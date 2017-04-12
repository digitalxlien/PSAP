Public Class frmCalles

    Private Sub frmCalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetPSAP.Calle' Puede moverla o quitarla según sea necesario.
        Me.CalleTableAdapter.Fill(Me.DataSetPSAP.Calle)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        CalleBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        CalleBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        CalleBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        CalleBindingSource.MoveLast()
    End Sub


    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        'Generar ID
        Dim total As Integer
        total = CalleBindingSource.Count + 1
        txtidCalle.Text = total.ToString

        'Agregar nuevo al BindingSource
        CalleBindingSource.AddNew()

        'Habilitar controles
        txtCalle.Enabled = True
        txtColonia.Enabled = True
        txtCodigoPostal.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        dgCalle.Enabled = False
        dgCalle.Enabled = False
        txtCalle.Focus()
        EnableNavigator(False)


    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        'Habilitar botones
        txtCalle.Enabled = False
        txtColonia.Enabled = False
        txtCodigoPostal.Enabled = False
        dgCalle.Enabled = True

        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        EnableNavigator(True)

        'Colocar datos por default:
        CalleBindingSource.Current(4) = 0

        'Refrescar
        dgCalle.Refresh()


    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        'Cierre de flujo
        CalleBindingSource.EndEdit()

        'Actualizar en TableAdapter
        CalleTableAdapter.Update(DataSetPSAP.Calle)

        Dispose()
    End Sub

    Private Sub EnableNavigator(flag As Boolean)
        cmdInicio.Enabled = flag
        cmdSiguiente.Enabled = flag
        cmdAnterior.Enabled = flag
        cmdUltimo.Enabled = flag
    End Sub


    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        CalleBindingSource.CancelEdit()
        'Habilitar botones
        txtCalle.Enabled = False
        txtColonia.Enabled = False
        txtCodigoPostal.Enabled = False
        dgCalle.Enabled = True

        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        EnableNavigator(True)
        cmdCancelar.Enabled = False
    End Sub
End Class