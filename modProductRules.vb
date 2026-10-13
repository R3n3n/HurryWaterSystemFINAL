Imports System.Globalization
Imports System.Text.RegularExpressions

''' <summary>
''' Which containers belong to which product category. Used by the product form so the rules live in one place.
'''   Gallon  -> Round, Slim (plus any gallon container the owner added later)
'''   Bottled -> bottle sizes in mL (350mL, 500mL, ...). A size typed in litres is stored in mL (1L -> 1000mL)
'''   any other category the owner creates -> no built-in rule, only containers already used under it
''' </summary>
Module modProductRules

    Public Const CATEGORY_GALLON As String = "Gallon"
    Public Const CATEGORY_BOTTLED As String = "Bottled"

    Private ReadOnly VolumePattern As New Regex("^(\d+(?:\.\d+)?)\s*(ml|l)$", RegexOptions.IgnoreCase Or RegexOptions.Compiled)

    Public Function IsGallonCategory(category As String) As Boolean
        Return String.Equals(category, CATEGORY_GALLON, StringComparison.OrdinalIgnoreCase)
    End Function

    Public Function IsBottledCategory(category As String) As Boolean
        Return String.Equals(category, CATEGORY_BOTTLED, StringComparison.OrdinalIgnoreCase)
    End Function

    ''' <summary>The containers a category always offers.</summary>
    Public Function DefaultContainersFor(category As String) As String()
        If IsGallonCategory(category) Then Return New String() {"Round", "Slim"}
        If IsBottledCategory(category) Then Return New String() {"350mL", "500mL"}
        Return New String() {}
    End Function

    ''' <summary>
    ''' True when the text is a bottle size: 350mL, 500 ml, 1L, 1.5 L ...
    ''' normalized is the size in mL ("1.5 L" -> "1500mL"). Sizes must be whole mL between 1 and 20000.
    ''' </summary>
    Public Function TryParseVolume(text As String, ByRef normalized As String) As Boolean
        normalized = ""
        If text Is Nothing Then Return False

        Dim m As Match = VolumePattern.Match(text.Trim())
        If Not m.Success Then Return False

        Dim amount As Decimal
        If Not Decimal.TryParse(m.Groups(1).Value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, amount) Then Return False
        If m.Groups(2).Value.Equals("l", StringComparison.OrdinalIgnoreCase) Then amount *= 1000D

        If amount < 1D OrElse amount > 20000D OrElse amount <> Math.Floor(amount) Then Return False

        normalized = CInt(amount).ToString(CultureInfo.InvariantCulture) & "mL"
        Return True
    End Function

    ''' <summary>"" when the container suits the category, otherwise the message to show the user.</summary>
    Public Function ContainerProblem(category As String, container As String) As String
        Dim size As String = ""
        Dim isSize As Boolean = TryParseVolume(container, size)

        If IsGallonCategory(category) AndAlso isSize Then
            Return "That is a bottle size. Use the Bottled category for mL products."
        End If
        If IsBottledCategory(category) AndAlso Not isSize Then
            Return "Bottled containers are sizes such as 350mL, 500mL or 1L."
        End If
        Return ""
    End Function

End Module
