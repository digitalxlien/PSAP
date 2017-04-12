<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarSalidaMaterial
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
        Me.dgSalidaMaterial = New System.Windows.Forms.DataGridView()
        Me.idSalidaMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gboxConsulta = New System.Windows.Forms.GroupBox()
        Me.rbtnIdSalida = New System.Windows.Forms.RadioButton()
        Me.cboxConsultaEmpleado = New System.Windows.Forms.ComboBox()
        Me.dtpConsultaFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdDetalles = New System.Windows.Forms.Button()
        Me.dtpConsultaFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboxConsultaCalle = New System.Windows.Forms.ComboBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.rbtnTodos = New System.Windows.Forms.RadioButton()
        Me.rbtnEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbtnCalle = New System.Windows.Forms.RadioButton()
        Me.rbtnFecha = New System.Windows.Forms.RadioButton()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.txtIdSalida = New System.Windows.Forms.TextBox()
        CType(Me.dgSalidaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgSalidaMaterial
        '
        Me.dgSalidaMaterial.AllowUserToAddRows = False
        Me.dgSalidaMaterial.AllowUserToDeleteRows = False
        Me.dgSalidaMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSalidaMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idSalidaMaterial, Me.calle, Me.empleado, Me.fecha, Me.concepto})
        Me.dgSalidaMaterial.Location = New System.Drawing.Point(19, 137)
        Me.dgSalidaMaterial.Name = "dgSalidaMaterial"
        Me.dgSalidaMaterial.ReadOnly = True
        Me.dgSalidaMaterial.Size = New System.Drawing.Size(871, 368)
        Me.dgSalidaMaterial.TabIndex = 93
        '
        'idSalidaMaterial
        '
        Me.idSalidaMaterial.HeaderText = "ID de Salida"
        Me.idSalidaMaterial.Name = "idSalidaMaterial"
        Me.idSalidaMaterial.ReadOnly = True
        '
        'calle
        '
        Me.calle.HeaderText = "Calle"
        Me.calle.Name = "calle"
        Me.calle.ReadOnly = True
        Me.calle.Width = 150
        '
        'empleado
        '
        Me.empleado.HeaderText = "Empleado"
        Me.empleado.Name = "empleado"
        Me.empleado.ReadOnly = True
        Me.empleado.Width = 150
        '
        'fecha
        '
        DataGridViewCellStyle1.Format = "D"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        Me.concepto.Width = 300
        '
        'gboxConsulta
        '
        Me.gboxConsulta.Controls.Add(Me.txtIdSalida)
        Me.gboxConsulta.Controls.Add(Me.rbtnIdSalida)
        Me.gboxConsulta.Controls.Add(Me.cboxConsultaEmpleado)
        Me.gboxConsulta.Controls.Add(Me.dtpConsultaFechaFin)
        Me.gboxConsulta.Controls.Add(Me.Label2)
        Me.gboxConsulta.Controls.Add(Me.Label1)
        Me.gboxConsulta.Controls.Add(Me.cmdDetalles)
        Me.gboxConsulta.Controls.Add(Me.dtpConsultaFechaInicio)
        Me.gboxConsulta.Controls.Add(Me.cboxConsultaCalle)
        Me.gboxConsulta.Controls.Add(Me.cmdConsultar)
        Me.gboxConsulta.Controls.Add(Me.rbtnTodos)
        Me.gboxConsulta.Controls.Add(Me.rbtnEmpleado)
        Me.gboxConsulta.Controls.Add(Me.rbtnCalle)
        Me.gboxConsulta.Controls.Add(Me.rbtnFecha)
        Me.gboxConsulta.Location = New System.Drawing.Point(19, 11)
        Me.gboxConsulta.Name = "gboxConsulta"
        Me.gboxConsulta.Size = New System.Drawing.Size(871, 107)
        Me.gboxConsulta.TabIndex = 92
        Me.gboxConsulta.TabStop = False
        Me.gboxConsulta.Text = "Consulta"
        '
        'rbtnIdSalida
        '
        Me.rbtnIdSalida.AutoSize = True
        Me.rbtnIdSalida.Location = New System.Drawing.Point(402, 18)
        Me.rbtnIdSalida.Name = "rbtnIdSalida"
        Me.rbtnIdSalida.Size = New System.Drawing.Size(84, 17)
        Me.rbtnIdSalida.TabIndex = 97
        Me.rbtnIdSalida.Text = "ID de salida:"
        Me.rbtnIdSalida.UseVisualStyleBackColor = True
        '
        'cboxConsultaEmpleado
        '
        Me.cboxConsultaEmpleado.Enabled = False
        Me.cboxConsultaEmpleado.FormattingEnabled = True
        Me.cboxConsultaEmpleado.Location = New System.Drawing.Point(109, 76)
        Me.cboxConsultaEmpleado.Name = "cboxConsultaEmpleado"
        Me.cboxConsultaEmpleado.Size = New System.Drawing.Size(251, 21)
        Me.cboxConsultaEmpleado.TabIndex = 96
        '
        'dtpConsultaFechaFin
        '
        Me.dtpConsultaFechaFin.Enabled = False
        Me.dtpConsultaFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpConsultaFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpConsultaFechaFin.Location = New System.Drawing.Point(267, 18)
        Me.dtpConsultaFechaFin.Name = "dtpConsultaFechaFin"
        Me.dtpConsultaFechaFin.Size = New System.Drawing.Size(95, 20)
        Me.dtpConsultaFechaFin.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Entre "
        '
        'cmdDetalles
        '
        Me.cmdDetalles.Enabled = False
        Me.cmdDetalles.Location = New System.Drawing.Point(775, 71)
        Me.cmdDetalles.Name = "cmdDetalles"
        Me.cmdDetalles.Size = New System.Drawing.Size(90, 23)
        Me.cmdDetalles.TabIndex = 92
        Me.cmdDetalles.Text = "Ver Detalles"
        Me.cmdDetalles.UseVisualStyleBackColor = True
        '
        'dtpConsultaFechaInicio
        '
        Me.dtpConsultaFechaInicio.Enabled = False
        Me.dtpConsultaFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpConsultaFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpConsultaFechaInicio.Location = New System.Drawing.Point(151, 19)
        Me.dtpConsultaFechaInicio.Name = "dtpConsultaFechaInicio"
        Me.dtpConsultaFechaInicio.Size = New System.Drawing.Size(95, 20)
        Me.dtpConsultaFechaInicio.TabIndex = 90
        '
        'cboxConsultaCalle
        '
        Me.cboxConsultaCalle.Enabled = False
        Me.cboxConsultaCalle.FormattingEnabled = True
        Me.cboxConsultaCalle.Location = New System.Drawing.Point(111, 48)
        Me.cboxConsultaCalle.Name = "cboxConsultaCalle"
        Me.cboxConsultaCalle.Size = New System.Drawing.Size(251, 21)
        Me.cboxConsultaCalle.TabIndex = 6
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(679, 71)
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
        Me.rbtnTodos.Location = New System.Drawing.Point(402, 52)
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
        'rbtnCalle
        '
        Me.rbtnCalle.AutoSize = True
        Me.rbtnCalle.Location = New System.Drawing.Point(15, 50)
        Me.rbtnCalle.Name = "rbtnCalle"
        Me.rbtnCalle.Size = New System.Drawing.Size(51, 17)
        Me.rbtnCalle.TabIndex = 1
        Me.rbtnCalle.Text = "Calle:"
        Me.rbtnCalle.UseVisualStyleBackColor = True
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
        Me.cmdSalir.Location = New System.Drawing.Point(770, 511)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 140
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'txtIdSalida
        '
        Me.txtIdSalida.Enabled = False
        Me.txtIdSalida.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtIdSalida.Location = New System.Drawing.Point(492, 12)
        Me.txtIdSalida.Name = "txtIdSalida"
        Me.txtIdSalida.Size = New System.Drawing.Size(195, 26)
        Me.txtIdSalida.TabIndex = 98
        '
        'frmConsultarSalidaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgSalidaMaterial)
        Me.Controls.Add(Me.gboxConsulta)
        Me.Name = "frmConsultarSalidaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Salida de Material"
        CType(Me.dgSalidaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxConsulta.ResumeLayout(False)
        Me.gboxConsulta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgSalidaMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents gboxConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDetalles As System.Windows.Forms.Button
    Friend WithEvents dtpConsultaFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboxConsultaCalle As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents rbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnEmpleado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCalle As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFecha As System.Windows.Forms.RadioButton
    Friend WithEvents dtpConsultaFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboxConsultaEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents idSalidaMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rbtnIdSalida As System.Windows.Forms.RadioButton
    Friend WithEvents txtIdSalida As System.Windows.Forms.TextBox
End Class
