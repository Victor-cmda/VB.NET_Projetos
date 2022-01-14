Imports Cadastro.clsAcesso

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim formconfig As New frmCadBanco
        Me.txt_Senha.UseSystemPasswordChar = True
        Me.KeyPreview = True


    End Sub

    Private Sub btn_Acessar_Click(sender As Object, e As EventArgs) Handles btn_Acessar.Click
        Acesso()
        'MsgBox("Acesso com sucesso", vbInformation, MdlUtil.Nome)
        Limpar()
    End Sub

#Region "Acesso ao Usuário"
    Private Sub Acesso()
        If Me.txt_Login.Text = String.Empty Or txt_Senha.Text = String.Empty Then
            MessageBox.Show("Você deve preencher todos os campos", MdlUtil.Nome, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If AcessoLogin(txt_Login.Text, txt_Senha.Text) = True Then
            Me.Hide()
            frmPrincipal.Show()
        End If
    End Sub
#End Region

#Region "Limpeza de objetos"
    Private Sub Limpar()
        Dim ctrl As Control

        For Each ctrl In Me.Controls
            If TypeName(ctrl) = "TextBox" Then
                ctrl.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub btn_Fechar_Click(sender As Object, e As EventArgs) Handles btn_Fechar.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If AscW(e.KeyChar) = 13 Then
            e.Handled = True
            Acesso()
        End If
    End Sub
#End Region

End Class

REM Data Source=VICTOR\SQLEXPRESS;Initial Catalog=PROJECTVB;Integrated Security=True