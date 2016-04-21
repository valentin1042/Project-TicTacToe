<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginMenuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.guestLabel = New System.Windows.Forms.Label()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(39, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 22)
        Me.TextBox1.TabIndex = 0
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(39, 133)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 21)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Guest "
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Location = New System.Drawing.Point(36, 43)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(109, 17)
        Me.usernameLabel.TabIndex = 2
        Me.usernameLabel.Text = "Enter username"
        '
        'guestLabel
        '
        Me.guestLabel.AutoSize = True
        Me.guestLabel.Location = New System.Drawing.Point(36, 113)
        Me.guestLabel.Name = "guestLabel"
        Me.guestLabel.Size = New System.Drawing.Size(93, 17)
        Me.guestLabel.TabIndex = 3
        Me.guestLabel.Text = "Play as guest"
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(230, 133)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(75, 32)
        Me.enterButton.TabIndex = 4
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.backButton.Location = New System.Drawing.Point(230, 30)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(75, 30)
        Me.backButton.TabIndex = 5
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'loginMenuForm
        '
        Me.AcceptButton = Me.enterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.backButton
        Me.ClientSize = New System.Drawing.Size(374, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.guestLabel)
        Me.Controls.Add(Me.usernameLabel)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "loginMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents usernameLabel As System.Windows.Forms.Label
    Friend WithEvents guestLabel As System.Windows.Forms.Label
    Friend WithEvents enterButton As System.Windows.Forms.Button
    Friend WithEvents backButton As System.Windows.Forms.Button
End Class
