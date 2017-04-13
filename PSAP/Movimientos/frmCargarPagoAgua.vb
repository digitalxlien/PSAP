Imports System.Data.SqlClient

Public Class frmCargarPagoAgua

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader


    Private Sub frmCargarPagoAgua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        CargarCbox(cboxSituacion, "descripcion", "Situacion")

        CargarCbox(cboxTarifa, "anio", "tarifa")

        cboxSituacion.SelectedIndex = 0
        cboxTarifa.SelectedIndex = 0

    End Sub



    Sub CargarCbox(ByRef cbox As ComboBox, ByVal columna As String, ByVal tabla As String)
        Dim sql As String = String.Format("SELECT {0} FROM {1};", columna, tabla)

        'Cargar el cbox
        cmd = New SqlCommand(sql, conexion)
        lector = cmd.ExecuteReader()
        While lector.Read()
            cbox.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub



End Class