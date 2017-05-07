Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmSeleccionarCalle
    Dim conexion As New SqlConnection(CadenaDeConexion)
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader


    Private Sub frmSeleccionarCalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()



        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand("SELECT nombre FROM Calle ORDER BY nombre ASC;", conexion)


        lector = cmd.ExecuteReader
        While lector.Read
            cboxCalle.Items.Add(lector(0))
        End While
        lector.Close()

        cboxCalle.SelectedIndex = 0

        conexion.Close()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub cmdGenerarReporte_Click(sender As Object, e As EventArgs) Handles cmdGenerarReporte.Click
        Dim Calle As String = cboxCalle.Text

        Dim Conexion As New SqlConnection(CadenaDeConexion)

        Dim cmd As New SqlCommand("ReporteCuentasPorCalle", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter()
        adaptador.SelectCommand = New SqlCommand
        adaptador.SelectCommand.Connection = Conexion
        adaptador.SelectCommand.CommandText = "ReporteCuentasPorCalle"
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@Calle", SqlDbType.NVarChar)
        param1.Direction = ParameterDirection.Input
        param1.Value = Calle
        adaptador.SelectCommand.Parameters.Add(param1)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        dataset.DataSetName = "ReporteCuentasPorCalle"
        Dim datasource As New ReportDataSource("ReporteCuentasPorCalle", dataset.Tables(0))
        datasource.Name = "ReporteCuentasPorCalle"
        datasource.Value = dataset.Tables(0)
        Dim p1 As New ReportParameter("p1", Calle)

        frmReportes.rvReportes.LocalReport.DataSources.Clear()
        frmReportes.rvReportes.LocalReport.DataSources.Add(datasource)
        frmReportes.rvReportes.LocalReport.ReportPath =
        "C:\Users\DigitalXlien\Desktop\XLIEN\Sistema de Pagos  y Servicios de Agua Potable - PSAP\PSAP\PSAP\reporteCuentasPorCalle.rdlc"
        frmReportes.rvReportes.LocalReport.SetParameters(New ReportParameter() {p1})
        frmReportes.rvReportes.RefreshReport()
        frmReportes.ShowDialog()
        Conexion.Close()

















    End Sub






End Class