<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoFamilias
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoFamilias))
        Me.lblCode = New MetroFramework.Controls.MetroLabel()
        Me.lblDescription = New MetroFramework.Controls.MetroLabel()
        Me.txtCode = New MetroFramework.Controls.MetroTextBox()
        Me.txtDescription = New MetroFramework.Controls.MetroTextBox()
        Me.gbFamilia = New System.Windows.Forms.GroupBox()
        Me.lblBuscar = New MetroFramework.Controls.MetroLabel()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.dgFamilias = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.btnRemove = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.FamiliaTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.FamiliaTableAdapter()
        Me.gbFamilia.SuspendLayout()
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(28, 40)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(53, 19)
        Me.lblCode.TabIndex = 0
        Me.lblCode.Text = "Código"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(28, 87)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(76, 19)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Descripción"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(142, 40)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(205, 23)
        Me.txtCode.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(142, 87)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(541, 23)
        Me.txtDescription.TabIndex = 3
        '
        'gbFamilia
        '
        Me.gbFamilia.Controls.Add(Me.lblCode)
        Me.gbFamilia.Controls.Add(Me.txtCode)
        Me.gbFamilia.Controls.Add(Me.lblDescription)
        Me.gbFamilia.Controls.Add(Me.txtDescription)
        Me.gbFamilia.Controls.Add(Me.lblBuscar)
        Me.gbFamilia.Controls.Add(Me.txtBuscar)
        Me.gbFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFamilia.Location = New System.Drawing.Point(17, 99)
        Me.gbFamilia.Name = "gbFamilia"
        Me.gbFamilia.Size = New System.Drawing.Size(718, 188)
        Me.gbFamilia.TabIndex = 4
        Me.gbFamilia.TabStop = False
        Me.gbFamilia.Text = "Familia"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(28, 133)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(47, 19)
        Me.lblBuscar.TabIndex = 4
        Me.lblBuscar.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(142, 133)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(205, 23)
        Me.txtBuscar.TabIndex = 5
        '
        'dgFamilias
        '
        Me.dgFamilias.AllowUserToAddRows = False
        Me.dgFamilias.AllowUserToDeleteRows = False
        Me.dgFamilias.AutoGenerateColumns = False
        Me.dgFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFamilias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.dgFamilias.DataSource = Me.FamiliaBindingSource
        Me.dgFamilias.Location = New System.Drawing.Point(17, 305)
        Me.dgFamilias.MultiSelect = False
        Me.dgFamilias.Name = "dgFamilias"
        Me.dgFamilias.ReadOnly = True
        Me.dgFamilias.RowHeadersVisible = False
        Me.dgFamilias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFamilias.Size = New System.Drawing.Size(718, 270)
        Me.dgFamilias.TabIndex = 5
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 101.5228!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.FillWeight = 98.47716!
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripición"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FamiliaBindingSource
        '
        Me.FamiliaBindingSource.DataMember = "Familia"
        Me.FamiliaBindingSource.DataSource = Me.TallerDataSet
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(24, 64)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(34, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "+"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(64, 64)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(34, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "-"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(104, 64)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Guardar"
        '
        'FamiliaTableAdapter
        '
        Me.FamiliaTableAdapter.ClearBeforeFill = True
        '
        'frmMantenimientoFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(759, 598)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbFamilia)
        Me.Controls.Add(Me.dgFamilias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMantenimientoFamilias"
        Me.Text = "Gestión de Familias"
        Me.gbFamilia.ResumeLayout(False)
        Me.gbFamilia.PerformLayout()
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCode As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDescription As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents gbFamilia As GroupBox
    Friend WithEvents dgFamilias As DataGridView
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRemove As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents FamiliaBindingSource As BindingSource
    Friend WithEvents FamiliaTableAdapter As tallerDataSetTableAdapters.FamiliaTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblBuscar As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
End Class
