Imports System.Data.SqlClient
Imports Cadastro.clsConexao
Public Class clsCRUD
    Public Shared Function InsertUser(ByVal Usuario As String, ByVal Senha As String)
        Dim cn As SqlConnection = GetConnection()
        Dim sqlInsert As String = "Insert into acesso(login,senha) values('" & Usuario & "', '" & Senha & "')"
        Dim cmd As SqlCommand = New SqlCommand(sqlInsert, cn)
        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario
        cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = Senha
        cmd.ExecuteNonQuery()
        Return sqlInsert
    End Function

#Region "Cadastro de Dados Pessoas"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Nome">Nome Pessoa</param>
    ''' <param name="Profissao">Profissao da Pessoa</param>
    ''' <param name="Idade">Idade da Pessoa</param>
    ''' <param name="EstadoCivil">Estado Civil da Pessoa</param>
    ''' <returns></returns>
    Public Shared Function InsertDados(ByVal Nome As String, ByVal Profissao As String, ByVal Idade As Integer, ByVal EstadoCivil As String)
        Dim cn As SqlConnection = GetConnection()
        Dim sqlInsert As String = ""
        Try
            sqlInsert = "Insert into dados(nome,profissao,idade,EstadoCivil)"
            sqlInsert &= "values(@nome, @profissao, @idade, @EstadoCivil)"
            Dim cmd As SqlCommand = New SqlCommand(sqlInsert, cn)
            cmd.Parameters.Add(New SqlParameter("@nome", Nome))
            cmd.Parameters.Add(New SqlParameter("@profissao", Profissao))
            cmd.Parameters.Add(New SqlParameter("@idade", Idade))
            cmd.Parameters.Add(New SqlParameter("@EstadoCivil", EstadoCivil))
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try

        Return sqlInsert
    End Function
#End Region

#Region "Carrega Grid"
    Public Shared Function SelecionaDadosGrid()
        Dim sqlSelect As String = ""
        sqlSelect = "select * from dados"
        Return sqlSelect
    End Function
#End Region

    Public Shared Function AlterarDados(ByVal Id As Integer, ByVal Nome As String, ByVal Profissao As String, ByVal Idade As Integer, ByVal EstadoCivil As String)
        Dim cn As SqlConnection = GetConnection()
        Dim sqlAlterar As String = ""
        Try
            sqlAlterar = "update dados set nome = @nome, profissao = @profissao, idade = @idade, estadoCivil = @estadoCivil Where idUsuario = " & Id
            Dim cmd As SqlCommand = New SqlCommand(sqlAlterar, cn)
            cmd.Parameters.Add(New SqlParameter("@nome", Nome))
            cmd.Parameters.Add(New SqlParameter("@profissao", Profissao))
            cmd.Parameters.Add(New SqlParameter("@idade", Idade))
            cmd.Parameters.Add(New SqlParameter("@EstadoCivil", EstadoCivil))
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try

        Return sqlAlterar
    End Function

    Public Shared Function ExcluirDados(ByVal Id As Integer)
        Dim cn As SqlConnection = GetConnection()
        Dim sqlDeletar As String = ""
        Try
            sqlDeletar = "delete from dados Where idUsuario = " & Id
            Dim cmd As SqlCommand = New SqlCommand(sqlDeletar, cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
        cn.Close()
        Return sqlDeletar
    End Function

End Class
