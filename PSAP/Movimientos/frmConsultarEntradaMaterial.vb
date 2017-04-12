Imports System.Data.SqlClient

Public Class frmConsultarEntradaMaterial

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader



    Private Sub frmConsultarEntradaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        CargarCboxProveedor(cboxConsultaProveedor)
        cboxConsultaProveedor.SelectedIndex = 0
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim sql As String = "SELECT CompraMaterial.idCompraMaterial, CompraMaterial.factura, CompraMaterial.idProveedor, Proveedor.nombre, CompraMaterial.fecha, CompraMaterial.subtotal, CompraMaterial.iva, CompraMaterial.total from CompraMaterial inner join Proveedor on CompraMaterial.idProveedor = Proveedor.idProveedor "
        
        dgCompraMaterial.Rows.Clear()

        Select Case True

            Case rbtnFecha.Checked
                'MessageBox.Show("Fecha Seleccionado")
                sql = sql + String.Format("where fecha = '{0}'", dtpConsultaFecha.Value.ToShortDateString)


            Case rbtnProveedor.Checked
                'MessageBox.Show("Concepto Seleccionado")
                sql = sql + String.Format("WHERE proveedor.nombre = '{0}'", cboxConsultaProveedor.Text)

            Case rbtnFactura.Checked
                'MessageBox.Show("Empleado Seleccionado")
                sql = sql + String.Format("where CompraMaterial.factura = '{0}'", txtConsultaFactura.Text)

            Case rbtnTodos.Checked
                'MessageBox.Show("Todos Seleccionado")

            Case Else
                MessageBox.Show("Seleccion un filtro en la busqueda", "Seleccione una opción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select



        cmd = New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader





        While lector.Read()
            dgCompraMaterial().Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While

        lector.Close()



        If dgCompraMaterial.Rows.Count > 0 Then
            cmdDetalles.Enabled = True
        Else
            cmdDetalles.Enabled = False
        End If



    End Sub

    Sub CargarCboxProveedor(ByRef cbox As ComboBox)

        'Cargar al cboxEmpleados los empleados el catalogo
        cmd = New SqlCommand("SELECT nombre FROM Proveedor order by nombre asc;", conexion)

        'MessageBox.Show("entra al metodo")
        lector = cmd.ExecuteReader()
        'MessageBox.Show("Se ejecuta el reader")
        While lector.Read()
            cbox.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub rbtnFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFecha.CheckedChanged
        dtpConsultaFecha.Enabled = True
        cboxConsultaProveedor.Enabled = False
        txtConsultaFactura.Enabled = False
        txtConsultaFactura.Clear()
    End Sub

    Private Sub rbtnProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnProveedor.CheckedChanged
        dtpConsultaFecha.Enabled = False
        cboxConsultaProveedor.Enabled = True
        txtConsultaFactura.Enabled = False
        txtConsultaFactura.Clear()
    End Sub

    Private Sub rbtnFactura_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFactura.CheckedChanged
        dtpConsultaFecha.Enabled = False
        cboxConsultaProveedor.Enabled = False
        txtConsultaFactura.Enabled = True
        txtConsultaFactura.Clear()
    End Sub

    Private Sub rbtnTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTodos.CheckedChanged
        dtpConsultaFecha.Enabled = False
        cboxConsultaProveedor.Enabled = False
        txtConsultaFactura.Enabled = False
        txtConsultaFactura.Clear()
    End Sub

    Private Sub cmdDetalles_Click(sender As Object, e As EventArgs) Handles cmdDetalles.Click

        Dim sql As String
        Dim idCompraMaterial As Integer = dgCompraMaterial.Rows.Item(dgCompraMaterial.CurrentCell.RowIndex).Cells(0).Value

        frmDetallesEntradaMaterial.dgDetalleEntradaMaterial.Rows.Clear()

        sql = String.Format("SELECT DetCompraMaterial.idMaterial, Material.descripcion, DetCompraMaterial.cantidad, DetCompraMaterial.costo FROM DetCompraMaterial inner join Material on DetCompraMaterial.idMaterial =  Material.idMaterial WHERE DetCompraMaterial.idCompraMaterial = '{0}'", idCompraMaterial)
        cmd.CommandText = sql

        lector = cmd.ExecuteReader()
        While lector.Read()
            frmDetallesEntradaMaterial.dgDetalleEntradaMaterial.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(2) * lector(3))
        End While
        frmDetallesEntradaMaterial.ShowDialog()
        lector.Close()

    End Sub


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub
End Class