Public Class frmEmpleados


    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetPSAP.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.DataSetPSAP.Empleado)

    End Sub



    Private Sub EnableNavigator(flag As Boolean)
        cmdInicio.Enabled = flag
        cmdSiguiente.Enabled = flag
        cmdAnterior.Enabled = flag
        cmdUltimo.Enabled = flag
    End Sub


    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        'Generar ID
        Dim total As Integer
        total = EmpleadoBindingSource.Count + 1
        txtidEmpleado.Text = total


        EmpleadoBindingSource.AddNew()

        txtNombre.Enabled = True
        txtCalle.Enabled = True
        txtColonia.Enabled = True
        txtCodigoPostal.Enabled = True
        txtTelefono.Enabled = True

        EnableNavigator(False)

        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        dgEmpleados.Enabled = False


    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        'Habilitar botones
        txtNombre.Enabled = False
        txtCalle.Enabled = False
        txtColonia.Enabled = False
        txtCodigoPostal.Enabled = False
        txtTelefono.Enabled = False
        EnableNavigator(True)
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        dgEmpleados.Enabled = True
        dgEmpleados.Refresh()



    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        EmpleadoBindingSource.EndEdit()
        EmpleadoTableAdapter.Update(DataSetPSAP.Empleado)
        Dispose()

    End Sub


    Private Sub txtCodigoPostal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPostal.KeyPress
        Dim CadenaValida As String = "1234567890"
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub


    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        Dim CadenaValida As String = "1234567890- +"
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click

        EmpleadoBindingSource.CancelEdit()
        txtNombre.Enabled = False

        txtCalle.Enabled = False
        txtColonia.Enabled = False
        txtCodigoPostal.Enabled = False
        txtTelefono.Enabled = False
        EnableNavigator(True)
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        dgEmpleados.Enabled = True



    End Sub
End Class