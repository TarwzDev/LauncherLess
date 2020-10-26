<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loading
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GunaWinCircleProgressIndicator1 = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaWinCircleProgressIndicator1
        '
        Me.GunaWinCircleProgressIndicator1.BackColor = System.Drawing.Color.Black
        Me.GunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaWinCircleProgressIndicator1.Location = New System.Drawing.Point(108, 112)
        Me.GunaWinCircleProgressIndicator1.Name = "GunaWinCircleProgressIndicator1"
        Me.GunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.Red
        Me.GunaWinCircleProgressIndicator1.Size = New System.Drawing.Size(94, 89)
        Me.GunaWinCircleProgressIndicator1.TabIndex = 0
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Black
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel1.Location = New System.Drawing.Point(117, 79)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(77, 15)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Connecting..."
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.Animated = True
        Me.GunaGradientButton2.AnimationHoverSpeed = 0.02!
        Me.GunaGradientButton2.AnimationSpeed = 0.03!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.Red
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.DarkRed
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Red
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GunaGradientButton2.Image = Nothing
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(91, 235)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.Red
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 5
        Me.GunaGradientButton2.Size = New System.Drawing.Size(105, 29)
        Me.GunaGradientButton2.TabIndex = 13
        Me.GunaGradientButton2.Text = "ABORT"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Controls.Add(Me.GunaGradientButton2)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 6
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Red
        Me.GunaShadowPanel1.ShadowShift = 1
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(286, 289)
        Me.GunaShadowPanel1.TabIndex = 14
        Me.GunaShadowPanel1.UseTransfarantBackground = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(310, 313)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaWinCircleProgressIndicator1)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Loading"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.TransparencyKey = System.Drawing.Color.DarkRed
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaWinCircleProgressIndicator1 As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Timer1 As Timer
End Class
