Public Class frmTarifas

    Private Sub frmTarifas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetPSAP.Tarifa' Puede moverla o quitarla según sea necesario.
        Me.TarifaTableAdapter.Fill(Me.DataSetPSAP.Tarifa)

    End Sub

    
    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        'Generar ID
        Dim total As Integer
        total = TarifaBindingSource.Count + 1
        txtidTarifa.Text = total.ToString

        'Agregar nuevo al BindingSource
        TarifaBindingSource.AddNew()

        'deshabilitar botones:
        txtAnio.Enabled = True
        txtCuotaFija.Enabled = True
        txtRecargos.Enabled = True
        txtTar.Enabled = True
        txtInfra.Enabled = True

        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        txtAnio.Focus()
        EnableNavigator(False)


    End Sub


    


    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        'Habilitar botones
        txtAnio.Enabled = False
        txtCuotaFija.Enabled = False
        txtRecargos.Enabled = False
        txtTar.Enabled = False
        txtInfra.Enabled = False

        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        EnableNavigator(True)

        'Refrescar
        dgTarifas.Refresh()


    End Sub


    Private Sub EnableNavigator(flag As Boolean)
        cmdInicio.Enabled = flag
        cmdSiguiente.Enabled = flag
        cmdAnterior.Enabled = flag
        cmdUltimo.Enabled = flag
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        'Cierre de flujo
        TarifaBindingSource.EndEdit()

        'Actualizar en TableAdapter
        TarifaTableAdapter.Update(DataSetPSAP.Tarifa)

        Dispose()
    End Sub
End Class