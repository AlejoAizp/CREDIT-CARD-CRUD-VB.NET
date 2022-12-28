
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class PresentationForm
    Dim connectionSqlServer As New SqlConnection("Data Source=DESKTOP-UNNJQAE\ALEJO;Initial Catalog=CrudVisualBasicDB;Integrated Security=True")
    Dim nameIsInDataBase As Integer
    Dim surNameIsInDataBase As Integer
    Dim creditCardIsInDataBase As Integer
    Dim cvvIsInDataBase As Integer
    Dim expireDateIsInDataBase As Integer

    Private Sub VistaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        updateDataTableVista()
        btnDeleteCreditCard.Enabled = False
        btnEditCreditCard.Enabled = False
    End Sub

    Public Function updateDataTableVista()

        Dim LCCard As New LCreditCard
        Dim DTable As DataTable = LCCard.createDataTableCreditCard()

        DataGridView1.DataSource = DTable

    End Function
    Public Function ClearTxtBox()

        txtCreditCardName.Clear()
        txtCreditCardSurName.Clear()
        txtCreditCardNumber.Clear()
        txtCVVNumber.Clear()
        txtExpireDate.Clear()


    End Function

    Public Function isInTheDatabaseValidator() As Boolean

        connectionSqlServer.Open()

        Dim SQLCommand1 As String = "Select Count(*) FROM CreditCards Where Name = @Name"
        Dim SQLCommand2 As String = "Select Count(*) FROM CreditCards Where SurName = @SurName"
        Dim SQLCommand3 As String = "Select Count(*) FROM CreditCards Where CreditCardNumber = @CreditCardNumber"
        Dim SQLCommand4 As String = "Select Count(*) FROM CreditCards Where CVV = @CVV"
        Dim SQLCommand5 As String = "Select Count(*) FROM CreditCards Where ExpireDate = @ExpireDate"

        Dim SQLCommand1Connection As New SqlCommand(SQLCommand1, connectionSqlServer)
        Dim SQLCommand2Connection As New SqlCommand(SQLCommand2, connectionSqlServer)
        Dim SQLCommand3Connection As New SqlCommand(SQLCommand3, connectionSqlServer)
        Dim SQLCommand4Connection As New SqlCommand(SQLCommand4, connectionSqlServer)
        Dim SQLCommand5Connection As New SqlCommand(SQLCommand5, connectionSqlServer)

        SQLCommand1Connection.Parameters.AddWithValue("@Name", txtCreditCardName.Text)
        SQLCommand2Connection.Parameters.AddWithValue("@SurName", txtCreditCardSurName.Text)
        SQLCommand3Connection.Parameters.AddWithValue("@CreditCardNumber", txtCreditCardNumber.Text)
        SQLCommand4Connection.Parameters.AddWithValue("@CVV", txtCVVNumber.Text)
        SQLCommand5Connection.Parameters.AddWithValue("@ExpireDate", txtExpireDate.Text)

        Dim RunSqlCommand1 As Boolean = CInt(SQLCommand1Connection.ExecuteScalar())
        Dim RunSqlCommand2 As Boolean = CInt(SQLCommand2Connection.ExecuteScalar())
        Dim RunSqlCommand3 As Boolean = CInt(SQLCommand3Connection.ExecuteScalar())
        Dim RunSqlCommand4 As Boolean = CInt(SQLCommand4Connection.ExecuteScalar())
        Dim RunSqlCommand5 As Boolean = CInt(SQLCommand5Connection.ExecuteScalar())

        nameIsInDataBase = RunSqlCommand1
        surNameIsInDataBase = RunSqlCommand2
        creditCardIsInDataBase = RunSqlCommand3
        cvvIsInDataBase = RunSqlCommand4
        expireDateIsInDataBase = RunSqlCommand5

        connectionSqlServer.Close()

    End Function

    Private Sub btnCreateCreditCard_Click(sender As Object, e As EventArgs) Handles btnCreateCreditCard.Click
        Dim DCCard As New DCreditCards
        Dim LCCard As New LCreditCard

        isInTheDatabaseValidator()

        Try
            'Validations--->
            If txtCreditCardName.Text <> "" And txtCreditCardSurName.Text <> "" And txtCreditCardNumber.Text <> "" And txtCVVNumber.Text <> "" And txtExpireDate.Text <> "" And
            txtCreditCardName.TextLength > 2 And txtCreditCardName.TextLength < 12 And txtCreditCardSurName.TextLength > 3 And
            txtCreditCardSurName.TextLength < 15 And txtCreditCardNumber.TextLength = 16 And txtCVVNumber.TextLength = 3 And txtExpireDate.TextLength = 8 And
            nameIsInDataBase = False And surNameIsInDataBase = False And creditCardIsInDataBase = False And cvvIsInDataBase = False And expireDateIsInDataBase = False Then
                'Validations--->

                LCCard.InsertCreditCard(txtCreditCardName.Text, txtCreditCardSurName.Text, txtCreditCardNumber.Text, txtCVVNumber.Text, txtExpireDate.Text)

                updateDataTableVista()

                ClearTxtBox()

            Else

                MsgBox("No se pudieron ingresar tus datos, puede que algunos datos ya existan o los mismos son erroneos.")

            End If


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnDeleteCreditCard_Click(sender As Object, e As EventArgs) Handles btnDeleteCreditCard.Click

        Try

            Dim LCCard As New LCreditCard

            LCCard.deleteCreditCard(txtInsertIdCreditCard.Text)

            Dim LCCardToDTable As New LCreditCard

            updateDataTableVista()

            ClearTxtBox()

            txtInsertIdCreditCard.Clear()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnEditCreditCard_Click(sender As Object, e As EventArgs) Handles btnEditCreditCard.Click

        Dim LCCard As New LCreditCard

        isInTheDatabaseValidator()

        Try
            If nameIsInDataBase = False Or surNameIsInDataBase = False Or creditCardIsInDataBase = False Or cvvIsInDataBase = False Or expireDateIsInDataBase = False Then

                LCCard.updateCreditCard(txtCreditCardName.Text, txtCreditCardSurName.Text, txtCreditCardNumber.Text, txtCVVNumber.Text, txtExpireDate.Text)

                updateDataTableVista()

                ClearTxtBox()

                txtInsertIdCreditCard.Clear()
            Else

                MsgBox("No se pudieron ingresar tus datos, puede que algunos datos ya existan o los mismos son erroneos.")

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub txtInsertIdCreditCard_TextChanged(sender As Object, e As EventArgs) Handles txtInsertIdCreditCard.TextChanged
        Try
            Dim LCCardToDTable As New LCreditCard

            Dim DTable As DataTable = LCCardToDTable.consultEditDeleteCreditCard(txtInsertIdCreditCard.Text)

            Dim DRow As DataRow = DTable.Rows.Item(0)

            txtCreditCardName.Text = DRow("NAME")
            txtCreditCardSurName.Text = DRow("SURNAME")
            txtCreditCardNumber.Text = DRow("CREDITCARDNUMBER")
            txtCVVNumber.Text = DRow("CVV")
            txtExpireDate.Text = DRow("EXPIREDATE")
            txtCreditCardNumber.Enabled = False
            btnCreateCreditCard.Enabled = False
            btnDeleteCreditCard.Enabled = True
            btnEditCreditCard.Enabled = True
        Catch ex As Exception

            ClearTxtBox()
            txtCreditCardNumber.Enabled = True
            btnCreateCreditCard.Enabled = True
            btnDeleteCreditCard.Enabled = False
            btnEditCreditCard.Enabled = False
        End Try

    End Sub

End Class