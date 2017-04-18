Imports System.Data.SqlClient

Public Class frmPagos

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As SqlCommand = New SqlCommand("", conexion)
    Dim lector As SqlDataReader



    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        txtFecha.Text = System.DateTime.Today.ToLongDateString
        txtidPago.Text = getIdPago() + 1


    End Sub





    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        'conexion.Open()
        Dim tipo As Integer
        Dim sql As String
        Dim mayor As Integer

        tipo = 1
        sql = String.Format("INSERT INTO Pago (idCuenta, fecha, tipo, otros, total) " &
                            " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');", _
                            txtidCuenta.Text, System.DateTime.Today.ToShortDateString, tipo, txtOtros.Value, txtTotal.Text)

        cmd.CommandText = sql

        cmd.ExecuteNonQuery()



        For x = 0 To dgAgua.Rows.Count - 1
            sql = String.Format("INSERT INTO DetPagoAgua " &
                                "(idPago, idSituacion, idTarifa, mesInicial, mesFinal, cuotaFija, recargos, tar, infra, descuento) " &
                                "values " &
                                "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');", _
                                txtidPago.Text, _
                                getIdSituacion(dgAgua.Rows.Item(x).Cells("situacion").Value), _
                                getIdTarifa(dgAgua.Rows.Item(x).Cells("anio").Value), _
                                getNumeroMes(dgAgua.Rows.Item(x).Cells("mesInicio").Value), _
                                getNumeroMes(dgAgua.Rows.Item(x).Cells("mesFin").Value), _
                                dgAgua.Rows.Item(x).Cells("coutaFija").Value, _
                                dgAgua.Rows.Item(x).Cells("recargos").Value, _
                                dgAgua.Rows.Item(x).Cells("tar").Value, _
                                dgAgua.Rows.Item(x).Cells("infra").Value, _
                                dgAgua.Rows.Item(x).Cells("descuento").Value)
            'MessageBox.Show(sql)

            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Next


        If dgAgua.Rows.Count > 0 Then

            sql = String.Format("UPDATE cuenta SET ultimoPagoMes = '{0}', ultimoPagoAnio = '{1}' WHERE idCuenta = '{2}'", getNumeroMes(dgAgua.Rows.Item(0).Cells("mesFin").Value), dgAgua.Rows.Item(0).Cells("anio").Value, txtidCuenta.Text)
            mayor = dgAgua.Rows.Item(0).Cells("anio").Value

            'Buscar el registro mas actual
            For x = 0 To dgAgua.Rows.Count - 1
                If dgAgua.Rows.Item(x).Cells("anio").Value > mayor Then
                    mayor = dgAgua.Rows.Item(x).Cells("anio").Value
                    sql = String.Format("UPDATE cuenta SET ultimoPagoMes = '{0}', ultimoPagoAnio = '{1}' WHERE idCuenta = '{2}'", getNumeroMes(dgAgua.Rows.Item(x).Cells("mesFin").Value), dgAgua.Rows.Item(x).Cells("anio").Value, txtidCuenta.Text)
                End If
            Next

            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            MessageBox.Show("Mayor: " & mayor)

        End If


        For x = 0 To dgServicios.Rows.Count - 1
            sql = String.Format("INSERT INTO DetPagoServicio " &
                                "(idPago, idServicio, idEmpleado, precio) " &
                                "values " &
                                "('{0}', '{1}', '{2}', '{3}');", _
                                txtidPago.Text, _
                                getIdServicio(dgServicios.Rows.Item(x).Cells("servicio").Value), _
                                getIdempleado(dgServicios.Rows.Item(x).Cells("empleado").Value), _
                                dgServicios.Rows.Item(x).Cells("precio").Value)

            'MessageBox.Show(sql)

            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Next

        MessageBox.Show("Se ha guardado la información del pago correctamente", "Pago Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        cmdGrabar.Enabled = False

        cmdImprimir.Enabled = True
        cmdNuevo.Enabled = True
    End Sub



    Function getNumeroMes(ByVal mes As String) As Integer
        Dim meses() As String = New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        For x = 0 To meses.Length
            If mes = meses(x) Then
                Return x + 1
            End If
        Next
        Return -1
    End Function


    Function getIdServicio(ByVal descripcion As String) As Integer
        Dim sql As String = String.Format("SELECT idServicio FROM Servicio WHERE descripcion = '{0}'", descripcion)
        cmd.CommandText = sql
        lector = cmd.ExecuteReader()
        lector.Read()
        getIdServicio = lector(0)
        lector.Close()
        Return getIdServicio
    End Function


    Function getIdempleado(ByVal nombre As String) As Integer
        Dim sql As String = String.Format("SELECT idEmpleado FROM Empleado WHERE nombre = '{0}'", nombre)
        cmd.CommandText = sql
        lector = cmd.ExecuteReader()
        lector.Read()
        getIdempleado = lector(0)
        lector.Close()
        Return getIdempleado
    End Function

    Function getIdSituacion(ByVal descripcion As String) As Integer
        Dim sql As String = String.Format("SELECT idSituacion FROM Situacion WHERE descripcion = '{0}'", descripcion)
        cmd.CommandText = sql
        lector = cmd.ExecuteReader()
        lector.Read()
        getIdSituacion = lector(0)
        lector.Close()
        Return getIdSituacion
    End Function


    Function getIdTarifa(ByVal anio As String) As Integer
        Dim sql As String = String.Format("SELECT idTarifa FROM Tarifa WHERE anio = '{0}'", anio)
        cmd.CommandText = sql
        lector = cmd.ExecuteReader()
        lector.Read()
        getIdTarifa = lector(0)
        lector.Close()
        Return getIdTarifa
    End Function



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

        txtTotal.Text = totalAgua + totalServicios + txtOtros.Value


    End Sub



    Private Sub cmdSalir_Click_1(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        validarGuardar()
    End Sub

    Sub validarGuardar()
        If txtidCuenta.Text <> "" Then
            If dgAgua.Rows.Count > 0 Or dgServicios.Rows.Count > 0 Then
                cmdGrabar.Enabled = True
            End If
        End If
    End Sub


    Private Sub cmdCargarPagoAgua_Click(sender As Object, e As EventArgs) Handles cmdCargarPagoAgua.Click
        frmCargarPagoAgua.ShowDialog()
    End Sub

    Private Sub cmdCargarPagoServicios_Click(sender As Object, e As EventArgs) Handles cmdCargarPagoServicios.Click
        frmCargarPagoServicio.ShowDialog()
    End Sub


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdBuscarCuenta.Click
        frmBuscarCuenta.ShowDialog()
    End Sub


    Function getIdPago() As Integer
        Dim sql As String = "SELECT COUNT(idPago) FROM Pago;"
        cmd.CommandText = sql
        lector = cmd.ExecuteReader
        lector.Read()
        getIdPago = lector(0)
        lector.Close()
        Return getIdPago
    End Function



    Private Sub txtOtros_ValueChanged(sender As Object, e As EventArgs) Handles txtOtros.ValueChanged
        CalcularTotal()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        txtFecha.Text = System.DateTime.Today.ToLongDateString
        txtidPago.Text = getIdPago() + 1

        txtidCuenta.Clear()
        txtNombre.Clear()
        txtDomicilio.Clear()
        txtFechaAlta.Clear()
        txtUltimoPeriodoPagado.Clear()

        dgAgua.Rows.Clear()
        dgServicios.Rows.Clear()

        txtTotal.Text = 0
        txtOtros.Value = 0

        cmdImprimir.Enabled = False
        cmdGrabar.Enabled = False

        cmdNuevo.Enabled = False


    End Sub
End Class