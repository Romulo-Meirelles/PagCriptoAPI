Imports System.Runtime.Serialization

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
    ''' 
    Public Class PagCriptoException
        Inherits Exception
        Public ReadOnly Property StatusCode As Integer

        Public Sub New(ByVal message As String, ByVal statusCode As Integer, ByVal innerException As Exception)
            MyBase.New(message, innerException)
            Me.StatusCode = statusCode
        End Sub

    End Class
End Namespace
