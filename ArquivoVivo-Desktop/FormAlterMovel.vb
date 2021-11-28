Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Path
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Public Class FormAlterMovel

    Private imageUser As Image
    Dim fileName As String
    Private imageUser2 As Image
    Dim fileName2 As String
    Dim UploadImage As Boolean = False

    Private Sub FormAlterMovel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ArquivovivomvDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
        Me.CategoriaTableAdapter.Fill(Me.ArquivovivomvDataSet.categoria)
        'TODO: esta linha de código carrega dados na tabela 'ArquivovivomvDataSet.designers'. Você pode movê-la ou removê-la conforme necessário.
        Me.DesignersTableAdapter.Fill(Me.ArquivovivomvDataSet.designers)
        'Carregamento dos dados enviados pelo clique duplo
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT m_titulo, m_desc, ct_nome, m.ct_id as idcat, d_nome, m_valUni, m_qtdEstoque FROM moveis AS m, categoria AS c, designers AS d
                                     WHERE m.ct_id = c.ct_id AND m.d_id = d.d_id AND m.m_id = '" & idQuery & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                While reader.Read()
                    txtTitleMovel.Text = reader("m_titulo").ToString
                    txtDescMovel.Text = reader("m_desc").ToString
                    cboxCatMovel.SelectedValue = reader("idcat")
                    cboxCatMovel.Text = reader("ct_nome").ToString
                    cboxDesignersMovel.Text = reader("d_nome").ToString
                    txtValueMovel.Text = reader("m_valUni").ToString.Replace("R$ ", "")
                    cboxQtdMovel.Text = reader("m_qtdEstoque").ToString
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
        rescueImage()

        WhiteButton(btnCancel)
        DarkGrayButton(btnCommitMovel)
        BlackButton(btnImageMovel)
    End Sub

    Private Sub rescueImage()

        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT m_imagem FROM moveis WHERE m_id = '" & idQuery & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable

                Dim tempImagem As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
                Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
                Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
                fs.Write(tempImagem, 0, tempImagem.Length)
                fs.Flush()
                fs.Close()

                picboxImageUploadMovel.Image = Image.FromFile(strArquivo)

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub btnCommitMovel_Click(sender As Object, e As EventArgs) Handles btnCommitMovel.Click
        Dim Response

        Response = MsgBox("Quer mesmo alterar o móvel de ID " & idQuery & "?", vbOKCancel, "ALTERAR CLIENTE")

        If Response = vbOK Then
            Dim titulo, desc, typeImg As String
            Dim qtd As Integer
            Dim value As Double

            'atribuição de valores às variáveis
            titulo = txtTitleMovel.Text
            desc = txtDescMovel.Text
            qtd = cboxQtdMovel.Text
            value = txtValueMovel.Text

            Using con As MySqlConnection = GetConnectionMysql()
                Try
                    'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                    con.Open()
                    'Validação do upload de imagem para o banco de dados
                    If UploadImage Then
                        Dim sql As String = "UPDATE moveis SET m_titulo=@title, m_desc=@desc, ct_id=@idCat, 
                                        d_id=@idDesigner, m_valUni=@value, m_qtdEstoque=@qtd, m_imagem=@image, m_typeImg=@type WHERE m_id = '" & idQuery & "'"

                        Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                        'Atribuição dos parâmetros
                        cmd.Parameters.AddWithValue("@title", titulo)
                        cmd.Parameters.AddWithValue("@desc", desc)
                        cmd.Parameters.AddWithValue("@idCat", cboxCatMovel.SelectedValue)
                        cmd.Parameters.AddWithValue("@idDesigner", cboxDesignersMovel.SelectedValue)
                        cmd.Parameters.AddWithValue("@value", value)
                        cmd.Parameters.AddWithValue("@qtd", qtd)
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
                    Else
                        Dim sql As String = "UPDATE moveis SET m_titulo=@title, m_desc=@desc, ct_id=@idCat, 
                                        d_id=@idDesigner, m_valUni=@value, m_qtdEstoque=@qtd WHERE m_id = '" & idQuery & "'"

                        Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                        'Atribuição dos parâmetros
                        cmd.Parameters.AddWithValue("@title", titulo)
                        cmd.Parameters.AddWithValue("@desc", desc)
                        cmd.Parameters.AddWithValue("@idCat", cboxCatMovel.SelectedValue)
                        cmd.Parameters.AddWithValue("@idDesigner", cboxDesignersMovel.SelectedValue)
                        cmd.Parameters.AddWithValue("@value", value)
                        cmd.Parameters.AddWithValue("@qtd", qtd)
                        'Cadastro concluído
                        Dim reader As MySqlDataReader = cmd.ExecuteReader
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                    idQuery = Nothing
                    FormHome.Show()
                    Me.Close()
                End Try
            End Using
        Else
            Using con As MySqlConnection = GetConnectionMysql()
                Try
                    con.Open()
                    Dim sql As String = "SELECT m_titulo, m_desc, ct_nome, m.ct_id as idcat, d_nome, m_valUni, m_qtdEstoque FROM moveis AS m, categoria AS c, designers AS d
                                         WHERE m.ct_id = c.ct_id AND m.d_id = d.d_id AND m.m_id = '" & idQuery & "'"
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    Dim reader As MySqlDataReader = cmd.ExecuteReader

                    While reader.Read()
                        txtTitleMovel.Text = reader("m_titulo").ToString
                        txtDescMovel.Text = reader("m_desc").ToString
                        cboxCatMovel.SelectedValue = reader("idcat")
                        cboxCatMovel.Text = reader("ct_nome").ToString
                        cboxDesignersMovel.Text = reader("d_nome").ToString
                        txtValueMovel.Text = reader("m_valUni").ToString.Replace("R$ ", "")
                        cboxQtdMovel.Text = reader("m_qtdEstoque").ToString
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            End Using
            rescueImage()
        End If
    End Sub

    Private Sub btnImageMovel_Click(sender As Object, e As EventArgs) Handles btnImageMovel.Click
        Using OFD As New OpenFileDialog With {.Filter = "image File(*.jpg;*.png;*)|*.jpg;*.png;*"}
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                fileName = Path.GetExtension(OFD.FileName)
                fileName = fileName.ToUpper

                imageUser = Image.FromFile(OFD.FileName)
                picboxImageUploadMovel.Image = imageUser

                UploadImage = True
            End If
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        idQuery = Nothing
        FormHome.Show()
        Me.Close()
    End Sub
End Class