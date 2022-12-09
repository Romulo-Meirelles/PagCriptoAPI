Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Core
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

    Public Class CheckPayment
        Inherits PagCriptoResponse


        <JsonProperty("payment-request")>
        Public Property Payment_Request As String

        <JsonProperty("payment-details")>
        Public Property Payment_Details As PD_

        <JsonProperty("customer-details")>
        Public Property Customer_Details As CD_

        Class PD_
            <JsonProperty("currency")>
            Public Property Currency As String

            <JsonProperty("address")>
            Public Property Address As String

            <JsonProperty("amount")>
            Public Property Amount As String

            <JsonProperty("received_amount")>
            Public Property Received_Amount As String

            <JsonProperty("txid")>
            Public Property Txid As String

            <JsonProperty("confirmations")>
            Public Property Confirmations As String

            <JsonProperty("created-at")>
            Public Property Created_At As String

            <JsonProperty("received-at-at")>
            Public Property Received_At As String

            <JsonProperty("status")>
            Public Property Status As String
        End Class
        Class CD_
            <JsonProperty("description")>
            Public Property Description As String

            <JsonProperty("callbackUrl")>
            Public Property CallBackUrl As String
        End Class


        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            A = "----- Payment Request -----" & vbCrLf
            A += "Number: " & Payment_Request & vbCrLf & vbCrLf

            A += "----- Payment Details -----" & vbCrLf
            A += "Currency: " & Payment_Details.Currency & vbCrLf &
                "Address: " & Payment_Details.Address & vbCrLf &
                "Amount: " & Payment_Details.Amount & vbCrLf &
                "Received Amount: " & Payment_Details.Received_Amount & vbCrLf &
                "Txid: " & Payment_Details.Txid & vbCrLf &
                "Confirmations: " & Payment_Details.Confirmations & vbCrLf &
                "Created_At: " & Payment_Details.Created_At & vbCrLf &
                "Received At: " & Payment_Details.Received_At & vbCrLf &
                "Status: " & Payment_Details.Status & vbCrLf & vbCrLf

            A += "----- Custumer Details -----" & vbCrLf
            A += "Description: " & Customer_Details.Description & vbCrLf &
                "CallBack: " & Customer_Details.CallBackUrl & vbCrLf & vbCrLf

            Return A
        End Function
    End Class
End Namespace