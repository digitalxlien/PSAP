<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifas
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
        Me.lblRecargos = New System.Windows.Forms.Label()
        Me.lblCoutaFija = New System.Windows.Forms.Label()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.txtidTarifa = New System.Windows.Forms.TextBox()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.lblidCalle = New System.Windows.Forms.Label()
        Me.dgTarifas = New System.Windows.Forms.DataGridView()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.lblTar = New System.Windows.Forms.Label()
        Me.lblInfra = New System.Windows.Forms.Label()
        Me.txtInfra = New System.Windows.Forms.NumericUpDown()
        Me.txtAnio = New System.Windows.Forms.NumericUpDown()
        Me.txtRecargos = New System.Windows.Forms.NumericUpDown()
        Me.txtCuotaFija = New System.Windows.Forms.NumericUpDown()
        Me.txtTar = New System.Windows.Forms.NumericUpDown()
        Me.DataSetPSAP = New PSAP.DataSetPSAP()
        Me.TarifaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TarifaTableAdapter = New PSAP.DataSetPSAPTableAdapters.TarifaTableAdapter()
        Me.IdTarifaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuotafijaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecargosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInfra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuotaFija, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarifaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRecargos
        '
        Me.lblRecargos.AutoSize = True
        Me.lblRecargos.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecargos.Location = New System.Drawing.Point(345, 127)
        Me.lblRecargos.Name = "lblRecargos"
        Me.lblRecargos.Size = New System.Drawing.Size(98, 22)
        Me.lblRecargos.TabIndex = 41
        Me.lblRecargos.Text = "Recargos:"
        '
        'lblCoutaFija
        '
        Me.lblCoutaFija.AutoSize = True
        Me.lblCoutaFija.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoutaFija.Location = New System.Drawing.Point(16, 129)
        Me.lblCoutaFija.Name = "lblCoutaFija"
        Me.lblCoutaFija.Size = New System.Drawing.Size(94, 22)
        Me.lblCoutaFija.TabIndex = 40
        Me.lblCoutaFija.Text = "Couta fija:"
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(263, 232)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 9
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(182, 232)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 8
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(101, 232)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 7
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(20, 232)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 6
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'txtidTarifa
        '
        Me.txtidTarifa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidTarifa.Location = New System.Drawing.Point(146, 16)
        Me.txtidTarifa.Name = "txtidTarifa"
        Me.txtidTarifa.ReadOnly = True
        Me.txtidTarifa.Size = New System.Drawing.Size(111, 26)
        Me.txtidTarifa.TabIndex = 39
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.Location = New System.Drawing.Point(16, 77)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(49, 22)
        Me.lblAnio.TabIndex = 38
        Me.lblAnio.Text = "Año:"
        '
        'lblidCalle
        '
        Me.lblidCalle.AutoSize = True
        Me.lblidCalle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidCalle.Location = New System.Drawing.Point(16, 16)
        Me.lblidCalle.Name = "lblidCalle"
        Me.lblidCalle.Size = New System.Drawing.Size(113, 22)
        Me.lblidCalle.TabIndex = 37
        Me.lblidCalle.Text = "ID de Tarifa:"
        '
        'dgTarifas
        '
        Me.dgTarifas.AllowUserToAddRows = False
        Me.dgTarifas.AllowUserToDeleteRows = False
        Me.dgTarifas.AutoGenerateColumns = False
        Me.dgTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTarifas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTarifaDataGridViewTextBoxColumn, Me.AnioDataGridViewTextBoxColumn, Me.CuotafijaDataGridViewTextBoxColumn, Me.RecargosDataGridViewTextBoxColumn, Me.TarDataGridViewTextBoxColumn, Me.InfraDataGridViewTextBoxColumn})
        Me.dgTarifas.DataSource = Me.TarifaBindingSource
        Me.dgTarifas.Location = New System.Drawing.Point(18, 271)
        Me.dgTarifas.Name = "dgTarifas"
        Me.dgTarifas.ReadOnly = True
        Me.dgTarifas.Size = New System.Drawing.Size(640, 226)
        Me.dgTarifas.TabIndex = 36
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(538, 510)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 12
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(412, 510)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 11
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(286, 510)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 10
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'lblTar
        '
        Me.lblTar.AutoSize = True
        Me.lblTar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTar.Location = New System.Drawing.Point(16, 181)
        Me.lblTar.Name = "lblTar"
        Me.lblTar.Size = New System.Drawing.Size(67, 22)
        Me.lblTar.TabIndex = 42
        Me.lblTar.Text = "T.A.R.:"
        '
        'lblInfra
        '
        Me.lblInfra.AutoSize = True
        Me.lblInfra.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfra.Location = New System.Drawing.Point(345, 181)
        Me.lblInfra.Name = "lblInfra"
        Me.lblInfra.Size = New System.Drawing.Size(136, 22)
        Me.lblInfra.TabIndex = 43
        Me.lblInfra.Text = "Infraestructura:"
        '
        'txtInfra
        '
        Me.txtInfra.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TarifaBindingSource, "infra", True))
        Me.txtInfra.DecimalPlaces = 2
        Me.txtInfra.Enabled = False
        Me.txtInfra.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtInfra.Location = New System.Drawing.Point(487, 182)
        Me.txtInfra.Maximum = New Decimal(New Integer() {32000, 0, 0, 0})
        Me.txtInfra.Name = "txtInfra"
        Me.txtInfra.Size = New System.Drawing.Size(120, 26)
        Me.txtInfra.TabIndex = 5
        '
        'txtAnio
        '
        Me.txtAnio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TarifaBindingSource, "anio", True))
        Me.txtAnio.Enabled = False
        Me.txtAnio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtAnio.Location = New System.Drawing.Point(115, 78)
        Me.txtAnio.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.txtAnio.Minimum = New Decimal(New Integer() {1950, 0, 0, 0})
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(120, 26)
        Me.txtAnio.TabIndex = 1
        Me.txtAnio.Value = New Decimal(New Integer() {1950, 0, 0, 0})
        '
        'txtRecargos
        '
        Me.txtRecargos.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TarifaBindingSource, "recargos", True))
        Me.txtRecargos.DecimalPlaces = 2
        Me.txtRecargos.Enabled = False
        Me.txtRecargos.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRecargos.Location = New System.Drawing.Point(487, 129)
        Me.txtRecargos.Maximum = New Decimal(New Integer() {32000, 0, 0, 0})
        Me.txtRecargos.Name = "txtRecargos"
        Me.txtRecargos.Size = New System.Drawing.Size(120, 26)
        Me.txtRecargos.TabIndex = 3
        '
        'txtCuotaFija
        '
        Me.txtCuotaFija.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TarifaBindingSource, "cuotafija", True))
        Me.txtCuotaFija.DecimalPlaces = 2
        Me.txtCuotaFija.Enabled = False
        Me.txtCuotaFija.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCuotaFija.Location = New System.Drawing.Point(115, 130)
        Me.txtCuotaFija.Maximum = New Decimal(New Integer() {32000, 0, 0, 0})
        Me.txtCuotaFija.Name = "txtCuotaFija"
        Me.txtCuotaFija.Size = New System.Drawing.Size(120, 26)
        Me.txtCuotaFija.TabIndex = 2
        '
        'txtTar
        '
        Me.txtTar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TarifaBindingSource, "tar", True))
        Me.txtTar.DecimalPlaces = 2
        Me.txtTar.Enabled = False
        Me.txtTar.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTar.Location = New System.Drawing.Point(115, 182)
        Me.txtTar.Maximum = New Decimal(New Integer() {32000, 0, 0, 0})
        Me.txtTar.Name = "txtTar"
        Me.txtTar.Size = New System.Drawing.Size(120, 26)
        Me.txtTar.TabIndex = 4
        '
        'DataSetPSAP
        '
        Me.DataSetPSAP.DataSetName = "DataSetPSAP"
        Me.DataSetPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TarifaBindingSource
        '
        Me.TarifaBindingSource.DataMember = "Tarifa"
        Me.TarifaBindingSource.DataSource = Me.DataSetPSAP
        '
        'TarifaTableAdapter
        '
        Me.TarifaTableAdapter.ClearBeforeFill = True
        '
        'IdTarifaDataGridViewTextBoxColumn
        '
        Me.IdTarifaDataGridViewTextBoxColumn.DataPropertyName = "idTarifa"
        Me.IdTarifaDataGridViewTextBoxColumn.HeaderText = "idTarifa"
        Me.IdTarifaDataGridViewTextBoxColumn.Name = "IdTarifaDataGridViewTextBoxColumn"
        Me.IdTarifaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnioDataGridViewTextBoxColumn
        '
        Me.AnioDataGridViewTextBoxColumn.DataPropertyName = "anio"
        Me.AnioDataGridViewTextBoxColumn.HeaderText = "anio"
        Me.AnioDataGridViewTextBoxColumn.Name = "AnioDataGridViewTextBoxColumn"
        Me.AnioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuotafijaDataGridViewTextBoxColumn
        '
        Me.CuotafijaDataGridViewTextBoxColumn.DataPropertyName = "cuotafija"
        Me.CuotafijaDataGridViewTextBoxColumn.HeaderText = "cuotafija"
        Me.CuotafijaDataGridViewTextBoxColumn.Name = "CuotafijaDataGridViewTextBoxColumn"
        Me.CuotafijaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecargosDataGridViewTextBoxColumn
        '
        Me.RecargosDataGridViewTextBoxColumn.DataPropertyName = "recargos"
        Me.RecargosDataGridViewTextBoxColumn.HeaderText = "recargos"
        Me.RecargosDataGridViewTextBoxColumn.Name = "RecargosDataGridViewTextBoxColumn"
        Me.RecargosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TarDataGridViewTextBoxColumn
        '
        Me.TarDataGridViewTextBoxColumn.DataPropertyName = "tar"
        Me.TarDataGridViewTextBoxColumn.HeaderText = "tar"
        Me.TarDataGridViewTextBoxColumn.Name = "TarDataGridViewTextBoxColumn"
        Me.TarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InfraDataGridViewTextBoxColumn
        '
        Me.InfraDataGridViewTextBoxColumn.DataPropertyName = "infra"
        Me.InfraDataGridViewTextBoxColumn.HeaderText = "infra"
        Me.InfraDataGridViewTextBoxColumn.Name = "InfraDataGridViewTextBoxColumn"
        Me.InfraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 557)
        Me.Controls.Add(Me.txtTar)
        Me.Controls.Add(Me.txtCuotaFija)
        Me.Controls.Add(Me.txtRecargos)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.txtInfra)
        Me.Controls.Add(Me.lblInfra)
        Me.Controls.Add(Me.lblTar)
        Me.Controls.Add(Me.lblRecargos)
        Me.Controls.Add(Me.lblCoutaFija)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.txtidTarifa)
        Me.Controls.Add(Me.lblAnio)
        Me.Controls.Add(Me.lblidCalle)
        Me.Controls.Add(Me.dgTarifas)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Name = "frmTarifas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas"
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInfra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuotaFija, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarifaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRecargos As System.Windows.Forms.Label
    Friend WithEvents lblCoutaFija As System.Windows.Forms.Label
    Friend WithEvents cmdUltimo As System.Windows.Forms.Button
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents cmdInicio As System.Windows.Forms.Button
    Friend WithEvents txtidTarifa As System.Windows.Forms.TextBox
    Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents lblidCalle As System.Windows.Forms.Label
    Friend WithEvents dgTarifas As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents lblTar As System.Windows.Forms.Label
    Friend WithEvents lblInfra As System.Windows.Forms.Label
    Friend WithEvents txtInfra As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtAnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtRecargos As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCuotaFija As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTar As System.Windows.Forms.NumericUpDown
    Friend WithEvents DataSetPSAP As PSAP.DataSetPSAP
    Friend WithEvents TarifaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TarifaTableAdapter As PSAP.DataSetPSAPTableAdapters.TarifaTableAdapter
    Friend WithEvents IdTarifaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuotafijaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecargosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InfraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
