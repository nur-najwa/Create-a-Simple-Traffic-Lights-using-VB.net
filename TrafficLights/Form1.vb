Public Class Form1

    Dim counter As Integer
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        counter = 0
        Timer1.Start()
        Timer1.Interval = 2000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case counter
            Case 0
                If Timer1.Interval = 2000 Then
                    TextBox1.BackColor = Color.White
                    TextBox2.BackColor = Color.White
                    TextBox3.BackColor = Color.FromArgb(0, 255, 0)
                    counter = 1
                Else
                    Timer1.Interval = Timer1.Interval + 200
                End If
            Case 1
                If Timer1.Interval = 3000 Then
                    TextBox3.BackColor = Color.White
                    TextBox2.BackColor = Color.White
                    TextBox1.BackColor = Color.FromArgb(255, 0, 0)
                    counter = 2
                Else
                    Timer1.Interval = Timer1.Interval + 200
                End If
            Case 2
                If Timer1.Interval = 4000 Then
                    TextBox3.BackColor = Color.White
                    TextBox1.BackColor = Color.White
                    TextBox2.BackColor = Color.Yellow
                    counter = 0
                Else
                    Timer1.Interval = Timer1.Interval + 200
                End If
        End Select
        Me.Text = Now()
    End Sub
End Class
