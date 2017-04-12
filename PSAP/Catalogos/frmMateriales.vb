Public Class frmMateriales

    Private Sub frmMaterialesPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSeTPSAP.Material' Puede moverla o quitarla según sea necesario.
        Me.MaterialTableAdapter.Fill(Me.DataSeTPSAP.Material)

    End Sub



    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        Dim total As Integer
        total = MaterialBindingSource.Count + 1
        MaterialBindingSource.AddNew()

        txtidMaterial.Text = total

        txtDescripcion.Enabled = True
        txtExistencia.Enabled = True
        txtMaximo.Enabled = True
        txtMinimo.Enabled = True
        cboxUnidadMedida.Enabled = True
        txtCosto.Enabled = True
        dtpFechaUltimaCompra.Enabled = True
        cmdGrabar.Enabled = True
        cmdNuevo.Enabled = False
        txtDescripcion.Focus()
        EnableNavigator(False)
        dgMateriales.Enabled = False
        cmdCancelar.Enabled = True

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        MaterialBindingSource.Current(7) = dtpFechaUltimaCompra.Value.Date
        txtDescripcion.Enabled = False
        txtExistencia.Enabled = False
        txtMaximo.Enabled = False
        txtMinimo.Enabled = False
        cboxUnidadMedida.Enabled = False
        txtCosto.Enabled = False
        dtpFechaUltimaCompra.Enabled = False

        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True

        EnableNavigator(True)
        dgMateriales.Refresh()

        dgMateriales.Enabled = True
        cmdCancelar.Enabled = False

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click

        MaterialBindingSource.EndEdit()
        MaterialTableAdapter.Update(DataSetPSAP.Material)
        Dispose()

    End Sub

    Private Sub EnableNavigator(flag As Boolean)
        cmdInicio.Enabled = flag
        cmdSiguiente.Enabled = flag
        cmdAnterior.Enabled = flag
        cmdUltimo.Enabled = flag
    End Sub




    'Validación de numeros:
    Private Sub txtExistencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExistencia.KeyPress
        Dim CadenaValida As String = "1234567890."
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtMaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaximo.KeyPress
        Dim CadenaValida As String = "1234567890."
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimo.KeyPress
        Dim CadenaValida As String = "1234567890."
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        Dim CadenaValida As String = "1234567890."
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        MaterialBindingSource.CancelEdit()

        txtDescripcion.Enabled = False
        txtExistencia.Enabled = False
        txtMaximo.Enabled = False
        txtMinimo.Enabled = False
        cboxUnidadMedida.Enabled = False
        txtCosto.Enabled = False
        dtpFechaUltimaCompra.Enabled = False

        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True

        EnableNavigator(True)
        dgMateriales.Refresh()

        dgMateriales.Enabled = True
        cmdCancelar.Enabled = False
    End Sub




End Class