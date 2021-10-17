Imports System.Media
Public Class Level_1
    Dim mossimage As Integer = 1        'the variable used to animate the main character
    Dim move As Boolean = True       'a boolean that if true, will allow the user to move the character, otherwise you can't
    Dim knife As Boolean = True     'a boolean that shows if Moss is holding the knife
    Dim knifedir As Integer     'a variable that defines what direction the knife is when it's thrown
    Dim toss As Integer = 0     'a variable that defines how far the knife travels once thrown
    Dim face As Integer     'a variable that defines what direction moss is facing
    Dim knifehand As Boolean = True     'a variable that's also used to show if Moss is holding the knife, but used more specifically for animation
    Dim zombie1from As Integer = 1      'what door the 1st zombie is from
    Dim zombie1to As Integer = 5        'what door the 1st zombie is going to
    Dim zombie2from As Integer = 2      'what door the 2nd zombie if from
    Dim zombie2to As Integer = 6        'what door the 2nd zombie is going to
    Dim health As Integer = 3       'variable for his health

    Private Sub MainScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'dim the variable used to move the character
        Dim Loc As Point

        If move = True Then
            Select Case e.KeyCode
                'move left
                Case Keys.A
                    face = 1
                    If knife = True Then
                        Me.picMoss.Image = My.Resources.Moss_with_Knife_Reversed        'change the picture so that the character is facing the right direction
                    Else
                        Me.picMoss.Image = My.Resources.Moss1_New_Reversed
                    End If

                    tmrMossRight.Stop()      'use the correct timer, depending on the direction
                    tmrMossLeft.Start()
                    If Not picMoss.Location.X - 10 < 0 Then
                        Loc = New Point(picMoss.Location.X - 30, picMoss.Location.Y)        'find the new location
                        picMoss.Location = Loc
                    End If
                'move right
                Case Keys.D
                    face = 2
                    If knife = True Then
                        Me.picMoss.Image = My.Resources.Moss_with_Knife     'change the picture so that the character is facing the right direction
                    Else
                        Me.picMoss.Image = My.Resources.Moss1_New
                    End If

                    tmrMossLeft.Stop()      'use the correct timer, depending on the direction
                    tmrMossRight.Start()
                    If Not picMoss.Location.X + 10 > Me.Width - picMoss.Width - 10 Then
                        Loc = New Point(picMoss.Location.X + 30, picMoss.Location.Y)        'find the new location
                        picMoss.Location = Loc
                    End If
                'move up
                Case Keys.W
                    If Not picMoss.Location.Y - 10 < 0 Then
                        Loc = New Point(picMoss.Location.X, picMoss.Location.Y - 30)        'find the new location
                        picMoss.Location = Loc
                    End If
                'move down
                Case Keys.S
                    If Not picMoss.Location.Y - 10 > Me.Height - picMoss.Height + 1.1 Then
                        Loc = New Point(picMoss.Location.X, picMoss.Location.Y + 30)        'find the new location
                        picMoss.Location = Loc
                    End If
                'throw up
                Case Keys.I
                    If knife = True Then                'change the picture of the knife and Moss, and start the procedures for knife movement
                        knifehand = False
                        Me.picKnife.Image = My.Resources.Knife_Up
                        Me.picKnife.Show()
                        Me.picKnife.Top = Me.picMoss.Top
                        Me.picKnife.Left = Me.picMoss.Left
                        knifedir = 1
                        tmrKnife.Start()
                    End If
                'throw left
                Case Keys.J
                    If knife = True Then        'change the picture of the knife and Moss, and start the procedures for knife movement
                        knifehand = False
                        Me.picKnife.Image = My.Resources.Knife_Left
                        Me.picKnife.Show()
                        Me.picKnife.Location = Me.picMoss.Location
                        knifedir = 2
                        tmrKnife.Start()
                    End If
                'throw down
                Case Keys.K
                    If knife = True Then        'change the picture of the knife and Moss, and start the procedures for knife movement
                        knifehand = False
                        Me.picKnife.Image = My.Resources.Knife_Down
                        Me.picKnife.Show()
                        Me.picKnife.Location = Me.picMoss.Location
                        knifedir = 3
                        Me.picKnife.Top = Me.picMoss.Top + 25
                        tmrKnife.Start()
                    End If
                'throw right
                Case Keys.L
                    If knife = True Then        'change the picture of the knife and Moss, and start the procedures for knife movement
                        knifehand = False
                        Me.picKnife.Image = My.Resources.Knife_Right
                        Me.picKnife.Show()
                        Me.picKnife.Location = Me.picMoss.Location
                        knifedir = 4
                        Me.picKnife.Left = Me.picMoss.Left + 25
                        tmrKnife.Start()
                    End If
            End Select
        End If
    End Sub

    Private Sub tmrMossLeft_Tick(sender As Object, e As EventArgs) Handles tmrMossLeft.Tick     'if Moss is facing left
        If knifehand = True Then        'animate Moss, according to if he has the knife or not
            Select Case mossimage
                Case 1
                    picMoss.Image = My.Resources.Moss_with_Knife_Reversed
                    mossimage += 1
                Case 2
                    picMoss.Image = My.Resources.Moss_with_Knife_Reversed_2
                    mossimage += 1
                Case 3
                    picMoss.Image = My.Resources.Moss_with_Knife_Reversed_3
                    mossimage = 1
            End Select
        Else
            Select Case mossimage       'no knife
                Case 1
                    picMoss.Image = My.Resources.Moss1_New_Reversed
                    mossimage += 1
                Case 2
                    picMoss.Image = My.Resources.Moss2_New_Reversed
                    mossimage += 1
                Case 3
                    picMoss.Image = My.Resources.Moss3_New_Reversed
                    mossimage = 1
            End Select
        End If
    End Sub

    Private Sub tmrMossRight_Tick(sender As Object, e As EventArgs) Handles tmrMossRight.Tick       'if Moss is facing right
        If knifehand = True Then        'animate Moss, according to if he has the knife or not
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
        Else
            Select Case mossimage       'no knife
                Case 1
                    picMoss.Image = My.Resources.Moss1_New
                    mossimage += 1
                Case 2
                    picMoss.Image = My.Resources.Moss2_New
                    mossimage += 1
                Case 3
                    picMoss.Image = My.Resources.Moss3_New
                    mossimage = 1
            End Select
        End If
    End Sub

    Private Sub tmrKnife_Tick(sender As Object, e As EventArgs) Handles tmrKnife.Tick
        toss += 10      'increase every tick

        Select Case knifedir        'move the knife in whatever direction it should be
            Case 1
                Me.picKnife.Top = Me.picMoss.Top - toss     'up
            Case 2
                Me.picKnife.Left = Me.picMoss.Left - toss       'left
            Case 3
                Me.picKnife.Top = Me.picMoss.Top + toss     'down
            Case 4
                Me.picKnife.Left = Me.picMoss.Left + toss       'right
        End Select

        If toss = 200 Then      'stop moving when it gets to a certain point
            toss = 0
            knife = False
            tmrKnife.Stop()
        End If

        'set boundaries for the knife, if it moves out of it, then stop the timer and set the knife in place
        If Me.picKnife.Left > 725 Then
            Me.picKnife.Left = 725
            knife = False
            tmrKnife.Stop()
        ElseIf Me.picKnife.Left < 280 Then
            Me.picKnife.Left = 280
            knife = False
            tmrKnife.Stop()
        End If

        'same boundaries, but for the up and down directions
        If Me.picKnife.Top > 550 Then
            Me.picKnife.Top = 550
            knife = False
            tmrKnife.Stop()
        ElseIf Me.picKnife.Top < 100 Then
            Me.picKnife.Top = 100
            knife = False
            tmrKnife.Stop()
        End If
    End Sub

    Private Sub Level_1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'hide the knife, as it should only be shown when Moss throws
        Me.picKnife.Hide()
        tmrBounds.Start()           'start the timers for the boundaries and the zombies
        tmrZombie1.Start()
        tmrZombie2.Start()
        Randomize()
        If Endless = True Then
            My.Computer.Audio.Play(My.Resources.Necrofantasia, AudioPlayMode.BackgroundLoop)
        End If
        score = 0
    End Sub

    Private Sub tmrBounds_Tick(sender As Object, e As EventArgs) Handles tmrBounds.Tick
        If Me.picMoss.Left > 720 Then       'set boundaries for Moss to move so that he stays inside the box
            Me.picMoss.Left = 720
        ElseIf Me.picMoss.Left < 280 Then
            Me.picMoss.Left = 280
        End If

        If Me.picMoss.Top > 560 Then        'same boundaries but for up and down directions
            Me.picMoss.Top = 560
        ElseIf Me.picMoss.Top < 100 Then
            Me.picMoss.Top = 100
        End If

        Select Case knife       'code for collecting the knife
            Case False
                If Me.picMoss.Bounds.IntersectsWith(Me.picKnife.Bounds) Then        'change the pictures of the knife and Moss, accordingly
                    Me.picKnife.Hide()
                    Me.picKnife.Location = New Point(1000, 1000)
                    knife = True
                    knifehand = True
                    Select Case face
                        Case 1
                            Me.picMoss.Image = My.Resources.Moss1_New_Reversed
                        Case 2
                            Me.picMoss.Image = My.Resources.Moss1_New
                    End Select
                End If
        End Select

        If Me.picZombie1.Left > 720 Then        'set boundaries for the zombies, once they walk out of the box, they die and randomly respawn
            zombie1from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie1fromcode()
        ElseIf Me.picZombie1.Left < 280 Then
            zombie1from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie1fromcode()
        ElseIf Me.picZombie1.Top > 550 Then
            zombie1from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie1fromcode()
        ElseIf Me.picZombie1.Top < 100 Then
            zombie1from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie1fromcode()
        End If

        If zombie1from = zombie1to Then     'just to make sure they move from one door to another, not the same one
            zombie1to += 1
        ElseIf zombie1to = 7 Then
            zombie1to = 1
        End If

        If Me.picZombie2.Left > 720 Then        'set boundaries for the zombies, once they walk out of the box, they die and randomly respawn
            zombie2from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie2fromcode()
        ElseIf Me.picZombie2.Left < 280 Then
            zombie2from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie2fromcode()
        ElseIf Me.picZombie2.Top > 550 Then
            zombie2from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie2fromcode()
        ElseIf Me.picZombie2.Top < 100 Then
            zombie2from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie2fromcode()
        End If

        If zombie2from = zombie2to Then     'just to make sure they move from one door to another, not the same one
            zombie2to += 1
        ElseIf zombie2to = 7 Then
            zombie2to = 1
        End If

        If Me.picMoss.Bounds.IntersectsWith(Me.picZombie1.Bounds) Then      'code for getting hit by a zombie
            health += -1
            zombie1from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie1fromcode()
        End If

        If Me.picMoss.Bounds.IntersectsWith(Me.picZombie2.Bounds) Then      'code for getting hit by a zombie
            health += -1
            zombie2from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie2fromcode()
        End If

        Select Case health      'code for the display of the three hearts
            Case 3
                Me.picHeart1.Image = My.Resources.Heart_New     'full health
                Me.picHeart2.Image = My.Resources.Heart_New
                Me.picHeart3.Image = My.Resources.Heart_New
            Case 2
                Me.picHeart1.Image = My.Resources.Heart_New     '2 health left, one lost
                Me.picHeart2.Image = My.Resources.Heart_New
                Me.picHeart3.Image = My.Resources.Heart_New_Empty
            Case 1
                Me.picHeart1.Image = My.Resources.Heart_New     'one health left, 2 lost
                Me.picHeart2.Image = My.Resources.Heart_New_Empty
                Me.picHeart3.Image = My.Resources.Heart_New_Empty
            Case 0
                move = False        'when you die, stop the code for everything and hide everything
                Me.picHeart1.Image = My.Resources.Heart_New_Empty
                Me.picMoss.Image = My.Resources.Moss_Dead
                tmrMossLeft.Stop()
                tmrMossRight.Stop()
                tmrZombie1.Stop()
                Me.picZombie1.Hide()
                Me.picZombie1.Enabled = False
                tmrZombie2.Stop()
                Me.picZombie2.Hide()
                Me.picZombie2.Enabled = False
                My.Computer.Audio.Stop()
        End Select

        If Me.picKnife.Bounds.IntersectsWith(Me.picZombie1.Bounds) Then     'when you kill a zombie, score goes up and the zombie respawns randomly
            Me.picZombie1.Hide()
            score += 100
            zombie1from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie1fromcode()
        End If

        If Me.picKnife.Bounds.IntersectsWith(Me.picZombie2.Bounds) Then     'when you kill a zombie, score goes up and the zombie respawns randomly
            Me.picZombie2.Hide()
            score += 100
            zombie2from = Int((6 - 1 + 1) * Rnd() + 1)
            Call zombie2fromcode()
        End If

        If Endless = False Then     'this is the difference between normal mode and endless mode
            If score = 500 Then     'normal mode changes the speed of the zombies, and ends when you get 3000 points
                tmrZombie1.Interval = 150
                tmrZombie2.Interval = 150
            ElseIf score = 1000 Then
                tmrZombie1.Interval = 100
                tmrZombie2.Interval = 100
            ElseIf score = 2000 Then
                tmrZombie1.Interval = 50
                tmrZombie2.Interval = 50
                My.Computer.Audio.Play(My.Resources.Native_Faith, AudioPlayMode.BackgroundLoop)
            ElseIf score = 5000 Then
                My.Computer.Audio.Stop()
                Conclusion.Show()
                Me.Close()
            End If
        ElseIf Endless = True Then      'endless mode is only one speed, and never stops
            tmrZombie1.Interval = 125
            tmrZombie2.Interval = 125
        End If

        Me.lblScore.Text = score        'display the score to the user

    End Sub

    Sub zombie1fromcode()
        Select Case zombie1from
            Case 1
                zombie1to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie1.Location = New Point(290, 130)
            Case 2
                zombie1to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie1.Location = New Point(775, 130)
            Case 3
                zombie1to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie1.Location = New Point(290, 440)
            Case 4
                zombie1to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie1.Location = New Point(775, 440)
            Case 5
                zombie1to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie1.Location = New Point(365, 520)
            Case 6
                zombie1to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie1.Location = New Point(660, 520)
        End Select
    End Sub
    Sub zombie2fromcode()
        Select Case zombie2from
            Case 1
                zombie2to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie2.Location = New Point(290, 130)
            Case 2
                zombie2to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie2.Location = New Point(775, 130)
            Case 3
                zombie2to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie2.Location = New Point(290, 440)
            Case 4
                zombie2to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie2.Location = New Point(775, 440)
            Case 5
                zombie2to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie2.Location = New Point(365, 520)
            Case 6
                zombie2to = Int((6 - 1 + 1) * Rnd() + 1)
                Me.picZombie2.Location = New Point(660, 520)
        End Select
    End Sub

    Private Sub tmrZombie1_Tick(sender As Object, e As EventArgs) Handles tmrZombie1.Tick
        Me.picZombie1.Show()
        Select Case zombie1from
            Case 1
                Select Case zombie1to
                    Case 2
                        Me.picZombie1.Left += 15
                    Case 3
                        zombie1to += 1
                    Case 4
                        Me.picZombie1.Left += 15
                        Me.picZombie1.Top += 10
                    Case 5
                        Me.picZombie1.Left += 4
                        Me.picZombie1.Top += 20
                    Case 6
                        Me.picZombie1.Left += 15
                        Me.picZombie1.Top += 18
                End Select
            Case 2
                Select Case zombie1to
                    Case 1
                        Me.picZombie1.Left += -15
                    Case 3
                        Me.picZombie1.Left += -15
                        Me.picZombie1.Top += 10
                    Case 4
                        zombie1to += 1
                    Case 5
                        Me.picZombie1.Left += -15
                        Me.picZombie1.Top += 20
                    Case 6
                        Me.picZombie1.Left += -4
                        Me.picZombie1.Top += 18
                End Select
            Case 3
                Select Case zombie1to
                    Case 1
                        zombie1to += 1
                    Case 2
                        Me.picZombie1.Left += 15
                        Me.picZombie1.Top += -10
                    Case 4
                        Me.picZombie1.Left += 15
                    Case 5
                        Me.picZombie1.Left += 3
                        Me.picZombie1.Top += 7
                    Case 6
                        Me.picZombie1.Left += 10
                        Me.picZombie1.Top += 5
                End Select
            Case 4
                Select Case zombie1to
                    Case 1
                        Me.picZombie1.Left += -15
                        Me.picZombie1.Top += -10
                    Case 2
                        zombie1to += 1
                    Case 3
                        Me.picZombie1.Left += -15
                    Case 5
                        Me.picZombie1.Left += 10
                        Me.picZombie1.Top += 5
                    Case 6
                        Me.picZombie1.Left += 5
                        Me.picZombie1.Top += 5
                End Select
            Case 5
                Select Case zombie1to
                    Case 1
                        Me.picZombie1.Left += -4
                        Me.picZombie1.Top += -15
                    Case 2
                        Me.picZombie1.Left += 10
                        Me.picZombie1.Top += -9
                    Case 3
                        Me.picZombie1.Left += -5
                        Me.picZombie1.Top += -5
                    Case 4
                        Me.picZombie1.Left += 15
                        Me.picZombie1.Top += -5
                    Case 6
                        zombie1to += 1
                End Select
            Case 6
                Select Case zombie1to
                    Case 1
                        Me.picZombie1.Left += 4
                        Me.picZombie1.Top += -8
                    Case 2
                        Me.picZombie1.Left += -10
                        Me.picZombie1.Top += -7
                    Case 3
                        Me.picZombie1.Left += 5
                        Me.picZombie1.Top += -5
                    Case 4
                        Me.picZombie1.Left += -15
                        Me.picZombie1.Top += -4
                    Case 5
                        zombie1to += 1
                End Select
        End Select
    End Sub

    Private Sub tmrZombie2_Tick(sender As Object, e As EventArgs) Handles tmrZombie2.Tick
        Me.picZombie2.Show()
        Select Case zombie2from
            Case 1
                Select Case zombie2to
                    Case 2
                        Me.picZombie2.Left += 15
                    Case 3
                        zombie2to += 1
                    Case 4
                        Me.picZombie2.Left += 15
                        Me.picZombie2.Top += 10
                    Case 5
                        Me.picZombie2.Left += 4
                        Me.picZombie2.Top += 20
                    Case 6
                        Me.picZombie2.Left += 15
                        Me.picZombie2.Top += 18
                End Select
            Case 2
                Select Case zombie2to
                    Case 1
                        Me.picZombie2.Left += -15
                    Case 3
                        Me.picZombie2.Left += -15
                        Me.picZombie2.Top += 10
                    Case 4
                        zombie2to += 1
                    Case 5
                        Me.picZombie2.Left += -15
                        Me.picZombie2.Top += 20
                    Case 6
                        Me.picZombie2.Left += -4
                        Me.picZombie2.Top += 18
                End Select
            Case 3
                Select Case zombie2to
                    Case 1
                        zombie2to += 1
                    Case 2
                        Me.picZombie2.Left += 15
                        Me.picZombie2.Top += -10
                    Case 4
                        Me.picZombie2.Left += 15
                    Case 5
                        Me.picZombie2.Left += 3
                        Me.picZombie2.Top += 7
                    Case 6
                        Me.picZombie2.Left += 10
                        Me.picZombie2.Top += 5
                End Select
            Case 4
                Select Case zombie2to
                    Case 1
                        Me.picZombie2.Left += -15
                        Me.picZombie2.Top += -10
                    Case 2
                        zombie2to += 1
                    Case 3
                        Me.picZombie2.Left += -15
                    Case 5
                        Me.picZombie2.Left += 10
                        Me.picZombie2.Top += 5
                    Case 6
                        Me.picZombie2.Left += 5
                        Me.picZombie2.Top += 5
                End Select
            Case 5
                Select Case zombie2to
                    Case 1
                        Me.picZombie2.Left += -4
                        Me.picZombie2.Top += -15
                    Case 2
                        Me.picZombie2.Left += 10
                        Me.picZombie2.Top += -9
                    Case 3
                        Me.picZombie2.Left += -5
                        Me.picZombie2.Top += -5
                    Case 4
                        Me.picZombie2.Left += 15
                        Me.picZombie2.Top += -5
                    Case 6
                        zombie2to += 1
                End Select
            Case 6
                Select Case zombie2to
                    Case 1
                        Me.picZombie2.Left += 4
                        Me.picZombie2.Top += -8
                    Case 2
                        Me.picZombie2.Left += -10
                        Me.picZombie2.Top += -7
                    Case 3
                        Me.picZombie2.Left += 5
                        Me.picZombie2.Top += -5
                    Case 4
                        Me.picZombie2.Left += -15
                        Me.picZombie2.Top += -4
                    Case 5
                        zombie2to += 1
                End Select
        End Select
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to return to the main screen?", "Return to the main screen?", MessageBoxButtons.YesNo)       'ask if user wants to return
        If result = DialogResult.Yes Then
            My.Computer.Audio.Play(My.Resources.Shanghai_Teahouse, AudioPlayMode.Background)
            Me.Close()      'return
            MainScreen.Show()
        End If
    End Sub
End Class