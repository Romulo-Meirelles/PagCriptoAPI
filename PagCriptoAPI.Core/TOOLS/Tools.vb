Namespace Core
    Module Tools
#Region "Tools"
        Friend Function http_build_query(ByVal ParameterNames() As String, ByVal ParameterValues() As String) As String
            Dim sRet As String = ""
            If ParameterNames.Length <> ParameterValues.Length Then Throw New System.Exception("The parameter arrays do not match.")
            For i As Integer = 0 To ParameterNames.Length - 1
                If IsNothing(ParameterNames(i)) OrElse IsNothing(ParameterValues(i)) Then Continue For
                sRet = String.Concat(sRet, IIf(sRet = "", "", "&"), ParameterNames(i), "=", ParameterValues(i))
            Next
            Return sRet
        End Function
        Friend Function TimeToUnix(ByVal dteDate As Date) As String
            Try
                If dteDate.IsDaylightSavingTime = True Then
                    dteDate = DateAdd(DateInterval.Hour, -1, dteDate)
                End If
                TimeToUnix = DateDiff(DateInterval.Second, #1/1/1970#, dteDate)
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function
        Friend Function UnixToTime(ByVal strUnixTime As String) As Date
            Try
                If strUnixTime.Length > 10 Then
                    strUnixTime = strUnixTime.Substring(0, 10)
                End If
                UnixToTime = DateAdd(DateInterval.Second, CDbl(strUnixTime), #1/1/1970#)
                If UnixToTime.IsDaylightSavingTime = True Then
                    UnixToTime = DateAdd(DateInterval.Hour, 1, UnixToTime)
                End If
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function
#End Region
    End Module
End Namespace
