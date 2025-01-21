<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btn0 = New Button()
        btnEquals = New Button()
        btnClear = New Button()
        btnDivide = New Button()
        btnMultiply = New Button()
        btnSubtract = New Button()
        btnAdd = New Button()
        txtDisplay = New TextBox()
        SuspendLayout()
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(78, 316)
        btn1.Name = "btn1"
        btn1.Size = New Size(54, 45)
        btn1.TabIndex = 0
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(163, 316)
        btn2.Name = "btn2"
        btn2.Size = New Size(54, 45)
        btn2.TabIndex = 1
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(240, 316)
        btn3.Name = "btn3"
        btn3.Size = New Size(54, 45)
        btn3.TabIndex = 3
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(78, 246)
        btn4.Name = "btn4"
        btn4.Size = New Size(54, 45)
        btn4.TabIndex = 3
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(163, 246)
        btn5.Name = "btn5"
        btn5.Size = New Size(54, 45)
        btn5.TabIndex = 4
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(240, 246)
        btn6.Name = "btn6"
        btn6.Size = New Size(54, 45)
        btn6.TabIndex = 5
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(78, 180)
        btn7.Name = "btn7"
        btn7.Size = New Size(54, 45)
        btn7.TabIndex = 6
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(163, 180)
        btn8.Name = "btn8"
        btn8.Size = New Size(54, 45)
        btn8.TabIndex = 7
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(240, 180)
        btn9.Name = "btn9"
        btn9.Size = New Size(54, 45)
        btn9.TabIndex = 8
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Location = New Point(163, 379)
        btn0.Name = "btn0"
        btn0.Size = New Size(54, 45)
        btn0.TabIndex = 9
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btnEquals
        ' 
        btnEquals.Location = New Point(240, 379)
        btnEquals.Name = "btnEquals"
        btnEquals.Size = New Size(54, 45)
        btnEquals.TabIndex = 10
        btnEquals.Text = "="
        btnEquals.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(78, 379)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(54, 45)
        btnClear.TabIndex = 11
        btnClear.Text = "C"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(315, 180)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(54, 45)
        btnDivide.TabIndex = 12
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(315, 246)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(54, 45)
        btnMultiply.TabIndex = 13
        btnMultiply.Text = "*"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Location = New Point(315, 316)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(54, 45)
        btnSubtract.TabIndex = 14
        btnSubtract.Text = "-"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(315, 379)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(54, 45)
        btnAdd.TabIndex = 15
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDisplay.Location = New Point(78, 115)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(216, 35)
        txtDisplay.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(469, 535)
        Controls.Add(txtDisplay)
        Controls.Add(btnAdd)
        Controls.Add(btnSubtract)
        Controls.Add(btnMultiply)
        Controls.Add(btnDivide)
        Controls.Add(btnClear)
        Controls.Add(btnEquals)
        Controls.Add(btn0)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtDisplay As TextBox

End Class
