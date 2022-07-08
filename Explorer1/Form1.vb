Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "Desktop - Start programs1" Then
            yourversion.Text = My.Computer.Info.OSFullName
            yourversion.Text = My.Computer.Info.OSFullName
            yourversion.Text = My.Computer.Info.OSFullName
            yourversion.Text = My.Computer.Info.OSFullName
            yourversion.Text = My.Computer.Info.OSFullName
            yourversion.Text = My.Computer.Info.OSFullName
            yourversion.Text = My.Computer.Info.OSFullName
            yourversion.Text = My.Computer.Info.OSFullName
            If yourversion.Text = "Microsoft Windows 7 Professional " Then
                Panel7.Visible = True
                Panel1.Visible = False
            Else
                If yourversion.Text = "Microsoft Windows Vista Professional " Then
                    Panel7.Visible = True
                    Panel1.Visible = False
                End If
                If yourversion.Text = "Microsoft Windows 7 Ultimate " Then
                    Panel7.Visible = True
                    Panel1.Visible = False
                End If
                If yourversion.Text = "Microsoft Windows 7 Home Basic " Then
                    Panel7.Visible = True
                    Panel1.Visible = False
                End If
                If yourversion.Text = "Microsoft Windows 7 Enterprise " Then
                    Panel7.Visible = True
                    Panel1.Visible = False
                End If
            End If
            'Enterprise
        End If
        
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form35.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form31.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If Form21.WindowState = FormWindowState.Minimized Then
            Form21.WindowState = FormWindowState.Normal
        Else
            Form21.Close()
            Form21.Show()
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Panel2.Visible = True
        PictureBox6.Visible = True
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Panel2.Visible = False
        PictureBox6.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form33.Show()
        Form33.Timer1.Start()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click, PictureBox7.Click, Label1.Click
        Form21.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Form20.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click, PictureBox10.Click, Label2.Click
        Form31.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click, PictureBox12.Click, Label3.Click
        Form35.Show()
    End Sub

    Private Sub PictureBox6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.BackColor = Color.Gray
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.Gray
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackColor = Color.Gray
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.BackColor = Color.Gray
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.BackColor = Color.Gray
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox9_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseEnter
        PictureBox9.BackColor = Color.Gray
    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        PictureBox9.BackColor = Color.Transparent
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Public Sub shutdown()
        Form7.Close()
        Form12.Close()
        Form15.Close()
        Form20.Close()
        Form21.Close()
        Form22.Close()
        Form31.Close()
        Form35.Close()
        Form41.Close()
        Form45.Close()
        Form46.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click, PictureBox1.Click, Label4.Click
        Form17.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Form17.Show()
    End Sub

    Private Sub Picture3_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture3.DoubleClick
        ContextMenuStrip1.Show()
    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub PictureBox9_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseHover
        ToolTip1.Active = True
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        'yourversion.Text = "Microsoft Windows 11 Professional "
        If My.Computer.Info.OSFullName = "Microsoft Windows 7 Professional " Then
            yourversion.Text = "Microsoft Windows 10 Pro "
            stopwin71()
            'Panel7.Visible = True
        Else
            stopwin71()
            yourversion.Text = "Microsoft Windows 11 Pro "
        End If
    End Sub

    Private Sub Stopwin7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stopwin7.Tick
        If Form31.PictureBox4.Visible = True Then
            Form31.PictureBox4.Visible = False
        End If
    End Sub
    Public Sub stopwin71()
        PictureBox5.Visible = False
        PictureBox9.Visible = False
        Button1.Enabled = False
        Panel1.Visible = True
    End Sub
End Class
