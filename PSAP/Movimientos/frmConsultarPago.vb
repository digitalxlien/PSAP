Imports System.Data.SqlClient

Public Class frmConsultarPago

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As New SqlCommand("")
    Dim lector As SqlDataReader
    Dim meses() As String = New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}

    Private Sub frmConsultarPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        cmd.Connection = conexion
    End Sub



    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click


        Dim sql As String = "select Pago.idPago, pago.idCuenta, Cuenta.nombre, pago.fecha, pago.tipo, pago.total from pago inner join Cuenta on pago.idCuenta = cuenta.idCuenta "
        dgPagos.Rows.Clear()
        Select True

            Case rbtnIdPago.Checked
                If Not txtidPago.Text = "" Then
                    sql = sql + String.Format(" where Pago.idPago = {0};", txtidPago.Text)
                End If

            Case rbtnIdCuenta.Checked
                'sql = sql + String.Format(" where Cuenta.Nombre like '%{0}%';", txtidCuenta.Text)
                If Not txtidCuenta.Text = "" Then
                    sql = sql + String.Format(" where Cuenta.idCuenta = {0};", txtidCuenta.Text)
                End If


            Case rbtnTodos.Checked
                'MessageBox.Show("Seleccion un filtro en la busqueda", "Seleccione una opción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

        cmd.CommandText = sql

        lector = cmd.ExecuteReader

        While lector.Read()
            dgPagos.Rows.Add(lector(0), lector(1), lector(2), lector(3), gettipo(lector(4)), lector(5))
        End While

        lector.Close()


        If dgPagos.Rows.Count > 0 Then
            cmdDetalles.Enabled = True
        Else
            cmdDetalles.Enabled = False
        End If


    End Sub

    


    Private Sub cmdDetalles_Click(sender As Object, e As EventArgs) Handles cmdDetalles.Click


        Dim idPago As Integer = dgPagos.Rows.Item(dgPagos.CurrentCell.RowIndex).Cells(0).Value
        Dim fecha As String = dgPagos.Rows.Item(dgPagos.CurrentCell.RowIndex).Cells(3).Value
        Dim idCuenta As Integer = dgPagos.Rows.Item(dgPagos.CurrentCell.RowIndex).Cells(1).Value
        Dim total As Double = dgPagos.Rows.Item(dgPagos.CurrentCell.RowIndex).Cells(5).Value

        frmConsultarDetallePagos.dgAgua.Rows.Clear()
        frmConsultarDetallePagos.dgServicios.Rows.Clear()


        cmd.CommandText = String.Format("Select otros from pago where idPago = {0}", idPago)
        lector = cmd.ExecuteReader
        lector.Read()
        frmConsultarDetallePagos.txtOtros.Text = lector(0)

        lector.Close()

        cmd.CommandText = String.Format("Select * from Cuenta where idCuenta = {0}", idCuenta)

        lector = cmd.ExecuteReader

        lector.Read()

        frmConsultarDetallePagos.txtidPago.Text = idPago
        frmConsultarDetallePagos.txtFecha.Text = fecha
        frmConsultarDetallePagos.txtTotal.Text = total


        frmConsultarDetallePagos.txtidCuenta.Text = lector(0)
        frmConsultarDetallePagos.txtNombre.Text = lector(2)
        frmConsultarDetallePagos.txtFechaAlta.Text = lector(5)
        frmConsultarDetallePagos.txtUltimoPeriodoPagado.Text = lector(7) & " / " & lector(6)

        lector.Close()




        cmd.CommandText = String.Format("select tarifa.anio,  detPagoAgua.mesInicial, detPagoAgua.mesfinal, detPagoAgua.cuotafija,  detPagoAgua.recargos,  detPagoAgua.tar, detPagoAgua.infra, Situacion.descripcion, detPagoAgua.descuento " & _
        "from detPagoAgua inner join Tarifa on detPagoAgua.idtarifa = Tarifa.idTarifa inner join Situacion on situacion.idSituacion = detPagoAgua.idsituacion " & _
        "where DetPagoAgua.idPago = {0}", idPago)

        lector = cmd.ExecuteReader


        While lector.Read
            frmConsultarDetallePagos.dgAgua.Rows.Add(lector(0), meses(lector(1) - 1), meses(lector(2) - 1), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), calcularImporte(lector(3), lector(4), lector(5), lector(6)))
        End While

        lector.Close()


        cmd.CommandText = String.Format("Select Servicio.descripcion, Empleado.nombre, DetPagoServicio.precio from DetPagoServicio " &
                            "inner join Servicio on Servicio.idServicio = DetPagoServicio.idServicio " & _
                            "inner join empleado on Empleado.idEmpleado = DetPagoServicio.idEmpleado " & _
                            "where DetPagoServicio.idPago = {0}", idPago)

        lector = cmd.ExecuteReader

        While lector.Read
            frmConsultarDetallePagos.dgServicios.Rows.Add(lector(0), lector(1), lector(2))
        End While


        lector.Close()

        frmConsultarDetallePagos.ShowDialog()

        'conexion.Close()


    End Sub

    Function calcularImporte(cuotaFija As Double, recargos As Double, tar As Double, infra As Double) As Integer
        Return cuotaFija + recargos + tar + infra
    End Function



    Private Sub txtidCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidCuenta.KeyPress
        Dim CadenaValida As String = "1234567890"
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub



    Private Sub txtidPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidPago.KeyPress
        Dim CadenaValida As String = "1234567890"
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub




    Private Sub rbtnIdCuenta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIdCuenta.CheckedChanged
        txtidCuenta.Enabled = True
        txtidPago.Enabled = False
        txtidCuenta.Text = ""
        txtidCuenta.Focus()
    End Sub

    Private Sub rbtnIdPago_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIdPago.CheckedChanged
        txtidCuenta.Enabled = False
        txtidPago.Enabled = True
        txtidPago.Text = ""
        txtidPago.Focus()
    End Sub

    Private Sub rbtnTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTodos.CheckedChanged
        txtidCuenta.Enabled = False
        txtidPago.Enabled = False
        txtidCuenta.Text = ""
        txtidPago.Text = ""
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
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


    Function gettipo(tipo As Integer) As String

        If tipo = 1 Then
            Return "Agua"
        End If

        If tipo = 2 Then
            Return "Servicio"
        End If

        Return "Agua y servicio"

    End Function


End Class