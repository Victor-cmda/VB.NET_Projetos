<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txt_Senha = New System.Windows.Forms.TextBox()
        Me.btn_Acessar = New System.Windows.Forms.Button()
        Me.txt_Login = New System.Windows.Forms.TextBox()
        Me.btn_Fechar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_Senha
        '
        Me.txt_Senha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Senha.Location = New System.Drawing.Point(74, 215)
        Me.txt_Senha.Name = "txt_Senha"
        Me.txt_Senha.Size = New System.Drawing.Size(204, 20)
        Me.txt_Senha.TabIndex = 1
        '
        'btn_Acessar
        '
        Me.btn_Acessar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Acessar.Location = New System.Drawing.Point(97, 251)
        Me.btn_Acessar.Name = "btn_Acessar"
        Me.btn_Acessar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Acessar.TabIndex = 2
        Me.btn_Acessar.Text = "Entrar"
        Me.btn_Acessar.UseVisualStyleBackColor = True
        '
        'txt_Login
        '
        Me.txt_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Login.Location = New System.Drawing.Point(74, 170)
        Me.txt_Login.Name = "txt_Login"
        Me.txt_Login.Size = New System.Drawing.Size(204, 20)
        Me.txt_Login.TabIndex = 0
        '
        'btn_Fechar
        '
        Me.btn_Fechar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Fechar.Location = New System.Drawing.Point(178, 251)
        Me.btn_Fechar.Name = "btn_Fechar"
        Me.btn_Fechar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Fechar.TabIndex = 3
        Me.btn_Fechar.Text = "Fechar"
        Me.btn_Fechar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(80, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(80, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Senha"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(367, 430)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Fechar)
        Me.Controls.Add(Me.txt_Login)
        Me.Controls.Add(Me.btn_Acessar)
        Me.Controls.Add(Me.txt_Senha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Senha As TextBox
    Friend WithEvents btn_Acessar As Button
    Friend WithEvents ptb_Foto As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_Login As TextBox
    Friend WithEvents btn_Fechar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
