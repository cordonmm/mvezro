<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoArticulosAlta
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
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.lblObservaciones = New MetroFramework.Controls.MetroLabel()
        Me.txtObservaciones = New MetroFramework.Controls.MetroTextBox()
        Me.txtPVP = New MetroFramework.Controls.MetroTextBox()
        Me.lblPVP = New MetroFramework.Controls.MetroLabel()
        Me.lblFamilia = New MetroFramework.Controls.MetroLabel()
        Me.FamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.txtReferencia = New MetroFramework.Controls.MetroTextBox()
        Me.lblReferencia = New MetroFramework.Controls.MetroLabel()
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.lblDescripcion = New MetroFramework.Controls.MetroLabel()
        Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.txtPrecioCosto = New MetroFramework.Controls.MetroTextBox()
        Me.lblPrecioCosto = New MetroFramework.Controls.MetroLabel()
        Me.FamiliaTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.FamiliaTableAdapter()
        Me.lblStock = New MetroFramework.Controls.MetroLabel()
        Me.txtStock = New MetroFramework.Controls.MetroTextBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New AplicacionGestionTalleres.tallerDataSetTableAdapters.TableAdapterManager()
        Me.cmbFamilia = New System.Windows.Forms.ComboBox()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(597, 497)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 25)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(470, 497)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(102, 25)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(23, 359)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(95, 19)
        Me.lblObservaciones.TabIndex = 91
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(23, 389)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(676, 65)
        Me.txtObservaciones.TabIndex = 13
        '
        'txtPVP
        '
        Me.txtPVP.Location = New System.Drawing.Point(385, 239)
        Me.txtPVP.Name = "txtPVP"
        Me.txtPVP.Size = New System.Drawing.Size(314, 25)
        Me.txtPVP.TabIndex = 9
        '
        'lblPVP
        '
        Me.lblPVP.AutoSize = True
        Me.lblPVP.Location = New System.Drawing.Point(385, 215)
        Me.lblPVP.Name = "lblPVP"
        Me.lblPVP.Size = New System.Drawing.Size(83, 19)
        Me.lblPVP.TabIndex = 78
        Me.lblPVP.Text = "PVP (sin IVA)"
        '
        'lblFamilia
        '
        Me.lblFamilia.AutoSize = True
        Me.lblFamilia.Location = New System.Drawing.Point(178, 73)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(50, 19)
        Me.lblFamilia.TabIndex = 73
        Me.lblFamilia.Text = "Familia"
        '
        'FamiliaBindingSource
        '
        Me.FamiliaBindingSource.DataMember = "Familia"
        Me.FamiliaBindingSource.DataSource = Me.TallerDataSetBindingSource
        '
        'TallerDataSetBindingSource
        '
        Me.TallerDataSetBindingSource.DataSource = Me.TallerDataSet
        Me.TallerDataSetBindingSource.Position = 0
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(479, 99)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(220, 25)
        Me.txtReferencia.TabIndex = 3
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(479, 75)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(70, 19)
        Me.lblReferencia.TabIndex = 68
        Me.lblReferencia.Text = "Referencia"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(23, 165)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(676, 25)
        Me.txtDescripcion.TabIndex = 5
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 141)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(76, 19)
        Me.lblDescripcion.TabIndex = 66
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(23, 97)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(112, 25)
        Me.txtCodigo.TabIndex = 65
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(23, 73)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 19)
        Me.lblCodigo.TabIndex = 64
        Me.lblCodigo.Text = "Código"
        '
        'txtPrecioCosto
        '
        Me.txtPrecioCosto.Location = New System.Drawing.Point(23, 239)
        Me.txtPrecioCosto.Name = "txtPrecioCosto"
        Me.txtPrecioCosto.Size = New System.Drawing.Size(313, 25)
        Me.txtPrecioCosto.TabIndex = 7
        '
        'lblPrecioCosto
        '
        Me.lblPrecioCosto.AutoSize = True
        Me.lblPrecioCosto.Location = New System.Drawing.Point(23, 215)
        Me.lblPrecioCosto.Name = "lblPrecioCosto"
        Me.lblPrecioCosto.Size = New System.Drawing.Size(120, 19)
        Me.lblPrecioCosto.TabIndex = 94
        Me.lblPrecioCosto.Text = "Precio Costo + IVA"
        '
        'FamiliaTableAdapter
        '
        Me.FamiliaTableAdapter.ClearBeforeFill = True
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(22, 285)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(40, 19)
        Me.lblStock.TabIndex = 96
        Me.lblStock.Text = "Stock"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(22, 309)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(113, 25)
        Me.txtStock.TabIndex = 11
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.TallerDataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlbaranTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ConfiguracionTableAdapter = Nothing
        Me.TableAdapterManager.FacturaETableAdapter = Nothing
        Me.TableAdapterManager.FacturaRTableAdapter = Nothing
        Me.TableAdapterManager.FamiliaTableAdapter = Me.FamiliaTableAdapter
        Me.TableAdapterManager.LineaAlbaranTableAdapter = Nothing
        Me.TableAdapterManager.LineaFacturaETableAdapter = Nothing
        Me.TableAdapterManager.LineaFacturaRTableAdapter = Nothing
        Me.TableAdapterManager.LineaPresupuestoTableAdapter = Nothing
        Me.TableAdapterManager.PatrimonioTableAdapter = Nothing
        Me.TableAdapterManager.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AplicacionGestionTalleres.tallerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cmbFamilia
        '
        Me.cmbFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFamilia.DataSource = Me.FamiliaBindingSource
        Me.cmbFamilia.DisplayMember = "descripcion"
        Me.cmbFamilia.DropDownHeight = 103
        Me.cmbFamilia.FormattingEnabled = True
        Me.cmbFamilia.IntegralHeight = False
        Me.cmbFamilia.Location = New System.Drawing.Point(178, 99)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.Size = New System.Drawing.Size(256, 21)
        Me.cmbFamilia.TabIndex = 1
        Me.cmbFamilia.ValueMember = "Id"
        '
        'frmMantenimientoArticulosAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(736, 570)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblFamilia)
        Me.Controls.Add(Me.cmbFamilia)
        Me.Controls.Add(Me.lblReferencia)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblPrecioCosto)
        Me.Controls.Add(Me.txtPrecioCosto)
        Me.Controls.Add(Me.lblPVP)
        Me.Controls.Add(Me.txtPVP)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "frmMantenimientoArticulosAlta"
        Me.Text = "Nuevo Artículo"
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Friend WithEvents lblObservaciones As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtObservaciones As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPVP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPVP As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblFamilia As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtReferencia As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblReferencia As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDescripcion As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPrecioCosto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPrecioCosto As MetroFramework.Controls.MetroLabel
    Friend WithEvents TallerDataSetBindingSource As BindingSource
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents FamiliaBindingSource As BindingSource
    Friend WithEvents FamiliaTableAdapter As tallerDataSetTableAdapters.FamiliaTableAdapter
    Friend WithEvents lblStock As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As tallerDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As tallerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cmbFamilia As ComboBox
End Class
