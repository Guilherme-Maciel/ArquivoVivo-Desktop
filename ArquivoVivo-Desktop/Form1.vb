Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DarkGrayButton2(btnLogar)
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btnLogar_Click(sender As Object, e As EventArgs) Handles btnLogar.Click
        Dim numRow As Integer
        Dim email, senha As String

        email = txtEmail.Text
        senha = txtSenha.Text

        Using con As MySqlConnection = GetConnectionMysql()
            Try
                con.Open()
                Dim sql As String = "SELECT f_email, f_nome, f_sobrenome, f_id FROM funcionarios WHERE f_email = '" & email & "' and f_senha = '" & senha & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                numRow = dt.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using


        If numRow = 1 Then
            Using con As MySqlConnection = GetConnectionMysql()
                Try
                    con.Open()
                    Dim sql As String = "SELECT f_email, f_nome, f_sobrenome, f_id FROM funcionarios WHERE f_email = '" & email & "' and f_senha = '" & senha & "'"
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    Dim reader As MySqlDataReader = cmd.ExecuteReader
                    While reader.Read()
                        funcId_SESSION = reader("f_id")
                        funcName_SESSION = reader("f_nome").ToString
                        funcSurname_SESSION = reader("f_sobrenome").ToString
                    End While
                Catch

                Finally
                    con.Close()
                End Try
            End Using

            FormHome.Show()
            Me.Close()
        Else
            MsgBox("Email ou senha inválidos!!!", vbOK)
        End If
    End Sub
End Class
