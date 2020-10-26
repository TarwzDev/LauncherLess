Public Class BanFrm
    Private Sub Ocultar_Tick(sender As Object, e As EventArgs) Handles Ocultar.Tick
        Me.Hide()
    End Sub

    Private Sub BanFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheatEngine_Tick(sender As Object, e As EventArgs) Handles CheatEngine.Tick


        Try

            Dim CEE() As Process = Process.GetProcessesByName("cheatengine-i386")
            For Each CE1 As Process In CEE
                CE1.Kill()
            Next

            Dim CEE2() As Process = Process.GetProcessesByName("Cheat Engine")
            For Each CE2 As Process In CEE2
                CE2.Kill()
            Next

            Dim CEE3() As Process = Process.GetProcessesByName("cheatengine-x86_64-SSE4-AVX2")
            For Each CE3 As Process In CEE3
                CE3.Kill()
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Detectar_Tick(sender As Object, e As EventArgs) Handles Detectar.Tick

    End Sub
End Class