Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Standard
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

    Public Class GetListPayments
        Inherits PagCriptoResponse

        <JsonProperty("currency")>
        Public Property Currency As String

        <JsonProperty("payment_request")>
        Public Property Payment_Request As String

        <JsonProperty("created-at")>
        Public Property Created_At As String

        <JsonProperty("amount")>
        Public Property Amount As String

        <JsonProperty("received_amount")>
        Public Property Received_Amount As String

        <JsonProperty("confirmations")>
        Public Property Confirmations As String

        <JsonProperty("description")>
        Public Property Description As String

        <JsonProperty("status")>
        Public Property Status As String

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            A = "----- List Payment -----" & vbCrLf
            A += "Currency: " & Currency & vbCrLf &
                "Payment Request: " & Payment_Request & vbCrLf &
                "Created At: " & Created_At & vbCrLf &
                "Amount: " & Amount & vbCrLf &
                "Received Amount: " & Received_Amount & vbCrLf &
                "Confirmations: " & Confirmations & vbCrLf &
                "Description: " & Description & vbCrLf &
                "Status: " & Status & vbCrLf & vbCrLf
            Return A
        End Function
    End Class
End Namespace