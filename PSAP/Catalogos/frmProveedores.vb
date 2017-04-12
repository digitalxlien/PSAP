Public Class frmProveedores

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetPSAP.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.DataSetPSAP.Proveedor)


    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        'Generar ID
        Dim total As Integer
        total = ProveedorBindingSource.Count + 1
        txtidProveedor.Text = total.ToString

        'Agregar nuevo al BindingSource
        ProveedorBindingSource.AddNew()

        txtNombre.Enabled = True
        txtCalle.Enabled = True
        txtColonia.Enabled = True
        txtCodigoPostal.Enabled = True
        cboxEstado.Enabled = True
        txtTelefono.Enabled = True

        cmdGrabar.Enabled = True
        cmdNuevo.Enabled = False

        EnableNavigator(False)

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click


        txtNombre.Enabled = False
        txtCalle.Enabled = False
        txtColonia.Enabled = False
        txtCodigoPostal.Enabled = False
        cboxEstado.Enabled = False
        txtTelefono.Enabled = False

        cboxEstado.Text = "Jalisco"
        EnableNavigator(True)

        dgProveedor.Refresh()

        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True


    End Sub

    Private Sub EnableNavigator(flag As Boolean)
        cmdInicio.Enabled = flag
        cmdSiguiente.Enabled = flag
        cmdAnterior.Enabled = flag
        cmdUltimo.Enabled = flag
    End Sub


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        'Cierre de flujo
        ProveedorBindingSource.EndEdit()

        'Actualizar en TableAdapter
        ProveedorTableAdapter.Update(DataSetPSAP.Proveedor)

        Dispose()
    End Sub
End Class