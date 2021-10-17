Public Class Level_0
    Dim fall As Integer = 0         'the variable used to move the events in the case statement
    Dim falling As Boolean = True       'the variable used to make Moss "fall" at the start
    Dim phrase As String = "What just happened? Where am I...again? "       'this is the text that is shown, it changes throughout the form
    Dim counter As Integer = 0     'a counter used to make the text move when it shows itself
    Dim proceed As Integer = 0      'the variable used to make the text/events move to the next step in the case statement

    Private Sub Level_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrFall.Start()
        Me.picKnife.Hide()
        tmrBounds.Start()
        Me.lblText.Hide()
        Me.picZombie1.Hide()
        Me.picZombie2.Hide()
    End Sub

    Private Sub tmrFall_Tick(sender As Object, e As EventArgs) Handles tmrFall.Tick
        fall += 1
        If falling = True Then
            Me.picMoss.Location = New Point(510, 0 + fall * 10)
            If Me.picMoss.Location.Y > 320 Then
                falling = False
            End If
        Else
            Select Case fall
                Case 150
                    Me.picMoss.Image = My.Resources.Moss1_New_Reversed
                Case 200
                    Me.picMoss.Image = My.Resources.Moss1_New
                Case 250
                    tmrText.Start()
                    tmrFall.Stop()
            End Select
        End If
    End Sub

    Private Sub tmrBounds_Tick(sender As Object, e As EventArgs) Handles tmrBounds.Tick
        If Me.picMoss.Bounds.IntersectsWith(Me.picZombie1.Bounds) Then
            Dim num As Integer = 0
            Me.picZombie1.Hide()
            proceed = 3
            For num = 0 To 10
                Me.picMoss.Top += 10
                System.Threading.Thread.Sleep(10)
                Me.picMoss.Top += -10
                System.Threading.Thread.Sleep(10)
            Next num

            tmrText.Start()
            tmrZombie1.Stop()
            tmrBounds.Stop()
        End If
    End Sub

    Private Sub tmrText_Tick(sender As Object, e As EventArgs) Handles tmrText.Tick
        Select Case proceed
            Case 0
                Me.lblText.Show()
                counter += 1
                lblText.Text += Mid(phrase, counter, 1)
                If counter >= phrase.Length Then
                    counter = 0
                    System.Threading.Thread.Sleep(2000)
                    Me.lblText.Text = Nothing
                    proceed = 1
                ElseIf counter = 34 Then
                    System.Threading.Thread.Sleep(2000)
                End If
            Case 1
                phrase = "What is this place, some gaming interface? "
                counter += 1
                Me.lblText.Text += Mid(phrase, counter, 1)
                If counter >= phrase.Length Then
                    counter = 0
                    System.Threading.Thread.Sleep(2000)
                    Me.lblText.Text = Nothing
                    proceed = 2
                End If
            Case 2
                Me.picZombie1.Show()
                Me.picMoss.Image = My.Resources.Moss1_New_Reversed
                phrase = "What the heck is that? "
                counter += 1
                Me.lblText.Text += Mid(phrase, counter, 1)
                If counter >= phrase.Length Then
                    counter = 0
                    System.Threading.Thread.Sleep(2000)
                    Me.lblText.Text = Nothing
                    tmrZombie1.Start()
                    tmrText.Stop()
                End If
            Case 3
                Me.picHeart3.Image = My.Resources.Heart_New_Empty
                phrase = "Ow, that hurt...I should stay away from those... "
                counter += 1
                Me.lblText.Text += Mid(phrase, counter, 1)
                If counter >= phrase.Length Then
                    counter = 0
                    System.Threading.Thread.Sleep(2000)
                    Me.lblText.Text = Nothing
                    proceed = 4
                End If
            Case 4
                Me.picZombie2.Show()
                Me.picMoss.Image = My.Resources.Moss_with_Knife
                phrase = "Oh no there's more! I guess it's time to use this knife..."
                counter += 1
                Me.lblText.Text += Mid(phrase, counter, 1)
                If counter >= phrase.Length Then
                    counter = 0
                    System.Threading.Thread.Sleep(2000)
                    Level_1.Show()
                    Me.Close()
                    tmrText.Stop()
                End If
        End Select
    End Sub

    Private Sub tmrZombie1_Tick(sender As Object, e As EventArgs) Handles tmrZombie1.Tick
        Me.picZombie1.Left += 11
        Me.picZombie1.Top += 10
    End Sub
End Class