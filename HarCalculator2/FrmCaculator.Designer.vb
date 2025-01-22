<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCaculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 16.2F)
        TextBox1.Location = New Point(39, 172)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(174, 43)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 16.2F)
        TextBox2.Location = New Point(289, 172)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(174, 43)
        TextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label1.Location = New Point(766, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 46)
        Label1.TabIndex = 2
        Label1.Text = "Addition(+)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 19.8000011F)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label2.Location = New Point(766, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(227, 46)
        Label2.TabIndex = 3
        Label2.Text = "Subtraction(-)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 19.8000011F)
        Label3.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label3.Location = New Point(766, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(275, 46)
        Label3.TabIndex = 4
        Label3.Text = "Multiplication( X)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 19.8000011F)
        Label4.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label4.Location = New Point(766, 273)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 46)
        Label4.TabIndex = 5
        Label4.Text = "Division(\)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F)
        Label5.Location = New Point(489, 172)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 31)
        Label5.TabIndex = 6
        Label5.Text = "="
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 16.2F)
        TextBox3.Location = New Point(557, 172)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(163, 43)
        TextBox3.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Underline)
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label6.Location = New Point(429, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(213, 54)
        Label6.TabIndex = 8
        Label6.Text = "Calculator"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F)
        Label7.ForeColor = Color.Teal
        Label7.Location = New Point(608, 138)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 31)
        Label7.TabIndex = 9
        Label7.Text = "Total"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13.8F)
        Label8.ForeColor = Color.Teal
        Label8.Location = New Point(312, 138)
        Label8.Name = "Label8"
        Label8.Size = New Size(110, 31)
        Label8.TabIndex = 10
        Label8.Text = "Number2"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13.8F)
        Label9.ForeColor = Color.Teal
        Label9.Location = New Point(69, 138)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 31)
        Label9.TabIndex = 11
        Label9.Text = "Number1"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 19.8000011F)
        Label10.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label10.Location = New Point(238, 161)
        Label10.Name = "Label10"
        Label10.Size = New Size(27, 46)
        Label10.TabIndex = 12
        Label10.Text = "."
        ' 
        ' FrmCaculator
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1053, 426)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FrmCaculator"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label

End Class
