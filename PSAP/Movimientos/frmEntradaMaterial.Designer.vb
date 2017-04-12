<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntradaMaterial
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidProveedor = New System.Windows.Forms.TextBox()
        Me.lblIdGasto = New System.Windows.Forms.Label()
        Me.txtidEntradaMaterial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gboxProveedor = New System.Windows.Forms.GroupBox()
        Me.cboxProveedor = New System.Windows.Forms.ComboBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gboxMaterial = New System.Windows.Forms.GroupBox()
        Me.cboxMaterial = New System.Windows.Forms.ComboBox()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.txtCosto = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCostoAnterior = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtidMaterial = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgDetalleEntradaMaterial = New System.Windows.Forms.DataGridView()
        Me.idMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.gboxProveedor.SuspendLayout()
        Me.gboxMaterial.SuspendLayout()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetalleEntradaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 22)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Proveedor:"
        '
        'txtidProveedor
        '
        Me.txtidProveedor.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidProveedor.Location = New System.Drawing.Point(47, 53)
        Me.txtidProveedor.MaxLength = 49
        Me.txtidProveedor.Name = "txtidProveedor"
        Me.txtidProveedor.ReadOnly = True
        Me.txtidProveedor.Size = New System.Drawing.Size(98, 26)
        Me.txtidProveedor.TabIndex = 83
        '
        'lblIdGasto
        '
        Me.lblIdGasto.AutoSize = True
        Me.lblIdGasto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdGasto.Location = New System.Drawing.Point(12, 25)
        Me.lblIdGasto.Name = "lblIdGasto"
        Me.lblIdGasto.Size = New System.Drawing.Size(132, 22)
        Me.lblIdGasto.TabIndex = 85
        Me.lblIdGasto.Text = "ID de Entrada:"
        '
        'txtidEntradaMaterial
        '
        Me.txtidEntradaMaterial.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidEntradaMaterial.Location = New System.Drawing.Point(157, 25)
        Me.txtidEntradaMaterial.MaxLength = 49
        Me.txtidEntradaMaterial.Name = "txtidEntradaMaterial"
        Me.txtidEntradaMaterial.ReadOnly = True
        Me.txtidEntradaMaterial.Size = New System.Drawing.Size(110, 26)
        Me.txtidEntradaMaterial.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Teléfono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 22)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Domicilio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 22)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "No. de Factura:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 22)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "ID:"
        '
        'gboxProveedor
        '
        Me.gboxProveedor.Controls.Add(Me.cboxProveedor)
        Me.gboxProveedor.Controls.Add(Me.txtDomicilio)
        Me.gboxProveedor.Controls.Add(Me.txtTelefono)
        Me.gboxProveedor.Controls.Add(Me.Label5)
        Me.gboxProveedor.Controls.Add(Me.Label4)
        Me.gboxProveedor.Controls.Add(Me.Label2)
        Me.gboxProveedor.Controls.Add(Me.txtidProveedor)
        Me.gboxProveedor.Controls.Add(Me.Label1)
        Me.gboxProveedor.Location = New System.Drawing.Point(288, 9)
        Me.gboxProveedor.Name = "gboxProveedor"
        Me.gboxProveedor.Size = New System.Drawing.Size(438, 127)
        Me.gboxProveedor.TabIndex = 90
        Me.gboxProveedor.TabStop = False
        '
        'cboxProveedor
        '
        Me.cboxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxProveedor.Enabled = False
        Me.cboxProveedor.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxProveedor.FormattingEnabled = True
        Me.cboxProveedor.Location = New System.Drawing.Point(116, 16)
        Me.cboxProveedor.Name = "cboxProveedor"
        Me.cboxProveedor.Size = New System.Drawing.Size(302, 26)
        Me.cboxProveedor.TabIndex = 111
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtDomicilio.Location = New System.Drawing.Point(105, 93)
        Me.txtDomicilio.MaxLength = 49
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.ReadOnly = True
        Me.txtDomicilio.Size = New System.Drawing.Size(313, 26)
        Me.txtDomicilio.TabIndex = 91
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(255, 53)
        Me.txtTelefono.MaxLength = 49
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(163, 26)
        Me.txtTelefono.TabIndex = 90
        '
        'txtFactura
        '
        Me.txtFactura.Enabled = False
        Me.txtFactura.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtFactura.Location = New System.Drawing.Point(157, 61)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(110, 26)
        Me.txtFactura.TabIndex = 91
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(99, 97)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(168, 26)
        Me.dtpFecha.TabIndex = 93
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Fecha:"
        '
        'gboxMaterial
        '
        Me.gboxMaterial.Controls.Add(Me.cboxMaterial)
        Me.gboxMaterial.Controls.Add(Me.cmdAgregar)
        Me.gboxMaterial.Controls.Add(Me.txtCosto)
        Me.gboxMaterial.Controls.Add(Me.Label13)
        Me.gboxMaterial.Controls.Add(Me.txtCantidad)
        Me.gboxMaterial.Controls.Add(Me.Label14)
        Me.gboxMaterial.Controls.Add(Me.txtUnidades)
        Me.gboxMaterial.Controls.Add(Me.txtMaximo)
        Me.gboxMaterial.Controls.Add(Me.Label12)
        Me.gboxMaterial.Controls.Add(Me.txtMinimo)
        Me.gboxMaterial.Controls.Add(Me.Label11)
        Me.gboxMaterial.Controls.Add(Me.txtExistencia)
        Me.gboxMaterial.Controls.Add(Me.Label10)
        Me.gboxMaterial.Controls.Add(Me.txtCostoAnterior)
        Me.gboxMaterial.Controls.Add(Me.Label9)
        Me.gboxMaterial.Controls.Add(Me.txtidMaterial)
        Me.gboxMaterial.Controls.Add(Me.Label8)
        Me.gboxMaterial.Controls.Add(Me.Label7)
        Me.gboxMaterial.Location = New System.Drawing.Point(17, 142)
        Me.gboxMaterial.Name = "gboxMaterial"
        Me.gboxMaterial.Size = New System.Drawing.Size(715, 131)
        Me.gboxMaterial.TabIndex = 94
        Me.gboxMaterial.TabStop = False
        '
        'cboxMaterial
        '
        Me.cboxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxMaterial.Enabled = False
        Me.cboxMaterial.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxMaterial.FormattingEnabled = True
        Me.cboxMaterial.Location = New System.Drawing.Point(92, 16)
        Me.cboxMaterial.Name = "cboxMaterial"
        Me.cboxMaterial.Size = New System.Drawing.Size(314, 26)
        Me.cboxMaterial.TabIndex = 110
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Enabled = False
        Me.cmdAgregar.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAgregar.Location = New System.Drawing.Point(589, 85)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(120, 35)
        Me.cmdAgregar.TabIndex = 109
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'txtCosto
        '
        Me.txtCosto.DecimalPlaces = 2
        Me.txtCosto.Enabled = False
        Me.txtCosto.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCosto.Location = New System.Drawing.Point(453, 94)
        Me.txtCosto.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(102, 26)
        Me.txtCosto.TabIndex = 108
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(365, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 22)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "Costo: $"
        '
        'txtCantidad
        '
        Me.txtCantidad.DecimalPlaces = 2
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCantidad.Location = New System.Drawing.Point(105, 94)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(102, 26)
        Me.txtCantidad.TabIndex = 106
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 22)
        Me.Label14.TabIndex = 105
        Me.Label14.Text = "Cantidad:"
        '
        'txtUnidades
        '
        Me.txtUnidades.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtUnidades.Location = New System.Drawing.Point(220, 94)
        Me.txtUnidades.MaxLength = 49
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.ReadOnly = True
        Me.txtUnidades.Size = New System.Drawing.Size(118, 26)
        Me.txtUnidades.TabIndex = 103
        '
        'txtMaximo
        '
        Me.txtMaximo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtMaximo.Location = New System.Drawing.Point(320, 58)
        Me.txtMaximo.MaxLength = 49
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.ReadOnly = True
        Me.txtMaximo.Size = New System.Drawing.Size(86, 26)
        Me.txtMaximo.TabIndex = 101
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(267, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 22)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "Max:"
        '
        'txtMinimo
        '
        Me.txtMinimo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtMinimo.Location = New System.Drawing.Point(469, 58)
        Me.txtMinimo.MaxLength = 49
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.ReadOnly = True
        Me.txtMinimo.Size = New System.Drawing.Size(86, 26)
        Me.txtMinimo.TabIndex = 99
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(425, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 22)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Min:"
        '
        'txtExistencia
        '
        Me.txtExistencia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtExistencia.Location = New System.Drawing.Point(611, 16)
        Me.txtExistencia.MaxLength = 49
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.ReadOnly = True
        Me.txtExistencia.Size = New System.Drawing.Size(98, 26)
        Me.txtExistencia.TabIndex = 97
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(544, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 22)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Exist.:"
        '
        'txtCostoAnterior
        '
        Me.txtCostoAnterior.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCostoAnterior.Location = New System.Drawing.Point(141, 58)
        Me.txtCostoAnterior.MaxLength = 49
        Me.txtCostoAnterior.Name = "txtCostoAnterior"
        Me.txtCostoAnterior.ReadOnly = True
        Me.txtCostoAnterior.Size = New System.Drawing.Size(110, 26)
        Me.txtCostoAnterior.TabIndex = 95
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 22)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "Costo Anterior:"
        '
        'txtidMaterial
        '
        Me.txtidMaterial.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidMaterial.Location = New System.Drawing.Point(443, 16)
        Me.txtidMaterial.MaxLength = 49
        Me.txtidMaterial.Name = "txtidMaterial"
        Me.txtidMaterial.ReadOnly = True
        Me.txtidMaterial.Size = New System.Drawing.Size(84, 26)
        Me.txtidMaterial.TabIndex = 92
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(412, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 22)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 22)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Material:"
        '
        'dgDetalleEntradaMaterial
        '
        Me.dgDetalleEntradaMaterial.AllowUserToAddRows = False
        Me.dgDetalleEntradaMaterial.AllowUserToDeleteRows = False
        Me.dgDetalleEntradaMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalleEntradaMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMaterial, Me.material, Me.cantidad, Me.costo, Me.importe})
        Me.dgDetalleEntradaMaterial.Location = New System.Drawing.Point(17, 278)
        Me.dgDetalleEntradaMaterial.Name = "dgDetalleEntradaMaterial"
        Me.dgDetalleEntradaMaterial.ReadOnly = True
        Me.dgDetalleEntradaMaterial.Size = New System.Drawing.Size(715, 187)
        Me.dgDetalleEntradaMaterial.TabIndex = 110
        '
        'idMaterial
        '
        Me.idMaterial.HeaderText = "ID de Material"
        Me.idMaterial.Name = "idMaterial"
        Me.idMaterial.ReadOnly = True
        Me.idMaterial.Width = 75
        '
        'material
        '
        Me.material.HeaderText = "Material"
        Me.material.Name = "material"
        Me.material.ReadOnly = True
        Me.material.Width = 285
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'costo
        '
        Me.costo.HeaderText = "Costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        '
        'importe
        '
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(269, 534)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 113
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(143, 534)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 112
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(17, 534)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 111
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSubtotal.Location = New System.Drawing.Point(614, 472)
        Me.txtSubtotal.MaxLength = 49
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(118, 26)
        Me.txtSubtotal.TabIndex = 110
        '
        'txtIva
        '
        Me.txtIva.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtIva.Location = New System.Drawing.Point(614, 504)
        Me.txtIva.MaxLength = 49
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(118, 26)
        Me.txtIva.TabIndex = 114
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTotal.Location = New System.Drawing.Point(614, 534)
        Me.txtTotal.MaxLength = 49
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(118, 26)
        Me.txtTotal.TabIndex = 115
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(508, 476)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 22)
        Me.Label15.TabIndex = 110
        Me.Label15.Text = "Subtotal: $"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(546, 508)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 22)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "IVA: $"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(537, 538)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 22)
        Me.Label17.TabIndex = 116
        Me.Label17.Text = "Total: $"
        '
        'frmEntradaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(744, 581)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.dgDetalleEntradaMaterial)
        Me.Controls.Add(Me.gboxMaterial)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.gboxProveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblIdGasto)
        Me.Controls.Add(Me.txtidEntradaMaterial)
        Me.Name = "frmEntradaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Compra de Material"
        Me.gboxProveedor.ResumeLayout(False)
        Me.gboxProveedor.PerformLayout()
        Me.gboxMaterial.ResumeLayout(False)
        Me.gboxMaterial.PerformLayout()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetalleEntradaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtidProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblIdGasto As System.Windows.Forms.Label
    Friend WithEvents txtidEntradaMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gboxProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gboxMaterial As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaximo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMinimo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtExistencia As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCostoAnterior As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtidMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents txtCosto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents dgDetalleEntradaMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents idMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboxProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cboxMaterial As System.Windows.Forms.ComboBox
End Class
