<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMateriales
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
        Me.cboxUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSeTPSAP = New PSAP.DataSeTPSAP()
        Me.lblUltimaFechaCompra = New System.Windows.Forms.Label()
        Me.dtpFechaUltimaCompra = New System.Windows.Forms.DateTimePicker()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.lblUnidadMedida = New System.Windows.Forms.Label()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.lblMinimo = New System.Windows.Forms.Label()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.lblMaximo = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtidMaterial = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblidMaterial = New System.Windows.Forms.Label()
        Me.dgMateriales = New System.Windows.Forms.DataGridView()
        Me.IdMaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.MaterialTableAdapter = New PSAP.DataSeTPSAPTableAdapters.MaterialTableAdapter()
        Me.cmdSalir = New System.Windows.Forms.Button()
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSeTPSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboxUnidadMedida
        '
        Me.cboxUnidadMedida.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "unidadMedida", True))
        Me.cboxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxUnidadMedida.Enabled = False
        Me.cboxUnidadMedida.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxUnidadMedida.FormattingEnabled = True
        Me.cboxUnidadMedida.Items.AddRange(New Object() {"PIEZA", "KILO", "LITRO", "GRAMO", "METRO", "UNIDAD", "PULGADA", "CENTIMETRO", "ONZA"})
        Me.cboxUnidadMedida.Location = New System.Drawing.Point(475, 108)
        Me.cboxUnidadMedida.Name = "cboxUnidadMedida"
        Me.cboxUnidadMedida.Size = New System.Drawing.Size(197, 26)
        Me.cboxUnidadMedida.TabIndex = 55
        '
        'MaterialBindingSource
        '
        Me.MaterialBindingSource.DataMember = "Material"
        Me.MaterialBindingSource.DataSource = Me.DataSeTPSAP
        '
        'DataSeTPSAP
        '
        Me.DataSeTPSAP.DataSetName = "DataSeTPSAP"
        Me.DataSeTPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblUltimaFechaCompra
        '
        Me.lblUltimaFechaCompra.AutoSize = True
        Me.lblUltimaFechaCompra.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimaFechaCompra.Location = New System.Drawing.Point(333, 148)
        Me.lblUltimaFechaCompra.Name = "lblUltimaFechaCompra"
        Me.lblUltimaFechaCompra.Size = New System.Drawing.Size(136, 22)
        Me.lblUltimaFechaCompra.TabIndex = 65
        Me.lblUltimaFechaCompra.Text = "Última compra:"
        '
        'dtpFechaUltimaCompra
        '
        Me.dtpFechaUltimaCompra.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MaterialBindingSource, "fechaUltimaCompra", True))
        Me.dtpFechaUltimaCompra.Enabled = False
        Me.dtpFechaUltimaCompra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaUltimaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaUltimaCompra.Location = New System.Drawing.Point(475, 144)
        Me.dtpFechaUltimaCompra.Name = "dtpFechaUltimaCompra"
        Me.dtpFechaUltimaCompra.Size = New System.Drawing.Size(197, 26)
        Me.dtpFechaUltimaCompra.TabIndex = 57
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosto.Location = New System.Drawing.Point(403, 80)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(66, 22)
        Me.lblCosto.TabIndex = 64
        Me.lblCosto.Text = "Costo:"
        '
        'lblUnidadMedida
        '
        Me.lblUnidadMedida.AutoSize = True
        Me.lblUnidadMedida.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadMedida.Location = New System.Drawing.Point(300, 114)
        Me.lblUnidadMedida.Name = "lblUnidadMedida"
        Me.lblUnidadMedida.Size = New System.Drawing.Size(169, 22)
        Me.lblUnidadMedida.TabIndex = 63
        Me.lblUnidadMedida.Text = "Unidad de medida:"
        '
        'txtMinimo
        '
        Me.txtMinimo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "minimo", True))
        Me.txtMinimo.Enabled = False
        Me.txtMinimo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtMinimo.Location = New System.Drawing.Point(147, 144)
        Me.txtMinimo.MaxLength = 49
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(127, 26)
        Me.txtMinimo.TabIndex = 54
        '
        'lblMinimo
        '
        Me.lblMinimo.AutoSize = True
        Me.lblMinimo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimo.Location = New System.Drawing.Point(12, 145)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(77, 22)
        Me.lblMinimo.TabIndex = 62
        Me.lblMinimo.Text = "Mínimo:"
        '
        'txtMaximo
        '
        Me.txtMaximo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "maximo", True))
        Me.txtMaximo.Enabled = False
        Me.txtMaximo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtMaximo.Location = New System.Drawing.Point(147, 110)
        Me.txtMaximo.MaxLength = 49
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(127, 26)
        Me.txtMaximo.TabIndex = 53
        '
        'lblMaximo
        '
        Me.lblMaximo.AutoSize = True
        Me.lblMaximo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaximo.Location = New System.Drawing.Point(12, 112)
        Me.lblMaximo.Name = "lblMaximo"
        Me.lblMaximo.Size = New System.Drawing.Size(80, 22)
        Me.lblMaximo.TabIndex = 61
        Me.lblMaximo.Text = "Máximo:"
        '
        'txtCosto
        '
        Me.txtCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "costo", True))
        Me.txtCosto.Enabled = False
        Me.txtCosto.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCosto.Location = New System.Drawing.Point(475, 75)
        Me.txtCosto.MaxLength = 49
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(197, 26)
        Me.txtCosto.TabIndex = 56
        '
        'txtExistencia
        '
        Me.txtExistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "existencia", True))
        Me.txtExistencia.Enabled = False
        Me.txtExistencia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtExistencia.Location = New System.Drawing.Point(147, 76)
        Me.txtExistencia.MaxLength = 49
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Size = New System.Drawing.Size(127, 26)
        Me.txtExistencia.TabIndex = 52
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistencia.Location = New System.Drawing.Point(12, 80)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(101, 22)
        Me.lblExistencia.TabIndex = 60
        Me.lblExistencia.Text = "Existencia:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "descripcion", True))
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtDescripcion.Location = New System.Drawing.Point(147, 43)
        Me.txtDescripcion.MaxLength = 30
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(525, 26)
        Me.txtDescripcion.TabIndex = 51
        '
        'txtidMaterial
        '
        Me.txtidMaterial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidMaterial.Location = New System.Drawing.Point(147, 7)
        Me.txtidMaterial.Name = "txtidMaterial"
        Me.txtidMaterial.ReadOnly = True
        Me.txtidMaterial.Size = New System.Drawing.Size(111, 26)
        Me.txtidMaterial.TabIndex = 50
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 45)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(116, 22)
        Me.lblDescripcion.TabIndex = 59
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblidMaterial
        '
        Me.lblidMaterial.AutoSize = True
        Me.lblidMaterial.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidMaterial.Location = New System.Drawing.Point(12, 9)
        Me.lblidMaterial.Name = "lblidMaterial"
        Me.lblidMaterial.Size = New System.Drawing.Size(132, 22)
        Me.lblidMaterial.TabIndex = 58
        Me.lblidMaterial.Text = "ID de Material:"
        '
        'dgMateriales
        '
        Me.dgMateriales.AllowUserToAddRows = False
        Me.dgMateriales.AllowUserToDeleteRows = False
        Me.dgMateriales.AutoGenerateColumns = False
        Me.dgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMaterialDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.MaximoDataGridViewTextBoxColumn, Me.MinimoDataGridViewTextBoxColumn, Me.UnidadMedidaDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.FechaUltimaCompraDataGridViewTextBoxColumn})
        Me.dgMateriales.DataSource = Me.MaterialBindingSource
        Me.dgMateriales.Location = New System.Drawing.Point(12, 223)
        Me.dgMateriales.Name = "dgMateriales"
        Me.dgMateriales.ReadOnly = True
        Me.dgMateriales.Size = New System.Drawing.Size(878, 292)
        Me.dgMateriales.TabIndex = 73
        '
        'IdMaterialDataGridViewTextBoxColumn
        '
        Me.IdMaterialDataGridViewTextBoxColumn.DataPropertyName = "idMaterial"
        Me.IdMaterialDataGridViewTextBoxColumn.HeaderText = "idMaterial"
        Me.IdMaterialDataGridViewTextBoxColumn.Name = "IdMaterialDataGridViewTextBoxColumn"
        Me.IdMaterialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaximoDataGridViewTextBoxColumn
        '
        Me.MaximoDataGridViewTextBoxColumn.DataPropertyName = "maximo"
        Me.MaximoDataGridViewTextBoxColumn.HeaderText = "maximo"
        Me.MaximoDataGridViewTextBoxColumn.Name = "MaximoDataGridViewTextBoxColumn"
        Me.MaximoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MinimoDataGridViewTextBoxColumn
        '
        Me.MinimoDataGridViewTextBoxColumn.DataPropertyName = "minimo"
        Me.MinimoDataGridViewTextBoxColumn.HeaderText = "minimo"
        Me.MinimoDataGridViewTextBoxColumn.Name = "MinimoDataGridViewTextBoxColumn"
        Me.MinimoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadMedidaDataGridViewTextBoxColumn
        '
        Me.UnidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "unidadMedida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.HeaderText = "unidadMedida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.Name = "UnidadMedidaDataGridViewTextBoxColumn"
        Me.UnidadMedidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaUltimaCompraDataGridViewTextBoxColumn
        '
        Me.FechaUltimaCompraDataGridViewTextBoxColumn.DataPropertyName = "fechaUltimaCompra"
        Me.FechaUltimaCompraDataGridViewTextBoxColumn.HeaderText = "fechaUltimaCompra"
        Me.FechaUltimaCompraDataGridViewTextBoxColumn.Name = "FechaUltimaCompraDataGridViewTextBoxColumn"
        Me.FechaUltimaCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.PSAP.My.Resources.Resources.cancel
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(522, 521)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(120, 35)
        Me.cmdCancelar.TabIndex = 72
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(255, 194)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 69
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(174, 194)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 68
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(93, 194)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 67
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(12, 194)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 66
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(647, 521)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 71
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(397, 521)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 70
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'MaterialTableAdapter
        '
        Me.MaterialTableAdapter.ClearBeforeFill = True
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(773, 521)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 74
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'frmMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(897, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgMateriales)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cboxUnidadMedida)
        Me.Controls.Add(Me.lblUltimaFechaCompra)
        Me.Controls.Add(Me.dtpFechaUltimaCompra)
        Me.Controls.Add(Me.lblCosto)
        Me.Controls.Add(Me.lblUnidadMedida)
        Me.Controls.Add(Me.txtMinimo)
        Me.Controls.Add(Me.lblMinimo)
        Me.Controls.Add(Me.txtMaximo)
        Me.Controls.Add(Me.lblMaximo)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtExistencia)
        Me.Controls.Add(Me.lblExistencia)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtidMaterial)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblidMaterial)
        Me.Name = "frmMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Materiales"
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSeTPSAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboxUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents lblUltimaFechaCompra As System.Windows.Forms.Label
    Friend WithEvents dtpFechaUltimaCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCosto As System.Windows.Forms.Label
    Friend WithEvents lblUnidadMedida As System.Windows.Forms.Label
    Friend WithEvents txtMinimo As System.Windows.Forms.TextBox
    Friend WithEvents lblMinimo As System.Windows.Forms.Label
    Friend WithEvents txtMaximo As System.Windows.Forms.TextBox
    Friend WithEvents lblMaximo As System.Windows.Forms.Label
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtExistencia As System.Windows.Forms.TextBox
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtidMaterial As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblidMaterial As System.Windows.Forms.Label
    Friend WithEvents dgMateriales As System.Windows.Forms.DataGridView
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdUltimo As System.Windows.Forms.Button
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents cmdInicio As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents DataSeTPSAP As PSAP.DataSeTPSAP
    Friend WithEvents MaterialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialTableAdapter As PSAP.DataSeTPSAPTableAdapters.MaterialTableAdapter
    Friend WithEvents IdMaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaximoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinimoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
End Class
