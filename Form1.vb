Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        lblLoading.Text = ProgressBar1.Value & "% Loading..."
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
