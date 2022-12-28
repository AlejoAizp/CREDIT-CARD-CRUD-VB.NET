<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PresentationForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeaderText = New System.Windows.Forms.Label()
        Me.txtCreditCardName = New System.Windows.Forms.TextBox()
        Me.txtCreditCardSurName = New System.Windows.Forms.TextBox()
        Me.txtCreditCardNumber = New System.Windows.Forms.TextBox()
        Me.txtCVVNumber = New System.Windows.Forms.TextBox()
        Me.txtExpireDate = New System.Windows.Forms.TextBox()
        Me.lblCreateCreditCardText = New System.Windows.Forms.Label()
        Me.lblCreditCardName = New System.Windows.Forms.Label()
        Me.lblCreditCardSurName = New System.Windows.Forms.Label()
        Me.lblCreditCardNumber = New System.Windows.Forms.Label()
        Me.lblCVV = New System.Windows.Forms.Label()
        Me.lblExpireDate = New System.Windows.Forms.Label()
        Me.lblCreditCardContainer = New System.Windows.Forms.Label()
        Me.btnCreateCreditCard = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtInsertIdCreditCard = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDeleteCreditCard = New System.Windows.Forms.Button()
        Me.btnEditCreditCard = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeaderText
        '
        Me.lblHeaderText.BackColor = System.Drawing.Color.White
        Me.lblHeaderText.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblHeaderText.Font = New System.Drawing.Font("Perpetua Titling MT", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderText.Location = New System.Drawing.Point(-217, 9)
        Me.lblHeaderText.Name = "lblHeaderText"
        Me.lblHeaderText.Size = New System.Drawing.Size(1653, 84)
        Me.lblHeaderText.TabIndex = 1
        Me.lblHeaderText.Text = "CREDIT CARD SYSTEM"
        Me.lblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCreditCardName
        '
        Me.txtCreditCardName.Location = New System.Drawing.Point(84, 242)
        Me.txtCreditCardName.MaxLength = 16
        Me.txtCreditCardName.Name = "txtCreditCardName"
        Me.txtCreditCardName.Size = New System.Drawing.Size(350, 20)
        Me.txtCreditCardName.TabIndex = 16
        '
        'txtCreditCardSurName
        '
        Me.txtCreditCardSurName.Location = New System.Drawing.Point(84, 284)
        Me.txtCreditCardSurName.Name = "txtCreditCardSurName"
        Me.txtCreditCardSurName.Size = New System.Drawing.Size(350, 20)
        Me.txtCreditCardSurName.TabIndex = 17
        '
        'txtCreditCardNumber
        '
        Me.txtCreditCardNumber.Location = New System.Drawing.Point(84, 323)
        Me.txtCreditCardNumber.Name = "txtCreditCardNumber"
        Me.txtCreditCardNumber.Size = New System.Drawing.Size(350, 20)
        Me.txtCreditCardNumber.TabIndex = 18
        '
        'txtCVVNumber
        '
        Me.txtCVVNumber.Location = New System.Drawing.Point(84, 365)
        Me.txtCVVNumber.Name = "txtCVVNumber"
        Me.txtCVVNumber.Size = New System.Drawing.Size(350, 20)
        Me.txtCVVNumber.TabIndex = 19
        '
        'txtExpireDate
        '
        Me.txtExpireDate.Location = New System.Drawing.Point(84, 406)
        Me.txtExpireDate.Name = "txtExpireDate"
        Me.txtExpireDate.Size = New System.Drawing.Size(350, 20)
        Me.txtExpireDate.TabIndex = 20
        '
        'lblCreateCreditCardText
        '
        Me.lblCreateCreditCardText.AllowDrop = True
        Me.lblCreateCreditCardText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCreateCreditCardText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateCreditCardText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCreateCreditCardText.Location = New System.Drawing.Point(21, 192)
        Me.lblCreateCreditCardText.Name = "lblCreateCreditCardText"
        Me.lblCreateCreditCardText.Size = New System.Drawing.Size(520, 20)
        Me.lblCreateCreditCardText.TabIndex = 21
        Me.lblCreateCreditCardText.Text = "INGRESE SUS DATOS Y CREE SU TARJETA DE CREDITO"
        Me.lblCreateCreditCardText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCreateCreditCardText.UseMnemonic = False
        '
        'lblCreditCardName
        '
        Me.lblCreditCardName.AutoSize = True
        Me.lblCreditCardName.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCreditCardName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCardName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCreditCardName.Location = New System.Drawing.Point(84, 222)
        Me.lblCreditCardName.Name = "lblCreditCardName"
        Me.lblCreditCardName.Size = New System.Drawing.Size(56, 16)
        Me.lblCreditCardName.TabIndex = 22
        Me.lblCreditCardName.Text = "Nombre"
        '
        'lblCreditCardSurName
        '
        Me.lblCreditCardSurName.AutoSize = True
        Me.lblCreditCardSurName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCardSurName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCreditCardSurName.Location = New System.Drawing.Point(84, 263)
        Me.lblCreditCardSurName.Name = "lblCreditCardSurName"
        Me.lblCreditCardSurName.Size = New System.Drawing.Size(57, 16)
        Me.lblCreditCardSurName.TabIndex = 23
        Me.lblCreditCardSurName.Text = "Apellido"
        '
        'lblCreditCardNumber
        '
        Me.lblCreditCardNumber.AutoSize = True
        Me.lblCreditCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCardNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCreditCardNumber.Location = New System.Drawing.Point(81, 307)
        Me.lblCreditCardNumber.Name = "lblCreditCardNumber"
        Me.lblCreditCardNumber.Size = New System.Drawing.Size(120, 16)
        Me.lblCreditCardNumber.TabIndex = 24
        Me.lblCreditCardNumber.Text = "Numero de Tarjeta"
        '
        'lblCVV
        '
        Me.lblCVV.AutoSize = True
        Me.lblCVV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCVV.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCVV.Location = New System.Drawing.Point(84, 346)
        Me.lblCVV.Name = "lblCVV"
        Me.lblCVV.Size = New System.Drawing.Size(34, 16)
        Me.lblCVV.TabIndex = 25
        Me.lblCVV.Text = "CVV"
        '
        'lblExpireDate
        '
        Me.lblExpireDate.AutoSize = True
        Me.lblExpireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpireDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblExpireDate.Location = New System.Drawing.Point(84, 388)
        Me.lblExpireDate.Name = "lblExpireDate"
        Me.lblExpireDate.Size = New System.Drawing.Size(111, 16)
        Me.lblExpireDate.TabIndex = 26
        Me.lblExpireDate.Text = "Fecha Expiracion"
        '
        'lblCreditCardContainer
        '
        Me.lblCreditCardContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCreditCardContainer.Cursor = System.Windows.Forms.Cursors.Cross
        Me.lblCreditCardContainer.ForeColor = System.Drawing.Color.Red
        Me.lblCreditCardContainer.Location = New System.Drawing.Point(603, 233)
        Me.lblCreditCardContainer.Name = "lblCreditCardContainer"
        Me.lblCreditCardContainer.Size = New System.Drawing.Size(560, 210)
        Me.lblCreditCardContainer.TabIndex = 28
        '
        'btnCreateCreditCard
        '
        Me.btnCreateCreditCard.BackColor = System.Drawing.Color.Lime
        Me.btnCreateCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreateCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateCreditCard.Location = New System.Drawing.Point(84, 453)
        Me.btnCreateCreditCard.Name = "btnCreateCreditCard"
        Me.btnCreateCreditCard.Size = New System.Drawing.Size(347, 43)
        Me.btnCreateCreditCard.TabIndex = 30
        Me.btnCreateCreditCard.Text = "CREAR TARJETA DE CREDITO"
        Me.btnCreateCreditCard.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(539, 233)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(624, 210)
        Me.DataGridView1.TabIndex = 34
        '
        'txtInsertIdCreditCard
        '
        Me.txtInsertIdCreditCard.Location = New System.Drawing.Point(95, 538)
        Me.txtInsertIdCreditCard.Name = "txtInsertIdCreditCard"
        Me.txtInsertIdCreditCard.Size = New System.Drawing.Size(100, 20)
        Me.txtInsertIdCreditCard.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(84, 508)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "SELECCIONA UN ID Y ELIMINA O EDITA UNA TARJETA"
        '
        'btnDeleteCreditCard
        '
        Me.btnDeleteCreditCard.BackColor = System.Drawing.Color.Red
        Me.btnDeleteCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteCreditCard.Location = New System.Drawing.Point(225, 536)
        Me.btnDeleteCreditCard.Name = "btnDeleteCreditCard"
        Me.btnDeleteCreditCard.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteCreditCard.TabIndex = 37
        Me.btnDeleteCreditCard.Text = "ELIMINAR"
        Me.btnDeleteCreditCard.UseVisualStyleBackColor = False
        '
        'btnEditCreditCard
        '
        Me.btnEditCreditCard.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnEditCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditCreditCard.Location = New System.Drawing.Point(319, 536)
        Me.btnEditCreditCard.Name = "btnEditCreditCard"
        Me.btnEditCreditCard.Size = New System.Drawing.Size(75, 23)
        Me.btnEditCreditCard.TabIndex = 38
        Me.btnEditCreditCard.Text = "EDITAR"
        Me.btnEditCreditCard.UseVisualStyleBackColor = False
        '
        'VistaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1198, 646)
        Me.Controls.Add(Me.btnEditCreditCard)
        Me.Controls.Add(Me.btnDeleteCreditCard)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInsertIdCreditCard)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCreateCreditCard)
        Me.Controls.Add(Me.lblCreditCardContainer)
        Me.Controls.Add(Me.lblExpireDate)
        Me.Controls.Add(Me.lblCVV)
        Me.Controls.Add(Me.lblCreditCardNumber)
        Me.Controls.Add(Me.lblCreditCardSurName)
        Me.Controls.Add(Me.lblCreditCardName)
        Me.Controls.Add(Me.lblCreateCreditCardText)
        Me.Controls.Add(Me.txtExpireDate)
        Me.Controls.Add(Me.txtCVVNumber)
        Me.Controls.Add(Me.txtCreditCardNumber)
        Me.Controls.Add(Me.txtCreditCardSurName)
        Me.Controls.Add(Me.txtCreditCardName)
        Me.Controls.Add(Me.lblHeaderText)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "VistaForm"
        Me.Text = "VistaForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeaderText As Label
    Friend WithEvents txtCreditCardName As TextBox
    Friend WithEvents txtCreditCardSurName As TextBox
    Friend WithEvents txtCreditCardNumber As TextBox
    Friend WithEvents txtCVVNumber As TextBox
    Friend WithEvents txtExpireDate As TextBox
    Friend WithEvents lblCreateCreditCardText As Label
    Friend WithEvents lblCreditCardName As Label
    Friend WithEvents lblCreditCardSurName As Label
    Friend WithEvents lblCreditCardNumber As Label
    Friend WithEvents lblCVV As Label
    Friend WithEvents lblExpireDate As Label
    Friend WithEvents lblCreditCardContainer As Label
    Friend WithEvents btnCreateCreditCard As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtInsertIdCreditCard As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDeleteCreditCard As Button
    Friend WithEvents btnEditCreditCard As Button
End Class
