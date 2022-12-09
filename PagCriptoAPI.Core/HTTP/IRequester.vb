
Imports System.Net.Http

Namespace Core
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
    Public Interface IRequester
        ReadOnly Property Configuration As ApiConfig
        Function Post(Of T As Class)(Resource As String, Optional Parameters As Dictionary(Of String, String) = Nothing, Optional Method As HttpMethod = Nothing, Optional ByVal IsIDictionary As Boolean = False, Optional noThrow As Boolean = False) As Task(Of T)
    End Interface
End Namespace
