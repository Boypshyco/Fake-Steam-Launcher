<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.SteamTheme1 = New Steam.SteamTheme()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SteamControlBox1 = New Steam.SteamControlBox()
        Me.Button1 = New Steam.SteamButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SteamTheme1.SuspendLayout
        Me.SuspendLayout
        '
        'SteamTheme1
        '
        Me.SteamTheme1.BackColor = System.Drawing.Color.Chocolate
        Me.SteamTheme1.Controls.Add(Me.WebBrowser1)
        Me.SteamTheme1.Controls.Add(Me.Label2)
        Me.SteamTheme1.Controls.Add(Me.Label1)
        Me.SteamTheme1.Controls.Add(Me.ProgressBar1)
        Me.SteamTheme1.Controls.Add(Me.SteamControlBox1)
        Me.SteamTheme1.Controls.Add(Me.Button1)
        Me.SteamTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SteamTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SteamTheme1.Name = "SteamTheme1"
        Me.SteamTheme1.Size = New System.Drawing.Size(427, 101)
        Me.SteamTheme1.TabIndex = 0
        Me.SteamTheme1.Text = "Update Steam"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 160)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(403, 90)
        Me.WebBrowser1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(234, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "%"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(204, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 45)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(403, 14)
        Me.ProgressBar1.TabIndex = 2
        '
        'SteamControlBox1
        '
        Me.SteamControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SteamControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.SteamControlBox1.Location = New System.Drawing.Point(390, 3)
        Me.SteamControlBox1.Name = "SteamControlBox1"
        Me.SteamControlBox1.Size = New System.Drawing.Size(34, 19)
        Me.SteamControlBox1.TabIndex = 1
        Me.SteamControlBox1.Text = "SteamControlBox1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial", 7!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.Location = New System.Drawing.Point(128, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Check for Steam Client Updates..."
        Me.Button1.TextAlign = Steam.TxtAlign.Center
        '
        'Timer1
        '
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 101)
        Me.Controls.Add(Me.SteamTheme1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Steam"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SteamTheme1.ResumeLayout(false)
        Me.SteamTheme1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents SteamTheme1 As SteamTheme
    Friend WithEvents Button1 As SteamButton
    Friend WithEvents SteamControlBox1 As SteamControlBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
