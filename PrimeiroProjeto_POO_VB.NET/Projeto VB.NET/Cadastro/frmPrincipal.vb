Public Class frmPrincipal
    Private Sub CadastroDeAcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeAcessoToolStripMenuItem.Click
        Dim CadAcesso As New frmCadAcesso
        CadAcesso.ShowDialog()
    End Sub

    Private Sub DadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DadosToolStripMenuItem.Click
        Dim formulario As New frmDados
        formulario.ShowDialog()
    End Sub
End Class