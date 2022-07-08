Public Class Form41

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form21.Show()
        Form21.Panel1.Visible = True
        Form21.Panel2.Visible = False
        Form21.ggg.Visible = False
        Form21.Panel3.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form21.Show()
        Form21.Panel1.Visible = False
        Form21.Panel2.Visible = True
        Form21.ggg.Visible = False
        Form21.Panel3.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form21.Show()
        Form21.Panel1.Visible = False
        Form21.Panel2.Visible = False
        Form21.ggg.Visible = True
        Form21.Panel3.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form21.Show()
        Form21.Panel1.Visible = False
        Form21.Panel2.Visible = False
        Form21.ggg.Visible = False
        Form21.Panel3.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Start Update" Then
            Button2.Text = "Stop Update"
            Timer1.Start()
        Else
            Button2.Text = "Start Update"
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Label1.Visible = True
        End If
    End Sub

    Private Sub Form41_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Console.WriteLine()
        'System.Console
    End Sub
End Class