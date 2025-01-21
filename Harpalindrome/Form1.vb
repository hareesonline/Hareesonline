Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event is triggered when the form loads
    End Sub

    Private Sub btnCheckPalindrome_Click(sender As Object, e As EventArgs) Handles btnCheckPalindrome.Click
        Dim input As String = txtInput.Text

        If IsPalindrome(input) Then
            MessageBox.Show("The string is a palindrome.")
        Else
            MessageBox.Show("The string is not a palindrome.")
        End If
    End Sub

    Private Function IsPalindrome(ByVal str As String) As Boolean
        ' Remove any non-alphanumeric characters and convert to lowercase
        Dim cleanedStr As String = New String(str.Where(AddressOf Char.IsLetterOrDigit).ToArray()).ToLower()

        ' Reverse the cleaned string
        Dim reversedStr As String = New String(cleanedStr.Reverse().ToArray())

        ' Check if the cleaned string is equal to its reverse
        Return cleanedStr = reversedStr
    End Function

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.GotFocus

        txtInput.Text = ""

    End Sub

    Private Sub txtInput_TextChanged_1(sender As Object, e As EventArgs) Handles txtInput.GotFocus
        txtInput.Text = ""

    End Sub
End Class