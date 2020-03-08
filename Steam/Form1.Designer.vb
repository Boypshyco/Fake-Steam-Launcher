<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SteamTheme1 = New Steam.SteamTheme()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.IP = New System.Windows.Forms.Label()
        Me.SteamControlBox1 = New Steam.SteamControlBox()
        Me.SteamButton4 = New Steam.SteamButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SteamButton3 = New Steam.SteamButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SteamDivider1 = New Steam.SteamDivider()
        Me.SteamButton2 = New Steam.SteamButton()
        Me.SteamButton1 = New Steam.SteamButton()
        Me.SteamCheckBox1 = New Steam.SteamCheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SteamTextBox2 = New Steam.SteamTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SteamLogo1 = New Steam.SteamLogo()
        Me.SteamTextBox1 = New Steam.SteamTextBox()
        Me.NotifyIcon2 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommunityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FriendsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BigPictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SteamVRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SteamTheme1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.NotifyIcon.SuspendLayout
        Me.SuspendLayout
        '
        'Timer1
        '
        '
        'SteamTheme1
        '
        Me.SteamTheme1.Controls.Add(Me.TabControl1)
        Me.SteamTheme1.Controls.Add(Me.IP)
        Me.SteamTheme1.Controls.Add(Me.SteamControlBox1)
        Me.SteamTheme1.Controls.Add(Me.SteamButton4)
        Me.SteamTheme1.Controls.Add(Me.Label4)
        Me.SteamTheme1.Controls.Add(Me.SteamButton3)
        Me.SteamTheme1.Controls.Add(Me.Label3)
        Me.SteamTheme1.Controls.Add(Me.SteamDivider1)
        Me.SteamTheme1.Controls.Add(Me.SteamButton2)
        Me.SteamTheme1.Controls.Add(Me.SteamButton1)
        Me.SteamTheme1.Controls.Add(Me.SteamCheckBox1)
        Me.SteamTheme1.Controls.Add(Me.Label2)
        Me.SteamTheme1.Controls.Add(Me.SteamTextBox2)
        Me.SteamTheme1.Controls.Add(Me.Label1)
        Me.SteamTheme1.Controls.Add(Me.SteamLogo1)
        Me.SteamTheme1.Controls.Add(Me.SteamTextBox1)
        Me.SteamTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SteamTheme1.Font = New System.Drawing.Font("Arial", 8!)
        Me.SteamTheme1.ForeColor = System.Drawing.Color.White
        Me.SteamTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SteamTheme1.Name = "SteamTheme1"
        Me.SteamTheme1.Size = New System.Drawing.Size(478, 328)
        Me.SteamTheme1.TabIndex = 0
        Me.SteamTheme1.Text = "Steam by NinjaGhost"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(422, 350)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(44, 59)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(36, 32)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Webrowser"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = true
        Me.WebBrowser1.Size = New System.Drawing.Size(30, 26)
        Me.WebBrowser1.TabIndex = 15
        Me.WebBrowser1.Visible = false
        '
        'IP
        '
        Me.IP.AutoSize = true
        Me.IP.BackColor = System.Drawing.Color.Transparent
        Me.IP.ForeColor = System.Drawing.Color.White
        Me.IP.Location = New System.Drawing.Point(15, 350)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(40, 14)
        Me.IP.TabIndex = 14
        Me.IP.Text = "0.0.0.0"
        '
        'SteamControlBox1
        '
        Me.SteamControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SteamControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.SteamControlBox1.Location = New System.Drawing.Point(438, 3)
        Me.SteamControlBox1.Name = "SteamControlBox1"
        Me.SteamControlBox1.Size = New System.Drawing.Size(40, 24)
        Me.SteamControlBox1.TabIndex = 13
        Me.SteamControlBox1.Text = "SteamControlBox1"
        '
        'SteamButton4
        '
        Me.SteamButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.SteamButton4.Font = New System.Drawing.Font("Arial", 7!, System.Drawing.FontStyle.Bold)
        Me.SteamButton4.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.SteamButton4.Location = New System.Drawing.Point(196, 269)
        Me.SteamButton4.Name = "SteamButton4"
        Me.SteamButton4.Size = New System.Drawing.Size(249, 26)
        Me.SteamButton4.TabIndex = 12
        Me.SteamButton4.Text = "CREATE A NEW ACCOUNT..."
        Me.SteamButton4.TextAlign = Steam.TxtAlign.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(35, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Don't have a Steam account?"
        '
        'SteamButton3
        '
        Me.SteamButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.SteamButton3.Font = New System.Drawing.Font("Arial", 7!, System.Drawing.FontStyle.Bold)
        Me.SteamButton3.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.SteamButton3.Location = New System.Drawing.Point(196, 237)
        Me.SteamButton3.Name = "SteamButton3"
        Me.SteamButton3.Size = New System.Drawing.Size(249, 26)
        Me.SteamButton3.TabIndex = 10
        Me.SteamButton3.Text = "I CAN'T SIGN IN..."
        Me.SteamButton3.TextAlign = Steam.TxtAlign.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(61, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Need help with sign in?"
        '
        'SteamDivider1
        '
        Me.SteamDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.SteamDivider1.Location = New System.Drawing.Point(23, 215)
        Me.SteamDivider1.Name = "SteamDivider1"
        Me.SteamDivider1.Offset = 8
        Me.SteamDivider1.Size = New System.Drawing.Size(425, 23)
        Me.SteamDivider1.TabIndex = 8
        Me.SteamDivider1.Text = "SteamDivider1"
        '
        'SteamButton2
        '
        Me.SteamButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.SteamButton2.Font = New System.Drawing.Font("Arial", 7!, System.Drawing.FontStyle.Bold)
        Me.SteamButton2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.SteamButton2.Location = New System.Drawing.Point(285, 183)
        Me.SteamButton2.Name = "SteamButton2"
        Me.SteamButton2.Size = New System.Drawing.Size(163, 26)
        Me.SteamButton2.TabIndex = 7
        Me.SteamButton2.Text = "CANCEL"
        Me.SteamButton2.TextAlign = Steam.TxtAlign.Left
        '
        'SteamButton1
        '
        Me.SteamButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.SteamButton1.Font = New System.Drawing.Font("Arial", 7!, System.Drawing.FontStyle.Bold)
        Me.SteamButton1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.SteamButton1.Location = New System.Drawing.Point(113, 183)
        Me.SteamButton1.Name = "SteamButton1"
        Me.SteamButton1.Size = New System.Drawing.Size(163, 26)
        Me.SteamButton1.TabIndex = 6
        Me.SteamButton1.Text = "LOGIN"
        Me.SteamButton1.TextAlign = Steam.TxtAlign.Left
        '
        'SteamCheckBox1
        '
        Me.SteamCheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.SteamCheckBox1.Checked = false
        Me.SteamCheckBox1.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SteamCheckBox1.Location = New System.Drawing.Point(113, 152)
        Me.SteamCheckBox1.Name = "SteamCheckBox1"
        Me.SteamCheckBox1.Size = New System.Drawing.Size(180, 25)
        Me.SteamCheckBox1.TabIndex = 5
        Me.SteamCheckBox1.Text = "Remember  my password"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(51, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'SteamTextBox2
        '
        Me.SteamTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.SteamTextBox2.Font = New System.Drawing.Font("Arial", 8!)
        Me.SteamTextBox2.ForeColor = System.Drawing.Color.Silver
        Me.SteamTextBox2.Location = New System.Drawing.Point(113, 123)
        Me.SteamTextBox2.MaxLength = 32767
        Me.SteamTextBox2.Name = "SteamTextBox2"
        Me.SteamTextBox2.Size = New System.Drawing.Size(335, 23)
        Me.SteamTextBox2.Status = false
        Me.SteamTextBox2.TabIndex = 3
        Me.SteamTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.SteamTextBox2.UseSystemPasswordChar = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(27, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Account name"
        '
        'SteamLogo1
        '
        Me.SteamLogo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SteamLogo1.BackColor = System.Drawing.Color.Transparent
        Me.SteamLogo1.Location = New System.Drawing.Point(64, 41)
        Me.SteamLogo1.Name = "SteamLogo1"
        Me.SteamLogo1.Size = New System.Drawing.Size(126, 36)
        Me.SteamLogo1.TabIndex = 1
        Me.SteamLogo1.Text = "SteamLogo1"
        '
        'SteamTextBox1
        '
        Me.SteamTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.SteamTextBox1.Font = New System.Drawing.Font("Arial", 8!)
        Me.SteamTextBox1.ForeColor = System.Drawing.Color.Silver
        Me.SteamTextBox1.Location = New System.Drawing.Point(113, 94)
        Me.SteamTextBox1.MaxLength = 32767
        Me.SteamTextBox1.Name = "SteamTextBox1"
        Me.SteamTextBox1.Size = New System.Drawing.Size(335, 23)
        Me.SteamTextBox1.Status = false
        Me.SteamTextBox1.TabIndex = 0
        Me.SteamTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.SteamTextBox1.UseSystemPasswordChar = false
        '
        'NotifyIcon2
        '
        Me.NotifyIcon2.ContextMenuStrip = Me.NotifyIcon
        Me.NotifyIcon2.Icon = CType(resources.GetObject("NotifyIcon2.Icon"),System.Drawing.Icon)
        Me.NotifyIcon2.Text = "Steam"
        Me.NotifyIcon2.Visible = true
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StoreToolStripMenuItem, Me.LibraryToolStripMenuItem, Me.CommunityToolStripMenuItem, Me.FriendsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.BigPictureToolStripMenuItem, Me.SteamVRToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.NotifyIcon.Name = "ContextMenuStrip1"
        Me.NotifyIcon.Size = New System.Drawing.Size(139, 180)
        '
        'StoreToolStripMenuItem
        '
        Me.StoreToolStripMenuItem.Name = "StoreToolStripMenuItem"
        Me.StoreToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.StoreToolStripMenuItem.Text = "&Store"
        '
        'LibraryToolStripMenuItem
        '
        Me.LibraryToolStripMenuItem.Name = "LibraryToolStripMenuItem"
        Me.LibraryToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.LibraryToolStripMenuItem.Text = "&Library"
        '
        'CommunityToolStripMenuItem
        '
        Me.CommunityToolStripMenuItem.Name = "CommunityToolStripMenuItem"
        Me.CommunityToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CommunityToolStripMenuItem.Text = "&Community"
        '
        'FriendsToolStripMenuItem
        '
        Me.FriendsToolStripMenuItem.Name = "FriendsToolStripMenuItem"
        Me.FriendsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.FriendsToolStripMenuItem.Text = "&Friends"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'BigPictureToolStripMenuItem
        '
        Me.BigPictureToolStripMenuItem.Name = "BigPictureToolStripMenuItem"
        Me.BigPictureToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.BigPictureToolStripMenuItem.Text = "&Big Picture"
        '
        'SteamVRToolStripMenuItem
        '
        Me.SteamVRToolStripMenuItem.Name = "SteamVRToolStripMenuItem"
        Me.SteamVRToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SteamVRToolStripMenuItem.Text = "&SteamVR"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 328)
        Me.Controls.Add(Me.SteamTheme1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Steam Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SteamTheme1.ResumeLayout(false)
        Me.SteamTheme1.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.NotifyIcon.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents SteamTheme1 As SteamTheme
    Friend WithEvents SteamControlBox1 As SteamControlBox
    Friend WithEvents SteamButton4 As SteamButton
    Friend WithEvents Label4 As Label
    Friend WithEvents SteamButton3 As SteamButton
    Friend WithEvents Label3 As Label
    Friend WithEvents SteamDivider1 As SteamDivider
    Friend WithEvents SteamButton2 As SteamButton
    Friend WithEvents SteamButton1 As SteamButton
    Friend WithEvents SteamCheckBox1 As SteamCheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SteamTextBox2 As SteamTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SteamLogo1 As SteamLogo
    Friend WithEvents SteamTextBox1 As SteamTextBox
    Friend WithEvents IP As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents NotifyIcon2 As NotifyIcon
    Friend WithEvents NotifyIcon As ContextMenuStrip
    Friend WithEvents StoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommunityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FriendsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BigPictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SteamVRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
