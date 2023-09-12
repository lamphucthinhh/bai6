Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cc As Integer
        cc = Integer.Parse(txtcuuchuong.Text)
        Dim i As Integer
        For i = 1 To 10
            Dim kq As String
            kq = i & " x " & cc & " = " & i * cc
            ListBox1.Items.Add(kq)
        Next
    End Sub
End Class