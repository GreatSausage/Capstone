Imports MySql.Data.MySqlClient
Module MdlConnection
    Public conn As New MySqlConnection("server=localhost;user id=root;password=052903;database=dbmcpms;port=3306")
    Public ServerConn As New MySqlConnection
    Public com As New MySqlCommand
    Public adp As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public Sub OpenServerConnection()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub RunQuery(ByVal querystatement As String)
        Try
            OpenServerConnection()
            adp = New MySqlDataAdapter(querystatement, conn)
            ds = New DataSet
            adp.Fill(ds, "querytable")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub RunCommand(ByVal commandstatement As String, ParamArray dynamicParameters() As MySqlParameter)
        Try
            OpenServerConnection()
            com = New MySqlCommand(commandstatement, conn)
            com.Parameters.AddRange(dynamicParameters)
            com.ExecuteNonQuery()
            com.Parameters.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Function RunScalar(ByVal scalarstatement As String)
        Try
            OpenServerConnection()
            com = New MySqlCommand(scalarstatement, conn)
            Dim scalar As Object = com.ExecuteScalar
            If scalar IsNot Nothing AndAlso Not DBNull.Value.Equals(scalar) Then
                Return scalar.ToString
            Else
                Return String.Empty
            End If
        Catch ex As Exception
            Return String.Empty
        Finally
            conn.Close()
        End Try
    End Function
End Module

