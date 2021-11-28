Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Path
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Public Class FormAlterDesigner
    Private imageUser As Image
    Dim fileName As String
    Private imageUser2 As Image
    Dim fileName2 As String
    Dim UploadImage As Boolean = False
    Private Sub FormAlterDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT d_nome, d_bio FROM designers
                                     WHERE d_id = '" & idQuery & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                While reader.Read()
                    txtNameDesigner.Text = reader("d_nome").ToString
                    txtBioDesigner.Text = reader("d_bio").ToString

                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
        rescueImage()
        WhiteButton(btnCancelDesigner)
        DarkGrayButton(btnCommitDesigner)
        BlackButton(btnImageDesigner)
    End Sub

    Private Sub btnCommitDesigner_Click(sender As Object, e As EventArgs) Handles btnCommitDesigner.Click
        Dim Response

        Response = MsgBox("Quer mesmo alterar o móvel de ID " & idQuery & "?", vbOKCancel, "ALTERAR CLIENTE")

        If Response = vbOK Then
            Dim name, bio, typeImg As String


            'atribuição de valores às variáveis
            name = txtNameDesigner.Text
            bio = txtBioDesigner.Text

            Using con As MySqlConnection = GetConnectionMysql()
                Try
                    'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                    con.Open()
                    'Validação do upload de imagem para o banco de dados
                    If UploadImage Then
                        Dim sql As String = "UPDATE designers SET d_nome=@name, d_bio=@bio, d_imagem=@image, d_typeImg=@type WHERE d_id = '" & idQuery & "'"

                        Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                        'Atribuição dos parâmetros
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@bio", bio)
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
                        Dim sql As String = "UPDATE designers SET d_nome=@name, d_bio=@bio WHERE d_id = '" & idQuery & "'"

                        Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                        'Atribuição dos parâmetros
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@bio", bio)
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
                    Dim sql As String = "SELECT d_nome, d_bio FROM designers
                                     WHERE d_id = '" & idQuery & "'"
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    Dim reader As MySqlDataReader = cmd.ExecuteReader

                    While reader.Read()
                        txtNameDesigner.Text = reader("d_nome").ToString
                        txtBioDesigner.Text = reader("d_bio").ToString

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

    Private Sub rescueImage()
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT d_imagem FROM designers WHERE d_id = '" & idQuery & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable

                Dim tempImagem As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
                Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
                Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
                fs.Write(tempImagem, 0, tempImagem.Length)
                fs.Flush()
                fs.Close()

                picboxImageUploadDesigner.Image = Image.FromFile(strArquivo)

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub btnImageDesigner_Click(sender As Object, e As EventArgs) Handles btnImageDesigner.Click
        Using OFD As New OpenFileDialog With {.Filter = "image File(*.jpg;*.png;*)|*.jpg;*.png;*"}
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                fileName = Path.GetExtension(OFD.FileName)
                fileName = fileName.ToUpper

                imageUser = Image.FromFile(OFD.FileName)
                picboxImageUploadDesigner.Image = imageUser

                UploadImage = True
            End If
        End Using
    End Sub

    Private Sub btnCancelDesigner_Click(sender As Object, e As EventArgs) Handles btnCancelDesigner.Click
        idQuery = Nothing
        FormHome.Show()
        Me.Close()
    End Sub
End Class