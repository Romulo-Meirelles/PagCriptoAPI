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
    Public Class Order
        Inherits PagCriptoResponse

        <JsonProperty("data")>
        Public Property PCData As PCDATA_
        Class PCDATA_
            <JsonProperty("pair")>
            Public Property Pair As String

            <JsonProperty("bids")>
            Public Property Bids As List(Of Lista_)

            <JsonProperty("asks")>
            Public Property Asks As List(Of Lista_)

            Class Lista_
                <JsonProperty("nick")>
                Public Property Nick As String

                <JsonProperty("amount")>
                Public Property Quantidade As String

                <JsonProperty("price")>
                Public Property Cotacao As String
            End Class


        End Class
        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            A += "Par: " + PCData.Pair & vbCrLf &
                "------- Bids -------" & vbCrLf

            For i = 0 To PCData.Bids.Count - 1
                A += "Nick: " & PCData.Bids(i).Nick & vbCrLf &
                     "Quantidade: " & PCData.Bids(i).Quantidade & vbCrLf &
                     "Cotação: " & PCData.Bids(i).Cotacao & vbCrLf & vbCrLf
            Next

            A += vbCrLf & "------- Asks ------- " & vbCrLf
            For i = 0 To PCData.Asks.Count - 1
                A += "Nick: " & PCData.Asks(i).Nick & vbCrLf &
                     "Quantidade: " & PCData.Asks(i).Quantidade & vbCrLf &
                     "Cotação: " & PCData.Asks(i).Cotacao & vbCrLf & vbCrLf
            Next

            Return A
        End Function
    End Class
End Namespace