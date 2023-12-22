Imports System.Runtime.InteropServices

Public Class conversor
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calcular.Click
        If monedasalida.SelectedItem = "Dólar" Then
            total.Text = cantidad.Text / 4602
        Else
            If monedasalida.SelectedItem = "Libra esterlina" Then
                total.Text = cantidad.Text / 5682
            Else
                If monedasalida.SelectedItem = "Euro" Then
                    total.Text = cantidad.Text / 4992
                Else
                If monedasalida.SelectedItem = "Yuan chino" Then
                        total.Text = cantidad.Text / 680
                    Else
                    If monedasalida.SelectedItem = "Rublo Ruso" Then
                            total.Text = cantidad.Text / 65
                        Else
                        If monedasalida.SelectedItem = "Yen japones" Then
                                total.Text = cantidad.Text / 35
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles cantidad.TextChanged

    End Sub

    Private Sub monedasalida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles monedasalida.SelectedIndexChanged

    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        cantidad.Text = ""
        monedasalida.SelectedItem = ""
        total.Text = ""
    End Sub
End Class
