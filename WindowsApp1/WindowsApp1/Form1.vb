Public Class Form1
    Dim contador As Integer
    Dim contadors As Integer = 0

    Private Sub botonmas_Click(sender As Object, e As EventArgs) Handles botonmas.Click
        Dim botonmas As Integer = cantidadtextbox.Text
        Dim numtemp As Integer
        numtemp = botonmas + 1
        cantidadtextbox.Text = numtemp.ToString()


    End Sub

    Private Sub botonmenos_Click(sender As Object, e As EventArgs) Handles botonmenos.Click
        Dim botonmenos As Integer = cantidadtextbox.Text
        Dim numtemp2 As Integer
        numtemp2 = botonmenos - 1
        cantidadtextbox.Text = numtemp2.ToString()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim price As Integer = preciotextbox.Text
        Dim cuant As Integer = cantidadtextbox.Text
        Dim subtotal As Integer
        subtotal = price * cuant
        Label7.Text = subtotal.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim button2 As Integer = preciotextbox.Text
        Dim cuantIVA As Integer = cantidadtextbox.Text
        Dim Iva As Integer
        Iva = button2 * cuantIVA * 0.16
        Label8.Text = Iva.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim button3 As Integer = preciotextbox.Text
        Dim cuantotal As Integer = cantidadtextbox.Text
        Dim ivatotal As Integer = Label8.Text
        Dim total As Integer
        total = button3 * cuantotal + ivatotal
        Label9.Text = total.ToString()
    End Sub
End Class