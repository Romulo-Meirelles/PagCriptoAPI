Imports Newtonsoft.Json

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
    Public Class Ticker
        Inherits PagCriptoResponse


        <JsonProperty("Data")>
        Public Property Data As Data_
        Class Data_
            <JsonProperty("pair")>
            Public Property Pair As String

            <JsonProperty("high")>
            Public Property High As String

            <JsonProperty("low")>
            Public Property Low As String

            <JsonProperty("volume")>
            Public Property Volume As String

            <JsonProperty("volume_otc")>
            Public Property Volume_OTC As String

            <JsonProperty("trades_qty")>
            Public Property Trades_Quantidade As String

            <JsonProperty("last")>
            Public Property Last As String

            <JsonProperty("sell")>
            Public Property Sell As String
            <JsonProperty("buy")>
            Public Property Buy As String

            <JsonProperty("date")>
            Public Property [Date] As String
        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            A += "Par: " & Data.Pair & vbCrLf &
                "High: " & Data.High & vbCrLf &
                "Low: " & Data.Low & vbCrLf &
                "Volume: " & Data.Volume & vbCrLf &
                "Volume OTC: " & Data.Volume_OTC & vbCrLf &
                "Trades Quantidade: " & Data.Trades_Quantidade & vbCrLf &
                "Last: " & Data.Last & vbCrLf &
                "Sell: " & Data.Sell & vbCrLf &
                "Buy: " & Data.Buy & vbCrLf &
                "Date: " & Data.Date & vbCrLf
            Return A
        End Function
    End Class
End Namespace