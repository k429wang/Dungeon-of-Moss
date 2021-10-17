Public Class Conclusion
    Dim events As Integer = 0
    Dim mossimage As Integer = 1
    Private Sub Conclusion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblWin.Hide()
        Me.lblEndless.Hide()
        Me.picMoss.Hide()
        Me.btnExit.Hide()
        tmrEvents.Start()
        tmrMoss.Start()
    End Sub

    Private Sub tmrEvents_Tick(sender As Object, e As EventArgs) Handles tmrEvents.Tick
        events += 1
        Select Case events
            Case 1
                System.Threading.Thread.Sleep(1000)
            Case 5
                Me.lblScore.Left += 41
                Me.lblScore.Top += 12
            Case 7
                Me.lblScore.Left += 41
                Me.lblScore.Top += 12
            Case 9
                Me.lblScore.Left += 41
                Me.lblScore.Top += 12
            Case 11
                Me.lblScore.Left += 41
                Me.lblScore.Top += 12
            Case 13
                Me.lblScore.Left += 41
                Me.lblScore.Top += 12
            Case 15
                Me.lblScore.Left += 41
                Me.lblScore.Top += 12
            Case 17
                Me.lblScore.Left += 43
                Me.lblScore.Top += 12
            Case 28
                My.Computer.Audio.Play(My.Resources.Bad_Apple, AudioPlayMode.Background)
            Case 34
                Me.lblWin.Show()
                Me.lblEndless.Show()
                Me.picMoss.Show()
                Me.btnExit.Show()
                Me.BackColor = Color.LightSkyBlue
            Case 39
                Me.BackColor = Color.HotPink
            Case 44
                events = 33
        End Select
    End Sub

    Private Sub tmrMoss_Tick(sender As Object, e As EventArgs) Handles tmrMoss.Tick
        Select Case mossimage
            Case 1
                picMoss.Image = My.Resources.Moss_with_Knife
                mossimage += 1
            Case 2
                picMoss.Image = My.Resources.Moss_with_Knife_2
                mossimage += 1
            Case 3
                picMoss.Image = My.Resources.Moss_with_Knife_3
                mossimage = 1
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        My.Computer.Audio.Stop()
        tmrEvents.Stop()
        MainScreen.Show()
        Me.Hide()
    End Sub
End Class