Public Class frmPozos

    Private Sub frmPozos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetPSAP.Pozo' Puede moverla o quitarla según sea necesario.
        Me.PozoTableAdapter.Fill(Me.DataSetPSAP.Pozo)

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        Dim total As Integer
        total = PozoBindingSource.Count + 1

        txtidPozo.Text = total
        txtUbicacion.Enabled = True
        txtUbicacion.Focus()

        cmdGrabar.Enabled = True
        cmdNuevo.Enabled = False

        PozoBindingSource.AddNew()
        EnableNavigator(False)


    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        PozoBindingSource.Current(0) = txtidPozo.Text
        PozoBindingSource.Current(1) = txtUbicacion.Text

        txtUbicacion.Enabled = False
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        dgPozos.Refresh()

        EnableNavigator(True)

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click

        PozoBindingSource.EndEdit()

        PozoTableAdapter.Update(DataSetPSAP.Pozo)

        Dispose()

    End Sub


    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        PozoBindingSource.MoveFirst()
        LoadRowInfoTotxt()
    End Sub


    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        PozoBindingSource.MovePrevious()
        LoadRowInfoTotxt()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        PozoBindingSource.MoveLast()
        LoadRowInfoTotxt()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        PozoBindingSource.MoveNext()
        LoadRowInfoTotxt()
    End Sub


    'LoadRowInfoTotxt
    Private Sub LoadRowInfoTotxt()
        txtidPozo.Text = PozoBindingSource.Current(0)
        txtUbicacion.Text = PozoBindingSource.Current(1)
    End Sub

    Private Sub EnableNavigator(flag As Boolean)
        cmdInicio.Enabled = flag
        cmdSiguiente.Enabled = flag
        cmdAnterior.Enabled = flag
        cmdUltimo.Enabled = flag
    End Sub



End Class