<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadBanco
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
        Me.txt_caminho = New System.Windows.Forms.TextBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_caminho
        '
        Me.txt_caminho.Location = New System.Drawing.Point(12, 39)
        Me.txt_caminho.Name = "txt_caminho"
        Me.txt_caminho.Size = New System.Drawing.Size(458, 20)
        Me.txt_caminho.TabIndex = 0
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Location = New System.Drawing.Point(203, 117)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cadastrar.TabIndex = 1
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cadastro de Caminho Banco"
        '
        'frmCadBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(482, 152)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.txt_caminho)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCadBanco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_caminho As TextBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Label1 As Label
End Class
