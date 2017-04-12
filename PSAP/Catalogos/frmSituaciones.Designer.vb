<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSituaciones
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
        Me.txtidSituacion = New System.Windows.Forms.TextBox()
        Me.lblGasto = New System.Windows.Forms.Label()
        Me.lblidGasto = New System.Windows.Forms.Label()
        Me.dgSituaciones = New System.Windows.Forms.DataGridView()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.DataSetPSAP = New PSAP.DataSetPSAP()
        Me.SituacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SituacionTableAdapter = New PSAP.DataSetPSAPTableAdapters.SituacionTableAdapter()
        Me.IdSituacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.NumericUpDown()
        CType(Me.dgSituaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SituacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(253, 166)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 23
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(172, 166)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 22
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(91, 166)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 21
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(10, 166)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 20
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SituacionBindingSource, "descripcion", True))
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtDescripcion.Location = New System.Drawing.Point(157, 63)
        Me.txtDescripcion.MaxLength = 49
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(330, 26)
        Me.txtDescripcion.TabIndex = 19
        '
        'txtidSituacion
        '
        Me.txtidSituacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidSituacion.Location = New System.Drawing.Point(162, 19)
        Me.txtidSituacion.Name = "txtidSituacion"
        Me.txtidSituacion.ReadOnly = True
        Me.txtidSituacion.Size = New System.Drawing.Size(115, 26)
        Me.txtidSituacion.TabIndex = 18
        '
        'lblGasto
        '
        Me.lblGasto.AutoSize = True
        Me.lblGasto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGasto.Location = New System.Drawing.Point(12, 63)
        Me.lblGasto.Name = "lblGasto"
        Me.lblGasto.Size = New System.Drawing.Size(116, 22)
        Me.lblGasto.TabIndex = 17
        Me.lblGasto.Text = "Descripción:"
        '
        'lblidGasto
        '
        Me.lblidGasto.AutoSize = True
        Me.lblidGasto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidGasto.Location = New System.Drawing.Point(12, 23)
        Me.lblidGasto.Name = "lblidGasto"
        Me.lblidGasto.Size = New System.Drawing.Size(144, 22)
        Me.lblidGasto.TabIndex = 16
        Me.lblidGasto.Text = "ID de Situación:"
        '
        'dgSituaciones
        '
        Me.dgSituaciones.AllowUserToAddRows = False
        Me.dgSituaciones.AllowUserToDeleteRows = False
        Me.dgSituaciones.AutoGenerateColumns = False
        Me.dgSituaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSituaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSituacionDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DescuentoDataGridViewTextBoxColumn})
        Me.dgSituaciones.DataSource = Me.SituacionBindingSource
        Me.dgSituaciones.Location = New System.Drawing.Point(10, 195)
        Me.dgSituaciones.Name = "dgSituaciones"
        Me.dgSituaciones.ReadOnly = True
        Me.dgSituaciones.Size = New System.Drawing.Size(587, 300)
        Me.dgSituaciones.TabIndex = 15
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(477, 501)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 14
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(351, 501)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 13
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(225, 501)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 12
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'DataSetPSAP
        '
        Me.DataSetPSAP.DataSetName = "DataSetPSAP"
        Me.DataSetPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SituacionBindingSource
        '
        Me.SituacionBindingSource.DataMember = "Situacion"
        Me.SituacionBindingSource.DataSource = Me.DataSetPSAP
        '
        'SituacionTableAdapter
        '
        Me.SituacionTableAdapter.ClearBeforeFill = True
        '
        'IdSituacionDataGridViewTextBoxColumn
        '
        Me.IdSituacionDataGridViewTextBoxColumn.DataPropertyName = "idSituacion"
        Me.IdSituacionDataGridViewTextBoxColumn.HeaderText = "ID de Situacion"
        Me.IdSituacionDataGridViewTextBoxColumn.Name = "IdSituacionDataGridViewTextBoxColumn"
        Me.IdSituacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 300
        '
        'DescuentoDataGridViewTextBoxColumn
        '
        Me.DescuentoDataGridViewTextBoxColumn.DataPropertyName = "descuento"
        Me.DescuentoDataGridViewTextBoxColumn.HeaderText = "Descuento (%)"
        Me.DescuentoDataGridViewTextBoxColumn.Name = "DescuentoDataGridViewTextBoxColumn"
        Me.DescuentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescuentoDataGridViewTextBoxColumn.Width = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 22)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Descuento (%):"
        '
        'txtDescuento
        '
        Me.txtDescuento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SituacionBindingSource, "descuento", True))
        Me.txtDescuento.DecimalPlaces = 2
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtDescuento.Location = New System.Drawing.Point(157, 107)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(120, 26)
        Me.txtDescuento.TabIndex = 25
        '
        'frmSituaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 548)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtidSituacion)
        Me.Controls.Add(Me.lblGasto)
        Me.Controls.Add(Me.lblidGasto)
        Me.Controls.Add(Me.dgSituaciones)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Name = "frmSituaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Situaciones"
        CType(Me.dgSituaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SituacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdUltimo As System.Windows.Forms.Button
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents cmdInicio As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtidSituacion As System.Windows.Forms.TextBox
    Friend WithEvents lblGasto As System.Windows.Forms.Label
    Friend WithEvents lblidGasto As System.Windows.Forms.Label
    Friend WithEvents dgSituaciones As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents DataSetPSAP As PSAP.DataSetPSAP
    Friend WithEvents SituacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SituacionTableAdapter As PSAP.DataSetPSAPTableAdapters.SituacionTableAdapter
    Friend WithEvents IdSituacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As System.Windows.Forms.NumericUpDown
End Class
