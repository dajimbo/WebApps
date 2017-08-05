Imports System.Data.SqlClient
Module SqlConn
    Public Function getConnection(connectionString As String) As SqlConnection
        Dim Connection As New SqlConnection()
        Try
            Connection.ConnectionString = connectionString
            Connection.Open()
        Catch ex As Exception
            logErrorsToDatabase(ex)
        End Try
        Return Connection
    End Function

    Public Sub executeNonQuery(query As String, connection As SqlConnection)
        Try
            Dim command As New SqlCommand(query, connection)
            command.ExecuteNonQuery()
        Catch ex As Exception
            logErrorsToDatabase(ex)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Function executeQuery(query As String, connection As SqlConnection) As DataTable
        Dim data As New DataTable()
        Try
            Using command As New SqlDataAdapter(query, connection)
                command.Fill(data)
            End Using
        Catch ex As Exception
            logErrorsToDatabase(ex)
        Finally
            connection.Close()
        End Try
        Return data
    End Function


    Public Sub logErrorsToDatabase(ex As Exception)
        Dim connectionString = "Server = DESKTOP-1GH0JHK\WEBDEV; Database =  AdventureWorks2014; UID = sa; pwd = localadmin"
        Dim errorSqlConnection As New SqlConnection(connectionString)
        Dim command As New SqlCommand("INSERT INTO  Errors VALUES ('" + ex.Source.Replace("'", "") + "','" + ex.Message.Replace("'", "") + "','" _
                                            + ex.TargetSite.Name.Replace("'", "") + "')", errorSqlConnection)
        Try
            errorSqlConnection.Open()
            command.ExecuteNonQuery()
        Catch ex
            Console.WriteLine(ex.Message)
        Finally
            errorSqlConnection.Close()
        End Try
    End Sub

End Module
