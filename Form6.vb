Public Class Form6

   
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a, b As String

        a = TextBox1.Text
        b = TextBox2.Text

        If a = "admin" And b = "1234" Then
            Form5.Show()
        Else
            MsgBox("Please enter correct user id or password")
        End If

    End Sub
End Class