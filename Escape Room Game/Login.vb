Public Class Login
    Public username As String 'Create public variable to store the username the user enters. It is public so it can be used in different forms.

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged
        username = TextBoxName.Text 'When the user enters something into the text box it is stored in the variable username.
    End Sub

    Private Sub TextBoxUsername_Enter(sender As Object, e As EventArgs) Handles TextBoxName.Enter
        LabelName.Visible = False 'If the user clicks on the text box the label (LabelName) is no longer visible. This label has "Name" as the text and is on the text box in a darker shade of grey to tell the user to enter their name here. 
    End Sub
    Private Sub TextBoxName_Leave(sender As Object, e As EventArgs) Handles TextBoxName.Leave
        If TextBoxName.Text = "" Then LabelName.Visible = True 'If the user clicks off the text box and there is nothing entered into the text box (TextBoxName) the label (LabelName) is now visible. This let's the user know to enter ther name in that text box.
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        'Here are the local variables for the user to enter a name and make sure it is valid.
        Dim len As Integer
        Dim singleChar As Char
        Dim spaceCount As Integer = 0
        Dim comma As Boolean = False

        'If there is nothing the length is set to 0, if not the length is set to the length of the username and the for loop occurs.
        If username = "" Then
            len = 0
        Else
            len = username.Length 'Stores the number of characters in the username in the variable "len".
            'A for loop that is used to determine if there are any commas in the username and the number of spaces in the username.
            'The for loop goes from 0 to the number of characters in the username.
            For x = 0 To len
                singleChar = username.Substring(x) 'Stores each character of the username in the variable "singleChar". Each time x increases until "len" it changes the value of "singleChar" to the next character of the username.
                If singleChar = "," Then 'If any character of the username is a comma ","
                    comma = True 'Then the boolean "comma" becomes true.
                End If
                If singleChar = " " Then 'If the username character is a space the 
                    spaceCount = spaceCount + 1 'Variable "spaceCount" increases by one. It does this for all the characters to store the number of spaces in the username.
                End If
            Next
        End If

        'An if statement for the validity when the user enters their name.
        'If the name is invalid the text of the label (labelIncorrect) changes and tells the user what the problem is.
        'It also changes the back colour of the label to dark red, label text colour to silver and makes picture box PictureBoxBan visible which is a ban Icon. This is for design to imply the username is unacceptable.
        If username = "" Then 'If the username is empty so the user didn't enter anything the name is invalid.
            Labelincorrect.Text = "             Please enter a name                  "
            Labelincorrect.ForeColor = Color.DarkBlue
            Labelincorrect.BackColor = Color.DarkRed
            PictureBoxBan.Visible = True
        ElseIf len > 12 Then 'If the length of the username is more than 12 the name is invalid
            Labelincorrect.Text = "             Max of 12 characters                 "
            Labelincorrect.ForeColor = Color.DarkBlue
            Labelincorrect.BackColor = Color.DarkRed
            PictureBoxBan.Visible = True
        ElseIf comma = True Then 'If the boolean comma is true there is at least one comma in the name so it is invalid as it will ruin my program.
            Labelincorrect.Text = "                     No commas                        "
            Labelincorrect.ForeColor = Color.DarkBlue
            Labelincorrect.BackColor = Color.DarkRed
            PictureBoxBan.Visible = True
        ElseIf spaceCount = len Then 'If the number of spaces in the username is the same as the length of the username it is all spaces so it is invalid
            Labelincorrect.Text = "             Don't just enter spaces              "
            Labelincorrect.ForeColor = Color.DarkBlue
            Labelincorrect.BackColor = Color.DarkRed
            PictureBoxBan.Visible = True
            'If none of the rest is true the username is acceptable and it resets the form by clearing the text of the text box, clearing the text of the incorrect label and making the ban icon no longer visible.
            'It then opens the rules form and hides this form
        Else

            TextBoxName.Text = ""
            Labelincorrect.Text = ""
            PictureBoxBan.Visible = False
            Me.Hide()
        End If
    End Sub

    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click
        Settings.Show()
        TextBoxName.Text = ""
        Labelincorrect.Text = ""
        PictureBoxBan.Visible = False
        Me.H
        ide() 896+

    End Sub
End Class