Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer

        ' Try to parse the input as an integer
        If Integer.TryParse(TextBox1.Text, number) Then
            ' Check if the number is even or odd
            If number Mod 2 = 0 Then
                Label1.Text = "The number is even."
            Else
                Label1.Text = "The number is odd."
            End If
        Else
            Label1.Text = "Please enter a valid integer."
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
