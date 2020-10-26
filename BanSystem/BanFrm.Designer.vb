<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BanFrm
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
        Me.components = New System.ComponentModel.Container()
        Me.Detectar = New System.Windows.Forms.Timer(Me.components)
        Me.Ocultar = New System.Windows.Forms.Timer(Me.components)
        Me.CheatEngine = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Detectar
        '
        '
        'Ocultar
        '
        Me.Ocultar.Enabled = True
        Me.Ocultar.Interval = 1
        '
        'CheatEngine
        '
        Me.CheatEngine.Enabled = True
        '
        'BanFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(319, 78)
        Me.ControlBox = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BanFrm"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AC"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Detectar As Windows.Forms.Timer
    Friend WithEvents Ocultar As Windows.Forms.Timer
    Friend WithEvents CheatEngine As Windows.Forms.Timer
End Class
