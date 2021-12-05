<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlterDesigner
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
        Me.panelDesigner = New System.Windows.Forms.Panel()
        Me.btnCancelDesigner = New System.Windows.Forms.Button()
        Me.btnCommitDesigner = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnImageDesigner = New System.Windows.Forms.Button()
        Me.picboxImageUploadDesigner = New System.Windows.Forms.PictureBox()
        Me.txtBioDesigner = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNameDesigner = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelDesigner.SuspendLayout()
        CType(Me.picboxImageUploadDesigner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelDesigner
        '
        Me.panelDesigner.Controls.Add(Me.btnCancelDesigner)
        Me.panelDesigner.Controls.Add(Me.btnCommitDesigner)
        Me.panelDesigner.Controls.Add(Me.Label9)
        Me.panelDesigner.Controls.Add(Me.Label10)
        Me.panelDesigner.Controls.Add(Me.btnImageDesigner)
        Me.panelDesigner.Controls.Add(Me.picboxImageUploadDesigner)
        Me.panelDesigner.Controls.Add(Me.txtBioDesigner)
        Me.panelDesigner.Controls.Add(Me.Label11)
        Me.panelDesigner.Controls.Add(Me.Label16)
        Me.panelDesigner.Controls.Add(Me.txtNameDesigner)
        Me.panelDesigner.Controls.Add(Me.Label17)
        Me.panelDesigner.Controls.Add(Me.Panel2)
        Me.panelDesigner.Location = New System.Drawing.Point(0, 0)
        Me.panelDesigner.Name = "panelDesigner"
        Me.panelDesigner.Size = New System.Drawing.Size(1000, 700)
        Me.panelDesigner.TabIndex = 43
        '
        'btnCancelDesigner
        '
        Me.btnCancelDesigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelDesigner.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDesigner.Location = New System.Drawing.Point(621, 629)
        Me.btnCancelDesigner.Name = "btnCancelDesigner"
        Me.btnCancelDesigner.Size = New System.Drawing.Size(213, 57)
        Me.btnCancelDesigner.TabIndex = 41
        Me.btnCancelDesigner.Text = "CANCELAR"
        Me.btnCancelDesigner.UseVisualStyleBackColor = True
        '
        'btnCommitDesigner
        '
        Me.btnCommitDesigner.FlatAppearance.BorderSize = 0
        Me.btnCommitDesigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommitDesigner.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommitDesigner.Location = New System.Drawing.Point(186, 629)
        Me.btnCommitDesigner.Name = "btnCommitDesigner"
        Me.btnCommitDesigner.Size = New System.Drawing.Size(213, 57)
        Me.btnCommitDesigner.TabIndex = 40
        Me.btnCommitDesigner.Text = "ALTERAR"
        Me.btnCommitDesigner.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Raleway Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(632, 533)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 22)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = ".jpg ou .png"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Raleway Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(626, 487)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 22)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Limite: 100KB"
        '
        'btnImageDesigner
        '
        Me.btnImageDesigner.Font = New System.Drawing.Font("Raleway Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImageDesigner.Location = New System.Drawing.Point(530, 427)
        Me.btnImageDesigner.Name = "btnImageDesigner"
        Me.btnImageDesigner.Size = New System.Drawing.Size(304, 31)
        Me.btnImageDesigner.TabIndex = 37
        Me.btnImageDesigner.Text = "ESCOLHER IMAGEM"
        Me.btnImageDesigner.UseVisualStyleBackColor = True
        '
        'picboxImageUploadDesigner
        '
        Me.picboxImageUploadDesigner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxImageUploadDesigner.Location = New System.Drawing.Point(186, 427)
        Me.picboxImageUploadDesigner.Name = "picboxImageUploadDesigner"
        Me.picboxImageUploadDesigner.Size = New System.Drawing.Size(304, 181)
        Me.picboxImageUploadDesigner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxImageUploadDesigner.TabIndex = 36
        Me.picboxImageUploadDesigner.TabStop = False
        '
        'txtBioDesigner
        '
        Me.txtBioDesigner.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBioDesigner.Location = New System.Drawing.Point(186, 200)
        Me.txtBioDesigner.Multiline = True
        Me.txtBioDesigner.Name = "txtBioDesigner"
        Me.txtBioDesigner.Size = New System.Drawing.Size(648, 205)
        Me.txtBioDesigner.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(178, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 44)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "biografia:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Raleway", 24.0!)
        Me.Label16.Location = New System.Drawing.Point(430, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(198, 44)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "DESIGNERS"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNameDesigner
        '
        Me.txtNameDesigner.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameDesigner.Location = New System.Drawing.Point(186, 115)
        Me.txtNameDesigner.Name = "txtNameDesigner"
        Me.txtNameDesigner.Size = New System.Drawing.Size(648, 35)
        Me.txtNameDesigner.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(178, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 44)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "nome:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 2)
        Me.Panel2.TabIndex = 22
        '
        'FormAlterDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.panelDesigner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAlterDesigner"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAlterDesigner"
        Me.panelDesigner.ResumeLayout(False)
        Me.panelDesigner.PerformLayout()
        CType(Me.picboxImageUploadDesigner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelDesigner As Panel
    Friend WithEvents btnCancelDesigner As Button
    Friend WithEvents btnCommitDesigner As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnImageDesigner As Button
    Friend WithEvents picboxImageUploadDesigner As PictureBox
    Friend WithEvents txtBioDesigner As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtNameDesigner As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel2 As Panel
End Class
