Imports System.Net.Http
Imports System.Net.Http.Headers

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

    Public Class HttpClientRequester
        Inherits RequesterBase
        Implements IDisposable

        Private ReadOnly _Client As HttpClient
        Private _DisposeClient As Boolean
        Public Sub New(ByVal Configuration As ApiConfig, ByVal Client As HttpClient)
            MyBase.New(Configuration)
            _Client = Client
        End Sub
        Public Overrides Async Function Post(Of T As Class)(Resource As String, Optional Parameters As Dictionary(Of String, String) = Nothing, Optional Method As HttpMethod = Nothing, Optional ByVal IsIDictionary As Boolean = False, Optional noThrow As Boolean = False) As Task(Of T)
            Dim Deserialized As Object
            Dim Result = Await CreateRequestAsync(Resource, Method, Parameters)
            Dim Response = Await Result.Content.ReadAsStringAsync()

            If Response.Contains("""code"":") And Response.Contains("""message"":") Then
                Deserialized = Deserialize(Of T)(Response)
                HandleError(Deserialized.Code, Deserialized.Message, noThrow:=noThrow)
            End If

            If Resource.Contains("trade/orders/") Then
                Response = Response.Replace("none", """[none]""")
            End If

            If IsIDictionary = True Then
                Deserialized = DeserializeDictionary(Of IDictionary(Of String, T))(Response)
                Return Deserialized
            End If

            Deserialized = Deserialize(Of T)(Response)
            Return Deserialized
        End Function
        Public Shared Sub ConfigureClient(Client As HttpClient, ByVal Configuration As ApiConfig)
            Client.BaseAddress = New Uri(Configuration.BaseUrl)
        End Sub
        Protected Friend Overridable Function CreateRequestAsync(ByVal Resource As String, ByVal Method As HttpMethod, ByVal Parameters As Dictionary(Of String, String)) As Task(Of HttpResponseMessage)
            If Resource.Contains("trade") OrElse Resource.Contains("gateway") OrElse Resource.Contains("otc") Then _Client.DefaultRequestHeaders.Add("X-Authentication", Configuration.TokenAPI)
            Dim content = New FormUrlEncodedContent(CreateParameterPairs(Parameters))
            Return _Client.SendAsync(New HttpRequestMessage(Method, New Uri(Resource, UriKind.Relative)) With {.Content = content})
        End Function
        Public Shared Function Create(ByVal Config As ApiConfig, ByVal Optional Client As HttpClient = Nothing, ByVal Optional DisposeClient As Boolean = False) As HttpClientRequester
            If Client Is Nothing Then DisposeClient = True
            Client = If(Client, New HttpClient())
            HttpClientRequester.ConfigureClient(Client, Config)
            Return New HttpClientRequester(Config, Client) With {._DisposeClient = DisposeClient}
        End Function
        Public Sub Dispose() Implements IDisposable.Dispose
            If _DisposeClient Then _Client.Dispose()
        End Sub
    End Class
End Namespace
