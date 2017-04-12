Public Class frmServicios

    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetPSAP.Servicio' Puede moverla o quitarla según sea necesario.
        Me.ServicioTableAdapter.Fill(Me.DataSetPSAP.Servicio)

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        txtDescripcion.Text = ""
        txtPrecio.Text = ""
        Dim total As Integer
        total = ServicioBindingSource.Count + 1
        txtIdServicio.Text = total
        txtDescripcion.Enabled = True
        txtPrecio.Enabled = True
        txtDescripcion.Focus()
        cmdGrabar.Enabled = True
        cmdNuevo.Enabled = False
        ServicioBindingSource.AddNew()
        EnableNavigator(False)
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        ServicioBindingSource.Current(0) = txtIdServicio.Text
        ServicioBindingSource.Current(1) = txtDescripcion.Text
        ServicioBindingSource.Current(2) = txtPrecio.Text
        txtDescripcion.Enabled = False
        txtPrecio.Enabled = False
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        dgServicios.Refresh()
        EnableNavigator(True)

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        ServicioBindingSource.EndEdit()
        ServicioTableAdapter.Update(DataSetPSAP.Servicio)
        Dispose()
    End Sub


    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        ServicioBindingSource.MoveFirst()
        LoadRowInfoTotxt()

    End Sub


    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        ServicioBindingSource.MovePrevious()
        LoadRowInfoTotxt()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        ServicioBindingSource.MoveLast()
        LoadRowInfoTotxt()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        ServicioBindingSource.MoveNext()
        LoadRowInfoTotxt()
    End Sub

    'LoadRowInfoTotxt
    Private Sub LoadRowInfoTotxt()
        txtIdServicio.Text = ServicioBindingSource.Current(0)
        txtDescripcion.Text = ServicioBindingSource.Current(1)
        txtPrecio.Text = ServicioBindingSource.Current(2)

    End Sub

    Private Sub EnableNavigator(flag As Boolean)
        cmdInicio.Enabled = flag
        cmdSiguiente.Enabled = flag
        cmdAnterior.Enabled = flag
        cmdUltimo.Enabled = flag
    End Sub


    'Validación de números:
    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        Dim CadenaValida As String = "1234567890."
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class