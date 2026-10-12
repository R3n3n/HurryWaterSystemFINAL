Imports MySql.Data.MySqlClient
Module modSchemaUpdates

    Public Function EnsureProductColumnsFlexible() As Boolean
        Try
            connection()

            sql = "SELECT COUNT(*) FROM information_schema.COLUMNS " &
                  "WHERE TABLE_SCHEMA = DATABASE() AND LOWER(TABLE_NAME) = 'tblproducts' " &
                  "AND COLUMN_NAME IN ('category', 'containerType', 'waterType') AND DATA_TYPE = 'enum'"
            cmd = New MySqlCommand(sql, cn)
            Dim enumColumns As Long = CLng(cmd.ExecuteScalar())

            If enumColumns = 0 Then Return True

            sql = "ALTER TABLE tblproducts " &
                  "MODIFY category VARCHAR(30) NOT NULL, " &
                  "MODIFY containerType VARCHAR(30) NOT NULL, " &
                  "MODIFY waterType VARCHAR(30) NOT NULL"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Couldn't prepare the products table for new products: " & ex.Message & vbCrLf & vbCrLf &
                   "You can run Database\products_flexible_columns.sql in phpMyAdmin instead.",
                   MsgBoxStyle.Critical, "Database update")
            Return False
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Public Function EnsureOrderAuditColumns() As Boolean
        Try
            connection()

            If Not ColumnExists("tblsalesorders", "handledBy") Then
                sql = "ALTER TABLE tblsalesorders ADD COLUMN handledBy INT NULL"
                cmd = New MySqlCommand(sql, cn)
                cmd.ExecuteNonQuery()
            End If

            If Not ColumnExists("tblsalesorders", "handledAt") Then
                sql = "ALTER TABLE tblsalesorders ADD COLUMN handledAt DATETIME NULL"
                cmd = New MySqlCommand(sql, cn)
                cmd.ExecuteNonQuery()
            End If

            Return True
        Catch ex As Exception
            MsgBox("Couldn't add the 'handled by' columns to the orders table: " & ex.Message & vbCrLf & vbCrLf &
                   "You can run Database\order_audit_columns.sql in phpMyAdmin instead.",
                   MsgBoxStyle.Critical, "Database update")
            Return False
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Public Function EnsureExpenseStockLink() As Boolean
        Try
            connection()

            If Not ColumnExists("tblexpenses", "stockTransactionId") Then
                sql = "ALTER TABLE tblexpenses ADD COLUMN stockTransactionId INT NULL"
                cmd = New MySqlCommand(sql, cn)
                cmd.ExecuteNonQuery()
            End If

            Return True
        Catch ex As Exception
            MsgBox("Couldn't link expenses to stock-ins: " & ex.Message & vbCrLf & vbCrLf &
                   "You can run Database\order_void_and_stock_expense.sql in phpMyAdmin instead.",
                   MsgBoxStyle.Critical, "Database update")
            Return False
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Function ColumnExists(tableName As String, columnName As String) As Boolean
        sql = "SELECT COUNT(*) FROM information_schema.COLUMNS " &
              "WHERE TABLE_SCHEMA = DATABASE() AND LOWER(TABLE_NAME) = @t AND COLUMN_NAME = @c"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@t", tableName.ToLower())
        cmd.Parameters.AddWithValue("@c", columnName)
        Return CLng(cmd.ExecuteScalar()) > 0
    End Function

End Module
