Public Class Form21

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form20.Show()
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel1.Visible = True
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'AboutBox12.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'AboutBox11.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'Form2.Button2.Enabled = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
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
        'Form20.Close()
        'Errorbox1.Close()
        'AboutBox1.Close()
        'AboutBox3.Close()
        'AboutBox5.Close()
        'AboutBox7.Close()
        'AboutBox8.Close()
        'Form1.Show()
        'Form1.Panel2.Visible = True
        'Form1.PictureBox1.Visible = False
        'Form1.PictureBox2.Visible = False
        'Form1.PictureBox3.Visible = False
        'Form1.PictureBox4.Visible = False
        'Form1.PictureBox5.Visible = False
        'Form1.PictureBox6.Visible = False
        'Form1.PictureBox7.Visible = False
        'Form1.PictureBox8.Visible = False
        'Form1.PictureBox9.Visible = False
        'Form1.Button1.Visible = False
        'Form1.Button2.Visible = False
        'Form1.Button3.Visible = False
        'Form1.Button4.Visible = False
        'Form1.Button7.Visible = False
        'Form1.Button10.Visible = False
        'Form1.Panel2.Visible = True
        'Form1.Label1.Visible = False
        'Form1.Label2.Visible = False
        'Form1.Text = "Stopped Desktroy Error"
        'Me.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Panel2.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form7.Show()
        'Panel1.Visible = False
        'Panel2.Visible = True
        'ggg.Visible = False
        'Panel3.Visible = False
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Form10.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel2.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Form26.Show()
        Form12.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Form22.Show()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        'Form1.Button15.Visible = True
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = True
        Panel3.Visible = False
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
        Button21.Enabled = False
        Label15.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Button21.Enabled = True
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click

        'Form27.Close()

        Button21.Enabled = False
        
        If TextBox2.Text = "Silan" Then
            'AboutBox18.Show()
        End If
        If TextBox2.Text = "silan" Then
            'AboutBox18.Show()
        End If
        If TextBox2.Text = "Display" Then
            'Form6.Show()
        End If
        If TextBox2.Text = "display" Then
            'Form6.Show()
        End If
        If TextBox2.Text = "Programs" Then
            'Form7.Show()
        End If
        If TextBox2.Text = "programs" Then
            'Form7.Show()
        End If
        If TextBox2.Text = "User" Then
            'Form10.Show()
        End If
        If TextBox2.Text = "user" Then
            'Form10.Show()
        End If
        If TextBox2.Text = "Desktroy" Then
            'Form12.Show()
        End If
        If TextBox2.Text = "desktroy" Then
            'Form12.Show()
        End If
        Me.Label12.Text = TextBox2.Text
        'Form2.Label1.Text = TextBox2.Text
        'Form27.Show()
        If TextBox2.Text = "???" Then
            'Form27.Close()
        End If
        If TextBox2.Text = "???" Then
            'Errorbox1.Show()
            'Errorbox1.al.Text = "Can't Display User Name!"
            'Form2.Label1.Text = "SCSW"
            'Me.Label12.Text = "SCSW"
        End If
        'If Form27.Label1.Text = "Display" Then
        'Form27.Label1.Text = "???"
        'Form2.Label1.Text = Form27.Label1.Text
        'Me.Label12.Text = Form27.Label1.Text
        'End If
        'If Form27.Label1.Text = "display" Then
        'Form27.Label1.Text = "???"
        'Me.Label12.Text = Form27.Label1.Text
        'End If
        'If Form27.Label1.Text = "User" Then
        'Form27.Label1.Text = "???"
        'Form2.Label1.Text = Form27.Label1.Text
        'Me.Label12.Text = Form27.Label1.Text
        'End If
        'If Form27.Label1.Text = "user" Then
        'Form27.Label1.Text = "???"
        'Form2.Label1.Text = Form27.Label1.Text
        'Me.Label12.Text = Form27.Label1.Text
        'End If
        'If Form27.Label1.Text = "Programs" Then
        'Form27.Label1.Text = "???"
        'Form2.Label1.Text = Form27.Label1.Text
        'Me.Label12.Text = Form27.Label1.Text
        'End If
        'If Form27.Label1.Text = "programs" Then
        'Form27.Label1.Text = "???"
        'Form2.Label1.Text = Form27.Label1.Text
        'Me.Label12.Text = Form27.Label1.Text
        'End If
        'If Form27.Label1.Text = "Desktroy" Then
        'Form27.Label1.Text = "???"
        'Form2.Label1.Text = Form27.Label1.Text
        'Me.Label12.Text = Form27.Label1.Text
        'End If
        'If Form27.Label1.Text = "desktroy" Then
        'Form27.Label1.Text = "???"
        'Form2.Label1.Text = Form27.Label1.Text
        'Me.Label12.Text = Form27.Label1.Text
        'End If

    End Sub

    Private Sub Button12_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Form27.Label1.Visible = False Then
        'Me.Label1.Text = "SCSW"
        'End If

        'If Form27.Label1.Visible = True Then
        'Label1.Text = TextBox2.Text
        'Else
        'Me.Label1.Text = "SCSW"
        'End If
        'If Form27.Button1.Text = ":) :(" Then
        'Label12.Text = Form27.Label1.Text
        'End If

    End Sub

    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click

        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Button14_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Panel1.Visible = False
        Panel2.Visible = False
        ggg.Visible = False
        Panel3.Visible = False
        'Form34.Show()
    End Sub

    Private Sub Button19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Form1.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button20_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Form1.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.DoubleClick
        Panel4.Visible = False
        MsgBox("Old Settings is open restart settings for new settings tab")
    End Sub
End Class