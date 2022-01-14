<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadAcesso
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadAcesso))
        Me.txt_CadSenha = New System.Windows.Forms.TextBox()
        Me.txt_CadUsuario = New System.Windows.Forms.TextBox()
        Me.btn_Cadastro = New System.Windows.Forms.Button()
        Me.btn_Sair = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_CadSenha
        '
        Me.txt_CadSenha.Location = New System.Drawing.Point(57, 130)
        Me.txt_CadSenha.Name = "txt_CadSenha"
        Me.txt_CadSenha.Size = New System.Drawing.Size(240, 20)
        Me.txt_CadSenha.TabIndex = 0
        '
        'txt_CadUsuario
        '
        Me.txt_CadUsuario.Location = New System.Drawing.Point(57, 94)
        Me.txt_CadUsuario.Name = "txt_CadUsuario"
        Me.txt_CadUsuario.Size = New System.Drawing.Size(240, 20)
        Me.txt_CadUsuario.TabIndex = 1
        '
        'btn_Cadastro
        '
        Me.btn_Cadastro.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cadastro.Location = New System.Drawing.Point(141, 174)
        Me.btn_Cadastro.Name = "btn_Cadastro"
        Me.btn_Cadastro.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cadastro.TabIndex = 2
        Me.btn_Cadastro.Text = "Cadastrar"
        Me.btn_Cadastro.UseVisualStyleBackColor = True
        '
        'btn_Sair
        '
        Me.btn_Sair.Location = New System.Drawing.Point(222, 174)
        Me.btn_Sair.Name = "btn_Sair"
        Me.btn_Sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_Sair.TabIndex = 3
        Me.btn_Sair.Text = "Fechar"
        Me.btn_Sair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Senha"
        '
        'frmCadAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.btn_Cadastro
        Me.ClientSize = New System.Drawing.Size(311, 301)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Sair)
        Me.Controls.Add(Me.btn_Cadastro)
        Me.Controls.Add(Me.txt_CadUsuario)
        Me.Controls.Add(Me.txt_CadSenha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadAcesso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCadAcesso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_CadSenha As TextBox
    Friend WithEvents txt_CadUsuario As TextBox
    Friend WithEvents btn_Cadastro As Button
    Friend WithEvents btn_Sair As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
