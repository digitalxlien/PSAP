<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarPagoAgua
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
        Me.cboxSituacion = New System.Windows.Forms.ComboBox()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.txtidCuenta = New System.Windows.Forms.TextBox()
        Me.lblidEmpleado = New System.Windows.Forms.Label()
        Me.cboxTarifa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxMesInicial = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxMesFinal = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboxSituacion
        '
        Me.cboxSituacion.DisplayMember = "nombre"
        Me.cboxSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSituacion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboxSituacion.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxSituacion.FormattingEnabled = True
        Me.cboxSituacion.Location = New System.Drawing.Point(119, 13)
        Me.cboxSituacion.Name = "cboxSituacion"
        Me.cboxSituacion.Size = New System.Drawing.Size(230, 26)
        Me.cboxSituacion.TabIndex = 58
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.Location = New System.Drawing.Point(22, 13)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(92, 22)
        Me.lblCalle.TabIndex = 59
        Me.lblCalle.Text = "Situación:"
        '
        'txtidCuenta
        '
        Me.txtidCuenta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidCuenta.Location = New System.Drawing.Point(487, 12)
        Me.txtidCuenta.Name = "txtidCuenta"
        Me.txtidCuenta.ReadOnly = True
        Me.txtidCuenta.Size = New System.Drawing.Size(162, 26)
        Me.txtidCuenta.TabIndex = 61
        '
        'lblidEmpleado
        '
        Me.lblidEmpleado.AutoSize = True
        Me.lblidEmpleado.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidEmpleado.Location = New System.Drawing.Point(374, 13)
        Me.lblidEmpleado.Name = "lblidEmpleado"
        Me.lblidEmpleado.Size = New System.Drawing.Size(107, 22)
        Me.lblidEmpleado.TabIndex = 60
        Me.lblidEmpleado.Text = "Descuento:"
        '
        'cboxTarifa
        '
        Me.cboxTarifa.DisplayMember = "nombre"
        Me.cboxTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTarifa.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboxTarifa.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxTarifa.FormattingEnabled = True
        Me.cboxTarifa.Location = New System.Drawing.Point(120, 80)
        Me.cboxTarifa.Name = "cboxTarifa"
        Me.cboxTarifa.Size = New System.Drawing.Size(230, 26)
        Me.cboxTarifa.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 22)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Año:"
        '
        'cboxMesInicial
        '
        Me.cboxMesInicial.DisplayMember = "nombre"
        Me.cboxMesInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxMesInicial.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboxMesInicial.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxMesInicial.FormattingEnabled = True
        Me.cboxMesInicial.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboxMesInicial.Location = New System.Drawing.Point(120, 119)
        Me.cboxMesInicial.Name = "cboxMesInicial"
        Me.cboxMesInicial.Size = New System.Drawing.Size(230, 26)
        Me.cboxMesInicial.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 22)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Mes inicial:"
        '
        'cboxMesFinal
        '
        Me.cboxMesFinal.DisplayMember = "nombre"
        Me.cboxMesFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxMesFinal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboxMesFinal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxMesFinal.FormattingEnabled = True
        Me.cboxMesFinal.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboxMesFinal.Location = New System.Drawing.Point(120, 155)
        Me.cboxMesFinal.Name = "cboxMesFinal"
        Me.cboxMesFinal.Size = New System.Drawing.Size(230, 26)
        Me.cboxMesFinal.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 22)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Mes final:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(125, 313)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(162, 26)
        Me.TextBox1.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 22)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Cuota Fija:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(464, 317)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(162, 26)
        Me.TextBox2.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(360, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 22)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Recargos:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(125, 346)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(162, 26)
        Me.TextBox3.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 22)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "T.A.R.:"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(464, 346)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(162, 26)
        Me.TextBox4.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(322, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 22)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Infraestructura:"
        '
        'frmCargarPagoAgua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 488)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboxMesFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboxMesInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboxTarifa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidCuenta)
        Me.Controls.Add(Me.lblidEmpleado)
        Me.Controls.Add(Me.cboxSituacion)
        Me.Controls.Add(Me.lblCalle)
        Me.Name = "frmCargarPagoAgua"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Pago de Agua"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboxSituacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents txtidCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lblidEmpleado As System.Windows.Forms.Label
    Friend WithEvents cboxTarifa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboxMesInicial As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboxMesFinal As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
