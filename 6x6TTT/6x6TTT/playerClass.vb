
Public Class playerClass
    Public name As String = ""
    'Private guest As String = "guest"
    Public turnNumber As Integer = 0

    'Constructor 
    Public Sub New()
        name = ""
        'guest = "guest"
        turnNumber = 0
    End Sub

    'Register
    'Lets player register a new username
    'Procedure:
    '   Open file 
    '   Asks for username 
    '   Checks to see if username is taken
    '   Adds valid username
    'Returns:
    '   Display success
    Public Sub Register(ByVal username As String)
        Dim usernameFile As New System.IO.StreamReader("nameofuser.txt")
        Dim numberofUsers = 0, yesFlag, noFlag As Integer
        yesFlag = 0
        noFlag = 0
        Dim StrdUsername As String = ""
        Dim NewUsername As String = ""
        Dim users(20) As String
        'BEGINHERE:

        '        If (NewUsername = "") Then
        '            MsgBox("Username cannot be blank")
        '            GoTo BEGINHERE
        '        End If
        NewUsername = username.ToUpper()
        Do Until usernameFile.Peek = -1
            StrdUsername = usernameFile.ReadLine()
            StrdUsername = StrdUsername.ToUpper()
            If StrdUsername = NewUsername Then
                yesFlag += 1
            Else
                noFlag = 0
            End If
            numberofUsers += 1
        Loop
        usernameFile.Close()
        If (yesFlag > 0) Then
            MsgBox("Username exist. Please enter a different name")
        Else
            Dim file As New System.IO.StreamWriter("nameofuser.txt", True)
            file.WriteLine(NewUsername)
            file.Close()
            loginMenuForm.Close()
            mainMenuForm.Show()
            MsgBox(" REGISTRATION WAS SUCESSFUL!" & ControlChars.CrLf & " THANK YOU FOR REGISTERING." & ControlChars.CrLf & " ENJOY THE GAME!")
        End If
    End Sub
    'Log in
    'Lets player login with username
    'Procedure:
    '   Open file 
    '   Asks for username or guest
    '   If guest adds guest to game board player name
    '   Checks if username is valid
    '   Adds valid username to game board player name 
    'Returns:
    '   True if username is found
    Public Function Login(ByVal username As String)
        Try
            Dim usernameFile = IO.File.ReadAllText("nameofuser.txt")
            Dim lookFor As String = username.ToUpper()
            If usernameFile.Contains(lookFor) Then
                name = username
                loginMenuForm.errorLabel.Text = "Username found."
                Return True
            Else
                loginMenuForm.errorLabel.Text = "Username not found. Please register or play as guest."
                Return False
            End If
        Catch
            loginMenuForm.errorLabel.Text = "File not found."
            Return False
        End Try

        'Dim i = 0, yesFlag, noFlag As Integer
        'yesFlag = 0
        'noFlag = 0
        'Dim StrdUsername As String = ""
        'Dim NewUsername As String = ""
        'Dim users(20) As String
        'BEGINHERE:

        '           GoTo BEGINHERE

        'Do Until usernameFile.Peek = -1
        '    StrdUsername = usernameFile.ReadLine()
        '    StrdUsername = StrdUsername.ToUpper
        '    If StrdUsername = NewUsername Then
        '        yesFlag = yesFlag + 1
        '    Else
        '        noFlag = 0
        '    End If
        '    i = i + 1
        'Loop
        'usernameFile.Close()
        'If (yesFlag > 0) Then
        '    MsgBox("Please Enter another username different than before")
        'Else
        '    'usernameFile.Close()
        '    'Dim file As New StreamWriter("nameofuser.txt", True)
        '    'file.WriteLine(NewUsername)
        '    'file.Close()
        '    'MsgBox(" REGISTRATION WAS SUCESSFUL" & ControlChars.CrLf & " THANK YOU FOR THE REGIusernameFileATION WITH VADER TIC-TAC-TOE" & ControlChars.CrLf & " ENJOY THE GAME")
        'End If
    End Function

    'SetVader
    'Sets the second player as Vader
    'Procedure:
    '   Sets the game board player 2 name to Vader 
    'Returns:
    '   Display success
    Public Sub setVader()
        name = "Vader"
    End Sub

    Private Sub searchFile()
        '    Try
        '        Dim usernameFile = IO.File.ReadAllText("username.txt")
        '        'Dim lookfor As String = username
        '        ' If usernameFile.Contains(lookfor) Then
        '        loginMenuForm.errorLabel.Text = "Username found"
        '        loginMenuForm.errorLabel.Visible = False

        '        Else
        '        loginMenuForm.errorLabel.Text = "Username not found"
        '        loginMenuForm.errorLabel.Visible = True
        '        End If
        '        'Using usernameFile As New System.IO.StreamWriter("username.txt")
        '        '    usernameFile.WriteLine(username)
        '        'End Using
        '    Catch
        '        errorLabel.Text = "Error with file"

        '    End Try

    End Sub
End Class
