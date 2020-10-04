Public Class Form3
    Private Sub Entrée_Click(sender As Object, e As EventArgs) Handles Entrée.Click
        MVTENTREE.ShowDialog()
        Close()
    End Sub

    Private Sub Sortie_Click(sender As Object, e As EventArgs) Handles Sortie.Click
        MVTSORTIE.ShowDialog()
        Close()
    End Sub

    Private Sub Transfert_Click(sender As Object, e As EventArgs) Handles Transfert.Click
        MVTTRANSFERT.ShowDialog()
        Close()
    End Sub
End Class