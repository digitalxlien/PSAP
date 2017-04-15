<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarPagoServicio
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
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lblidEmpleado = New System.Windows.Forms.Label()
        Me.cboxServicio = New System.Windows.Forms.ComboBox()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.cboxEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCosto
        '
        Me.txtCosto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Location = New System.Drawing.Point(110, 105)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.ReadOnly = True
        Me.txtCosto.Size = New System.Drawing.Size(140, 26)
        Me.txtCosto.TabIndex = 65
        Me.txtCosto.Text = "0"
        '
        'lblidEmpleado
        '
        Me.lblidEmpleado.AutoSize = True
        Me.lblidEmpleado.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidEmpleado.Location = New System.Drawing.Point(12, 105)
        Me.lblidEmpleado.Name = "lblidEmpleado"
        Me.lblidEmpleado.Size = New System.Drawing.Size(82, 22)
        Me.lblidEmpleado.TabIndex = 64
        Me.lblidEmpleado.Text = "Costo $:"
        '
        'cboxServicio
        '
        Me.cboxServicio.DisplayMember = "nombre"
        Me.cboxServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxServicio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboxServicio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxServicio.FormattingEnabled = True
        Me.cboxServicio.Location = New System.Drawing.Point(110, 19)
        Me.cboxServicio.Name = "cboxServicio"
        Me.cboxServicio.Size = New System.Drawing.Size(466, 26)
        Me.cboxServicio.TabIndex = 62
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.Location = New System.Drawing.Point(12, 19)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(83, 22)
        Me.lblCalle.TabIndex = 63
        Me.lblCalle.Text = "Servicio:"
        '
        'cboxEmpleado
        '
        Me.cboxEmpleado.DisplayMember = "nombre"
        Me.cboxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboxEmpleado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxEmpleado.FormattingEnabled = True
        Me.cboxEmpleado.Location = New System.Drawing.Point(110, 62)
        Me.cboxEmpleado.Name = "cboxEmpleado"
        Me.cboxEmpleado.Size = New System.Drawing.Size(466, 26)
        Me.cboxEmpleado.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Empleado:"
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(452, 148)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 79
        Me.cmdSalir.Text = "Regresar"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(326, 148)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(120, 35)
        Me.cmdAceptar.TabIndex = 78
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'frmCargarPagoServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(580, 189)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cboxEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.lblidEmpleado)
        Me.Controls.Add(Me.cboxServicio)
        Me.Controls.Add(Me.lblCalle)
        Me.Name = "frmCargarPagoServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Pago de Servicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents lblidEmpleado As System.Windows.Forms.Label
    Friend WithEvents cboxServicio As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents cboxEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
End Class
