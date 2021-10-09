Imports System.Runtime.InteropServices
Public Class FormHome

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(Me.txtSearchPedidos.Handle, &H1501, 0, "PESQUISAR...")
        SendMessage(Me.txtSearchCliente.Handle, &H1501, 0, "PESQUISAR...")
        SendMessage(Me.txtSearchMoveis.Handle, &H1501, 0, "PESQUISAR...")
        SendMessage(Me.txtSearchDesigners.Handle, &H1501, 0, "PESQUISAR...")
        SendMessage(Me.txtSearchFuncionarios.Handle, &H1501, 0, "PESQUISAR...")


        panelHomePedidos.Visible = False
        panelHomeCliente.Visible = False
        panelMainPage.Visible = True
        panelHomeMoveis.Visible = False
        panelHomeDesigners.Visible = False
        panelHomeFuncionarios.Visible = False


    End Sub
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        panelHomePedidos.Visible = True
        panelMainPage.Visible = False
        panelHomeCliente.Visible = False
        panelHomeMoveis.Visible = False
        panelHomeDesigners.Visible = False
        panelHomeFuncionarios.Visible = False


    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        panelHomePedidos.Visible = False
        panelMainPage.Visible = True
        panelHomeCliente.Visible = False
        panelHomeMoveis.Visible = False
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        panelHomePedidos.Visible = False
        panelMainPage.Visible = False
        panelHomeCliente.Visible = False
        panelHomeMoveis.Visible = True
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

    Private Sub btnCadasterMovel_Click(sender As Object, e As EventArgs) Handles btnCadasterMovel.Click
        FormMoveisType.Show()
        Me.Close()
    End Sub

    Private Sub btnCadasterDesigner_Click(sender As Object, e As EventArgs) Handles btnCadasterDesigner.Click
        panelCadaster = 2
        FormCadaster.Show()
        Me.Close()
    End Sub
End Class