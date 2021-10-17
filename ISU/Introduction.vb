'this is the introduction
'


Public Class Introduction
    'dim the variables used
    Dim mossimage As Integer = 1        'the variable used to animate the main character
    Dim events As Integer = 0           'the variable used in the select case statement that runs all the different animations and events in the cutscene
    Dim counter As Integer = 0          'a counter used to make the text move when it shows itself
    Dim phrase As String = "Where am I... "     'this is the text that is shown, it changes throughout the form
    Dim proceed As Integer = 0          'the variable used to make the text/events move to the next step in the case statement
    Dim move As Boolean = False         'a boolean that if true, will allow the user to move the character, otherwise you can't
    Dim first As Boolean = True     'make it so that you can only press the button/Moss once to make it disappear
    Private Sub MainScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'dim the variable used to move the character
        Dim Loc As Point

        If move = True Then
            Select Case e.KeyCode
                'move left
                Case Keys.A
                    Me.picMoss.Image = My.Resources.Moss1_Reversed      'change the picture so that the character is facing the right direction
                    tmrMossRight.Stop()         'use the correct timer, depending on the direction
                    tmrMossLeft.Start()
                    If Not picMoss.Location.X - 10 < 0 Then
                        Loc = New Point(picMoss.Location.X - 20, picMoss.Location.Y)        'find the new location
                        picMoss.Location = Loc
                    End If
                'move right
                Case Keys.D
                    Me.picMoss.Image = My.Resources.Moss1       'change the picture so that the character is facing the right direction
                    tmrMossLeft.Stop()      'use the correct timer, depending on the direction
                    tmrMossRight.Start()
                    If Not picMoss.Location.X + 10 > Me.Width - picMoss.Width - 10 Then
                        Loc = New Point(picMoss.Location.X + 20, picMoss.Location.Y)        'find the new location
                        picMoss.Location = Loc
                    End If
                'move up
                Case Keys.W
                    If Not picMoss.Location.Y - 10 < 0 Then
                        Loc = New Point(picMoss.Location.X, picMoss.Location.Y - 20)        'find the new location
                        picMoss.Location = Loc
                    End If
                'move down
                Case Keys.S
                    If Not picMoss.Location.Y - 10 > Me.Height - picMoss.Height + 1.1 Then
                        Loc = New Point(picMoss.Location.X, picMoss.Location.Y + 20)        'find the new location
                        picMoss.Location = Loc
                    End If
            End Select
        End If

        If Me.picMoss.Bounds.IntersectsWith(Me.picKnife.Bounds) Then
            Me.picKnife.Hide()          'the knife is with Moss now, so hide the original picture
            Me.picKnife.Location = New Point(1000, 1000)        'move it somewhere so that it won't interact with anything anymore
            Me.picMoss.SizeMode = PictureBoxSizeMode.StretchImage       'restretch the image so that it looks weirder
            Me.picMoss.Top += 20        'make it look more centered
            Me.picMoss.Size = New Point(55, 50)     'make the size more close to the original
            Me.picMoss.Image = My.Resources.Moss_with_Knife_Reversed            'change the picture so that he's holding a knife
            Me.lblText.Text = Nothing       'reset the text
            move = False        'stop the user from moving
            proceed = 2     'move the select case to the next event
            tmrText.Start()     'start the timer for text
        End If
    End Sub

    Private Sub picMoss_Click(sender As Object, e As EventArgs) Handles picMoss.Click
        If first = True Then
            tmrAnimations.Start()       'start the timer for the animations
            Me.picMoss.Hide()       'hide Moss for now...
            first = False
        End If
    End Sub

    Private Sub tmrEvent_Tick(sender As Object, e As EventArgs) Handles tmrAnimations.Tick
        events += 1     'every tick of the timer, the event variable moves up so that the select case can move on

        Select Case events
            Case 1
                Me.BackColor = Color.White      'change the background colour so that it looks like it's flashing
            Case 2
                Me.BackColor = Color.DimGray
            Case 4      'skip a case so that there's a brief pause
                Me.BackColor = Color.White
            Case 5
                Me.BackColor = Color.DimGray
            Case 17     'longer pause
                Me.BackColor = Color.White
            Case 18
                Me.BackColor = Color.DimGray
                Me.picMoss.Image = My.Resources.Moss1       'make Moss appear and with the right picture
                Me.picMoss.Show()
            Case 44
                Me.picMoss.Image = My.Resources.Moss1_Reversed      'change the picture so that it looks like he's turning around
            Case 60
                Me.picMoss.Image = My.Resources.Moss1       'change it back
            Case 74
                Me.lblText.Show()       'play the text and the protocols for text
                tmrText.Start()
        End Select
    End Sub

    Private Sub tmrText_Tick(sender As Object, e As EventArgs) Handles tmrText.Tick
        'every tick the timer will check what case the variable is on
        Select Case proceed
            Case 0
                counter += 1        'move the counter up every tick
                lblText.Text += Mid(phrase, counter, 1)     'counts the characters and displays them accordingly
                If counter >= phrase.Length Then        'move on when the string is finished
                    counter = 0     'reset the counter, as it's used throughout the code
                    System.Threading.Thread.Sleep(2000)         'stop the code for 2 seconds
                    lblText.Text = Nothing      'reset the text box
                    Me.picKnife.Show()      'show the knife 
                    proceed = 1     'next case
                End If
            Case 1
                Me.picMoss.Image = My.Resources.Moss1_Reversed
                phrase = "What's that? "        'change the text displayed
                counter += 1        'move the counter up every tick
                lblText.Text += Mid(phrase, counter, 1)      'counts the characters and displays them accordingly
                If counter >= phrase.Length Then     'move on when the string is finished
                    counter = 0      'reset the counter, as it's used throughout the code
                    System.Threading.Thread.Sleep(2000)       'stop the code for 2 seconds
                    Me.lblText.Text = "*Use WASD keys to move*"     'change the text box to only display that text until user finishes the task
                    move = True     'let them move
                    tmrText.Stop()      'stop this timer for now
                End If
            Case 2
                phrase = "Woah...that's cool... "       'change the text displayed
                counter += 1        'move the counter up every tick
                lblText.Text += Mid(phrase, counter, 1)     'counts the characters and displays them accordingly
                If counter >= phrase.Length Then     'move on when the string is finished
                    counter = 0     'reset the counter, as it's used throughout the code
                    System.Threading.Thread.Sleep(2000)       'stop the code for 2 seconds
                    lblText.Text = Nothing       'reset the text box
                    proceed = 3      'next case
                End If
            Case 3
                Me.BackColor = Color.White      'make the background white for emphasis
                Me.picMoss.Image = My.Resources.Moss1_Reversed      'change the picture for emphasis
                Me.tmrText.Interval = 20     'make the text display faster
                phrase = "What's happening?? "         'change the text displayed
                counter += 1          'move the counter up every tick
                lblText.Text += Mid(phrase, counter, 1)     'counts the characters and displays them accordingly
                If counter >= phrase.Length Then         'move on when the string is finished
                    counter = 0      'reset the counter, as it's used throughout the code
                    System.Threading.Thread.Sleep(5000)       'stop the code for 2 seconds
                    lblText.Text = Nothing        'reset the text box
                    proceed = 4      'next case
                End If
            Case 4
                Level_0.Show()      'show the next form
                Me.Close()       'hide this form
                proceed = 5     'make sure this timer doesn't run in the background
            Case 5

        End Select
    End Sub

    Private Sub Intro_Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblText.Hide()       'hide the text when you load in
        Me.picKnife.Hide()      'hide the knife when you load in
    End Sub
End Class