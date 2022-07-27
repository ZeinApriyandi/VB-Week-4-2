Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        lbl_font.Font = New Font("Microsoft sans Sarif", lbl_font.Font.Size, lbl_font.Font.Style Xor FontStyle.Strikeout)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        lbl_font.Font = New Font ("Microsoft sans Sarif", lbl_font.Font.Size, lbl_font.Font.Style Xor FontStyle.Underline)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        lbl_font.Font = New Font("Microsoft sans Sarif", lbl_font.Font.Size, lbl_font.Font.Style Xor FontStyle.Regular)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        lbl_font.Font = New Font("Microsoft sans Sarif", lbl_font.Font.Size, lbl_font.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        lbl_font.Font = New Font("Microsoft sans Sarif", lbl_font.Font.Size, lbl_font.Font.Style Xor FontStyle.Bold)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        lbl_font.Font = New Font("Microsoft sans Sarif", lbl_font.Font.Size, lbl_font.Font.Style Xor FontStyle.Bold Xor FontStyle.Italic)
    End Sub
End Class
