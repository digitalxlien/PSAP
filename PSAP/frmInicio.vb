Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms


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
        frmActividadPozos.ShowDialog()
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

    Private Sub mniRegistrarPago_Click(sender As Object, e As EventArgs) Handles mniRegistrarPago.Click
        frmPagos.ShowDialog()
    End Sub

    Private Sub mniConsultarPagos_Click(sender As Object, e As EventArgs) Handles mniConsultarPagos.Click
        frmConsultarPago.ShowDialog()
    End Sub

    Private Sub mniReportesClientes_Click(sender As Object, e As EventArgs) Handles mniReportesCuentas.Click
        Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
        Dim cmd As New SqlCommand("ReporteCuentas", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adaptador.Fill(data)
        data.DataSetName = "ReporteCuentas"
        Dim reportes As New ReportDataSource("ReporteCuentas", data.Tables(0))
        frmReportes.rvReportes.LocalReport.DataSources.Clear()
        frmReportes.rvReportes.LocalReport.DataSources.Add(reportes)
        frmReportes.rvReportes.LocalReport.ReportPath = directorioLocal & "ReporteCuentas.rdlc"
        frmReportes.rvReportes.RefreshReport()
        frmReportes.Show()
        conexion.Close()
    End Sub

    Private Sub mniClientesPorCalle_Click(sender As Object, e As EventArgs) Handles mniCuentasPorCalle.Click
        frmSeleccionarCalle.ShowDialog()
    End Sub

    Private Sub mniReporteCalles_Click(sender As Object, e As EventArgs) Handles mniReporteCalles.Click
        Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
        Dim cmd As New SqlCommand("ReporteCalles", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adaptador.Fill(data)
        data.DataSetName = "ReporteCalles"
        Dim reportes As New ReportDataSource("ReporteCalles", data.Tables(0))
        frmReportes.rvReportes.LocalReport.DataSources.Clear()
        frmReportes.rvReportes.LocalReport.DataSources.Add(reportes)
        frmReportes.rvReportes.LocalReport.ReportPath = directorioLocal & "ReporteCalles.rdlc"
        frmReportes.rvReportes.RefreshReport()
        frmReportes.Show()
        conexion.Close()


    End Sub

    Private Sub mniReporteEmpleados_Click(sender As Object, e As EventArgs) Handles mniReporteEmpleados.Click

        Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
        Dim cmd As New SqlCommand("ReporteEmpleados", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adaptador.Fill(data)
        data.DataSetName = "ReporteEmpleados"
        Dim reportes As New ReportDataSource("ReporteEmpleados", data.Tables(0))
        frmReportes.rvReportes.LocalReport.DataSources.Clear()
        frmReportes.rvReportes.LocalReport.DataSources.Add(reportes)
        frmReportes.rvReportes.LocalReport.ReportPath = directorioLocal & "ReporteEmpleados.rdlc"
        frmReportes.rvReportes.RefreshReport()
        frmReportes.Show()
        conexion.Close()


    End Sub

    Private Sub mniReporteGastos_Click(sender As Object, e As EventArgs) Handles mniReporteGastos.Click
        Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
        Dim cmd As New SqlCommand("ReporteGastos", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adaptador.Fill(data)
        data.DataSetName = "ReporteGastos"
        Dim reportes As New ReportDataSource("ReporteGastos", data.Tables(0))
        frmReportes.rvReportes.LocalReport.DataSources.Clear()
        frmReportes.rvReportes.LocalReport.DataSources.Add(reportes)
        frmReportes.rvReportes.LocalReport.ReportPath = directorioLocal & "ReporteGastos.rdlc"
        frmReportes.rvReportes.RefreshReport()
        frmReportes.Show()
        conexion.Close()


    End Sub

    Private Sub mniReporteTarifas_Click(sender As Object, e As EventArgs) Handles mniReporteTarifas.Click
        Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
        Dim cmd As New SqlCommand("ReporteTarifas", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adaptador.Fill(data)
        data.DataSetName = "ReporteTarifas"
        Dim reportes As New ReportDataSource("ReporteTarifas", data.Tables(0))
        frmReportes.rvReportes.LocalReport.DataSources.Clear()
        frmReportes.rvReportes.LocalReport.DataSources.Add(reportes)
        frmReportes.rvReportes.LocalReport.ReportPath = directorioLocal & "ReporteTarifas.rdlc"
        frmReportes.rvReportes.RefreshReport()
        frmReportes.Show()
        conexion.Close()
    End Sub

    Private Sub mniReporteMaterialesExistencia_Click(sender As Object, e As EventArgs) Handles mniReporteMaterialesExistencia.Click
        Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
        Dim cmd As New SqlCommand("ReporteMateriales", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adaptador.Fill(data)
        data.DataSetName = "ReporteMateriales"
        Dim reportes As New ReportDataSource("ReporteMateriales", data.Tables(0))
        frmReportes.rvReportes.LocalReport.DataSources.Clear()
        frmReportes.rvReportes.LocalReport.DataSources.Add(reportes)
        frmReportes.rvReportes.LocalReport.ReportPath = directorioLocal & "ReporteMateriales.rdlc"
        frmReportes.rvReportes.RefreshReport()
        frmReportes.Show()
        conexion.Close()
    End Sub

    Private Sub mniReportePozos_Click(sender As Object, e As EventArgs) Handles mniReportePozos.Click
        Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
        Dim cmd As New SqlCommand("ReportePozos", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adaptador.Fill(data)
        data.DataSetName = "ReportePozos"
        Dim reportes As New ReportDataSource("ReportePozos", data.Tables(0))
        frmReportes.rvReportes.LocalReport.DataSources.Clear()
        frmReportes.rvReportes.LocalReport.DataSources.Add(reportes)
        frmReportes.rvReportes.LocalReport.ReportPath = directorioLocal & "ReportePozos.rdlc"
        frmReportes.rvReportes.RefreshReport()
        frmReportes.Show()
        conexion.Close()
    End Sub

    Private Sub mniProveedores_Click(sender As Object, e As EventArgs) Handles mniProveedores.Click
        Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
        Dim cmd As New SqlCommand("ReporteProveedores", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adaptador.Fill(data)
        data.DataSetName = "ReporteProveedores"
        Dim reportes As New ReportDataSource("ReporteProveedores", data.Tables(0))
        frmReportes.rvReportes.LocalReport.DataSources.Clear()
        frmReportes.rvReportes.LocalReport.DataSources.Add(reportes)
        frmReportes.rvReportes.LocalReport.ReportPath = directorioLocal & "ReporteProveedores.rdlc"
        frmReportes.rvReportes.RefreshReport()
        frmReportes.Show()
        conexion.Close()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
        Dim cmd As New SqlCommand("ReporteServicios", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adaptador.Fill(data)
        data.DataSetName = "ReporteServicios"
        Dim reportes As New ReportDataSource("ReporteServicios", data.Tables(0))
        frmReportes.rvReportes.LocalReport.DataSources.Clear()
        frmReportes.rvReportes.LocalReport.DataSources.Add(reportes)
        frmReportes.rvReportes.LocalReport.ReportPath = directorioLocal & "ReporteServicios.rdlc"
        frmReportes.rvReportes.RefreshReport()
        frmReportes.Show()
        conexion.Close()
    End Sub

    Private Sub HistorialDePagosPorCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mniReporteHistorialCuenta.Click
        frmSeleccionarCuenta.ShowDialog()
    End Sub
End Class