Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Path
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.Net
Imports System.Net.Mail

Public Class FormCadaster
    'Variáveis para cadastro de imagem
    Private imageUser As Image
    Dim fileName As String
    Private imageUser2 As Image
    Dim fileName2 As String

    Private Sub FormCadaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ArquivovivomvDataSet.designers'. Você pode movê-la ou removê-la conforme necessário.
        Me.DesignersTableAdapter.Fill(Me.ArquivovivomvDataSet.designers)

        panelInvisible()

        cadastroDecision(panelCadaster)

        BlackButton(btnImageMovel)
        BlackButton(btnImageDesigner)

        DarkGrayButton(btnCommitMovel)
        DarkGrayButton(btnCommitDesigner)
        DarkGrayButton(btnCommitCliente)
        DarkGrayButton(btnCommitFuncionario)

        WhiteButton(btnCancel)
        WhiteButton(btnCancelDesigner)
        WhiteButton(btnCancelCliente)
        WhiteButton(btnCancelFuncionario)

        comboBoxQtd()
        cboxCatItems()
    End Sub
    'MÓVEL
    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImageMovel.Click
        Using OFD As New OpenFileDialog With {.Filter = "image File(*.jpg;*.png;*)|*.jpg;*.png;*"}
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                fileName = Path.GetExtension(OFD.FileName)
                fileName = fileName.ToUpper

                imageUser = Image.FromFile(OFD.FileName)
                picboxImageUploadMovel.Image = imageUser
            End If
        End Using
    End Sub
    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommitMovel.Click
        Dim title, desc, designer, typeImg, dataFormat As String
        Dim idDesigner, cat As Integer
        Dim value, qtd As Double
        Dim data As DateTime = DateTime.Now

        'atribuição de valores às variáveis
        title = txtTitleMovel.Text
        desc = txtDescMovel.Text
        cat = cboxCatMovel.SelectedValue
        designer = cboxDesignersMovel.Text
        value = txtValueMovel.Text
        qtd = cboxQtdMovel.Text
        dataFormat = Format(data, "s")
        idDesigner = cboxDesignersMovel.SelectedValue

        Using con As MySqlConnection = GetConnectionMysql()
            Try
                'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                con.Open()
                Dim sql As String = "INSERT INTO moveis(d_id, m_titulo, m_desc, ct_id, m_designers, m_valUni, m_qtdEstoque, m_imagem, m_typeImg, m_dtReg) VALUES(@did, @title, @desc, @cat, @designer, @value, @qtd, @image, @type, @date)"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                'Atribuição dos parâmetros
                cmd.Parameters.AddWithValue("@did", idDesigner)
                cmd.Parameters.AddWithValue("@title", title)
                cmd.Parameters.AddWithValue("@desc", desc)
                cmd.Parameters.AddWithValue("@cat", cat)
                cmd.Parameters.AddWithValue("@designer", designer)
                cmd.Parameters.AddWithValue("@value", value)
                cmd.Parameters.AddWithValue("@qtd", qtd)
                cmd.Parameters.AddWithValue("@date", dataFormat)

                'Validação do upload de imagem para o banco de dados
                Using ms As New IO.MemoryStream
                    If fileName = ".PNG" Then
                        imageUser.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                        Dim byteArray = ms.ToArray
                        cmd.Parameters.AddWithValue("@image", byteArray)
                        typeImg = "image/jpeg"
                        cmd.Parameters.AddWithValue("@type", typeImg)
                    ElseIf fileName = ".JPG" Or fileName = ".JPEG" Then
                        imageUser.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        Dim byteArray = ms.ToArray
                        cmd.Parameters.AddWithValue("@image", byteArray)
                        typeImg = "image/png"
                        cmd.Parameters.AddWithValue("@type", typeImg)
                    End If
                End Using
                'Cadastro concluído
                Dim reader As MySqlDataReader = cmd.ExecuteReader


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtTitleMovel.Clear()
                txtDescMovel.Clear()
                cboxCatMovel.SelectedIndex = -1
                cboxDesignersMovel.SelectedIndex = -1
                txtValueMovel.Clear()
                cboxQtdMovel.SelectedIndex = -1
                picboxImageUploadMovel.Image = Nothing
            End Try
        End Using
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FormHome.Show()
        Me.Close()
    End Sub

    'DESIGNER
    Private Sub btnImageDesigner_Click(sender As Object, e As EventArgs) Handles btnImageDesigner.Click
        Using OFD As New OpenFileDialog With {.Filter = "image File(*.jpg;*.png;*)|*.jpg;*.png;*"}
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                fileName = Path.GetExtension(OFD.FileName)
                fileName = fileName.ToUpper

                imageUser = Image.FromFile(OFD.FileName)
                picboxImageUploadDesigner.Image = imageUser
            End If
        End Using
    End Sub
    Private Sub btnCommitDesigner_Click(sender As Object, e As EventArgs) Handles btnCommitDesigner.Click
        Dim name, bio, typeImg As String


        'atribuição de valores às variáveis
        name = txtNameDesigner.Text
        bio = txtBioDesigner.Text


        Using con As MySqlConnection = GetConnectionMysql()
            Try
                'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                con.Open()
                Dim sql As String = "INSERT INTO designers(d_nome, d_bio, d_imagem, d_typeImg) VALUES(@name, @bio, @image, @type)"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                'Atribuição dos parâmetros
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@bio", bio)

                'Validação do upload de imagem para o banco de dados
                Using ms As New IO.MemoryStream
                    If fileName = ".PNG" Then
                        imageUser.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                        Dim byteArray = ms.ToArray
                        cmd.Parameters.AddWithValue("@image", byteArray)
                        typeImg = "image/jpeg"
                        cmd.Parameters.AddWithValue("@type", typeImg)
                    ElseIf fileName = ".JPG" Or fileName = ".JPEG" Then
                        imageUser.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        Dim byteArray = ms.ToArray
                        cmd.Parameters.AddWithValue("@image", byteArray)
                        typeImg = "image/png"
                        cmd.Parameters.AddWithValue("@type", typeImg)
                    End If
                End Using
                'Cadastro concluído
                Dim reader As MySqlDataReader = cmd.ExecuteReader

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtNameDesigner.Clear()
                txtBioDesigner.Clear()
                picboxImageUploadDesigner.Image = Nothing
            End Try
        End Using
    End Sub
    Private Sub btnCancelDesigner_Click(sender As Object, e As EventArgs) Handles btnCancelDesigner.Click
        FormHome.Show()
        Me.Close()
    End Sub

    'CLIENTE
    Private Sub btnCommitCliente_Click(sender As Object, e As EventArgs) Handles btnCommitCliente.Click
        Dim name, lastName, email, cel, fix, estado, cidade, rua, bairro, cep, numRes, comple, password, state, dataFormat As String
        Dim data As DateTime = DateTime.Now

        'atribuição de valores às variáveis
        name = txtNameCliente.Text
        lastName = txtSobreCliente.Text
        email = txtEmailCliente.Text
        cel = txtCelCliente.Text
        fix = txtFixCliente.Text
        estado = txtEstadoCliente.Text
        cidade = txtCidadeCliente.Text
        rua = txtRuaCliente.Text
        bairro = txtBairroCliente.Text
        cep = txtCepCliente.Text
        numRes = txtNumResCliente.Text
        comple = txtCompleCliente.Text
        dataFormat = Format(data, "s")
        password = RandowPass()
        state = "ativo"

        Using con As MySqlConnection = GetConnectionMysql()
            Try
                'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                con.Open()
                Dim sql As String = "INSERT INTO cliente(c_nome, c_sobrenome, c_email, c_senha, c_estado, c_cidade, c_cep, c_rua, c_bairro, c_numRes, c_complemento, c_telCel, c_telFixo, c_dtReg, c_state)
                                     VALUES(@name, @lastName, @email, @password, @estado, @city, @cep, @street, @district, @numRes, @comple, @telCel, @telFix, @date, @state)"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                'Atribuição dos parâmetros
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@lastName", lastName)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@estado", estado)
                cmd.Parameters.AddWithValue("@city", cidade)
                cmd.Parameters.AddWithValue("@cep", cep)
                cmd.Parameters.AddWithValue("@street", rua)
                cmd.Parameters.AddWithValue("@district", bairro)
                cmd.Parameters.AddWithValue("@numRes", numRes)
                cmd.Parameters.AddWithValue("@comple", comple)
                cmd.Parameters.AddWithValue("@telCel", cel)
                cmd.Parameters.AddWithValue("@telFix", fix)
                cmd.Parameters.AddWithValue("@date", dataFormat)
                cmd.Parameters.AddWithValue("@state", state)

                'Cadastro concluído
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                'cria uma mensagem e envia por email ao usuário
                SendMail(password)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtNameCliente.Clear()
                txtSobreCliente.Clear()
                txtEmailCliente.Clear()
                txtCelCliente.Clear()
                txtFixCliente.Clear()
                txtEstadoCliente.Clear()
                txtCidadeCliente.Clear()
                txtRuaCliente.Clear()
                txtBairroCliente.Clear()
                txtCepCliente.Clear()
                txtNumResCliente.Clear()
                txtCompleCliente.Clear()
            End Try
        End Using
    End Sub
    Private Sub btnCancelCliente_Click(sender As Object, e As EventArgs) Handles btnCancelCliente.Click
        FormHome.Show()
        Me.Close()
    End Sub

    'FUNCIONÁRIO
    Private Sub btnCommitFuncionario_Click(sender As Object, e As EventArgs) Handles btnCommitFuncionario.Click
        Dim name, lastName, email, cel, fix, password, state, dataFormat As String
        Dim data As DateTime = DateTime.Now

        'atribuição de valores às variáveis
        name = txtNomeFuncionario.Text
        lastName = txtSobreFuncionario.Text
        email = txtEmailFuncionario.Text
        cel = txtCelFuncionario.Text
        fix = txtFixFuncionario.Text
        password = txtSenhaFuncionario.Text
        dataFormat = Format(data, "s")
        state = "ativo"

        Using con As MySqlConnection = GetConnectionMysql()
            Try
                'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                con.Open()
                Dim sql As String = "INSERT INTO funcionarios(f_nome, f_sobrenome, f_email, f_senha, f_telCel, f_telFixo, f_dtReg, f_state, f_type)
                                     VALUES(@name, @lastName, @email, @password, @telCel, @telFix, @date, @state, '2')"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                'Atribuição dos parâmetros
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@lastName", lastName)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@telCel", cel)
                cmd.Parameters.AddWithValue("@telFix", fix)
                cmd.Parameters.AddWithValue("@date", dataFormat)
                cmd.Parameters.AddWithValue("@state", state)

                'Cadastro concluído
                Dim reader As MySqlDataReader = cmd.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtNomeFuncionario.Clear()
                txtSobreFuncionario.Clear()
                txtEmailFuncionario.Clear()
                txtSenhaFuncionario.Clear()
                txtCelFuncionario.Clear()
                txtFixFuncionario.Clear()
            End Try
        End Using
    End Sub

    'Procedimento de atribuição do método textBoxMoeda()
    Private Sub txtValue_TextChanged(sender As Object, e As EventArgs) Handles txtValueMovel.TextChanged
        TextBoxMoeda(txtValueMovel)
    End Sub

    'Procedimentos ComboBox
    Private Sub cboxCat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboxCatMovel.KeyPress
        e.Handled = True
    End Sub
    Private Sub cboxCatItems()

        cboxCatMovel.DisplayMember = "Text"
        cboxCatMovel.ValueMember = "Value"

        Dim tb As New DataTable

        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))
        tb.Rows.Add("APARADOR", 3)
        tb.Rows.Add("CADEIRAS", 4)
        tb.Rows.Add("CREDENZA", 5)
        tb.Rows.Add("ESCRIVANINHA", 6)
        tb.Rows.Add("ESTANTE", 7)
        tb.Rows.Add("MESA LATERAL", 8)
        tb.Rows.Add("MESA ALTA", 9)
        tb.Rows.Add("MESA DE CENTRO", 10)
        tb.Rows.Add("OBJETOS", 11)
        tb.Rows.Add("POLTRONAS", 12)
        tb.Rows.Add("SOFÁS", 13)

        cboxCatMovel.DataSource = tb

    End Sub
    Private Sub cboxQtd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboxQtdMovel.KeyPress
        e.Handled = True
    End Sub
    Public Sub comboBoxQtd()
        Dim i As Integer

        While i < 999
            cboxQtdMovel.Items.Add(i)
            i = i + 1
        End While
    End Sub

    'init sub
    Private Sub panelInvisible()
        panelMovel.Visible = False
        panelDesigner.Visible = False
        panelCliente.Visible = False
        panelFuncionario.Visible = False
    End Sub
    Private Sub cadastroDecision(i As Integer)
        If (i = 1) Then
            panelMovel.Visible = True
        End If

        If (i = 2) Then
            panelDesigner.Visible = True
        End If

        If (i = 3) Then
            panelCliente.Visible = True
        End If

        If (i = 4) Then
            panelFuncionario.Visible = True
        End If
    End Sub

    'email function
    Private Function SendMail(ByVal password As String) As Boolean

        Dim objEnvio As SmtpClient = Nothing
        Dim objEmail As New MailMessage
        Dim blnReturn As Boolean = False

        Try
            objEnvio = New SmtpClient("smtp.gmail.com", "587")
            objEmail = New MailMessage

            'destino
            objEmail.To.Add(New MailAddress("guilhermeteste5932.ms@gmail.com", "Guilherme Maciel"))

            'remetente
            objEmail.From = New MailAddress("guilhermeteste5932.ms@gmail.com", "ARQUIVO VIVO MÓVEIS")

            'Mensagem
            objEmail.Subject = "ARQUIVO VIVO MÓVEIS - SENHA WEBSITE"
            objEmail.IsBodyHtml = True
            objEmail.Body = "Sua senha é: " & password & ". Faça login no site <arquivovivomoveis.com.br> e mude sua senha caso desejar :)"

            'credenciais
            objEnvio.EnableSsl = True
            objEnvio.UseDefaultCredentials = False
            Dim credentials As New NetworkCredential("guilhermeteste5932.ms@gmail.com", "59323466Teste")
            objEnvio.Credentials = credentials

            'enviar
            objEnvio.Send(objEmail)

            blnReturn = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objEmail = Nothing
            objEnvio = Nothing
        End Try

        Return blnReturn
    End Function
End Class