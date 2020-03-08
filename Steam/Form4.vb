Public Class Form4
    Public Sub CheckForUpdates()
        If ProgressBar1.Value = 100 Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://www.dropbox.com/s/7l5yn31r8oobl9n/Version.txt?dl=0")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()

            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                Button1.Text = ("You are up todate!")
                label2.text = ("You may now close this dialog")
            Else
                Button1.Text = ("Downloading update!")
                WebBrowser1.Navigate("https://www.dropbox.com/s/vl2xcrzh6wcn0ke/NinjaGhost%20-%20Steam.exe?dl=0")
                label2.text = ("You may now close this dialog")
            End If
        End If
        end sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Label1.Text = ProgressBar1.Value
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            If ProgressBar1.Value = 100 Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://www.dropbox.com/s/7l5yn31r8oobl9n/Version.txt?dl=0")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()

                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                    Button1.Text = ("You are up todate!")
                    label2.text = ("You may now close this dialog")
                Else
                    Button1.Text = ("Downloading update!")
                    WebBrowser1.Navigate("https://www.dropbox.com/s/vl2xcrzh6wcn0ke/NinjaGhost%20-%20Steam.exe?dl=0")
                    label2.text = ("You may now close this dialog")
                End If
            End If
        End If
        End sub
    Private Sub SteamButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        label1.Visible = true
        label2.Visible = True
        Button1.Enabled = False
        Button1.Text = "Checking for updates..."
        Timer1.Start()
        Label1.Text = ProgressBar1.Value
        CheckForUpdates()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class