Imports Newtonsoft.Json

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
    Public Class Trades
        Inherits PagCriptoResponse

        '<JsonExtensionData>
        <JsonProperty("data")>
        Public Property Data As Data_

        Class Data_
            <JsonProperty("pair")>
            Public Property Pair As String

            <JsonProperty("trades")>
            Public Property Trades As List(Of Result)

            Class Result
                <JsonProperty("date")>
                Public Property [Date] As String

                <JsonProperty("nick")>
                Public Property Nick_Buyer As String

                <JsonProperty("nickv")>
                Public Property Nick_Seller As String

                <JsonProperty("amount")>
                Public Property Amount As String

                <JsonProperty("price")>
                Public Property Price As String

                <JsonProperty("order")>
                Public Property Order As String
            End Class

        End Class
        Public Overrides Function ToString() As String
            Dim A As String = String.Empty
            A += "------- Par ------- " & Data.Pair & vbCrLf
            For i = 0 To Data.Trades.Count - 1
                A += "Data: " & Data.Trades(i).Date & vbCrLf &
                    "Nick Comprador: " & Data.Trades(i).Nick_Buyer & vbCrLf &
                    "Nick Vendedor: " & Data.Trades(i).Nick_Seller & vbCrLf &
                    "Quantidade: " & Data.Trades(i).Amount & vbCrLf &
                    "Preço: " & Data.Trades(i).Price & vbCrLf &
                    "Ordem: " & Data.Trades(i).Order & vbCrLf & vbCrLf
            Next
            Return A
        End Function
    End Class
End Namespace