<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMoveisAmbiente2
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
        Me.btnFill = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.txtDesigner = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxTitle = New System.Windows.Forms.ComboBox()
        Me.MoveisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArquivovivomvDataSet = New ArquivoVivo_Desktop.arquivovivomvDataSet()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picboxImageUploadMovel = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.MoveisTableAdapter = New ArquivoVivo_Desktop.arquivovivomvDataSetTableAdapters.moveisTableAdapter()
        Me.panelMovel.SuspendLayout()
        CType(Me.MoveisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArquivovivomvDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxImageUploadMovel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMovel
        '
        Me.panelMovel.Controls.Add(Me.btnFill)
        Me.panelMovel.Controls.Add(Me.btnCommit)
        Me.panelMovel.Controls.Add(Me.txtDesigner)
        Me.panelMovel.Controls.Add(Me.Label2)
        Me.panelMovel.Controls.Add(Me.cboxTitle)
        Me.panelMovel.Controls.Add(Me.btnCancel)
        Me.panelMovel.Controls.Add(Me.btnNext)
        Me.panelMovel.Controls.Add(Me.picboxImageUploadMovel)
        Me.panelMovel.Controls.Add(Me.Label6)
        Me.panelMovel.Controls.Add(Me.txtDesc)
        Me.panelMovel.Controls.Add(Me.Label4)
        Me.panelMovel.Controls.Add(Me.Label83)
        Me.panelMovel.Controls.Add(Me.txtId)
        Me.panelMovel.Controls.Add(Me.Label1)
        Me.panelMovel.Controls.Add(Me.Panel28)
        Me.panelMovel.Location = New System.Drawing.Point(0, 0)
        Me.panelMovel.Name = "panelMovel"
        Me.panelMovel.Size = New System.Drawing.Size(1000, 700)
        Me.panelMovel.TabIndex = 29
        '
        'btnFill
        '
        Me.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFill.Font = New System.Drawing.Font("Raleway Light", 12.0!)
        Me.btnFill.Location = New System.Drawing.Point(393, 115)
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
        'txtDesigner
        '
        Me.txtDesigner.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesigner.Location = New System.Drawing.Point(33, 516)
        Me.txtDesigner.Name = "txtDesigner"
        Me.txtDesigner.ReadOnly = True
        Me.txtDesigner.Size = New System.Drawing.Size(528, 35)
        Me.txtDesigner.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 469)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 44)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "designer:"
        '
        'cboxTitle
        '
        Me.cboxTitle.DataSource = Me.MoveisBindingSource
        Me.cboxTitle.DisplayMember = "m_titulo"
        Me.cboxTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTitle.FormattingEnabled = True
        Me.cboxTitle.Location = New System.Drawing.Point(33, 198)
        Me.cboxTitle.Name = "cboxTitle"
        Me.cboxTitle.Size = New System.Drawing.Size(528, 35)
        Me.cboxTitle.TabIndex = 42
        Me.cboxTitle.ValueMember = "m_id"
        '
        'MoveisBindingSource
        '
        Me.MoveisBindingSource.DataMember = "moveis"
        Me.MoveisBindingSource.DataSource = Me.ArquivovivomvDataSet
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
        Me.Label6.Location = New System.Drawing.Point(25, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 44)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "título:"
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(33, 283)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(528, 184)
        Me.txtDesc.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 44)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "descrição:"
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
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(33, 115)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(95, 35)
        Me.txtId.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 44)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "id:"
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
        'FormMoveisAmbiente2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.panelMovel)
        Me.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "FormMoveisAmbiente2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMoveisAmbiente2"
        Me.panelMovel.ResumeLayout(False)
        Me.panelMovel.PerformLayout()
        CType(Me.MoveisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArquivovivomvDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxImageUploadMovel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMovel As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents picboxImageUploadMovel As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel28 As Panel
    Friend WithEvents btnFill As Button
    Friend WithEvents btnCommit As Button
    Friend WithEvents txtDesigner As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboxTitle As ComboBox
    Friend WithEvents ArquivovivomvDataSet As arquivovivomvDataSet
    Friend WithEvents MoveisBindingSource As BindingSource
    Friend WithEvents MoveisTableAdapter As arquivovivomvDataSetTableAdapters.moveisTableAdapter
End Class
