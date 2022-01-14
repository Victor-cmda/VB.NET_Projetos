Imports System.Data.SqlClient
Imports Cadastro.clsConexao
Public Class clsAcesso
    Public Shared Function AcessoLogin(ByVal Usuario As String, ByVal Senha As String) As Boolean
        Dim sql As String = "Select login, senha From acesso Where login = '" & Usuario & "' And senha = '" & Senha & "'"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConnection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        dtr = cmd.ExecuteReader
        Dim valida As Boolean = False
        Try
            If dtr.HasRows Then
                valida = True
            End If

        Catch ex As Exception
            Throw ex
        End Try
        Return valida

    End Function
End Class
