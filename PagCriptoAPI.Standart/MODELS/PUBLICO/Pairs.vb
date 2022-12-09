Imports Newtonsoft.Json

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
    Public Class Pairs
        Inherits PagCriptoResponse

        <JsonProperty("available_pairs")>
        Public Property Available_Pairs As List(Of Available)

        <JsonProperty("last_update")>
        Public Property Last_Update As String

        Class Available
            <JsonProperty("label")>
            Public Property Label As String

            <JsonProperty("key")>
            Public Property Key As String
        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty
            For i = 0 To Available_Pairs.Count - 1
                A += "Ativos Label: " & Available_Pairs(i).Label & vbCrLf &
                    "Ativos Key: " & Available_Pairs(i).Key & vbCrLf & vbCrLf
            Next
            A += "Última Atualização: " & Last_Update
            Return A
        End Function
    End Class
End Namespace