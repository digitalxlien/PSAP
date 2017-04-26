<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarPago
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
        Me.dgPagos = New System.Windows.Forms.DataGridView()
        Me.idPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gboxConsulta = New System.Windows.Forms.GroupBox()
        Me.txtidCuenta = New System.Windows.Forms.TextBox()
        Me.txtidPago = New System.Windows.Forms.TextBox()
        Me.rbtnIdPago = New System.Windows.Forms.RadioButton()
        Me.cmdDetalles = New System.Windows.Forms.Button()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.rbtnTodos = New System.Windows.Forms.RadioButton()
        Me.rbtnIdCuenta = New System.Windows.Forms.RadioButton()
        Me.cmdSalir = New System.Windows.Forms.Button()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgPagos
        '
        Me.dgPagos.AllowUserToAddRows = False
        Me.dgPagos.AllowUserToDeleteRows = False
        Me.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPago, Me.idCliente, Me.nombre, Me.fecha, Me.tipo, Me.total})
        Me.dgPagos.Location = New System.Drawing.Point(12, 141)
        Me.dgPagos.Name = "dgPagos"
        Me.dgPagos.ReadOnly = True
        Me.dgPagos.Size = New System.Drawing.Size(873, 326)
        Me.dgPagos.TabIndex = 141
        '
        'idPago
        '
        Me.idPago.HeaderText = "ID de Pago"
        Me.idPago.Name = "idPago"
        Me.idPago.ReadOnly = True
        '
        'idCliente
        '
        Me.idCliente.HeaderText = "ID de Cliente"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'fecha
        '
        DataGridViewCellStyle1.Format = "D"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 200
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'gboxConsulta
        '
        Me.gboxConsulta.Controls.Add(Me.txtidCuenta)
        Me.gboxConsulta.Controls.Add(Me.txtidPago)
        Me.gboxConsulta.Controls.Add(Me.rbtnIdPago)
        Me.gboxConsulta.Controls.Add(Me.cmdDetalles)
        Me.gboxConsulta.Controls.Add(Me.cmdConsultar)
        Me.gboxConsulta.Controls.Add(Me.rbtnTodos)
        Me.gboxConsulta.Controls.Add(Me.rbtnIdCuenta)
        Me.gboxConsulta.Location = New System.Drawing.Point(14, 12)
        Me.gboxConsulta.Name = "gboxConsulta"
        Me.gboxConsulta.Size = New System.Drawing.Size(871, 107)
        Me.gboxConsulta.TabIndex = 143
        Me.gboxConsulta.TabStop = False
        Me.gboxConsulta.Text = "Consulta"
        '
        'txtidCuenta
        '
        Me.txtidCuenta.Enabled = False
        Me.txtidCuenta.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidCuenta.Location = New System.Drawing.Point(117, 18)
        Me.txtidCuenta.Name = "txtidCuenta"
        Me.txtidCuenta.Size = New System.Drawing.Size(195, 26)
        Me.txtidCuenta.TabIndex = 99
        '
        'txtidPago
        '
        Me.txtidPago.Enabled = False
        Me.txtidPago.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtidPago.Location = New System.Drawing.Point(465, 15)
        Me.txtidPago.Name = "txtidPago"
        Me.txtidPago.Size = New System.Drawing.Size(195, 26)
        Me.txtidPago.TabIndex = 98
        '
        'rbtnIdPago
        '
        Me.rbtnIdPago.AutoSize = True
        Me.rbtnIdPago.Location = New System.Drawing.Point(375, 21)
        Me.rbtnIdPago.Name = "rbtnIdPago"
        Me.rbtnIdPago.Size = New System.Drawing.Size(82, 17)
        Me.rbtnIdPago.TabIndex = 97
        Me.rbtnIdPago.Text = "ID de Pago:"
        Me.rbtnIdPago.UseVisualStyleBackColor = True
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
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(679, 71)
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
        Me.rbtnTodos.Location = New System.Drawing.Point(15, 54)
        Me.rbtnTodos.Name = "rbtnTodos"
        Me.rbtnTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbtnTodos.TabIndex = 3
        Me.rbtnTodos.TabStop = True
        Me.rbtnTodos.Text = "Todos"
        Me.rbtnTodos.UseVisualStyleBackColor = True
        '
        'rbtnIdCuenta
        '
        Me.rbtnIdCuenta.AutoSize = True
        Me.rbtnIdCuenta.Location = New System.Drawing.Point(15, 21)
        Me.rbtnIdCuenta.Name = "rbtnIdCuenta"
        Me.rbtnIdCuenta.Size = New System.Drawing.Size(91, 17)
        Me.rbtnIdCuenta.TabIndex = 1
        Me.rbtnIdCuenta.Text = "ID de Cuenta:"
        Me.rbtnIdCuenta.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(765, 484)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 142
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'frmConsultarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 531)
        Me.ControlBox = False
        Me.Controls.Add(Me.gboxConsulta)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgPagos)
        Me.Name = "frmConsultarPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Pagos"
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxConsulta.ResumeLayout(False)
        Me.gboxConsulta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents dgPagos As System.Windows.Forms.DataGridView
    Friend WithEvents idPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gboxConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents txtidCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtidPago As System.Windows.Forms.TextBox
    Friend WithEvents rbtnIdPago As System.Windows.Forms.RadioButton
    Friend WithEvents cmdDetalles As System.Windows.Forms.Button
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents rbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnIdCuenta As System.Windows.Forms.RadioButton
End Class
