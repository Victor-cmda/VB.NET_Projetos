Imports Cadastro.clsUtil
Imports Cadastro.clsCRUD

Public Class frmCadAcesso
    Private Sub btn_Cadastro_Click(sender As Object, e As EventArgs) Handles btn_Cadastro.Click
        Dim tabela As String = "acesso"
        Dim campo As String = "Login"
        Dim usuario As String = ""
        Dim senha As String = ""

        usuario = txt_CadUsuario.Text
        senha = txt_CadSenha.Text

        If usuario = "" Or senha = "" Then
            MessageBox.Show("Os campos devem ser preenhidos", MdlUtil.Nome, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            If VerificaExistencia(tabela, campo, usuario) = True Then
                MessageBox.Show("Usuário já existente", MdlUtil.Nome, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_CadUsuario.Text = String.Empty
                Exit Sub
            Else
                InsertUser(usuario, senha)
            End If

            If VerificaExistencia(tabela, campo, usuario) = True Then
                MessageBox.Show("Cadastro de acesso efetuado com sucesso", MdlUtil.Nome, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Não foi possível efetuar o cadastro", MdlUtil.Nome, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_Sair_Click(sender As Object, e As EventArgs) Handles btn_Sair.Click
        Me.Close()
    End Sub
End Class