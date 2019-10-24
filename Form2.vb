Public Class Form2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim usd As Double
        Dim rm As Double

        If RadioButton1.Checked = True Then
            'if user select to convert usd to rm
            usd = Val(TextBox1.Text)
            rm = usd * 3.8
            TextBox2.Text = Format(rm, "#.###")
        End If

        If RadioButton2.Checked = True Then
            'if user select to convert rm to usd
            rm = Val(TextBox2.Text)
            usd = rm / 3.8
            TextBox1.Text = Format(usd, "#.##")
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        'TextBox1.Focus()
        'OR
        'TextBox1.Clear()
        'TextBox2.Clear()

    End Sub



    
    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox1.Focus()
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged

        TextBox1.Enabled = False
        TextBox2.Enabled = True
        TextBox2.Focus()
    End Sub
End Class
