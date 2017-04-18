Imports System.Data.SqlClient
Public Class frmEntradaMaterial

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader

    Private Sub frmEntradaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()

        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand("SELECT nombre FROM Proveedor ORDER BY nombre ASC", conexion)


        lector = cmd.ExecuteReader

        While lector.Read
            cboxProveedor.Items.Add(lector(0))
        End While
        lector.Close()


        cmd.CommandText = "SELECT descripcion FROM Material ORDER BY descripcion ASC;"
        lector = cmd.ExecuteReader
        While lector.Read
            cboxMaterial.Items.Add(lector(0))
            MessageBox.Show(lector(0))
        End While
        lector.Close()
        cboxMaterial.SelectedIndex = 0
        cboxProveedor.SelectedIndex = 0


    End Sub

    Private Sub cboxProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxProveedor.SelectedIndexChanged
        txtidProveedor.Text = getIdProveedor(cboxProveedor.Text)
        txtTelefono.Text = getTelefonoProveedor(cboxProveedor.Text)
        txtDomicilio.Text = getDomicilioProveedor(cboxProveedor.Text)
    End Sub

    Private Sub cboxMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxMaterial.SelectedIndexChanged
        txtidMaterial.Text = getIdMaterial(cboxMaterial.Text)
        txtExistencia.Text = getExistenciaMaterial(cboxMaterial.Text)
        txtMinimo.Text = getMinimoMaterial(cboxMaterial.Text)
        txtMaximo.Text = getMaximoMaterial(cboxMaterial.Text)
        txtCostoAnterior.Text = getCostoMaterial(cboxMaterial.Text)
        txtUnidades.Text = getUnidadMedidaMaterial(cboxMaterial.Text)


    End Sub

    
    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim total As Integer
        Dim iva As Double
        dgDetalleEntradaMaterial.Rows.Add(txtidMaterial.Text, cboxMaterial.Text, txtCantidad.Value, txtCosto.Value, txtCantidad.Value * txtCosto.Value)

        total = autosuma(dgDetalleEntradaMaterial, "importe")
        iva = total * 0.16
        txtSubtotal.Text = total - iva
        txtIva.Text = iva
        txtTotal.Text = total
    End Sub

    Function autosuma(ByRef dg As DataGridView, ByVal colunma As String) As Decimal
        Dim total As Decimal = 0

        For x = 0 To dg.Rows.Count - 1
            total = total + dg.Item(colunma, x).Value
        Next

        Return total
    End Function


    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim sql As String

        If dgDetalleEntradaMaterial.Rows.Count > 0 Then

            'Grabado de CompraMaterial :
            sql = String.Format("INSERT INTO CompraMaterial ( idProveedor, factura, fecha, subtotal, iva, total) VALUES ('{0}', '{1}',  '{2}',  '{3}', '{4}',  '{5}') ", txtidProveedor.Text, _
                                txtFactura.Text, dtpFecha.Value.ToShortDateString, txtSubtotal.Text, txtIva.Text, txtTotal.Text)

            Dim cmd As New SqlCommand(sql, conexion)
            cmd.ExecuteNonQuery()

            'Grabado del DetalleCompraMaterial:
            For x = 0 To dgDetalleEntradaMaterial.Rows.Count - 1
                'Insercion en la tabla.
                sql = String.Format("INSERT INTO DetCompraMaterial (idCompraMaterial, idMaterial, cantidad, costo) VALUES ('{0}', '{1}',  '{2}',  '{3}') ", _
                                    txtidEntradaMaterial.Text, dgDetalleEntradaMaterial.Item("idMaterial", x).Value, dgDetalleEntradaMaterial.Item("cantidad", x).Value, dgDetalleEntradaMaterial.Item("costo", x).Value)
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()


                'MessageBox.Show("id: " & getExistenciaMaterial(dgDetalleEntradaMaterial.Item("material", x).Value))
                'Actualizacion de la información:
                sql = String.Format("UPDATE Material SET existencia = '{0}', costo = '{1}', fechaUltimaCompra = '{2}' WHERE idMaterial = '{3}';", _
                                    getExistenciaMaterial(dgDetalleEntradaMaterial.Item("material", x).Value) + dgDetalleEntradaMaterial.Item("cantidad", x).Value, _
                                    dgDetalleEntradaMaterial.Item("costo", x).Value, dtpFecha.Value.ToShortDateString, dgDetalleEntradaMaterial.Item("idMaterial", x).Value)

                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

            Next

            limpiarFormulario()
            activarFormulario(False)
            cboxMaterial.SelectedIndex = 0
            cboxProveedor.SelectedIndex = 0
        Else
            MessageBox.Show("Registre al menos un material en la compra", "Complete el formulario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub



    Sub activarFormulario(ByVal flag As Boolean)
        txtFactura.Enabled = flag
        dtpFecha.Enabled = flag
        cboxProveedor.Enabled = flag
        cboxMaterial.Enabled = flag
        txtCantidad.Enabled = flag
        txtCosto.Enabled = flag
        cmdAgregar.Enabled = flag
        cmdGrabar.Enabled = flag
        cmdNuevo.Enabled = Not flag
    End Sub





    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim cmd As New SqlCommand("SELECT nombre FROM Proveedor ORDER BY nombre ASC", conexion)

        cmd.CommandText = "SELECT COUNT(*) FROM CompraMaterial;"
        lector = cmd.ExecuteReader
        lector.Read()
        txtidEntradaMaterial.Text = CInt(lector(0)) + 1
        lector.Close()

        activarFormulario(True)
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub



    Sub limpiarFormulario()
        txtidEntradaMaterial.Clear()
        txtFactura.Clear()
        dtpFecha.Update()

        txtidProveedor.Clear()
        txtTelefono.Clear()
        txtDomicilio.Clear()

        txtCostoAnterior.Clear()
        txtMaximo.Clear()
        txtMinimo.Clear()
        txtCantidad.Value = 0
        txtCosto.Value = 0
        txtUnidades.Clear()
        dgDetalleEntradaMaterial.Rows.Clear()

        txtSubtotal.Clear()
        txtIva.Clear()
        txtTotal.Clear()

    End Sub




    Function getIdProveedor(ByVal nombre As String) As Integer
        Dim aux As Integer
        Dim sql = String.Format("SELECT idProveedor FROM Proveedor WHERE nombre = '{0}'", nombre)
        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader
        lector.Read()
        aux = lector(0)
        lector.Close()
        Return aux
    End Function

    Function getTelefonoProveedor(ByVal nombre As String) As String
        Dim aux As String
        Dim sql As String = String.Format("SELECT telefono FROM Proveedor WHERE nombre = '{0}'", nombre)
        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader
        lector.Read()
        aux = lector(0)
        lector.Close()
        Return aux
    End Function

    Function getDomicilioProveedor(ByVal nombre As String) As String
        Dim aux As String
        Dim sql = String.Format("SELECT calle FROM Proveedor WHERE nombre = '{0}'", nombre)
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

    Function getcostoMaterial(ByVal nombre As String) As Decimal
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

End Class