Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Path
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Public Class FormMoveisAmbiente2

    Dim idQuery As Integer
    Public assoc() As Integer
    Public count As Integer = 0

    Private Sub FormMoveisAmbiente2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ArquivovivomvDataSet.moveis'. Você pode movê-la ou removê-la conforme necessário.
        Me.MoveisTableAdapter.Fill(Me.ArquivovivomvDataSet.moveis)
        BlackButton(btnFill)
        BlackButton(btnCommit)
        DarkGrayButton(btnNext)
        WhiteButton(btnCancel)

        btnCommit.Enabled = False
        btnNext.Enabled = False
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click

        idQuery = cboxTitle.SelectedValue
        txtId.Text = idQuery

        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT m_titulo, m_desc, d_nome FROM moveis, designers WHERE moveis.m_id = '" & idQuery & "' and moveis.d_id = designers.d_id"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                While reader.Read()
                    cboxTitle.Text = reader("m_titulo").ToString
                    txtDesc.Text = reader("m_desc").ToString
                    txtDesigner.Text = reader("d_nome").ToString
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using

        rescueImage()

        btnCommit.Enabled = True
        btnNext.Enabled = True
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ReDim Preserve assoc(count)
        assoc(count) = idQuery
        count += 1

        txtId.Clear()
        txtDesc.Clear()
        txtDesigner.Clear()
        txtDesigner.Clear()
        cboxTitle.SelectedIndex = -1
        idQuery = 0
        picboxImageUploadMovel.Image = Nothing
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FormHome.Show()
        Me.Close()
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Dim data As DateTime = DateTime.Now
        Dim dataFormat, assocStr, typeImg As String

        ReDim Preserve assoc(count)
        assoc(count) = idQuery

        dataFormat = Format(data, "s")
        assocStr = String.Join(",", assoc)

        Using con As MySqlConnection = GetConnectionMysql()
            Try
                'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                con.Open()
                Dim sql As String = "INSERT INTO moveis(m_titulo, m_desc, ct_id, m_valUni, m_qtdEstoque, m_imagem, m_typeImg, m_dtReg, m_assoc) VALUES(@title, @desc, @cat, @value, @qtd, @image, @type, @date, @assoc)"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                'Atribuição dos parâmetros
                cmd.Parameters.AddWithValue("@title", titleA)
                cmd.Parameters.AddWithValue("@desc", descA)
                cmd.Parameters.AddWithValue("@cat", 2)
                cmd.Parameters.AddWithValue("@value", valueA)
                cmd.Parameters.AddWithValue("@qtd", qtdA)
                cmd.Parameters.AddWithValue("@date", dataFormat)
                cmd.Parameters.AddWithValue("@assoc", assocStr)


                'Validação do upload de imagem para o banco de dados
                Using ms As New IO.MemoryStream
                    If fileNameA = ".PNG" Then
                        imageUserA.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                        Dim byteArray = ms.ToArray
                        cmd.Parameters.AddWithValue("@image", byteArray)
                        typeImg = "image/jpeg"
                        cmd.Parameters.AddWithValue("@type", typeImg)
                    ElseIf fileNameA = ".JPG" Or fileNameA = ".JPEG" Then
                        imageUserA.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
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
                imageUserA = Nothing
                fileNameA = Nothing
                titleA = Nothing
                descA = Nothing
                valueA = Nothing
                qtdA = Nothing

                FormHome.Show()
                Me.Close()
            End Try
        End Using
    End Sub

    Private Sub cboxTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxTitle.SelectedIndexChanged
        btnCommit.Enabled = False
        btnNext.Enabled = False
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
End Class