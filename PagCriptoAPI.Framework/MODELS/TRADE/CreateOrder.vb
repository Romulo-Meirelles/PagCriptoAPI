Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Framework
    ''' <summary>
    ''' *** MADE FOR GITHUB ***
    ''' WRITTEN BY ROMULO MEIRELLES.
    ''' UPWORK: https://www.upwork.com/freelancers/~01fcbc5039ac5766b4
    ''' CONTACT WHATSAPP: https://wa.me/message/KWIS3BYO6K24N1
    ''' CONTACT TELEGRAM: https://t.me/Romulo_Meirelles
    ''' GITHUB: https://github.com/Romulo-Meirelles
    ''' DISCORD: đąяķňέs§¢øďε#2786
    ''' </summary>
    ''' <remarks></remarks>

    Public Class CreateOrder
        Inherits PagCriptoResponse

        <JsonProperty("Currency")>
        Public Property Currency As String

        <JsonProperty("id")>
        Public Property Id As String

        <JsonProperty("quantity")>
        Public Property Quantity As String

        <JsonProperty("price")>
        Public Property Price As String

        <JsonProperty("order")>
        Public Property Order As String

        <JsonProperty("status")>
        Public Property Status As String

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty
            A = "Currency: " & Currency & vbCrLf &
                "Id: " & Id & vbCrLf &
                "Quantity: " & Quantity & vbCrLf &
                "Price: " & Price & vbCrLf &
                "Order: " & Order & vbCrLf &
                "Status: " & Status & vbCrLf & vbCrLf
            Return A
        End Function
    End Class
End Namespace