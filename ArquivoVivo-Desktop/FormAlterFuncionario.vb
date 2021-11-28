Imports MySql.Data.MySqlClient
Public Class FormAlterFuncionario
    Dim status As String
    Private Sub FormAlterFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carregamento dos dados enviados pelo clique duplo
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT f_nome, f_sobrenome, f_email, f_senha, f_telCel, f_telFixo, f_state FROM funcionarios WHERE f_id = '" & idQuery & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                While reader.Read()
                    txtNomeFuncionario.Text = reader("f_nome").ToString
                    txtSobreFuncionario.Text = reader("f_sobrenome").ToString
                    txtEmailFuncionario.Text = reader("f_email").ToString
                    txtSenhaFuncionario.Text = reader("f_senha").ToString
                    txtCelFuncionario.Text = reader("f_telCel").ToString
                    txtFixFuncionario.Text = reader("f_telFixo").ToString



                    status = reader("f_state").ToString
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                If status = "ativo" Then
                    rbtnAtivo.Checked = True
                Else
                    rbtnArquivado.Checked = True
                End If
            End Try
        End Using

        WhiteButton(btnCancelFuncionario)
        DarkGrayButton(btnCommitFuncionario)
    End Sub

    Private Sub btnCommitFuncionario_Click(sender As Object, e As EventArgs) Handles btnCommitFuncionario.Click
        Dim Response

        Response = MsgBox("Quer mesmo alterar o cliente de ID " & idQuery & "?", vbOKCancel, "ALTERAR CLIENTE")

        If Response = vbOK Then
            Dim name, lastName, email, cel, fix, estado, state, pass As String
            'atribuição de valores às variáveis
            name = txtNomeFuncionario.Text
            lastName = txtSobreFuncionario.Text
            email = txtEmailFuncionario.Text
            pass = txtSenhaFuncionario.Text
            cel = txtCelFuncionario.Text
            fix = txtFixFuncionario.Text

            If rbtnAtivo.Checked Then
                state = "ativo"
            Else
                state = "arquivado"
            End If
            Using con As MySqlConnection = GetConnectionMysql()
                Try
                    'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                    con.Open()
                    Dim sql As String = "UPDATE funcionarios SET  f_nome=@name, f_sobrenome=@lastName, f_email=@email, f_senha=@pass, f_telCel=@telCel, f_telFixo=@telFixo, f_state=@state WHERE f_id = '" & idQuery & "'"

                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                    'Atribuição dos parâmetros
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@lastName", lastName)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@pass", pass)
                    cmd.Parameters.AddWithValue("@telCel", cel)
                    cmd.Parameters.AddWithValue("@telFixo", fix)
                    cmd.Parameters.AddWithValue("@state", state)
                    'Cadastro concluído
                    Dim reader As MySqlDataReader = cmd.ExecuteReader
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
                    Dim sql As String = "SELECT f_nome, f_sobrenome, f_email, f_senha, f_telCel, f_telFixo, f_state FROM funcionarios WHERE f_id = '" & idQuery & "'"
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    Dim reader As MySqlDataReader = cmd.ExecuteReader

                    While reader.Read()
                        txtNomeFuncionario.Text = reader("f_nome").ToString
                        txtSobreFuncionario.Text = reader("f_sobrenome").ToString
                        txtEmailFuncionario.Text = reader("f_email").ToString
                        txtSenhaFuncionario.Text = reader("f_senha").ToString
                        txtCelFuncionario.Text = reader("f_telCel").ToString
                        txtFixFuncionario.Text = reader("f_telFixo").ToString



                        status = reader("f_state").ToString
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                    If status = "ativo" Then
                        rbtnAtivo.Checked = True
                    Else
                        rbtnArquivado.Checked = True
                    End If
                End Try
            End Using
        End If
    End Sub

    Private Sub btnCancelFuncionario_Click(sender As Object, e As EventArgs) Handles btnCancelFuncionario.Click
        idQuery = Nothing
        FormHome.Show()
        Me.Close()
    End Sub
End Class