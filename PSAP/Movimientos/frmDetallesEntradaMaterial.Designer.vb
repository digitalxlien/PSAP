<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallesEntradaMaterial
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
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIdGasto = New System.Windows.Forms.Label()
        Me.txtidCompraMaterial = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.dgDetalleEntradaMaterial = New System.Windows.Forms.DataGridView()
        Me.idMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSalir = New System.Windows.Forms.Button()
        CType(Me.dgDetalleEntradaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(92, 52)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(168, 26)
        Me.dtpFecha.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(303, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 22)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(303, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 22)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "No. de Factura:"
        '
        'lblIdGasto
        '
        Me.lblIdGasto.AutoSize = True
        Me.lblIdGasto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdGasto.Location = New System.Drawing.Point(12, 14)
        Me.lblIdGasto.Name = "lblIdGasto"
        Me.lblIdGasto.Size = New System.Drawing.Size(132, 22)
        Me.lblIdGasto.TabIndex = 95
        Me.lblIdGasto.Text = "ID de Entrada:"
        '
        'txtidCompraMaterial
        '
        Me.txtidCompraMaterial.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidCompraMaterial.Location = New System.Drawing.Point(150, 12)
        Me.txtidCompraMaterial.MaxLength = 49
        Me.txtidCompraMaterial.Name = "txtidCompraMaterial"
        Me.txtidCompraMaterial.ReadOnly = True
        Me.txtidCompraMaterial.Size = New System.Drawing.Size(110, 26)
        Me.txtidCompraMaterial.TabIndex = 94
        '
        'txtProveedor
        '
        Me.txtProveedor.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtProveedor.Location = New System.Drawing.Point(413, 52)
        Me.txtProveedor.MaxLength = 49
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(302, 26)
        Me.txtProveedor.TabIndex = 101
        '
        'txtFactura
        '
        Me.txtFactura.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtFactura.Location = New System.Drawing.Point(448, 12)
        Me.txtFactura.MaxLength = 49
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(110, 26)
        Me.txtFactura.TabIndex = 102
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(536, 476)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 22)
        Me.Label17.TabIndex = 121
        Me.Label17.Text = "Total: $"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(545, 446)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 22)
        Me.Label16.TabIndex = 122
        Me.Label16.Text = "IVA: $"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(507, 414)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 22)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Subtotal: $"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTotal.Location = New System.Drawing.Point(613, 472)
        Me.txtTotal.MaxLength = 49
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(118, 26)
        Me.txtTotal.TabIndex = 120
        '
        'txtIva
        '
        Me.txtIva.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtIva.Location = New System.Drawing.Point(613, 442)
        Me.txtIva.MaxLength = 49
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(118, 26)
        Me.txtIva.TabIndex = 119
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSubtotal.Location = New System.Drawing.Point(613, 410)
        Me.txtSubtotal.MaxLength = 49
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(118, 26)
        Me.txtSubtotal.TabIndex = 118
        '
        'dgDetalleEntradaMaterial
        '
        Me.dgDetalleEntradaMaterial.AllowUserToAddRows = False
        Me.dgDetalleEntradaMaterial.AllowUserToDeleteRows = False
        Me.dgDetalleEntradaMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalleEntradaMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMaterial, Me.material, Me.cantidad, Me.costo, Me.importe})
        Me.dgDetalleEntradaMaterial.Location = New System.Drawing.Point(16, 112)
        Me.dgDetalleEntradaMaterial.Name = "dgDetalleEntradaMaterial"
        Me.dgDetalleEntradaMaterial.ReadOnly = True
        Me.dgDetalleEntradaMaterial.Size = New System.Drawing.Size(715, 283)
        Me.dgDetalleEntradaMaterial.TabIndex = 123
        '
        'idMaterial
        '
        Me.idMaterial.HeaderText = "ID de Material"
        Me.idMaterial.Name = "idMaterial"
        Me.idMaterial.ReadOnly = True
        Me.idMaterial.Width = 75
        '
        'material
        '
        Me.material.HeaderText = "Material"
        Me.material.Name = "material"
        Me.material.ReadOnly = True
        Me.material.Width = 285
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'costo
        '
        Me.costo.HeaderText = "Costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        '
        'importe
        '
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(613, 516)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 124
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'frmDetallesEntradaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgDetalleEntradaMaterial)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblIdGasto)
        Me.Controls.Add(Me.txtidCompraMaterial)
        Me.Name = "frmDetallesEntradaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles de la Compra"
        CType(Me.dgDetalleEntradaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblIdGasto As System.Windows.Forms.Label
    Friend WithEvents txtidCompraMaterial As System.Windows.Forms.TextBox
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents dgDetalleEntradaMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents idMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
End Class
