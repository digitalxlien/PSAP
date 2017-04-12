<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallesSalidaMaterial
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.dgDetalleSalidaMaterial = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSalida = New System.Windows.Forms.Label()
        Me.txtidSalidaMaterial = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.idMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgDetalleSalidaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(613, 511)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 139
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'dgDetalleSalidaMaterial
        '
        Me.dgDetalleSalidaMaterial.AllowUserToAddRows = False
        Me.dgDetalleSalidaMaterial.AllowUserToDeleteRows = False
        Me.dgDetalleSalidaMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalleSalidaMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMaterial, Me.material, Me.cantidad, Me.costo, Me.importe})
        Me.dgDetalleSalidaMaterial.Location = New System.Drawing.Point(16, 151)
        Me.dgDetalleSalidaMaterial.Name = "dgDetalleSalidaMaterial"
        Me.dgDetalleSalidaMaterial.ReadOnly = True
        Me.dgDetalleSalidaMaterial.Size = New System.Drawing.Size(715, 297)
        Me.dgDetalleSalidaMaterial.TabIndex = 138
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(545, 467)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 22)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Total:"
        '
        'txtCalle
        '
        Me.txtCalle.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCalle.Location = New System.Drawing.Point(413, 17)
        Me.txtCalle.MaxLength = 49
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.ReadOnly = True
        Me.txtCalle.Size = New System.Drawing.Size(302, 26)
        Me.txtCalle.TabIndex = 132
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtEmpleado.Location = New System.Drawing.Point(413, 57)
        Me.txtEmpleado.MaxLength = 49
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.ReadOnly = True
        Me.txtEmpleado.Size = New System.Drawing.Size(302, 26)
        Me.txtEmpleado.TabIndex = 131
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(303, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 22)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Empleado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(303, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 22)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Calle:"
        '
        'lblSalida
        '
        Me.lblSalida.AutoSize = True
        Me.lblSalida.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalida.Location = New System.Drawing.Point(12, 19)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(119, 22)
        Me.lblSalida.TabIndex = 127
        Me.lblSalida.Text = "ID de Salida:"
        '
        'txtidSalidaMaterial
        '
        Me.txtidSalidaMaterial.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidSalidaMaterial.Location = New System.Drawing.Point(150, 17)
        Me.txtidSalidaMaterial.MaxLength = 49
        Me.txtidSalidaMaterial.Name = "txtidSalidaMaterial"
        Me.txtidSalidaMaterial.ReadOnly = True
        Me.txtidSalidaMaterial.Size = New System.Drawing.Size(110, 26)
        Me.txtidSalidaMaterial.TabIndex = 126
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTotal.Location = New System.Drawing.Point(613, 467)
        Me.txtTotal.MaxLength = 49
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(118, 26)
        Me.txtTotal.TabIndex = 136
        '
        'txtConcepto
        '
        Me.txtConcepto.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtConcepto.Location = New System.Drawing.Point(122, 96)
        Me.txtConcepto.MaxLength = 49
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ReadOnly = True
        Me.txtConcepto.Size = New System.Drawing.Size(593, 26)
        Me.txtConcepto.TabIndex = 141
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 22)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "Concepto:"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtFecha.Location = New System.Drawing.Point(86, 57)
        Me.txtFecha.MaxLength = 49
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(211, 26)
        Me.txtFecha.TabIndex = 142
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
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'costo
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.costo.DefaultCellStyle = DataGridViewCellStyle2
        Me.costo.HeaderText = "Costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        '
        'importe
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.importe.DefaultCellStyle = DataGridViewCellStyle3
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'frmDetallesSalidaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgDetalleSalidaMaterial)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtEmpleado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSalida)
        Me.Controls.Add(Me.txtidSalidaMaterial)
        Me.Name = "frmDetallesSalidaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Salida de Material"
        CType(Me.dgDetalleSalidaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents dgDetalleSalidaMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSalida As System.Windows.Forms.Label
    Friend WithEvents txtidSalidaMaterial As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents idMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
