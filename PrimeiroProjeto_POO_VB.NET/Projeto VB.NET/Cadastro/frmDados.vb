Imports Cadastro.clsUtil
Imports Cadastro.clsCRUD
Public Class frmDados
    Private id As Integer
    Private Sub frmDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaCombo()
        CarregaGrid()

    End Sub

    Private Sub CarregaCombo()
        Dim sql As String = "select * from Estadocivil"
        Dim tb As New Data.DataTable
        tb = geraTBL(sql)

        cboEstadoCivil.ValueMember = "Id"
        cboEstadoCivil.DisplayMember = "EstadoCivil"
        cboEstadoCivil.DataSource = tb
    End Sub

    Private Sub btn_Cadastrar_Click(sender As Object, e As EventArgs) Handles btn_Cadastrar.Click
        InseriDadosPessoa()
        CarregaGrid()
    End Sub

    Private Sub InseriDadosPessoa()
        InsertDados(txt_Nome.Text, txt_Profissao.Text, txt_Idade.Text, cboEstadoCivil.Text)
        MessageBox.Show("O cadastro de " & txt_Nome.Text & ", foi efetuado com sucesso", Nome, MessageBoxButtons.OK, MessageBoxIcon.Information)
        txt_Nome.Clear()
        txt_Idade.Clear()
        txt_Profissao.Clear()
    End Sub

    Private Sub AlteraDados()
        AlterarDados(id, txt_Nome.Text, txt_Profissao.Text, txt_Idade.Text, cboEstadoCivil.Text)
        MessageBox.Show("Os dados " & txt_Nome.Text & ", foi alterado com sucesso", Nome, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ExcluiDados()
        ExcluirDados(id)
        CarregaGrid()

    End Sub

    Private Sub CarregaGrid()
        Dim sql As String = SelecionaDadosGrid()
        Dim tb As New DataTable

        tb = geraTBL(sql)
        With dgvDados
            .DataSource = tb
            .Columns(0).Visible = False
            .Columns(1).Width = 200
            .Columns(2).Width = 130
            .Columns(3).Width = 100
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

    End Sub

    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
        Dim i As Integer
        i = e.RowIndex
        Dim selecionaLinha As DataGridViewRow
        selecionaLinha = dgvDados.Rows(i)
        id = selecionaLinha.Cells(0).Value
        Me.txt_Nome.Text = selecionaLinha.Cells(1).Value.ToString
        Me.txt_Profissao.Text = selecionaLinha.Cells(2).Value.ToString
        Me.txt_Idade.Text = selecionaLinha.Cells(3).Value.ToString
        Me.cboEstadoCivil.Text = selecionaLinha.Cells(4).Value.ToString

    End Sub

    Private Sub btn_Alterar_Click(sender As Object, e As EventArgs) Handles btn_Alterar.Click
        AlteraDados()
        CarregaGrid()
    End Sub

    Private Sub btn_Excluir_Click(sender As Object, e As EventArgs) Handles btn_Excluir.Click
        If MessageBox.Show("Deseja realmente apagar estes dados?", Nome, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ExcluiDados()
            MessageBox.Show("Dados apagados com sucesso", Nome, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class