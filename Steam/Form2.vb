Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatingStart.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles UpdatingStart.Tick
        ProgressBar1.Increment(1.5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Form1.Show()
            ProgressBar1.Value = "0"
            Me.Hide()
            UpdatingStart.Stop()
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class