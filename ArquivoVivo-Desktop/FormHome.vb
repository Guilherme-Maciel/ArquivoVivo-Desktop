Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class FormHome
    Dim queryCliente As String

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'querys
        queryCliente = "SELECT c_id AS 'ID', CONCAT(c_nome,' ',c_sobrenome) AS 'CLIENTE', c_telCel AS 'CELULAR', c_telFixo AS 'FIXO', c_email AS 'EMAIL', c_cep AS 'CEP' FROM cliente"

        'Atribui o texto de dica para todas as textbox
        PlaceholderTextBox()
        'Inicia pelo panelMainPage e oculta os demais
        InitPanelStart()
        'Padroniza a aparência dos demais DataGridView's
        DataGridStyles()

        'carrega os dados em seus respectivos DataGridView's
        LoadDataMysql(queryCliente, dtGridCliente)

        'Cliente Count
        CountAllData("cliente", lblCountAllDataCliente)
        CountCurrentMouth("cliente", "c_dtReg", lblCountCurrentMouthCliente)
    End Sub

    'Close and Minimize
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    'Panel View Buttons
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        panelHomePedidos.Visible = False
        panelMainPage.Visible = True
        panelHomeCliente.Visible = False
        panelHomeMoveis.Visible = False
        panelHomeDesigners.Visible = False
        panelHomeFuncionarios.Visible = False
    End Sub
    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        panelHomePedidos.Visible = True
        panelMainPage.Visible = False
        panelHomeCliente.Visible = False
        panelHomeMoveis.Visible = False
        panelHomeDesigners.Visible = False
        panelHomeFuncionarios.Visible = False
    End Sub
    Private Sub btnMoveis_Click(sender As Object, e As EventArgs) Handles btnMoveis.Click
        panelHomePedidos.Visible = False
        panelMainPage.Visible = False
        panelHomeCliente.Visible = False
        panelHomeMoveis.Visible = True
        panelHomeDesigners.Visible = False
        panelHomeFuncionarios.Visible = False
    End Sub
    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        panelHomePedidos.Visible = False
        panelMainPage.Visible = False
        panelHomeCliente.Visible = True
        panelHomeMoveis.Visible = False
        panelHomeDesigners.Visible = False
        panelHomeFuncionarios.Visible = False
    End Sub
    Private Sub btnDesigners_Click(sender As Object, e As EventArgs) Handles btnDesigners.Click
        panelHomePedidos.Visible = False
        panelMainPage.Visible = False
        panelHomeCliente.Visible = False
        panelHomeMoveis.Visible = False
        panelHomeDesigners.Visible = True
        panelHomeFuncionarios.Visible = False
    End Sub
    Private Sub btnFuncionario_Click(sender As Object, e As EventArgs) Handles btnFuncionario.Click
        panelHomePedidos.Visible = False
        panelMainPage.Visible = False
        panelHomeCliente.Visible = False
        panelHomeMoveis.Visible = False
        panelHomeDesigners.Visible = False
        panelHomeFuncionarios.Visible = True
    End Sub

    'Cadaster Buttons
    Private Sub btnCadasterMovel_Click(sender As Object, e As EventArgs) Handles btnCadasterMovel.Click
        FormMoveisType.Show()
        Me.Close()
    End Sub
    Private Sub btnCadasterDesigner_Click(sender As Object, e As EventArgs) Handles btnCadasterDesigner.Click
        panelCadaster = 2
        FormCadaster.Show()
        Me.Close()
    End Sub
    Private Sub btnCadasterCliente_Click(sender As Object, e As EventArgs) Handles btnCadasterCliente.Click
        panelCadaster = 3
        FormCadaster.Show()
        Me.Close()
    End Sub
    Private Sub btnCadasterFuncionario_Click(sender As Object, e As EventArgs) Handles btnCadasterFuncionario.Click
        panelCadaster = 4
        FormCadaster.Show()
        Me.Close()
    End Sub

    '-----------DB FUNCTIONS-----------
    'select das querys
    Private Sub LoadDataMysql(query As String, dtMysql As DataGridView)
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(query, con)
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
    'Counts 
    Private Sub CountAllData(table As String, label As Label)
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT COUNT(*) AS 'total' FROM " & table & ""
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                While reader.Read()
                    lblCountAllDataCliente.Text = reader("total").ToString
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub CountCurrentMouth(table As String, column As String, label As Label)
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT COUNT(*) AS 'total' FROM " & table & " WHERE MONTH(" & column & ") = MONTH(CURRENT_DATE()) AND YEAR(" & column & ") = YEAR(CURRENT_DATE())"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                While reader.Read()
                    label.Text = reader("total").ToString
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using

    End Sub
    '----------------------------------'

    'DEFAULT SUB
    Private Sub DataGridStyles()
        'cliente
        dtGridCliente.ColumnHeadersDefaultCellStyle.Font = New Font("Raleway", 12)
        dtGridCliente.RowTemplate.Height = 29
        dtGridCliente.GridColor = Color.LightGray

    End Sub
    Private Sub PlaceholderTextBox()
        SendMessage(Me.txtSearchPedidos.Handle, &H1501, 0, "PESQUISAR...")
        SendMessage(Me.txtSearchCliente.Handle, &H1501, 0, "PESQUISAR...")
        SendMessage(Me.txtSearchMoveis.Handle, &H1501, 0, "PESQUISAR...")
        SendMessage(Me.txtSearchDesigners.Handle, &H1501, 0, "PESQUISAR...")
        SendMessage(Me.txtSearchFuncionarios.Handle, &H1501, 0, "PESQUISAR...")
    End Sub
    Private Sub InitPanelStart()
        panelHomePedidos.Visible = False
        panelHomeCliente.Visible = False
        panelMainPage.Visible = True
        panelHomeMoveis.Visible = False
        panelHomeDesigners.Visible = False
        panelHomeFuncionarios.Visible = False
    End Sub

    'Placeholder textbox function
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
End Class