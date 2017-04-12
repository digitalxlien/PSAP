<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Me.txtidPago = New System.Windows.Forms.TextBox()
        Me.lblIDMaterial = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboxCuenta = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gboxCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtidPago
        '
        Me.txtidPago.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidPago.Location = New System.Drawing.Point(130, 18)
        Me.txtidPago.Name = "txtidPago"
        Me.txtidPago.ReadOnly = True
        Me.txtidPago.Size = New System.Drawing.Size(163, 26)
        Me.txtidPago.TabIndex = 59
        '
        'lblIDMaterial
        '
        Me.lblIDMaterial.AutoSize = True
        Me.lblIDMaterial.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDMaterial.Location = New System.Drawing.Point(12, 20)
        Me.lblIDMaterial.Name = "lblIDMaterial"
        Me.lblIDMaterial.Size = New System.Drawing.Size(112, 22)
        Me.lblIDMaterial.TabIndex = 60
        Me.lblIDMaterial.Text = "ID de Pago:"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(130, 54)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(163, 26)
        Me.txtFecha.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Fecha:"
        '
        'gboxCuenta
        '
        Me.gboxCuenta.Controls.Add(Me.cmdSalir)
        Me.gboxCuenta.Controls.Add(Me.TextBox4)
        Me.gboxCuenta.Controls.Add(Me.Label5)
        Me.gboxCuenta.Controls.Add(Me.TextBox3)
        Me.gboxCuenta.Controls.Add(Me.TextBox2)
        Me.gboxCuenta.Controls.Add(Me.Label4)
        Me.gboxCuenta.Controls.Add(Me.Label3)
        Me.gboxCuenta.Controls.Add(Me.TextBox1)
        Me.gboxCuenta.Controls.Add(Me.txtExistencia)
        Me.gboxCuenta.Controls.Add(Me.Label2)
        Me.gboxCuenta.Controls.Add(Me.lblExistencia)
        Me.gboxCuenta.Location = New System.Drawing.Point(12, 86)
        Me.gboxCuenta.Name = "gboxCuenta"
        Me.gboxCuenta.Size = New System.Drawing.Size(426, 256)
        Me.gboxCuenta.TabIndex = 63
        Me.gboxCuenta.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(248, 203)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(162, 35)
        Me.cmdSalir.TabIndex = 141
        Me.cmdSalir.Text = "Buscar cuenta"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TextBox4.Location = New System.Drawing.Point(200, 166)
        Me.TextBox4.MaxLength = 49
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(210, 26)
        Me.TextBox4.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(20, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 18)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Ultimo periodo pagado:"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TextBox3.Location = New System.Drawing.Point(152, 131)
        Me.TextBox3.MaxLength = 49
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(258, 26)
        Me.TextBox3.TabIndex = 64
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TextBox2.Location = New System.Drawing.Point(152, 93)
        Me.TextBox2.MaxLength = 49
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(258, 26)
        Me.TextBox2.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 22)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Domicilio:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(152, 58)
        Me.TextBox1.MaxLength = 49
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(258, 26)
        Me.TextBox1.TabIndex = 64
        '
        'txtExistencia
        '
        Me.txtExistencia.Enabled = False
        Me.txtExistencia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtExistencia.Location = New System.Drawing.Point(152, 22)
        Me.txtExistencia.MaxLength = 49
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.ReadOnly = True
        Me.txtExistencia.Size = New System.Drawing.Size(155, 26)
        Me.txtExistencia.TabIndex = 61
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
        'Button1
        '
        Me.Button1.Image = Global.PSAP.My.Resources.Resources._return
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(16, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(422, 35)
        Me.Button1.TabIndex = 141
        Me.Button1.Text = "Cargar pago de agua"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.PSAP.My.Resources.Resources._return
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(16, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(422, 35)
        Me.Button2.TabIndex = 142
        Me.Button2.Text = "Cargar pago de servicio"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 486)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gboxCuenta)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidPago)
        Me.Controls.Add(Me.lblIDMaterial)
        Me.Name = "frmPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pago de Agua y de Servicios"
        Me.gboxCuenta.ResumeLayout(False)
        Me.gboxCuenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtidPago As System.Windows.Forms.TextBox
    Friend WithEvents lblIDMaterial As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gboxCuenta As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtExistencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
