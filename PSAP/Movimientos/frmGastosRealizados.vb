
Imports System.Data.SqlClient

Public Class frmGastosRealizados

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader
    Dim aux_idGasto As Integer = -1
    Dim aux_idEmpleado As Integer = -1


    Private Sub frmGastosRealizados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        conexion.Close()
        lector.Close()
    End Sub

    Private Sub frmGastosRealizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        CargarCboxConcepto(cboxConcepto)
        CargarCboxEmpleado(cboxEmpleado)

        CargarCboxConcepto(cboxConsultaConcepto)
        CargarCboxEmpleado(cboxConsultaEmpleado)

        cboxEmpleado.SelectedIndex = 0
        cboxConcepto.SelectedIndex = 0
    End Sub

    Sub CargarCboxConcepto(ByRef cbox As ComboBox)
        'Cargar al cboxEmpleados los empleados el catalogo
        cmd = New SqlCommand("SELECT concepto FROM Gasto;", conexion)
        lector = cmd.ExecuteReader()
        While lector.Read()
            cbox.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

   

    Sub CargarCboxEmpleado(ByRef cbox As ComboBox)
        'Cargar al cboxEmpleados los empleados el catalogo
        cmd = New SqlCommand("SELECT nombre FROM Empleado;", conexion)
        lector = cmd.ExecuteReader()
        While lector.Read()
            cbox.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub cboxEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxEmpleado.SelectedIndexChanged

        Dim sql As String = String.Format("SELECT idEmpleado, calle, telefono FROM Empleado WHERE nombre = '{0}';", cboxEmpleado.Text)
        cmd = New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader()

        lector.Read()

        txtDomicilio.Text = lector("calle")
        txtTelefono.Text = lector("telefono")
        aux_idEmpleado = lector("idEmpleado")
        lector.Close()

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim idGastoRealizado As Integer
        cmd = New SqlCommand("SELECT COUNT(*) AS total from GastoRealizado", conexion)
        lector = cmd.ExecuteReader
        lector.Read()
        idGastoRealizado = lector(0)
        txtidGastoRealizado.Text = idGastoRealizado + 1

        dtpFecha.Enabled = True
        cboxEmpleado.Enabled = True
        cboxConcepto.Enabled = True

        txtImporte.Enabled = True
        txtObservaciones.Enabled = True

        cmdNuevo.Enabled = False

        lector.Close()
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim fecha As String = dtpFecha.Value.ToShortDateString
        Dim importe As Decimal = txtImporte.Text
        Dim observaciones As String = txtObservaciones.Text

        If observaciones = "" Then
            observaciones = "Sin observaciones."
        End If

        Dim sql As String = String.Format("INSERT INTO gastoRealizado (idGasto, idEmpleado, fecha, importe, observaciones) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');", aux_idGasto, aux_idEmpleado, fecha, importe, observaciones)
        MessageBox.Show(sql)


        cmd.CommandText = sql
        cmd.ExecuteNonQuery()

        txtidGastoRealizado.Text = ""

        dtpFecha.Enabled = False
        cboxConcepto.SelectedIndex = 0
        cboxEmpleado.SelectedIndex = 0
        cboxEmpleado.Enabled = False
        cboxConcepto.Enabled = False

        txtImporte.Enabled = False
        txtImporte.Value = 0

        txtDomicilio.Text = ""
        txtTelefono.Text = ""

        txtObservaciones.Enabled = False
        txtObservaciones.Text = ""
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True

        consultaGeneral()

    End Sub

    Private Sub cboxConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxConcepto.SelectedIndexChanged
        Dim sql As String = String.Format("SELECT * FROM Gasto WHERE concepto = '{0}';", cboxConcepto.Text)
        cmd = New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader()

        lector.Read()

        'MessageBox.Show(lector(0))
        aux_idGasto = lector(0)

        lector.Close()
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim sql As String = "SELECT	GastoRealizado.idGastoRealizado, GastoRealizado.fecha, GastoRealizado.idEmpleado, Empleado.nombre,  Gasto.concepto, GastoRealizado.importe, GastoRealizado.observaciones from GastoRealizado inner join Empleado  on GastoRealizado.idEmpleado = Empleado.idEmpleado inner join Gasto on Gasto.idGasto = GastoRealizado.idGasto "
        dgGastosRealizados.Rows.Clear()

        Select Case True
            Case rbtnConcepto.Checked
                'MessageBox.Show("Concepto Seleccionado")
                sql = sql + String.Format("where Gasto.concepto = '{0}'", cboxConsultaConcepto.Text)

            Case rbtnEmpleado.Checked
                'MessageBox.Show("Empleado Seleccionado")
                sql = sql + String.Format("where empleado.nombre = '{0}'", cboxConsultaEmpleado.Text)
            Case rbtnFecha.Checked
                'MessageBox.Show("Fecha Seleccionado")
                sql = sql + String.Format("where fecha = '{0}'", dtpConsultaFecha.Value.ToShortDateString)

            Case rbtnTodos.Checked
                'MessageBox.Show("Todos Seleccionado")

            Case Else
                MessageBox.Show("Seleccion un filtro en la busqueda", "Seleccione una opción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

        cmd.CommandText = sql

        lector = cmd.ExecuteReader

        While lector.Read()
            dgGastosRealizados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While

        lector.Close()


    End Sub

    Private Sub rbtnFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFecha.CheckedChanged
        dtpConsultaFecha.Enabled = True
        cboxConsultaConcepto.Enabled = False
        cboxConsultaEmpleado.Enabled = False
    End Sub

    Private Sub rbtnConcepto_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnConcepto.CheckedChanged
        dtpConsultaFecha.Enabled = False
        cboxConsultaConcepto.Enabled = True
        cboxConsultaEmpleado.Enabled = False
    End Sub

    Private Sub rbtnEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnEmpleado.CheckedChanged
        dtpConsultaFecha.Enabled = False
        cboxConsultaConcepto.Enabled = False
        cboxConsultaEmpleado.Enabled = True
    End Sub

    Private Sub rbtnTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTodos.CheckedChanged
        dtpConsultaFecha.Enabled = False
        cboxConsultaConcepto.Enabled = False
        cboxConsultaEmpleado.Enabled = False
    End Sub

    Sub consultaGeneral()
        Dim sql As String = "SELECT	GastoRealizado.idGasto, GastoRealizado.fecha, GastoRealizado.idEmpleado, Empleado.nombre,  Gasto.concepto, GastoRealizado.importe, GastoRealizado.observaciones from GastoRealizado inner join Empleado  on GastoRealizado.idEmpleado = Empleado.idEmpleado inner join Gasto on Gasto.idGasto = GastoRealizado.idGasto "
        dgGastosRealizados.Rows.Clear()

        Select Case True
            Case rbtnConcepto.Checked
                'MessageBox.Show("Concepto Seleccionado")
                sql = sql + String.Format("where Gasto.concepto = '{0}'", cboxConsultaConcepto.Text)

            Case rbtnEmpleado.Checked
                'MessageBox.Show("Empleado Seleccionado")
                sql = sql + String.Format("where empleado.nombre = '{0}'", cboxConsultaEmpleado.Text)
            Case rbtnFecha.Checked
                'MessageBox.Show("Fecha Seleccionado")
                sql = sql + String.Format("where fecha = '{0}'", dtpConsultaFecha.Value.ToShortDateString)

            Case rbtnTodos.Checked
                'MessageBox.Show("Todos Seleccionado")

            Case Else
                MessageBox.Show("Seleccion un filtro en la busqueda", "Seleccione una opción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

        cmd.CommandText = sql

        lector = cmd.ExecuteReader

        While lector.Read()
            dgGastosRealizados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While

        lector.Close()

    End Sub



End Class