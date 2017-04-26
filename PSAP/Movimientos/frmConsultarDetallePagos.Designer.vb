<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarDetallePagos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgServicios = New System.Windows.Forms.DataGridView()
        Me.servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgAgua = New System.Windows.Forms.DataGridView()
        Me.anio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mesInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mesFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coutaFija = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.infra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.situacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gboxCuenta = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaAlta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUltimoPeriodoPagado = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtidCuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidPago = New System.Windows.Forms.TextBox()
        Me.lblIDMaterial = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAgua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(978, 447)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(120, 35)
        Me.cmdImprimir.TabIndex = 170
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(452, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 22)
        Me.Label8.TabIndex = 168
        Me.Label8.Text = "Otros:"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(974, 410)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(71, 22)
        Me.Total.TabIndex = 166
        Me.Total.Text = "Total $:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(452, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(260, 22)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "Detalle del pago de servicios:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(452, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 22)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "Detalle del pago de agua:"
        '
        'dgServicios
        '
        Me.dgServicios.AllowUserToAddRows = False
        Me.dgServicios.AllowUserToDeleteRows = False
        Me.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.servicio, Me.empleado, Me.precio})
        Me.dgServicios.Location = New System.Drawing.Point(456, 240)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.ReadOnly = True
        Me.dgServicios.Size = New System.Drawing.Size(772, 150)
        Me.dgServicios.TabIndex = 163
        '
        'servicio
        '
        Me.servicio.HeaderText = "Servicio"
        Me.servicio.Name = "servicio"
        Me.servicio.ReadOnly = True
        Me.servicio.Width = 325
        '
        'empleado
        '
        DataGridViewCellStyle1.Format = "C2"
        Me.empleado.DefaultCellStyle = DataGridViewCellStyle1
        Me.empleado.HeaderText = "Empleado"
        Me.empleado.Name = "empleado"
        Me.empleado.ReadOnly = True
        Me.empleado.Width = 300
        '
        'precio
        '
        DataGridViewCellStyle2.Format = "N2"
        Me.precio.DefaultCellStyle = DataGridViewCellStyle2
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'dgAgua
        '
        Me.dgAgua.AllowUserToAddRows = False
        Me.dgAgua.AllowUserToDeleteRows = False
        Me.dgAgua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAgua.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.anio, Me.mesInicio, Me.mesFin, Me.coutaFija, Me.recargos, Me.tar, Me.infra, Me.situacion, Me.descuento, Me.importe})
        Me.dgAgua.Location = New System.Drawing.Point(456, 42)
        Me.dgAgua.Name = "dgAgua"
        Me.dgAgua.ReadOnly = True
        Me.dgAgua.Size = New System.Drawing.Size(772, 150)
        Me.dgAgua.TabIndex = 162
        '
        'anio
        '
        Me.anio.HeaderText = "Año"
        Me.anio.Name = "anio"
        Me.anio.ReadOnly = True
        Me.anio.Width = 50
        '
        'mesInicio
        '
        Me.mesInicio.HeaderText = "Mes Inicial"
        Me.mesInicio.Name = "mesInicio"
        Me.mesInicio.ReadOnly = True
        Me.mesInicio.Width = 60
        '
        'mesFin
        '
        Me.mesFin.HeaderText = "Mes Final"
        Me.mesFin.Name = "mesFin"
        Me.mesFin.ReadOnly = True
        Me.mesFin.Width = 60
        '
        'coutaFija
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.coutaFija.DefaultCellStyle = DataGridViewCellStyle3
        Me.coutaFija.HeaderText = "Cuota Fija"
        Me.coutaFija.Name = "coutaFija"
        Me.coutaFija.ReadOnly = True
        Me.coutaFija.Width = 75
        '
        'recargos
        '
        DataGridViewCellStyle4.Format = "N2"
        Me.recargos.DefaultCellStyle = DataGridViewCellStyle4
        Me.recargos.HeaderText = "Recargos"
        Me.recargos.Name = "recargos"
        Me.recargos.ReadOnly = True
        Me.recargos.Width = 75
        '
        'tar
        '
        DataGridViewCellStyle5.Format = "N2"
        Me.tar.DefaultCellStyle = DataGridViewCellStyle5
        Me.tar.HeaderText = "T.A.R."
        Me.tar.Name = "tar"
        Me.tar.ReadOnly = True
        Me.tar.Width = 75
        '
        'infra
        '
        DataGridViewCellStyle6.Format = "N2"
        Me.infra.DefaultCellStyle = DataGridViewCellStyle6
        Me.infra.HeaderText = "Infraestructura"
        Me.infra.Name = "infra"
        Me.infra.ReadOnly = True
        Me.infra.Width = 75
        '
        'situacion
        '
        Me.situacion.HeaderText = "Situacion"
        Me.situacion.Name = "situacion"
        Me.situacion.ReadOnly = True
        Me.situacion.Width = 75
        '
        'descuento
        '
        DataGridViewCellStyle7.Format = "N2"
        Me.descuento.DefaultCellStyle = DataGridViewCellStyle7
        Me.descuento.HeaderText = "Descuento"
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        Me.descuento.Width = 80
        '
        'importe
        '
        DataGridViewCellStyle8.Format = "N2"
        Me.importe.DefaultCellStyle = DataGridViewCellStyle8
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'gboxCuenta
        '
        Me.gboxCuenta.Controls.Add(Me.Label5)
        Me.gboxCuenta.Controls.Add(Me.txtFechaAlta)
        Me.gboxCuenta.Controls.Add(Me.Label4)
        Me.gboxCuenta.Controls.Add(Me.txtUltimoPeriodoPagado)
        Me.gboxCuenta.Controls.Add(Me.txtNombre)
        Me.gboxCuenta.Controls.Add(Me.txtidCuenta)
        Me.gboxCuenta.Controls.Add(Me.Label2)
        Me.gboxCuenta.Controls.Add(Me.lblExistencia)
        Me.gboxCuenta.Location = New System.Drawing.Point(11, 80)
        Me.gboxCuenta.Name = "gboxCuenta"
        Me.gboxCuenta.Size = New System.Drawing.Size(426, 195)
        Me.gboxCuenta.TabIndex = 159
        Me.gboxCuenta.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 22)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Último mes pagado:"
        '
        'txtFechaAlta
        '
        Me.txtFechaAlta.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtFechaAlta.Location = New System.Drawing.Point(152, 97)
        Me.txtFechaAlta.MaxLength = 49
        Me.txtFechaAlta.Name = "txtFechaAlta"
        Me.txtFechaAlta.ReadOnly = True
        Me.txtFechaAlta.Size = New System.Drawing.Size(258, 26)
        Me.txtFechaAlta.TabIndex = 142
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 22)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Fecha de alta:"
        '
        'txtUltimoPeriodoPagado
        '
        Me.txtUltimoPeriodoPagado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtUltimoPeriodoPagado.Location = New System.Drawing.Point(200, 138)
        Me.txtUltimoPeriodoPagado.MaxLength = 49
        Me.txtUltimoPeriodoPagado.Name = "txtUltimoPeriodoPagado"
        Me.txtUltimoPeriodoPagado.ReadOnly = True
        Me.txtUltimoPeriodoPagado.Size = New System.Drawing.Size(210, 26)
        Me.txtUltimoPeriodoPagado.TabIndex = 64
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(152, 58)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(258, 26)
        Me.txtNombre.TabIndex = 64
        '
        'txtidCuenta
        '
        Me.txtidCuenta.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidCuenta.Location = New System.Drawing.Point(152, 22)
        Me.txtidCuenta.MaxLength = 49
        Me.txtidCuenta.Name = "txtidCuenta"
        Me.txtidCuenta.ReadOnly = True
        Me.txtidCuenta.Size = New System.Drawing.Size(155, 26)
        Me.txtidCuenta.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 22)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Nombre:"
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistencia.Location = New System.Drawing.Point(19, 26)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(127, 22)
        Me.lblExistencia.TabIndex = 62
        Me.lblExistencia.Text = "ID de Cuenta:"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(85, 48)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(352, 26)
        Me.txtFecha.TabIndex = 157
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Fecha:"
        '
        'txtidPago
        '
        Me.txtidPago.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidPago.Location = New System.Drawing.Point(129, 12)
        Me.txtidPago.Name = "txtidPago"
        Me.txtidPago.ReadOnly = True
        Me.txtidPago.Size = New System.Drawing.Size(308, 26)
        Me.txtidPago.TabIndex = 155
        '
        'lblIDMaterial
        '
        Me.lblIDMaterial.AutoSize = True
        Me.lblIDMaterial.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDMaterial.Location = New System.Drawing.Point(11, 14)
        Me.lblIDMaterial.Name = "lblIDMaterial"
        Me.lblIDMaterial.Size = New System.Drawing.Size(112, 22)
        Me.lblIDMaterial.TabIndex = 156
        Me.lblIDMaterial.Text = "ID de Pago:"
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(1108, 447)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 173
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(1067, 409)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(159, 32)
        Me.txtTotal.TabIndex = 172
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOtros
        '
        Me.txtOtros.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtros.ForeColor = System.Drawing.Color.Black
        Me.txtOtros.Location = New System.Drawing.Point(519, 410)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.ReadOnly = True
        Me.txtOtros.Size = New System.Drawing.Size(126, 32)
        Me.txtOtros.TabIndex = 174
        Me.txtOtros.Text = "0"
        Me.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmConsultarDetallePagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 501)
        Me.Controls.Add(Me.txtOtros)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgServicios)
        Me.Controls.Add(Me.dgAgua)
        Me.Controls.Add(Me.gboxCuenta)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidPago)
        Me.Controls.Add(Me.lblIDMaterial)
        Me.Name = "frmConsultarDetallePagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Pago"
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAgua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxCuenta.ResumeLayout(False)
        Me.gboxCuenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgServicios As System.Windows.Forms.DataGridView
    Friend WithEvents dgAgua As System.Windows.Forms.DataGridView
    Friend WithEvents gboxCuenta As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFechaAlta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUltimoPeriodoPagado As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtidCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidPago As System.Windows.Forms.TextBox
    Friend WithEvents lblIDMaterial As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents servicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents anio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mesInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mesFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coutaFija As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents recargos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents infra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents situacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtOtros As System.Windows.Forms.TextBox
End Class
