Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Path
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Public Class FormNewPedido2
    Dim qtd, idMovel As String
    Dim valUni As Double
    Private Sub FormNewPedido2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ArquivovivomvDataSet.moveis'. Você pode movê-la ou removê-la conforme necessário.
        Me.MoveisTableAdapter.Fill(Me.ArquivovivomvDataSet.moveis)

        rbtnAuto.Checked = True

        'Estilização dos butões
        BlackButton(btnFill)
        BlackButton(btnCalculate)
        BlackButton(btnCommit)
        WhiteButton(btnCancel)
        DarkGrayButton(btnNext)
    End Sub

    Private Sub rbtnAuto_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnAuto.CheckedChanged
        txtQtdManual.Visible = False
        txtTitle.Visible = False

        lblId.Visible = True
        txtId.Visible = True

        btnCalculate.Visible = True
        btnFill.Visible = True

        cboxQtd.Visible = True
        cboxTitle.Visible = True

        txtValue.Clear()
        txtQtdManual.Clear()
        txtTitle.Clear()
        picboxImageUploadMovel.Visible = True
    End Sub

    Private Sub rbtnManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnManual.CheckedChanged
        txtQtdManual.Visible = True
        txtTitle.Visible = True

        lblId.Visible = False
        txtId.Visible = False

        btnCalculate.Visible = False
        btnFill.Visible = False

        cboxQtd.Visible = False
        cboxTitle.Visible = False

        txtValue.Clear()
        txtQtdManual.Clear()
        txtTitle.Clear()
        picboxImageUploadMovel.Visible = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim name, lastName, email, cel, fix, estado, cidade, rua, bairro, cep, numRes, comple, password, state, dataFormat As String
        Dim data As DateTime = DateTime.Now

        'atribuição de valores às variáveis
        password = RandowPass()
        state = "ativo"
        If rbtnAuto.Checked Then


            Using con As MySqlConnection = GetConnectionMysql()
                Try
                    'conexão com o banco pela variável con que recebe a função GetConnectionMysql()
                    con.Open()
                    Dim sql As String = "INSERT INTO pedidos(p_nPedido, p_movel, p_qtd, p_tipos, p_ordem, p_preco, p_dtReg, p_state, c_id)
                                     VALUES(@numPedido, @movel, @qtd, @tipos, @ordem, @preco, @date, @state, @idCliente)"
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                    'Atribuição dos parâmetros
                    cmd.Parameters.AddWithValue("@numPedido", name)

                    'Cadastro concluído
                    Dim reader As MySqlDataReader = cmd.ExecuteReader
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            End Using
        End If
        txtId.Clear()
        txtOrdem.Clear()
        txtQtdManual.Clear()
        txtTitle.Clear()
        txtValue.Clear()
        cboxTitle.SelectedIndex = -1
        cboxQtd.SelectedIndex = -1
        cboxQtd.Items.Clear()
        picboxImageUploadMovel.Image = Nothing
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        idMovel = cboxTitle.SelectedValue
        txtId.Text = idMovel

        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT m_titulo, m_desc, d_nome FROM moveis, designers WHERE moveis.m_id = '" & idMovel & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                While reader.Read()
                    cboxTitle.Text = reader("m_titulo").ToString
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                rescueImage()
                comboBoxQtd()

                txtValue.Clear()
                cboxQtd.SelectedItem = -1
                cboxQtd.Text = ""

                btnCommit.Enabled = True
                btnNext.Enabled = True
            End Try
        End Using

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim total As Double

        total = cboxQtd.SelectedItem * valUni

        txtValue.Text = "R$ " & total
    End Sub

    Private Sub rescueImage()

        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT m_imagem FROM moveis WHERE m_id = '" & idMovel & "'"
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

    Public Sub comboBoxQtd()
        cboxQtd.Items.Clear()

        Dim i As Integer = 1

        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT m_qtdEstoque, m_valUni  FROM moveis WHERE m_id = '" & idMovel & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                While reader.Read()
                    qtd = reader("m_qtdEstoque").ToString
                    valUni = reader("m_valUni").ToString
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using

        While i <= qtd
            cboxQtd.Items.Add(i)
            i = i + 1
        End While
    End Sub
End Class