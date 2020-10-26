'*
'* Criado por Tawrz Dev
'* https://github.com/TarwzDev
'* Última modificação: 25/10/2020
'*

Imports AMCDLL
Imports BanSystem

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports System.Linq


Public Class GameLauncher
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim AMC As New AMC_Detector
        AMC.Show()

        Dim AntiCheatLauncher As New BanFrm
        AntiCheatLauncher.Show()


    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        If System.IO.File.Exists(String.Concat(Environment.CurrentDirectory, "/Jogo.exe")) Then

            Dim token As String = "7896545647435646132"

            Process.Start(Application.StartupPath & "\Jogo.exe", token)

            Close()
        Else
            ' MsgBox("Não foi possível iniciar o jogo." + vbNewLine + "Código de parada: 1", MsgBoxStyle.Information)
            NJogo.Visible = True
        End If

        'If Not System.IO.File.Exists(Application.StartupPath & "\Dados\Teste.xml") Then

        '    MsgBox("Arquivo não encontrado!")

        'End If
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        NJogo.Visible = False
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        End
    End Sub
End Class
