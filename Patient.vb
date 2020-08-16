Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
Imports System.Windows.Forms.ErrorProvider
Imports System.Data.DataView
Public Class Patient
    Dim cmd, cmd1 As OleDbCommand
    Dim dr, dr1 As OleDbDataReader
    Dim con, cn As New OleDbConnection
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s As String
        If txtPname.Text = "" Or txtPaddress.Text = "" Or txtPcontact.Text = "" Or txtPdisease.Text = "" Or txtPblood.Text = "" Then
            MsgBox("Please enter the all information")
        Else

            Try
                con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2012\Projects\WindowsApplication1\WindowsApplication1\hospital.mdb")
                con.Open()
                s = "Insert Into patient(name,address,contactno,disease,blood) Values ('" & txtPname.Text & "','" & txtPaddress.Text & "','" & txtPcontact.Text & "','" & txtPdisease.Text & "','" & txtPblood.Text & "')"
                Dim cmd As New OleDbCommand(s, con)
                cmd.ExecuteNonQuery()
                MsgBox("Record saved successfully...")
                txtPaddress.Text = ""
                txtPcontact.Text = ""
                txtPname.Text = ""
                txtPblood.Text = ""
                txtPdisease.Text = ""
                Login.Visible = True
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message(), , "ERROR")
            End Try
        End If
    End Sub
End Class