Imports System.Data.SqlClient

Public Class frmCargarPagoAgua

    Dim conexion As New SqlConnection("Data source = DIGITALXLIEN-PC; Initial Catalog = 'BD_PSAP'; Integrated security = true")
    Dim cmd As SqlCommand = New SqlCommand("", conexion)
    Dim lector As SqlDataReader
    Dim meses() As String = New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}

    '       LOAD

    Private Sub frmCargarPagoAgua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()

        cargarCboxSituaciones()
        
        cargarCboxTarifa()

        cboxTarifa.SelectedIndex = 0
        cboxSituacion.SelectedIndex = 0
        cboxMesInicial.SelectedIndex = 0
        cboxMesFinal.SelectedIndex = 0

    End Sub


    '       CARGAR COMBO BOX

    Sub cargarCboxSituaciones()
        Dim sql As String = String.Format("SELECT descripcion FROM situacion ORDER BY descuento asc;")
        'Cargar el cbox
        cmd.CommandText = sql
        lector = cmd.ExecuteReader()
        While lector.Read()
            cboxSituacion.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Sub cargarCboxTarifa()
        Dim sql As String = String.Format("SELECT anio FROM tarifa ORDER BY anio desc;")
        'Cargar el cbox
        cmd.CommandText = sql
        lector = cmd.ExecuteReader()
        While lector.Read()
            cboxTarifa.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    

    Sub calcularCosto()

        Dim descuento As Double = CDbl(txtDescuento.Text) / 100
        Dim cuotaFija As Double = getCuotaFija(cboxTarifa.Text)
        Dim recargos As Double = getRecargos(cboxTarifa.Text)
        Dim tar As Double = getTar(cboxTarifa.Text)
        Dim infra As Double = getInfra(cboxTarifa.Text)
        Dim mesInicio As Integer
        Dim mesFin As Integer
        Dim fechaOS As Date

        fechaOS = System.DateTime.Today
        mesInicio = cboxMesInicial.SelectedIndex + 1
        mesFin = cboxMesFinal.SelectedIndex + 1

        'Si cboxTarifa = fechaOS.año entonces:
        If cboxTarifa.Text.Equals(fechaOS.Year.ToString) Then
            'Cero recargos si paga el periodo en el mismo año
            recargos = 0
        End If

        If descuento = 0 And entreEneroFebrero(fechaOS) And cboxTarifa.Text.Equals(fechaOS.Year.ToString) Then
            'Descuento del 15% si el pago del periodo lo hace entre los meses de enero y febrero 
            'y no recibe ningun descuento por alguna situacion. especial
            descuento = 0.15
            txtDescuentoPagoPuntual.Text = descuento * 100
        Else
            txtDescuentoPagoPuntual.Text = 0
        End If


        txtCuotaFija.Text = Math.Round(((cuotaFija - (cuotaFija * descuento)) / 12) * mesFin, 2)
        txtTar.Text = Math.Round(((tar - (tar * descuento)) / 12) * mesFin, 2)
        txtInfra.Text = Math.Round(((infra - (infra * descuento)) / 12) * mesFin, 2)
        txtRecargos.Text = Math.Round((recargos / 12) * mesFin, 2)

        




    End Sub

    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs)
        calcularCosto()

    End Sub

    Sub CargarCbox(ByRef cbox As ComboBox, ByVal columna As String, ByVal tabla As String, columnaOrden As String, orden As String)

        Dim sql As String = String.Format("SELECT {0} FROM {1} ORDER BY {2} {3};", columna, tabla, columnaOrden, orden)

        'Cargar el cbox
        cmd.CommandText = sql
        lector = cmd.ExecuteReader()
        While lector.Read()
            cbox.Items.Add(lector(0))
        End While
        lector.Close()

    End Sub

    Function entreEneroFebrero(ByVal fecha As Date) As Boolean
        If fecha.Month = 1 Or fecha.Month = 2 Then
            Return True
        Else
            Return False
        End If
    End Function



    '       SELECTED INDEX CHANGED

    Private Sub cboxTarifa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxTarifa.SelectedIndexChanged
        txtCuotaFija.Text = getCuotaFija(cboxTarifa.Text)
        txtRecargos.Text = getRecargos(cboxTarifa.Text)
        txtTar.Text = getTar(cboxTarifa.Text)
        txtInfra.Text = getInfra(cboxTarifa.Text)

        cboxMesInicial.Enabled = True
        '2do 
        calcularCosto()
    End Sub

    Private Sub cboxMesInicial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxMesInicial.SelectedIndexChanged

        cboxMesFinal.Items.Clear()
        cboxMesFinal.Items.AddRange(meses)
        For x = 0 To cboxMesInicial.SelectedIndex - 1
            cboxMesFinal.Items.RemoveAt(0)
        Next
        cboxMesFinal.SelectedIndex = 0

        cboxMesFinal.Enabled = True



        '3er
        calcularCosto()
    End Sub

    Private Sub cboxMesFinal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxMesFinal.SelectedIndexChanged
        cmdAceptar.Enabled = True

        '4to
        calcularCosto()
    End Sub

    Private Sub cboxSituacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxSituacion.SelectedIndexChanged
        txtDescuento.Text = getDescuento(cboxSituacion.Text)
        '1er
        calcularCosto()
    End Sub


    '       GETS

    Function getDescuento(ByVal descripcion As String) As Double


        Dim sql As String = String.Format("SELECT descuento FROM Situacion where descripcion = '{0}'", descripcion)
        Dim descuento As Double
        Dim aux As SqlDataReader

        cmd.CommandText = sql
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

        cmd.CommandText = sql
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

        cmd.CommandText = sql
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
        cmd.CommandText = sql
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
        cmd.CommandText = sql
        aux = cmd.ExecuteReader()
        aux.Read()
        infra = aux(0)
        aux.Close()
        Return infra
    End Function


    '       BOTONES:

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        Dim descuento As Double = CDbl(txtDescuento.Text)
        Dim importe As Double
        If descuento = 0 Then
            descuento = CDbl(txtDescuentoPagoPuntual.Text)
        End If



        importe = CDbl(txtCuotaFija.Text) + CDbl(txtRecargos.Text) + CDbl(txtTar.Text) + CDbl(txtInfra.Text)

        frmPagos.dgAgua.Rows.Add(cboxTarifa.Text, cboxMesInicial.Text, cboxMesFinal.Text, txtCuotaFija.Text, txtRecargos.Text, txtTar.Text, txtInfra.Text, cboxSituacion.Text, descuento, importe)
        conexion.Close()
        lector.Close()
        Me.Dispose()


        frmPagos.CalcularTotal()


    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexion.Close()
        lector.Close()
        Me.Dispose()
    End Sub


End Class