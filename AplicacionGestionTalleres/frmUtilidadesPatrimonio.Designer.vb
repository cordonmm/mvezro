<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilidadesPatrimonio
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
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox7 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox6 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.txtIVA = New MetroFramework.Controls.MetroTextBox()
        Me.txtFactura = New MetroFramework.Controls.MetroTextBox()
        Me.dtpFechaFac = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txtConcepto = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtImporte = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.ConfiguracionTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConfiguracionTableAdapter()
        Me.PatrimonioTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.PatrimonioTableAdapter()
        Me.txtIdentificador = New System.Windows.Forms.TextBox()
        Me.ProveedorTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ProveedorTableAdapter()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(353, 839)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel9.TabIndex = 129
        Me.MetroLabel9.Text = "+"
        '
        'MetroTextBox7
        '
        Me.MetroTextBox7.Location = New System.Drawing.Point(402, 837)
        Me.MetroTextBox7.Name = "MetroTextBox7"
        Me.MetroTextBox7.Size = New System.Drawing.Size(131, 25)
        Me.MetroTextBox7.TabIndex = 128
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(402, 811)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel10.TabIndex = 127
        Me.MetroLabel10.Text = "Total Presupuesto"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(162, 839)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel8.TabIndex = 126
        Me.MetroLabel8.Text = "+"
        '
        'MetroTextBox6
        '
        Me.MetroTextBox6.Location = New System.Drawing.Point(212, 837)
        Me.MetroTextBox6.Name = "MetroTextBox6"
        Me.MetroTextBox6.Size = New System.Drawing.Size(112, 25)
        Me.MetroTextBox6.TabIndex = 125
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(212, 811)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(28, 19)
        Me.MetroLabel7.TabIndex = 124
        Me.MetroLabel7.Text = "IVA"
        '
        'MetroTextBox5
        '
        Me.MetroTextBox5.Location = New System.Drawing.Point(23, 837)
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.Size = New System.Drawing.Size(112, 25)
        Me.MetroTextBox5.TabIndex = 123
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 811)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel6.TabIndex = 122
        Me.MetroLabel6.Text = "Base Imponible"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(604, 201)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(102, 25)
        Me.btnImprimir.TabIndex = 117
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(823, 201)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 25)
        Me.btnCancelar.TabIndex = 115
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(712, 201)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(102, 25)
        Me.btnAceptar.TabIndex = 114
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(162, 90)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(68, 25)
        Me.txtIVA.TabIndex = 4
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(23, 90)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(112, 25)
        Me.txtFactura.TabIndex = 2
        '
        'dtpFechaFac
        '
        Me.dtpFechaFac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFac.Location = New System.Drawing.Point(245, 90)
        Me.dtpFechaFac.Name = "dtpFechaFac"
        Me.dtpFechaFac.Size = New System.Drawing.Size(175, 20)
        Me.dtpFechaFac.TabIndex = 6
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(630, 66)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel4.TabIndex = 107
        Me.MetroLabel4.Text = "Proveedor"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(245, 63)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel3.TabIndex = 106
        Me.MetroLabel3.Text = "Fecha"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(162, 66)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(28, 19)
        Me.MetroLabel2.TabIndex = 105
        Me.MetroLabel2.Text = "IVA"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 66)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel1.TabIndex = 104
        Me.MetroLabel1.Text = "Nº Factura"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(442, 67)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel12.TabIndex = 131
        Me.MetroLabel12.Text = "Identificador"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(23, 157)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(645, 25)
        Me.txtConcepto.TabIndex = 12
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 133)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel5.TabIndex = 132
        Me.MetroLabel5.Text = "Concepto"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(691, 157)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(231, 25)
        Me.txtImporte.TabIndex = 16
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(691, 133)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel11.TabIndex = 134
        Me.MetroLabel11.Text = "Importe"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedor.DataSource = Me.ProveedorBindingSource
        Me.cmbProveedor.DisplayMember = "nombre"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(630, 90)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(275, 21)
        Me.cmbProveedor.TabIndex = 10
        Me.cmbProveedor.ValueMember = "Id"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.TallerDataSet
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConfiguracionTableAdapter
        '
        Me.ConfiguracionTableAdapter.ClearBeforeFill = True
        '
        'PatrimonioTableAdapter
        '
        Me.PatrimonioTableAdapter.ClearBeforeFill = True
        '
        'txtIdentificador
        '
        Me.txtIdentificador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtIdentificador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtIdentificador.Location = New System.Drawing.Point(442, 90)
        Me.txtIdentificador.Name = "txtIdentificador"
        Me.txtIdentificador.Size = New System.Drawing.Size(164, 20)
        Me.txtIdentificador.TabIndex = 8
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'frmUtilidadesPatrimonio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(948, 267)
        Me.Controls.Add(Me.txtIdentificador)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroTextBox7)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroTextBox6)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroTextBox5)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.dtpFechaFac)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "frmUtilidadesPatrimonio"
        Me.Text = "Patrimonio"
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox7 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox6 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtIVA As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFactura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpFechaFac As DateTimePicker
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtConcepto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtImporte As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents ConfiguracionTableAdapter As tallerDataSetTableAdapters.ConfiguracionTableAdapter
    Friend WithEvents PatrimonioTableAdapter As tallerDataSetTableAdapters.PatrimonioTableAdapter
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents txtIdentificador As TextBox
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As tallerDataSetTableAdapters.ProveedorTableAdapter
End Class
