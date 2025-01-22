Public Class FrmCaculator
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label10.Text = "+"

        TextBox3.Text = Convert.ToDecimal(TextBox1.Text) + Convert.ToDecimal(TextBox2.Text)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label10.Text = "-"
        TextBox3.Text = Convert.ToDecimal(TextBox1.Text) - Convert.ToDecimal(TextBox2.Text)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label10.Text = "X"
        TextBox3.Text = Convert.ToDecimal(TextBox1.Text) * Convert.ToDecimal(TextBox2.Text)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label10.Text = "\"
        TextBox3.Text = Convert.ToDecimal(TextBox1.Text) / Convert.ToDecimal(TextBox2.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
