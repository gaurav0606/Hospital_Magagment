<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor
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
        Me.txtDname = New System.Windows.Forms.TextBox()
        Me.txtDquali = New System.Windows.Forms.TextBox()
        Me.txtDcontact = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDaddress = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctor Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Doctor Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Qualification"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact no."
        '
        'txtDname
        '
        Me.txtDname.Location = New System.Drawing.Point(269, 136)
        Me.txtDname.Name = "txtDname"
        Me.txtDname.Size = New System.Drawing.Size(246, 26)
        Me.txtDname.TabIndex = 4
        '
        'txtDquali
        '
        Me.txtDquali.Location = New System.Drawing.Point(269, 199)
        Me.txtDquali.Name = "txtDquali"
        Me.txtDquali.Size = New System.Drawing.Size(246, 26)
        Me.txtDquali.TabIndex = 5
        '
        'txtDcontact
        '
        Me.txtDcontact.Location = New System.Drawing.Point(273, 260)
        Me.txtDcontact.Name = "txtDcontact"
        Me.txtDcontact.Size = New System.Drawing.Size(242, 26)
        Me.txtDcontact.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Address"
        '
        'txtDaddress
        '
        Me.txtDaddress.Location = New System.Drawing.Point(276, 315)
        Me.txtDaddress.Name = "txtDaddress"
        Me.txtDaddress.Size = New System.Drawing.Size(239, 26)
        Me.txtDaddress.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(204, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(407, 436)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 42)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1352, 741)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDaddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDcontact)
        Me.Controls.Add(Me.txtDquali)
        Me.Controls.Add(Me.txtDname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Doctor"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDname As System.Windows.Forms.TextBox
    Friend WithEvents txtDquali As System.Windows.Forms.TextBox
    Friend WithEvents txtDcontact As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDaddress As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
