﻿Public Class setupMenuForm

    Dim colorCount As Integer = 2                'Holds the number of colors that can be choosen
    Dim cStone(2) As String

    'Setup Menu loader
    'Loads the player names to the radio buttons 
    'Procedure: 
    '   sets the player 1 radio button to first player 
    '   sets the player 2 radio button to second player 
    'Returns:
    '   None
    Private Sub setupMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        player1RadioButton.Text = GameBoard1.Board.player1.name
        player2RadioButton.Text = GameBoard1.Board.player2.name

    End Sub

    'Enter button
    'Sets the settings for the game 
    'Procedure:
    '   Ask to choose who plays first
    '   Ask first player or single player to choose color
    '   Ask second player or set VADER to VADER color
    'Return:
    '   Display gameboard with proper settings
    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click

        If chooseFirstplayerGroupBox.Visible Then

            'Checks which radio button is selected 
            If player1RadioButton.Checked Then
                'Sets the name of the players in the gameboard
                GameBoard1.Board.setPlayer(player1RadioButton.Text, player2RadioButton.Text)                                 'setPlayer(player1.name, player2.name)

                'This if statement changes chooseColorGroupbox.text to show the name of the player
                'Ex: "Player.name choose your color"
                If GameBoard1.Board.player1.name = "Vader" Then
                    chooseColorGroupBox.Text = GameBoard1.Board.player2.name + " choose your color."
                Else
                    chooseColorGroupBox.Text = GameBoard1.Board.player1.name + " choose your color."
                End If

            ElseIf player2RadioButton.Checked Then

                'Sets the name of the players in the gameboard
                GameBoard1.Board.setPlayer(player2RadioButton.Text, player1RadioButton.Text)                                 'setPlayer(player1.name, player2.name)

                'This if statement changes chooseColorGroupbox.text to show the name of the player depending on which player is Vader 
                'Ex: "Player.name choose your color"
                If GameBoard1.Board.player2.name = "Vader" Then
                    chooseColorGroupBox.Text = GameBoard1.Board.player1.name + " choose your color."
                Else
                    chooseColorGroupBox.Text = GameBoard1.Board.player2.name + " choose your color."
                End If

            End If

            'If Vader is in any radio button then display the difficulty groupbox 
            If player2RadioButton.Text = "Vader" Or player1RadioButton.Text = "Vader" Then

                chooseFirstplayerGroupBox.Visible = False
                chooseDifficultyGroupBox.Visible = True

            Else

                chooseColorGroupBox.Visible = True
                chooseFirstplayerGroupBox.Visible = False

            End If
        End If

        If chooseDifficultyGroupBox.Visible Then
            'If the difficulty groupbox is displayed then check which radio button is selected
            'then display the chooseColorGroupbox
            If easyRadioButton.Checked Then
                GameBoard1.Board.setDifficulty(0)
            ElseIf medRadioButton.Checked Then
                GameBoard1.Board.setDifficulty(1)
            ElseIf hardRadioButton.Checked Then
                GameBoard1.Board.setDifficulty(2)
            End If

            colorCount -= 1                      'Decrease the number of colors to be choosen by 1 since Vader doesn't choose a color

            chooseColorGroupBox.Visible = True
            chooseDifficultyGroupBox.Visible = False
        End If

        If chooseColorGroupBox.Visible Then
            'This if statement will count the number of colors choosen limiting it to 2
            If colorCount >= 1 Then

                'Checks which color radio button was selected
                'If selected the radio button will disappear
                If blueRadioButton.Checked Then

                    blueRadioButton.Visible = False

                    chooseColorGroupBox.Text = GameBoard1.Board.player2.name + " choose your color."         'Display "Player2.name choose your color"    
                    colorCount -= 1                  'Decrease the number of colors to be choosen by 1 



                ElseIf greenRadioButton.Checked Then

                    greenRadioButton.Visible = False

                    chooseColorGroupBox.Text = GameBoard1.Board.player2.name + " choose your color."         'Display "Player2.name choose your color"   

                    colorCount -= 1                  'Decrease the number of colors to be choosen by 1 



                ElseIf yellowRadioButton.Checked Then

                    yellowRadioButton.Visible = False

                    chooseColorGroupBox.Text = GameBoard1.Board.player2.name + " choose your color."         'Display "Player2.name choose your color"    

                    colorCount -= 1                  'Decrease the number of colors to be choosen by 1 

       

                ElseIf redRadioButton.Checked Then

                    redRadioButton.Visible = False

                    chooseColorGroupBox.Text = GameBoard1.Board.player2.name + " choose your color."         'Display "Player2.name choose your color"    'Replace GameBoard1 with gameboard form

                    colorCount -= 1                  'Decrease the number of colors to be choosen by 1 

 
                End If

            End If

            'When the last color is choosen close the form and show the board form
            If colorCount = 0 Then
                Me.Close()
                GameBoard1.Show()
                ''If player2RadioButton.Text = "Vader" Then

                '    GameBoard1.Board.setStone(cStone(1), "VaderBlack")        'Replace GameBoard1 with gameboard form
                'Else

                '    GameBoard1.Board.setStone(cStone(1), cStone(0))           'Replace GameBoard1 with gameboard form

                'End If

            End If
        End If
    End Sub

    'Back button
    'Allows the player to return to the main menu
    'Procedure:
    '   Closes the setup menu
    '   Shows the main menu
    'Returns 
    '   None
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click

        Me.Close()
        mainMenuForm.Show()

    End Sub

    'Things left to do 
    '1. Send the colors of the stone to the game board
    '2. Show the game board after settings are choosen
    '3. Testing
End Class