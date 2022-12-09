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

    Public Class History
        Inherits PagCriptoResponse

        <JsonProperty("pagination")>
        Public Property Pagination As Pagination_
        Class Pagination_
            <JsonProperty("current_page")>
            Public Property Current_Page As Integer

            <JsonProperty("total_pages")>
            Public Property Total_Page As Integer

            <JsonProperty("per_page")>
            Public Property Per_Page As Integer

            <JsonProperty("total_records")>
            Public Property Total_Records As Integer

        End Class

        <JsonProperty("history")>
        Public Property History As List(Of History_)
        Class History_

            <JsonProperty("pair")>
            Public Property Pair As String

            <JsonProperty("quantity")>
            Public Property Quantity As String

            <JsonProperty("price")>
            Public Property Price As String

            <JsonProperty("total")>
            Public Property Total As String

            <JsonProperty("order")>
            Public Property Order As String

            <JsonProperty("tax")>
            Public Property Tax As String

            <JsonProperty("date")>
            Public Property Data As String
        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            A = "Current Page: " & Pagination.Current_Page & vbCrLf &
                                 "Total Page: " & Pagination.Total_Page & vbCrLf &
                                 "Per Page: " & Pagination.Per_Page & vbCrLf &
                                 "Total Records: " & Pagination.Total_Records & vbCrLf & vbCrLf

            For i = 0 To History.Count - 1
                A += "Pair: " & History(i).Pair & vbCrLf &
                                  "Quantity: " & History(i).Quantity & vbCrLf &
                                  "Price: " & History(i).Price & vbCrLf &
                                  "Total: " & History(i).Total & vbCrLf &
                                  "Order: " & History(i).Order & vbCrLf &
                                  "Tax: " & History(i).Tax & vbCrLf &
                                  "Date: " & History(i).Data & vbCrLf & vbCrLf
            Next
            Return A
        End Function
    End Class
End Namespace