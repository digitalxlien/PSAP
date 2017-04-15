Public Class frmPagos


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        frmBuscarCuenta.ShowDialog()
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

End Class