Public Class Form45

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        If Button2.Visible = False Then
            Button2.Visible = True
            Button2.Text = OpenFileDialog1.FileName
        Else
            If Button3.Visible = False Then
                Button3.Visible = True
                Button3.Text = OpenFileDialog1.FileName
            Else
                If Button4.Visible = False Then
                    Button4.Visible = True
                    Button4.Text = OpenFileDialog1.FileName
                Else
                    If Button5.Visible = False Then
                        Button5.Visible = True
                        Button5.Text = OpenFileDialog1.FileName
                    Else

                    End If
                End If
            End If
        End If
        'Button2.Text = 
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start(Button2.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start(Button3.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Process.Start(Button4.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Process.Start(Button5.Text)
    End Sub
End Class