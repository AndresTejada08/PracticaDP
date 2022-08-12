Public Class Form1
    Dim Servicio As New ServiceReference1.WebService1SoapClient
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim Nro1, Nro2, Resultado As Integer
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Resultado = Servicio.Suma(Nro1, Nro2)
        txtResultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim Nro1, Nro2, Resultado As Integer
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Resultado = Servicio.Resta(Nro1, Nro2)
        txtResultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Dim Nro1, Nro2, Resultado As Integer
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Resultado = Servicio.Multiplicacion(Nro1, Nro2)
        txtResultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim Nro1, Nro2, Resultado As String
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Resultado = Servicio.Division(Nro1, Nro2)
        txtResultado.Text = Resultado
    End Sub

    Private Sub btnInverso_Click(sender As Object, e As EventArgs) Handles btnInverso.Click
        Dim Nro1, Resultado As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Resultado = Servicio.Inverso(Nro1)
        txtResultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        Dim Nro1, Resultado As Integer
        Nro1 = Double.Parse(txtNro1.Text)
        Resultado = Servicio.Factorial(Nro1)
        txtResultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnSeno_Click(sender As Object, e As EventArgs) Handles btnSeno.Click
        Dim Nro1, Resultado As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Resultado = Servicio.Seno(Nro1)
        txtResultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnCoseno_Click(sender As Object, e As EventArgs) Handles btnCoseno.Click
        Dim Nro1, Resultado As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Resultado = Servicio.Coseno(Nro1)
        txtResultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnTangente_Click(sender As Object, e As EventArgs) Handles btnTangente.Click
        Dim Nro1, Resultado As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Resultado = Servicio.Tangente(Nro1)
        txtResultado.Text = Resultado.ToString()
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        Dim Nro1, Nro2, Resultado As Integer
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Resultado = Servicio.Potencia(Nro1, Nro2)
        txtResultado.Text = Resultado.ToString()
    End Sub
End Class
