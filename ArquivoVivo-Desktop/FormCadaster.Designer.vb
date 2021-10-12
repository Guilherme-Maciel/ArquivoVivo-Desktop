<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCadaster
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
        Me.components = New System.ComponentModel.Container()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitleMovel = New System.Windows.Forms.TextBox()
        Me.panelMovel = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCommitMovel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnImageMovel = New System.Windows.Forms.Button()
        Me.picboxImageUploadMovel = New System.Windows.Forms.PictureBox()
        Me.txtDescMovel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboxQtdMovel = New System.Windows.Forms.ComboBox()
        Me.txtValueMovel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxDesignersMovel = New System.Windows.Forms.ComboBox()
        Me.DesignersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArquivovivomvDataSet = New ArquivoVivo_Desktop.arquivovivomvDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboxCatMovel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DesignersTableAdapter = New ArquivoVivo_Desktop.arquivovivomvDataSetTableAdapters.designersTableAdapter()
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
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New ArquivoVivo_Desktop.arquivovivomvDataSetTableAdapters.categoriaTableAdapter()
        Me.panelMovel.SuspendLayout()
        CType(Me.picboxImageUploadMovel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArquivovivomvDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDesigner.SuspendLayout()
        CType(Me.picboxImageUploadDesigner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.Black
        Me.Panel28.Location = New System.Drawing.Point(0, 61)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(1000, 2)
        Me.Panel28.TabIndex = 22
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
        'txtTitleMovel
        '
        Me.txtTitleMovel.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitleMovel.Location = New System.Drawing.Point(186, 115)
        Me.txtTitleMovel.Name = "txtTitleMovel"
        Me.txtTitleMovel.Size = New System.Drawing.Size(648, 35)
        Me.txtTitleMovel.TabIndex = 25
        '
        'panelMovel
        '
        Me.panelMovel.Controls.Add(Me.btnCancel)
        Me.panelMovel.Controls.Add(Me.btnCommitMovel)
        Me.panelMovel.Controls.Add(Me.Label8)
        Me.panelMovel.Controls.Add(Me.Label7)
        Me.panelMovel.Controls.Add(Me.btnImageMovel)
        Me.panelMovel.Controls.Add(Me.picboxImageUploadMovel)
        Me.panelMovel.Controls.Add(Me.txtDescMovel)
        Me.panelMovel.Controls.Add(Me.Label6)
        Me.panelMovel.Controls.Add(Me.Label5)
        Me.panelMovel.Controls.Add(Me.cboxQtdMovel)
        Me.panelMovel.Controls.Add(Me.txtValueMovel)
        Me.panelMovel.Controls.Add(Me.Label4)
        Me.panelMovel.Controls.Add(Me.cboxDesignersMovel)
        Me.panelMovel.Controls.Add(Me.Label3)
        Me.panelMovel.Controls.Add(Me.cboxCatMovel)
        Me.panelMovel.Controls.Add(Me.Label2)
        Me.panelMovel.Controls.Add(Me.Label83)
        Me.panelMovel.Controls.Add(Me.txtTitleMovel)
        Me.panelMovel.Controls.Add(Me.Label1)
        Me.panelMovel.Controls.Add(Me.Panel28)
        Me.panelMovel.Location = New System.Drawing.Point(0, 0)
        Me.panelMovel.Name = "panelMovel"
        Me.panelMovel.Size = New System.Drawing.Size(961, 706)
        Me.panelMovel.TabIndex = 27
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
        'btnCommitMovel
        '
        Me.btnCommitMovel.FlatAppearance.BorderSize = 0
        Me.btnCommitMovel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommitMovel.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommitMovel.Location = New System.Drawing.Point(186, 629)
        Me.btnCommitMovel.Name = "btnCommitMovel"
        Me.btnCommitMovel.Size = New System.Drawing.Size(213, 57)
        Me.btnCommitMovel.TabIndex = 40
        Me.btnCommitMovel.Text = "SALVAR"
        Me.btnCommitMovel.UseVisualStyleBackColor = True
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
        'btnImageMovel
        '
        Me.btnImageMovel.Font = New System.Drawing.Font("Raleway Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImageMovel.Location = New System.Drawing.Point(530, 427)
        Me.btnImageMovel.Name = "btnImageMovel"
        Me.btnImageMovel.Size = New System.Drawing.Size(304, 31)
        Me.btnImageMovel.TabIndex = 37
        Me.btnImageMovel.Text = "ESCOLHER IMAGEM"
        Me.btnImageMovel.UseVisualStyleBackColor = True
        '
        'picboxImageUploadMovel
        '
        Me.picboxImageUploadMovel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxImageUploadMovel.Location = New System.Drawing.Point(186, 427)
        Me.picboxImageUploadMovel.Name = "picboxImageUploadMovel"
        Me.picboxImageUploadMovel.Size = New System.Drawing.Size(304, 181)
        Me.picboxImageUploadMovel.TabIndex = 36
        Me.picboxImageUploadMovel.TabStop = False
        '
        'txtDescMovel
        '
        Me.txtDescMovel.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescMovel.Location = New System.Drawing.Point(186, 200)
        Me.txtDescMovel.Multiline = True
        Me.txtDescMovel.Name = "txtDescMovel"
        Me.txtDescMovel.Size = New System.Drawing.Size(304, 205)
        Me.txtDescMovel.TabIndex = 35
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
        Me.Label5.Location = New System.Drawing.Point(753, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 44)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "qtd:"
        '
        'cboxQtdMovel
        '
        Me.cboxQtdMovel.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxQtdMovel.FormattingEnabled = True
        Me.cboxQtdMovel.Location = New System.Drawing.Point(761, 370)
        Me.cboxQtdMovel.Name = "cboxQtdMovel"
        Me.cboxQtdMovel.Size = New System.Drawing.Size(73, 35)
        Me.cboxQtdMovel.TabIndex = 32
        '
        'txtValueMovel
        '
        Me.txtValueMovel.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValueMovel.Location = New System.Drawing.Point(530, 370)
        Me.txtValueMovel.Name = "txtValueMovel"
        Me.txtValueMovel.Size = New System.Drawing.Size(167, 35)
        Me.txtValueMovel.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(522, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 44)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "valor:"
        '
        'cboxDesignersMovel
        '
        Me.cboxDesignersMovel.DataSource = Me.DesignersBindingSource
        Me.cboxDesignersMovel.DisplayMember = "d_nome"
        Me.cboxDesignersMovel.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxDesignersMovel.FormattingEnabled = True
        Me.cboxDesignersMovel.Location = New System.Drawing.Point(530, 285)
        Me.cboxDesignersMovel.Name = "cboxDesignersMovel"
        Me.cboxDesignersMovel.Size = New System.Drawing.Size(304, 35)
        Me.cboxDesignersMovel.TabIndex = 29
        Me.cboxDesignersMovel.ValueMember = "d_id"
        '
        'DesignersBindingSource
        '
        Me.DesignersBindingSource.DataMember = "designers"
        Me.DesignersBindingSource.DataSource = Me.ArquivovivomvDataSet
        '
        'ArquivovivomvDataSet
        '
        Me.ArquivovivomvDataSet.DataSetName = "arquivovivomvDataSet"
        Me.ArquivovivomvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(522, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 44)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "designer:"
        '
        'cboxCatMovel
        '
        Me.cboxCatMovel.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxCatMovel.FormattingEnabled = True
        Me.cboxCatMovel.Location = New System.Drawing.Point(530, 200)
        Me.cboxCatMovel.Name = "cboxCatMovel"
        Me.cboxCatMovel.Size = New System.Drawing.Size(304, 35)
        Me.cboxCatMovel.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(522, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 44)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "categoria:"
        '
        'DesignersTableAdapter
        '
        Me.DesignersTableAdapter.ClearBeforeFill = True
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
        Me.panelDesigner.TabIndex = 42
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
        Me.btnCommitDesigner.Text = "SALVAR"
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
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "categoria"
        Me.CategoriaBindingSource.DataSource = Me.ArquivovivomvDataSet
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'FormCadaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.panelDesigner)
        Me.Controls.Add(Me.panelMovel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCadaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCadaster"
        Me.panelMovel.ResumeLayout(False)
        Me.panelMovel.PerformLayout()
        CType(Me.picboxImageUploadMovel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArquivovivomvDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDesigner.ResumeLayout(False)
        Me.panelDesigner.PerformLayout()
        CType(Me.picboxImageUploadDesigner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label83 As Label
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitleMovel As TextBox
    Friend WithEvents panelMovel As Panel
    Friend WithEvents cboxDesignersMovel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboxCatMovel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboxQtdMovel As ComboBox
    Friend WithEvents picboxImageUploadMovel As PictureBox
    Friend WithEvents txtDescMovel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnImageMovel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCommitMovel As Button
    Friend WithEvents txtValueMovel As TextBox
    Friend WithEvents ArquivovivomvDataSet As arquivovivomvDataSet
    Friend WithEvents DesignersBindingSource As BindingSource
    Friend WithEvents DesignersTableAdapter As arquivovivomvDataSetTableAdapters.designersTableAdapter
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
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As arquivovivomvDataSetTableAdapters.categoriaTableAdapter
End Class
