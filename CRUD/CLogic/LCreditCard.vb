Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class LCreditCard
    Dim dcv As New DCreditCards
    Dim Vf As New PresentationForm
    Public Function InsertCreditCard(nam As String, sur As String, ccn As String, cv As Integer, ed As String)


        Dim DCCard As New DCreditCards(nam, sur, ccn, cv, ed)


        If DCCard.InsertCreditCard(DCCard) = True Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function createDataTableCreditCard() As DataTable

        Try

            Dim DCCard As New DCreditCards

            Dim DTable As DataTable = DCCard.createDataTableCreditCard()

            Return DTable


        Catch ex As Exception

            MsgBox(ex.Message)

            Return Nothing

        End Try

    End Function

    Public Function consultEditDeleteCreditCard(idCCard As Integer) As DataTable

        Try

            Dim DCCard As New DCreditCards

            Dim DTable As DataTable = DCCard.consultEditDeleteCreditCard(idCCard)

            Return DTable


        Catch ex As Exception

            Return Nothing

            MsgBox(ex.Message)

        End Try
    End Function

    Public Function updateCreditCard(nam As String, sur As String, ccn As String, cv As Integer, ed As String) As Boolean

        Try

            Dim DCCard As New DCreditCards(nam, sur, ccn, cv, ed)

            DCCard.updateCreditCard(DCCard)

            Return True


        Catch ex As Exception

            MsgBox(ex.Message)

            Return False

        End Try

    End Function

    Public Function deleteCreditCard(idCCard As Integer) As Boolean

        Try

            Dim DCCard As New DCreditCards

            DCCard.deleteCreditCard(idCCard)

            Return True


        Catch ex As Exception

            MsgBox(ex.Message)

            Return False

        End Try

    End Function

End Class
