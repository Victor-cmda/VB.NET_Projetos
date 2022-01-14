Imports System.Data.SqlClient

Public Class clsConexao
    Public Overloads Shared Function GetConnection() As SqlConnection
        Dim strCn As String = "Data Source=VICTOR\SQLEXPRESS;Initial Catalog=PROJECTVB;Integrated Security=True"
        Dim cn As SqlConnection = New SqlConnection(strCn)
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return cn
    End Function
End Class
