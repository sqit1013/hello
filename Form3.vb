Public Class Form3

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Version: 1.0.1
        'Purpose: compute averagre marks
        'Created Date:
        'Last Modified Date
        'Author: 


        Dim m1 As Double  'm1 is for student mark 1
        Dim m2 As Double
        Dim m3 As Double
        Dim avg As Double

        m1 = Val(TextBox1.Text)
        m2 = Val(TextBox1.Text)
        m3 = Val(TextBox1.Text)

        avg = (m1 + m2 + m3) / 3

        Label4.Text = "The average is = " & avg
    End Sub
End Class