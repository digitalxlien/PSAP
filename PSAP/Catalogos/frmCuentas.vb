Public Class frmCuentas

    Private Sub frmCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetPSAP.Calle' Puede moverla o quitarla según sea necesario.
        Me.CalleTableAdapter.Fill(Me.DataSetPSAP.Calle)
        'TODO: esta línea de código carga datos en la tabla 'DataSetPSAP.Cuenta' Puede moverla o quitarla según sea necesario.
        Me.CuentaTableAdapter.Fill(Me.DataSetPSAP.Cuenta)

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        'Habiitar botones
        txtNombre.Enabled = True
        cboxCalle.Enabled = False
        txtColonia.Enabled = False
        txtCodigoPostal.Enabled = False
        txtNumExt.Enabled = False
        txtNumInt.Enabled = False
        dtpFechaUltimaCompra.Enabled = False
        EnableNavigator(True)

        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        cmdCancelar.Enabled = False
        dgCuentas.Enabled = True


        'Cuentas.idCalle = Id de la calle
        CuentaBindingSource.Current(1) = cboxCalle.SelectedValue


        'Incremento de Calle.totalCasas:
        Dim pos As Integer
        pos = CalleBindingSource.Find("idCalle", cboxCalle.SelectedValue)
        CalleBindingSource.Position = pos
        CalleBindingSource.Current(4) = CalleBindingSource.Current(4) + 1

        CalleBindingSource.EndEdit()
        CalleTableAdapter.Update(DataSetPSAP.Calle)

        dgCuentas.Refresh()

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        'Generar id
        Dim idCuenta As Integer
        idCuenta = CuentaBindingSource.Count + 1
        txtidCuenta.Text = idCuenta

        'Agregar nuevo
        CuentaBindingSource.AddNew()

        'Habilitar botones
        txtNombre.Enabled = True
        cboxCalle.Enabled = True
        txtColonia.Enabled = True
        txtCodigoPostal.Enabled = True

        txtNumExt.Enabled = True
        txtNumInt.Enabled = True
        dtpFechaUltimaCompra.Enabled = True
        cmdGrabar.Enabled = True
        cmdNuevo.Enabled = False
        cmdCancelar.Enabled = True
        dgCuentas.Enabled = False
        EnableNavigator(False)
        txtNombre.Focus()


    End Sub



    Private Sub EnableNavigator(flag As Boolean)
        cmdInicio.Enabled = flag
        cmdSiguiente.Enabled = flag
        cmdAnterior.Enabled = flag
        cmdUltimo.Enabled = flag
    End Sub


    Private Sub cboxCalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxCalle.SelectedIndexChanged


        Try
            Dim pos As Integer
            pos = CalleBindingSource.Find("idCalle", cboxCalle.SelectedValue)

            CalleBindingSource.Position = pos

            txtColonia.Text = CalleBindingSource.Current(2)
            txtCodigoPostal.Text = CalleBindingSource.Current(3)
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try


        


    End Sub



    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        CuentaBindingSource.EndEdit()
        CuentaTableAdapter.Update(DataSetPSAP.Cuenta)

        Dispose()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        CuentaBindingSource.CancelEdit()
        CalleBindingSource.EndEdit()

        txtNombre.Enabled = True
        cboxCalle.Enabled = False
        txtColonia.Enabled = False
        txtCodigoPostal.Enabled = False
        txtNumExt.Enabled = False
        txtNumInt.Enabled = False
        dtpFechaUltimaCompra.Enabled = False
        EnableNavigator(True)

        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        cmdCancelar.Enabled = False
        dgCuentas.Enabled = True

    End Sub
End Class