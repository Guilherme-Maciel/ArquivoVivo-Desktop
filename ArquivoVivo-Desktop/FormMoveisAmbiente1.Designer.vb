<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMoveisAmbiente1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelMovel = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.picboxImageUpload = New System.Windows.Forms.PictureBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboxQtd = New System.Windows.Forms.ComboBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.panelMovel.SuspendLayout()
        CType(Me.picboxImageUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMovel
        '
        Me.panelMovel.Controls.Add(Me.btnCancel)
        Me.panelMovel.Controls.Add(Me.btnCommit)
        Me.panelMovel.Controls.Add(Me.Label8)
        Me.panelMovel.Controls.Add(Me.Label7)
        Me.panelMovel.Controls.Add(Me.btnImage)
        Me.panelMovel.Controls.Add(Me.picboxImageUpload)
        Me.panelMovel.Controls.Add(Me.txtDesc)
        Me.panelMovel.Controls.Add(Me.Label6)
        Me.panelMovel.Controls.Add(Me.Label5)
        Me.panelMovel.Controls.Add(Me.cboxQtd)
        Me.panelMovel.Controls.Add(Me.txtValue)
        Me.panelMovel.Controls.Add(Me.Label4)
        Me.panelMovel.Controls.Add(Me.Label83)
        Me.panelMovel.Controls.Add(Me.txtTitle)
        Me.panelMovel.Controls.Add(Me.Label1)
        Me.panelMovel.Controls.Add(Me.Panel28)
        Me.panelMovel.Location = New System.Drawing.Point(0, 0)
        Me.panelMovel.Name = "panelMovel"
        Me.panelMovel.Size = New System.Drawing.Size(1000, 700)
        Me.panelMovel.TabIndex = 28
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(621, 629)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(213, 57)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "CANCELAR"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCommit
        '
        Me.btnCommit.FlatAppearance.BorderSize = 0
        Me.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommit.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.Location = New System.Drawing.Point(186, 629)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(213, 57)
        Me.btnCommit.TabIndex = 40
        Me.btnCommit.Text = "SALVAR"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Raleway Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(632, 533)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 22)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = ".jpg ou .png"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Raleway Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(626, 487)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 22)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Limite: 100KB"
        '
        'btnImage
        '
        Me.btnImage.Font = New System.Drawing.Font("Raleway Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImage.Location = New System.Drawing.Point(530, 427)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(304, 31)
        Me.btnImage.TabIndex = 37
        Me.btnImage.Text = "ESCOLHER IMAGEM"
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'picboxImageUpload
        '
        Me.picboxImageUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxImageUpload.Location = New System.Drawing.Point(186, 427)
        Me.picboxImageUpload.Name = "picboxImageUpload"
        Me.picboxImageUpload.Size = New System.Drawing.Size(304, 181)
        Me.picboxImageUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxImageUpload.TabIndex = 36
        Me.picboxImageUpload.TabStop = False
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(186, 200)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(304, 205)
        Me.txtDesc.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(178, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 44)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "descrição:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(753, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 44)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "qtd:"
        '
        'cboxQtd
        '
        Me.cboxQtd.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxQtd.FormattingEnabled = True
        Me.cboxQtd.Location = New System.Drawing.Point(761, 290)
        Me.cboxQtd.Name = "cboxQtd"
        Me.cboxQtd.Size = New System.Drawing.Size(73, 35)
        Me.cboxQtd.TabIndex = 32
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(530, 290)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(167, 35)
        Me.txtValue.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(522, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 44)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "valor:"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Raleway", 24.0!)
        Me.Label83.Location = New System.Drawing.Point(430, 10)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(141, 44)
        Me.Label83.TabIndex = 23
        Me.Label83.Text = "MÓVEIS"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(186, 115)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(648, 35)
        Me.txtTitle.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 44)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "título:"
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.Black
        Me.Panel28.Location = New System.Drawing.Point(0, 61)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(1000, 2)
        Me.Panel28.TabIndex = 22
        '
        'FormMoveisAmbiente1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.panelMovel)
        Me.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "FormMoveisAmbiente1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMoveisAmbiente1"
        Me.panelMovel.ResumeLayout(False)
        Me.panelMovel.PerformLayout()
        CType(Me.picboxImageUpload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMovel As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCommit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnImage As Button
    Friend WithEvents picboxImageUpload As PictureBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboxQtd As ComboBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel28 As Panel
End Class
