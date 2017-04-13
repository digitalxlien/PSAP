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
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.lblidEmpleado = New System.Windows.Forms.Label()
        Me.cboxTarifa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxMesInicial = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxMesFinal = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuotaFija = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRecargos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInfra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
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
        Me.lblCalle.Location = New System.Drawing.Point(12, 13)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(92, 22)
        Me.lblCalle.TabIndex = 59
        Me.lblCalle.Text = "Situación:"
        '
        'txtDescuento
        '
        Me.txtDescuento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(521, 12)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(140, 26)
        Me.txtDescuento.TabIndex = 61
        '
        'lblidEmpleado
        '
        Me.lblidEmpleado.AutoSize = True
        Me.lblidEmpleado.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidEmpleado.Location = New System.Drawing.Point(374, 13)
        Me.lblidEmpleado.Name = "lblidEmpleado"
        Me.lblidEmpleado.Size = New System.Drawing.Size(141, 22)
        Me.lblidEmpleado.TabIndex = 60
        Me.lblidEmpleado.Text = "Descuento (%):"
        '
        'cboxTarifa
        '
        Me.cboxTarifa.DisplayMember = "nombre"
        Me.cboxTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTarifa.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboxTarifa.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxTarifa.FormattingEnabled = True
        Me.cboxTarifa.Location = New System.Drawing.Point(120, 67)
        Me.cboxTarifa.Name = "cboxTarifa"
        Me.cboxTarifa.Size = New System.Drawing.Size(230, 26)
        Me.cboxTarifa.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 71)
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
        Me.cboxMesInicial.Location = New System.Drawing.Point(120, 106)
        Me.cboxMesInicial.Name = "cboxMesInicial"
        Me.cboxMesInicial.Size = New System.Drawing.Size(230, 26)
        Me.cboxMesInicial.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 106)
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
        Me.cboxMesFinal.Location = New System.Drawing.Point(120, 142)
        Me.cboxMesFinal.Name = "cboxMesFinal"
        Me.cboxMesFinal.Size = New System.Drawing.Size(230, 26)
        Me.cboxMesFinal.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 22)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Mes final:"
        '
        'txtCuotaFija
        '
        Me.txtCuotaFija.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotaFija.Location = New System.Drawing.Point(125, 212)
        Me.txtCuotaFija.Name = "txtCuotaFija"
        Me.txtCuotaFija.ReadOnly = True
        Me.txtCuotaFija.Size = New System.Drawing.Size(162, 26)
        Me.txtCuotaFija.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 22)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Cuota Fija:"
        '
        'txtRecargos
        '
        Me.txtRecargos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecargos.Location = New System.Drawing.Point(487, 216)
        Me.txtRecargos.Name = "txtRecargos"
        Me.txtRecargos.ReadOnly = True
        Me.txtRecargos.Size = New System.Drawing.Size(174, 26)
        Me.txtRecargos.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(383, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 22)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Recargos:"
        '
        'txtTar
        '
        Me.txtTar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTar.Location = New System.Drawing.Point(125, 245)
        Me.txtTar.Name = "txtTar"
        Me.txtTar.ReadOnly = True
        Me.txtTar.Size = New System.Drawing.Size(162, 26)
        Me.txtTar.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 22)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "T.A.R.:"
        '
        'txtInfra
        '
        Me.txtInfra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfra.Location = New System.Drawing.Point(487, 245)
        Me.txtInfra.Name = "txtInfra"
        Me.txtInfra.ReadOnly = True
        Me.txtInfra.Size = New System.Drawing.Size(174, 26)
        Me.txtInfra.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(345, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 22)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Infraestructura:"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(543, 302)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 77
        Me.cmdSalir.Text = "Regresar"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(417, 302)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 76
        Me.cmdNuevo.Text = "Aceptar"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'frmCargarPagoAgua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 349)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.txtInfra)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRecargos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCuotaFija)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboxMesFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboxMesInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboxTarifa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescuento)
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
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents lblidEmpleado As System.Windows.Forms.Label
    Friend WithEvents cboxTarifa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboxMesInicial As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboxMesFinal As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCuotaFija As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRecargos As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTar As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtInfra As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
End Class
