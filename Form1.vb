﻿Public Class Form1

    Dim n1 As Decimal
    Dim n2 As Decimal
    Dim res As Decimal



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        entrada()

        res = n1 + n2

        salida()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        entrada()

        res = n1 - n2

        salida()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        entrada()

        res = n1 * n2

        salida()

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        entrada()

        res = n1 / n2

        salida()

    End Sub
    Private Sub entrada()

        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)

    End Sub

    Private Sub salida()

        TextBox3.Text = res.ToString

    End Sub


End Class
