Imports System.Data.SqlClient

Public Class frmCargarPagoAgua

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader
    Dim meses() As String = New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}





    Private Sub frmCargarPagoAgua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        CargarCbox(cboxSituacion, "descripcion", "Situacion")

        CargarCbox(cboxTarifa, "anio", "tarifa")

        cboxSituacion.SelectedIndex = 0
        cboxTarifa.SelectedIndex = 0
        cboxMesInicial.SelectedIndex = 0
        cboxMesFinal.SelectedIndex = 0

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

    Private Sub cboxMesInicial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxMesInicial.SelectedIndexChanged

        cboxMesFinal.Items.Clear()
        cboxMesFinal.Items.AddRange(meses)
        For x = 0 To cboxMesInicial.SelectedIndex - 1
            cboxMesFinal.Items.RemoveAt(0)
        Next
        cboxMesFinal.SelectedIndex = 0

    End Sub

    Private Sub cboxSituacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxSituacion.SelectedIndexChanged
        txtDescuento.Text = getDescuento(cboxSituacion.Text)
    End Sub

    Function getDescuento(ByVal descripcion As String) As Double


        Dim sql As String = String.Format("SELECT descuento FROM Situacion where descripcion = '{0}'", descripcion)
        Dim descuento As Double
        Dim aux As SqlDataReader

        cmd = New SqlCommand(sql, conexion)
        aux = cmd.ExecuteReader()
        aux.Read()
        descuento = aux(0)
        aux.Close()
        Return descuento
    End Function



    Function getCuotaFija(ByVal anio As String) As Double
        Dim sql As String = String.Format("SELECT CuotaFija FROM Tarifa WHERE anio = {0}", anio)
        Dim cuotaFija As Double
        Dim aux As SqlDataReader

        cmd = New SqlCommand(sql, conexion)
        aux = cmd.ExecuteReader()
        aux.Read()
        cuotaFija = aux(0)
        aux.Close()

        Return cuotaFija
    End Function

    Function getRecargos(ByVal anio As String) As Double
        Dim sql As String = String.Format("SELECT recargos FROM Tarifa WHERE anio = {0}", anio)
        Dim recargos As Double
        Dim aux As SqlDataReader

        cmd = New SqlCommand(sql, conexion)
        aux = cmd.ExecuteReader()
        aux.Read()
        recargos = aux(0)
        aux.Close()

        Return recargos
    End Function

    Function getTar(ByVal anio As String) As Double
        Dim sql As String = String.Format("SELECT tar FROM Tarifa WHERE anio = {0}", anio)
        Dim tar As Double
        Dim aux As SqlDataReader

        cmd = New SqlCommand(sql, conexion)
        aux = cmd.ExecuteReader()
        aux.Read()
        tar = aux(0)
        aux.Close()

        Return tar
    End Function

    Function getInfra(ByVal anio As String) As Double
        Dim sql As String = String.Format("SELECT infra FROM Tarifa WHERE anio = {0}", anio)
        Dim infra As Double
        Dim aux As SqlDataReader

        cmd = New SqlCommand(sql, conexion)
        aux = cmd.ExecuteReader()
        aux.Read()
        infra = aux(0)
        aux.Close()

        Return infra
    End Function

    Private Sub cboxTarifa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxTarifa.SelectedIndexChanged
        txtCuotaFija.Text = getCuotaFija(cboxTarifa.Text)
        txtRecargos.Text = getRecargos(cboxTarifa.Text)
        txtTar.Text = getTar(cboxTarifa.Text)
        txtInfra.Text = getInfra(cboxTarifa.Text)
    End Sub

    
End Class