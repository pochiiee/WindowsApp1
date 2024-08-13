Public Class Example

    Private Sub clickMe_Click(sender As Object, e As EventArgs) Handles clickMe.Click
        Dim enteredName As String = TextBox1.Text
        MsgBox("Welcome, " & enteredName & "!")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
