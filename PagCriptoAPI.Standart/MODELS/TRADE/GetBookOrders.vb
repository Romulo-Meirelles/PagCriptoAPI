Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json.Serialization

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

    Public Class GetBookOrders
        Inherits PagCriptoResponse

        <JsonProperty("orders")>
        Public Property Orders As Pair

        Class Pair
            <JsonProperty("BTCBRL")>
            Public Property BTCBRL As MyOrders

            <JsonProperty("DOGEBTC")>
            Public Property DOGEBTC As MyOrders

            <JsonProperty("LTCBTC")>
            Public Property LTCBTC As MyOrders

            <JsonProperty("BCHBTC")>
            Public Property BCHBTC As MyOrders

            <JsonProperty("LTCBRL")>
            Public Property LTCBRL As MyOrders

            <JsonProperty("BCHBRL")>
            Public Property BCHBRL As MyOrders

            <JsonProperty("DASHBRL")>
            Public Property DASHBRL As MyOrders

            <JsonProperty("DASHBTC")>
            Public Property DASHBTC As MyOrders

            <JsonProperty("NANOBTC")>
            Public Property NANOBTC As MyOrders

            <JsonProperty("NANOBRL")>
            Public Property NANOBRL As MyOrders

            <JsonProperty("BTCUSDT")>
            Public Property BTCUSDT As MyOrders

            <JsonProperty("ETHBTC")>
            Public Property ETHBTC As MyOrders

            <JsonProperty("ETHUSDT")>
            Public Property ETHUSDT As MyOrders

            <JsonProperty("ETHBRL")>
            Public Property ETHBRL As MyOrders

            <JsonProperty("USDTBRL")>
            Public Property USDTBRL As MyOrders

            <JsonProperty("DOGEBRL")>
            Public Property DOGEBRL As MyOrders

            <JsonProperty("USDCBRL")>
            Public Property USDCBRL As MyOrders

            <JsonProperty("BNBBRL")>
            Public Property BNBBRL As MyOrders

            <JsonProperty("BUSDBRL")>
            Public Property BUSDBRL As MyOrders

            <JsonProperty("TRXBRL")>
            Public Property TRXBRL As MyOrders



        End Class
        Class MyOrders

            <JsonProperty("buy")>
            Public Property Buy As List(Of Itens)

            <JsonProperty("sell")>
            Public Property Sell As List(Of Itens)

        End Class
        Class Itens
            <JsonProperty("id")>
            Public Property Id As String

            <JsonProperty("qty")>
            Public Property Quantity As Double

            <JsonProperty("cot")>
            Public Property Cotation As Double

            <JsonProperty("status")>
            Public Property Status As String

        End Class

        <OnError>
        Friend Sub OnError(ByVal context As StreamingContext, ByVal errorContext As ErrorContext)
            errorContext.Handled = True
        End Sub
    End Class
End Namespace