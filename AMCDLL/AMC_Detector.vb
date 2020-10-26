Public Class AMC_Detector
    Private Sub AMC_Detector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim TargetProcess As Process() = Process.GetProcessesByName("PointBlank")
        If TargetProcess.Length > 1 Then
            For Each Jogo As Process In TargetProcess
                Jogo.Kill()

            Next
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Hide()
    End Sub
End Class