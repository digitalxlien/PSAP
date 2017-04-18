<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagos))
        Me.txtidPago = New System.Windows.Forms.TextBox()
        Me.lblIDMaterial = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboxCuenta = New System.Windows.Forms.GroupBox()
        Me.txtFechaAlta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdBuscarCuenta = New System.Windows.Forms.Button()
        Me.txtUltimoPeriodoPagado = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtidCuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.dgAgua = New System.Windows.Forms.DataGridView()
        Me.anio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mesInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mesFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coutaFija = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.infra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.situacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgServicios = New System.Windows.Forms.DataGridView()
        Me.servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cmdCargarPagoServicios = New System.Windows.Forms.Button()
        Me.cmdCargarPagoAgua = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOtros = New System.Windows.Forms.NumericUpDown()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gboxCuenta.SuspendLayout()
        CType(Me.dgAgua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidPago
        '
        Me.txtidPago.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidPago.Location = New System.Drawing.Point(130, 18)
        Me.txtidPago.Name = "txtidPago"
        Me.txtidPago.ReadOnly = True
        Me.txtidPago.Size = New System.Drawing.Size(308, 26)
        Me.txtidPago.TabIndex = 59
        '
        'lblIDMaterial
        '
        Me.lblIDMaterial.AutoSize = True
        Me.lblIDMaterial.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDMaterial.Location = New System.Drawing.Point(12, 20)
        Me.lblIDMaterial.Name = "lblIDMaterial"
        Me.lblIDMaterial.Size = New System.Drawing.Size(112, 22)
        Me.lblIDMaterial.TabIndex = 60
        Me.lblIDMaterial.Text = "ID de Pago:"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(86, 54)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(352, 26)
        Me.txtFecha.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Fecha:"
        '
        'gboxCuenta
        '
        Me.gboxCuenta.Controls.Add(Me.Label5)
        Me.gboxCuenta.Controls.Add(Me.txtFechaAlta)
        Me.gboxCuenta.Controls.Add(Me.Label4)
        Me.gboxCuenta.Controls.Add(Me.cmdBuscarCuenta)
        Me.gboxCuenta.Controls.Add(Me.txtUltimoPeriodoPagado)
        Me.gboxCuenta.Controls.Add(Me.txtDomicilio)
        Me.gboxCuenta.Controls.Add(Me.Label3)
        Me.gboxCuenta.Controls.Add(Me.txtNombre)
        Me.gboxCuenta.Controls.Add(Me.txtidCuenta)
        Me.gboxCuenta.Controls.Add(Me.Label2)
        Me.gboxCuenta.Controls.Add(Me.lblExistencia)
        Me.gboxCuenta.Location = New System.Drawing.Point(12, 86)
        Me.gboxCuenta.Name = "gboxCuenta"
        Me.gboxCuenta.Size = New System.Drawing.Size(426, 257)
        Me.gboxCuenta.TabIndex = 63
        Me.gboxCuenta.TabStop = False
        '
        'txtFechaAlta
        '
        Me.txtFechaAlta.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtFechaAlta.Location = New System.Drawing.Point(152, 137)
        Me.txtFechaAlta.MaxLength = 49
        Me.txtFechaAlta.Name = "txtFechaAlta"
        Me.txtFechaAlta.ReadOnly = True
        Me.txtFechaAlta.Size = New System.Drawing.Size(258, 26)
        Me.txtFechaAlta.TabIndex = 142
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 22)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Fecha de alta:"
        '
        'cmdBuscarCuenta
        '
        Me.cmdBuscarCuenta.Image = CType(resources.GetObject("cmdBuscarCuenta.Image"), System.Drawing.Image)
        Me.cmdBuscarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBuscarCuenta.Location = New System.Drawing.Point(248, 216)
        Me.cmdBuscarCuenta.Name = "cmdBuscarCuenta"
        Me.cmdBuscarCuenta.Size = New System.Drawing.Size(162, 35)
        Me.cmdBuscarCuenta.TabIndex = 141
        Me.cmdBuscarCuenta.Text = "Buscar cuenta"
        Me.cmdBuscarCuenta.UseVisualStyleBackColor = True
        '
        'txtUltimoPeriodoPagado
        '
        Me.txtUltimoPeriodoPagado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtUltimoPeriodoPagado.Location = New System.Drawing.Point(200, 178)
        Me.txtUltimoPeriodoPagado.MaxLength = 49
        Me.txtUltimoPeriodoPagado.Name = "txtUltimoPeriodoPagado"
        Me.txtUltimoPeriodoPagado.ReadOnly = True
        Me.txtUltimoPeriodoPagado.Size = New System.Drawing.Size(210, 26)
        Me.txtUltimoPeriodoPagado.TabIndex = 64
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtDomicilio.Location = New System.Drawing.Point(152, 93)
        Me.txtDomicilio.MaxLength = 49
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.ReadOnly = True
        Me.txtDomicilio.Size = New System.Drawing.Size(258, 26)
        Me.txtDomicilio.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 22)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Domicilio:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(152, 58)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(258, 26)
        Me.txtNombre.TabIndex = 64
        '
        'txtidCuenta
        '
        Me.txtidCuenta.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidCuenta.Location = New System.Drawing.Point(152, 22)
        Me.txtidCuenta.MaxLength = 49
        Me.txtidCuenta.Name = "txtidCuenta"
        Me.txtidCuenta.ReadOnly = True
        Me.txtidCuenta.Size = New System.Drawing.Size(155, 26)
        Me.txtidCuenta.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 22)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Nombre:"
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistencia.Location = New System.Drawing.Point(19, 26)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(127, 22)
        Me.lblExistencia.TabIndex = 62
        Me.lblExistencia.Text = "ID de Cuenta:"
        '
        'dgAgua
        '
        Me.dgAgua.AllowUserToAddRows = False
        Me.dgAgua.AllowUserToDeleteRows = False
        Me.dgAgua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAgua.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.anio, Me.mesInicio, Me.mesFin, Me.coutaFija, Me.recargos, Me.tar, Me.infra, Me.situacion, Me.descuento, Me.importe})
        Me.dgAgua.Location = New System.Drawing.Point(457, 48)
        Me.dgAgua.Name = "dgAgua"
        Me.dgAgua.ReadOnly = True
        Me.dgAgua.Size = New System.Drawing.Size(772, 150)
        Me.dgAgua.TabIndex = 143
        '
        'anio
        '
        Me.anio.HeaderText = "Año"
        Me.anio.Name = "anio"
        Me.anio.ReadOnly = True
        Me.anio.Width = 50
        '
        'mesInicio
        '
        Me.mesInicio.HeaderText = "Mes Inicial"
        Me.mesInicio.Name = "mesInicio"
        Me.mesInicio.ReadOnly = True
        Me.mesInicio.Width = 60
        '
        'mesFin
        '
        Me.mesFin.HeaderText = "Mes Final"
        Me.mesFin.Name = "mesFin"
        Me.mesFin.ReadOnly = True
        Me.mesFin.Width = 60
        '
        'coutaFija
        '
        Me.coutaFija.HeaderText = "Cuota Fija"
        Me.coutaFija.Name = "coutaFija"
        Me.coutaFija.ReadOnly = True
        Me.coutaFija.Width = 75
        '
        'recargos
        '
        Me.recargos.HeaderText = "Recargos"
        Me.recargos.Name = "recargos"
        Me.recargos.ReadOnly = True
        Me.recargos.Width = 75
        '
        'tar
        '
        Me.tar.HeaderText = "T.A.R."
        Me.tar.Name = "tar"
        Me.tar.ReadOnly = True
        Me.tar.Width = 75
        '
        'infra
        '
        Me.infra.HeaderText = "Infraestructura"
        Me.infra.Name = "infra"
        Me.infra.ReadOnly = True
        Me.infra.Width = 75
        '
        'situacion
        '
        Me.situacion.HeaderText = "Situacion"
        Me.situacion.Name = "situacion"
        Me.situacion.ReadOnly = True
        Me.situacion.Width = 75
        '
        'descuento
        '
        Me.descuento.HeaderText = "Descuento"
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        Me.descuento.Width = 80
        '
        'importe
        '
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'dgServicios
        '
        Me.dgServicios.AllowUserToAddRows = False
        Me.dgServicios.AllowUserToDeleteRows = False
        Me.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.servicio, Me.empleado, Me.precio})
        Me.dgServicios.Location = New System.Drawing.Point(457, 246)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.ReadOnly = True
        Me.dgServicios.Size = New System.Drawing.Size(772, 150)
        Me.dgServicios.TabIndex = 144
        '
        'servicio
        '
        Me.servicio.HeaderText = "Servicio"
        Me.servicio.Name = "servicio"
        Me.servicio.ReadOnly = True
        Me.servicio.Width = 325
        '
        'empleado
        '
        Me.empleado.HeaderText = "Empleado"
        Me.empleado.Name = "empleado"
        Me.empleado.ReadOnly = True
        Me.empleado.Width = 300
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(453, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 22)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Detalle del pago de agua:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(453, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(260, 22)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "Detalle del pago de servicios:"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(975, 416)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(71, 22)
        Me.Total.TabIndex = 147
        Me.Total.Text = "Total $:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(1070, 412)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(159, 32)
        Me.txtTotal.TabIndex = 148
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdCargarPagoServicios
        '
        Me.cmdCargarPagoServicios.Image = CType(resources.GetObject("cmdCargarPagoServicios.Image"), System.Drawing.Image)
        Me.cmdCargarPagoServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCargarPagoServicios.Location = New System.Drawing.Point(16, 412)
        Me.cmdCargarPagoServicios.Name = "cmdCargarPagoServicios"
        Me.cmdCargarPagoServicios.Size = New System.Drawing.Size(422, 35)
        Me.cmdCargarPagoServicios.TabIndex = 142
        Me.cmdCargarPagoServicios.Text = "Cargar pago de servicio"
        Me.cmdCargarPagoServicios.UseVisualStyleBackColor = True
        '
        'cmdCargarPagoAgua
        '
        Me.cmdCargarPagoAgua.Image = CType(resources.GetObject("cmdCargarPagoAgua.Image"), System.Drawing.Image)
        Me.cmdCargarPagoAgua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCargarPagoAgua.Location = New System.Drawing.Point(16, 361)
        Me.cmdCargarPagoAgua.Name = "cmdCargarPagoAgua"
        Me.cmdCargarPagoAgua.Size = New System.Drawing.Size(422, 35)
        Me.cmdCargarPagoAgua.TabIndex = 141
        Me.cmdCargarPagoAgua.Text = "Cargar pago de agua"
        Me.cmdCargarPagoAgua.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(1109, 459)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 149
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(979, 459)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 150
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(453, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 22)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Otros:"
        '
        'txtOtros
        '
        Me.txtOtros.DecimalPlaces = 2
        Me.txtOtros.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtros.Location = New System.Drawing.Point(521, 416)
        Me.txtOtros.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(120, 26)
        Me.txtOtros.TabIndex = 152
        Me.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(853, 459)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(120, 35)
        Me.cmdImprimir.TabIndex = 153
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(727, 459)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 154
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 22)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Último mes pagado:"
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 506)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.txtOtros)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgServicios)
        Me.Controls.Add(Me.dgAgua)
        Me.Controls.Add(Me.cmdCargarPagoServicios)
        Me.Controls.Add(Me.cmdCargarPagoAgua)
        Me.Controls.Add(Me.gboxCuenta)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidPago)
        Me.Controls.Add(Me.lblIDMaterial)
        Me.Name = "frmPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pago de Agua y de Servicios"
        Me.gboxCuenta.ResumeLayout(False)
        Me.gboxCuenta.PerformLayout()
        CType(Me.dgAgua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtidPago As System.Windows.Forms.TextBox
    Friend WithEvents lblIDMaterial As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gboxCuenta As System.Windows.Forms.GroupBox
    Friend WithEvents txtUltimoPeriodoPagado As System.Windows.Forms.TextBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtidCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents cmdBuscarCuenta As System.Windows.Forms.Button
    Friend WithEvents cmdCargarPagoAgua As System.Windows.Forms.Button
    Friend WithEvents cmdCargarPagoServicios As System.Windows.Forms.Button
    Friend WithEvents txtFechaAlta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgAgua As System.Windows.Forms.DataGridView
    Friend WithEvents dgServicios As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents servicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents anio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mesInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mesFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coutaFija As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents recargos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents infra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents situacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOtros As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
