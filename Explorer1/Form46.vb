Public Class Form46

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click, PictureBox1.Click, Label1.Click
        Form31.Close()
        Form31.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Explorer3.Show()
        LoadTree()
    End Sub
    Private Sub LoadTree()
        Form15.Show()
    End Sub
End Class