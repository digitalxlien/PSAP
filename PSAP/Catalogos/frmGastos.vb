Public Class frmGastos

   
    Private Sub frmGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Llena el dgGastos con los datos de la tabla
        Me.GastoTableAdapter.Fill(Me.DataSetPSAP.Gasto)

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        txtConcepto.Enabled = False
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        dgGastos.Refresh()
        cmdCancelar.Enabled = False
        EnableNavigator(True)
        dgGastos.Enabled = True

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        Dim total As Integer
        total = GastoBindingSource.Count + 1
        GastoBindingSource.AddNew()
        txtidGasto.Text = total
        txtConcepto.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        txtConcepto.Focus()
        dgGastos.Enabled = False
        EnableNavigator(False)

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        GastoBindingSource.EndEdit()
        Me.GastoTableAdapter.Update(Me.DataSetPSAP.Gasto)
        Dispose()
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        GastoBindingSource.MoveFirst()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        GastoBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        GastoBindingSource.MoveLast()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        GastoBindingSource.MoveNext()
    End Sub


    Private Sub EnableNavigator(flag As Boolean)
        cmdInicio.Enabled = flag
        cmdSiguiente.Enabled = flag
        cmdAnterior.Enabled = flag
        cmdUltimo.Enabled = flag
    End Sub


  

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        GastoBindingSource.CancelEdit()

        cmdCancelar.Enabled = False
        txtConcepto.Enabled = False
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        dgGastos.Refresh()
        dgGastos.Enabled = True
        EnableNavigator(True)

    End Sub
End Class
