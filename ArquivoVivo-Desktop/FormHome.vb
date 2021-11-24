Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class FormHome
    Dim queryCliente As String
    Dim queryDesigner As String
    Dim queryMovel As String
    Dim queryFuncionario As String


    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'querys
        queryDesigner = "SELECT d_id AS 'ID', d_nome AS 'NOME', d_bio AS 'BIOGRAFIA' FROM designers"
        queryCliente = "SELECT c_id AS 'ID', CONCAT(c_nome,' ',c_sobrenome) AS 'CLIENTE', c_telCel AS 'CELULAR', c_telFixo AS 'FIXO', c_email AS 'EMAIL', c_cep AS 'CEP' FROM cliente"
        queryMovel = "SELECT m_id AS 'ID', m_titulo AS 'TITULO', d_nome AS 'DESIGNER', m_qtdEstoque AS 'QTD', ct_nome AS 'CATEGORIA', CONCAT('R$ ', m_valUni) AS 'VALOR UNI.'
                      FROM moveis, categoria, designers 
                      WHERE designers.d_id = moveis.d_id AND moveis.ct_id = categoria.ct_id"
        queryFuncionario = "SELECT f_id AS 'ID', f_nome AS 'FUNCIONÁRIO', f_telCel AS 'CELULAR', f_telFixo AS 'FIXO', f_email AS 'EMAIL' FROM funcionarios"
        'Atribui o texto de dica para todas as textbox
        PlaceholderTextBox()
        'Inicia pelo panelMainPage e oculta os demais
        InitPanelStart()
        'Padroniza a aparência dos demais DataGridView's
        DataGridStyles()

        'carrega os dados em seus respectivos DataGridView's
        LoadDataMysql(queryCliente, dtGridCliente)
        LoadDataMysql(queryDesigner, dtGridDesigner)
        LoadDataMysql(queryMovel, dtGridMovel)
        LoadDataMysql(queryFuncionario, dtGridFuncionario)
        'Cliente Count
        CountAllData("cliente", lblCountAllDataCliente)
        CountCurrentMouth("cliente", "c_dtReg", lblCountCurrentMouthCliente)
        'Designer Count
        CountAllData("designers", lblCountAllDataDesigner)
        'Movel Count
        CountAllData("moveis", lblCountAllDataMovel)
        CountCurrentMouth("moveis", "m_dtReg", lblCountCurrentMouthMovel)
        CountWithoutStorage()
        'funcionario Count
        CountAllData("funcionarios", lblCountAllDataFuncionario)
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
                    label.Text = reader("total").ToString
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
    Private Sub CountWithoutStorage()
        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT COUNT(*) AS 'total' FROM moveis WHERE m_qtdEstoque <= 0"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                Dim reader As MySqlDataReader = cmd.ExecuteReader

                While reader.Read()
                    lblCountWithoutStorageMovel.Text = reader("total").ToString
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
        'designer
        dtGridDesigner.ColumnHeadersDefaultCellStyle.Font = New Font("Raleway", 12)
        dtGridDesigner.RowTemplate.Height = 29
        dtGridDesigner.GridColor = Color.LightGray
        'móvel
        dtGridMovel.ColumnHeadersDefaultCellStyle.Font = New Font("Raleway", 12)
        dtGridMovel.RowTemplate.Height = 29
        dtGridMovel.GridColor = Color.LightGray
        'funcionario
        dtGridFuncionario.ColumnHeadersDefaultCellStyle.Font = New Font("Raleway", 12)
        dtGridFuncionario.RowTemplate.Height = 29
        dtGridFuncionario.GridColor = Color.LightGray

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

    Private Sub btnSearchFuncionarios_Click(sender As Object, e As EventArgs) Handles btnSearchFuncionarios.Click
        Dim search As String
        search = txtSearchFuncionarios.Text
        If search = "" Then
            queryFuncionario = "SELECT f_id AS 'ID', f_nome AS 'FUNCIONÁRIO', f_telCel AS 'CELULAR', f_telFixo AS 'FIXO', f_email AS 'EMAIL' FROM funcionarios"
            LoadDataMysql(queryFuncionario, dtGridFuncionario)
        End If
        If rbtnIdFuncionario.Checked Then
            queryFuncionario = "SELECT f_id AS 'ID', f_nome AS 'FUNCIONÁRIO', f_telCel AS 'CELULAR', f_telFixo AS 'FIXO', f_email AS 'EMAIL' FROM funcionarios WHERE f_id LIKE '%" & search & "%'"
            LoadDataMysql(queryFuncionario, dtGridFuncionario)
        ElseIf rbtnNomeFuncionario.Checked Then
            queryFuncionario = "SELECT f_id AS 'ID', f_nome AS 'FUNCIONÁRIO', f_telCel AS 'CELULAR', f_telFixo AS 'FIXO', f_email AS 'EMAIL' FROM funcionarios WHERE f_nome LIKE '%" & search & "%'"
            LoadDataMysql(queryFuncionario, dtGridFuncionario)
        ElseIf rbtnCelFuncionario.Checked Then
            queryFuncionario = "SELECT f_id AS 'ID', f_nome AS 'FUNCIONÁRIO', f_telCel AS 'CELULAR', f_telFixo AS 'FIXO', f_email AS 'EMAIL' FROM funcionarios WHERE f_telCel LIKE '%" & search & "%'"
            LoadDataMysql(queryFuncionario, dtGridFuncionario)
        ElseIf rbtnFixFuncionario.Checked Then
            queryFuncionario = "SELECT f_id AS 'ID', f_nome AS 'FUNCIONÁRIO', f_telCel AS 'CELULAR', f_telFixo AS 'FIXO', f_email AS 'EMAIL' FROM funcionarios WHERE f_telFixo LIKE '%" & search & "%'"
            LoadDataMysql(queryFuncionario, dtGridFuncionario)
        ElseIf rbtnEmailFuncionario.Checked Then
            queryFuncionario = "SELECT f_id AS 'ID', f_nome AS 'FUNCIONÁRIO', f_telCel AS 'CELULAR', f_telFixo AS 'FIXO', f_email AS 'EMAIL' FROM funcionarios WHERE f_email LIKE '%" & search & "%'"
            LoadDataMysql(queryFuncionario, dtGridFuncionario)
        End If
    End Sub
    Private Sub btnSearchDesigner_Click(sender As Object, e As EventArgs) Handles btnSearchDesigner.Click
        Dim search As String
        search = txtSearchDesigners.Text
        If search = "" Then
            queryDesigner = "SELECT d_id AS 'ID', d_nome AS 'NOME', d_bio AS 'BIOGRAFIA' FROM designers"
            LoadDataMysql(queryDesigner, dtGridDesigner)
        End If
        If rbtnIdDesigner.Checked Then
            queryDesigner = "SELECT d_id AS 'ID', d_nome AS 'NOME', d_bio AS 'BIOGRAFIA' FROM designers WHERE d_id LIKE '%" & search & "%'"
            LoadDataMysql(queryDesigner, dtGridDesigner)
        ElseIf rbtnNomeDesigner.Checked Then
            queryDesigner = "SELECT d_id AS 'ID', d_nome AS 'NOME', d_bio AS 'BIOGRAFIA' FROM designers WHERE d_nome LIKE '%" & search & "%'"
            LoadDataMysql(queryDesigner, dtGridDesigner)
        ElseIf rbtnBioDesigner.Checked Then
            queryDesigner = "SELECT d_id AS 'ID', d_nome AS 'NOME', d_bio AS 'BIOGRAFIA' FROM designers WHERE d_bio LIKE '%" & search & "%'"
            LoadDataMysql(queryDesigner, dtGridDesigner)
        End If
    End Sub

    Private Sub btnSearchMoveis_Click(sender As Object, e As EventArgs) Handles btnSearchMoveis.Click
        Dim search As String
        search = txtSearchMoveis.Text

        If search = "" Then
            queryMovel = "SELECT m_id AS 'ID', m_titulo AS 'TITULO', d_nome AS 'DESIGNER', m_qtdEstoque AS 'QTD', ct_nome AS 'CATEGORIA', CONCAT('R$ ', m_valUni) AS 'VALOR UNI.'
                      FROM moveis, categoria, designers 
                      WHERE designers.d_id = moveis.d_id AND moveis.ct_id = categoria.ct_id"
            LoadDataMysql(queryMovel, dtGridMovel)
        End If
        If rbtnIdMovel.Checked Then
            queryMovel = "SELECT m_id AS 'ID', m_titulo AS 'TITULO', d_nome AS 'DESIGNER', m_qtdEstoque AS 'QTD', ct_nome AS 'CATEGORIA', CONCAT('R$ ', m_valUni) AS 'VALOR UNI.'
                      FROM moveis, categoria, designers 
                      WHERE designers.d_id = moveis.d_id AND moveis.ct_id = categoria.ct_id AND m_id LIKE '%" & search & "%'"
            LoadDataMysql(queryMovel, dtGridMovel)
        ElseIf rbtnTituloMovel.Checked Then
            queryMovel = "SELECT m_id AS 'ID', m_titulo AS 'TITULO', d_nome AS 'DESIGNER', m_qtdEstoque AS 'QTD', ct_nome AS 'CATEGORIA', CONCAT('R$ ', m_valUni) AS 'VALOR UNI.'
                      FROM moveis, categoria, designers 
                      WHERE designers.d_id = moveis.d_id AND moveis.ct_id = categoria.ct_id AND m_titulo LIKE '%" & search & "%'"
            LoadDataMysql(queryMovel, dtGridMovel)
        ElseIf rbtnDesignerMovel.Checked Then
            queryMovel = "SELECT m_id AS 'ID', m_titulo AS 'TITULO', d_nome AS 'DESIGNER', m_qtdEstoque AS 'QTD', ct_nome AS 'CATEGORIA', CONCAT('R$ ', m_valUni) AS 'VALOR UNI.'
                      FROM moveis, categoria, designers 
                      WHERE designers.d_id = moveis.d_id AND moveis.ct_id = categoria.ct_id AND d_nome LIKE '%" & search & "%'"
            LoadDataMysql(queryMovel, dtGridMovel)
        ElseIf rbtnCategoriaMovel.Checked Then
            queryMovel = "SELECT m_id AS 'ID', m_titulo AS 'TITULO', d_nome AS 'DESIGNER', m_qtdEstoque AS 'QTD', ct_nome AS 'CATEGORIA', CONCAT('R$ ', m_valUni) AS 'VALOR UNI.'
                      FROM moveis, categoria, designers 
                      WHERE designers.d_id = moveis.d_id AND moveis.ct_id = categoria.ct_id AND ct_nome LIKE '%" & search & "%'"
            LoadDataMysql(queryMovel, dtGridMovel)
        End If
    End Sub

    Private Sub btnSearchCliente_Click(sender As Object, e As EventArgs) Handles btnSearchCliente.Click
        Dim search As String
        search = txtSearchCliente.Text
        If search = "" Then
            queryCliente = "SELECT c_id AS 'ID', CONCAT(c_nome,' ',c_sobrenome) AS 'CLIENTE', c_telCel AS 'CELULAR', c_telFixo AS 'FIXO', c_email AS 'EMAIL', c_cep AS 'CEP' FROM cliente"
            LoadDataMysql(queryCliente, dtGridCliente)
        End If
        If rbtnIdCliente.Checked Then
            queryCliente = "SELECT c_id AS 'ID', CONCAT(c_nome,' ',c_sobrenome) AS 'CLIENTE', c_telCel AS 'CELULAR', c_telFixo AS 'FIXO', c_email AS 'EMAIL', c_cep AS 'CEP' FROM cliente WHERE c_id LIKE '%" & search & "%'"
            LoadDataMysql(queryCliente, dtGridCliente)
        ElseIf rbtnNomeCliente.Checked Then
            queryCliente = "SELECT c_id AS 'ID', CONCAT(c_nome,' ',c_sobrenome) AS 'CLIENTE', c_telCel AS 'CELULAR', c_telFixo AS 'FIXO', c_email AS 'EMAIL', c_cep AS 'CEP' 
                            FROM cliente WHERE c_nome LIKE '%" & search & "%'"
            LoadDataMysql(queryCliente, dtGridCliente)
        ElseIf rbtnCelCliente.Checked Then
            queryCliente = "SELECT c_id AS 'ID', CONCAT(c_nome,' ',c_sobrenome) AS 'CLIENTE', c_telCel AS 'CELULAR', c_telFixo AS 'FIXO', c_email AS 'EMAIL', c_cep AS 'CEP' 
                            FROM cliente WHERE c_telCel LIKE '%" & search & "%'"
            LoadDataMysql(queryCliente, dtGridCliente)
        ElseIf rbtnTelCliente.Checked Then
            queryCliente = "SELECT c_id AS 'ID', CONCAT(c_nome,' ',c_sobrenome) AS 'CLIENTE', c_telCel AS 'CELULAR', c_telFixo AS 'FIXO', c_email AS 'EMAIL', c_cep AS 'CEP' 
                            FROM cliente WHERE c_telFixo LIKE '%" & search & "%'"
            LoadDataMysql(queryCliente, dtGridCliente)
        ElseIf rbtnEmailCliente.Checked Then
            queryCliente = "SELECT c_id AS 'ID', CONCAT(c_nome,' ',c_sobrenome) AS 'CLIENTE', c_telCel AS 'CELULAR', c_telFixo AS 'FIXO', c_email AS 'EMAIL', c_cep AS 'CEP' 
                            FROM cliente WHERE c_email LIKE '%" & search & "%'"
            LoadDataMysql(queryCliente, dtGridCliente)
        ElseIf rbtnCepCliente.Checked Then
            queryCliente = "SELECT c_id AS 'ID', CONCAT(c_nome,' ',c_sobrenome) AS 'CLIENTE', c_telCel AS 'CELULAR', c_telFixo AS 'FIXO', c_email AS 'EMAIL', c_cep AS 'CEP' 
                            FROM cliente WHERE c_cep LIKE '%" & search & "%'"
            LoadDataMysql(queryCliente, dtGridCliente)
        End If
    End Sub

    Private Sub dtGridCliente_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtGridCliente.RowHeaderMouseDoubleClick
        idQuery = CType(dtGridCliente.Item(0, e.RowIndex).Value, Integer)
        formAlterCliente.Show()
        Me.Close()
    End Sub
End Class