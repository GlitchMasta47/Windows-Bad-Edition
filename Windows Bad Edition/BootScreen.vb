Public Class BootScreen
    Public WithEvents NotifyIcon1 As NotifyIcon

    Private Sub BootScreen_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub BootScreen_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            NotifyIcon1.Icon = SystemIcons.Application
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.None
            NotifyIcon1.BalloonTipTitle = "Windows Virtual PC"
            NotifyIcon1.BalloonTipText = "Your virtual computer is still running in the background."
            NotifyIcon1.ShowBalloonTip(50000)
            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub BootScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1 = New NotifyIcon
    End Sub
End Class