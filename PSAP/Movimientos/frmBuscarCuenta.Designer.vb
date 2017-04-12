<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCuenta
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.dgCuentas = New System.Windows.Forms.DataGridView()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaDeAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ultimaFechaPagada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdRegresar = New System.Windows.Forms.Button()
        Me.cmdSeleccionar = New System.Windows.Forms.Button()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(101, 23)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(155, 26)
        Me.txtNombre.TabIndex = 142
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistencia.Location = New System.Drawing.Point(12, 23)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(83, 22)
        Me.lblExistencia.TabIndex = 143
        Me.lblExistencia.Text = "Nombre:"
        '
        'dgCuentas
        '
        Me.dgCuentas.AllowUserToAddRows = False
        Me.dgCuentas.AllowUserToDeleteRows = False
        Me.dgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuenta, Me.nombre, Me.calle, Me.numeroExt, Me.numeroInt, Me.fechaDeAlta, Me.ultimaFechaPagada})
        Me.dgCuentas.Location = New System.Drawing.Point(16, 71)
        Me.dgCuentas.Name = "dgCuentas"
        Me.dgCuentas.ReadOnly = True
        Me.dgCuentas.Size = New System.Drawing.Size(869, 329)
        Me.dgCuentas.TabIndex = 144
        '
        'idCuenta
        '
        Me.idCuenta.HeaderText = "ID de Cuenta"
        Me.idCuenta.Name = "idCuenta"
        Me.idCuenta.ReadOnly = True
        Me.idCuenta.Width = 50
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'calle
        '
        Me.calle.HeaderText = "Calle"
        Me.calle.Name = "calle"
        Me.calle.ReadOnly = True
        Me.calle.Width = 200
        '
        'numeroExt
        '
        Me.numeroExt.HeaderText = "No. Ext."
        Me.numeroExt.Name = "numeroExt"
        Me.numeroExt.ReadOnly = True
        Me.numeroExt.Width = 50
        '
        'numeroInt
        '
        Me.numeroInt.HeaderText = "No. Int."
        Me.numeroInt.Name = "numeroInt"
        Me.numeroInt.ReadOnly = True
        Me.numeroInt.Width = 50
        '
        'fechaDeAlta
        '
        Me.fechaDeAlta.HeaderText = "Fecha de Alta"
        Me.fechaDeAlta.Name = "fechaDeAlta"
        Me.fechaDeAlta.ReadOnly = True
        '
        'ultimaFechaPagada
        '
        Me.ultimaFechaPagada.HeaderText = "Ultima Fecha Pagada"
        Me.ultimaFechaPagada.Name = "ultimaFechaPagada"
        Me.ultimaFechaPagada.ReadOnly = True
        Me.ultimaFechaPagada.Width = 150
        '
        'cmdRegresar
        '
        Me.cmdRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdRegresar.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRegresar.Location = New System.Drawing.Point(765, 406)
        Me.cmdRegresar.Name = "cmdRegresar"
        Me.cmdRegresar.Size = New System.Drawing.Size(120, 35)
        Me.cmdRegresar.TabIndex = 146
        Me.cmdRegresar.Text = "Regresar"
        Me.cmdRegresar.UseVisualStyleBackColor = True
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSeleccionar.Location = New System.Drawing.Point(624, 406)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(135, 35)
        Me.cmdSeleccionar.TabIndex = 145
        Me.cmdSeleccionar.Text = "Seleccionar"
        Me.cmdSeleccionar.UseVisualStyleBackColor = True
        '
        'frmBuscarCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdRegresar
        Me.ClientSize = New System.Drawing.Size(897, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdRegresar)
        Me.Controls.Add(Me.cmdSeleccionar)
        Me.Controls.Add(Me.dgCuentas)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblExistencia)
        Me.Name = "frmBuscarCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cuenta"
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents dgCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents idCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numeroExt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numeroInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaDeAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ultimaFechaPagada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdRegresar As System.Windows.Forms.Button
    Friend WithEvents cmdSeleccionar As System.Windows.Forms.Button
End Class
