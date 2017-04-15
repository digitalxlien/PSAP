Public Class frmPagos


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdBuscarCuenta.Click
        frmBuscarCuenta.ShowDialog()
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdCargarPagoAgua.Click
        frmCargarPagoAgua.ShowDialog()
    End Sub


    Function autosuma(ByRef dg As DataGridView, ByVal colunma As String) As Decimal
        Dim total As Decimal = 0

        For x = 0 To dg.Rows.Count - 1
            total = total + dg.Item(colunma, x).Value

        Next

        Return Math.Round(total, 2)
    End Function

    Sub CalcularTotal()
        Dim totalAgua As Double
        Dim totalServicios As Double


        totalAgua = autosuma(dgAgua, "importe")
        totalServicios = autosuma(dgServicios, "precio")

        txtTotal.Text = totalAgua + totalServicios


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdCargarPagoServicios.Click
        frmCargarPagoServicio.ShowDialog()
    End Sub

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdSalir_Click_1(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        cmdGrabar.Enabled = True
    End Sub
End Class