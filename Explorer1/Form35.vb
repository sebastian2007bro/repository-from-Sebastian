Public Class Form35

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser1.Navigate(TextBox1.Text)
        If TextBox1.Text = "CMD" Then
            'Form17.Show()
            WebBrowser1.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        WebBrowser2.GoBack()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        WebBrowser2.GoForward()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WebBrowser2.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        WebBrowser2.Navigate(TextBox2.Text)
        If TextBox2.Text = "CMD" Then
            'Form17.Show()
            WebBrowser2.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
        End If

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        WebBrowser3.GoBack()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        WebBrowser3.GoForward()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        WebBrowser3.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        WebBrowser3.Navigate(TextBox3.Text)
        If TextBox3.Text = "CMD" Then
            'Form17.Show()
            WebBrowser3.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        WebBrowser4.GoBack()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        WebBrowser4.GoForward()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        WebBrowser4.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        WebBrowser4.Navigate(TextBox4.Text)
        If TextBox4.Text = "CMD" Then
            'Form17.Show()
            WebBrowser4.Navigate("https://sebs-sw-b.netlify.app/news-sebs-sw.html")
        End If
    End Sub

    Private Sub Form35_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Me.Close()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub
End Class