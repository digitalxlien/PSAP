<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicios
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
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtIdServicio = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblidServicio = New System.Windows.Forms.Label()
        Me.dgServicios = New System.Windows.Forms.DataGridView()
        Me.IdServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPSAP = New PSAP.DataSetPSAP()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.ServicioTableAdapter = New PSAP.DataSetPSAPTableAdapters.ServicioTableAdapter()
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(253, 123)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 6
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(172, 123)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 5
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(91, 123)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 3
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(10, 123)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 3
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtDescripcion.Location = New System.Drawing.Point(144, 42)
        Me.txtDescripcion.MaxLength = 49
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(330, 26)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtIdServicio
        '
        Me.txtIdServicio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdServicio.Location = New System.Drawing.Point(144, 5)
        Me.txtIdServicio.Name = "txtIdServicio"
        Me.txtIdServicio.ReadOnly = True
        Me.txtIdServicio.Size = New System.Drawing.Size(103, 26)
        Me.txtIdServicio.TabIndex = 30
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 42)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(116, 22)
        Me.lblDescripcion.TabIndex = 29
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblidServicio
        '
        Me.lblidServicio.AutoSize = True
        Me.lblidServicio.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidServicio.Location = New System.Drawing.Point(12, 9)
        Me.lblidServicio.Name = "lblidServicio"
        Me.lblidServicio.Size = New System.Drawing.Size(135, 22)
        Me.lblidServicio.TabIndex = 28
        Me.lblidServicio.Text = "ID de Servicio:"
        '
        'dgServicios
        '
        Me.dgServicios.AllowUserToAddRows = False
        Me.dgServicios.AllowUserToDeleteRows = False
        Me.dgServicios.AutoGenerateColumns = False
        Me.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdServicioDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.dgServicios.DataSource = Me.ServicioBindingSource
        Me.dgServicios.Location = New System.Drawing.Point(10, 164)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.ReadOnly = True
        Me.dgServicios.Size = New System.Drawing.Size(517, 192)
        Me.dgServicios.TabIndex = 27
        '
        'IdServicioDataGridViewTextBoxColumn
        '
        Me.IdServicioDataGridViewTextBoxColumn.DataPropertyName = "idServicio"
        Me.IdServicioDataGridViewTextBoxColumn.HeaderText = "ID de Servicio"
        Me.IdServicioDataGridViewTextBoxColumn.Name = "IdServicioDataGridViewTextBoxColumn"
        Me.IdServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 250
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServicioBindingSource
        '
        Me.ServicioBindingSource.DataMember = "Servicio"
        Me.ServicioBindingSource.DataSource = Me.DataSetPSAP
        '
        'DataSetPSAP
        '
        Me.DataSetPSAP.DataSetName = "DataSetPSAP"
        Me.DataSetPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(407, 381)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 9
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(281, 381)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 8
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(155, 381)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 7
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtPrecio.Location = New System.Drawing.Point(144, 82)
        Me.txtPrecio.MaxLength = 49
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(330, 26)
        Me.txtPrecio.TabIndex = 2
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(12, 82)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(70, 22)
        Me.lblPrecio.TabIndex = 36
        Me.lblPrecio.Text = "Precio:"
        '
        'ServicioTableAdapter
        '
        Me.ServicioTableAdapter.ClearBeforeFill = True
        '
        'frmServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 428)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdServicio)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblidServicio)
        Me.Controls.Add(Me.dgServicios)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Name = "frmServicios"
        Me.Text = "Servicios"
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdUltimo As System.Windows.Forms.Button
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents cmdInicio As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtIdServicio As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblidServicio As System.Windows.Forms.Label
    Friend WithEvents dgServicios As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents DataSetPSAP As PSAP.DataSetPSAP
    Friend WithEvents ServicioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServicioTableAdapter As PSAP.DataSetPSAPTableAdapters.ServicioTableAdapter
    Friend WithEvents IdServicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
