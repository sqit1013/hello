Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim quan As Integer
        Dim rm As Double

        'quan = Val(TextBox1.Text)
        'quan = Val(ComboBox1.Text)
        quan = Val(ListBox1.Text)
        rm = quan * 1.53

        TextBox2.Text = rm
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
        'OR
        'TextBox1.Clear()
        'TextBox2.Clear()

    End Sub

    
   
    
   
End Class
