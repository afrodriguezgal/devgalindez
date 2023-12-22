Public Class appfracciones
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtn1.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Suma.Click
        If (Val(txtd1.Text) = Val(txtd2.Text)) Then
            txtrn.Text = Val(txtn1.Text) + Val(txtn2.Text)
            txtrd.Text = Val(txtd1.Text)
        Else
            If (Val(txtd1.Text) <> Val(txtd2.Text)) Then
                MsgBox("Recuerde que el denominador debe ser igual")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Resta.Click
        If (Val(txtd1.Text) = Val(txtd2.Text)) Then
            txtrn.Text = Val(txtn1.Text) - Val(txtn2.Text)
            txtrd.Text = Val(txtd1.Text)
        Else
            If (Val(txtd1.Text) <> Val(txtd2.Text)) Then
                MsgBox("Recuerde que el denominador debe ser igual")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        txtd1.Text = ""
        txtd2.Text = ""
        txtn1.Text = ""
        txtn2.Text = ""
        txtrd.Text = ""
        txtrn.Text = ""
    End Sub
End Class
