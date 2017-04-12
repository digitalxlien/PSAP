<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGastos))
        Me.dgGastos = New System.Windows.Forms.DataGridView()
        Me.IdGastoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPSAP = New PSAP.DataSeTPSAP()
        Me.lblidGasto = New System.Windows.Forms.Label()
        Me.lblGasto = New System.Windows.Forms.Label()
        Me.txtidGasto = New System.Windows.Forms.TextBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.GastoTableAdapter = New PSAP.DataSeTPSAPTableAdapters.GastoTableAdapter()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        CType(Me.dgGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgGastos
        '
        Me.dgGastos.AllowUserToAddRows = False
        Me.dgGastos.AllowUserToDeleteRows = False
        Me.dgGastos.AutoGenerateColumns = False
        Me.dgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdGastoDataGridViewTextBoxColumn, Me.ConceptoDataGridViewTextBoxColumn})
        Me.dgGastos.DataSource = Me.GastoBindingSource
        Me.dgGastos.Location = New System.Drawing.Point(12, 123)
        Me.dgGastos.Name = "dgGastos"
        Me.dgGastos.ReadOnly = True
        Me.dgGastos.Size = New System.Drawing.Size(498, 245)
        Me.dgGastos.TabIndex = 3
        '
        'IdGastoDataGridViewTextBoxColumn
        '
        Me.IdGastoDataGridViewTextBoxColumn.DataPropertyName = "idGasto"
        Me.IdGastoDataGridViewTextBoxColumn.HeaderText = "ID de Gasto"
        Me.IdGastoDataGridViewTextBoxColumn.Name = "IdGastoDataGridViewTextBoxColumn"
        Me.IdGastoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConceptoDataGridViewTextBoxColumn
        '
        Me.ConceptoDataGridViewTextBoxColumn.DataPropertyName = "concepto"
        Me.ConceptoDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.Name = "ConceptoDataGridViewTextBoxColumn"
        Me.ConceptoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConceptoDataGridViewTextBoxColumn.Width = 320
        '
        'GastoBindingSource
        '
        Me.GastoBindingSource.DataMember = "Gasto"
        Me.GastoBindingSource.DataSource = Me.DataSetPSAP
        '
        'DataSetPSAP
        '
        Me.DataSetPSAP.DataSetName = "DataSetPSAP"
        Me.DataSetPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblidGasto
        '
        Me.lblidGasto.AutoSize = True
        Me.lblidGasto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidGasto.Location = New System.Drawing.Point(12, 18)
        Me.lblidGasto.Name = "lblidGasto"
        Me.lblidGasto.Size = New System.Drawing.Size(118, 22)
        Me.lblidGasto.TabIndex = 4
        Me.lblidGasto.Text = "ID de Gasto:"
        '
        'lblGasto
        '
        Me.lblGasto.AutoSize = True
        Me.lblGasto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGasto.Location = New System.Drawing.Point(12, 50)
        Me.lblGasto.Name = "lblGasto"
        Me.lblGasto.Size = New System.Drawing.Size(98, 22)
        Me.lblGasto.TabIndex = 5
        Me.lblGasto.Text = "Concepto:"
        '
        'txtidGasto
        '
        Me.txtidGasto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "idGasto", True))
        Me.txtidGasto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidGasto.Location = New System.Drawing.Point(146, 18)
        Me.txtidGasto.Name = "txtidGasto"
        Me.txtidGasto.ReadOnly = True
        Me.txtidGasto.Size = New System.Drawing.Size(103, 26)
        Me.txtidGasto.TabIndex = 6
        '
        'txtConcepto
        '
        Me.txtConcepto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "concepto", True))
        Me.txtConcepto.Enabled = False
        Me.txtConcepto.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtConcepto.Location = New System.Drawing.Point(146, 50)
        Me.txtConcepto.MaxLength = 49
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(330, 26)
        Me.txtConcepto.TabIndex = 7
        '
        'GastoTableAdapter
        '
        Me.GastoTableAdapter.ClearBeforeFill = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(12, 94)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 8
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSiguiente.Location = New System.Drawing.Point(93, 94)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 9
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(174, 94)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 10
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(255, 94)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 11
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.PSAP.My.Resources.Resources.cancel
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(138, 374)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(120, 35)
        Me.cmdCancelar.TabIndex = 27
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Image = Global.PSAP.My.Resources.Resources._return
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(390, 374)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 35)
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.PSAP.My.Resources.Resources.save
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(264, 374)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 35)
        Me.cmdGrabar.TabIndex = 1
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.PSAP.My.Resources.Resources.add
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 374)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 35)
        Me.cmdNuevo.TabIndex = 0
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'frmGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(520, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtidGasto)
        Me.Controls.Add(Me.lblGasto)
        Me.Controls.Add(Me.lblidGasto)
        Me.Controls.Add(Me.dgGastos)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gastos"
        CType(Me.dgGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPSAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents dgGastos As System.Windows.Forms.DataGridView
    Friend WithEvents lblidGasto As System.Windows.Forms.Label
    Friend WithEvents lblGasto As System.Windows.Forms.Label
    Friend WithEvents txtidGasto As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents DataSetPSAP As PSAP.DataSetPSAP
    Friend WithEvents GastoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GastoTableAdapter As PSAP.DataSetPSAPTableAdapters.GastoTableAdapter
    Friend WithEvents cmdInicio As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cmdUltimo As System.Windows.Forms.Button
    Friend WithEvents IdGastoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button

End Class
