Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Net
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

    Public Class RFQ_OTC
        Inherits PagCriptoResponse

        <JsonProperty("quote")>
        Public Property Quote As QUOTE_

        Class QUOTE_
            <JsonProperty("currency")>
            Public Property Currency As String

            <JsonProperty("quote_id")>
            Public Property Quote_Id As String

            <JsonProperty("quantity")>
            Public Property Quantity As String

            <JsonProperty("price")>
            Public Property Price As String

            <JsonProperty("quote_size")>
            Public Property Quote_Size As String

            <JsonProperty("order")>
            Public Property Order As String

            <JsonProperty("created_at")>
            Public Property Created_At As String

            <JsonProperty("expires_at")>
            Public Property Expires_At As String

        End Class


        Public Overrides Function ToString() As String
            Dim A As String = String.Empty
            A += "Currency: " & Quote.Currency & vbCrLf &
            "Quote Id: " & Quote.Quote_Id & vbCrLf &
            "Quantity: " & Quote.Quantity & vbCrLf &
            "Price: " & Quote.Price & vbCrLf &
            "Quote Size: " & Quote.Quote_Size & vbCrLf &
            "Order: " & Quote.Order & vbCrLf &
            "Created At: " & Quote.Created_At & vbCrLf &
            "Expires At: " & Quote.Expires_At & vbCrLf & vbCrLf
            Return A
        End Function
    End Class
End Namespace