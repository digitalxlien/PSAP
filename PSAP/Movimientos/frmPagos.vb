Public Class frmPagos


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        frmBuscarCuenta.ShowDialog()
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCargarPagoAgua.ShowDialog()
    End Sub

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class