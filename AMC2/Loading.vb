Imports System.Net
Public Class Loading
    Private Sub GunaWinCircleProgressIndicator1_Load(sender As Object, e As EventArgs) Handles GunaWinCircleProgressIndicator1.Load

    End Sub

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Stop()
        Try
            Dim web As New WebClient
            Dim Dados As String = web.DownloadString("http://localhost/status.txt")

            If Dados = "Manutencao" Then

                Me.Hide()

                MsgBox("We are performing maintenance, please try again later.", MsgBoxStyle.Critical, "LauncherLess - Maintenance")

                Timer1.Stop()

                End

            ElseIf Dados = "Problema" Then

                Me.Hide()

                MsgBox("Our servers are in trouble, wait until everything normalizes.", MsgBoxStyle.Critical, "LauncherLess - Server error")

                Timer1.Stop()

                End

            ElseIf Dados = "Finalizado" Then

                End
            ElseIf Dados = "Liberado" Then
                Me.Hide()
                GameLauncher.Show()
            End If

        Catch ex As Exception
            Me.Hide()
            MsgBox("Unable to establish a connection to the server.", MsgBoxStyle.Critical, "LauncherLess - Connection refused")
            End
        End Try


    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        Close()
    End Sub

    Private Sub GunaShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaShadowPanel1.Paint

    End Sub
End Class