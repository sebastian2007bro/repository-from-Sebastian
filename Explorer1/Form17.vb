Public Class Form17

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If RichTextBox1.Text = "C:/Sebs-SW/install CP1.0 -1" Then
            'Form5.Show()
            RichTextBox1.Text = "C:/Sebs-SW/install CP1.0 - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/restart -mi" Then
            Form33.Show()
            Form33.Label1.Text = "Restart"
            RichTextBox1.Text = "C:/Sebs-SW/restart -mi - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/download update 2.8" Then
            'Form8.Show()
            RichTextBox1.Text = "C:/Sebs-SW/download update 2.8 - Done"
        End If
        If RichTextBox1.Text = "SW.???.About" Then
            RichTextBox1.Text = "C:/Sebs-SW"
            MsgBox("Sorry for the Danish language ??? er en Fejl(Error) for Programmer i Sebs SW(Sebs Web)")
            RichTextBox1.Text = "C:/Sebs-SW"
            'SW.???.About
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/download update sebs sw b -1" Then
            Form1.Text = "Sebs SW B"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/sebs sw b" Then
            RichTextBox1.Text = "C:/Sebs-SW/sebs sw b - Fail"
            MsgBox("Program Builder is not activated-Sebs SW B", MsgBoxStyle.Critical)
            MsgBox("need Sebs sw 3.5 or 3.6 form", MsgBoxStyle.Critical)
            'Form1.Text = "Sebs SW B"
            RichTextBox1.Text = "C:/Sebs-SW/sebs sw b - Fail"
            'download update sebs sw b -1
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/download Lions1.0 -install" Then
            'AboutBox12.Show()
            'Form9.Show()
            Form1.Panel1.Visible = False
            Form1.Panel3.Visible = False
            Form1.Panel4.Visible = False
            RichTextBox1.Text = "C:/Sebs-SW/download Lions1.0 -install - Done"
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/reboot" Then
            Form33.Show()
            Form33.Timer1.Start()
            Form1.shutdown()
            Close()
        End If
        If RichTextBox1.Text = "C:/Sebs-SW/download Lions2.0 -install" Then
            'AboutBox11.Show()
            Form1.Panel1.Visible = False
            Form1.Panel3.Visible = False
            Form1.Panel4.Visible = False
            RichTextBox1.Text = "C:/Sebs-SW/download Lions2.0 -install - Done"
        End If
        If RichTextBox1.ForeColor = Color.Black Then
            RichTextBox1.ForeColor = Color.White
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog2.Font
            RichTextBox1.ForeColor = FontDialog2.Color
        End If
    End Sub

    Private Sub CMDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDToolStripMenuItem.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub FontDialog2_Apply(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontDialog2.Apply
        RichTextBox1.Font = FontDialog1.Font
        RichTextBox1.ForeColor = FontDialog1.Color
    End Sub
End Class