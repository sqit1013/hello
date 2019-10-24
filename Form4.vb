Public Class Form4

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n As Integer

        n = Val(InputBox("Please enter an integer"))

        If n > 0 Then
            MsgBox(n & " is positive")
        ElseIf n < 0 Then
            MsgBox(n & " is negative")
        Else
            MsgBox(n & " is null")
        End If
    End Sub
End Class