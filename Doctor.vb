
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
Imports System.Windows.Forms.ErrorProvider
Imports System.Data.DataView
Public Class Doctor
    Dim cmd, cmd1 As OleDbCommand
    Dim dr, dr1 As OleDbDataReader
    Dim con, cn As New OleDbConnection
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String
        If txtDname.Text = "" Or txtDaddress.Text = "" Or txtDcontact.Text = "" Or txtDquali.Text = "" Then
            MsgBox("Please enter the all information")
        Else

            Try
                con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2012\Projects\WindowsApplication1\WindowsApplication1\hospital.mdb")
                con.Open()
                s = "Insert Into doctor(name,quali,contactno,address) Values ('" & txtDname.Text & "','" & txtDquali.Text & "','" & txtDcontact.Text & "','" & txtDaddress.Text & "')"
                Dim cmd As New OleDbCommand(s, con)
                cmd.ExecuteNonQuery()
                MsgBox("Record saved successfully...")
                txtDaddress.Text = ""
                txtDcontact.Text = ""
                txtDname.Text = ""
                txtDquali.Text = ""
                Login.Visible = True
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message(), , "ERROR")
            End Try
        End If
    End Sub
End Class