<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActividadPozos
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
        Me.cboxPozo = New System.Windows.Forms.ComboBox()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.lblUnidadMedida = New System.Windows.Forms.Label()
        Me.txtidActividad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLectura = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.dgActividadPozos = New System.Windows.Forms.DataGridView()
        Me.idActividadPozo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPozo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lectura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgActividadPozos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboxPozo
        '
        Me.cboxPozo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxPozo.Enabled = False
        Me.cboxPozo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxPozo.FormattingEnabled = True
        Me.cboxPozo.Location = New System.Drawing.Point(90, 44)
        Me.cboxPozo.Name = "cboxPozo"
        Me.cboxPozo.Size = New System.Drawing.Size(268, 26)
        Me.cboxPozo.TabIndex = 48
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosto.Location = New System.Drawing.Point(12, 9)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(143, 22)
        Me.lblCosto.TabIndex = 51
        Me.lblCosto.Text = "ID de Actividad:"
        '
        'lblUnidadMedida
        '
        Me.lblUnidadMedida.AutoSize = True
        Me.lblUnidadMedida.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadMedida.Location = New System.Drawing.Point(12, 48)
        Me.lblUnidadMedida.Name = "lblUnidadMedida"
        Me.lblUnidadMedida.Size = New System.Drawing.Size(59, 22)
        Me.lblUnidadMedida.TabIndex = 50
        Me.lblUnidadMedida.Text = "Pozo:"
        '
        'txtidActividad
        '
        Me.txtidActividad.Enabled = False
        Me.txtidActividad.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidActividad.Location = New System.Drawing.Point(161, 5)
        Me.txtidActividad.MaxLength = 49
        Me.txtidActividad.Name = "txtidActividad"
        Me.txtidActividad.ReadOnly = True
        Me.txtidActividad.Size = New System.Drawing.Size(197, 26)
        Me.txtidActividad.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(90, 91)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(268, 26)
        Me.dtpFecha.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 22)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Hora:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Lectura:"
        '
        'txtLectura
        '
        Me.txtLectura.Enabled = False
        Me.txtLectura.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtLectura.Location = New System.Drawing.Point(492, 5)
        Me.txtLectura.MaxLength = 49
        Me.txtLectura.Name = "txtLectura"
        Me.txtLectura.Size = New System.Drawing.Size(302, 26)
        Me.txtLectura.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(408, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 22)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtObservaciones.Location = New System.Drawing.Point(412, 73)
        Me.txtObservaciones.MaxLength = 49
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(382, 89)
        Me.txtObservaciones.TabIndex = 59
        '
        'dgActividadPozos
        '
        Me.dgActividadPozos.AllowUserToAddRows = False
        Me.dgActividadPozos.AllowUserToDeleteRows = False
        Me.dgActividadPozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgActividadPozos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idActividadPozo, Me.idPozo, Me.ubicacion, Me.fecha, Me.hora, Me.lectura, Me.observaciones})
        Me.dgActividadPozos.Location = New System.Drawing.Point(20, 185)
        Me.dgActividadPozos.Name = "dgActividadPozos"
        Me.dgActividadPozos.ReadOnly = True
        Me.dgActividadPozos.Size = New System.Drawing.Size(774, 280)
        Me.dgActividadPozos.TabIndex = 60
        '
        'idActividadPozo
        '
        Me.idActividadPozo.HeaderText = "ID Actividad del Pozo"
        Me.idActividadPozo.Name = "idActividadPozo"
        Me.idActividadPozo.ReadOnly = True
        '
        'idPozo
        '
        Me.idPozo.HeaderText = "ID de Pozo"
        Me.idPozo.Name = "idPozo"
        Me.idPozo.ReadOnly = True
        '
        'ubicacion
        '
        Me.ubicacion.HeaderText = "Ubicación"
        Me.ubicacion.Name = "ubicacion"
        Me.ubicacion.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'hora
        '
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.hora.DefaultCellStyle = DataGridViewCellStyle1
        Me.hora.HeaderText = "Hora"
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        '
        'lectura
        '
        Me.lectura.HeaderText = "Lectura"
        Me.lectura.Name = "lectura"
        Me.lectura.ReadOnly = True
        '
        'observaciones
        '
        Me.observaciones.HeaderText = "Observaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.ReadOnly = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(675, 479)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 63
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(549, 479)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 62
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(423, 479)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 61
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'dtpHora
        '
        Me.dtpHora.Enabled = False
        Me.dtpHora.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHora.Location = New System.Drawing.Point(90, 132)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(268, 26)
        Me.dtpHora.TabIndex = 64
        '
        'frmActividadPozos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 526)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtpHora)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.dgActividadPozos)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLectura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxPozo)
        Me.Controls.Add(Me.lblCosto)
        Me.Controls.Add(Me.lblUnidadMedida)
        Me.Controls.Add(Me.txtidActividad)
        Me.Name = "frmActividadPozos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de la Actividad de Pozos"
        CType(Me.dgActividadPozos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboxPozo As System.Windows.Forms.ComboBox
    Friend WithEvents lblCosto As System.Windows.Forms.Label
    Friend WithEvents lblUnidadMedida As System.Windows.Forms.Label
    Friend WithEvents txtidActividad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLectura As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents dgActividadPozos As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents idActividadPozo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPozo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lectura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
