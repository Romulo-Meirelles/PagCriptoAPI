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

    Public Class Balance
        Inherits PagCriptoResponse

        <JsonProperty("currency")>
        Public Property Currency As String

        <JsonProperty("current")>
        Public Property Current As Double

        <JsonProperty("orders")>
        Public Property Orders As Double

        <JsonProperty("withdraw_fee")>
        Public Property Withdraw_Fee As Integer

        <JsonProperty("trade_fee")>
        Public Property Trade_Fee As Integer

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty
            A = "Currency: " & Currency & vbCrLf &
                "Current: " & Current & vbCrLf &
                "Orders: " & Orders & vbCrLf &
                "Withdraw Fee: " & Withdraw_Fee & vbCrLf &
                "Trade Fee: " & Trade_Fee & vbCrLf & vbCrLf
            Return A
        End Function
    End Class
End Namespace