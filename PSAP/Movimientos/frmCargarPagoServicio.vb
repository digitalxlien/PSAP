Imports System.Data.SqlClient
Public Class frmCargarPagoServicio

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As SqlCommand = New SqlCommand("", conexion)
    Dim lector As SqlDataReader




    Private Sub frmCargarPagoServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        CargarCboxEmpleados()
        CargarCboxServicios()

        cboxEmpleado.SelectedIndex = 0
        cboxServicio.SelectedIndex = 0

    End Sub

    Sub CargarCboxEmpleados()
        cmd.CommandText = "SELECT nombre FROM Empleado ORDER BY nombre ASC"
        lector = cmd.ExecuteReader
        While lector.Read
            cboxEmpleado.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub


    Sub CargarCboxServicios()
        cmd.CommandText = "select descripcion from Servicio order by descripcion desc;"
        lector = cmd.ExecuteReader
        While lector.Read
            cboxServicio.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub


    Private Sub cboxServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxServicio.SelectedIndexChanged
        txtCosto.Text = getPrecio(cboxServicio.Text)
    End Sub

    Function getPrecio(ByVal servicio As String) As Double

        cmd.CommandText = String.Format("select precio from servicio where descripcion = '{0}'", servicio)
        lector = cmd.ExecuteReader
        lector.Read()
        getPrecio = lector(0)
        lector.Close()
        Return getPrecio
    End Function


    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        frmPagos.dgServicios.Rows.Add(cboxServicio.Text, cboxEmpleado.Text, txtCosto.Text)

        frmPagos.CalcularTotal()

        Me.Dispose()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub
End Class