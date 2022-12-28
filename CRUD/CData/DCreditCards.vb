Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class DCreditCards
    Inherits DbConnection

    Private id_CreditCard As Integer
    Private Name As String
    Private Surname As String
    Private CreditCardNumber As String
    Private CVV As Integer
    Private ExpireDate As String


    Private SqlCommand As SqlCommand
    Private DReader As SqlDataReader

    Public Sub New(nam As String, sur As String, ccn As String, cv As Integer, ed As String)

        Name = nam
        Surname = sur
        CreditCardNumber = ccn
        CVV = cv
        ExpireDate = ed

    End Sub

    Public Sub New()

    End Sub

    Public Property idCreditCard As Integer
        Get
            Return id_CreditCard
        End Get
        Set(ByVal value As Integer)
            id_CreditCard = value
        End Set
    End Property

    Public Property NameCreditCard As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property

    Public Property SurnameCreditCard As String
        Get
            Return Surname
        End Get
        Set(value As String)
            Surname = value
        End Set
    End Property

    Public Property NumberCreditCard As String
        Get
            Return CreditCardNumber
        End Get
        Set(value As String)
            CreditCardNumber = value
        End Set
    End Property

    Public Property CVVCreditCard As String
        Get
            Return CVV
        End Get
        Set(value As String)
            CVV = value
        End Set
    End Property

    Public Property ExpireDateCreditCard As String
        Get
            Return ExpireDate
        End Get
        Set(value As String)
            ExpireDate = value
        End Set
    End Property


    Public Function InsertCreditCard(dcc As DCreditCards) As Boolean

        Try

            connectDb()

            Dim SqlInstruction As String = "INSERT INTO CREDITCARDS(NAME,SURNAME,CREDITCARDNUMBER,CVV,EXPIREDATE)VALUES('" & dcc.NameCreditCard &
                "','" & dcc.SurnameCreditCard & "','" & dcc.CreditCardNumber & "','" & dcc.CVVCreditCard & "','" & dcc.ExpireDateCreditCard & "')"

            SqlCommand = New SqlCommand(SqlInstruction, connectionSqlServer)

            If SqlCommand.ExecuteNonQuery() Then

                MsgBox("The client entered correctly")

                Return True
            Else
                Return False

            End If



        Catch ex As Exception

            MsgBox(ex.Message)

            Return False


        Finally

            disconnectDb()

        End Try


    End Function



    Public Function createDataTableCreditCard() As DataTable
        Try
            connectDb()

            SqlCommand = New SqlCommand("SELECT * FROM CREDITCARDS")

            SqlCommand.Connection = connectionSqlServer

            If SqlCommand.ExecuteNonQuery() Then

                Dim DTable As New DataTable
                Dim SqlAdp As New SqlDataAdapter(SqlCommand)

                SqlAdp.Fill(DTable)

                Return DTable

            Else

                Return Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

            Return Nothing

        Finally

            disconnectDb()

        End Try

    End Function

    Public Function consultEditDeleteCreditCard(idCreditCard As Integer) As DataTable
        Try
            connectDb()

            SqlCommand = New SqlCommand("SELECT NAME,SURNAME,CREDITCARDNUMBER,CVV,EXPIREDATE FROM CREDITCARDS WHERE ID_CREDITCARD ='" & idCreditCard & "'")

            SqlCommand.Connection = connectionSqlServer

            If SqlCommand.ExecuteNonQuery() Then

                Dim DTable As New DataTable
                Dim DAdapter As New SqlDataAdapter(SqlCommand)

                DAdapter.Fill(DTable)

                Return DTable

                DReader.Close()

            Else
                Return Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

            Return Nothing

        Finally
            disconnectDb()

        End Try

    End Function


    Public Function updateCreditCard(ccards As DCreditCards) As Boolean

        Try

            connectDb()

            SqlCommand = New SqlCommand("UPDATE CREDITCARDS SET NAME='" & ccards.Name & "',SURNAME='" & ccards.Surname & "',CREDITCARDNUMBER='" & ccards.CreditCardNumber & "',CVV='" &
            ccards.CVV & "', EXPIREDATE='" & ccards.ExpireDate & "' WHERE CREDITCARDNUMBER='" & ccards.CreditCardNumber & "'")

            SqlCommand.Connection = connectionSqlServer

            If SqlCommand.ExecuteNonQuery() Then

                MsgBox("Los datos de la Tarjeta de Credito fueron actualizados correctamente.")

                Return True

            Else

                Return False

            End If


        Catch ex As Exception

            MsgBox(ex.Message)

        Finally

            disconnectDb()

        End Try

    End Function

    Public Function deleteCreditCard(idCCard As Integer) As Boolean

        Try
            connectDb()

            SqlCommand = New SqlCommand("DELETE FROM CREDITCARDS WHERE ID_CREDITCARD='" & idCCard & "'")

            SqlCommand.Connection = connectionSqlServer


            If SqlCommand.ExecuteNonQuery() Then

                MsgBox("la tarjeta se ha eliminado correctamente de la base de datos.")

                Return True

            Else

                Return False

            End If


        Catch ex As Exception

            MsgBox(ex.Message)

            Return False

        Finally

            disconnectDb()

        End Try
    End Function


End Class
