Public Class FormMoveisAmbiente1
    Private Sub FormMoveisAmbiente1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BlackButton(btnImage)
        DarkGrayButton(btnCommit)
        WhiteButton(btnCancel)
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        FormMoveisAmbiente2.Show()
        Me.Close()
    End Sub
End Class