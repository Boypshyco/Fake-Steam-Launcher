Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.ComponentModel

'-----------------------------
' Name: Steam Theme
'-----------------------------
Public Enum MouseState As Byte
    None = 0
    Hover = 1
    Down = 2
    Lock = 3
    Click = 4
End Enum
Public Enum TxtAlign
    Left = 1
    Center = 2
    Right = 3
End Enum
Class SteamTheme : Inherits ContainerControl
    Private state As MouseState = MouseState.None
    Dim Dwn As Boolean = False
    Dim MoveHeight As Integer = 38
    Dim MousePoint As New Point(0, 0)
    Dim glow As Boolean = False
#Region "MouseState"
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = Windows.Forms.MouseButtons.Left And New Rectangle(0, 0, Width, MoveHeight).Contains(e.Location) Then
            Dwn = True
            MousePoint = e.Location
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        Dwn = False
    End Sub
    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        MyBase.OnMouseClick(e)
        state = MouseState.Click : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If Dwn = True Then
            Parent.Location = MousePosition - MousePoint
        End If
    End Sub
#End Region

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        ParentForm.FormBorderStyle = FormBorderStyle.None
        ParentForm.AllowTransparency = False
        ParentForm.TransparencyKey = Color.Fuchsia
        Dock = DockStyle.Fill
        Invalidate()
    End Sub
    Sub New()
        Size = New Size(480, 330)

    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim TopDarkGradient As New LinearGradientBrush(New Point(0, 70), New Point(0, 140), Color.FromArgb(34, 34, 34), Color.FromArgb(38, 38, 38))
        Dim TopBlueLine As New LinearGradientBrush(New Point(0, 0), New Point(Width, 0), Color.FromArgb(25, 54, 83), Color.FromArgb(29, 30, 30))
        Dim LeftBlueLine As New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(25, 54, 83), Color.FromArgb(29, 30, 30))
        Dim TopBlueGradient As New LinearGradientBrush(New Point(0, 0), New Point(0, 30), Color.FromArgb(70, 25, 54, 83), Color.FromArgb(0, 29, 30, 30))
        Dim BottomBlueLine As New LinearGradientBrush(New Point(0, 0), New Point(Width, 0), Color.FromArgb(29, 30, 30), Color.FromArgb(21, 69, 106))
        Dim RightBlueLine As New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(29, 30, 30), Color.FromArgb(21, 69, 106))
        Using G = e.Graphics
            G.Clear(Color.FromArgb(38, 38, 38))
            Select Case state
                Case MouseState.None
                    G.FillRectangle(TopDarkGradient, 0, 0, Width, 50)
                    G.FillRectangle(TopBlueLine, 0, 0, Width, 1)
                    G.FillRectangle(LeftBlueLine, 0, 0, 1, Height)
                    G.FillRectangle(BottomBlueLine, 0, Height - 1, Width, 1)
                    G.FillRectangle(RightBlueLine, Width - 1, 0, 1, Height)
                    G.TextRenderingHint = TextRenderingHint.SystemDefault
                    G.SmoothingMode = SmoothingMode.HighQuality
                    G.InterpolationMode = InterpolationMode.HighQualityBicubic
                    G.DrawString(FindForm.Text, New Font("Arial FF", 11, FontStyle.Regular, GraphicsUnit.Pixel), New SolidBrush(Color.FromArgb(137, 137, 137)), New Point(10, 10))
                Case MouseState.Click
                    G.FillRectangle(TopDarkGradient, 0, 0, Width, 50)
                    G.FillRectangle(TopBlueLine, 0, 0, Width, 1)
                    G.FillRectangle(LeftBlueLine, 0, 0, 1, Height)
                    G.FillRectangle(TopBlueGradient, 0, 0, Width, 30)
                    G.FillRectangle(BottomBlueLine, 0, Height - 1, Width, 1)
                    G.FillRectangle(RightBlueLine, Width - 1, 0, 1, Height)
                    G.TextRenderingHint = TextRenderingHint.SystemDefault
                    G.SmoothingMode = SmoothingMode.HighQuality
                    G.InterpolationMode = InterpolationMode.HighQualityBicubic
                    G.DrawString(FindForm.Text, New Font("Arial FF", 11, FontStyle.Regular, GraphicsUnit.Pixel), New SolidBrush(Color.FromArgb(235, 235, 235)), New Point(10, 10))
            End Select
        End Using
    End Sub

End Class
Public Class SteamButton : Inherits Control

    Private state As MouseState = MouseState.None
    Private _enabled As Boolean = True

    Private _txtAlign As TxtAlign = TxtAlign.Center
    Public Property TextAlign As TxtAlign
        Get
            Return _txtAlign
        End Get
        Set(value As TxtAlign)
            _txtAlign = value
            Invalidate()
        End Set
    End Property

    Sub New()
        DoubleBuffered = True
        Font = New Font("Arial", 7, FontStyle.Bold)
        Size = New Size(163, 26)
        ForeColor = SystemColors.ScrollBar
        BackColor = Color.FromArgb(38, 38, 38)
    End Sub

    Public Overloads Property Enabled As Boolean
        Get
            Return _enabled
        End Get
        Set(value As Boolean)
            _enabled = value
            Invalidate()
        End Set
    End Property

    Sub PerformClick()
        MyBase.OnClick(EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        Dim Grad1 As New LinearGradientBrush(New Point(0, 0), New Point(0, Size.Height), Color.FromArgb(105, 105, 105), Color.FromArgb(59, 59, 59))
        Dim Grad2 As New LinearGradientBrush(New Point(0, 0), New Point(0, Size.Height), Color.FromArgb(80, 80, 80), Color.FromArgb(58, 58, 58))
        Select Case _enabled
            Case True
                ForeColor = SystemColors.ScrollBar
                Select Case state
                    Case MouseState.None
                        g.FillRectangle(Grad2, 1, 1, Width - 2, Height - 2)
                    Case MouseState.Hover
                        g.FillRectangle(Grad1, 1, 1, Width - 2, Height - 2)
                    Case MouseState.Down
                        g.FillRectangle(Grad1, 1, 1, Width - 2, Height - 2)
                End Select
            Case False
                g.Clear(Color.FromArgb(44, 44, 44))
                ForeColor = Color.FromArgb(115, 115, 115)
        End Select

        Select Case _txtAlign
            Case TxtAlign.Left
                g.DrawString(Text, New Font("Arial", 7, FontStyle.Bold), New SolidBrush(ForeColor), New Rectangle(8, 0, Width, Height), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
            Case TxtAlign.Center
                g.DrawString(Text, New Font("Arial", 7, FontStyle.Bold), New SolidBrush(ForeColor), New Rectangle(0, 0, Width, Height), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            Case TxtAlign.Right
                g.DrawString(Text, New Font("Arial", 7, FontStyle.Bold), New SolidBrush(ForeColor), New Rectangle(0, 0, Width - 8, Height), New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center})
        End Select
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        state = MouseState.Hover : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseHover(e As EventArgs)
        MyBase.OnMouseHover(e)
        state = MouseState.Hover : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        state = MouseState.None : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        state = MouseState.Down : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        state = MouseState.Hover : Invalidate()
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
End Class

Public Class SteamDivider : Inherits Control
    Private _offset As Integer = 8
    Public Property Offset As Integer
        Get
            Return _offset
        End Get
        Set(value As Integer)
            _offset = value
            Invalidate()
        End Set
    End Property
    Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.DrawLine(New Pen(Color.FromArgb(77, 77, 77)), New Point(_offset, Height / 2 - 2), New Point(Width - _offset, Height / 2 - 1))
        BackColor = Color.FromArgb(38, 38, 38)
    End Sub
End Class

Public Class SteamLogo : Inherits Control
    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Size = New Size(118, 36)
    End Sub
    Public Function ConvertToImage(ByVal Code As String) As Image
        Return Image.FromStream(New System.IO.MemoryStream(Convert.FromBase64String(Code)))
    End Function
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim newImage As Image = ConvertToImage("iVBORw0KGgoAAAANSUhEUgAAAHYAAAAkCAYAAABc4c7tAAAABGdBTUEAALGOfPtRkwAAACBjSFJNAACHDwAAjA8AAP1SAACBQAAAfXkAAOmLAAA85QAAGcxzPIV3AAAKOWlDQ1BQaG90b3Nob3AgSUNDIHByb2ZpbGUAAEjHnZZ3VFTXFofPvXd6oc0wAlKG3rvAANJ7k15FYZgZYCgDDjM0sSGiAhFFRJoiSFDEgNFQJFZEsRAUVLAHJAgoMRhFVCxvRtaLrqy89/Ly++Osb+2z97n77L3PWhcAkqcvl5cGSwGQyhPwgzyc6RGRUXTsAIABHmCAKQBMVka6X7B7CBDJy82FniFyAl8EAfB6WLwCcNPQM4BOB/+fpFnpfIHomAARm7M5GSwRF4g4JUuQLrbPipgalyxmGCVmvihBEcuJOWGRDT77LLKjmNmpPLaIxTmns1PZYu4V8bZMIUfEiK+ICzO5nCwR3xKxRoowlSviN+LYVA4zAwAUSWwXcFiJIjYRMYkfEuQi4uUA4EgJX3HcVyzgZAvEl3JJS8/hcxMSBXQdli7d1NqaQffkZKVwBALDACYrmcln013SUtOZvBwAFu/8WTLi2tJFRbY0tba0NDQzMv2qUP91829K3NtFehn4uWcQrf+L7a/80hoAYMyJarPziy2uCoDOLQDI3fti0zgAgKSobx3Xv7oPTTwviQJBuo2xcVZWlhGXwzISF/QP/U+Hv6GvvmckPu6P8tBdOfFMYYqALq4bKy0lTcinZ6QzWRy64Z+H+B8H/nUeBkGceA6fwxNFhImmjMtLELWbx+YKuGk8Opf3n5r4D8P+pMW5FonS+BFQY4yA1HUqQH7tBygKESDR+8Vd/6NvvvgwIH554SqTi3P/7zf9Z8Gl4iWDm/A5ziUohM4S8jMX98TPEqABAUgCKpAHykAd6ABDYAasgC1wBG7AG/iDEBAJVgMWSASpgA+yQB7YBApBMdgJ9oBqUAcaQTNoBcdBJzgFzoNL4Bq4AW6D+2AUTIBnYBa8BgsQBGEhMkSB5CEVSBPSh8wgBmQPuUG+UBAUCcVCCRAPEkJ50GaoGCqDqqF6qBn6HjoJnYeuQIPQXWgMmoZ+h97BCEyCqbASrAUbwwzYCfaBQ+BVcAK8Bs6FC+AdcCXcAB+FO+Dz8DX4NjwKP4PnEIAQERqiihgiDMQF8UeikHiEj6xHipAKpAFpRbqRPuQmMorMIG9RGBQFRUcZomxRnqhQFAu1BrUeVYKqRh1GdaB6UTdRY6hZ1Ec0Ga2I1kfboL3QEegEdBa6EF2BbkK3oy+ib6Mn0K8xGAwNo42xwnhiIjFJmLWYEsw+TBvmHGYQM46Zw2Kx8lh9rB3WH8vECrCF2CrsUexZ7BB2AvsGR8Sp4Mxw7rgoHA+Xj6vAHcGdwQ3hJnELeCm8Jt4G749n43PwpfhGfDf+On4Cv0CQJmgT7AghhCTCJkIloZVwkfCA8JJIJKoRrYmBRC5xI7GSeIx4mThGfEuSIemRXEjRJCFpB+kQ6RzpLuklmUzWIjuSo8gC8g5yM/kC+RH5jQRFwkjCS4ItsUGiRqJDYkjiuSReUlPSSXK1ZK5kheQJyeuSM1J4KS0pFymm1HqpGqmTUiNSc9IUaVNpf+lU6RLpI9JXpKdksDJaMm4ybJkCmYMyF2TGKQhFneJCYVE2UxopFykTVAxVm+pFTaIWU7+jDlBnZWVkl8mGyWbL1sielh2lITQtmhcthVZKO04bpr1borTEaQlnyfYlrUuGlszLLZVzlOPIFcm1yd2WeydPl3eTT5bfJd8p/1ABpaCnEKiQpbBf4aLCzFLqUtulrKVFS48vvacIK+opBimuVTyo2K84p6Ss5KGUrlSldEFpRpmm7KicpFyufEZ5WoWiYq/CVSlXOavylC5Ld6Kn0CvpvfRZVUVVT1Whar3qgOqCmrZaqFq+WpvaQ3WCOkM9Xr1cvUd9VkNFw08jT6NF454mXpOhmai5V7NPc15LWytca6tWp9aUtpy2l3audov2Ax2yjoPOGp0GnVu6GF2GbrLuPt0berCehV6iXo3edX1Y31Kfq79Pf9AAbWBtwDNoMBgxJBk6GWYathiOGdGMfI3yjTqNnhtrGEcZ7zLuM/5oYmGSYtJoct9UxtTbNN+02/R3Mz0zllmN2S1zsrm7+QbzLvMXy/SXcZbtX3bHgmLhZ7HVosfig6WVJd+y1XLaSsMq1qrWaoRBZQQwShiXrdHWztYbrE9Zv7WxtBHYHLf5zdbQNtn2iO3Ucu3lnOWNy8ft1OyYdvV2o/Z0+1j7A/ajDqoOTIcGh8eO6o5sxybHSSddpySno07PnU2c+c7tzvMuNi7rXM65Iq4erkWuA24ybqFu1W6P3NXcE9xb3Gc9LDzWepzzRHv6eO7yHPFS8mJ5NXvNelt5r/Pu9SH5BPtU+zz21fPl+3b7wX7efrv9HqzQXMFb0ekP/L38d/s/DNAOWBPwYyAmMCCwJvBJkGlQXlBfMCU4JvhI8OsQ55DSkPuhOqHC0J4wybDosOaw+XDX8LLw0QjjiHUR1yIVIrmRXVHYqLCopqi5lW4r96yciLaILoweXqW9KnvVldUKq1NWn46RjGHGnIhFx4bHHol9z/RnNjDn4rziauNmWS6svaxnbEd2OXuaY8cp40zG28WXxU8l2CXsTphOdEisSJzhunCruS+SPJPqkuaT/ZMPJX9KCU9pS8Wlxqae5Mnwknm9acpp2WmD6frphemja2zW7Fkzy/fhN2VAGasyugRU0c9Uv1BHuEU4lmmfWZP5Jiss60S2dDYvuz9HL2d7zmSue+63a1FrWWt78lTzNuWNrXNaV78eWh+3vmeD+oaCDRMbPTYe3kTYlLzpp3yT/LL8V5vDN3cXKBVsLBjf4rGlpVCikF84stV2a9021DbutoHt5turtn8sYhddLTYprih+X8IqufqN6TeV33zaEb9joNSydP9OzE7ezuFdDrsOl0mX5ZaN7/bb3VFOLy8qf7UnZs+VimUVdXsJe4V7Ryt9K7uqNKp2Vr2vTqy+XeNc01arWLu9dn4fe9/Qfsf9rXVKdcV17w5wD9yp96jvaNBqqDiIOZh58EljWGPft4xvm5sUmoqbPhziHRo9HHS4t9mqufmI4pHSFrhF2DJ9NProje9cv+tqNWytb6O1FR8Dx4THnn4f+/3wcZ/jPScYJ1p/0Pyhtp3SXtQBdeR0zHYmdo52RXYNnvQ+2dNt293+o9GPh06pnqo5LXu69AzhTMGZT2dzz86dSz83cz7h/HhPTM/9CxEXbvUG9g5c9Ll4+ZL7pQt9Tn1nL9tdPnXF5srJq4yrndcsr3X0W/S3/2TxU/uA5UDHdavrXTesb3QPLh88M+QwdP6m681Lt7xuXbu94vbgcOjwnZHokdE77DtTd1PuvriXeW/h/sYH6AdFD6UeVjxSfNTws+7PbaOWo6fHXMf6Hwc/vj/OGn/2S8Yv7ycKnpCfVEyqTDZPmU2dmnafvvF05dOJZ+nPFmYKf5X+tfa5zvMffnP8rX82YnbiBf/Fp99LXsq/PPRq2aueuYC5R69TXy/MF72Rf3P4LeNt37vwd5MLWe+x7ys/6H7o/ujz8cGn1E+f/gUDmPP8usTo0wAAAAlwSFlzAAALEwAACxMBAJqcGAAAGRZJREFUeF7tWndYV2eWvhBL4mgyJs7E2cxmd3YzO5NnNppYsIu9YBcUC4qIDZQmgjSRjiKIipVIR5FiRHoHqQKKFBFBsQEqWAEVsd193w9/LEl0B2Z3J/MHPs95fsDv3u+e77znvOc931WaNWuWsJkzZ0qamprS7t27JT8/P2n79u2SsbGxtHfvXmn16tXCTpw4IVlaWn4cGRmpcuDAAaP4+HivoqKikJKSkrDS0tLwwsLCYzExMXu8vLz0IiIihmzZsqVPQECAtGTJEmF79uyR1qxZwzUkXCNZW1uL506YMEGaNGnSe01VVVUaP358u/H348ePSatWrRJrhYSECN/o+/z586W1a9e03zNlyhT8vlbS09OTNmzY8F7T19eXtLS0pHHjxgmfFixYIPb8vvt4vba2tojdnDlzpLlz5wpfeT+fO2bMGGnRokXSpk2bxJ653sKFC4Xx57Fjx0qjR48WNnLkSGnFihXiWvpAn6dNmyZNnz5dmjx5sjRixAhxDW348OGSmpqauHbdunXt2PET8Rb+cs2/Cqynp6f4u42NzaDc3Fynmpqa/GfPnjXLf+XfkydPGm/evJmVmppqY2Ji8tXs2bPF2t3A/gMAu379esnHx+dfo6Ki9j1//vz+W8zEv9evX8uvXr16p/G7jv+am5trEXzngwcPDqTj3cD+gsBaWVmxWpc8evSohOAQrJcvX/5N9ubNGwFwfX19voODg9rmzZu7gf0lgD106FDPhIQES1RfCwFtbW39PzGu9eLFiyb0X72dO3cqdQP7dwTW1dW1d05Ojguq7CVAkFtaWrpsBLHjPwIKKhffsYLxewuE1xZTU1PlbmD/n4ClqKHNmDFDOAdVuxWBb21peSY/e/a00/b06VMB3uvXr+RHjx4+zcvLzQZ4J1NSUqIrKiou8zsCDuElAAYbPAkMDNAlqAwEP99nCkAV1g1sJ4DlzYpFQI/qz1ufPyVQzU+au2TPn7fIjxsfPw8PD/dwdnb+086dO3rQAW7kqM/RT8PCwjQqLlfkPkPCPHn6RH77+dDM3EyVztOxdxmTrmPAuoHtJLC8afDgwZKuru7A+ob6YoLa2PgY1thpw2gjP3hwvwmCS51Oa6/Slk5Hnf4IG//z0mVL/9nR2ZHjkhQbF/txSkpy4FMA29jUKCr3ytUrZzBW9adDDNZPzcDAQIDLQHUD20Vghw0bJqGi3FCtoNFHXbPHjwjsK1dXl/V0dt68eb0gvqxv3rpZXVVVVXO1+mpd3tm8jP3796uiiqUdO1z7lpSWJLPKee9TJNKpU6fWjhs7TlJRUWnfgMIYIAVI3cB2AVj2Vh0dnT9iFLlLoFB5XbKmpia5oCA/bfny5Upz585RPnXqB98bN27cMTc3X+Xr6/tVYGDgN2FhoQfr6mrrt22zmbxy5UqAu2NsQ0PD0wcPHsiPHz+Wr1+/Xrpw4YKBEydOlKZOndpu3Bw3qQjWT4HlaZaJiYkyntEvKCioH4RfL96no7Oq/R4GhsFiEhCI9xm/19DQEEHhMxmoZcuWvfc+xEyITQUAjCP9V/jHdcg0YEKxDn8moLT58+ZLo0aNEoDRmNBMAibSwoXqYh3F/pksPwWWe+K1TAZew2cTXALLpOP1krq6uhRyIsSCADU01MMaOm337jWAih/LoGAtLoyqVbt162b94sWLBzEjDx8+zNFJ2rhxIyoqZFdBQUEhsq0P1LB04UJR3sOHD7FOvUiOAwcO6HANVly7LZgvAszs53o0Asag+fn59vH399fLyEhPKS6+cL64uPg8BFsmery3s7OTKgLTk9eimvpHx0R7Y3yLio+Pe69B5EX5+Pp4AIQe5uZmZJYBYDHfxMTEd16fnJwUFRwcvN/S0qIvElayt7cTAR46dKhgQPp69Oj3dhSPiYkJp6ysrb5ZprVcWoWko6lrqLdXMXxU9vPz25uWnhodERF+cOnSpb8iAyxUF99JKsNVBKA0rg0No52WlhaNf5F49iCugwRUMTXdHI9ED543b/7n0pKlSz48d64w5eHDB/Ldu3e6ZASltq72JQAdYWNjLSHIPtjs0YkTJ2CT06Xvv/9e8vHxERkGsAdWVlVeR6YPWwDAAoMC9rLPcp3HoGTcGz5TbeYHGos0pI7GjFRUMI1rIRj98/LyQpFULyjEGpseU7gJo5qHT6/j4mInkbLQGv50734D2kUzEgh6ANfzk89sam6Sm2FNzY1y64tWuajofLWBoWGvffv2MhG/qK6+eo/X8xrF/byH1gKxWFFx6fahw4d+7eNzFPsJFEzBfc9ABWtrr/zjvfv3HvOeVrQ4MJk99yPOzZcukQBeOxvgbx8UFRVdoQCFxnmDljVv9pzZ0qLFi0SCcx9MAP7MvV+uvFxOLfQAmLm4uKiyOFet0s7YbrddRhHJqFpnlK/p17dqbjXeQYDrbtd1yRpQsSUlxbWenp5/SEtLlfDzaTc3NxuAKGiKJ0ykIlID6K3n+fPnStET582cOUPaf8DLiT2W66ALyJWVl+8ePHTw93zpsG/fPmFe+71Ez2AASH20pQgKAqnPe5lYaAPpR32+X+fl5aWNKrIuv1SemZ2Tnaihod6XdIcq6p+almqfk5PtnJuX65ieke6Gvt+M1iNfulRenJWdZZ+VlemYX5DvCjA3oqX0dHB0kPwD/AeWlpVeu3//nlxefvHamTMZdjm5OY5Y24mWn3/WJTIy0mTbtm2/cnBwEEewBI0VRmr29fMxYqu6c+e2fBf7w0RQhpgMQKKJSl0M0EilbBOg4Q+wZvH9+/dlJIMMX39AkveYjiShaa3QEqzH/Xt7ey9i3O/cuSODHV85OTuNWay5mNQcAaEpI14EdgspZBUy+mVN7S25pqYLhutRbS8dHOx1SBEuLs5SaFioG5RvNJ1wd3cXDd7A0ED0CU3NxYOR4dVw7g8IHq494dNwr16sVVtbg83fabSw2DqK/Y39iEYaBq1Ke/fukTw9dwujAEtIiA9nwG/cuPYEwuhrBsfW1lY6HnJcQmJ9huv+pa0fqYiKj4qOktIy0qjUGZyeEHN1ZKioqNPBhw8fkpJTkqW09DQJVCwCvR8JheT5HIl67eGjB/IPP5xMMjI2kuIT4qWY2Bhh/Bm9XRy98tmgQIgkXSHUUIUfApy0+oa7UP1V8s1bN+Q7d2/LqG5NXd3VAqR169ZKjAMNvV0ZyVXMBGcs8NlqvtVsvMoIFWnseArSuejTS3ltL7SbKMV11deqX+3Z4zmOTIHk/3fEe7eRkZEVkvkjOOfvyU3evHkDgbreObt5XWRienr6UWRhj7aKnMzF/xNVUIkKXgUVLFSbDfoPMrJvdHRUPOjWz9DQUBmg9SosLLhA5xRrIkneeHh4GDGLqWppVJPsXW5uQk0LQyJJMTHRJ7i56urqZ4GBAerGJsZKDLA+Asa3UW5uOwUljkTFkr4TkxIFEGQPJMsnqPK6e0gq+BRia7tNCggMkFAxom1s3myCmARIR44c/hzULCoWwCawEqmEySD8JIBkJr4o4c8USG9B4hn4IOytmUmLfngkIyOjkjFOTk4OmDlTTZkVjU8k+5J2YBGb4ttgL+LA9oS+HCT0xJjRggG4D+xxAq5pQqWK665evfLKw8N9rIWFJVhgvogVC4lJTYW6AD22AuNJCx25dv0aM+F/NFA3KLCgVG+D3peaSzQF97My+AkKW152sawCYsXPydFx7f4D+82QZTlJyUlnVq5c8TtQDByw14RjLzs+iyBDENlZWVlKdnbbheE6QVesXChuYdwggqWJxGqBz/KVK1WPMrMy/THqrLCwsPiti6sLZmZr0KKmNAG9niLkVOSpt6OBGmnwE/TnOraeyNORx7dvt0WyOEjHoLKDgoMkdw930KivhOr6vPBcYTVbRVZWVimodgFM3c7OTgN+aWAun4yA96QC5unYmNFjoHRHi7YDhe7AREUcXoCB+np7H/n+9u3bSMSrDZjx/2PChIkiXlTCTAj0SGWIoWLGoKqqUsQDoD1Bz1TRWa0jxCMEo3JcfJwf9IOMdvMCsXsDzfJqp9vOsY5OjqK/W2PfBJbiUgQNffbToKDAmcjsY5cqLjVdR8CvYXEE7Wd2tfoKH/oCmaIG9SWylqZwlMIDfWeof4DfYdBRRmxcTFxAgL+xvr5eP4ICNfglem359RvXfrQuq/ZE6Imdu9x3SXtAvTRWPdYS4wNHAFI6xwn0px4hIccNK6suP2AwbtXcFPeXlZVWxsbGbAc1fqUORTlp8iRpLmhsxcoVb8cNobY/hl91GL8oaI6xYp0QGEf0VT9/Pwg+b/SxI9LBgwd+iz569dp1Jt5V0TL4HFptXY2MZ7dCyHzJ5JkydYpQ8AsWsncuHoBCqay7XSuHnDiewmRH75tFSua9vr4+5osWLRYJy2qliMI6SikpyRdI12gPF6DsU27fqZMTEuOd16xbqzRcZbi0bv26b+BLC1ikCDE2Qvya0NpkCNcx9B1tTEIiiAMdASwfzAwH8tIGvQ3c4HAoSvPCcwUl3BQBxiYIJqq5WvRWVNYuBplAEVDK/DlQcVRuDAqbPOdVL699lPyietzd3aQtZlu+Tk1NyWHiXL5cIV+u/G9j8DCbuoJBJCTNW/MQ/ZWbJ6BtwKpi7RXSGlA1Ro0hUOHuoNZz9I3JwrWLSy4Ubdy08S/jxo8TVTtt+jRURZuqJLCZWWfqGOSTJyOCmTiOjm3Agl2E/6Bh6cCB/b/JO5t7lftGAJuKMFHhOWUFhfll584XXszOzioFg3w5XrXNr2nTpsK3caTD6fSB95mZbdEdN24sVW0vjEgX+czc3OxU/P4RaZZql70TM7xSUlKiABZtwd/AYNNAxONO+aWLt8zMzb6keISw8+T3EIqmh48c/gtweXaxvIyqeDQBpeBj5WLfbXMsF2fW7oAo0dPXEzy9e7cHe+Nn+FyZlJyYXlFR3piXl3MTGRgMUWEMeviYwWaWkOLQN5F9y0SCINgiMPzd0NCgB+ay34ARvg0KCrArLi6qvnKlEmr04s+MTHDo0EEb9ritWFdhXE8PCcdk4VCuo7Na9DUmjqGRgVCiSMp+ePas1NTkWCYMQY6ICPNDIiltw97WQqiwR1KRwj7OyEirg/CSw8PDgukz+zYNYGL2PoTZ+yCTckBOTtYVXnfyh4h0D49dv05JSeqfmBjfH+r709NRkZ8gYZRHjBwBptKAINIX4gnXBl/H85EIrVh7C+IzG3pBLTQ0JLUae8T+W01MjCdRcFKXcPQBkyglJMRBc9ySwUSRBBs64mRN7U0ZY6HJ+vXrPikrKykpu1hav3GT/ue5eTmDKy5fel5aWowe7jSa7YSty8HRnuwrCk0MvLt2uYnAUalxg1SFFggoZjGqxN4HDu4fgsUHzps/j4H+DkH9GkFWohKGk+Ja9goqVmOoR1CvZGVtOZSiA+PEFVBk06WKcvSGi6RLGQ7+zKquVL4BJepDPQvqFAaZz3PnTQZQ16AYhVEEcZRiAnI25AjEBAW1DUQ13a+sqpBTUlNSkP09wsLD4IuVxN5OWoZ9jPGnjgwRGnoiqGNPJ8OAggXAYIoBqOwqMlbwsSCIp9nS1q1Itq3m4hNJI9Zk/5s9exYEkLq0YcP634MtLrGSuFcyEfYlDEAo9snnHqW444EM2YwtAi2riOoZ7SiKa5qabh6HEbAVDHEVLSON9x07HuxITQMmGY4R7NmF4iIZTDOKByQsThpBZnFKQ4YMEcCyAlkJ/JKZR+SpTFmRllYW4m+o4t/BKW04cTriZPgum23WnxsZGYrKIrAEGpnbA9csZX8SmwGQGBtIj++1EmReeXnZfbSCb6joOr6uY5VRHbNaadraqwjqV0e8j8yG+v0ntVlqSsOGD6MA6YH+OAXANvK5kZGnopxdnJU4IoHaJFwnhBSsH/pZHQOF6gjkWTNnUNpe6APSMednzz2eAzDzVrH/Yz9JbDukXB6Q0KZOmaoE8aTMfsZ5mS9SwBw6YIw32M8zjC/5YLvc5JSkvLeWjd5by3igzVVqaS3/gu2B+oQtAgq96FpbO4piogD4HvEJcRGiIMovMoY1GGW+5kke1h+GuD3DXmUIv5F8wcKW0tHYJ3u7u+/6lP2RIBLxOVCfK7Xfjh34m7GJEbORalRUCYD+NTjfLiw81BOiqDezl8IJ2TMwNDTU+8KF888JWFHRuU4ZgQU93kCQ+6MvSebm5sJYHaxQxYhBI7jo28agtCcYEWqjoiLLkMlFCEw5Anefa4Han6ACF02GeFJDVTFQTBCqasyE/ZKSEm5XXC6Xjx0LDoKSbs92zISiaikAsc/P0tJSqkrLSuSz+XlPoqJPl5w+faoUFCwsNi66zN/fNxT+9mbiAZweEG5ZTKrk5MRMxPQzMN1HsD4HDx3o47ln94dYcy6q+SnX9Nq/T5PA8tSIwJ4+HXmBAis4ODCa7DBhgirGJstpAPYFWxVi7cpDDZ5yoaUNRdyeFhSelVGdI63BSGwpHY0b7RMScswD2e6MSvgzy5oUQypkIElzpA3+zFmRahWVyiroe+ZMesCmTRtVRDXbWE9OTEooQi+QmUnIyk4bN4og+1BQUIwpjFXi6OQgAs6EomGmVYa/TqCoVj6LdMdg0i6C6rDefWx+w4L58z+gcFGFuJkO8URg2WdZsWlpqQ0MIio2yAK0yj3T2ILYX0nHAPizzMyM22ASsE5J+zMUdhX3p6enViCB+rAoTExMVDDDv7mM73z9fDbxIOKI9+F2c/fYhfhZDsjNy66tghhFNSZvs7XpzYKhYo+JjSllP0eSxrBlsO1BVPWKjj4dmV9wtgrx/ZZtDj5J6K3DGbPzKAoCy3ZCcDuayAzXHS4rkMGv0ZRrQLFHzLeazdRaofUhqRmLi/mPDnDe4zhCocDqDg0LCYIaW4LeOBz31rP68vPz5PyCzhuqQb5QfL4JQmwyD85JdwrjiEPx5AhR4OBgJ8zZ2ZFM0gOfKqjcdbAIAB0HcRYJCnXCpr5bhb7M3kVQWbXsZR1MGVS1Fu3HH2CqIlhKFGy0tsMGstRaSXeN7odgL2foBj+MFD+zHTtd/Z2cnRYZmxj34rkuxpFpAM9/xw5XG4D9JWfK3Z4eko/vUXFiRoHFPgwQFuHZfs4uTruQtL/i83jEamlludhjt4c/GGA6gWayMBlRYL+BePw3xFyp7eXEDp7GfQHMvOGHpclmk9/CB7Dqjw3iaDlGB92+KalJGQXn8pHxtIIXcXExGbhxAmkBFatEBwgs5LY4CZk0aeJHSckJuRg7RuNBiwrPF8gAt8uGypNjYqNPQQn2ItUQEIVRSJGOnVC1BJfm6uoshnHOnqwK0uymTfpCaDERFOqUTPMeYMVrsm+//VYEm1qCApDG/j5o0CDx3eDB3wlhORz9+102ZMh3omUhsEKniLcvKsMwaqgIzbHNdrvksdtdAEumoUDi8yiMhg0bKnzgOlMxA7N42Ku5jioKjWfJClsKhbx6tY4QpdwXr6FfXIO9neMNgeSRZ0fjWwERRDihQc7Ozs6UIfNBpwVyYlJ8DjLnA6jlIeifU+zt7ZUoLJZrLe8TFhZqdzwk+Azmt97+AX7h4t6czC4ZnwOaeWFrazORALHftPWdNmMwOLO6uDj9CFhulGfIHINYBZs3G4tNUxlTKP01YCnKGEhe0xFYtgIGrS3oKuLVG2fTd9mYMaPFqzcCS1C53nhVzM0AhlPCNlvbHwFL8AgsmYgtgj7wk22O+2RS8nlTMQ93BHYZxkbuh8ByamFi0E/ey3s4MbwTWN7M5g3x0+dU5A/eeWdzXoPH5cysDBmy+gWcs50+bdonGAE84hNioyH9faGKc4OCA+PwwE8x1qgRJIwG4p5OG54BGn51/HiwGwDpwYATmI5GZqDaJpjdwHYRWI4AFBXkdfSzP0AJVjPwUKnCcnKzeZDtuN3OdggCOQpNXFNPf8NYaxsrVrEWBNTlM5np7dd31rLADGCEEg7ckzGoE0SeEHU0vunhMZ29/fZ2Ou4GtpPA8ihMYXTYwnLrFABbl56RKqemJctp6SmgzSz2wafe3oc9ff2OWh05csg54mRYXWb2GXzP61K6ZBlnBLjV6A/DhyEoPPrj66mfGv/Okx32UEXVdgP7NwDLRs65DzPdDAT/LsFNTkkURoBpqDKAkywrvoPo6rTx+owzImGumZmZjmHQx8JBAvg+GzlqJMDa2A3s/xZYPoRzFEaeibFxUZcIINRvuxGcjr93xZAsbzDkn8fsO4wSn0nUDezfEVj+Vwu+8sIs9kVwcOBeVNtLVlxCYtzfZClpolpb/AN8neHEZ3SKz+kG9hcAdgYqiicafAng4uo8PeTEsWiA85xUzOojYFDJ7zR+11al4tpmKOhwO/vt45csXaJMJxjsbmB/QWB55sj/RbdBb71kaGDQEw5PDz4WaAWQi2Pjou8peidBTE5JaO+lMbFR9ZhxCwMC/cxMt2xW1duwXpnvT7VWLJc2m27uBvYfBVgDw03iREd/ox7o2UoyMjLsb7rF9GtDIwNDm23WFq47XBxcdzjb4+etAEF/i5npV0iGfrxWV1dH2rB+nXiJ3w3s3wtYI+m/AKVYXDJwLZcNAAAAAElFTkSuQmCC")
        e.Graphics.DrawImage(newImage, 0, 0, 118, 36)
        newImage.Dispose()
    End Sub
End Class
<DefaultEvent("CheckedChanged")> Public Class SteamCheckBox : Inherits Control
    Dim _state As MouseState = MouseState.None

    Private _Checked As Boolean
    Public Property Checked As Boolean
        Get
            Return _Checked
        End Get
        Set(value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property

    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        Size = New Size(180, 25)
    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        If Not Checked Then Checked = True Else Checked = False
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub
    Event CheckedChanged(ByVal sender As Object)

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim G As Graphics = e.Graphics

        Dim selectionrect As Rectangle = New Rectangle(4, 4, 15, 15)
        Dim innerselectionrect As Rectangle = New Rectangle(5, 5, 13, 13)


        MyBase.OnPaint(e)
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        G.Clear(Color.FromArgb(38, 38, 38))

        G.DrawString(Text, New Font("Tahoma", 8, FontStyle.Regular), New SolidBrush(Color.FromArgb(168, 168, 168)), New Rectangle(25, 3, Width, 16), New StringFormat() With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})

        If Checked Then
            G.FillRectangle(New SolidBrush(Color.FromArgb(145, 145, 145)), selectionrect)
            G.FillRectangle(New SolidBrush(Color.FromArgb(38, 38, 38)), innerselectionrect)
            G.DrawString("b", New Font("Marlett", 18, FontStyle.Regular), New SolidBrush(Color.FromArgb(235, 235, 235)), New Point(-4, 1))
            G.DrawString(Text, New Font("Tahoma", 8, FontStyle.Regular), New SolidBrush(Color.FromArgb(227, 227, 227)), New Rectangle(25, 3, Width, 16), New StringFormat() With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
        Else
            G.FillRectangle(New SolidBrush(Color.FromArgb(103, 103, 103)), selectionrect)
            G.FillRectangle(New SolidBrush(Color.FromArgb(38, 38, 38)), innerselectionrect)
        End If
    End Sub
End Class
Public Class SteamTextBox : Inherits Control
    Private state As MouseState = MouseState.None
    Dim WithEvents txtbox As New TextBox
    Private _status As Boolean


#Region " Control Help - Properties & Flicker Control "
    Private _passmask As Boolean = False
    Public Shadows Property UseSystemPasswordChar() As Boolean
        Get
            Return _passmask
        End Get
        Set(ByVal v As Boolean)
            txtbox.UseSystemPasswordChar = UseSystemPasswordChar
            _passmask = v
            Invalidate()
        End Set
    End Property
    Private _maxchars As Integer = 32767
    Public Shadows Property MaxLength() As Integer
        Get
            Return _maxchars
        End Get
        Set(ByVal v As Integer)
            _maxchars = v
            txtbox.MaxLength = MaxLength
            Invalidate()
        End Set
    End Property
    Private _align As HorizontalAlignment
    Public Shadows Property TextAlignment() As HorizontalAlignment
        Get
            Return _align
        End Get
        Set(ByVal v As HorizontalAlignment)
            _align = v
            Invalidate()
        End Set
    End Property
    Public Property Status As Boolean
        Get
            Return _status
        End Get
        Set(value As Boolean)
            _status = value
            Invalidate()
        End Set
    End Property
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Protected Overrides Sub OnBackColorChanged(ByVal e As System.EventArgs)
        MyBase.OnBackColorChanged(e)
        txtbox.BackColor = BackColor
        Invalidate()
    End Sub
    Protected Overrides Sub OnForeColorChanged(ByVal e As System.EventArgs)
        MyBase.OnForeColorChanged(e)
        txtbox.ForeColor = ForeColor
        Invalidate()
    End Sub
    Protected Overrides Sub OnFontChanged(ByVal e As System.EventArgs)
        MyBase.OnFontChanged(e)
        txtbox.Font = Font
    End Sub
    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        MyBase.OnClick(e)
    End Sub
    Protected Overrides Sub OnLeave(e As EventArgs)
        MyBase.OnLeave(e)
        state = MouseState.None : Invalidate()
    End Sub
    Protected Overrides Sub OnEnter(e As EventArgs)
        MyBase.OnEnter(e)
        state = MouseState.Click : Invalidate()
    End Sub
    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
        txtbox.Focus()
    End Sub
    Sub TextChngTxtBox() Handles txtbox.TextChanged
        Text = txtbox.Text
    End Sub
    Sub TextChng() Handles MyBase.TextChanged
        txtbox.Text = Text
    End Sub
    Sub NewTextBox()
        With txtbox
            .Multiline = False
            .BackColor = Color.FromArgb(43, 43, 43)
            .ForeColor = ForeColor
            .Text = String.Empty
            .TextAlign = HorizontalAlignment.Center
            .BorderStyle = BorderStyle.None
            .Location = New Point(5, 4)
            .Font = New Font("Trebuchet MS", 8.25F, FontStyle.Bold)
            .Size = New Size(Width - 10, Height - 11)
            .UseSystemPasswordChar = UseSystemPasswordChar
        End With

    End Sub
#End Region

    Sub New()
        MyBase.New()

        NewTextBox()
        Controls.Add(txtbox)

        Text = ""
        Font = New Font("Arial", 8, FontStyle.Regular)
        ForeColor = Color.Silver
        BackColor = Color.FromArgb(38, 38, 38)
        Size = New Size(135, 22)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        Dim selectionrect As Rectangle = New Rectangle(0, 0, Width - 1, Height - 1)
        Dim innerselectionrect As Rectangle = New Rectangle(1, 1, Width - 3, Height - 3)

        Height = txtbox.Height + 10
        With txtbox
            .Width = Width - 10
            .TextAlign = TextAlignment
            .UseSystemPasswordChar = UseSystemPasswordChar
        End With
        G.Clear(Color.FromArgb(38, 38, 38))
        Select Case state
            Case MouseState.Click
                G.FillRectangle(New SolidBrush(Color.FromArgb(145, 145, 145)), selectionrect)
                G.FillRectangle(New SolidBrush(Color.FromArgb(38, 38, 38)), innerselectionrect)
            Case MouseState.None
                G.FillRectangle(New SolidBrush(Color.FromArgb(103, 103, 103)), selectionrect)
                G.FillRectangle(New SolidBrush(Color.FromArgb(38, 38, 38)), innerselectionrect)
        End Select

    End Sub
End Class

Public Class SteamControlBox : Inherits Control
#Region " MouseStates "
    Dim State As MouseState = MouseState.None
    Dim X As Integer
    Dim MinBtn As New Rectangle(0, 0, 20, 20)
    Dim CloseBtn As New Rectangle(15, 0, 20, 20)
    Protected Overrides Sub OnMouseDown(e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        If X > MinBtn.X And X < MinBtn.X + 20 Then
            FindForm.WindowState = FormWindowState.Minimized
        Else
            FindForm.Close()
        End If
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Hover : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Hover : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseMove(e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.Location.X
        Invalidate()
    End Sub
#End Region

    Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Size = New Size(40, 24)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)

        MyBase.OnPaint(e)

        G.Clear(BackColor)
        Dim CloseFont As New Font("Segoe UI Symbol", 10.03, FontStyle.Bold)
        Dim MinFont As New Font("Marlett", 11, FontStyle.Bold)

        Select Case State
            Case MouseState.None
                G.DrawString("0", MinFont, New SolidBrush(Color.FromArgb(168, 168, 168)), MinBtn, New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                G.DrawString("✕", CloseFont, New SolidBrush(Color.FromArgb(168, 168, 168)), CloseBtn, New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            Case MouseState.Hover
                If X > MinBtn.X And X < MinBtn.X + 20 Then
                    G.DrawString("0", MinFont, New SolidBrush(Color.FromArgb(227, 227, 227)), MinBtn, New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                    G.DrawString("✕", CloseFont, New SolidBrush(Color.FromArgb(168, 168, 168)), CloseBtn, New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Else
                    G.DrawString("✕", CloseFont, New SolidBrush(Color.FromArgb(227, 227, 227)), CloseBtn, New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                    G.DrawString("0", MinFont, New SolidBrush(Color.FromArgb(168, 168, 168)), MinBtn, New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                End If
        End Select


        e.Graphics.DrawImage(B.Clone(), 0, 0)
        G.Dispose() : B.Dispose()
    End Sub
End Class