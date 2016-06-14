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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.txtVehiculo = New MetroFramework.Controls.MetroTextBox()
        Me.txtIVA = New MetroFramework.Controls.MetroTextBox()
        Me.txtFactura = New MetroFramework.Controls.MetroTextBox()
        Me.dtpFechaFac = New System.Windows.Forms.DateTimePicker()
        Me.dgLinea = New System.Windows.Forms.DataGridView()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.btnNuevoArticulo = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dgArticulos = New System.Windows.Forms.DataGridView()
        Me.FamiliaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.gbLineas = New System.Windows.Forms.GroupBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtTotalFactura = New MetroFramework.Controls.MetroTextBox()
        Me.lblTotalFactura = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtIVATotal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtBaseImponible = New MetroFramework.Controls.MetroTextBox()
        Me.lblBaseImponible = New MetroFramework.Controls.MetroLabel()
        Me.ConsProductoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConsProductoTableAdapter()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ClienteTableAdapter()
        Me.btnEliminarLinea = New MetroFramework.Controls.MetroButton()
        Me.ConfiguracionTableAdapter1 = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConfiguracionTableAdapter()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.FacturaETableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.FacturaETableAdapter()
        Me.cbContado = New System.Windows.Forms.CheckBox()
        Me.LineaFacturaETableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.LineaFacturaETableAdapter()
        Me.ProductoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ProductoTableAdapter()
        Me.btnAñadirCliente = New MetroFramework.Controls.MetroButton()
        CType(Me.dgLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbArticulo.SuspendLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLineas.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(1109, 715)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(102, 25)
        Me.btnImprimir.TabIndex = 25
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(1112, 841)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(102, 25)
        Me.btnEliminar.TabIndex = 33
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(981, 841)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 25)
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(846, 841)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(102, 25)
        Me.btnAceptar.TabIndex = 31
        Me.btnAceptar.Text = "Guardar"
        '
        'txtVehiculo
        '
        Me.txtVehiculo.Location = New System.Drawing.Point(771, 94)
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.Size = New System.Drawing.Size(152, 25)
        Me.txtVehiculo.TabIndex = 14
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(158, 94)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(62, 25)
        Me.txtIVA.TabIndex = 11
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(23, 94)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(112, 25)
        Me.txtFactura.TabIndex = 10
        '
        'dtpFechaFac
        '
        Me.dtpFechaFac.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaFac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFac.Location = New System.Drawing.Point(252, 97)
        Me.dtpFechaFac.Name = "dtpFechaFac"
        Me.dtpFechaFac.Size = New System.Drawing.Size(175, 20)
        Me.dtpFechaFac.TabIndex = 12
        Me.dtpFechaFac.TabStop = False
        Me.dtpFechaFac.Value = New Date(2016, 6, 9, 0, 0, 0, 0)
        '
        'dgLinea
        '
        Me.dgLinea.AllowUserToAddRows = False
        Me.dgLinea.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgLinea.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgLinea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgLinea.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.dgLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLinea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.cantidad, Me.descripcion, Me.precio, Me.total})
        Me.dgLinea.Location = New System.Drawing.Point(25, 30)
        Me.dgLinea.Name = "dgLinea"
        Me.dgLinea.ReadOnly = True
        Me.dgLinea.RowHeadersVisible = False
        Me.dgLinea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLinea.Size = New System.Drawing.Size(1019, 215)
        Me.dgLinea.TabIndex = 29
        '
        'idProducto
        '
        Me.idProducto.HeaderText = "idProducto"
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        Me.idProducto.Visible = False
        '
        'cantidad
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.precio.DefaultCellStyle = DataGridViewCellStyle3
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'total
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle4
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
        Me.txtMatricula.TabIndex = 15
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
        Me.txtKM.TabIndex = 16
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
        Me.txtDescuento.Size = New System.Drawing.Size(89, 25)
        Me.txtDescuento.TabIndex = 21
        '
        'txtPVP
        '
        Me.txtPVP.Location = New System.Drawing.Point(743, 61)
        Me.txtPVP.Name = "txtPVP"
        Me.txtPVP.Size = New System.Drawing.Size(97, 25)
        Me.txtPVP.TabIndex = 20
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(597, 61)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(124, 25)
        Me.txtCantidad.TabIndex = 19
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(25, 61)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(466, 25)
        Me.txtArticulo.TabIndex = 18
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
        Me.btnAnadir.TabIndex = 22
        Me.btnAnadir.Text = "Añadir"
        '
        'gbArticulo
        '
        Me.gbArticulo.Controls.Add(Me.btnNuevoArticulo)
        Me.gbArticulo.Controls.Add(Me.MetroLabel1)
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
        Me.gbArticulo.TabIndex = 17
        Me.gbArticulo.TabStop = False
        Me.gbArticulo.Text = "Añadir artículo"
        '
        'btnNuevoArticulo
        '
        Me.btnNuevoArticulo.Location = New System.Drawing.Point(497, 61)
        Me.btnNuevoArticulo.Name = "btnNuevoArticulo"
        Me.btnNuevoArticulo.Size = New System.Drawing.Size(28, 25)
        Me.btnNuevoArticulo.TabIndex = 107
        Me.btnNuevoArticulo.Text = "+"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(949, 61)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel1.TabIndex = 74
        Me.MetroLabel1.Text = "%"
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
        Me.dgArticulos.RowHeadersVisible = False
        Me.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgArticulos.Size = New System.Drawing.Size(1163, 240)
        Me.dgArticulos.TabIndex = 23
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
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
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
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(1109, 746)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 25)
        Me.btnBuscar.TabIndex = 27
        Me.btnBuscar.Text = "Buscar"
        '
        'gbLineas
        '
        Me.gbLineas.Controls.Add(Me.dgLinea)
        Me.gbLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLineas.Location = New System.Drawing.Point(23, 526)
        Me.gbLineas.Name = "gbLineas"
        Me.gbLineas.Size = New System.Drawing.Size(1060, 264)
        Me.gbLineas.TabIndex = 65
        Me.gbLineas.TabStop = False
        Me.gbLineas.Text = "Líneas"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(353, 843)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel9.TabIndex = 73
        Me.MetroLabel9.Text = "="
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.Location = New System.Drawing.Point(402, 841)
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.ReadOnly = True
        Me.txtTotalFactura.Size = New System.Drawing.Size(131, 25)
        Me.txtTotalFactura.TabIndex = 30
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
        'txtIVATotal
        '
        Me.txtIVATotal.Location = New System.Drawing.Point(212, 841)
        Me.txtIVATotal.Name = "txtIVATotal"
        Me.txtIVATotal.Size = New System.Drawing.Size(112, 25)
        Me.txtIVATotal.TabIndex = 29
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
        Me.txtBaseImponible.ReadOnly = True
        Me.txtBaseImponible.Size = New System.Drawing.Size(112, 25)
        Me.txtBaseImponible.TabIndex = 28
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
        Me.cmbCliente.Size = New System.Drawing.Size(264, 21)
        Me.cmbCliente.TabIndex = 13
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
        'btnEliminarLinea
        '
        Me.btnEliminarLinea.Location = New System.Drawing.Point(1109, 568)
        Me.btnEliminarLinea.Name = "btnEliminarLinea"
        Me.btnEliminarLinea.Size = New System.Drawing.Size(102, 25)
        Me.btnEliminarLinea.TabIndex = 24
        Me.btnEliminarLinea.Text = "Eliminar linea"
        '
        'ConfiguracionTableAdapter1
        '
        Me.ConfiguracionTableAdapter1.ClearBeforeFill = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(220, 97)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel2.TabIndex = 75
        Me.MetroLabel2.Text = "%"
        '
        'FacturaETableAdapter
        '
        Me.FacturaETableAdapter.ClearBeforeFill = True
        '
        'cbContado
        '
        Me.cbContado.AutoSize = True
        Me.cbContado.Location = New System.Drawing.Point(598, 845)
        Me.cbContado.Name = "cbContado"
        Me.cbContado.Size = New System.Drawing.Size(116, 17)
        Me.cbContado.TabIndex = 76
        Me.cbContado.Text = "Pagada al contado"
        Me.cbContado.UseVisualStyleBackColor = True
        '
        'LineaFacturaETableAdapter
        '
        Me.LineaFacturaETableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'btnAñadirCliente
        '
        Me.btnAñadirCliente.Location = New System.Drawing.Point(720, 94)
        Me.btnAñadirCliente.Name = "btnAñadirCliente"
        Me.btnAñadirCliente.Size = New System.Drawing.Size(24, 22)
        Me.btnAñadirCliente.TabIndex = 108
        Me.btnAñadirCliente.Text = "+"
        '
        'frmFacturacionEmitidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 884)
        Me.Controls.Add(Me.btnAñadirCliente)
        Me.Controls.Add(Me.cbContado)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnEliminarLinea)
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
        Me.Controls.Add(Me.gbLineas)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.lblTotalFactura)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.txtIVATotal)
        Me.Controls.Add(Me.txtTotalFactura)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txtBaseImponible)
        Me.Controls.Add(Me.lblBaseImponible)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmFacturacionEmitidas"
        Me.Padding = New System.Windows.Forms.Padding(20, 65, 20, 22)
        Me.Text = "Facturas Emitidas"
        CType(Me.dgLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbArticulo.ResumeLayout(False)
        Me.gbArticulo.PerformLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLineas.ResumeLayout(False)
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtVehiculo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIVA As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFactura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpFechaFac As DateTimePicker
    Friend WithEvents dgLinea As DataGridView
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
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents gbLineas As GroupBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTotalFactura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblTotalFactura As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtIVATotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBaseImponible As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblBaseImponible As MetroFramework.Controls.MetroLabel
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents ConsProductoBindingSource As BindingSource
    Friend WithEvents ConsProductoTableAdapter As tallerDataSetTableAdapters.ConsProductoTableAdapter
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As tallerDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents btnEliminarLinea As MetroFramework.Controls.MetroButton
    Friend WithEvents FamiliaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents ConfiguracionTableAdapter1 As tallerDataSetTableAdapters.ConfiguracionTableAdapter
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents FacturaETableAdapter As tallerDataSetTableAdapters.FacturaETableAdapter
    Friend WithEvents cbContado As CheckBox
    Friend WithEvents LineaFacturaETableAdapter As tallerDataSetTableAdapters.LineaFacturaETableAdapter
    Friend WithEvents ProductoTableAdapter As tallerDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents btnNuevoArticulo As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAñadirCliente As MetroFramework.Controls.MetroButton
End Class
