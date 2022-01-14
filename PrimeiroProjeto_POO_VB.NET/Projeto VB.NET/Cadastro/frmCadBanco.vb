Public Class frmCadBanco
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        My.Settings.ConnBanco = Me.txt_caminho.Text
        My.Settings.Save()

        If My.Settings.ConnBanco <> "" Then
            MessageBox.Show("Banco de dados Cadastrado com sucesso", "Sistema de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
        End If

    End Sub
End Class