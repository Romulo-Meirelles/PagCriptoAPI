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

    Public Class CreatePayment
        Inherits PagCriptoResponse

        <JsonProperty("payment-details")>
        Public Property Payment_Details As PD_

        <JsonProperty("customer-details")>
        Public Property Customer_Details As CD_

        Class PD_
            <JsonProperty("currency")>
            Public Property Currency As String

            <JsonProperty("address")>
            Public Property Address As String

            <JsonProperty("payment_request")>
            Public Property Payments_Request As String

            <JsonProperty("amount")>
            Public Property Amount As String
        End Class
        Class CD_
            <JsonProperty("description")>
            Public Property Description As String

            <JsonProperty("callback")>
            Public Property CallBack As String
        End Class



        Public Overrides Function ToString() As String
            Dim A As String = String.Empty
            A = "----- Payment Details -----" & vbCrLf
            A += "Currency: " & Payment_Details.Currency & vbCrLf &
                "Address: " & Payment_Details.Address & vbCrLf &
                "Payment Request: " & Payment_Details.Payments_Request & vbCrLf &
                "Amount: " & Payment_Details.Amount & vbCrLf & vbCrLf

            A += "----- Custumer Details -----" & vbCrLf
            A += "Description: " & Customer_Details.Description & vbCrLf &
                "CallBack: " & Customer_Details.CallBack & vbCrLf & vbCrLf

            Return A
            End Function
        End Class
End Namespace