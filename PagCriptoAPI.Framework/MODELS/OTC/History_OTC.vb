Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
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

    Public Class History_OTC
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

            <JsonProperty("coin")>
            Public Property Coin As String

            <JsonProperty("quote_id")>
            Public Property Quote_Id As String

            <JsonProperty("order")>
            Public Property Order As String

            <JsonProperty("price")>
            Public Property Price As String

            <JsonProperty("quantity")>
            Public Property Quantity As String

            <JsonProperty("quote_size")>
            Public Property Quote_Size As String

            <JsonProperty("executed_at")>
            Public Property Executed_At As String
        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            A = "Current Page: " & Pagination.Current_Page & vbCrLf &
                                 "Total Page: " & Pagination.Total_Page & vbCrLf &
                                 "Per Page: " & Pagination.Per_Page & vbCrLf &
                                 "Total Records: " & Pagination.Total_Records & vbCrLf & vbCrLf

            For i = 0 To History.Count - 1
                A += "Coin: " & History(i).Coin & vbCrLf &
                                  "Quote Id: " & History(i).Quote_Id & vbCrLf &
                                  "Order: " & History(i).Order & vbCrLf &
                                  "Price: " & History(i).Price & vbCrLf &
                                  "Quantity: " & History(i).Quantity & vbCrLf &
                                  "Quote Size: " & History(i).Quote_Size & vbCrLf &
                                  "Executed At: " & History(i).Executed_At & vbCrLf & vbCrLf
            Next
            Return A
        End Function
    End Class
End Namespace