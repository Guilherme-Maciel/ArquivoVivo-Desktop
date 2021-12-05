<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewPedido2
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
        Me.components = New System.ComponentModel.Container()
        Me.panelMovel = New System.Windows.Forms.Panel()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbtnManual = New System.Windows.Forms.RadioButton()
        Me.rbtnAuto = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.checkAssis = New System.Windows.Forms.CheckBox()
        Me.checkVenda = New System.Windows.Forms.CheckBox()
        Me.checkLocacao = New System.Windows.Forms.CheckBox()
        Me.checkReforma = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboxQtd = New System.Windows.Forms.ComboBox()
        Me.btnFill = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.txtQtdManual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxTitle = New System.Windows.Forms.ComboBox()
        Me.MoveisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArquivovivomvDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArquivovivomvDataSet = New ArquivoVivo_Desktop.arquivovivomvDataSet()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picboxImageUploadMovel = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOrdem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.MoveisTableAdapter = New ArquivoVivo_Desktop.arquivovivomvDataSetTableAdapters.moveisTableAdapter()
        Me.panelMovel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.MoveisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArquivovivomvDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArquivovivomvDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxImageUploadMovel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMovel
        '
        Me.panelMovel.Controls.Add(Me.txtTitle)
        Me.panelMovel.Controls.Add(Me.Panel2)
        Me.panelMovel.Controls.Add(Me.Panel1)
        Me.panelMovel.Controls.Add(Me.btnCalculate)
        Me.panelMovel.Controls.Add(Me.txtValue)
        Me.panelMovel.Controls.Add(Me.Label3)
        Me.panelMovel.Controls.Add(Me.cboxQtd)
        Me.panelMovel.Controls.Add(Me.btnFill)
        Me.panelMovel.Controls.Add(Me.btnCommit)
        Me.panelMovel.Controls.Add(Me.txtQtdManual)
        Me.panelMovel.Controls.Add(Me.Label2)
        Me.panelMovel.Controls.Add(Me.cboxTitle)
        Me.panelMovel.Controls.Add(Me.btnCancel)
        Me.panelMovel.Controls.Add(Me.btnNext)
        Me.panelMovel.Controls.Add(Me.picboxImageUploadMovel)
        Me.panelMovel.Controls.Add(Me.Label6)
        Me.panelMovel.Controls.Add(Me.txtOrdem)
        Me.panelMovel.Controls.Add(Me.Label4)
        Me.panelMovel.Controls.Add(Me.Label83)
        Me.panelMovel.Controls.Add(Me.txtId)
        Me.panelMovel.Controls.Add(Me.lblId)
        Me.panelMovel.Controls.Add(Me.Panel28)
        Me.panelMovel.Location = New System.Drawing.Point(0, 0)
        Me.panelMovel.Name = "panelMovel"
        Me.panelMovel.Size = New System.Drawing.Size(1000, 700)
        Me.panelMovel.TabIndex = 30
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(33, 240)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(528, 35)
        Me.txtTitle.TabIndex = 53
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbtnManual)
        Me.Panel2.Controls.Add(Me.rbtnAuto)
        Me.Panel2.Location = New System.Drawing.Point(626, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 41)
        Me.Panel2.TabIndex = 52
        '
        'rbtnManual
        '
        Me.rbtnManual.AutoSize = True
        Me.rbtnManual.Font = New System.Drawing.Font("Raleway Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnManual.Location = New System.Drawing.Point(219, 7)
        Me.rbtnManual.Name = "rbtnManual"
        Me.rbtnManual.Size = New System.Drawing.Size(82, 26)
        Me.rbtnManual.TabIndex = 2
        Me.rbtnManual.TabStop = True
        Me.rbtnManual.Text = "Manual"
        Me.rbtnManual.UseVisualStyleBackColor = True
        '
        'rbtnAuto
        '
        Me.rbtnAuto.AutoSize = True
        Me.rbtnAuto.Font = New System.Drawing.Font("Raleway Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAuto.Location = New System.Drawing.Point(5, 7)
        Me.rbtnAuto.Name = "rbtnAuto"
        Me.rbtnAuto.Size = New System.Drawing.Size(112, 26)
        Me.rbtnAuto.TabIndex = 0
        Me.rbtnAuto.TabStop = True
        Me.rbtnAuto.Text = "Automático"
        Me.rbtnAuto.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.checkAssis)
        Me.Panel1.Controls.Add(Me.checkVenda)
        Me.Panel1.Controls.Add(Me.checkLocacao)
        Me.Panel1.Controls.Add(Me.checkReforma)
        Me.Panel1.Location = New System.Drawing.Point(33, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 41)
        Me.Panel1.TabIndex = 51
        '
        'checkAssis
        '
        Me.checkAssis.AutoSize = True
        Me.checkAssis.Font = New System.Drawing.Font("Raleway Light", 12.0!)
        Me.checkAssis.Location = New System.Drawing.Point(278, 8)
        Me.checkAssis.Name = "checkAssis"
        Me.checkAssis.Size = New System.Drawing.Size(111, 26)
        Me.checkAssis.TabIndex = 57
        Me.checkAssis.Text = "Assistência"
        Me.checkAssis.UseVisualStyleBackColor = True
        '
        'checkVenda
        '
        Me.checkVenda.AutoSize = True
        Me.checkVenda.Font = New System.Drawing.Font("Raleway Light", 12.0!)
        Me.checkVenda.Location = New System.Drawing.Point(3, 8)
        Me.checkVenda.Name = "checkVenda"
        Me.checkVenda.Size = New System.Drawing.Size(76, 26)
        Me.checkVenda.TabIndex = 54
        Me.checkVenda.Text = "Venda"
        Me.checkVenda.UseVisualStyleBackColor = True
        '
        'checkLocacao
        '
        Me.checkLocacao.AutoSize = True
        Me.checkLocacao.Font = New System.Drawing.Font("Raleway Light", 12.0!)
        Me.checkLocacao.Location = New System.Drawing.Point(182, 8)
        Me.checkLocacao.Name = "checkLocacao"
        Me.checkLocacao.Size = New System.Drawing.Size(92, 26)
        Me.checkLocacao.TabIndex = 56
        Me.checkLocacao.Text = "Locação"
        Me.checkLocacao.UseVisualStyleBackColor = True
        '
        'checkReforma
        '
        Me.checkReforma.AutoSize = True
        Me.checkReforma.Font = New System.Drawing.Font("Raleway Light", 12.0!)
        Me.checkReforma.Location = New System.Drawing.Point(85, 8)
        Me.checkReforma.Name = "checkReforma"
        Me.checkReforma.Size = New System.Drawing.Size(91, 26)
        Me.checkReforma.TabIndex = 55
        Me.checkReforma.Text = "Reforma"
        Me.checkReforma.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Raleway Light", 12.0!)
        Me.btnCalculate.Location = New System.Drawing.Point(228, 559)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(138, 32)
        Me.btnCalculate.TabIndex = 50
        Me.btnCalculate.Text = "CALCULAR"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(376, 557)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(185, 35)
        Me.txtValue.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(368, 512)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 44)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "valor:"
        '
        'cboxQtd
        '
        Me.cboxQtd.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.cboxQtd.FormattingEnabled = True
        Me.cboxQtd.Location = New System.Drawing.Point(33, 556)
        Me.cboxQtd.Name = "cboxQtd"
        Me.cboxQtd.Size = New System.Drawing.Size(185, 37)
        Me.cboxQtd.TabIndex = 47
        '
        'btnFill
        '
        Me.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFill.Font = New System.Drawing.Font("Raleway Light", 12.0!)
        Me.btnFill.Location = New System.Drawing.Point(393, 157)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(168, 32)
        Me.btnFill.TabIndex = 46
        Me.btnFill.Text = "PREENCHER"
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'btnCommit
        '
        Me.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommit.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.Location = New System.Drawing.Point(646, 629)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(213, 57)
        Me.btnCommit.TabIndex = 45
        Me.btnCommit.Text = "FINALIZAR"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'txtQtdManual
        '
        Me.txtQtdManual.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdManual.Location = New System.Drawing.Point(33, 558)
        Me.txtQtdManual.Name = "txtQtdManual"
        Me.txtQtdManual.Size = New System.Drawing.Size(185, 35)
        Me.txtQtdManual.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 511)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 44)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "quantidade:"
        '
        'cboxTitle
        '
        Me.cboxTitle.DataSource = Me.MoveisBindingSource
        Me.cboxTitle.DisplayMember = "m_titulo"
        Me.cboxTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTitle.FormattingEnabled = True
        Me.cboxTitle.Location = New System.Drawing.Point(33, 240)
        Me.cboxTitle.Name = "cboxTitle"
        Me.cboxTitle.Size = New System.Drawing.Size(528, 35)
        Me.cboxTitle.TabIndex = 42
        Me.cboxTitle.ValueMember = "m_id"
        '
        'MoveisBindingSource
        '
        Me.MoveisBindingSource.DataMember = "moveis"
        Me.MoveisBindingSource.DataSource = Me.ArquivovivomvDataSetBindingSource
        '
        'ArquivovivomvDataSetBindingSource
        '
        Me.ArquivovivomvDataSetBindingSource.DataSource = Me.ArquivovivomvDataSet
        Me.ArquivovivomvDataSetBindingSource.Position = 0
        '
        'ArquivovivomvDataSet
        '
        Me.ArquivovivomvDataSet.DataSetName = "arquivovivomvDataSet"
        Me.ArquivovivomvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(393, 629)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(213, 57)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "CANCELAR"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(140, 629)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(213, 57)
        Me.btnNext.TabIndex = 40
        Me.btnNext.Text = "PRÓXIMO"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'picboxImageUploadMovel
        '
        Me.picboxImageUploadMovel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxImageUploadMovel.Location = New System.Drawing.Point(626, 201)
        Me.picboxImageUploadMovel.Name = "picboxImageUploadMovel"
        Me.picboxImageUploadMovel.Size = New System.Drawing.Size(304, 304)
        Me.picboxImageUploadMovel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxImageUploadMovel.TabIndex = 36
        Me.picboxImageUploadMovel.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 44)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "título:"
        '
        'txtOrdem
        '
        Me.txtOrdem.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdem.Location = New System.Drawing.Point(33, 325)
        Me.txtOrdem.Multiline = True
        Me.txtOrdem.Name = "txtOrdem"
        Me.txtOrdem.Size = New System.Drawing.Size(528, 184)
        Me.txtOrdem.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 44)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "ordem:"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Raleway", 24.0!)
        Me.Label83.Location = New System.Drawing.Point(430, 10)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(138, 44)
        Me.Label83.TabIndex = 23
        Me.Label83.Text = "PEDIDO"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(33, 157)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(95, 35)
        Me.txtId.TabIndex = 25
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(25, 110)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(53, 44)
        Me.lblId.TabIndex = 24
        Me.lblId.Text = "id:"
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.Black
        Me.Panel28.Location = New System.Drawing.Point(0, 61)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(1000, 2)
        Me.Panel28.TabIndex = 22
        '
        'MoveisTableAdapter
        '
        Me.MoveisTableAdapter.ClearBeforeFill = True
        '
        'FormNewPedido2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.panelMovel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormNewPedido2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNewPedido2"
        Me.panelMovel.ResumeLayout(False)
        Me.panelMovel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MoveisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArquivovivomvDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArquivovivomvDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxImageUploadMovel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMovel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rbtnManual As RadioButton
    Friend WithEvents rbtnAuto As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtValue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboxQtd As ComboBox
    Friend WithEvents btnFill As Button
    Friend WithEvents btnCommit As Button
    Friend WithEvents txtQtdManual As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboxTitle As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents picboxImageUploadMovel As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOrdem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents Panel28 As Panel
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents ArquivovivomvDataSetBindingSource As BindingSource
    Friend WithEvents ArquivovivomvDataSet As arquivovivomvDataSet
    Friend WithEvents MoveisBindingSource As BindingSource
    Friend WithEvents MoveisTableAdapter As arquivovivomvDataSetTableAdapters.moveisTableAdapter
    Friend WithEvents checkAssis As CheckBox
    Friend WithEvents checkLocacao As CheckBox
    Friend WithEvents checkReforma As CheckBox
    Friend WithEvents checkVenda As CheckBox
End Class
