Public Class frmPagos


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        frmBuscarCuenta.ShowDialog()
    End Sub
End Class