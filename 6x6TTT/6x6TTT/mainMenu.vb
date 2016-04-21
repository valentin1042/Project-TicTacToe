Public Class mainMenuForm
    'Remove after adding gameboard form
    Public Board As boardClass = New boardClass()
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    'vsPlayerButton
    'Log in for each player
    'Procedure: 
    '   Displays log in menu for first player
    '   Displays log in menu for second player 
    'Returns:
    '   Username for player 1 
    '   Username for player 2
    Private Sub vsPlayerBtn_Click(sender As Object, e As EventArgs) Handles vsPlayerBtn.Click
        Me.Hide()
        loginMenuForm.Show()
        'setupMenu.Show()
    End Sub

    'vsVaderButton
    'Log in only for player
    'Procedure:
    '   Displays log in for player
    'Returns:
    '   Username for player
    Private Sub vsVaderBtn_Click(sender As Object, e As EventArgs) Handles vsVaderBtn.Click
        Me.Hide()
        loginMenuForm.Show()
    End Sub

    'Register Button
    'Registration for one player 
    'Procedure:
    '   Displays registration for one player
    '   Makes new username in file
    'Returns: 
    '   Registration complete
    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Me.Hide()
        scoreMenuForm.Show()
    End Sub

    'History Button
    'Displays history for register player
    'Procedure:
    '   Player log in
    '   Gather history for player
    '   Displays history 
    'Returns:
    '   Form displaying history
    Private Sub historyBtn_Click(sender As Object, e As EventArgs) Handles historyBtn.Click

    End Sub

End Class
