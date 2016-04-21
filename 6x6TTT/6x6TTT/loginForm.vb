Public Class loginMenuForm

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
        mainMenuForm.Show()
    End Sub

    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        Me.Close()
        setupMenuForm.Show()
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class