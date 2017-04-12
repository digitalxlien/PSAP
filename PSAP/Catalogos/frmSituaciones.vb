Public Class frmSituaciones

    Private Sub frmSituaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetPSAP.Situacion' Puede moverla o quitarla según sea necesario.
        Me.SituacionTableAdapter.Fill(Me.DataSetPSAP.Situacion)

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim total As Integer
        total = SituacionBindingSource.Count + 1
        txtidSituacion.Text = total.ToString

        SituacionBindingSource.AddNew()

        txtDescripcion.Enabled = True
        txtDescuento.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True

        EnableNavigator(False)

        txtDescripcion.Focus()

        'tikismikis:
        txtDescuento.ResetText()

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        txtDescripcion.Enabled = False
        txtDescuento.Enabled = False
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        EnableNavigator(True)

        'Refrescar
        dgSituaciones.Refresh()

    End Sub
    
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        'Cierre de flujo
        SituacionBindingSource.EndEdit()

        'Actualizar en TableAdapter
        SituacionTableAdapter.Update(DataSetPSAP.Situacion)

        Dispose()
    End Sub

    Private Sub EnableNavigator(flag As Boolean)
        cmdInicio.Enabled = flag
        cmdSiguiente.Enabled = flag
        cmdAnterior.Enabled = flag
        cmdUltimo.Enabled = flag
    End Sub

End Class