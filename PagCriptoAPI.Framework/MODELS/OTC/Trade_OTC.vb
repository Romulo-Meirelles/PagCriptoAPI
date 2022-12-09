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

    Public Class Trade_OTC
        Inherits PagCriptoResponse

        <JsonProperty("trade")>
        Public Property Trade As QUOTEID_

        Class QUOTEID_
            <JsonProperty("quote_id")>
            Public Property Quote_Id As String

            <JsonProperty("response")>
            Public Property Response As RESPONSE_

            Class RESPONSE_
                <JsonProperty("success")>
                Public Property Success As String

                <JsonProperty("message")>
                Public Property Message As String
            End Class

        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty
            A += "Quote Id: " & Trade.Quote_Id & vbCrLf &
            "Success: " & Trade.Response.Success & vbCrLf &
            "Message: " & Trade.Response.Message & vbCrLf & vbCrLf
            Return A
        End Function
    End Class
End Namespace