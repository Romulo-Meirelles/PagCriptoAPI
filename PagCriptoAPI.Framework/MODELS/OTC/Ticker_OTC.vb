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

    Public Class Ticker_OTC
        Inherits PagCriptoResponse

        <JsonProperty("otc_ticker")>
        Public Property OTC_Ticker As OTCTICKER_

        Class OTCTICKER_
            <JsonProperty("crypto")>
            Public Property Crypto As String

            <JsonProperty("volume")>
            Public Property Volume As String

            <JsonProperty("last")>
            Public Property Last As String

            <JsonProperty("buy")>
            Public Property Buy As String

            <JsonProperty("sell")>
            Public Property Sell As String

        End Class


        Public Overrides Function ToString() As String
            Dim A As String = String.Empty
            A += "Crypto: " & OTC_Ticker.Crypto & vbCrLf &
            "Volume: " & OTC_Ticker.Volume & vbCrLf &
            "Last: " & OTC_Ticker.Last & vbCrLf &
            "Buy: " & OTC_Ticker.Buy & vbCrLf &
            "Sell: " & OTC_Ticker.Sell & vbCrLf & vbCrLf
            Return A
        End Function
        End Class
End Namespace