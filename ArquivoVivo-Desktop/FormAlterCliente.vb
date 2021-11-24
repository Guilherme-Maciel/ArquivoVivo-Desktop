Imports MySql.Data.MySqlClient
Public Class formAlterCliente
    Dim status As String
    Private Sub formAlterCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carregamento dos dados enviados pelo clique duplo
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT c_nome, c_sobrenome, c_email, c_telCel, c_telFixo, c_estado, 
                                     c_cidade, c_cep, c_rua, c_bairro, c_numRes, c_complemento, c_state  FROM cliente WHERE c_id = '" & idQuery & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                While reader.Read()
                    txtNameCliente.Text = reader("c_nome").ToString
                    txtSobreCliente.Text = reader("c_sobrenome").ToString
                    txtEmailCliente.Text = reader("c_email").ToString
                    txtCelCliente.Text = reader("c_telCel").ToString
                    txtFixCliente.Text = reader("c_telFixo").ToString
                    txtEstadoCliente.Text = reader("c_estado").ToString
                    txtCidadeCliente.Text = reader("c_cidade").ToString
                    txtCepCliente.Text = reader("c_cep").ToString
                    txtRuaCliente.Text = reader("c_rua").ToString
                    txtEmailCliente.Text = reader("c_email").ToString
                    txtBairroCliente.Text = reader("c_bairro").ToString
                    txtNumResCliente.Text = reader("c_numRes").ToString
                    txtCompleCliente.Text = reader("c_complemento").ToString
                    status = reader("c_state").ToString
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

        WhiteButton(btnCancelCliente)
        DarkGrayButton(btnCommitCliente)
    End Sub

    Private Sub btnCancelCliente_Click(sender As Object, e As EventArgs) Handles btnCancelCliente.Click
        idQuery = Nothing
        FormHome.Show()
        Me.Close()
    End Sub

    Private Sub btnCommitCliente_Click(sender As Object, e As EventArgs) Handles btnCommitCliente.Click
        Dim Response

        Response = MsgBox("Quer mesmo alterar o cliente de ID " & idQuery & "?", vbOKCancel, "ALTERAR CLIENTE")

        If Response = vbOK Then
            Dim name, lastName, email, cel, fix, estado, cidade, rua, bairro, cep, numRes, comple, state As String
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

            If rbtnAtivo.Checked Then
                state = "ativo"
            Else
                state = "arquivado"
            End If
            Using con As MySqlConnection = GetConnectionMysql()
                Try
                    'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                    con.Open()
                    Dim sql As String = "UPDATE cliente SET c_nome=@name, c_sobrenome=@lastName, c_email=@email, c_estado=@estado, 
                                        c_cidade=@city, c_cep=@cep, c_rua=@street, c_bairro=@district, c_numRes=@numRes, c_complemento=@comple, c_telCel=@telCel, 
                                        c_telFixo=@telFix, c_state=@state WHERE c_id = '" & idQuery & "'"

                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                    'Atribuição dos parâmetros
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@lastName", lastName)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@estado", estado)
                    cmd.Parameters.AddWithValue("@city", cidade)
                    cmd.Parameters.AddWithValue("@cep", cep)
                    cmd.Parameters.AddWithValue("@street", rua)
                    cmd.Parameters.AddWithValue("@district", bairro)
                    cmd.Parameters.AddWithValue("@numRes", numRes)
                    cmd.Parameters.AddWithValue("@comple", comple)
                    cmd.Parameters.AddWithValue("@telCel", cel)
                    cmd.Parameters.AddWithValue("@telFix", fix)
                    cmd.Parameters.AddWithValue("@state", state)

                    'Cadastro concluído
                    Dim reader As MySqlDataReader = cmd.ExecuteReader

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            End Using
        Else
            Using con As MySqlConnection = GetConnectionMysql()
                Try
                    con.Open()
                    Dim sql As String = "SELECT c_nome, c_sobrenome, c_email, c_telCel, c_telFixo, c_estado, 
                                     c_cidade, c_cep, c_rua, c_bairro, c_numRes, c_complemento, c_state  FROM cliente WHERE c_id = '" & idQuery & "'"
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    Dim reader As MySqlDataReader = cmd.ExecuteReader

                    While reader.Read()
                        txtNameCliente.Text = reader("c_nome").ToString
                        txtSobreCliente.Text = reader("c_sobrenome").ToString
                        txtEmailCliente.Text = reader("c_email").ToString
                        txtCelCliente.Text = reader("c_telCel").ToString
                        txtFixCliente.Text = reader("c_telFixo").ToString
                        txtEstadoCliente.Text = reader("c_estado").ToString
                        txtCidadeCliente.Text = reader("c_cidade").ToString
                        txtCepCliente.Text = reader("c_cep").ToString
                        txtRuaCliente.Text = reader("c_rua").ToString
                        txtEmailCliente.Text = reader("c_email").ToString
                        txtBairroCliente.Text = reader("c_bairro").ToString
                        txtNumResCliente.Text = reader("c_numRes").ToString
                        txtCompleCliente.Text = reader("c_complemento").ToString
                        status = reader("c_state").ToString
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

    Private Sub btnNewPedido_Click(sender As Object, e As EventArgs) Handles btnNewPedido.Click
        FormNewPedido1.Show()
        Me.Close()
    End Sub
End Class