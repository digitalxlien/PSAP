Imports System.Data.SqlClient
Public Class frmSalidaMaterial


    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader


    Private Sub frmSalidaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()

        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand("SELECT nombre FROM Empleado ORDER BY nombre ASC", conexion)


        lector = cmd.ExecuteReader

        While lector.Read
            cboxEmpleado.Items.Add(lector(0))
        End While
        lector.Close()

        cmd.CommandText = "SELECT nombre FROM Calle ORDER BY nombre ASC;"
        lector = cmd.ExecuteReader
        While lector.Read
            cboxCalle.Items.Add(lector(0))
        End While
        lector.Close()

        cmd.CommandText = "SELECT descripcion FROM Material ORDER BY descripcion ASC;"
        lector = cmd.ExecuteReader
        While lector.Read
            cboxMaterial.Items.Add(lector(0))
        End While
        lector.Close()


        cboxMaterial.SelectedIndex = 0
        cboxEmpleado.SelectedIndex = 0
        cboxCalle.SelectedIndex = 0

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim cmd As New SqlCommand()

        cmd.Connection = conexion
        cmd.CommandText = "SELECT COUNT(*) FROM SalidaMaterial;"
        lector = cmd.ExecuteReader
        lector.Read()
        txtidSalidaMaterial.Text = CInt(lector(0)) + 1
        lector.Close()
        activarFormulario(True)
        txtConcepto.Focus()
    End Sub

    Sub activarFormulario(ByVal flag As Boolean)

        dtpFecha.Enabled = flag
        cboxCalle.Enabled = flag
        cboxEmpleado.Enabled = flag
        cboxMaterial.Enabled = flag
        txtCantidad.Enabled = flag
        label34.Enabled = flag
        txtConcepto.Enabled = flag
        cmdAgregar.Enabled = flag
        cmdGrabar.Enabled = flag
        cmdNuevo.Enabled = Not flag

    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim total As Integer

        If txtCantidad.Value > 0 Then
            dgDetalleSalidaMaterial.Rows.Add(txtidMaterial.Text, cboxMaterial.Text, txtCantidad.Value, CDbl(txtCosto.Text), txtCantidad.Value * CDbl(txtCosto.Text))

            total = autosuma(dgDetalleSalidaMaterial, "importe")
            txtTotal.Text = total

        Else
            MessageBox.Show("Agregue la cantidad mayor a 0.", "Agregue una cantidad correcta.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Function autosuma(ByRef dg As DataGridView, ByVal colunma As String) As Decimal
        Dim total As Decimal = 0

        For x = 0 To dg.Rows.Count - 1
            total = total + dg.Item(colunma, x).Value
        Next

        Return total
    End Function

    Private Sub cboxMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxMaterial.SelectedIndexChanged
        txtidMaterial.Text = getIdMaterial(cboxMaterial.Text)
        txtExistencia.Text = getExistenciaMaterial(cboxMaterial.Text)
        txtMinimo.Text = getMinimoMaterial(cboxMaterial.Text)
        txtMaximo.Text = getMaximoMaterial(cboxMaterial.Text)
        txtCosto.Text = getCostoMaterial(cboxMaterial.Text)
        txtUnidades.Text = getUnidadMedidaMaterial(cboxMaterial.Text)
        txtCantidad.Value = 1
        txtCantidad.Focus()
    End Sub

    Function getIdEmpleado(ByVal nombre As String) As Integer
        Dim aux As Integer
        Dim sql = String.Format("SELECT idEmpleado FROM Empleado WHERE nombre = '{0}'", nombre)
        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader
        lector.Read()
        aux = lector(0)
        lector.Close()
        Return aux
    End Function

    Function getIdCalle(ByVal nombre As String) As Integer
        Dim aux As Integer
        Dim sql = String.Format("SELECT idCalle FROM Calle WHERE nombre = '{0}'", nombre)
        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader
        lector.Read()
        aux = lector(0)
        lector.Close()
        Return aux
    End Function

    Function getIdMaterial(ByVal nombre As String) As Integer
        Dim aux As Integer
        Dim sql = String.Format("SELECT idMaterial FROM Material WHERE descripcion = '{0}'", nombre)
        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader
        lector.Read()
        aux = lector(0)
        lector.Close()
        Return aux
    End Function

    Function getExistenciaMaterial(ByVal nombre As String) As Decimal
        Dim aux As Decimal
        Dim sql = String.Format("SELECT existencia FROM Material WHERE descripcion = '{0}'", nombre)
        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader
        lector.Read()
        aux = lector(0)
        lector.Close()
        Return aux
    End Function

    Function getMinimoMaterial(ByVal nombre As String) As Decimal
        Dim aux As Decimal
        Dim sql = String.Format("SELECT minimo FROM Material WHERE descripcion = '{0}'", nombre)
        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader
        lector.Read()
        aux = lector(0)
        lector.Close()
        Return aux
    End Function

    Function getMaximoMaterial(ByVal nombre As String) As Decimal
        Dim aux As Decimal
        Dim sql = String.Format("SELECT maximo FROM Material WHERE descripcion = '{0}'", nombre)
        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader
        lector.Read()
        aux = lector(0)
        lector.Close()
        Return aux
    End Function

    Function getCostoMaterial(ByVal nombre As String) As Decimal
        Dim aux As Decimal
        Dim sql = String.Format("SELECT costo FROM Material WHERE descripcion = '{0}'", nombre)
        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader
        lector.Read()
        aux = lector(0)
        lector.Close()
        Return aux
    End Function

    Function getUnidadMedidaMaterial(ByVal nombre As String) As String
        Dim aux As String
        Dim sql = String.Format("SELECT unidadMedida FROM Material WHERE descripcion = '{0}'", nombre)
        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader
        lector.Read()
        aux = lector(0)
        lector.Close()
        Return aux
    End Function


    Sub limpiarFormulario()
        txtidSalidaMaterial.Clear()
        dtpFecha.Update()

        txtMaximo.Clear()
        txtMinimo.Clear()
        txtCantidad.Value = 0
        txtCosto.Text = 0
        txtUnidades.Clear()
        dgDetalleSalidaMaterial.Rows.Clear()

        txtTotal.Clear()

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim sql As String
        Dim nombreMaterial As String

        If dgDetalleSalidaMaterial.Rows.Count > 0 Then


            'Grabado de SalidaMaterial :
            sql = String.Format("INSERT INTO SalidaMaterial (idEmpleado, idCalle, fecha,  concepto) VALUES ('{0}', '{1}',  '{2}',  '{3}') ", _
                                getIdEmpleado(cboxEmpleado.Text), getIdCalle(cboxCalle.Text), dtpFecha.Value.ToShortDateString, txtConcepto.Text)

            Dim cmd As New SqlCommand(sql, conexion)
            cmd.ExecuteNonQuery()


            'Grabado de DetalleSalidaMaterial
            For x = 0 To dgDetalleSalidaMaterial.Rows.Count - 1

                nombreMaterial = dgDetalleSalidaMaterial.Item("material", x).Value

                'Insercion en la tabla.
                sql = String.Format("INSERT INTO DetSalidaMaterial (idSalidaMaterial, idMaterial, cantidad, costo) VALUES ('{0}', '{1}',  '{2}',  '{3}') ", _
                                    txtidSalidaMaterial.Text, dgDetalleSalidaMaterial.Item("idMaterial", x).Value, dgDetalleSalidaMaterial.Item("cantidad", x).Value, dgDetalleSalidaMaterial.Item("costo", x).Value)
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

                'Actualizacion de existencias:
                sql = String.Format("UPDATE Material SET existencia = '{0}' WHERE idMaterial = '{1}';", getExistenciaMaterial(nombreMaterial) - dgDetalleSalidaMaterial.Item("cantidad", x).Value, dgDetalleSalidaMaterial.Item("idMaterial", x).Value)
                'MessageBox.Show("SQL de update:   " & sql)

                cmd.CommandText = sql
                cmd.ExecuteNonQuery()


            Next

            limpiarFormulario()
            activarFormulario(False)
            cboxMaterial.SelectedIndex = 0
            cboxCalle.SelectedIndex = 0
            cboxEmpleado.SelectedIndex = 0

        Else
            MessageBox.Show("Agregue al menos un material de salida", "Agregue materiales", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




    End Sub








End Class