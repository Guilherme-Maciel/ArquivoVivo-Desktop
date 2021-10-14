Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Path
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class FormMoveisAmbiente1

    Private imageUser2 As Image
    Dim fileName2 As String



    Private Sub FormMoveisAmbiente1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BlackButton(btnImage)
        DarkGrayButton(btnCommit)
        WhiteButton(btnCancel)

        comboBoxQtd()
    End Sub
    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        Using OFD As New OpenFileDialog With {.Filter = "image File(*.jpg;*.png;*)|*.jpg;*.png;*"}
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                fileNameA = Path.GetExtension(OFD.FileName)
                fileNameA = fileNameA.ToUpper

                imageUserA = Image.FromFile(OFD.FileName)
                picboxImageUpload.Image = imageUserA
            End If
        End Using
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        titleA = txtTitle.Text
        descA = txtDesc.Text
        valueA = txtValue.Text
        qtdA = cboxQtd.SelectedItem

        FormMoveisAmbiente2.Show()
        Me.Close()
    End Sub

    Private Sub txtValue_TextChanged(sender As Object, e As EventArgs) Handles txtValue.TextChanged
        TextBoxMoeda(txtValue)
    End Sub

    Public Sub comboBoxQtd()
        Dim i As Integer

        While i < 999
            cboxQtd.Items.Add(i)
            i = i + 1
        End While
    End Sub

    Private Sub cboxQtd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboxQtd.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FormHome.Show()
        Me.Close()
    End Sub
End Class
