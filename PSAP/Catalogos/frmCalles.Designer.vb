<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalles))
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.CalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPSAP = New PSAP.DataSeTPSAP()
        Me.txtidCalle = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblidCalle = New System.Windows.Forms.Label()
        Me.dgCalle = New System.Windows.Forms.DataGridView()
        Me.IdCalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCasasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.CalleTableAdapter = New PSAP.DataSeTPSAPTableAdapters.CalleTableAdapter()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        CType(Me.CalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(255, 176)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 7
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(174, 176)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 6
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(93, 176)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 5
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(12, 176)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 4
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'txtCalle
        '
        Me.txtCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalleBindingSource, "nombre", True))
        Me.txtCalle.Enabled = False
        Me.txtCalle.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCalle.Location = New System.Drawing.Point(151, 44)
        Me.txtCalle.MaxLength = 49
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(330, 26)
        Me.txtCalle.TabIndex = 1
        '
        'CalleBindingSource
        '
        Me.CalleBindingSource.DataMember = "Calle"
        Me.CalleBindingSource.DataSource = Me.DataSetPSAP
        '
        'DataSetPSAP
        '
        Me.DataSetPSAP.DataSetName = "DataSetPSAP"
        Me.DataSetPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtidCalle
        '
        Me.txtidCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalleBindingSource, "idCalle", True))
        Me.txtidCalle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidCalle.Location = New System.Drawing.Point(151, 5)
        Me.txtidCalle.Name = "txtidCalle"
        Me.txtidCalle.ReadOnly = True
        Me.txtidCalle.Size = New System.Drawing.Size(111, 26)
        Me.txtidCalle.TabIndex = 18
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(12, 48)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(83, 22)
        Me.lblNombre.TabIndex = 17
        Me.lblNombre.Text = "Nombre:"
        '
        'lblidCalle
        '
        Me.lblidCalle.AutoSize = True
        Me.lblidCalle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidCalle.Location = New System.Drawing.Point(12, 9)
        Me.lblidCalle.Name = "lblidCalle"
        Me.lblidCalle.Size = New System.Drawing.Size(110, 22)
        Me.lblidCalle.TabIndex = 16
        Me.lblidCalle.Text = "ID de Calle:"
        '
        'dgCalle
        '
        Me.dgCalle.AllowUserToAddRows = False
        Me.dgCalle.AllowUserToDeleteRows = False
        Me.dgCalle.AutoGenerateColumns = False
        Me.dgCalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCalleDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.CodigoPostalDataGridViewTextBoxColumn, Me.TotalCasasDataGridViewTextBoxColumn})
        Me.dgCalle.DataSource = Me.CalleBindingSource
        Me.dgCalle.Location = New System.Drawing.Point(10, 205)
        Me.dgCalle.Name = "dgCalle"
        Me.dgCalle.ReadOnly = True
        Me.dgCalle.Size = New System.Drawing.Size(720, 245)
        Me.dgCalle.TabIndex = 15
        '
        'IdCalleDataGridViewTextBoxColumn
        '
        Me.IdCalleDataGridViewTextBoxColumn.DataPropertyName = "idCalle"
        Me.IdCalleDataGridViewTextBoxColumn.HeaderText = "ID de Calle"
        Me.IdCalleDataGridViewTextBoxColumn.Name = "IdCalleDataGridViewTextBoxColumn"
        Me.IdCalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 250
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoPostalDataGridViewTextBoxColumn
        '
        Me.CodigoPostalDataGridViewTextBoxColumn.DataPropertyName = "codigoPostal"
        Me.CodigoPostalDataGridViewTextBoxColumn.HeaderText = "Código Postal"
        Me.CodigoPostalDataGridViewTextBoxColumn.Name = "CodigoPostalDataGridViewTextBoxColumn"
        Me.CodigoPostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalCasasDataGridViewTextBoxColumn
        '
        Me.TotalCasasDataGridViewTextBoxColumn.DataPropertyName = "totalCasas"
        Me.TotalCasasDataGridViewTextBoxColumn.HeaderText = "Total de casas"
        Me.TotalCasasDataGridViewTextBoxColumn.Name = "TotalCasasDataGridViewTextBoxColumn"
        Me.TotalCasasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(611, 456)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 10
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'CalleTableAdapter
        '
        Me.CalleTableAdapter.ClearBeforeFill = True
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColonia.Location = New System.Drawing.Point(12, 87)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(79, 22)
        Me.lblColonia.TabIndex = 24
        Me.lblColonia.Text = "Colonia:"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoPostal.Location = New System.Drawing.Point(12, 126)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(133, 22)
        Me.lblCodigoPostal.TabIndex = 25
        Me.lblCodigoPostal.Text = "Código postal:"
        '
        'txtColonia
        '
        Me.txtColonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalleBindingSource, "colonia", True))
        Me.txtColonia.Enabled = False
        Me.txtColonia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtColonia.Location = New System.Drawing.Point(151, 83)
        Me.txtColonia.MaxLength = 49
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(330, 26)
        Me.txtColonia.TabIndex = 2
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalleBindingSource, "codigoPostal", True))
        Me.txtCodigoPostal.Enabled = False
        Me.txtCodigoPostal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCodigoPostal.Location = New System.Drawing.Point(151, 122)
        Me.txtCodigoPostal.MaxLength = 49
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(125, 26)
        Me.txtCodigoPostal.TabIndex = 3
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.PSAP.My.Resources.Resources.cancel
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(359, 456)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(120, 35)
        Me.cmdCancelar.TabIndex = 26
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(485, 456)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 9
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(233, 456)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 8
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'frmCalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(737, 497)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.txtCodigoPostal)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.lblCodigoPostal)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtidCalle)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblidCalle)
        Me.Controls.Add(Me.dgCalle)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCalles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calles"
        CType(Me.CalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdUltimo As System.Windows.Forms.Button
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents cmdInicio As System.Windows.Forms.Button
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtidCalle As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblidCalle As System.Windows.Forms.Label
    Friend WithEvents dgCalle As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents DataSetPSAP As PSAP.DataSetPSAP
    Friend WithEvents CalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalleTableAdapter As PSAP.DataSetPSAPTableAdapters.CalleTableAdapter
    Friend WithEvents IdCalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoPostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCasasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblColonia As System.Windows.Forms.Label
    Friend WithEvents lblCodigoPostal As System.Windows.Forms.Label
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
