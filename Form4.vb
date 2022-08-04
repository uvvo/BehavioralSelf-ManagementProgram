Public Class Form4
    Dim currenttime As String
    Dim msgtime As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currenttime = TimeOfDay.ToString("hh:mm:ss tt")
        Label4.Text = currenttime
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        msgtime = MaskedTextBox1.Text + " " + ComboBox1.Text
        Label3.Text = "Reminder set for: " + msgtime
        If currenttime = msgtime Then
            Timer2.Stop()
            MsgBox(TextBox1.Text)
            Button1.Enabled = True
            Button2.Enabled = False
            Label3.Text = ""
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Start()
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Stop()
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class