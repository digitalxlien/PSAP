<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarEntradaMaterial
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
        Me.gboxConsulta = New System.Windows.Forms.GroupBox()
        Me.cmdDetalles = New System.Windows.Forms.Button()
        Me.txtConsultaFactura = New System.Windows.Forms.TextBox()
        Me.dtpConsultaFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboxConsultaProveedor = New System.Windows.Forms.ComboBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.rbtnTodos = New System.Windows.Forms.RadioButton()
        Me.rbtnFactura = New System.Windows.Forms.RadioButton()
        Me.rbtnProveedor = New System.Windows.Forms.RadioButton()
        Me.rbtnFecha = New System.Windows.Forms.RadioButton()
        Me.dgCompraMaterial = New System.Windows.Forms.DataGridView()
        Me.idCompraMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.gboxConsulta.SuspendLayout()
        CType(Me.dgCompraMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboxConsulta
        '
        Me.gboxConsulta.Controls.Add(Me.cmdDetalles)
        Me.gboxConsulta.Controls.Add(Me.txtConsultaFactura)
        Me.gboxConsulta.Controls.Add(Me.dtpConsultaFecha)
        Me.gboxConsulta.Controls.Add(Me.cboxConsultaProveedor)
        Me.gboxConsulta.Controls.Add(Me.cmdConsultar)
        Me.gboxConsulta.Controls.Add(Me.rbtnTodos)
        Me.gboxConsulta.Controls.Add(Me.rbtnFactura)
        Me.gboxConsulta.Controls.Add(Me.rbtnProveedor)
        Me.gboxConsulta.Controls.Add(Me.rbtnFecha)
        Me.gboxConsulta.Location = New System.Drawing.Point(12, 12)
        Me.gboxConsulta.Name = "gboxConsulta"
        Me.gboxConsulta.Size = New System.Drawing.Size(871, 107)
        Me.gboxConsulta.TabIndex = 90
        Me.gboxConsulta.TabStop = False
        Me.gboxConsulta.Text = "Consulta"
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
        'txtConsultaFactura
        '
        Me.txtConsultaFactura.Location = New System.Drawing.Point(111, 76)
        Me.txtConsultaFactura.Name = "txtConsultaFactura"
        Me.txtConsultaFactura.Size = New System.Drawing.Size(199, 20)
        Me.txtConsultaFactura.TabIndex = 91
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
        'cboxConsultaProveedor
        '
        Me.cboxConsultaProveedor.FormattingEnabled = True
        Me.cboxConsultaProveedor.Location = New System.Drawing.Point(111, 48)
        Me.cboxConsultaProveedor.Name = "cboxConsultaProveedor"
        Me.cboxConsultaProveedor.Size = New System.Drawing.Size(199, 21)
        Me.cboxConsultaProveedor.TabIndex = 6
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
        'rbtnFactura
        '
        Me.rbtnFactura.AutoSize = True
        Me.rbtnFactura.Location = New System.Drawing.Point(15, 79)
        Me.rbtnFactura.Name = "rbtnFactura"
        Me.rbtnFactura.Size = New System.Drawing.Size(64, 17)
        Me.rbtnFactura.TabIndex = 2
        Me.rbtnFactura.Text = "Fectura:"
        Me.rbtnFactura.UseVisualStyleBackColor = True
        '
        'rbtnProveedor
        '
        Me.rbtnProveedor.AutoSize = True
        Me.rbtnProveedor.Location = New System.Drawing.Point(15, 50)
        Me.rbtnProveedor.Name = "rbtnProveedor"
        Me.rbtnProveedor.Size = New System.Drawing.Size(77, 17)
        Me.rbtnProveedor.TabIndex = 1
        Me.rbtnProveedor.Text = "Proveedor:"
        Me.rbtnProveedor.UseVisualStyleBackColor = True
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
        'dgCompraMaterial
        '
        Me.dgCompraMaterial.AllowUserToAddRows = False
        Me.dgCompraMaterial.AllowUserToDeleteRows = False
        Me.dgCompraMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCompraMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCompraMaterial, Me.factura, Me.idProveedor, Me.nombreProveedor, Me.fecha, Me.subtotal, Me.iva, Me.total})
        Me.dgCompraMaterial.Location = New System.Drawing.Point(12, 138)
        Me.dgCompraMaterial.Name = "dgCompraMaterial"
        Me.dgCompraMaterial.ReadOnly = True
        Me.dgCompraMaterial.Size = New System.Drawing.Size(871, 368)
        Me.dgCompraMaterial.TabIndex = 91
        '
        'idCompraMaterial
        '
        Me.idCompraMaterial.HeaderText = "ID de Compra"
        Me.idCompraMaterial.Name = "idCompraMaterial"
        Me.idCompraMaterial.ReadOnly = True
        '
        'factura
        '
        Me.factura.HeaderText = "No. de Factura"
        Me.factura.Name = "factura"
        Me.factura.ReadOnly = True
        '
        'idProveedor
        '
        Me.idProveedor.HeaderText = "ID de Proveedor"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.ReadOnly = True
        '
        'nombreProveedor
        '
        Me.nombreProveedor.HeaderText = "Nombre del Proveedor"
        Me.nombreProveedor.Name = "nombreProveedor"
        Me.nombreProveedor.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'iva
        '
        Me.iva.HeaderText = "I.V.A."
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(763, 512)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 140
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'frmConsultarEntradaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 557)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgCompraMaterial)
        Me.Controls.Add(Me.gboxConsulta)
        Me.Name = "frmConsultarEntradaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Compras de Material"
        Me.gboxConsulta.ResumeLayout(False)
        Me.gboxConsulta.PerformLayout()
        CType(Me.dgCompraMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboxConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents dtpConsultaFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboxConsultaProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents rbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFactura As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents dgCompraMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents idCompraMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtConsultaFactura As System.Windows.Forms.TextBox
    Friend WithEvents cmdDetalles As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
End Class
