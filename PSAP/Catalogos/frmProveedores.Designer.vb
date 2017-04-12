<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtidProveedor = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblidCalle = New System.Windows.Forms.Label()
        Me.dgProveedor = New System.Windows.Forms.DataGridView()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.DataSetPSAP = New PSAP.DataSetPSAP()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New PSAP.DataSetPSAPTableAdapters.ProveedorTableAdapter()
        Me.cboxEstado = New System.Windows.Forms.ComboBox()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtColonia
        '
        Me.txtColonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "colonia", True))
        Me.txtColonia.Enabled = False
        Me.txtColonia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtColonia.Location = New System.Drawing.Point(101, 122)
        Me.txtColonia.MaxLength = 49
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(330, 26)
        Me.txtColonia.TabIndex = 28
        '
        'txtCalle
        '
        Me.txtCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "calle", True))
        Me.txtCalle.Enabled = False
        Me.txtCalle.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCalle.Location = New System.Drawing.Point(101, 83)
        Me.txtCalle.MaxLength = 49
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(330, 26)
        Me.txtCalle.TabIndex = 27
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColonia.Location = New System.Drawing.Point(12, 126)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(79, 22)
        Me.lblColonia.TabIndex = 41
        Me.lblColonia.Text = "Colonia:"
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
        Me.cmdUltimo.Location = New System.Drawing.Point(255, 210)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 32
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(174, 210)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 31
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(93, 210)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 30
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(12, 210)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 29
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "nombre", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(101, 44)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(330, 26)
        Me.txtNombre.TabIndex = 26
        '
        'txtidProveedor
        '
        Me.txtidProveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidProveedor.Location = New System.Drawing.Point(174, 5)
        Me.txtidProveedor.Name = "txtidProveedor"
        Me.txtidProveedor.ReadOnly = True
        Me.txtidProveedor.Size = New System.Drawing.Size(111, 26)
        Me.txtidProveedor.TabIndex = 39
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(12, 48)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(83, 22)
        Me.lblNombre.TabIndex = 38
        Me.lblNombre.Text = "Nombre:"
        '
        'lblidCalle
        '
        Me.lblidCalle.AutoSize = True
        Me.lblidCalle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidCalle.Location = New System.Drawing.Point(12, 9)
        Me.lblidCalle.Name = "lblidCalle"
        Me.lblidCalle.Size = New System.Drawing.Size(156, 22)
        Me.lblidCalle.TabIndex = 37
        Me.lblidCalle.Text = "ID de Proveedor:"
        '
        'dgProveedor
        '
        Me.dgProveedor.AllowUserToAddRows = False
        Me.dgProveedor.AllowUserToDeleteRows = False
        Me.dgProveedor.AutoGenerateColumns = False
        Me.dgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.CodigoPostalDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn})
        Me.dgProveedor.DataSource = Me.ProveedorBindingSource
        Me.dgProveedor.Location = New System.Drawing.Point(12, 252)
        Me.dgProveedor.Name = "dgProveedor"
        Me.dgProveedor.ReadOnly = True
        Me.dgProveedor.Size = New System.Drawing.Size(863, 303)
        Me.dgProveedor.TabIndex = 36
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(754, 561)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 35
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(628, 561)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 34
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(502, 561)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 33
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(12, 166)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(75, 22)
        Me.lblEstado.TabIndex = 44
        Me.lblEstado.Text = "Estado:"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoPostal.Location = New System.Drawing.Point(459, 126)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(133, 22)
        Me.lblCodigoPostal.TabIndex = 45
        Me.lblCodigoPostal.Text = "Código postal:"
        '
        'DataSetPSAP
        '
        Me.DataSetPSAP.DataSetName = "DataSetPSAP"
        Me.DataSetPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.DataSetPSAP
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'cboxEstado
        '
        Me.cboxEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "estado", True))
        Me.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEstado.Enabled = False
        Me.cboxEstado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxEstado.FormattingEnabled = True
        Me.cboxEstado.Items.AddRange(New Object() {"Jalisco", "Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Coahuila", "Colima", "Distrito Federal", "Durango", "Estado de México", "Guanajuato", "Guerrero", "Hidalgo", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas"})
        Me.cboxEstado.Location = New System.Drawing.Point(101, 166)
        Me.cboxEstado.Name = "cboxEstado"
        Me.cboxEstado.Size = New System.Drawing.Size(330, 26)
        Me.cboxEstado.TabIndex = 46
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "codigoPostal", True))
        Me.txtCodigoPostal.Enabled = False
        Me.txtCodigoPostal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCodigoPostal.Location = New System.Drawing.Point(600, 122)
        Me.txtCodigoPostal.MaxLength = 49
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(187, 26)
        Me.txtCodigoPostal.TabIndex = 47
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(459, 166)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(89, 22)
        Me.lblTelefono.TabIndex = 48
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "telefono", True))
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(600, 166)
        Me.txtTelefono.MaxLength = 49
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(187, 26)
        Me.txtTelefono.TabIndex = 49
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "ID de Proveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProveedorDataGridViewTextBoxColumn.Width = 50
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 200
        '
        'CalleDataGridViewTextBoxColumn
        '
        Me.CalleDataGridViewTextBoxColumn.DataPropertyName = "calle"
        Me.CalleDataGridViewTextBoxColumn.HeaderText = "Calle"
        Me.CalleDataGridViewTextBoxColumn.Name = "CalleDataGridViewTextBoxColumn"
        Me.CalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.CalleDataGridViewTextBoxColumn.Width = 150
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoPostalDataGridViewTextBoxColumn
        '
        Me.CodigoPostalDataGridViewTextBoxColumn.DataPropertyName = "codigoPostal"
        Me.CodigoPostalDataGridViewTextBoxColumn.HeaderText = "Código postal"
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
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 608)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtCodigoPostal)
        Me.Controls.Add(Me.cboxEstado)
        Me.Controls.Add(Me.lblCodigoPostal)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtidProveedor)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblidCalle)
        Me.Controls.Add(Me.dgProveedor)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        CType(Me.dgProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents lblColonia As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents cmdUltimo As System.Windows.Forms.Button
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents cmdInicio As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtidProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblidCalle As System.Windows.Forms.Label
    Friend WithEvents dgProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblCodigoPostal As System.Windows.Forms.Label
    Friend WithEvents DataSetPSAP As PSAP.DataSetPSAP
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorTableAdapter As PSAP.DataSetPSAPTableAdapters.ProveedorTableAdapter
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoPostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
End Class
