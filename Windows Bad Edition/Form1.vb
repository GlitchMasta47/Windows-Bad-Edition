Public Class Form1
    Dim preparePercent
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        PictureBox1.Hide()
        UseWaitCursor = True
        PrepareTimer.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Beep()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Beep()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Beep()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UseWaitCursor = False
        PrepareTimer.Stop()
        preparePercent = 0
    End Sub

    Private Sub PrepareTimer_Tick(sender As Object, e As EventArgs) Handles PrepareTimer.Tick
        If preparePercent = 0 Then
            preparePercent = 29
        ElseIf preparePercent = 29 Then
            preparePercent = 49
        ElseIf preparePercent = 49 Then
            preparePercent = 72
        ElseIf preparePercent = 72 Then
            preparePercent = 97
        ElseIf preparePercent = 97 Then
            preparePercent = 99
        ElseIf preparePercent = 99 Then
            preparePercent = 100
        End If
        Label1.Text = "Preparing " & CStr(preparePercent) & "%"
        If preparePercent = 100 Then
            Hide()
            BootScreen.Show()
        End If
    End Sub
End Class
