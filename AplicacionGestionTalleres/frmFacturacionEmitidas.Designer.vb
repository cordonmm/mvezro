<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacionEmitidas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtVehiculo = New MetroFramework.Controls.MetroTextBox()
        Me.txtIVA = New MetroFramework.Controls.MetroTextBox()
        Me.txtFactura = New MetroFramework.Controls.MetroTextBox()
        Me.dtpFechaFac = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblVehiculo = New MetroFramework.Controls.MetroLabel()
        Me.lblCliente = New MetroFramework.Controls.MetroLabel()
        Me.lblFecha = New MetroFramework.Controls.MetroLabel()
        Me.lblIVA = New MetroFramework.Controls.MetroLabel()
        Me.lblNFactura = New MetroFramework.Controls.MetroLabel()
        Me.txtMatricula = New MetroFramework.Controls.MetroTextBox()
        Me.lblMatricula = New MetroFramework.Controls.MetroLabel()
        Me.txtKM = New MetroFramework.Controls.MetroTextBox()
        Me.lblKM = New MetroFramework.Controls.MetroLabel()
        Me.txtDescuento = New MetroFramework.Controls.MetroTextBox()
        Me.txtPVP = New MetroFramework.Controls.MetroTextBox()
        Me.txtCantidad = New MetroFramework.Controls.MetroTextBox()
        Me.txtArticulo = New MetroFramework.Controls.MetroTextBox()
        Me.lblDescuento = New MetroFramework.Controls.MetroLabel()
        Me.lblPVP = New MetroFramework.Controls.MetroLabel()
        Me.lblCantidad = New MetroFramework.Controls.MetroLabel()
        Me.lblArticulo = New MetroFramework.Controls.MetroLabel()
        Me.btnAnadir = New MetroFramework.Controls.MetroButton()
        Me.gbArticulo = New System.Windows.Forms.GroupBox()
        Me.dgArticulos = New System.Windows.Forms.DataGridView()
        Me.FamiliaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtTotalFactura = New MetroFramework.Controls.MetroTextBox()
        Me.lblTotalFactura = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox6 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtBaseImponible = New MetroFramework.Controls.MetroTextBox()
        Me.lblBaseImponible = New MetroFramework.Controls.MetroLabel()
        Me.ConsProductoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConsProductoTableAdapter()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ClienteTableAdapter()
        Me.MetroButton8 = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbArticulo.SuspendLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(1109, 714)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton5.TabIndex = 47
        Me.MetroButton5.Text = "Modificar"
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(1109, 683)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton4.TabIndex = 46
        Me.MetroButton4.Text = "Imprimir"
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(981, 843)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton3.TabIndex = 45
        Me.MetroButton3.Text = "Eliminar"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(850, 843)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton2.TabIndex = 44
        Me.MetroButton2.Text = "Cancelar"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(715, 843)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton1.TabIndex = 43
        Me.MetroButton1.Text = "Aceptar"
        '
        'txtVehiculo
        '
        Me.txtVehiculo.Location = New System.Drawing.Point(771, 94)
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.Size = New System.Drawing.Size(152, 25)
        Me.txtVehiculo.TabIndex = 34
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(158, 94)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(68, 25)
        Me.txtIVA.TabIndex = 32
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(23, 94)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(112, 25)
        Me.txtFactura.TabIndex = 31
        '
        'dtpFechaFac
        '
        Me.dtpFechaFac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFac.Location = New System.Drawing.Point(252, 97)
        Me.dtpFechaFac.Name = "dtpFechaFac"
        Me.dtpFechaFac.Size = New System.Drawing.Size(175, 20)
        Me.dtpFechaFac.TabIndex = 30
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cantidad, Me.descripcion, Me.precio, Me.total})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1019, 215)
        Me.DataGridView1.TabIndex = 29
        '
        'cantidad
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'lblVehiculo
        '
        Me.lblVehiculo.AutoSize = True
        Me.lblVehiculo.Location = New System.Drawing.Point(771, 70)
        Me.lblVehiculo.Name = "lblVehiculo"
        Me.lblVehiculo.Size = New System.Drawing.Size(107, 19)
        Me.lblVehiculo.TabIndex = 28
        Me.lblVehiculo.Text = "Modelo Vehículo"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(450, 70)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(49, 19)
        Me.lblCliente.TabIndex = 27
        Me.lblCliente.Text = "Cliente"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(252, 70)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(43, 19)
        Me.lblFecha.TabIndex = 26
        Me.lblFecha.Text = "Fecha"
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Location = New System.Drawing.Point(162, 70)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(28, 19)
        Me.lblIVA.TabIndex = 25
        Me.lblIVA.Text = "IVA"
        '
        'lblNFactura
        '
        Me.lblNFactura.AutoSize = True
        Me.lblNFactura.Location = New System.Drawing.Point(23, 70)
        Me.lblNFactura.Name = "lblNFactura"
        Me.lblNFactura.Size = New System.Drawing.Size(71, 19)
        Me.lblNFactura.TabIndex = 24
        Me.lblNFactura.Text = "Nº Factura"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(939, 94)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(144, 25)
        Me.txtMatricula.TabIndex = 49
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(939, 70)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(63, 19)
        Me.lblMatricula.TabIndex = 48
        Me.lblMatricula.Text = "Matrícula"
        '
        'txtKM
        '
        Me.txtKM.Location = New System.Drawing.Point(1104, 94)
        Me.txtKM.Name = "txtKM"
        Me.txtKM.Size = New System.Drawing.Size(107, 25)
        Me.txtKM.TabIndex = 51
        '
        'lblKM
        '
        Me.lblKM.AutoSize = True
        Me.lblKM.Location = New System.Drawing.Point(1104, 70)
        Me.lblKM.Name = "lblKM"
        Me.lblKM.Size = New System.Drawing.Size(83, 19)
        Me.lblKM.TabIndex = 50
        Me.lblKM.Text = "Km. Vehículo"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(860, 61)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(152, 25)
        Me.txtDescuento.TabIndex = 60
        '
        'txtPVP
        '
        Me.txtPVP.Location = New System.Drawing.Point(743, 61)
        Me.txtPVP.Name = "txtPVP"
        Me.txtPVP.Size = New System.Drawing.Size(97, 25)
        Me.txtPVP.TabIndex = 59
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(597, 61)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(124, 25)
        Me.txtCantidad.TabIndex = 58
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(25, 61)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(551, 25)
        Me.txtArticulo.TabIndex = 57
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(860, 38)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(69, 19)
        Me.lblDescuento.TabIndex = 55
        Me.lblDescuento.Text = "Descuento"
        '
        'lblPVP
        '
        Me.lblPVP.AutoSize = True
        Me.lblPVP.Location = New System.Drawing.Point(743, 38)
        Me.lblPVP.Name = "lblPVP"
        Me.lblPVP.Size = New System.Drawing.Size(33, 19)
        Me.lblPVP.TabIndex = 54
        Me.lblPVP.Text = "PVP"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(597, 38)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(62, 19)
        Me.lblCantidad.TabIndex = 53
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblArticulo
        '
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Location = New System.Drawing.Point(25, 38)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(55, 19)
        Me.lblArticulo.TabIndex = 52
        Me.lblArticulo.Text = "Artículo"
        '
        'btnAnadir
        '
        Me.btnAnadir.Location = New System.Drawing.Point(1029, 61)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(159, 25)
        Me.btnAnadir.TabIndex = 61
        Me.btnAnadir.Text = "Añadir"
        '
        'gbArticulo
        '
        Me.gbArticulo.Controls.Add(Me.dgArticulos)
        Me.gbArticulo.Controls.Add(Me.btnAnadir)
        Me.gbArticulo.Controls.Add(Me.txtArticulo)
        Me.gbArticulo.Controls.Add(Me.txtDescuento)
        Me.gbArticulo.Controls.Add(Me.lblArticulo)
        Me.gbArticulo.Controls.Add(Me.txtPVP)
        Me.gbArticulo.Controls.Add(Me.lblCantidad)
        Me.gbArticulo.Controls.Add(Me.txtCantidad)
        Me.gbArticulo.Controls.Add(Me.lblPVP)
        Me.gbArticulo.Controls.Add(Me.lblDescuento)
        Me.gbArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbArticulo.Location = New System.Drawing.Point(23, 141)
        Me.gbArticulo.Name = "gbArticulo"
        Me.gbArticulo.Size = New System.Drawing.Size(1210, 378)
        Me.gbArticulo.TabIndex = 62
        Me.gbArticulo.TabStop = False
        Me.gbArticulo.Text = "Añadir artículo"
        '
        'dgArticulos
        '
        Me.dgArticulos.AllowUserToAddRows = False
        Me.dgArticulos.AllowUserToDeleteRows = False
        Me.dgArticulos.AutoGenerateColumns = False
        Me.dgArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgArticulos.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FamiliaDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.dgArticulos.DataSource = Me.ConsProductoBindingSource
        Me.dgArticulos.Location = New System.Drawing.Point(25, 118)
        Me.dgArticulos.MultiSelect = False
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.ReadOnly = True
        Me.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgArticulos.Size = New System.Drawing.Size(1163, 240)
        Me.dgArticulos.TabIndex = 64
        '
        'FamiliaDataGridViewTextBoxColumn
        '
        Me.FamiliaDataGridViewTextBoxColumn.DataPropertyName = "Familia"
        Me.FamiliaDataGridViewTextBoxColumn.HeaderText = "Familia"
        Me.FamiliaDataGridViewTextBoxColumn.Name = "FamiliaDataGridViewTextBoxColumn"
        Me.FamiliaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReferenciaDataGridViewTextBoxColumn
        '
        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        Me.ReferenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        Me.DescripciónDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConsProductoBindingSource
        '
        Me.ConsProductoBindingSource.DataMember = "ConsProducto"
        Me.ConsProductoBindingSource.DataSource = Me.TallerDataSet
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroButton7
        '
        Me.MetroButton7.Location = New System.Drawing.Point(1109, 746)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton7.TabIndex = 63
        Me.MetroButton7.Text = "Buscar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 526)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1060, 264)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Líneas"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(353, 843)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel9.TabIndex = 73
        Me.MetroLabel9.Text = "+"
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.Location = New System.Drawing.Point(402, 841)
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.Size = New System.Drawing.Size(131, 25)
        Me.txtTotalFactura.TabIndex = 72
        '
        'lblTotalFactura
        '
        Me.lblTotalFactura.AutoSize = True
        Me.lblTotalFactura.Location = New System.Drawing.Point(402, 815)
        Me.lblTotalFactura.Name = "lblTotalFactura"
        Me.lblTotalFactura.Size = New System.Drawing.Size(82, 19)
        Me.lblTotalFactura.TabIndex = 71
        Me.lblTotalFactura.Text = "Total Factura"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(162, 843)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel8.TabIndex = 70
        Me.MetroLabel8.Text = "+"
        '
        'MetroTextBox6
        '
        Me.MetroTextBox6.Location = New System.Drawing.Point(212, 841)
        Me.MetroTextBox6.Name = "MetroTextBox6"
        Me.MetroTextBox6.Size = New System.Drawing.Size(112, 25)
        Me.MetroTextBox6.TabIndex = 69
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(212, 815)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(28, 19)
        Me.MetroLabel7.TabIndex = 68
        Me.MetroLabel7.Text = "IVA"
        '
        'txtBaseImponible
        '
        Me.txtBaseImponible.Location = New System.Drawing.Point(23, 841)
        Me.txtBaseImponible.Name = "txtBaseImponible"
        Me.txtBaseImponible.Size = New System.Drawing.Size(112, 25)
        Me.txtBaseImponible.TabIndex = 67
        '
        'lblBaseImponible
        '
        Me.lblBaseImponible.AutoSize = True
        Me.lblBaseImponible.Location = New System.Drawing.Point(23, 815)
        Me.lblBaseImponible.Name = "lblBaseImponible"
        Me.lblBaseImponible.Size = New System.Drawing.Size(99, 19)
        Me.lblBaseImponible.TabIndex = 66
        Me.lblBaseImponible.Text = "Base Imponible"
        '
        'ConsProductoTableAdapter
        '
        Me.ConsProductoTableAdapter.ClearBeforeFill = True
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.DataSource = Me.ClienteBindingSource
        Me.cmbCliente.DisplayMember = "nombre"
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(450, 95)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(294, 21)
        Me.cmbCliente.TabIndex = 74
        Me.cmbCliente.ValueMember = "Id"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.TallerDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'MetroButton8
        '
        Me.MetroButton8.Location = New System.Drawing.Point(1109, 568)
        Me.MetroButton8.Name = "MetroButton8"
        Me.MetroButton8.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton8.TabIndex = 75
        Me.MetroButton8.Text = "Eliminar linea"
        '
        'frmFacturacionEmitidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 884)
        Me.Controls.Add(Me.MetroButton8)
        Me.Controls.Add(Me.lblNFactura)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dtpFechaFac)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.lblVehiculo)
        Me.Controls.Add(Me.txtVehiculo)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.lblKM)
        Me.Controls.Add(Me.txtKM)
        Me.Controls.Add(Me.gbArticulo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.lblTotalFactura)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroTextBox6)
        Me.Controls.Add(Me.txtTotalFactura)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txtBaseImponible)
        Me.Controls.Add(Me.lblBaseImponible)
        Me.Controls.Add(Me.MetroButton7)
        Me.Controls.Add(Me.MetroButton5)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmFacturacionEmitidas"
        Me.Padding = New System.Windows.Forms.Padding(20, 65, 20, 22)
        Me.Text = "Facturas Emitidas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbArticulo.ResumeLayout(False)
        Me.gbArticulo.PerformLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtVehiculo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIVA As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFactura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpFechaFac As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblVehiculo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCliente As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblFecha As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblIVA As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNFactura As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMatricula As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblMatricula As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtKM As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblKM As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescuento As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPVP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCantidad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtArticulo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDescuento As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPVP As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCantidad As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblArticulo As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAnadir As MetroFramework.Controls.MetroButton
    Friend WithEvents gbArticulo As GroupBox
    Friend WithEvents dgArticulos As DataGridView
    Friend WithEvents MetroButton7 As MetroFramework.Controls.MetroButton
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTotalFactura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblTotalFactura As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox6 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBaseImponible As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblBaseImponible As MetroFramework.Controls.MetroLabel
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents ConsProductoBindingSource As BindingSource
    Friend WithEvents ConsProductoTableAdapter As tallerDataSetTableAdapters.ConsProductoTableAdapter
    Friend WithEvents FamiliaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As tallerDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents MetroButton8 As MetroFramework.Controls.MetroButton
End Class
