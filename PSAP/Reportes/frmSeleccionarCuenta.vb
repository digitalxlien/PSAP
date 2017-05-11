
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmSeleccionarCuenta

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As New SqlCommand
    Dim lector As SqlDataReader
    Dim sql As String
    Dim meses() As String = New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}

    Private Sub frmBuscarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        cmd.Connection = conexion
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

        dgCuentas.Rows.Clear()

        cmd.CommandText = String.Format("Select Cuenta.idCalle, Cuenta.nombre, Calle.nombre, Cuenta.numeroExt, Cuenta.numeroInt," & _
                                        "Cuenta.fechaAlta, cuenta.ultimoPagoMes, Cuenta.ultimoPagoAnio from cuenta inner join calle " & _
                                        "on Cuenta.idCalle = Calle.idCalle where cuenta.nombre like '%{0}%'", txtNombre.Text & "")


        lector = cmd.ExecuteReader

        While lector.Read
            If lector(6).ToString = "" Then
                dgCuentas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6).ToString & " - " & lector(7).ToString)
            Else
                dgCuentas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), meses(lector(6) - 1) & " - " & lector(7).ToString)
            End If
        End While
        lector.Close()


        If dgCuentas.Rows.Count > 0 Then
            cmdSeleccionar.Enabled = True
        Else
            cmdSeleccionar.Enabled = False
        End If

    End Sub

    Private Sub cmdSeleccionar_Click(sender As Object, e As EventArgs) Handles cmdSeleccionar.Click
        cierraConexion()

        Dim idCuenta As String = dgCuentas.Rows.Item(dgCuentas.CurrentCell.RowIndex).Cells(0).Value
        Dim nombre As String = dgCuentas.Rows.Item(dgCuentas.CurrentCell.RowIndex).Cells(0).Value
        'MessageBox.Show(idCuenta)


        Dim Conexion As New SqlConnection(CadenaDeConexion)

        Dim cmd As New SqlCommand("ReporteHistorialCuenta", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter()
        adaptador.SelectCommand = New SqlCommand
        adaptador.SelectCommand.Connection = Conexion
        adaptador.SelectCommand.CommandText = "ReporteHistorialCuenta"
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@idCuenta", SqlDbType.NVarChar)
        param1.Direction = ParameterDirection.Input
        param1.Value = idCuenta
        adaptador.SelectCommand.Parameters.Add(param1)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        dataset.DataSetName = "ReporteHistorialCuenta"
        Dim datasource As New ReportDataSource("ReporteHistorialCuenta", dataset.Tables(0))
        datasource.Name = "ReporteHistorialCuenta"
        datasource.Value = dataset.Tables(0)
        Dim p1 As New ReportParameter("p1", idCuenta)

        frmReportes.rvReportes.LocalReport.DataSources.Clear()
        frmReportes.rvReportes.LocalReport.DataSources.Add(datasource)
        frmReportes.rvReportes.LocalReport.ReportPath =
        "C:\Users\DigitalXlien\Desktop\XLIEN\Sistema de Pagos  y Servicios de Agua Potable - PSAP\PSAP\PSAP\ReporteHistorialCuenta.rdlc"
        frmReportes.rvReportes.LocalReport.SetParameters(New ReportParameter() {p1})
        frmReportes.rvReportes.RefreshReport()
        Conexion.Close()



        frmReportes.ShowDialog()

        Me.Dispose()

    End Sub

    Sub cierraConexion()
        conexion.Close()
    End Sub



    Private Sub cmdRegresar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        conexion.Close()
        Me.Dispose()
    End Sub


End Class