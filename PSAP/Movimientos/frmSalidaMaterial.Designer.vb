<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalidaMaterial
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
        Me.dgDetalleSalidaMaterial = New System.Windows.Forms.DataGridView()
        Me.idMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gboxMaterial = New System.Windows.Forms.GroupBox()
        Me.cboxMaterial = New System.Windows.Forms.ComboBox()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.label34 = New System.Windows.Forms.Label()
        Me.txtidMaterial = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gboxProveedor = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.cboxCalle = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIdGasto = New System.Windows.Forms.Label()
        Me.txtidSalidaMaterial = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgDetalleSalidaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxMaterial.SuspendLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxProveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgDetalleSalidaMaterial
        '
        Me.dgDetalleSalidaMaterial.AllowUserToAddRows = False
        Me.dgDetalleSalidaMaterial.AllowUserToDeleteRows = False
        Me.dgDetalleSalidaMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalleSalidaMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMaterial, Me.material, Me.cantidad, Me.costo, Me.importe})
        Me.dgDetalleSalidaMaterial.Location = New System.Drawing.Point(17, 278)
        Me.dgDetalleSalidaMaterial.Name = "dgDetalleSalidaMaterial"
        Me.dgDetalleSalidaMaterial.ReadOnly = True
        Me.dgDetalleSalidaMaterial.Size = New System.Drawing.Size(715, 187)
        Me.dgDetalleSalidaMaterial.TabIndex = 119
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
        'gboxMaterial
        '
        Me.gboxMaterial.Controls.Add(Me.cboxMaterial)
        Me.gboxMaterial.Controls.Add(Me.cmdAgregar)
        Me.gboxMaterial.Controls.Add(Me.txtCantidad)
        Me.gboxMaterial.Controls.Add(Me.Label14)
        Me.gboxMaterial.Controls.Add(Me.txtUnidades)
        Me.gboxMaterial.Controls.Add(Me.txtMaximo)
        Me.gboxMaterial.Controls.Add(Me.Label12)
        Me.gboxMaterial.Controls.Add(Me.txtMinimo)
        Me.gboxMaterial.Controls.Add(Me.Label11)
        Me.gboxMaterial.Controls.Add(Me.txtExistencia)
        Me.gboxMaterial.Controls.Add(Me.Label10)
        Me.gboxMaterial.Controls.Add(Me.txtCosto)
        Me.gboxMaterial.Controls.Add(Me.label34)
        Me.gboxMaterial.Controls.Add(Me.txtidMaterial)
        Me.gboxMaterial.Controls.Add(Me.Label8)
        Me.gboxMaterial.Controls.Add(Me.Label7)
        Me.gboxMaterial.Location = New System.Drawing.Point(17, 142)
        Me.gboxMaterial.Name = "gboxMaterial"
        Me.gboxMaterial.Size = New System.Drawing.Size(715, 131)
        Me.gboxMaterial.TabIndex = 118
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
        Me.txtUnidades.Size = New System.Drawing.Size(136, 26)
        Me.txtUnidades.TabIndex = 103
        '
        'txtMaximo
        '
        Me.txtMaximo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtMaximo.Location = New System.Drawing.Point(271, 58)
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
        Me.Label12.Location = New System.Drawing.Point(216, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 22)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "Max:"
        '
        'txtMinimo
        '
        Me.txtMinimo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtMinimo.Location = New System.Drawing.Point(462, 58)
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
        Me.Label11.Location = New System.Drawing.Point(412, 58)
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
        'txtCosto
        '
        Me.txtCosto.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCosto.Location = New System.Drawing.Point(92, 58)
        Me.txtCosto.MaxLength = 49
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.ReadOnly = True
        Me.txtCosto.Size = New System.Drawing.Size(115, 26)
        Me.txtCosto.TabIndex = 95
        '
        'label34
        '
        Me.label34.AutoSize = True
        Me.label34.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label34.Location = New System.Drawing.Point(6, 58)
        Me.label34.Name = "label34"
        Me.label34.Size = New System.Drawing.Size(82, 22)
        Me.label34.TabIndex = 96
        Me.label34.Text = "Costo: $"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Fecha:"
        '
        'gboxProveedor
        '
        Me.gboxProveedor.Controls.Add(Me.Label2)
        Me.gboxProveedor.Controls.Add(Me.txtConcepto)
        Me.gboxProveedor.Controls.Add(Me.cboxCalle)
        Me.gboxProveedor.Controls.Add(Me.Label1)
        Me.gboxProveedor.Controls.Add(Me.cboxEmpleado)
        Me.gboxProveedor.Controls.Add(Me.Label5)
        Me.gboxProveedor.Location = New System.Drawing.Point(309, 9)
        Me.gboxProveedor.Name = "gboxProveedor"
        Me.gboxProveedor.Size = New System.Drawing.Size(417, 127)
        Me.gboxProveedor.TabIndex = 114
        Me.gboxProveedor.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 22)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Concepto:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Enabled = False
        Me.txtConcepto.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtConcepto.Location = New System.Drawing.Point(116, 95)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(281, 26)
        Me.txtConcepto.TabIndex = 114
        '
        'cboxCalle
        '
        Me.cboxCalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCalle.Enabled = False
        Me.cboxCalle.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxCalle.FormattingEnabled = True
        Me.cboxCalle.Location = New System.Drawing.Point(116, 56)
        Me.cboxCalle.Name = "cboxCalle"
        Me.cboxCalle.Size = New System.Drawing.Size(295, 26)
        Me.cboxCalle.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 22)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Calle:"
        '
        'cboxEmpleado
        '
        Me.cboxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEmpleado.Enabled = False
        Me.cboxEmpleado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxEmpleado.FormattingEnabled = True
        Me.cboxEmpleado.Location = New System.Drawing.Point(116, 16)
        Me.cboxEmpleado.Name = "cboxEmpleado"
        Me.cboxEmpleado.Size = New System.Drawing.Size(295, 26)
        Me.cboxEmpleado.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 22)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Empleado:"
        '
        'lblIdGasto
        '
        Me.lblIdGasto.AutoSize = True
        Me.lblIdGasto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdGasto.Location = New System.Drawing.Point(12, 25)
        Me.lblIdGasto.Name = "lblIdGasto"
        Me.lblIdGasto.Size = New System.Drawing.Size(114, 22)
        Me.lblIdGasto.TabIndex = 112
        Me.lblIdGasto.Text = "ID de Salida"
        '
        'txtidSalidaMaterial
        '
        Me.txtidSalidaMaterial.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidSalidaMaterial.Location = New System.Drawing.Point(157, 25)
        Me.txtidSalidaMaterial.MaxLength = 49
        Me.txtidSalidaMaterial.Name = "txtidSalidaMaterial"
        Me.txtidSalidaMaterial.ReadOnly = True
        Me.txtidSalidaMaterial.Size = New System.Drawing.Size(110, 26)
        Me.txtidSalidaMaterial.TabIndex = 111
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(537, 475)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 22)
        Me.Label17.TabIndex = 127
        Me.Label17.Text = "Total: $"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTotal.Location = New System.Drawing.Point(614, 471)
        Me.txtTotal.MaxLength = 49
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(118, 26)
        Me.txtTotal.TabIndex = 126
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(617, 514)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 124
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(491, 514)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 123
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(365, 514)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 122
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(100, 65)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(168, 26)
        Me.dtpFecha.TabIndex = 117
        '
        'frmSalidaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.dgDetalleSalidaMaterial)
        Me.Controls.Add(Me.gboxMaterial)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gboxProveedor)
        Me.Controls.Add(Me.lblIdGasto)
        Me.Controls.Add(Me.txtidSalidaMaterial)
        Me.Name = "frmSalidaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salida Material"
        CType(Me.dgDetalleSalidaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxMaterial.ResumeLayout(False)
        Me.gboxMaterial.PerformLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxProveedor.ResumeLayout(False)
        Me.gboxProveedor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgDetalleSalidaMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents idMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gboxMaterial As System.Windows.Forms.GroupBox
    Friend WithEvents cboxMaterial As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents txtMaximo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMinimo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtExistencia As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents label34 As System.Windows.Forms.Label
    Friend WithEvents txtidMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gboxProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents cboxEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblIdGasto As System.Windows.Forms.Label
    Friend WithEvents txtidSalidaMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents cboxCalle As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
End Class
