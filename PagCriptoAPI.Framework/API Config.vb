
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
    Public Class ApiConfig
        Public Property TokenAPI As String
        Public Property BaseUrl As String = "https://api.pagcripto.com.br/v2/"
        Public Sub Check()
            If String.IsNullOrEmpty(TokenAPI) Then Throw New ArgumentException("The Token API PagCripto key is missing.", NameOf(ApiConfig.TokenAPI))
        End Sub
    End Class
End Namespace
