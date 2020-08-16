Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
Imports System.Windows.Forms.ErrorProvider
Imports System.Data.DataView
Public Class Admin
    Dim cmd, cmd1 As OleDbCommand
    Dim dr, dr1 As OleDbDataReader
    Dim con, cn As New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        Button4.Visible = True
        Label8.Visible = True
        TextBox6.Visible = True
        Button5.Visible = False
        Button3.Visible = True
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        txtDaddress.Visible = False
        txtDcontact.Visible = False
        txtDname.Visible = False
        txtDquali.Visible = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        Button4.Visible = False
        Label8.Visible = True
        TextBox6.Visible = True
        Button3.Visible = False
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        txtDaddress.Visible = True
        txtDcontact.Visible = True
        txtDname.Visible = True
        txtDquali.Visible = True
        Button5.Visible = True
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        Button4.Visible = False
        Label8.Visible = False
        TextBox6.Visible = False
        Button3.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        txtDaddress.Visible = False
        txtDcontact.Visible = False
        txtDname.Visible = False
        txtDquali.Visible = False
        Button5.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2012\Projects\WindowsApplication1\WindowsApplication1\hospital.mdb")
            cn.Open()

            cmd1 = New OleDbCommand("select * from patient where name='" & TextBox6.Text & "' ", cn)
            dr1 = cmd1.ExecuteReader
            While dr1.Read()
                TextBox1.Text = dr1(1)
                TextBox2.Text = dr1(2)
                TextBox3.Text = dr1(3)
                TextBox4.Text = dr1(4)
                TextBox5.Text = dr1(5)
            End While
            cn.Close()
            dr1.Close()
        Catch ex As Exception
            MsgBox(ex.Message(), , "ERROR")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2012\Projects\WindowsApplication1\WindowsApplication1\hospital.mdb")
            cn.Open()

            cmd1 = New OleDbCommand("select * from doctor where name='" & TextBox6.Text & "' ", cn)
            dr1 = cmd1.ExecuteReader
            While dr1.Read()
                txtDname.Text = dr1(1)
                txtDquali.Text = dr1(2)
                txtDcontact.Text = dr1(3)
                txtDaddress.Text = dr1(4)
            End While
            cn.Close()
            dr1.Close()
        Catch ex As Exception
            MsgBox(ex.Message(), , "ERROR")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class