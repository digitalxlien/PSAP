<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPozos
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.txtidPozo = New System.Windows.Forms.TextBox()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblidPozo = New System.Windows.Forms.Label()
        Me.dgPozos = New System.Windows.Forms.DataGridView()
        Me.IdPozoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PozoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPSAP = New PSAP.DataSeTPSAP()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.PozoTableAdapter = New PSAP.DataSeTPSAPTableAdapters.PozoTableAdapter()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.dgPozos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PozoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(253, 107)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 23
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(172, 107)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 22
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(91, 107)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 21
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(10, 107)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 20
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Enabled = False
        Me.txtUbicacion.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtUbicacion.Location = New System.Drawing.Point(144, 49)
        Me.txtUbicacion.MaxLength = 49
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(330, 26)
        Me.txtUbicacion.TabIndex = 19
        '
        'txtidPozo
        '
        Me.txtidPozo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidPozo.Location = New System.Drawing.Point(144, 5)
        Me.txtidPozo.Name = "txtidPozo"
        Me.txtidPozo.ReadOnly = True
        Me.txtidPozo.Size = New System.Drawing.Size(103, 26)
        Me.txtidPozo.TabIndex = 18
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.Location = New System.Drawing.Point(12, 49)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(98, 22)
        Me.lblUbicacion.TabIndex = 17
        Me.lblUbicacion.Text = "Ubicación:"
        '
        'lblidPozo
        '
        Me.lblidPozo.AutoSize = True
        Me.lblidPozo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidPozo.Location = New System.Drawing.Point(12, 9)
        Me.lblidPozo.Name = "lblidPozo"
        Me.lblidPozo.Size = New System.Drawing.Size(111, 22)
        Me.lblidPozo.TabIndex = 16
        Me.lblidPozo.Text = "ID de Pozo:"
        '
        'dgPozos
        '
        Me.dgPozos.AllowUserToAddRows = False
        Me.dgPozos.AllowUserToDeleteRows = False
        Me.dgPozos.AutoGenerateColumns = False
        Me.dgPozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPozos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPozoDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn})
        Me.dgPozos.DataSource = Me.PozoBindingSource
        Me.dgPozos.Location = New System.Drawing.Point(10, 136)
        Me.dgPozos.Name = "dgPozos"
        Me.dgPozos.ReadOnly = True
        Me.dgPozos.Size = New System.Drawing.Size(594, 206)
        Me.dgPozos.TabIndex = 15
        '
        'IdPozoDataGridViewTextBoxColumn
        '
        Me.IdPozoDataGridViewTextBoxColumn.DataPropertyName = "idPozo"
        Me.IdPozoDataGridViewTextBoxColumn.HeaderText = "ID de Pozo"
        Me.IdPozoDataGridViewTextBoxColumn.Name = "IdPozoDataGridViewTextBoxColumn"
        Me.IdPozoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPozoDataGridViewTextBoxColumn.Width = 220
        '
        'UbicacionDataGridViewTextBoxColumn
        '
        Me.UbicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.HeaderText = "Ubicación"
        Me.UbicacionDataGridViewTextBoxColumn.Name = "UbicacionDataGridViewTextBoxColumn"
        Me.UbicacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.UbicacionDataGridViewTextBoxColumn.Width = 300
        '
        'PozoBindingSource
        '
        Me.PozoBindingSource.DataMember = "Pozo"
        Me.PozoBindingSource.DataSource = Me.DataSetPSAP
        '
        'DataSetPSAP
        '
        Me.DataSetPSAP.DataSetName = "DataSetPSAP"
        Me.DataSetPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(484, 348)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 14
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(358, 348)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 13
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(106, 348)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 12
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'PozoTableAdapter
        '
        Me.PozoTableAdapter.ClearBeforeFill = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.PSAP.My.Resources.Resources.cancel
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(232, 348)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(120, 35)
        Me.cmdCancelar.TabIndex = 51
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmPozos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(611, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.txtidPozo)
        Me.Controls.Add(Me.lblUbicacion)
        Me.Controls.Add(Me.lblidPozo)
        Me.Controls.Add(Me.dgPozos)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Name = "frmPozos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pozos"
        CType(Me.dgPozos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PozoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdUltimo As System.Windows.Forms.Button
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents cmdInicio As System.Windows.Forms.Button
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents txtidPozo As System.Windows.Forms.TextBox
    Friend WithEvents lblUbicacion As System.Windows.Forms.Label
    Friend WithEvents lblidPozo As System.Windows.Forms.Label
    Friend WithEvents dgPozos As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents DataSetPSAP As PSAP.DataSetPSAP
    Friend WithEvents PozoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PozoTableAdapter As PSAP.DataSetPSAPTableAdapters.PozoTableAdapter
    Friend WithEvents IdPozoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
