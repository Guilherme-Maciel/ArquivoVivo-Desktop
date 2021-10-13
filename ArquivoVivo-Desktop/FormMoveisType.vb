Public Class FormMoveisType
    Private Sub btn_others_Click(sender As Object, e As EventArgs) Handles btn_others.Click
        panelCadaster = 1
        FormCadaster.Show()
        Me.Close()

    End Sub

    Private Sub btnAmbiente_Click(sender As Object, e As EventArgs) Handles btnAmbiente.Click
        FormMoveisAmbiente1.Show()
        Me.Close()
    End Sub
End Class