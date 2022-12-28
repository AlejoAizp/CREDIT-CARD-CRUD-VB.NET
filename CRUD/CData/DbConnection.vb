Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class DbConnection

    Public connectionSqlServer As New SqlConnection("Data Source=DESKTOP-UNNJQAE\ALEJO;Initial Catalog=CrudVisualBasicDB;Integrated Security=True")

    Public Function connectDb() As Boolean

        Try


            connectionSqlServer.Open()


            Return True


        Catch ex As Exception


            MsgBox(ex.Message)


            Return False

        End Try

    End Function

    Public Sub disconnectDb()

        Try

            If connectionSqlServer.State = ConnectionState.Open Then

                connectionSqlServer.Close()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


End Class
