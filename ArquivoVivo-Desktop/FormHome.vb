Imports System.Runtime.InteropServices
Public Class FormHome

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(Me.txtSearchPedidos.Handle, &H1501, 0, "PESQUISAR...")
        SendMessage(Me.txtSearchCliente.Handle, &H1501, 0, "PESQUISAR...")

        panelHomePedidos.Visible = False
        panelHomeCliente.Visible = False
        panelMainPage.Visible = True
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

    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        panelHomePedidos.Visible = False
        panelMainPage.Visible = True
        panelHomeCliente.Visible = False

    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        panelHomePedidos.Visible = False
        panelMainPage.Visible = False
        panelHomeCliente.Visible = True
    End Sub
End Class