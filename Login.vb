Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim l, p As String
        l = "admin"
        p = "admin"
        If l = TextBox1.Text And p = TextBox2.Text Then
            Admin.Visible = True
            MsgBox("Welcome")
            Me.Hide()
        Else
            MsgBox("Please enter correct login and password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Patient.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Doctor.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
