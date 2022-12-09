
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
    Public Interface IPagCriptoClient
        Inherits IDisposable

#Region "PUBLIC"
        Function Order(ByVal Par As String) As Task(Of Order)
        Function Ticker(ByVal Par As String) As Task(Of Ticker)
        Function Tickers() As Task(Of Tickers)
        Function Trades(ByVal Par As String) As Task(Of Trades)
        Function Pairs() As Task(Of pairs)
#End Region
#Region "TRADER"
        Function CreateOrder(ByVal Par As String, ByVal Quantity As Double, Price As Double, ByVal Order As String) As Task(Of CreateOrder)
        Function CancelOrder(ByVal Par As String, ByVal IdOrder As String) As Task(Of CancelOrder)
        Function Balance() As Task(Of List(Of Balance))
        Function GetBookOrders(ByVal Par As String) As Task(Of GetBookOrders)
        Function GetAggregateOrders(Optional ByVal Page As Integer = Nothing, Optional ByVal Per_Page As Integer = Nothing) As Task(Of GetAggregateOrders)
        Function StatusOrder(ByVal IdOrder As String, Optional ByVal Par As String = "BTCBRL") As Task(Of StatusOrder)
        Function History(Optional ByVal Page As Integer = Nothing, Optional ByVal Par As String = "BTCBRL") As Task(Of History)
#End Region
#Region "GATEWAY"
        Function CreatePayment(ByVal Currency As String, ByVal Amount As Double, ByVal Description As String, ByVal CallBack As String) As Task(Of CreatePayment)
        Function CheckPayment(ByVal Payment_Request_Id As String) As Task(Of CheckPayment)
        Function CancelPayment(ByVal Payment_Request_Id As String) As Task(Of CancelPayment)
        Function GetListPayment() As Task(Of List(Of GetListPayments))
#End Region
#Region "OTC"
        Function Ticker_OTC(ByVal Par As String) As Task(Of Ticker_OTC)
        Function RFQ_OTC(ByVal Currency As String, ByVal Order As String, ByVal Quantity As Double) As Task(Of RFQ_OTC)
        Function Trade_OTC(ByVal Quote_Id As String, Optional ByVal Amount As Double = 0.00000000) As Task(Of Trade_OTC)
        Function History_OTC(Optional ByVal Page As Integer = Nothing) As Task(Of History_OTC)
#End Region

    End Interface
End Namespace
