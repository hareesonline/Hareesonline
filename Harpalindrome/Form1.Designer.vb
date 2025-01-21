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
        btnCheckPalindrome = New Button()
        txtInput = New TextBox()
        SuspendLayout()
        ' 
        ' btnCheckPalindrome
        ' 
        btnCheckPalindrome.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnCheckPalindrome.Location = New Point(90, 107)
        btnCheckPalindrome.Name = "btnCheckPalindrome"
        btnCheckPalindrome.Size = New Size(136, 35)
        btnCheckPalindrome.TabIndex = 0
        btnCheckPalindrome.Text = "Check Palindrome "
        btnCheckPalindrome.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.ForeColor = SystemColors.MenuHighlight
        txtInput.Location = New Point(66, 53)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(170, 23)
        txtInput.TabIndex = 1
        txtInput.Text = "Enter the Text to Check"
        txtInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(328, 211)
        Controls.Add(txtInput)
        Controls.Add(btnCheckPalindrome)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Palindrome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCheckPalindrome As Button
    Friend WithEvents txtInput As TextBox

End Class
