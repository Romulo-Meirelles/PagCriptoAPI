Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json.Serialization

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

    Public Class StatusOrder
        Inherits PagCriptoResponse

        <JsonProperty("pair")>
        Public Property Pair As String

        <JsonProperty("id")>
        Public Property Id As String

        <JsonProperty("status")>
        Public Property Status As Integer

        <JsonProperty("preco_total")>
        Public Property Preco_Total As Double

        <JsonProperty("qnt_executada")>
        Public Property Quantidade_Executada As Double

        <JsonProperty("qnt_total")>
        Public Property Quantidade_Total As Double

        <JsonProperty("tipo")>
        Public Property Tipo As Integer

        <JsonProperty("create_date")>
        Public Property Create_Date As String

        <JsonProperty("update_date")>
        Public Property Update_Date As String

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            A = "Pair: " & Pair & vbCrLf &
                "Id: " & Id & vbCrLf &
                "Status: " & Status & vbCrLf &
                "Preço Total: " & Preco_Total & vbCrLf &
                "Quantidade Executada: " & Quantidade_Executada & vbCrLf &
                "Quantidade Total: " & Quantidade_Total & vbCrLf &
                "Tipo: " & Tipo & vbCrLf &
                "Created Date: " & Create_Date & vbCrLf &
                "Updated Date: " & Update_Date & vbCrLf & vbCrLf

            Return A
        End Function
    End Class
End Namespace