Public Class Form1
    Dim X As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rnd As New Random
        For i = 5 To 20
            Dim pict As New PictureBox
            pict.BackColor = Color.Red
            pict.Height = 10
            pict.Width = 10
            pict.Location = New Point(rnd.Next(0, My.Computer.Screen.Bounds.Width),
                                      rnd.Next(0, My.Computer.Screen.Bounds.Height))
            Me.Controls.Add(pict)
        Next
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class
