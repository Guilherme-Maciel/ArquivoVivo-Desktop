Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Path
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

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

        WhiteButton(btnCancel)
        WhiteButton(btnCancelDesigner)

        comboBoxCat()
        comboBoxQtd()
    End Sub
    'Movel
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
        Dim title, desc, cat, designer, typeImg, dataFormat As String
        Dim value, qtd As Double
        Dim data As DateTime = DateTime.Now

        'atribuição de valores às variáveis
        title = txtTitleMovel.Text
        desc = txtDescMovel.Text
        cat = cboxCatMovel.Text
        designer = cboxDesignersMovel.Text
        value = txtValueMovel.Text
        qtd = cboxQtdMovel.Text
        dataFormat = Format(data, "s")

        Using con As MySqlConnection = GetConnectionMysql()
            Try
                'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                con.Open()
                Dim sql As String = "INSERT INTO moveis(m_titulo, m_desc, m_categoria, m_designers, m_valUni, m_qtdEstoque, m_imagem, m_typeImg, m_dtReg) VALUES(@title, @desc, @cat, @designer, @value, @qtd, @image, @type, @date)"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                'Atribuição dos parâmetros
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
            End Try
        End Using
        txtTitleMovel.Clear()
        txtDescMovel.Clear()
        cboxCatMovel.SelectedIndex = -1
        cboxDesignersMovel.SelectedIndex = -1
        txtValueMovel.Clear()
        cboxQtdMovel.SelectedIndex = -1
        picboxImageUploadMovel.Image = Nothing

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FormHome.Show()
        Me.Close()
    End Sub

    'Designer
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
            End Try
        End Using
        txtNameDesigner.Clear()
        txtBioDesigner.Clear()
        picboxImageUploadDesigner.Image = Nothing

    End Sub
    Private Sub btnCancelDesigner_Click(sender As Object, e As EventArgs) Handles btnCancelDesigner.Click
        FormHome.Show()
        Me.Close()
    End Sub

    Private Sub cadastroDecision(i As Integer)
        If (i = 1) Then
            panelMovel.Visible = True
        End If

        If (i = 2) Then
            panelDesigner.Visible = True
        End If

    End Sub
    'Procedimento de atribuição do método textBoxMoeda()
    Private Sub txtValue_TextChanged(sender As Object, e As EventArgs) Handles txtValueMovel.TextChanged
        TextBoxMoeda(txtValueMovel)
    End Sub

    'Procedimentos ComboBox
    Private Sub cboxCat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboxCatMovel.KeyPress
        e.Handled = True
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

    Public Sub comboBoxCat()
        cboxCatMovel.Items.Add("APARADOR")
        cboxCatMovel.Items.Add("CADEIRAS")
        cboxCatMovel.Items.Add("CREDENZA")
        cboxCatMovel.Items.Add("ESCRIVANINHA")
        cboxCatMovel.Items.Add("ESTANTE")
        cboxCatMovel.Items.Add("MESA LATERAL")
        cboxCatMovel.Items.Add("MESA ALTA")
        cboxCatMovel.Items.Add("MESAS DE CENTRO")
        cboxCatMovel.Items.Add("OBJETOS")
        cboxCatMovel.Items.Add("POLTRONAS")
        cboxCatMovel.Items.Add("SOFÁS")
    End Sub

    'init sub
    Private Sub panelInvisible()
        panelMovel.Visible = False
        panelDesigner.Visible = False

    End Sub


End Class