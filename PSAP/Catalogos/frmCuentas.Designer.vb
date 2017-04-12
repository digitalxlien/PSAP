<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentas
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
        Me.components = New System.ComponentModel.Container()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.CuentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPSAP = New PSAP.DataSetPSAP()
        Me.txtidCuenta = New System.Windows.Forms.TextBox()
        Me.lblidNombre = New System.Windows.Forms.Label()
        Me.lblidEmpleado = New System.Windows.Forms.Label()
        Me.dgCuentas = New System.Windows.Forms.DataGridView()
        Me.IdCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroExtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroIntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoAnioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoMesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.CuentaTableAdapter = New PSAP.DataSetPSAPTableAdapters.CuentaTableAdapter()
        Me.cboxCalle = New System.Windows.Forms.ComboBox()
        Me.CalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumExt = New System.Windows.Forms.TextBox()
        Me.txtNumInt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaUltimaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalleTableAdapter = New PSAP.DataSetPSAPTableAdapters.CalleTableAdapter()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.CuentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColonia.Location = New System.Drawing.Point(14, 122)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(79, 22)
        Me.lblColonia.TabIndex = 59
        Me.lblColonia.Text = "Colonia:"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Enabled = False
        Me.txtCodigoPostal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCodigoPostal.Location = New System.Drawing.Point(151, 166)
        Me.txtCodigoPostal.MaxLength = 49
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.ReadOnly = True
        Me.txtCodigoPostal.Size = New System.Drawing.Size(207, 26)
        Me.txtCodigoPostal.TabIndex = 48
        '
        'txtColonia
        '
        Me.txtColonia.Enabled = False
        Me.txtColonia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtColonia.Location = New System.Drawing.Point(151, 122)
        Me.txtColonia.MaxLength = 49
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.ReadOnly = True
        Me.txtColonia.Size = New System.Drawing.Size(411, 26)
        Me.txtColonia.TabIndex = 47
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoPostal.Location = New System.Drawing.Point(12, 166)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(133, 22)
        Me.lblCodigoPostal.TabIndex = 58
        Me.lblCodigoPostal.Text = "Código postal:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.Location = New System.Drawing.Point(16, 85)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(58, 22)
        Me.lblCalle.TabIndex = 57
        Me.lblCalle.Text = "Calle:"
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(261, 253)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 10
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(180, 253)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 9
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(99, 253)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 8
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(18, 253)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 7
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaBindingSource, "nombre", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(151, 44)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(411, 26)
        Me.txtNombre.TabIndex = 1
        '
        'CuentaBindingSource
        '
        Me.CuentaBindingSource.DataMember = "Cuenta"
        Me.CuentaBindingSource.DataSource = Me.DataSetPSAP
        '
        'DataSetPSAP
        '
        Me.DataSetPSAP.DataSetName = "DataSetPSAP"
        Me.DataSetPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtidCuenta
        '
        Me.txtidCuenta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidCuenta.Location = New System.Drawing.Point(151, 5)
        Me.txtidCuenta.Name = "txtidCuenta"
        Me.txtidCuenta.ReadOnly = True
        Me.txtidCuenta.Size = New System.Drawing.Size(162, 26)
        Me.txtidCuenta.TabIndex = 56
        '
        'lblidNombre
        '
        Me.lblidNombre.AutoSize = True
        Me.lblidNombre.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidNombre.Location = New System.Drawing.Point(12, 44)
        Me.lblidNombre.Name = "lblidNombre"
        Me.lblidNombre.Size = New System.Drawing.Size(83, 22)
        Me.lblidNombre.TabIndex = 55
        Me.lblidNombre.Text = "Nombre:"
        '
        'lblidEmpleado
        '
        Me.lblidEmpleado.AutoSize = True
        Me.lblidEmpleado.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidEmpleado.Location = New System.Drawing.Point(12, 9)
        Me.lblidEmpleado.Name = "lblidEmpleado"
        Me.lblidEmpleado.Size = New System.Drawing.Size(122, 22)
        Me.lblidEmpleado.TabIndex = 54
        Me.lblidEmpleado.Text = "ID de Cuenta"
        '
        'dgCuentas
        '
        Me.dgCuentas.AllowUserToAddRows = False
        Me.dgCuentas.AllowUserToDeleteRows = False
        Me.dgCuentas.AutoGenerateColumns = False
        Me.dgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCuentaDataGridViewTextBoxColumn, Me.IdCalleDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.NumeroExtDataGridViewTextBoxColumn, Me.NumeroIntDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.UltimoPagoAnioDataGridViewTextBoxColumn, Me.UltimoPagoMesDataGridViewTextBoxColumn})
        Me.dgCuentas.DataSource = Me.CuentaBindingSource
        Me.dgCuentas.Location = New System.Drawing.Point(18, 282)
        Me.dgCuentas.Name = "dgCuentas"
        Me.dgCuentas.ReadOnly = True
        Me.dgCuentas.Size = New System.Drawing.Size(1067, 292)
        Me.dgCuentas.TabIndex = 53
        '
        'IdCuentaDataGridViewTextBoxColumn
        '
        Me.IdCuentaDataGridViewTextBoxColumn.DataPropertyName = "idCuenta"
        Me.IdCuentaDataGridViewTextBoxColumn.HeaderText = "ID de Cuenta"
        Me.IdCuentaDataGridViewTextBoxColumn.Name = "IdCuentaDataGridViewTextBoxColumn"
        Me.IdCuentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCalleDataGridViewTextBoxColumn
        '
        Me.IdCalleDataGridViewTextBoxColumn.DataPropertyName = "idCalle"
        Me.IdCalleDataGridViewTextBoxColumn.HeaderText = "ID de Calle"
        Me.IdCalleDataGridViewTextBoxColumn.Name = "IdCalleDataGridViewTextBoxColumn"
        Me.IdCalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 300
        '
        'NumeroExtDataGridViewTextBoxColumn
        '
        Me.NumeroExtDataGridViewTextBoxColumn.DataPropertyName = "numeroExt"
        Me.NumeroExtDataGridViewTextBoxColumn.HeaderText = "No. Ext."
        Me.NumeroExtDataGridViewTextBoxColumn.Name = "NumeroExtDataGridViewTextBoxColumn"
        Me.NumeroExtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroIntDataGridViewTextBoxColumn
        '
        Me.NumeroIntDataGridViewTextBoxColumn.DataPropertyName = "numeroInt"
        Me.NumeroIntDataGridViewTextBoxColumn.HeaderText = "No. Int."
        Me.NumeroIntDataGridViewTextBoxColumn.Name = "NumeroIntDataGridViewTextBoxColumn"
        Me.NumeroIntDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "fechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "fechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimoPagoAnioDataGridViewTextBoxColumn
        '
        Me.UltimoPagoAnioDataGridViewTextBoxColumn.DataPropertyName = "ultimoPagoAnio"
        Me.UltimoPagoAnioDataGridViewTextBoxColumn.HeaderText = "ultimoPagoAnio"
        Me.UltimoPagoAnioDataGridViewTextBoxColumn.Name = "UltimoPagoAnioDataGridViewTextBoxColumn"
        Me.UltimoPagoAnioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimoPagoMesDataGridViewTextBoxColumn
        '
        Me.UltimoPagoMesDataGridViewTextBoxColumn.DataPropertyName = "ultimoPagoMes"
        Me.UltimoPagoMesDataGridViewTextBoxColumn.HeaderText = "ultimoPagoMes"
        Me.UltimoPagoMesDataGridViewTextBoxColumn.Name = "UltimoPagoMesDataGridViewTextBoxColumn"
        Me.UltimoPagoMesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(966, 580)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 13
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(840, 580)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 12
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(589, 580)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 11
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'CuentaTableAdapter
        '
        Me.CuentaTableAdapter.ClearBeforeFill = True
        '
        'cboxCalle
        '
        Me.cboxCalle.DataSource = Me.CalleBindingSource
        Me.cboxCalle.DisplayMember = "nombre"
        Me.cboxCalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCalle.Enabled = False
        Me.cboxCalle.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxCalle.FormattingEnabled = True
        Me.cboxCalle.Location = New System.Drawing.Point(151, 83)
        Me.cboxCalle.Name = "cboxCalle"
        Me.cboxCalle.Size = New System.Drawing.Size(411, 26)
        Me.cboxCalle.TabIndex = 2
        Me.cboxCalle.ValueMember = "idCalle"
        '
        'CalleBindingSource
        '
        Me.CalleBindingSource.DataMember = "Calle"
        Me.CalleBindingSource.DataSource = Me.DataSetPSAP
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(585, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 22)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "No. Ext."
        '
        'txtNumExt
        '
        Me.txtNumExt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaBindingSource, "numeroExt", True))
        Me.txtNumExt.Enabled = False
        Me.txtNumExt.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNumExt.Location = New System.Drawing.Point(667, 83)
        Me.txtNumExt.MaxLength = 49
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(94, 26)
        Me.txtNumExt.TabIndex = 3
        '
        'txtNumInt
        '
        Me.txtNumInt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaBindingSource, "numeroInt", True))
        Me.txtNumInt.Enabled = False
        Me.txtNumInt.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNumInt.Location = New System.Drawing.Point(889, 83)
        Me.txtNumInt.MaxLength = 49
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(73, 26)
        Me.txtNumInt.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(813, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 22)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "No. Int."
        '
        'dtpFechaUltimaCompra
        '
        Me.dtpFechaUltimaCompra.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CuentaBindingSource, "fechaAlta", True))
        Me.dtpFechaUltimaCompra.Enabled = False
        Me.dtpFechaUltimaCompra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaUltimaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaUltimaCompra.Location = New System.Drawing.Point(153, 210)
        Me.dtpFechaUltimaCompra.Name = "dtpFechaUltimaCompra"
        Me.dtpFechaUltimaCompra.Size = New System.Drawing.Size(151, 26)
        Me.dtpFechaUltimaCompra.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 22)
        Me.Label3.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 22)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Fecha de Alta:"
        '
        'CalleTableAdapter
        '
        Me.CalleTableAdapter.ClearBeforeFill = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.PSAP.My.Resources.Resources.cancel
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(715, 580)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(120, 35)
        Me.cmdCancelar.TabIndex = 75
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 626)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaUltimaCompra)
        Me.Controls.Add(Me.txtNumInt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumExt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxCalle)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.txtCodigoPostal)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.lblCodigoPostal)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtidCuenta)
        Me.Controls.Add(Me.lblidNombre)
        Me.Controls.Add(Me.lblidEmpleado)
        Me.Controls.Add(Me.dgCuentas)
        Me.Name = "frmCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas"
        CType(Me.CuentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColonia As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoPostal As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents cmdUltimo As System.Windows.Forms.Button
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents cmdInicio As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtidCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lblidNombre As System.Windows.Forms.Label
    Friend WithEvents lblidEmpleado As System.Windows.Forms.Label
    Friend WithEvents dgCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents DataSetPSAP As PSAP.DataSetPSAP
    Friend WithEvents CuentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuentaTableAdapter As PSAP.DataSetPSAPTableAdapters.CuentaTableAdapter
    Friend WithEvents cboxCalle As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumExt As System.Windows.Forms.TextBox
    Friend WithEvents txtNumInt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaUltimaCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IdCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroExtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroIntDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoAnioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoMesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalleTableAdapter As PSAP.DataSetPSAPTableAdapters.CalleTableAdapter
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
