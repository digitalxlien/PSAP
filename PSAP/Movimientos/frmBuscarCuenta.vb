Imports System.Data.SqlClient

Public Class frmBuscarCuenta

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")

    Dim cmd As New SqlCommand
    Dim lector As SqlDataReader
    Dim sql As String
    Dim meses() As String = New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}

    Private Sub frmBuscarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        cmd.Connection = conexion
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

        dgCuentas.Rows.Clear()

        cmd.CommandText = String.Format("Select Cuenta.idCalle, Cuenta.nombre, Calle.nombre, Cuenta.numeroExt, Cuenta.numeroInt," & _
                                        "Cuenta.fechaAlta, cuenta.ultimoPagoMes, Cuenta.ultimoPagoAnio from cuenta inner join calle " & _
                                        "on Cuenta.idCalle = Calle.idCalle where cuenta.nombre like '%{0}%'", txtNombre.Text & "")


        lector = cmd.ExecuteReader

        While lector.Read
            If lector(6).ToString = "" Then
                dgCuentas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6).ToString & " - " & lector(7).ToString)
            Else
                dgCuentas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), meses(lector(6) - 1) & " - " & lector(7).ToString)
            End If
        End While
        lector.Close()


        If dgCuentas.Rows.Count > 0 Then
            cmdSeleccionar.Enabled = True
        Else
            cmdSeleccionar.Enabled = False
        End If

    End Sub

    Private Sub cmdSeleccionar_Click(sender As Object, e As EventArgs) Handles cmdSeleccionar.Click

        frmPagos.txtidCuenta.Text = dgCuentas.Rows.Item(dgCuentas.CurrentCell.RowIndex).Cells(0).Value
        frmPagos.txtNombre.Text = dgCuentas.Rows.Item(dgCuentas.CurrentCell.RowIndex).Cells(1).Value
        frmPagos.txtDomicilio.Text = dgCuentas.Rows.Item(dgCuentas.CurrentCell.RowIndex).Cells(2).Value & ", #" & dgCuentas.Rows.Item(dgCuentas.CurrentCell.RowIndex).Cells(3).Value & ", Int. " & dgCuentas.Rows.Item(dgCuentas.CurrentCell.RowIndex).Cells(4).Value
        frmPagos.txtUltimoPeriodoPagado.Text = dgCuentas.Rows.Item(dgCuentas.CurrentCell.RowIndex).Cells(6).Value
        frmPagos.txtFechaAlta.Text = CDate(dgCuentas.Rows.Item(dgCuentas.CurrentCell.RowIndex).Cells(5).Value).ToLongDateString



        frmPagos.validarGuardar()
        'frmPagos.txtTelefono.Text = dgCuentas.Rows.Item(dgCuentas.CurrentCell.RowIndex).Cells(1).Value

        Me.Dispose()

    End Sub


    Private Sub cmdRegresar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        conexion.Close()
        Me.Dispose()
    End Sub


End Class