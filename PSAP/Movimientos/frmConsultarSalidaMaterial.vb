Imports System.Data.SqlClient

Public Class frmConsultarSalidaMaterial

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader


    Private Sub frmConsultarSalidaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        CargarCboxCalle(cboxConsultaCalle)
        CargarCboxEmpleado(cboxConsultaEmpleado)


    End Sub



    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim sql As String = "SELECT SalidaMaterial.idSalidaMaterial, Calle.nombre, Empleado.nombre, SalidaMaterial.fecha, SalidaMaterial.concepto FROM SalidaMaterial INNER JOIN Calle on SalidaMaterial.idCalle = Calle.idCalle INNER JOIN Empleado on SalidaMaterial.idEmpleado = Empleado.idEmpleado "

        dgSalidaMaterial.Rows.Clear()

        Select Case True

            Case rbtnFecha.Checked
                sql = sql + String.Format("where SalidaMaterial.fecha between '{0}' AND '{1}';", dtpConsultaFechaInicio.Value.ToShortDateString, dtpConsultaFechaFin.Value.ToShortDateString)

            Case rbtnCalle.Checked
                sql = sql + String.Format("where Calle.nombre = '{0}'", cboxConsultaCalle.Text)

            Case rbtnEmpleado.Checked
                sql = sql + String.Format("where Empleado.nombre = '{0}'", cboxConsultaEmpleado.Text)

            Case rbtnIdSalida.Checked
                sql = sql + String.Format("where SalidaMaterial.idSalidaMaterial = '{0}'", txtIdSalida.Text)


            Case rbtnTodos.Checked

            Case Else
                MessageBox.Show("Seleccion un filtro en la busqueda", "Seleccione una opción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select



        cmd = New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader





        While lector.Read()
            dgSalidaMaterial().Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While

        lector.Close()



        If dgSalidaMaterial.Rows.Count > 0 Then
            cmdDetalles.Enabled = True
        Else
            cmdDetalles.Enabled = False
        End If



    End Sub

    Sub CargarCboxCalle(ByRef cbox As ComboBox)
        cmd = New SqlCommand("SELECT nombre FROM Calle order by nombre asc;", conexion)
        lector = cmd.ExecuteReader()
        While lector.Read()
            cbox.Items.Add(lector(0))
        End While
        cbox.SelectedIndex = 0
        lector.Close()
    End Sub

    Sub CargarCboxEmpleado(ByRef cbox As ComboBox)
        cmd = New SqlCommand("SELECT nombre FROM Empleado order by nombre asc;", conexion)
        lector = cmd.ExecuteReader()
        While lector.Read()
            cbox.Items.Add(lector(0))
        End While
        cbox.SelectedIndex = 0
        lector.Close()
    End Sub





    Private Sub rbtnFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFecha.CheckedChanged
        dtpConsultaFechaInicio.Enabled = True
        dtpConsultaFechaFin.Enabled = True
        cboxConsultaCalle.Enabled = False
        cboxConsultaEmpleado.Enabled = False
    End Sub

    Private Sub rbtnCalle_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCalle.CheckedChanged
        dtpConsultaFechaInicio.Enabled = False
        dtpConsultaFechaFin.Enabled = False
        cboxConsultaCalle.Enabled = True
        cboxConsultaEmpleado.Enabled = False
        txtIdSalida.Enabled = False
        txtIdSalida.Clear()
    End Sub

    Private Sub rbtnEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnEmpleado.CheckedChanged
        dtpConsultaFechaInicio.Enabled = False
        dtpConsultaFechaFin.Enabled = False
        cboxConsultaCalle.Enabled = False
        cboxConsultaEmpleado.Enabled = True
        txtIdSalida.Enabled = False
        txtIdSalida.Clear()
    End Sub

    Private Sub rbtnTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTodos.CheckedChanged
        dtpConsultaFechaInicio.Enabled = False
        dtpConsultaFechaFin.Enabled = False
        cboxConsultaCalle.Enabled = False
        cboxConsultaEmpleado.Enabled = False
        txtIdSalida.Enabled = False
        txtIdSalida.Clear()
    End Sub

    Private Sub rbtnIdSalida_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIdSalida.CheckedChanged
        dtpConsultaFechaInicio.Enabled = False
        dtpConsultaFechaFin.Enabled = False
        cboxConsultaCalle.Enabled = False
        cboxConsultaEmpleado.Enabled = False
        txtIdSalida.Enabled = True
        txtIdSalida.Clear()
        txtIdSalida.Focus()
    End Sub

    Private Sub cmdDetalles_Click(sender As Object, e As EventArgs) Handles cmdDetalles.Click

        Dim sql As String
        Dim idSalidaMaterial As Integer = dgSalidaMaterial.Rows.Item(dgSalidaMaterial.CurrentCell.RowIndex).Cells(0).Value


        frmDetallesSalidaMaterial.dgDetalleSalidaMaterial.Rows.Clear()

        'MessageBox.Show(idSalidaMaterial)
        sql = String.Format("SELECT DetSalidaMaterial.idMaterial, Material.descripcion, DetSalidaMaterial.cantidad, DetSalidaMaterial.costo FROM DetSalidaMaterial INNER JOIN Material ON DetSalidaMaterial.idMaterial = Material.idMaterial WHERE DetSalidaMaterial.idSalidaMaterial = '{0}'", idSalidaMaterial)

        cmd.CommandText = sql

        lector = cmd.ExecuteReader()
        While lector.Read()
            frmDetallesSalidaMaterial.dgDetalleSalidaMaterial.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(2) * lector(3))
        End While

        lector.Close()


        cmd.CommandText = String.Format("SELECT SalidaMaterial.idSalidaMaterial, Calle.nombre, Empleado.nombre, SalidaMaterial.fecha, SalidaMaterial.concepto FROM SalidaMaterial INNER JOIN Calle on SalidaMaterial.idCalle = Calle.idCalle INNER JOIN Empleado on SalidaMaterial.idEmpleado = Empleado.idEmpleado WHERE SalidaMaterial.idSalidaMaterial = '{0}'", idSalidaMaterial)


        lector = cmd.ExecuteReader
        lector.Read()
        frmDetallesSalidaMaterial.txtidSalidaMaterial.Text = lector(0)
        frmDetallesSalidaMaterial.txtCalle.Text = lector(1)
        frmDetallesSalidaMaterial.txtEmpleado.Text = lector(2)
        frmDetallesSalidaMaterial.txtConcepto.Text = lector(4)
        frmDetallesSalidaMaterial.txtFecha.Text = lector(3)

        lector.Close()

        'MessageBox.Show(autosuma(frmDetallesSalidaMaterial.dgDetalleSalidaMaterial, "importe"))
        frmDetallesSalidaMaterial.txtTotal.Text = autosuma(frmDetallesSalidaMaterial.dgDetalleSalidaMaterial, "importe")


        frmDetallesSalidaMaterial.ShowDialog()




    End Sub



    Function autosuma(ByRef dg As DataGridView, ByVal colunma As String) As Decimal
        Dim total As Decimal = 0

        For x = 0 To dg.Rows.Count - 1
            total = total + dg.Item(colunma, x).Value
        Next

        Return total
    End Function


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub


    
    Private Sub txtIdSalida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdSalida.KeyPress
        Dim CadenaValida As String = "1234567890"
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

End Class