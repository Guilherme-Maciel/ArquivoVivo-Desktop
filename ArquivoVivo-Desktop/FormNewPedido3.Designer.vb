<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNewPedido3
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelMovel = New System.Windows.Forms.Panel()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNPedido = New System.Windows.Forms.Label()
        Me.lblOrdens = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFixo = New System.Windows.Forms.Label()
        Me.lblCel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblRua = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.dtGridPedido = New System.Windows.Forms.DataGridView()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArquivovivomvDataSet = New ArquivoVivo_Desktop.arquivovivomvDataSet()
        Me.PedidosTableAdapter = New ArquivoVivo_Desktop.arquivovivomvDataSetTableAdapters.pedidosTableAdapter()
        Me.panelMovel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtGridPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArquivovivomvDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMovel
        '
        Me.panelMovel.Controls.Add(Me.dtGridPedido)
        Me.panelMovel.Controls.Add(Me.Panel2)
        Me.panelMovel.Controls.Add(Me.Panel1)
        Me.panelMovel.Controls.Add(Me.btnCommit)
        Me.panelMovel.Controls.Add(Me.btnCancel)
        Me.panelMovel.Controls.Add(Me.Label83)
        Me.panelMovel.Controls.Add(Me.Panel28)
        Me.panelMovel.Location = New System.Drawing.Point(0, 0)
        Me.panelMovel.Name = "panelMovel"
        Me.panelMovel.Size = New System.Drawing.Size(1000, 700)
        Me.panelMovel.TabIndex = 31
        '
        'btnCommit
        '
        Me.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommit.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.Location = New System.Drawing.Point(393, 327)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(213, 57)
        Me.btnCommit.TabIndex = 45
        Me.btnCommit.Text = "REGISTRAR"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Raleway Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(12, 327)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(213, 57)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "CANCELAR"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.Label6.Location = New System.Drawing.Point(14, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 37)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "N° PEDIDO:"
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
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.Black
        Me.Panel28.Location = New System.Drawing.Point(0, 61)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(1000, 2)
        Me.Panel28.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.lblData)
        Me.Panel1.Controls.Add(Me.lblOrdens)
        Me.Panel1.Controls.Add(Me.lblNPedido)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(12, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 251)
        Me.Panel1.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(14, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 37)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ORDENS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(14, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 37)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "DATA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(14, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 37)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "TOTAL:"
        '
        'lblNPedido
        '
        Me.lblNPedido.AutoSize = True
        Me.lblNPedido.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.lblNPedido.Location = New System.Drawing.Point(165, 13)
        Me.lblNPedido.Name = "lblNPedido"
        Me.lblNPedido.Size = New System.Drawing.Size(0, 37)
        Me.lblNPedido.TabIndex = 38
        '
        'lblOrdens
        '
        Me.lblOrdens.AutoSize = True
        Me.lblOrdens.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.lblOrdens.Location = New System.Drawing.Point(143, 76)
        Me.lblOrdens.Name = "lblOrdens"
        Me.lblOrdens.Size = New System.Drawing.Size(0, 37)
        Me.lblOrdens.TabIndex = 39
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.lblData.Location = New System.Drawing.Point(98, 139)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(0, 37)
        Me.lblData.TabIndex = 40
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.lblTotal.Location = New System.Drawing.Point(114, 202)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 37)
        Me.lblTotal.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblEmail)
        Me.Panel2.Controls.Add(Me.lblBairro)
        Me.Panel2.Controls.Add(Me.lblRua)
        Me.Panel2.Controls.Add(Me.lblCep)
        Me.Panel2.Controls.Add(Me.lblCliente)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.lblCel)
        Me.Panel2.Controls.Add(Me.lblFixo)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label)
        Me.Panel2.Location = New System.Drawing.Point(393, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 251)
        Me.Panel2.TabIndex = 55
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.Label.Location = New System.Drawing.Point(6, 7)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(134, 37)
        Me.Label.TabIndex = 34
        Me.Label.Text = "CLIENTE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 37)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "CEP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway Light", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(257, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 34)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "CELULAR:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Raleway Light", 18.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 34)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "FIXO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 37)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "BAIRRO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Raleway Light", 20.0!)
        Me.Label9.Location = New System.Drawing.Point(6, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 37)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "RUA:"
        '
        'lblFixo
        '
        Me.lblFixo.AutoSize = True
        Me.lblFixo.Font = New System.Drawing.Font("Raleway Light", 16.0!)
        Me.lblFixo.Location = New System.Drawing.Point(73, 173)
        Me.lblFixo.Name = "lblFixo"
        Me.lblFixo.Size = New System.Drawing.Size(178, 30)
        Me.lblFixo.TabIndex = 40
        Me.lblFixo.Text = "55 11 94210-4521"
        '
        'lblCel
        '
        Me.lblCel.AutoSize = True
        Me.lblCel.Font = New System.Drawing.Font("Raleway Light", 16.0!)
        Me.lblCel.Location = New System.Drawing.Point(381, 173)
        Me.lblCel.Name = "lblCel"
        Me.lblCel.Size = New System.Drawing.Size(178, 30)
        Me.lblCel.TabIndex = 41
        Me.lblCel.Text = "55 11 94210-4521"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Raleway Light", 18.0!)
        Me.Label12.Location = New System.Drawing.Point(7, 209)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 34)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "EMAIL:"
        '
        'lblCliente
        '
        Me.lblCliente.Font = New System.Drawing.Font("Raleway Light", 16.0!)
        Me.lblCliente.Location = New System.Drawing.Point(136, 14)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(443, 30)
        Me.lblCliente.TabIndex = 43
        Me.lblCliente.Text = "(NULL)"
        '
        'lblCep
        '
        Me.lblCep.Font = New System.Drawing.Font("Raleway Light", 16.0!)
        Me.lblCep.Location = New System.Drawing.Point(77, 54)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(502, 30)
        Me.lblCep.TabIndex = 44
        Me.lblCep.Text = "(NULL)"
        '
        'lblRua
        '
        Me.lblRua.Font = New System.Drawing.Font("Raleway Light", 16.0!)
        Me.lblRua.Location = New System.Drawing.Point(79, 94)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(502, 30)
        Me.lblRua.TabIndex = 45
        Me.lblRua.Text = "(NULL)"
        '
        'lblBairro
        '
        Me.lblBairro.Font = New System.Drawing.Font("Raleway Light", 16.0!)
        Me.lblBairro.Location = New System.Drawing.Point(122, 134)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(450, 30)
        Me.lblBairro.TabIndex = 46
        Me.lblBairro.Text = "(NULL)"
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Raleway Light", 16.0!)
        Me.lblEmail.Location = New System.Drawing.Point(94, 213)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(488, 30)
        Me.lblEmail.TabIndex = 47
        Me.lblEmail.Text = "(NULL)"
        '
        'dtGridPedido
        '
        Me.dtGridPedido.AllowUserToAddRows = False
        Me.dtGridPedido.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Raleway Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtGridPedido.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtGridPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Raleway Light", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtGridPedido.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtGridPedido.ColumnHeadersHeight = 29
        Me.dtGridPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Raleway Light", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtGridPedido.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtGridPedido.EnableHeadersVisualStyles = False
        Me.dtGridPedido.Location = New System.Drawing.Point(12, 389)
        Me.dtGridPedido.Margin = New System.Windows.Forms.Padding(2)
        Me.dtGridPedido.Name = "dtGridPedido"
        Me.dtGridPedido.ReadOnly = True
        Me.dtGridPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtGridPedido.RowHeadersWidth = 20
        Me.dtGridPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Raleway Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle4.NullValue = "(sem dados)"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtGridPedido.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtGridPedido.Size = New System.Drawing.Size(977, 300)
        Me.dtGridPedido.TabIndex = 57
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
        Me.PedidosBindingSource.DataSource = Me.ArquivovivomvDataSet
        '
        'ArquivovivomvDataSet
        '
        Me.ArquivovivomvDataSet.DataSetName = "arquivovivomvDataSet"
        Me.ArquivovivomvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'FormNewPedido3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.panelMovel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormNewPedido3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNewPedido3"
        Me.panelMovel.ResumeLayout(False)
        Me.panelMovel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtGridPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArquivovivomvDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMovel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblBairro As Label
    Friend WithEvents lblRua As Label
    Friend WithEvents lblCep As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblCel As Label
    Friend WithEvents lblFixo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblOrdens As Label
    Friend WithEvents lblNPedido As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCommit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label83 As Label
    Friend WithEvents Panel28 As Panel
    Friend WithEvents dtGridPedido As DataGridView
    Friend WithEvents ArquivovivomvDataSet As arquivovivomvDataSet
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents PedidosTableAdapter As arquivovivomvDataSetTableAdapters.pedidosTableAdapter
End Class
