<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastosRealizados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIdGasto = New System.Windows.Forms.Label()
        Me.lblUnidadMedida = New System.Windows.Forms.Label()
        Me.txtidGastoRealizado = New System.Windows.Forms.TextBox()
        Me.cboxEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gboxEmpleado = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtImporte = New System.Windows.Forms.NumericUpDown()
        Me.cboxConcepto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgGastosRealizados = New System.Windows.Forms.DataGridView()
        Me.idGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gboxConsulta = New System.Windows.Forms.GroupBox()
        Me.dtpConsultaFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboxConsultaEmpleado = New System.Windows.Forms.ComboBox()
        Me.cboxConsultaConcepto = New System.Windows.Forms.ComboBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.rbtnTodos = New System.Windows.Forms.RadioButton()
        Me.rbtnEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbtnConcepto = New System.Windows.Forms.RadioButton()
        Me.rbtnFecha = New System.Windows.Forms.RadioButton()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.gboxEmpleado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgGastosRealizados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtObservaciones.Location = New System.Drawing.Point(15, 125)
        Me.txtObservaciones.MaxLength = 49
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(365, 115)
        Me.txtObservaciones.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 22)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Observaciones:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(86, 44)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(268, 26)
        Me.dtpFecha.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Fecha:"
        '
        'lblIdGasto
        '
        Me.lblIdGasto.AutoSize = True
        Me.lblIdGasto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdGasto.Location = New System.Drawing.Point(12, 9)
        Me.lblIdGasto.Name = "lblIdGasto"
        Me.lblIdGasto.Size = New System.Drawing.Size(139, 22)
        Me.lblIdGasto.TabIndex = 68
        Me.lblIdGasto.Text = "ID de Registro:"
        '
        'lblUnidadMedida
        '
        Me.lblUnidadMedida.AutoSize = True
        Me.lblUnidadMedida.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadMedida.Location = New System.Drawing.Point(11, 28)
        Me.lblUnidadMedida.Name = "lblUnidadMedida"
        Me.lblUnidadMedida.Size = New System.Drawing.Size(98, 22)
        Me.lblUnidadMedida.TabIndex = 67
        Me.lblUnidadMedida.Text = "Concepto:"
        '
        'txtidGastoRealizado
        '
        Me.txtidGastoRealizado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidGastoRealizado.Location = New System.Drawing.Point(157, 9)
        Me.txtidGastoRealizado.MaxLength = 49
        Me.txtidGastoRealizado.Name = "txtidGastoRealizado"
        Me.txtidGastoRealizado.ReadOnly = True
        Me.txtidGastoRealizado.Size = New System.Drawing.Size(197, 26)
        Me.txtidGastoRealizado.TabIndex = 66
        '
        'cboxEmpleado
        '
        Me.cboxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEmpleado.Enabled = False
        Me.cboxEmpleado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxEmpleado.FormattingEnabled = True
        Me.cboxEmpleado.Location = New System.Drawing.Point(113, 21)
        Me.cboxEmpleado.Name = "cboxEmpleado"
        Me.cboxEmpleado.Size = New System.Drawing.Size(267, 26)
        Me.cboxEmpleado.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 22)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Empleado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 22)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Domicilio:"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtDomicilio.Location = New System.Drawing.Point(113, 58)
        Me.txtDomicilio.MaxLength = 49
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.ReadOnly = True
        Me.txtDomicilio.Size = New System.Drawing.Size(267, 26)
        Me.txtDomicilio.TabIndex = 80
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(113, 95)
        Me.txtTelefono.MaxLength = 49
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(267, 26)
        Me.txtTelefono.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 22)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Teléfono:"
        '
        'gboxEmpleado
        '
        Me.gboxEmpleado.Controls.Add(Me.Label5)
        Me.gboxEmpleado.Controls.Add(Me.txtTelefono)
        Me.gboxEmpleado.Controls.Add(Me.cboxEmpleado)
        Me.gboxEmpleado.Controls.Add(Me.Label7)
        Me.gboxEmpleado.Controls.Add(Me.Label6)
        Me.gboxEmpleado.Controls.Add(Me.txtDomicilio)
        Me.gboxEmpleado.Location = New System.Drawing.Point(16, 80)
        Me.gboxEmpleado.Name = "gboxEmpleado"
        Me.gboxEmpleado.Size = New System.Drawing.Size(400, 144)
        Me.gboxEmpleado.TabIndex = 83
        Me.gboxEmpleado.TabStop = False
        Me.gboxEmpleado.Text = "Empleado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtImporte)
        Me.GroupBox1.Controls.Add(Me.cboxConcepto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblUnidadMedida)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 260)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Concepto"
        '
        'txtImporte
        '
        Me.txtImporte.DecimalPlaces = 2
        Me.txtImporte.Enabled = False
        Me.txtImporte.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtImporte.Location = New System.Drawing.Point(114, 63)
        Me.txtImporte.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(266, 26)
        Me.txtImporte.TabIndex = 87
        '
        'cboxConcepto
        '
        Me.cboxConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxConcepto.Enabled = False
        Me.cboxConcepto.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxConcepto.FormattingEnabled = True
        Me.cboxConcepto.Location = New System.Drawing.Point(113, 29)
        Me.cboxConcepto.Name = "cboxConcepto"
        Me.cboxConcepto.Size = New System.Drawing.Size(267, 26)
        Me.cboxConcepto.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 22)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Importe: $"
        '
        'dgGastosRealizados
        '
        Me.dgGastosRealizados.AllowUserToAddRows = False
        Me.dgGastosRealizados.AllowUserToDeleteRows = False
        Me.dgGastosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGastosRealizados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idGasto, Me.fecha, Me.idEmpleado, Me.empleado, Me.concepto, Me.importe, Me.observaciones})
        Me.dgGastosRealizados.Location = New System.Drawing.Point(432, 122)
        Me.dgGastosRealizados.Name = "dgGastosRealizados"
        Me.dgGastosRealizados.ReadOnly = True
        Me.dgGastosRealizados.Size = New System.Drawing.Size(670, 368)
        Me.dgGastosRealizados.TabIndex = 88
        '
        'idGasto
        '
        Me.idGasto.HeaderText = "ID de Gasto"
        Me.idGasto.Name = "idGasto"
        Me.idGasto.ReadOnly = True
        Me.idGasto.Width = 50
        '
        'fecha
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "ID de Empleado"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        Me.idEmpleado.Width = 50
        '
        'empleado
        '
        Me.empleado.HeaderText = "Empleado"
        Me.empleado.Name = "empleado"
        Me.empleado.ReadOnly = True
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        '
        'importe
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.importe.DefaultCellStyle = DataGridViewCellStyle2
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'observaciones
        '
        Me.observaciones.HeaderText = "Observaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.ReadOnly = True
        '
        'gboxConsulta
        '
        Me.gboxConsulta.Controls.Add(Me.dtpConsultaFecha)
        Me.gboxConsulta.Controls.Add(Me.cboxConsultaEmpleado)
        Me.gboxConsulta.Controls.Add(Me.cboxConsultaConcepto)
        Me.gboxConsulta.Controls.Add(Me.cmdConsultar)
        Me.gboxConsulta.Controls.Add(Me.rbtnTodos)
        Me.gboxConsulta.Controls.Add(Me.rbtnEmpleado)
        Me.gboxConsulta.Controls.Add(Me.rbtnConcepto)
        Me.gboxConsulta.Controls.Add(Me.rbtnFecha)
        Me.gboxConsulta.Location = New System.Drawing.Point(432, 9)
        Me.gboxConsulta.Name = "gboxConsulta"
        Me.gboxConsulta.Size = New System.Drawing.Size(567, 107)
        Me.gboxConsulta.TabIndex = 89
        Me.gboxConsulta.TabStop = False
        Me.gboxConsulta.Text = "Consulta"
        '
        'dtpConsultaFecha
        '
        Me.dtpConsultaFecha.Enabled = False
        Me.dtpConsultaFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpConsultaFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpConsultaFecha.Location = New System.Drawing.Point(111, 21)
        Me.dtpConsultaFecha.Name = "dtpConsultaFecha"
        Me.dtpConsultaFecha.Size = New System.Drawing.Size(199, 20)
        Me.dtpConsultaFecha.TabIndex = 90
        '
        'cboxConsultaEmpleado
        '
        Me.cboxConsultaEmpleado.FormattingEnabled = True
        Me.cboxConsultaEmpleado.Location = New System.Drawing.Point(111, 76)
        Me.cboxConsultaEmpleado.Name = "cboxConsultaEmpleado"
        Me.cboxConsultaEmpleado.Size = New System.Drawing.Size(199, 21)
        Me.cboxConsultaEmpleado.TabIndex = 7
        '
        'cboxConsultaConcepto
        '
        Me.cboxConsultaConcepto.FormattingEnabled = True
        Me.cboxConsultaConcepto.Location = New System.Drawing.Point(111, 48)
        Me.cboxConsultaConcepto.Name = "cboxConsultaConcepto"
        Me.cboxConsultaConcepto.Size = New System.Drawing.Size(199, 21)
        Me.cboxConsultaConcepto.TabIndex = 6
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(370, 71)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(90, 23)
        Me.cmdConsultar.TabIndex = 4
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'rbtnTodos
        '
        Me.rbtnTodos.AutoSize = True
        Me.rbtnTodos.Checked = True
        Me.rbtnTodos.Location = New System.Drawing.Point(370, 21)
        Me.rbtnTodos.Name = "rbtnTodos"
        Me.rbtnTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbtnTodos.TabIndex = 3
        Me.rbtnTodos.TabStop = True
        Me.rbtnTodos.Text = "Todos"
        Me.rbtnTodos.UseVisualStyleBackColor = True
        '
        'rbtnEmpleado
        '
        Me.rbtnEmpleado.AutoSize = True
        Me.rbtnEmpleado.Location = New System.Drawing.Point(15, 79)
        Me.rbtnEmpleado.Name = "rbtnEmpleado"
        Me.rbtnEmpleado.Size = New System.Drawing.Size(75, 17)
        Me.rbtnEmpleado.TabIndex = 2
        Me.rbtnEmpleado.Text = "Empleado:"
        Me.rbtnEmpleado.UseVisualStyleBackColor = True
        '
        'rbtnConcepto
        '
        Me.rbtnConcepto.AutoSize = True
        Me.rbtnConcepto.Location = New System.Drawing.Point(15, 50)
        Me.rbtnConcepto.Name = "rbtnConcepto"
        Me.rbtnConcepto.Size = New System.Drawing.Size(74, 17)
        Me.rbtnConcepto.TabIndex = 1
        Me.rbtnConcepto.Text = "Concepto:"
        Me.rbtnConcepto.UseVisualStyleBackColor = True
        '
        'rbtnFecha
        '
        Me.rbtnFecha.AutoSize = True
        Me.rbtnFecha.Location = New System.Drawing.Point(15, 22)
        Me.rbtnFecha.Name = "rbtnFecha"
        Me.rbtnFecha.Size = New System.Drawing.Size(58, 17)
        Me.rbtnFecha.TabIndex = 0
        Me.rbtnFecha.Text = "Fecha:"
        Me.rbtnFecha.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(982, 496)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 87
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(297, 496)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 86
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(171, 496)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 85
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'frmGastosRealizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.gboxConsulta)
        Me.Controls.Add(Me.dgGastosRealizados)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gboxEmpleado)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblIdGasto)
        Me.Controls.Add(Me.txtidGastoRealizado)
        Me.Name = "frmGastosRealizados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Gastos"
        Me.gboxEmpleado.ResumeLayout(False)
        Me.gboxEmpleado.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgGastosRealizados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxConsulta.ResumeLayout(False)
        Me.gboxConsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblIdGasto As System.Windows.Forms.Label
    Friend WithEvents lblUnidadMedida As System.Windows.Forms.Label
    Friend WithEvents txtidGastoRealizado As System.Windows.Forms.TextBox
    Friend WithEvents cboxEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gboxEmpleado As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents dgGastosRealizados As System.Windows.Forms.DataGridView
    Friend WithEvents gboxConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents dtpConsultaFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboxConsultaEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents cboxConsultaConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents rbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnEmpleado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnConcepto As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFecha As System.Windows.Forms.RadioButton
    Friend WithEvents cboxConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents txtImporte As System.Windows.Forms.NumericUpDown
    Friend WithEvents idGasto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
