Imports MySql.Data.MySqlClient
Public Class FormAlterPedido
    Private Sub FormNewPedido3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DarkGrayButton(btnCommit)
        WhiteButton(btnCancel)
        'Status
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT p_state FROM pedidos WHERE p_nPedido = '" & nPedido & "' LIMIT 1"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                While reader.Read()
                    lblStatus.Text = reader("p_state").ToString
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
        'Cliente
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT c_id FROM pedidos WHERE p_nPedido = '" & nPedido & "' LIMIT 1"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                While reader.Read()
                    idQuery = reader("c_id")
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using

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
                    lblCliente.Text = reader("c_nome").ToString & " " & reader("c_sobrenome").ToString
                    lblEmail.Text = reader("c_email").ToString
                    lblCel.Text = reader("c_telCel").ToString
                    lblFixo.Text = reader("c_telFixo").ToString
                    lblCep.Text = reader("c_cep").ToString
                    lblRua.Text = reader("c_rua").ToString
                    lblEmail.Text = reader("c_email").ToString
                    lblBairro.Text = reader("c_bairro").ToString
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using

        LoadDataMysql(dtGridPedido)
        DataGridStyles()

        lblNPedido.Text = nPedido
        'Data
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT day(p_dtReg) AS dia, month(p_dtReg) AS mes, YEAR(p_dtReg) AS ano FROM pedidos WHERE p_nPedido = '" & nPedido & "' LIMIT 1"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                While reader.Read()
                    lblData.Text = reader("dia").ToString & "/" & reader("mes").ToString & "/" & reader("ano").ToString
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
        'Total
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT SUM(p_preco) AS preco FROM pedidos WHERE p_nPedido = '" & nPedido & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                While reader.Read()
                    lblTotal.Text = "R$ " & reader("preco").ToString
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub LoadDataMysql(dtMysql As DataGridView)
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("SELECT p_nPedido AS 'N PEDIDO', p_movel AS MOVEL, p_tipos AS TIPO, p_ordem AS ORDEM, p_preco AS PRECO 
                                                            FROM pedidos WHERE p_nPedido = '" & nPedido & "'", con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtMysql.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub DataGridStyles()
        dtGridPedido.ColumnHeadersDefaultCellStyle.Font = New Font("Raleway", 12)
        dtGridPedido.RowTemplate.Height = 29
        dtGridPedido.GridColor = Color.LightGray
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                con.Open()
                Dim sql As String = "UPDATE pedidos SET p_state='encerrado' WHERE p_nPedido = '" & nPedido & "'"

                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                'Cadastro concluído
                Dim reader As MySqlDataReader = cmd.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                idQuery = Nothing
                nPedido = Nothing
                FormHome.Show()
                Me.Close()
            End Try
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                con.Open()
                Dim sql As String = "UPDATE pedidos SET p_state='cancelado' WHERE p_nPedido = '" & nPedido & "'"

                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                'Cadastro concluído
                Dim reader As MySqlDataReader = cmd.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                idQuery = Nothing
                nPedido = Nothing
                FormHome.Show()
                Me.Close()
            End Try
        End Using
    End Sub
End Class