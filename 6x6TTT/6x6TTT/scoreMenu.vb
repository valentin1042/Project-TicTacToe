Public Class scoreMenuForm
    Private playerName As playerClass = New playerClass()
    Private wins As Integer = 0
    Private loss As Integer = 0
    Private tie As Integer = 0
    Private opponent As String



    'Holds the button to view
    Private Sub Btn_View_Click(sender As Object, e As EventArgs) Handles Btn_View.Click
        Const intMax As Integer = 10       'Holds the top number
        Dim mauro As System.IO.StreamReader
        ' Dim strFilename As String ' File name
        Dim strUser As String     ' Name of a 
        Dim strWin As String      ' To hold a phone number
        Dim strTie As String ' Holds the Tie
        Dim strLoss As String ' Holds the loss
        Dim intCount As Integer     ' Loop counter
        ' Open the file.
        mauro = My.Computer.FileSystem.OpenTextFileReader("Vader.txt")
        Try
            ' Read the data.
            For intCount = 0 To 0
                ' Read a name and win number from the file.
                strUser = mauro.ReadLine()
                strWin = mauro.ReadLine()
                strTie = mauro.ReadLine()
                strLoss = mauro.ReadLine()
                ' Display the data in the list box.
                List_Score.Items.Add("Name: " & strUser)
                List_Score.Items.Add("Wins: " & strWin)
                List_Score.Items.Add("Lost: " & strLoss)
                List_Score.Items.Add("Tie : " & strTie)
                List_Score.Items.Add("") ' Add a blank line
            Next

            ' Close the file.
            mauro.Close()
        Catch
            MessageBox.Show("That file cannot be opened.")
        End Try
    End Sub



    'Holds the Clear button
    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        List_Score.Items.Clear()
    End Sub
    'Button to go back or menu
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
        mainMenuForm.Show()
    End Sub

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class