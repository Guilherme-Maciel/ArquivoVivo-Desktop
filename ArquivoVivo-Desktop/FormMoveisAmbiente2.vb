Public Class FormMoveisAmbiente2
    Private Sub FormMoveisAmbiente2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BlackButton(btnFill)
        BlackButton(btnCommit)
        DarkGrayButton(btnNext)
        WhiteButton(btnCancel)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FormHome.Show()
        Me.Close()
    End Sub
End Class