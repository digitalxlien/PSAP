<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionarCalle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxCalle = New System.Windows.Forms.ComboBox()
        Me.cmdGenerarReporte = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 22)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Seleccione una calle:"
        '
        'cboxCalle
        '
        Me.cboxCalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCalle.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboxCalle.FormattingEnabled = True
        Me.cboxCalle.Location = New System.Drawing.Point(12, 34)
        Me.cboxCalle.Name = "cboxCalle"
        Me.cboxCalle.Size = New System.Drawing.Size(488, 26)
        Me.cboxCalle.TabIndex = 142
        '
        'cmdGenerarReporte
        '
        Me.cmdGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGenerarReporte.Location = New System.Drawing.Point(196, 73)
        Me.cmdGenerarReporte.Name = "cmdGenerarReporte"
        Me.cmdGenerarReporte.Size = New System.Drawing.Size(178, 35)
        Me.cmdGenerarReporte.TabIndex = 143
        Me.cmdGenerarReporte.Text = "Generar reporte"
        Me.cmdGenerarReporte.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(380, 73)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(120, 35)
        Me.cmdCancelar.TabIndex = 144
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmSeleccionarCalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 120)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGenerarReporte)
        Me.Controls.Add(Me.cboxCalle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSeleccionarCalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Calles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboxCalle As System.Windows.Forms.ComboBox
    Friend WithEvents cmdGenerarReporte As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
