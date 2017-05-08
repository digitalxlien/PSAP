<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mniArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniCatalogos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniGastos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniCalles = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniMateriales = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniPozos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniServicios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniCuentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniTarifas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSituaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniMovimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniActividadPozos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniGastosRealizados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniMovimientoMateriales = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisrarComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniConsultarEntradaMaterial = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mniRegistrarSalidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniConsultarSalidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniPagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniRegistrarPago = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniConsultarPagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniReportesCuentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniCuentasPorCalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniReporteCalles = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniReporteMaterialesExistencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniReporteEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniReporteGastos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniReporteTarifas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniReportePozos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsMenu
        '
        Me.mnsMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniArchivo, Me.mniCatalogos, Me.mniMovimientos, Me.mniReportes})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(712, 24)
        Me.mnsMenu.TabIndex = 0
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mniArchivo
        '
        Me.mniArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniAcercaDe, Me.mniSalir})
        Me.mniArchivo.Name = "mniArchivo"
        Me.mniArchivo.Size = New System.Drawing.Size(60, 20)
        Me.mniArchivo.Text = "Archivo"
        '
        'mniAcercaDe
        '
        Me.mniAcercaDe.Name = "mniAcercaDe"
        Me.mniAcercaDe.Size = New System.Drawing.Size(135, 22)
        Me.mniAcercaDe.Text = "Acerca de..."
        '
        'mniSalir
        '
        Me.mniSalir.Name = "mniSalir"
        Me.mniSalir.Size = New System.Drawing.Size(135, 22)
        Me.mniSalir.Text = "Salir"
        '
        'mniCatalogos
        '
        Me.mniCatalogos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniGastos, Me.mniCalles, Me.mniMateriales, Me.mniPozos, Me.mniServicios, Me.mniEmpleados, Me.mniCuentas, Me.mniTarifas, Me.mniSituaciones, Me.ProveedoresToolStripMenuItem})
        Me.mniCatalogos.Name = "mniCatalogos"
        Me.mniCatalogos.Size = New System.Drawing.Size(72, 20)
        Me.mniCatalogos.Text = "Catalogos"
        '
        'mniGastos
        '
        Me.mniGastos.Name = "mniGastos"
        Me.mniGastos.Size = New System.Drawing.Size(139, 22)
        Me.mniGastos.Text = "Gastos"
        '
        'mniCalles
        '
        Me.mniCalles.Name = "mniCalles"
        Me.mniCalles.Size = New System.Drawing.Size(139, 22)
        Me.mniCalles.Text = "Calles"
        '
        'mniMateriales
        '
        Me.mniMateriales.Name = "mniMateriales"
        Me.mniMateriales.Size = New System.Drawing.Size(139, 22)
        Me.mniMateriales.Text = "Materiales"
        '
        'mniPozos
        '
        Me.mniPozos.Name = "mniPozos"
        Me.mniPozos.Size = New System.Drawing.Size(139, 22)
        Me.mniPozos.Text = "Pozos"
        '
        'mniServicios
        '
        Me.mniServicios.Name = "mniServicios"
        Me.mniServicios.Size = New System.Drawing.Size(139, 22)
        Me.mniServicios.Text = "Servicios"
        '
        'mniEmpleados
        '
        Me.mniEmpleados.Name = "mniEmpleados"
        Me.mniEmpleados.Size = New System.Drawing.Size(139, 22)
        Me.mniEmpleados.Text = "Empleados"
        '
        'mniCuentas
        '
        Me.mniCuentas.Name = "mniCuentas"
        Me.mniCuentas.Size = New System.Drawing.Size(139, 22)
        Me.mniCuentas.Text = "Cuentas"
        '
        'mniTarifas
        '
        Me.mniTarifas.Name = "mniTarifas"
        Me.mniTarifas.Size = New System.Drawing.Size(139, 22)
        Me.mniTarifas.Text = "Tarifas"
        '
        'mniSituaciones
        '
        Me.mniSituaciones.Name = "mniSituaciones"
        Me.mniSituaciones.Size = New System.Drawing.Size(139, 22)
        Me.mniSituaciones.Text = "Situaciones"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'mniMovimientos
        '
        Me.mniMovimientos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniActividadPozos, Me.mniGastosRealizados, Me.mniMovimientoMateriales, Me.mniPagos})
        Me.mniMovimientos.Name = "mniMovimientos"
        Me.mniMovimientos.Size = New System.Drawing.Size(89, 20)
        Me.mniMovimientos.Text = "Movimientos"
        '
        'mniActividadPozos
        '
        Me.mniActividadPozos.Name = "mniActividadPozos"
        Me.mniActividadPozos.Size = New System.Drawing.Size(174, 22)
        Me.mniActividadPozos.Text = "Actividad de pozos"
        '
        'mniGastosRealizados
        '
        Me.mniGastosRealizados.Name = "mniGastosRealizados"
        Me.mniGastosRealizados.Size = New System.Drawing.Size(174, 22)
        Me.mniGastosRealizados.Text = "Registro de Gastos"
        '
        'mniMovimientoMateriales
        '
        Me.mniMovimientoMateriales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisrarComprasToolStripMenuItem, Me.mniConsultarEntradaMaterial, Me.ToolStripSeparator1, Me.mniRegistrarSalidas, Me.mniConsultarSalidas})
        Me.mniMovimientoMateriales.Name = "mniMovimientoMateriales"
        Me.mniMovimientoMateriales.Size = New System.Drawing.Size(174, 22)
        Me.mniMovimientoMateriales.Text = "Materiales"
        '
        'RegisrarComprasToolStripMenuItem
        '
        Me.RegisrarComprasToolStripMenuItem.Name = "RegisrarComprasToolStripMenuItem"
        Me.RegisrarComprasToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.RegisrarComprasToolStripMenuItem.Text = "Registrar Compras"
        '
        'mniConsultarEntradaMaterial
        '
        Me.mniConsultarEntradaMaterial.Name = "mniConsultarEntradaMaterial"
        Me.mniConsultarEntradaMaterial.Size = New System.Drawing.Size(176, 22)
        Me.mniConsultarEntradaMaterial.Text = "Consultar Compras"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'mniRegistrarSalidas
        '
        Me.mniRegistrarSalidas.Name = "mniRegistrarSalidas"
        Me.mniRegistrarSalidas.Size = New System.Drawing.Size(176, 22)
        Me.mniRegistrarSalidas.Text = "Registrar Salidas"
        '
        'mniConsultarSalidas
        '
        Me.mniConsultarSalidas.Name = "mniConsultarSalidas"
        Me.mniConsultarSalidas.Size = New System.Drawing.Size(176, 22)
        Me.mniConsultarSalidas.Text = "Consultar Salidas"
        '
        'mniPagos
        '
        Me.mniPagos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniRegistrarPago, Me.mniConsultarPagos})
        Me.mniPagos.Name = "mniPagos"
        Me.mniPagos.Size = New System.Drawing.Size(174, 22)
        Me.mniPagos.Text = "Pagos"
        '
        'mniRegistrarPago
        '
        Me.mniRegistrarPago.Name = "mniRegistrarPago"
        Me.mniRegistrarPago.Size = New System.Drawing.Size(160, 22)
        Me.mniRegistrarPago.Text = "Registrar Pago"
        '
        'mniConsultarPagos
        '
        Me.mniConsultarPagos.Name = "mniConsultarPagos"
        Me.mniConsultarPagos.Size = New System.Drawing.Size(160, 22)
        Me.mniConsultarPagos.Text = "Consultar Pagos"
        '
        'mniReportes
        '
        Me.mniReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniReportesCuentas, Me.mniCuentasPorCalle, Me.mniReporteCalles, Me.mniReporteMaterialesExistencia, Me.mniReporteEmpleados, Me.mniReporteGastos, Me.mniReporteTarifas, Me.mniReportePozos})
        Me.mniReportes.Name = "mniReportes"
        Me.mniReportes.Size = New System.Drawing.Size(65, 20)
        Me.mniReportes.Text = "Reportes"
        '
        'mniReportesCuentas
        '
        Me.mniReportesCuentas.Name = "mniReportesCuentas"
        Me.mniReportesCuentas.Size = New System.Drawing.Size(205, 22)
        Me.mniReportesCuentas.Text = "Cuentas"
        '
        'mniCuentasPorCalle
        '
        Me.mniCuentasPorCalle.Name = "mniCuentasPorCalle"
        Me.mniCuentasPorCalle.Size = New System.Drawing.Size(205, 22)
        Me.mniCuentasPorCalle.Text = "Clientes por calle"
        '
        'mniReporteCalles
        '
        Me.mniReporteCalles.Name = "mniReporteCalles"
        Me.mniReporteCalles.Size = New System.Drawing.Size(205, 22)
        Me.mniReporteCalles.Text = "Calles"
        '
        'mniReporteMaterialesExistencia
        '
        Me.mniReporteMaterialesExistencia.Name = "mniReporteMaterialesExistencia"
        Me.mniReporteMaterialesExistencia.Size = New System.Drawing.Size(205, 22)
        Me.mniReporteMaterialesExistencia.Text = "Materiales con existencia"
        '
        'mniReporteEmpleados
        '
        Me.mniReporteEmpleados.Name = "mniReporteEmpleados"
        Me.mniReporteEmpleados.Size = New System.Drawing.Size(205, 22)
        Me.mniReporteEmpleados.Text = "Empleados"
        '
        'mniReporteGastos
        '
        Me.mniReporteGastos.Name = "mniReporteGastos"
        Me.mniReporteGastos.Size = New System.Drawing.Size(205, 22)
        Me.mniReporteGastos.Text = "Gastos"
        '
        'mniReporteTarifas
        '
        Me.mniReporteTarifas.Name = "mniReporteTarifas"
        Me.mniReporteTarifas.Size = New System.Drawing.Size(205, 22)
        Me.mniReporteTarifas.Text = "Tarifas"
        '
        'mniReportePozos
        '
        Me.mniReportePozos.Name = "mniReportePozos"
        Me.mniReportePozos.Size = New System.Drawing.Size(205, 22)
        Me.mniReportePozos.Text = "Pozos"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 395)
        Me.Controls.Add(Me.mnsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnsMenu
        Me.MaximizeBox = False
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Pagos y Servicios de Agua Potable  - SPAP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnsMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mniArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniCatalogos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniGastos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniCalles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniMateriales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniPozos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniServicios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniCuentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniEmpleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniTarifas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSituaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniMovimientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniActividadPozos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniGastosRealizados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniMovimientoMateriales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniConsultarEntradaMaterial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisrarComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniRegistrarSalidas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniConsultarSalidas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mniPagos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniRegistrarPago As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniConsultarPagos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniReportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniReportesCuentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniCuentasPorCalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniReporteCalles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniReporteMaterialesExistencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniReporteEmpleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniReporteGastos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniReporteTarifas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniReportePozos As System.Windows.Forms.ToolStripMenuItem
End Class
