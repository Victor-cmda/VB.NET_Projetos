<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDados))
        Me.txt_Nome = New System.Windows.Forms.TextBox()
        Me.txt_Profissao = New System.Windows.Forms.TextBox()
        Me.txt_Idade = New System.Windows.Forms.TextBox()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.btn_Cadastrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btn_Alterar = New System.Windows.Forms.Button()
        Me.btn_Excluir = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Nome
        '
        Me.txt_Nome.Location = New System.Drawing.Point(29, 57)
        Me.txt_Nome.Name = "txt_Nome"
        Me.txt_Nome.Size = New System.Drawing.Size(249, 20)
        Me.txt_Nome.TabIndex = 0
        '
        'txt_Profissao
        '
        Me.txt_Profissao.Location = New System.Drawing.Point(284, 57)
        Me.txt_Profissao.Name = "txt_Profissao"
        Me.txt_Profissao.Size = New System.Drawing.Size(138, 20)
        Me.txt_Profissao.TabIndex = 1
        '
        'txt_Idade
        '
        Me.txt_Idade.Location = New System.Drawing.Point(428, 57)
        Me.txt_Idade.Name = "txt_Idade"
        Me.txt_Idade.Size = New System.Drawing.Size(143, 20)
        Me.txt_Idade.TabIndex = 2
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Location = New System.Drawing.Point(577, 57)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(121, 21)
        Me.cboEstadoCivil.TabIndex = 3
        '
        'btn_Cadastrar
        '
        Me.btn_Cadastrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cadastrar.Location = New System.Drawing.Point(719, 406)
        Me.btn_Cadastrar.Name = "btn_Cadastrar"
        Me.btn_Cadastrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cadastrar.TabIndex = 4
        Me.btn_Cadastrar.Text = "Cadastrar"
        Me.btn_Cadastrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(26, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(281, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Profissão"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(428, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Idade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(574, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Estado Civíl"
        '
        'dgvDados
        '
        Me.dgvDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(12, 101)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.Size = New System.Drawing.Size(797, 282)
        Me.dgvDados.TabIndex = 7
        '
        'btn_Alterar
        '
        Me.btn_Alterar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Alterar.Location = New System.Drawing.Point(638, 406)
        Me.btn_Alterar.Name = "btn_Alterar"
        Me.btn_Alterar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Alterar.TabIndex = 8
        Me.btn_Alterar.Text = "Alterar"
        Me.btn_Alterar.UseVisualStyleBackColor = True
        '
        'btn_Excluir
        '
        Me.btn_Excluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Excluir.Location = New System.Drawing.Point(557, 406)
        Me.btn_Excluir.Name = "btn_Excluir"
        Me.btn_Excluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Excluir.TabIndex = 9
        Me.btn_Excluir.Text = "Excluir"
        Me.btn_Excluir.UseVisualStyleBackColor = True
        '
        'frmDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(821, 450)
        Me.Controls.Add(Me.btn_Excluir)
        Me.Controls.Add(Me.btn_Alterar)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Cadastrar)
        Me.Controls.Add(Me.cboEstadoCivil)
        Me.Controls.Add(Me.txt_Idade)
        Me.Controls.Add(Me.txt_Profissao)
        Me.Controls.Add(Me.txt_Nome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDados"
        Me.Text = "frmDados"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Nome As TextBox
    Friend WithEvents txt_Profissao As TextBox
    Friend WithEvents txt_Idade As TextBox
    Friend WithEvents cboEstadoCivil As ComboBox
    Friend WithEvents btn_Cadastrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents btn_Alterar As Button
    Friend WithEvents btn_Excluir As Button
End Class
