Imports System.Net.Http
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
    Public MustInherit Class RequesterBase
        Implements IRequester

        Public MustOverride Function Post(Of T As Class)(ByVal resource As String, ByVal Optional parameters As Dictionary(Of String, String) = Nothing, Optional Method As HttpMethod = Nothing, Optional ByVal IsIDictionary As Boolean = False, ByVal Optional noThrow As Boolean = False) As Task(Of T) Implements IRequester.Post
        Public ReadOnly Property Configuration As ApiConfig Implements IRequester.Configuration
        Public Sub New(ByVal configuration As ApiConfig)
            Me.Configuration = configuration
        End Sub
        Private Shared ReadOnly Settings As JsonSerializerSettings = New JsonSerializerSettings With {
                .ContractResolver = New DefaultContractResolver With {.NamingStrategy = New SnakeCaseNamingStrategy()}}
        Protected Overridable Function Deserialize(Of T)(json As String) As T
            Try
                Return JsonConvert.DeserializeObject(Of T)(json, Settings)
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Protected Overridable Function DeserializeDictionary(Of IDictionary)(json As String) As IDictionary
            Try
                Return JsonConvert.DeserializeObject(Of IDictionary)(json, Settings)
            Catch ex As Exception
                Return Nothing
            End Try

        End Function
        Protected Overridable Function Serialize(ByVal obj As Object) As String
            Return JsonConvert.SerializeObject(obj, Settings)
        End Function
        Protected Iterator Function CreateParameterPairs(ByVal Optional source As IEnumerable(Of KeyValuePair(Of String, String)) = Nothing) As IEnumerable(Of KeyValuePair(Of String, String))
            If source Is Nothing Then Return

            For Each item In source
                Yield item
            Next
        End Function
        Public Shared Sub HandleError(ByVal Code As String, ByVal Message As String, ByVal Optional innerException As Exception = Nothing, ByVal Optional noThrow As Boolean = False)
            If noThrow Then Return
            If Not IsNothing(Code) Then Throw New PagCriptoException(Message, 0, innerException)
        End Sub

    End Class
End Namespace
