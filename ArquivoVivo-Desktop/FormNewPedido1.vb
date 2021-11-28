Imports MySql.Data.MySqlClient
Public Class FormNewPedido1

    Private Sub FormNewPedido1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    txtNameCliente.Text = reader("c_nome").ToString & " " & reader("c_sobrenome").ToString
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
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using

        DarkGrayButton(btnNext)
        WhiteButton(btnCancel)

        NumPedido()
    End Sub

    Private Sub NumPedido()
        Dim num, year As String
        'Ano
        Dim data As DateTime = DateTime.Now
        year = data.Year

        'Número
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT p_nPedido FROM pedidos WHERE YEAR(p_dtReg) = YEAR(CURRENT_DATE()) GROUP BY p_nPedido"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                num = dt.Rows.Count.ToString() + 1
                nPedido = num & "/" & year
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

            End Try
        End Using

        'Número do pedido
        Label1.Text = "N° PEDIDO: " & nPedido

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        FormNewPedido2.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("DELETE FROM pedidos WHERE p_nPedido = '" & nPedido & "'", con)
                Dim reader As MySqlDataReader = cmd.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
        idQuery = Nothing
        nPedido = Nothing
        FormHome.Show()
        Me.Close()

    End Sub
End Class