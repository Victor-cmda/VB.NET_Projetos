Imports System.Data
Imports System.Data.SqlClient
Imports Cadastro.clsConexao

Public Class clsUtil
    Public Shared Function VerificaExistencia(ByVal Tabela As String, ByVal Campo As String, ByVal Registro As String) As Boolean
        Dim sql As String = "Select Count(*) From " & Tabela & " Where " & Campo & "= '" & Registro & "'"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConnection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        Dim contador As Integer = 0

        contador = cmd.ExecuteScalar

        Dim valida As Boolean = True
        Try
            If contador = 0 Then
                valida = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return valida
    End Function

    Public Shared Function geraTBL(ByVal sql As String) As Data.DataTable
        Dim cn As SqlConnection = GetConnection()
        Dim tabela As New Data.DataTable
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            tabela.Load(cmd.ExecuteReader)
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Return (tabela)
    End Function
End Class
