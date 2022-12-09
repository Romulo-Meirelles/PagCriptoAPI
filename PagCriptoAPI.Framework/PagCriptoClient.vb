Imports System.Net.Http
Imports System.Reflection
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

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
    ''' 
    Public Class PagCriptoClient : Implements IPagCriptoClient

        Private ReadOnly _Requester As IRequester
        Public Sub New(ByVal Requester As IRequester)
            _Requester = Requester
        End Sub
        Public Shared Function Create(ByVal Config As ApiConfig, ByVal Optional Client As HttpClient = Nothing) As PagCriptoClient
            Dim Requester = HttpClientRequester.Create(Config, Client)
            Return New PagCriptoClient(Requester)
        End Function

#Region "PUBLIC"
        Public Async Function Orders(ByVal Par As String) As Task(Of Order) Implements IPagCriptoClient.Order
            Return Await _Requester.Post(Of Order)("public/orders/" & Par, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
        Public Async Function Ticker(ByVal Par As String) As Task(Of Ticker) Implements IPagCriptoClient.Ticker
            Return Await _Requester.Post(Of Ticker)("public/ticker/" & Par, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
        Public Async Function Tickers() As Task(Of Tickers) Implements IPagCriptoClient.Tickers
            Return Await _Requester.Post(Of Tickers)("public/tickers", New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
        Public Async Function Trades(ByVal Par As String) As Task(Of Trades) Implements IPagCriptoClient.Trades
            Return Await _Requester.Post(Of Trades)("public/trades/" & Par, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
        Public Async Function Pairs() As Task(Of Pairs) Implements IPagCriptoClient.Pairs
            Return Await _Requester.Post(Of Pairs)("public/pairs", New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
#End Region

#Region "TRADER"
        Public Async Function CreateOrder(ByVal Par As String, ByVal Quantity As Double, Price As Double, ByVal Order As String) As Task(Of CreateOrder) Implements IPagCriptoClient.CreateOrder
            _Requester.Configuration.Check()
            Dim BodyRequest As New Dictionary(Of String, String)
            BodyRequest.Add("quantity", Quantity.ToString)
            BodyRequest.Add("price", Price.ToString)
            BodyRequest.Add("order", Order)
            Dim R As IDictionary = Await _Requester.Post(Of IDictionary)("trade/create/" & Par, BodyRequest, HttpMethod.Post, True).ConfigureAwait(False)

            Dim K As New CreateOrder
            Dim MyList As New List(Of String)

            For Each element In R
                MyList.Add(element.Key)
                For Each item In element.Value
                    MyList.Add(item.Value)
                Next
            Next
            K.Currency = MyList(0)
            K.Id = MyList(1)
            K.Quantity = MyList(2)
            K.Price = MyList(3)
            K.Order = MyList(4)
            K.Status = MyList(5)

            Return K
        End Function
        Public Async Function CancelOrder(ByVal Par As String, ByVal IdOrder As String) As Task(Of CancelOrder) Implements IPagCriptoClient.CancelOrder
            _Requester.Configuration.Check()
            Dim BodyRequest As New Dictionary(Of String, String)
            BodyRequest.Add("idOrder", IdOrder)
            Return Await _Requester.Post(Of CancelOrder)("trade/cancel/" & Par, BodyRequest, HttpMethod.Post).ConfigureAwait(False)
        End Function
        Public Async Function Balance() As Task(Of List(Of Balance)) Implements IPagCriptoClient.Balance
            _Requester.Configuration.Check()
            Dim R = Await _Requester.Post(Of IDictionary)("trade/balance", New Dictionary(Of String, String), HttpMethod.Get, True).ConfigureAwait(False)
            Dim MyList As New List(Of Balance)
            For Each element In R.Item("balance")
                MyList.Add(New Balance() With {.Currency = element.Key,
                           .Current = element.Value("current"),
                           .Orders = element.Value("orders"),
                           .Withdraw_Fee = element.Value("whitdraw_fee"),
                           .Trade_Fee = element.Value("trade_fee")})
            Next
            Return MyList
        End Function
        Public Async Function GetBookOrders(ByVal Par As String) As Task(Of GetBookOrders) Implements IPagCriptoClient.GetBookOrders
            _Requester.Configuration.Check()
            Return Await _Requester.Post(Of GetBookOrders)("trade/orders/" & Par, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
        Public Async Function GetAggregateOrders(Optional ByVal Page As Integer = Nothing, Optional ByVal Per_Page As Integer = Nothing) As Task(Of GetAggregateOrders) Implements IPagCriptoClient.GetAggregateOrders
            _Requester.Configuration.Check()
            Dim BodyRequest As String = http_build_query({"page", "per_page"}, {Page, Per_Page})
            Return Await _Requester.Post(Of GetAggregateOrders)("trade/aggregate_orders?" & BodyRequest, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
        Public Async Function StatusOrder(ByVal IdOrder As String, Optional Par As String = "BTCBRL") As Task(Of StatusOrder) Implements IPagCriptoClient.StatusOrder
            _Requester.Configuration.Check()
            Dim BodyRequest As New Dictionary(Of String, String)
            BodyRequest.Add("idOrder", IdOrder)
            Return Await _Requester.Post(Of StatusOrder)("trade/status/" & Par, New Dictionary(Of String, String), HttpMethod.Post).ConfigureAwait(False)
        End Function
        Public Async Function History(Optional ByVal Page As Integer = Nothing, Optional Par As String = "BTCBRL") As Task(Of History) Implements IPagCriptoClient.History
            _Requester.Configuration.Check()
            Dim BodyRequest As String = http_build_query({"page"}, {Page})
            Return Await _Requester.Post(Of History)("trade/history/" & Par & "?" & BodyRequest, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
#End Region

#Region "GATEWAY"
        Public Async Function CreatePayment(ByVal Currency As String, ByVal Amount As Double, ByVal Description As String, ByVal CallBack As String) As Task(Of CreatePayment) Implements IPagCriptoClient.CreatePayment
            _Requester.Configuration.Check()
            Dim BodyRequest As New Dictionary(Of String, String)
            BodyRequest.Add("currency", Currency)
            BodyRequest.Add("amount", Amount)
            BodyRequest.Add("description", Description)
            BodyRequest.Add("callback", CallBack)
            Return Await _Requester.Post(Of CreatePayment)("gateway/createPayment", BodyRequest, HttpMethod.Post).ConfigureAwait(False)
        End Function
        Public Async Function CheckPayment(ByVal Payment_Request_Id As String) As Task(Of CheckPayment) Implements IPagCriptoClient.CheckPayment
            _Requester.Configuration.Check()
            Dim BodyRequest As String = http_build_query({"payment_request"}, {Payment_Request_Id})
            Return Await _Requester.Post(Of CheckPayment)("gateway/checkPayment?" & BodyRequest, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
        Public Async Function CancelPayment(ByVal Payment_Request_Id As String) As Task(Of CancelPayment) Implements IPagCriptoClient.CancelPayment
            _Requester.Configuration.Check()
            Dim BodyRequest As New Dictionary(Of String, String)
            BodyRequest.Add("payment_request", Payment_Request_Id)
            Return Await _Requester.Post(Of CancelPayment)("gateway/cancelPayment", BodyRequest, HttpMethod.Post).ConfigureAwait(False)
        End Function
        Public Async Function GetListPayment() As Task(Of List(Of GetListPayments)) Implements IPagCriptoClient.GetListPayment
            _Requester.Configuration.Check()
            Return Await _Requester.Post(Of List(Of GetListPayments))("gateway/listPayments", New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
#End Region

#Region "OTC"

        Public Async Function Ticker_OTC(ByVal Par As String) As Task(Of Ticker_OTC) Implements IPagCriptoClient.Ticker_OTC
            Return Await _Requester.Post(Of Ticker_OTC)("otc/ticker/" & Par, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
        Public Async Function RFQ_OTC(ByVal Currency As String, ByVal Order As String, ByVal Quantity As Double) As Task(Of RFQ_OTC) Implements IPagCriptoClient.RFQ_OTC
            _Requester.Configuration.Check()
            Dim BodyRequest As New Dictionary(Of String, String)
            BodyRequest.Add("currency", Currency)
            BodyRequest.Add("order", Order)
            BodyRequest.Add("quantity", Quantity)
            Return Await _Requester.Post(Of RFQ_OTC)("otc/rfq", BodyRequest, HttpMethod.Post).ConfigureAwait(False)
        End Function
        Public Async Function Trade_OTC(ByVal Quote_Id As String, Optional ByVal Amount As Double = 0.00000000) As Task(Of Trade_OTC) Implements IPagCriptoClient.Trade_OTC
            _Requester.Configuration.Check()
            Dim BodyRequest As New Dictionary(Of String, String)
            BodyRequest.Add("quote_id", Quote_Id)
            BodyRequest.Add("amount", Amount)
            Return Await _Requester.Post(Of Trade_OTC)("otc/trade", BodyRequest, HttpMethod.Post).ConfigureAwait(False)
        End Function
        Public Async Function History_OTC(Optional ByVal Page As Integer = Nothing) As Task(Of History_OTC) Implements IPagCriptoClient.History_OTC
            _Requester.Configuration.Check()
            Dim BodyRequest As String = http_build_query({"page"}, {Page})
            Return Await _Requester.Post(Of History_OTC)("otc/history?" & BodyRequest, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function
#End Region

        Enum Status_Desc
            Aguardando = 0
            Parcialmente_Executado = 1
            Completamente_Executado = 2
            Cancelado = 3
        End Enum

        Public Sub Dispose() Implements IPagCriptoClient.Dispose
            Dim Disposable As IDisposable = Nothing

            If [Implements].Assign(Disposable, TryCast(_Requester, IDisposable)) IsNot Nothing Then
                Disposable.Dispose()
            End If
        End Sub
        Private Class [Implements]
            Shared Function Assign(Of T)(ByRef Target As T, Value As T) As T
                Target = Value
                Return Value
            End Function
        End Class

    End Class
End Namespace
