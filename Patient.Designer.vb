<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtPname = New System.Windows.Forms.TextBox()
        Me.txtPaddress = New System.Windows.Forms.TextBox()
        Me.txtPcontact = New System.Windows.Forms.TextBox()
        Me.txtPdisease = New System.Windows.Forms.TextBox()
        Me.txtPblood = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 164)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Patient Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 198)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 229)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contact No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(125, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Disease Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Blood Group"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(200, 396)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 45)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Enter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(390, 396)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 45)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtPname
        '
        Me.txtPname.Location = New System.Drawing.Point(243, 158)
        Me.txtPname.Name = "txtPname"
        Me.txtPname.Size = New System.Drawing.Size(266, 24)
        Me.txtPname.TabIndex = 9
        '
        'txtPaddress
        '
        Me.txtPaddress.Location = New System.Drawing.Point(243, 192)
        Me.txtPaddress.Name = "txtPaddress"
        Me.txtPaddress.Size = New System.Drawing.Size(266, 24)
        Me.txtPaddress.TabIndex = 10
        '
        'txtPcontact
        '
        Me.txtPcontact.Location = New System.Drawing.Point(243, 222)
        Me.txtPcontact.Name = "txtPcontact"
        Me.txtPcontact.Size = New System.Drawing.Size(267, 24)
        Me.txtPcontact.TabIndex = 11
        '
        'txtPdisease
        '
        Me.txtPdisease.Location = New System.Drawing.Point(243, 258)
        Me.txtPdisease.Name = "txtPdisease"
        Me.txtPdisease.Size = New System.Drawing.Size(264, 24)
        Me.txtPdisease.TabIndex = 12
        '
        'txtPblood
        '
        Me.txtPblood.Location = New System.Drawing.Point(243, 292)
        Me.txtPblood.Name = "txtPblood"
        Me.txtPblood.Size = New System.Drawing.Size(264, 24)
        Me.txtPblood.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(249, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(261, 31)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Patient Information"
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 551)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPblood)
        Me.Controls.Add(Me.txtPdisease)
        Me.Controls.Add(Me.txtPcontact)
        Me.Controls.Add(Me.txtPaddress)
        Me.Controls.Add(Me.txtPname)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Patient"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtPname As System.Windows.Forms.TextBox
    Friend WithEvents txtPaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtPdisease As System.Windows.Forms.TextBox
    Friend WithEvents txtPblood As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
