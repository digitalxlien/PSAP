Imports System.Data.SqlClient


Public Class frmActiidadPozos

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim auxIdPozo As Integer = -1

    Private Sub frmActividadPozos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Formato del dtpHora:
        dtpHora.Format = DateTimePickerFormat.Time
        dtpHora.ShowUpDown = True


        conexion.Open()

        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand("SELECT * FROM Pozo", conexion)

        lector = cmd.ExecuteReader()

        'Cargar el catalogo Pozo en el comboBox:
        While lector.Read
            '1 es la posicion del nombre en la tabla
            cboxPozo.Items.Add(lector(1))
        End While

        lector.Close()

        'Cargar datos al dgActividadPozo
        cmd.CommandText = "SELECT ActividadPozo.idActividadPozo, ActividadPozo.idPozo, Pozo.ubicacion, ActividadPozo.fecha, ActividadPozo.hora, ActividadPozo.lectura, ActividadPozo.observaciones FROM ActividadPozo inner join Pozo ON ActividadPozo.idPozo = Pozo.IdPozo;"
        lector = cmd.ExecuteReader()

        While lector.Read
            dgActividadPozos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While

        lector.Close()

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM ActividadPozo;", conexion)
        Dim total As Integer

        total = cmd.ExecuteScalar() + 1
        txtidActividad.Text = total


        'Habilitar botones
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cboxPozo.Enabled = True
        dtpFecha.Enabled = True
        dtpHora.Enabled = True
        txtLectura.Enabled = True
        txtObservaciones.Enabled = True

    End Sub
    
    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        'Variables para tabla ActividadPozo
        Dim idPozo As Integer = auxIdPozo
        Dim fecha As String = dtpFecha.Value.Date
        Dim hora As String = dtpHora.Value.Hour.ToString & ":" & dtpHora.Value.Minute.ToString
        Dim lectura As String = txtLectura.Text
        Dim observaciones As String = txtObservaciones.Text


        If idPozo = -1 Then
            MessageBox.Show("Seleccione un Pozo del menu desplegable en este formulario.", "Falta especificar Pozo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboxPozo.Focus()
        Else

            Dim r As String
            r = String.Format("INSERT INTO ActividadPozo (idPozo, fecha, hora, lectura, observaciones) VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}')", _
                              idPozo, fecha, hora, lectura, observaciones)

            Dim cmd As New SqlCommand(r, conexion)
            cmd.ExecuteNonQuery()

            actualizar()

            'Limpiar Cajas de texto
            txtidActividad.Text = ""
            txtLectura.Text = ""
            txtObservaciones.Text = ""

            'Deshabilitar cajas de texto
            cmdGrabar.Enabled = False
            cmdNuevo.Enabled = True
            cboxPozo.Enabled = False
            dtpFecha.Enabled = False
            dtpHora.Enabled = False
            txtLectura.Enabled = False
            txtObservaciones.Enabled = False

        End If

    End Sub

    Private Sub cboxPozo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxPozo.SelectedIndexChanged

        Dim sql As String = String.Format("SELECT * FROM POZO WHERE ubicacion = '{0}'", cboxPozo.Text)

        Dim cmd As New SqlCommand(sql, conexion)
        Dim lector As SqlDataReader

        lector = cmd.ExecuteReader()

        'Ya consulta el id del Pozo
        lector.Read()
        auxIdPozo = lector(0)

        lector.Close()
    End Sub

    Private Sub frmActiidadPozos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        conexion.Close()
        dgActividadPozos.Rows.Clear()
        cboxPozo.Items.Clear()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub actualizar()

        dgActividadPozos.Rows.Clear()

        Dim sql As String = "SELECT ActividadPozo.idActividadPozo, ActividadPozo.idPozo, Pozo.ubicacion, ActividadPozo.fecha, ActividadPozo.hora, ActividadPozo.lectura, ActividadPozo.observaciones FROM ActividadPozo inner join Pozo ON ActividadPozo.idPozo = Pozo.IdPozo;"
        Dim lector As SqlDataReader
        Dim cmd As New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader()

        While lector.Read
            dgActividadPozos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While

        lector.Close()
    End Sub

End Class