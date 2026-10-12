Module modOrderRules

    Public Const CountedOrders As String = "pickupStatus <> 'Missed'"
    Public Function FormatOrderNo(orderId As Integer) As String
        Return "ORD-" & orderId.ToString("00000")
    End Function

    Public Function PaymentRuleProblem(pickupStatus As String, paymentStatus As String) As String
        If paymentStatus = "Paid" AndAlso (pickupStatus = "Pending" OrElse pickupStatus = "Missed") Then
            Return "An order can't be marked Paid while its pickup status is " & pickupStatus & "." & vbCrLf &
                   "Mark it Picked-up or Delivered first, or set the payment back to Unpaid."
        End If
        Return ""
    End Function

End Module
