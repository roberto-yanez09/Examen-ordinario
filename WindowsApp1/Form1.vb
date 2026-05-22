Public Class Form1
    Dim contador As Integer
    Dim contadors As Integer = 0

    Private Sub botonmas_Click(sender As Object, e As EventArgs) Handles botonmas.Click
        contador += 1
        cantidadtextbox.Text = contador.ToString()

    End Sub

    Private Sub botonmenos_Click(sender As Object, e As EventArgs) Handles botonmenos.Click
        contadors -= 1
        cantidadtextbox.Text = contadors.ToString()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
