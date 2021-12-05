<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMoveisType
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.btnAmbiente = New System.Windows.Forms.PictureBox()
        Me.btn_others = New System.Windows.Forms.PictureBox()
        CType(Me.btnAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_others, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.Black
        Me.Panel28.Location = New System.Drawing.Point(0, 58)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(1000, 2)
        Me.Panel28.TabIndex = 20
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Raleway", 24.0!)
        Me.Label83.Location = New System.Drawing.Point(430, 7)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(141, 44)
        Me.Label83.TabIndex = 21
        Me.Label83.Text = "MÓVEIS"
        '
        'btnAmbiente
        '
        Me.btnAmbiente.Image = Global.ArquivoVivo_Desktop.My.Resources.Resources.btn_ambiente
        Me.btnAmbiente.Location = New System.Drawing.Point(229, 255)
        Me.btnAmbiente.Name = "btnAmbiente"
        Me.btnAmbiente.Size = New System.Drawing.Size(228, 228)
        Me.btnAmbiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAmbiente.TabIndex = 23
        Me.btnAmbiente.TabStop = False
        '
        'btn_others
        '
        Me.btn_others.Image = Global.ArquivoVivo_Desktop.My.Resources.Resources.btn_others
        Me.btn_others.Location = New System.Drawing.Point(542, 255)
        Me.btn_others.Name = "btn_others"
        Me.btn_others.Size = New System.Drawing.Size(228, 228)
        Me.btn_others.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_others.TabIndex = 22
        Me.btn_others.TabStop = False
        '
        'FormMoveisType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.btnAmbiente)
        Me.Controls.Add(Me.btn_others)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.Panel28)
        Me.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Name = "FormMoveisType"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMoveisType"
        CType(Me.btnAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_others, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel28 As Panel
    Friend WithEvents Label83 As Label
    Friend WithEvents btn_others As PictureBox
    Friend WithEvents btnAmbiente As PictureBox
End Class
