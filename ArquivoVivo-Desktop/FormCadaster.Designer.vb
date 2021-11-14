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
        Me.panelCliente = New System.Windows.Forms.Panel()
        Me.txtCompleCliente = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtNumResCliente = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtBairroCliente = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtRuaCliente = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCepCliente = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCidadeCliente = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEstadoCliente = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtFixCliente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCelCliente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnCancelCliente = New System.Windows.Forms.Button()
        Me.btnCommitCliente = New System.Windows.Forms.Button()
        Me.txtSobreCliente = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNameCliente = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New ArquivoVivo_Desktop.arquivovivomvDataSetTableAdapters.categoriaTableAdapter()
        Me.panelFuncionario = New System.Windows.Forms.Panel()
        Me.txtSenhaFuncionario = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtFixFuncionario = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtCelFuncionario = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtEmailFuncionario = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.btnCancelFuncionario = New System.Windows.Forms.Button()
        Me.btnCommitFuncionario = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtNomeFuncionario = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtSobreFuncionario = New System.Windows.Forms.TextBox()
        Me.panelMovel.SuspendLayout()
        CType(Me.picboxImageUploadMovel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArquivovivomvDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDesigner.SuspendLayout()
        CType(Me.picboxImageUploadDesigner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCliente.SuspendLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFuncionario.SuspendLayout()
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
        Me.picboxImageUploadMovel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
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
        'panelCliente
        '
        Me.panelCliente.Controls.Add(Me.txtCompleCliente)
        Me.panelCliente.Controls.Add(Me.Label25)
        Me.panelCliente.Controls.Add(Me.txtNumResCliente)
        Me.panelCliente.Controls.Add(Me.Label26)
        Me.panelCliente.Controls.Add(Me.txtBairroCliente)
        Me.panelCliente.Controls.Add(Me.Label24)
        Me.panelCliente.Controls.Add(Me.txtRuaCliente)
        Me.panelCliente.Controls.Add(Me.Label23)
        Me.panelCliente.Controls.Add(Me.txtCepCliente)
        Me.panelCliente.Controls.Add(Me.Label22)
        Me.panelCliente.Controls.Add(Me.txtCidadeCliente)
        Me.panelCliente.Controls.Add(Me.Label20)
        Me.panelCliente.Controls.Add(Me.txtEstadoCliente)
        Me.panelCliente.Controls.Add(Me.Label21)
        Me.panelCliente.Controls.Add(Me.txtFixCliente)
        Me.panelCliente.Controls.Add(Me.Label13)
        Me.panelCliente.Controls.Add(Me.txtCelCliente)
        Me.panelCliente.Controls.Add(Me.Label12)
        Me.panelCliente.Controls.Add(Me.txtEmailCliente)
        Me.panelCliente.Controls.Add(Me.Label19)
        Me.panelCliente.Controls.Add(Me.btnCancelCliente)
        Me.panelCliente.Controls.Add(Me.btnCommitCliente)
        Me.panelCliente.Controls.Add(Me.txtSobreCliente)
        Me.panelCliente.Controls.Add(Me.Label14)
        Me.panelCliente.Controls.Add(Me.Label15)
        Me.panelCliente.Controls.Add(Me.txtNameCliente)
        Me.panelCliente.Controls.Add(Me.Label18)
        Me.panelCliente.Controls.Add(Me.Panel3)
        Me.panelCliente.Location = New System.Drawing.Point(0, 0)
        Me.panelCliente.Name = "panelCliente"
        Me.panelCliente.Size = New System.Drawing.Size(1000, 700)
        Me.panelCliente.TabIndex = 43
        '
        'txtCompleCliente
        '
        Me.txtCompleCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompleCliente.Location = New System.Drawing.Point(394, 563)
        Me.txtCompleCliente.Name = "txtCompleCliente"
        Me.txtCompleCliente.Size = New System.Drawing.Size(440, 35)
        Me.txtCompleCliente.TabIndex = 61
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(386, 522)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(233, 44)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "complemento:"
        '
        'txtNumResCliente
        '
        Me.txtNumResCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumResCliente.Location = New System.Drawing.Point(186, 563)
        Me.txtNumResCliente.Name = "txtNumResCliente"
        Me.txtNumResCliente.Size = New System.Drawing.Size(191, 35)
        Me.txtNumResCliente.TabIndex = 59
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(178, 522)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 44)
        Me.Label26.TabIndex = 58
        Me.Label26.Text = "n°:"
        '
        'txtBairroCliente
        '
        Me.txtBairroCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairroCliente.Location = New System.Drawing.Point(186, 487)
        Me.txtBairroCliente.Name = "txtBairroCliente"
        Me.txtBairroCliente.Size = New System.Drawing.Size(648, 35)
        Me.txtBairroCliente.TabIndex = 57
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(178, 446)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 44)
        Me.Label24.TabIndex = 56
        Me.Label24.Text = "bairro:"
        '
        'txtRuaCliente
        '
        Me.txtRuaCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuaCliente.Location = New System.Drawing.Point(394, 411)
        Me.txtRuaCliente.Name = "txtRuaCliente"
        Me.txtRuaCliente.Size = New System.Drawing.Size(440, 35)
        Me.txtRuaCliente.TabIndex = 55
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(386, 370)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 44)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "rua:"
        '
        'txtCepCliente
        '
        Me.txtCepCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCepCliente.Location = New System.Drawing.Point(186, 411)
        Me.txtCepCliente.Name = "txtCepCliente"
        Me.txtCepCliente.Size = New System.Drawing.Size(191, 35)
        Me.txtCepCliente.TabIndex = 53
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(178, 370)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 44)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "cep:"
        '
        'txtCidadeCliente
        '
        Me.txtCidadeCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidadeCliente.Location = New System.Drawing.Point(556, 335)
        Me.txtCidadeCliente.Name = "txtCidadeCliente"
        Me.txtCidadeCliente.Size = New System.Drawing.Size(278, 35)
        Me.txtCidadeCliente.TabIndex = 51
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(548, 294)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 44)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "cidade:"
        '
        'txtEstadoCliente
        '
        Me.txtEstadoCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoCliente.Location = New System.Drawing.Point(186, 335)
        Me.txtEstadoCliente.Name = "txtEstadoCliente"
        Me.txtEstadoCliente.Size = New System.Drawing.Size(278, 35)
        Me.txtEstadoCliente.TabIndex = 49
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(178, 294)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(126, 44)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "estado:"
        '
        'txtFixCliente
        '
        Me.txtFixCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixCliente.Location = New System.Drawing.Point(556, 259)
        Me.txtFixCliente.Name = "txtFixCliente"
        Me.txtFixCliente.Size = New System.Drawing.Size(278, 35)
        Me.txtFixCliente.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(548, 218)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 44)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "fixo:"
        '
        'txtCelCliente
        '
        Me.txtCelCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelCliente.Location = New System.Drawing.Point(186, 259)
        Me.txtCelCliente.Name = "txtCelCliente"
        Me.txtCelCliente.Size = New System.Drawing.Size(278, 35)
        Me.txtCelCliente.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(178, 218)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 44)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "celular:"
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailCliente.Location = New System.Drawing.Point(186, 183)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(648, 35)
        Me.txtEmailCliente.TabIndex = 43
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(178, 142)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 44)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "email:"
        '
        'btnCancelCliente
        '
        Me.btnCancelCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelCliente.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelCliente.Location = New System.Drawing.Point(621, 629)
        Me.btnCancelCliente.Name = "btnCancelCliente"
        Me.btnCancelCliente.Size = New System.Drawing.Size(213, 57)
        Me.btnCancelCliente.TabIndex = 41
        Me.btnCancelCliente.Text = "CANCELAR"
        Me.btnCancelCliente.UseVisualStyleBackColor = True
        '
        'btnCommitCliente
        '
        Me.btnCommitCliente.FlatAppearance.BorderSize = 0
        Me.btnCommitCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommitCliente.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommitCliente.Location = New System.Drawing.Point(186, 629)
        Me.btnCommitCliente.Name = "btnCommitCliente"
        Me.btnCommitCliente.Size = New System.Drawing.Size(213, 57)
        Me.btnCommitCliente.TabIndex = 40
        Me.btnCommitCliente.Text = "SALVAR"
        Me.btnCommitCliente.UseVisualStyleBackColor = True
        '
        'txtSobreCliente
        '
        Me.txtSobreCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSobreCliente.Location = New System.Drawing.Point(556, 109)
        Me.txtSobreCliente.Name = "txtSobreCliente"
        Me.txtSobreCliente.Size = New System.Drawing.Size(278, 35)
        Me.txtSobreCliente.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(548, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 44)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "s.nome"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Raleway", 24.0!)
        Me.Label15.Location = New System.Drawing.Point(430, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(172, 44)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "CLIENTES"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNameCliente
        '
        Me.txtNameCliente.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameCliente.Location = New System.Drawing.Point(186, 107)
        Me.txtNameCliente.Name = "txtNameCliente"
        Me.txtNameCliente.Size = New System.Drawing.Size(278, 35)
        Me.txtNameCliente.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(178, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 44)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "nome:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1000, 2)
        Me.Panel3.TabIndex = 22
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
        'panelFuncionario
        '
        Me.panelFuncionario.Controls.Add(Me.txtSenhaFuncionario)
        Me.panelFuncionario.Controls.Add(Me.Label34)
        Me.panelFuncionario.Controls.Add(Me.txtFixFuncionario)
        Me.panelFuncionario.Controls.Add(Me.Label39)
        Me.panelFuncionario.Controls.Add(Me.txtCelFuncionario)
        Me.panelFuncionario.Controls.Add(Me.Label40)
        Me.panelFuncionario.Controls.Add(Me.txtEmailFuncionario)
        Me.panelFuncionario.Controls.Add(Me.Label41)
        Me.panelFuncionario.Controls.Add(Me.btnCancelFuncionario)
        Me.panelFuncionario.Controls.Add(Me.btnCommitFuncionario)
        Me.panelFuncionario.Controls.Add(Me.txtSobreFuncionario)
        Me.panelFuncionario.Controls.Add(Me.Label42)
        Me.panelFuncionario.Controls.Add(Me.Label43)
        Me.panelFuncionario.Controls.Add(Me.txtNomeFuncionario)
        Me.panelFuncionario.Controls.Add(Me.Label44)
        Me.panelFuncionario.Controls.Add(Me.Panel6)
        Me.panelFuncionario.Location = New System.Drawing.Point(0, 0)
        Me.panelFuncionario.Name = "panelFuncionario"
        Me.panelFuncionario.Size = New System.Drawing.Size(1000, 700)
        Me.panelFuncionario.TabIndex = 44
        '
        'txtSenhaFuncionario
        '
        Me.txtSenhaFuncionario.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenhaFuncionario.Location = New System.Drawing.Point(186, 375)
        Me.txtSenhaFuncionario.Name = "txtSenhaFuncionario"
        Me.txtSenhaFuncionario.Size = New System.Drawing.Size(648, 35)
        Me.txtSenhaFuncionario.TabIndex = 57
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(178, 334)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(113, 44)
        Me.Label34.TabIndex = 56
        Me.Label34.Text = "senha:"
        '
        'txtFixFuncionario
        '
        Me.txtFixFuncionario.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixFuncionario.Location = New System.Drawing.Point(556, 449)
        Me.txtFixFuncionario.Name = "txtFixFuncionario"
        Me.txtFixFuncionario.Size = New System.Drawing.Size(278, 35)
        Me.txtFixFuncionario.TabIndex = 47
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(548, 408)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(75, 44)
        Me.Label39.TabIndex = 46
        Me.Label39.Text = "fixo:"
        '
        'txtCelFuncionario
        '
        Me.txtCelFuncionario.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelFuncionario.Location = New System.Drawing.Point(186, 449)
        Me.txtCelFuncionario.Name = "txtCelFuncionario"
        Me.txtCelFuncionario.Size = New System.Drawing.Size(278, 35)
        Me.txtCelFuncionario.TabIndex = 45
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(178, 408)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(125, 44)
        Me.Label40.TabIndex = 44
        Me.Label40.Text = "celular:"
        '
        'txtEmailFuncionario
        '
        Me.txtEmailFuncionario.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailFuncionario.Location = New System.Drawing.Point(186, 299)
        Me.txtEmailFuncionario.Name = "txtEmailFuncionario"
        Me.txtEmailFuncionario.Size = New System.Drawing.Size(648, 35)
        Me.txtEmailFuncionario.TabIndex = 43
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(178, 258)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(106, 44)
        Me.Label41.TabIndex = 42
        Me.Label41.Text = "email:"
        '
        'btnCancelFuncionario
        '
        Me.btnCancelFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelFuncionario.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelFuncionario.Location = New System.Drawing.Point(621, 629)
        Me.btnCancelFuncionario.Name = "btnCancelFuncionario"
        Me.btnCancelFuncionario.Size = New System.Drawing.Size(213, 57)
        Me.btnCancelFuncionario.TabIndex = 41
        Me.btnCancelFuncionario.Text = "CANCELAR"
        Me.btnCancelFuncionario.UseVisualStyleBackColor = True
        '
        'btnCommitFuncionario
        '
        Me.btnCommitFuncionario.FlatAppearance.BorderSize = 0
        Me.btnCommitFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommitFuncionario.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommitFuncionario.Location = New System.Drawing.Point(186, 629)
        Me.btnCommitFuncionario.Name = "btnCommitFuncionario"
        Me.btnCommitFuncionario.Size = New System.Drawing.Size(213, 57)
        Me.btnCommitFuncionario.TabIndex = 40
        Me.btnCommitFuncionario.Text = "SALVAR"
        Me.btnCommitFuncionario.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Raleway", 24.0!)
        Me.Label43.Location = New System.Drawing.Point(430, 10)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(261, 44)
        Me.Label43.TabIndex = 23
        Me.Label43.Text = "FUNCIONÁRIOS"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNomeFuncionario
        '
        Me.txtNomeFuncionario.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeFuncionario.Location = New System.Drawing.Point(186, 223)
        Me.txtNomeFuncionario.Name = "txtNomeFuncionario"
        Me.txtNomeFuncionario.Size = New System.Drawing.Size(278, 35)
        Me.txtNomeFuncionario.TabIndex = 25
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(178, 182)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(111, 44)
        Me.Label44.TabIndex = 24
        Me.Label44.Text = "nome:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(0, 61)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1000, 2)
        Me.Panel6.TabIndex = 22
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(548, 184)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(126, 44)
        Me.Label42.TabIndex = 34
        Me.Label42.Text = "s.nome"
        '
        'txtSobreFuncionario
        '
        Me.txtSobreFuncionario.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSobreFuncionario.Location = New System.Drawing.Point(556, 225)
        Me.txtSobreFuncionario.Name = "txtSobreFuncionario"
        Me.txtSobreFuncionario.Size = New System.Drawing.Size(278, 35)
        Me.txtSobreFuncionario.TabIndex = 35
        '
        'FormCadaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.panelFuncionario)
        Me.Controls.Add(Me.panelCliente)
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
        Me.panelCliente.ResumeLayout(False)
        Me.panelCliente.PerformLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFuncionario.ResumeLayout(False)
        Me.panelFuncionario.PerformLayout()
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
    Friend WithEvents panelCliente As Panel
    Friend WithEvents txtCidadeCliente As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtEstadoCliente As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtFixCliente As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCelCliente As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnCancelCliente As Button
    Friend WithEvents btnCommitCliente As Button
    Friend WithEvents txtSobreCliente As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNameCliente As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtCepCliente As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtBairroCliente As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtRuaCliente As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtCompleCliente As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtNumResCliente As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents panelFuncionario As Panel
    Friend WithEvents txtSenhaFuncionario As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtFixFuncionario As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txtCelFuncionario As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txtEmailFuncionario As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents btnCancelFuncionario As Button
    Friend WithEvents btnCommitFuncionario As Button
    Friend WithEvents txtSobreFuncionario As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents txtNomeFuncionario As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Panel6 As Panel
End Class
