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
    Public Class Tickers
        Inherits PagCriptoResponse

        '<JsonExtensionData>
        <JsonProperty("data")>
        Public Property Data As List(Of Status)

        '<JsonExtensionData>
        'Public Property Crypto As IDictionary(Of String, JsonToken)
        Class Status
            <JsonProperty("id")>
            Public Property Id As String

            <JsonProperty("quantity")>
            Public Property Quantity As String

            <JsonProperty("price")>
            Public Property Price As String

            <JsonProperty("order")>
            Public Property Order As String

            <JsonProperty("status")>
            Public Property Status As String
        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            'For Each element In Data(0)
            '    A += element.Key & ": " & vbCrLf &
            '        "High: " & element.Value.High & vbCrLf &
            '        "Low: " & element.Value.High & vbCrLf &
            '        "Volume: " & element.Value.High & vbCrLf &
            '        "Volume OCT: " & element.Value.High & vbCrLf &
            '        "Trades Quantidade: " & element.Value.High & vbCrLf &
            '        "Last: " & element.Value.High & vbCrLf &
            '        "Sell: " & element.Value.High & vbCrLf &
            '        "Buy: " & element.Value.High & vbCrLf & vbCrLf
            'Next
            Return A
        End Function
    End Class
End Namespace