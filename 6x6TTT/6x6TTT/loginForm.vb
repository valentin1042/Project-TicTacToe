Public Class loginMenuForm
    Private count As Integer = 0
    Public username, username1 As String
    Private guest As Boolean = False
    Private nameError As Boolean = True
    Private type As String
    Private loginSucess As Boolean = False
    'back button
    'Allows player to return to the main menu
    'Procedure:
    '   Closes the login menu
    '   Shows main menu
    'Return:
    '   None
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
        mainMenuForm.Show()
    End Sub
    'enter button
    'Checks if player entered username or checked play as guest
    'Procedure:
    '   If checked guest then set name as guest 
    '   If entered username 
    '   Open text file
    '   Searches text file for given username
    '   If invalid username then ask another username
    'Return:
    '   Message indicating if valid username
    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        If Not nameError Then
            username = usernameTextBox.Text
            If count = 3 Then
                GameBoard1.Board.player1.Register(username)
            ElseIf count = 2 Then
                loginSucess = GameBoard1.Board.player1.Login(username)
                If loginSucess Then
                    username1 = username
                    usernameTextBox.Clear()
                    count -= 1
                End If
            ElseIf count = 1 Then
                If username = username1 Then
                    errorLabel.Text = "Enter different username."
                Else
                    loginSucess = GameBoard1.Board.player2.Login(username)
                    If loginSucess Then
                        MsgBox("Now choose your settings.")
                        Me.Close()
                        setupMenuForm.Show()
                    End If
                End If
            End If
        Else
            errorLabel.Text = "Invalid username."
        End If
    End Sub

    'usernameTextBox
    'Allows player to enter username
    'Procedure:
    '   Player enters username
    '   If valid sets the username to name of player 
    '   and sets nameError to False
    'Returns: 
    '   Message indicating if username is invalid
    Private Sub usernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles usernameTextBox.TextChanged

        Try
            username = usernameTextBox.Text.ToUpper()
            If username.Contains("VADER") Or username.Length = 0 Or username.Contains(" ") Then
                nameError = True
            Else
                errorLabel.Text = ""
                nameError = False
            End If
        Catch
            errorLabel.Text = "Error"
            nameError = True
        End Try
    End Sub

    'setCount
    'set maximum number of time login menu will be called 
    'Arguments:
    '   cnt as integer 
    Public Sub setCount(ByVal cnt As Integer)
        count = cnt
    End Sub

    'guest radio button
    'Allows player to play as guest
    'Procedure:
    '   if checked then set boolen variable to true
    'Returns:
    '   None
    Private Sub guestRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles guestRadioButton.CheckedChanged
        guest = True
    End Sub

    Private Sub usernameTextBox_GotFocus(sender As Object, e As EventArgs) Handles usernameTextBox.GotFocus
        guestRadioButton.Checked = False
    End Sub
    'Things left to do 
    '1. Make function to look for username in file 
    '2. Error handling vader and guest as username
    '3. Testing 

End Class