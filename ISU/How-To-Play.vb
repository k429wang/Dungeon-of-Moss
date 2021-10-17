'This is the instructions page
'shows the user the controls and the general idea of the game


Public Class How_to_play
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'change the text in the label to the next section of instructions
        Me.lblInstructions.Text = "Kill enemies for points

Try to get as many points as you can!

Get 5000 points to win!

Good Luck..."

        Me.btnNext.Hide()       'hide this button so that the button behind it can be clicked
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()               'hide the current form
        MainScreen.Show()       'go back to the main screen
    End Sub
End Class