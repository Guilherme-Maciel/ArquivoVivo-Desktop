<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogar = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnEnd = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Raleway Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(938, 89)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(30, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 2)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(235, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 44)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "E-mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 393)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 44)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Senha:"
        '
        'btnLogar
        '
        Me.btnLogar.ForeColor = System.Drawing.Color.Black
        Me.btnLogar.Location = New System.Drawing.Point(344, 562)
        Me.btnLogar.Name = "btnLogar"
        Me.btnLogar.Size = New System.Drawing.Size(312, 61)
        Me.btnLogar.TabIndex = 7
        Me.btnLogar.Text = "ENTRAR"
        Me.btnLogar.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(258, 451)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(504, 22)
        Me.txtSenha.TabIndex = 8
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(258, 324)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(504, 22)
        Me.txtEmail.TabIndex = 9
        '
        'btnMinimize
        '
        Me.btnMinimize.Image = Global.ArquivoVivo_Desktop.My.Resources.Resources.minimize
        Me.btnMinimize.Location = New System.Drawing.Point(922, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimize.TabIndex = 11
        Me.btnMinimize.TabStop = False
        '
        'btnEnd
        '
        Me.btnEnd.Image = Global.ArquivoVivo_Desktop.My.Resources.Resources._end
        Me.btnEnd.Location = New System.Drawing.Point(958, 12)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(30, 30)
        Me.btnEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEnd.TabIndex = 10
        Me.btnEnd.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ArquivoVivo_Desktop.My.Resources.Resources.textbox_login
        Me.PictureBox3.Location = New System.Drawing.Point(243, 440)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(531, 45)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ArquivoVivo_Desktop.My.Resources.Resources.textbox_login
        Me.PictureBox2.Location = New System.Drawing.Point(243, 311)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(531, 45)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ArquivoVivo_Desktop.My.Resources.Resources.logo_white
        Me.PictureBox1.Location = New System.Drawing.Point(428, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(21.0!, 48.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.btnLogar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Raleway Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogar As Button
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnEnd As PictureBox
    Friend WithEvents btnMinimize As PictureBox
End Class
