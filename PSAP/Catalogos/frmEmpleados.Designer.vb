<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPSAP = New PSAP.DataSetPSAP()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtidEmpleado = New System.Windows.Forms.TextBox()
        Me.lblidNombre = New System.Windows.Forms.Label()
        Me.lblidEmpleado = New System.Windows.Forms.Label()
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.IdEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.EmpleadoTableAdapter = New PSAP.DataSetPSAPTableAdapters.EmpleadoTableAdapter()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "codigoPostal", True))
        Me.txtCodigoPostal.Enabled = False
        Me.txtCodigoPostal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCodigoPostal.Location = New System.Drawing.Point(172, 170)
        Me.txtCodigoPostal.MaxLength = 49
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(207, 26)
        Me.txtCodigoPostal.TabIndex = 4
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.DataSetPSAP
        '
        'DataSetPSAP
        '
        Me.DataSetPSAP.DataSetName = "DataSetPSAP"
        Me.DataSetPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtColonia
        '
        Me.txtColonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "colonia", True))
        Me.txtColonia.Enabled = False
        Me.txtColonia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtColonia.Location = New System.Drawing.Point(172, 126)
        Me.txtColonia.MaxLength = 49
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(481, 26)
        Me.txtColonia.TabIndex = 3
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoPostal.Location = New System.Drawing.Point(12, 166)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(133, 22)
        Me.lblCodigoPostal.TabIndex = 41
        Me.lblCodigoPostal.Text = "Código postal:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.Location = New System.Drawing.Point(12, 87)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(58, 22)
        Me.lblCalle.TabIndex = 40
        Me.lblCalle.Text = "Calle:"
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(261, 253)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 9
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(180, 253)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 8
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(99, 253)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 7
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(18, 253)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 6
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'txtCalle
        '
        Me.txtCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "calle", True))
        Me.txtCalle.Enabled = False
        Me.txtCalle.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCalle.Location = New System.Drawing.Point(172, 87)
        Me.txtCalle.MaxLength = 49
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(481, 26)
        Me.txtCalle.TabIndex = 2
        '
        'txtidEmpleado
        '
        Me.txtidEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "idEmpleado", True))
        Me.txtidEmpleado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidEmpleado.Location = New System.Drawing.Point(172, 9)
        Me.txtidEmpleado.Name = "txtidEmpleado"
        Me.txtidEmpleado.ReadOnly = True
        Me.txtidEmpleado.Size = New System.Drawing.Size(162, 26)
        Me.txtidEmpleado.TabIndex = 39
        '
        'lblidNombre
        '
        Me.lblidNombre.AutoSize = True
        Me.lblidNombre.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidNombre.Location = New System.Drawing.Point(12, 48)
        Me.lblidNombre.Name = "lblidNombre"
        Me.lblidNombre.Size = New System.Drawing.Size(83, 22)
        Me.lblidNombre.TabIndex = 38
        Me.lblidNombre.Text = "Nombre:"
        '
        'lblidEmpleado
        '
        Me.lblidEmpleado.AutoSize = True
        Me.lblidEmpleado.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidEmpleado.Location = New System.Drawing.Point(12, 9)
        Me.lblidEmpleado.Name = "lblidEmpleado"
        Me.lblidEmpleado.Size = New System.Drawing.Size(154, 22)
        Me.lblidEmpleado.TabIndex = 37
        Me.lblidEmpleado.Text = "ID de Empleado:"
        '
        'dgEmpleados
        '
        Me.dgEmpleados.AllowUserToAddRows = False
        Me.dgEmpleados.AllowUserToDeleteRows = False
        Me.dgEmpleados.AutoGenerateColumns = False
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleadoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.CodigoPostalDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn})
        Me.dgEmpleados.DataSource = Me.EmpleadoBindingSource
        Me.dgEmpleados.Location = New System.Drawing.Point(18, 282)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.ReadOnly = True
        Me.dgEmpleados.Size = New System.Drawing.Size(817, 292)
        Me.dgEmpleados.TabIndex = 36
        '
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "ID de Empleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        Me.IdEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 250
        '
        'CalleDataGridViewTextBoxColumn
        '
        Me.CalleDataGridViewTextBoxColumn.DataPropertyName = "calle"
        Me.CalleDataGridViewTextBoxColumn.HeaderText = "Calle"
        Me.CalleDataGridViewTextBoxColumn.Name = "CalleDataGridViewTextBoxColumn"
        Me.CalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoPostalDataGridViewTextBoxColumn
        '
        Me.CodigoPostalDataGridViewTextBoxColumn.DataPropertyName = "codigoPostal"
        Me.CodigoPostalDataGridViewTextBoxColumn.HeaderText = "Código Postal"
        Me.CodigoPostalDataGridViewTextBoxColumn.Name = "CodigoPostalDataGridViewTextBoxColumn"
        Me.CodigoPostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(718, 580)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 12
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(592, 580)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 11
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(340, 577)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 10
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColonia.Location = New System.Drawing.Point(12, 126)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(79, 22)
        Me.lblColonia.TabIndex = 42
        Me.lblColonia.Text = "Colonia:"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "nombre", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(172, 48)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(481, 26)
        Me.txtNombre.TabIndex = 1
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "telefono", True))
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(176, 212)
        Me.txtTelefono.MaxLength = 49
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(203, 26)
        Me.txtTelefono.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(16, 208)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(89, 22)
        Me.lblTelefono.TabIndex = 45
        Me.lblTelefono.Text = "Teléfono:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.PSAP.My.Resources.Resources.cancel
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(466, 577)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(120, 35)
        Me.cmdCancelar.TabIndex = 76
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 624)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.txtCodigoPostal)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.lblCodigoPostal)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtidEmpleado)
        Me.Controls.Add(Me.lblidNombre)
        Me.Controls.Add(Me.lblidEmpleado)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Name = "frmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoPostal As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents cmdUltimo As System.Windows.Forms.Button
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents cmdInicio As System.Windows.Forms.Button
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtidEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents lblidNombre As System.Windows.Forms.Label
    Friend WithEvents lblidEmpleado As System.Windows.Forms.Label
    Friend WithEvents dgEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents DataSetPSAP As PSAP.DataSetPSAP
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As PSAP.DataSetPSAPTableAdapters.EmpleadoTableAdapter
    Friend WithEvents lblColonia As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents IdEmpleadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoPostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
