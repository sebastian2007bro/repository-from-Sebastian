Public Class Form20

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button3.Visible = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        If ProgressBar1.Value = 100 Then
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()
        ProgressBar1.Value = 0
        Button3.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Form2.Close()
        'Form3.Close()
        'Form4.Close()
        'Form5.Close()
        'Form6.Close()
        'Form7.Close()
        'Explorer1.Close()
        'Explorer2.Close()
        'Form9.Close()
        'Form10.Close()
        'Form11.Close()
        'Form12.Close()
        'Form13.Close()
        'Form14.Close()
        'Form15.Close()
        'Form16.Close()
        'Form17.Close()
        'Form18.Close()
        'Form19.Close()
        'Form1.Show()
        'Errorbox1.Close()
        'AboutBox1.Close()
        'AboutBox3.Close()
        'AboutBox5.Close()
        'AboutBox7.Close()
        'AboutBox8.Close()
        'Form1.Timer3.Start()
        'Form1.V.Text = "???"
        'Form1.Panel3.Visible = False
        'Form1.Panel1.Visible = False
        'MsgBox("Virus in Form1 Form3 Form5 in All Forms. : your on 3.0. update to 3.2 - 3.3", MsgBoxStyle.Critical)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form21.Show()
        Form21.Panel1.Visible = True
        Form21.Panel2.Visible = False
        Form21.ggg.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form21.Show()
        Form21.Panel1.Visible = False
        Form21.Panel2.Visible = True
        Form21.ggg.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form21.Show()
        Form21.Panel1.Visible = False
        Form21.Panel2.Visible = False
        Form21.ggg.Visible = True
    End Sub

    Private Sub Form20_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Form1.Button1.Visible = True Then
            Form1.PictureBox9.Visible = True
        Else

            Form1.PictureBox9.Visible = False
            Form1.PictureBox9.Visible = False
            Form1.PictureBox9.Visible = False
            Form1.PictureBox9.Visible = False
            Form1.PictureBox9.Visible = False
            Form1.PictureBox9.Visible = False
            Form1.PictureBox9.Visible = False
        End If
    End Sub

    Private Sub Form20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.PictureBox9.Visible = True
    End Sub

    Private Sub Form20_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.PictureBox9.Visible = False
    End Sub
End Class