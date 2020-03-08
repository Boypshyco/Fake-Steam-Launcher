Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SteamButton1.Text = Form1.SteamTextBox1.Text
        Label8.Text = Form1.SteamTextBox1.Text
        WebBrowser1.Navigate("https://steamcommunity.com/id/" + Form1.SteamTextBox1.text)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()
        Form1.Close()
        Form2.close
        Form4.Close
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Webbrowser1.Navigate("https://store.steampowered.com/")
        Textbox1.Text = "https://store.steampowered.com/"
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        WebBrowser1.Navigate ("https://steamcommunity.com/home")
        Textbox1.Text = "https://steamcommunity.com/home"
    End Sub

    Private Sub SteamButton1_Click(sender As Object, e As EventArgs) Handles SteamButton1.Click
        WebBrowser1.Navigate("https://steamcommunity.com/id/" + Form1.SteamTextBox1.text)
        TextBox1.Text = "https://steamcommunity.com/id" + Form1.SteamTextBox1.text
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        WebBrowser1.Navigate("https://steamcommunity.com/id/" + Form1.SteamTextBox1.text)
        TextBox1.Text = "https://steamcommunity.com/id" + Form1.SteamTextBox1.text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WebBrowser1.GoBack 
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WebBrowser1.GoForward 
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        WebBrowser1.Refresh 
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WebBrowser1.Navigate ("https://steamcommunity.com/games/593110/announcements/")
        TextBox1.Text = "https://steamcommunity.com/games/593110/announcements/"
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        WebBrowser1.Navigate("https://steamcommunity.com/id/" + Form1.SteamTextBox1.text)
        TextBox1.Text = "https://steamcommunity.com/id" + Form1.SteamTextBox1.text
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        WebBrowser1.Navigate("https://steamcommunity.com/id/kausar1st/home/invites/")
        TextBox1.Text= "https://steamcommunity.com/id/kausar1st/home/invites/"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        View.Visible = True
        WebBrowser1.Navigate("https://store.steampowered.com/account/")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Friends.Visible = True
        WebBrowser1.Navigate("https://steamcommunity.com/friends/add/")
        TextBox1.Text = ("https://steamcommunity.com/friends/add/")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Games.Visible = True
        WebBrowser1.Navigate("https://store.steampowered.com/account/redeemwalletcode/")
        TextBox1.Text = "https://store.steampowered.com/account/redeemwalletcode/"
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Form4.Show()
    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged 
        TextBox1.Text = WebBrowser1.Url.ToString
        If PictureBox10.Visible = False Then
            PictureBox10.Visible = True
            Else
            PictureBox10.Visible = False
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Help.Visible = True
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        'None
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        'None
    End Sub
End Class