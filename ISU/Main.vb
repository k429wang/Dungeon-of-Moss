'This is my game, 
'It's a dungeon game where you kill zombies and try to get the highest score possible!



Public Class MainScreen
    Dim mossimage As Integer = 1            'used to animate the picture
    Dim mossright As Boolean = True         'used to determine what direction he is facing
    Private Sub btnHowToPlay_Click(sender As Object, e As EventArgs) Handles btnHowToPlay.Click
        Me.Hide()                   'hide the current form
        How_to_play.Show()          'show the next form
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        Me.Hide()                   'hide the current form
        Endless = False             'make the game not endless mode
        Introduction.Show()         'show the next form
    End Sub

    Private Sub tmrMossRight_Tick(sender As Object, e As EventArgs) Handles tmrMossRight.Tick
        Select Case mossimage                               'animate the picture
            Case 1
                picMoss.Image = My.Resources.Moss1      'first picture
                mossimage += 1
            Case 2
                picMoss.Image = My.Resources.Moss2      'second picture
                mossimage += 1
            Case 3
                picMoss.Image = My.Resources.Moss3      'third picture
                mossimage = 1
        End Select
    End Sub

    Private Sub btnQuickPlay_Click(sender As Object, e As EventArgs) Handles btnQuickPlay.Click
        Endless = True              'make the gamemode endless mode
        Level_1.Show()              'show the next form
        Me.Hide()                   'hide the current form
    End Sub

    Private Sub btnStart_MouseHover(sender As Object, e As EventArgs) Handles btnBegin.MouseHover
        'show the 3 labels that have descriptions when mouse hovers over
        Me.lblBeginText.Show()
        Me.lblQuickPlayText.Show()
        Me.lblHowToPlayText.Show()
    End Sub

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrMossRight.Start()        'start the timer for animation
        'hide the descriptive texts for now
        Me.lblBeginText.Hide()
        Me.lblQuickPlayText.Hide()
        Me.lblHowToPlayText.Hide()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Shanghai_Teahouse, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnQuickPlay_MouseHover(sender As Object, e As EventArgs) Handles btnQuickPlay.MouseHover
        'show the 3 labels that have descriptions when mouse hovers over
        Me.lblBeginText.Show()
        Me.lblQuickPlayText.Show()
        Me.lblHowToPlayText.Show()
    End Sub

    Private Sub btnQuickPlay_MouseLeave(sender As Object, e As EventArgs) Handles btnQuickPlay.MouseLeave
        'hide the labels when the mouse no longer hovers over the buttons
        Me.lblBeginText.Hide()
        Me.lblQuickPlayText.Hide()
        Me.lblHowToPlayText.Hide()
    End Sub

    Private Sub btnStart_MouseLeave(sender As Object, e As EventArgs) Handles btnBegin.MouseLeave
        'hide the labels when the mouse no longer hovers over the buttons
        Me.lblBeginText.Hide()
        Me.lblQuickPlayText.Hide()
        Me.lblHowToPlayText.Hide()
    End Sub

    Private Sub btnHowToPlay_MouseHover(sender As Object, e As EventArgs) Handles btnHowToPlay.MouseHover
        'show the 3 labels that have descriptions when mouse hovers over
        Me.lblBeginText.Show()
        Me.lblQuickPlayText.Show()
        Me.lblHowToPlayText.Show()
    End Sub

    Private Sub btnHowToPlay_MouseLeave(sender As Object, e As EventArgs) Handles btnHowToPlay.MouseLeave
        'hide the labels when the mouse no longer hovers over the buttons
        Me.lblBeginText.Hide()
        Me.lblQuickPlayText.Hide()
        Me.lblHowToPlayText.Hide()
    End Sub
End Class

Public Module Variables
    Public Endless As Boolean = False       'dim variable for endless mode
    Public score As Integer     'dim variable for score
End Module