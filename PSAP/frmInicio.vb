Public Class frmInicio

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mniAcercaDe.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mniSalir.Click
        End
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mniGastos.Click
        frmGastos.ShowDialog()
    End Sub


    Private Sub mniCalles_Click(sender As Object, e As EventArgs) Handles mniCalles.Click
        frmCalles.ShowDialog()
    End Sub

    Private Sub mniMateriales_Click(sender As Object, e As EventArgs) Handles mniMateriales.Click
        frmMateriales.ShowDialog()
    End Sub

    Private Sub mniPozos_Click(sender As Object, e As EventArgs) Handles mniPozos.Click
        frmPozos.ShowDialog()
    End Sub

    Private Sub mniServicios_Click(sender As Object, e As EventArgs) Handles mniServicios.Click
        frmServicios.ShowDialog()
    End Sub


    Private Sub mniCuentas_Click(sender As Object, e As EventArgs) Handles mniCuentas.Click
        frmCuentas.ShowDialog()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mniEmpleados.Click
        frmEmpleados.ShowDialog()
    End Sub

    Private Sub mniTarifas_Click(sender As Object, e As EventArgs) Handles mniTarifas.Click
        frmTarifas.ShowDialog()
    End Sub

    Private Sub SituacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mniSituaciones.Click
        frmSituaciones.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmProveedores.ShowDialog()
    End Sub

    Private Sub mniActividadPozos_Click(sender As Object, e As EventArgs) Handles mniActividadPozos.Click
        frmActiidadPozos.ShowDialog()
    End Sub

    Private Sub mniGastosRealizados_Click(sender As Object, e As EventArgs) Handles mniGastosRealizados.Click
        frmGastosRealizados.ShowDialog()
    End Sub

    Private Sub mniConsultarCompras_Click(sender As Object, e As EventArgs) Handles mniConsultarEntradaMaterial.Click
        frmConsultarEntradaMaterial.ShowDialog()
    End Sub

    Private Sub RegisrarComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisrarComprasToolStripMenuItem.Click
        frmEntradaMaterial.ShowDialog()
    End Sub


    Private Sub RegistrarSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mniRegistrarSalidas.Click
        frmSalidaMaterial.ShowDialog()
    End Sub

    Private Sub mniConsultarSalidas_Click(sender As Object, e As EventArgs) Handles mniConsultarSalidas.Click
        frmConsultarSalidaMaterial.ShowDialog()
    End Sub
End Class