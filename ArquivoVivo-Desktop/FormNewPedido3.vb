Imports MySql.Data.MySqlClient
Public Class FormNewPedido3
    Private Sub FormNewPedido3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataMysql(dtGridPedido)
        DataGridStyles()
    End Sub
    Private Sub LoadDataMysql(dtMysql As DataGridView)
        nPedido = "3/2021"
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("SELECT p_nPedido AS 'N° PEDIDO', p_movel AS MÓVEL, p_tipos AS TIPO, p_ordem AS ORDEM, p_preco AS PREÇO 
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
End Class