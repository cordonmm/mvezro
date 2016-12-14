<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacionRecibidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturacionRecibidas))
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtTotalFactura = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtIVATotal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtBaseImponible = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.txtAlbaran = New MetroFramework.Controls.MetroTextBox()
        Me.txtIVA = New MetroFramework.Controls.MetroTextBox()
        Me.txtFactura = New MetroFramework.Controls.MetroTextBox()
        Me.dtpFechaFac = New System.Windows.Forms.DateTimePicker()
        Me.lblAlbaran = New MetroFramework.Controls.MetroLabel()
        Me.lblProveedor = New MetroFramework.Controls.MetroLabel()
        Me.lblFecha = New MetroFramework.Controls.MetroLabel()
        Me.lblIVA = New MetroFramework.Controls.MetroLabel()
        Me.lblFactura = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.txtFamilia = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblReferencia = New MetroFramework.Controls.MetroLabel()
        Me.btnNuevoArticulo = New MetroFramework.Controls.MetroButton()
        Me.dgArticulos = New System.Windows.Forms.DataGridView()
        Me.FamiliaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pvp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.btnAñadir = New MetroFramework.Controls.MetroButton()
        Me.txtDescuento = New MetroFramework.Controls.MetroTextBox()
        Me.lblFamilia = New MetroFramework.Controls.MetroLabel()
        Me.txtPVP = New MetroFramework.Controls.MetroTextBox()
        Me.lblCantidad = New MetroFramework.Controls.MetroLabel()
        Me.lblPVP = New MetroFramework.Controls.MetroLabel()
        Me.lblDescuento = New MetroFramework.Controls.MetroLabel()
        Me.gbLineas = New System.Windows.Forms.GroupBox()
        Me.dgLinea = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsProductoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConsProductoTableAdapter()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ProveedorTableAdapter()
        Me.btnEliminarLinea = New MetroFramework.Controls.MetroButton()
        Me.ConfiguracionTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ConfiguracionTableAdapter()
        Me.FacturaRTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.FacturaRTableAdapter()
        Me.cbContado = New System.Windows.Forms.CheckBox()
        Me.ProductoTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ProductoTableAdapter()
        Me.LineaFacturaRTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.LineaFacturaRTableAdapter()
        Me.btnAñadirProveedor = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLineas.SuspendLayout()
        CType(Me.dgLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(353, 832)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel9.TabIndex = 103
        Me.MetroLabel9.Text = "+"
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.Location = New System.Drawing.Point(402, 830)
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.Size = New System.Drawing.Size(131, 25)
        Me.txtTotalFactura.TabIndex = 54
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(402, 804)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel10.TabIndex = 101
        Me.MetroLabel10.Text = "Total Factura"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(162, 832)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel8.TabIndex = 100
        Me.MetroLabel8.Text = "+"
        '
        'txtIVATotal
        '
        Me.txtIVATotal.Location = New System.Drawing.Point(212, 830)
        Me.txtIVATotal.Name = "txtIVATotal"
        Me.txtIVATotal.Size = New System.Drawing.Size(112, 25)
        Me.txtIVATotal.TabIndex = 50
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(212, 804)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(28, 19)
        Me.MetroLabel7.TabIndex = 98
        Me.MetroLabel7.Text = "IVA"
        '
        'txtBaseImponible
        '
        Me.txtBaseImponible.Location = New System.Drawing.Point(23, 830)
        Me.txtBaseImponible.Name = "txtBaseImponible"
        Me.txtBaseImponible.Size = New System.Drawing.Size(112, 25)
        Me.txtBaseImponible.TabIndex = 48
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 804)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel6.TabIndex = 46
        Me.MetroLabel6.Text = "Base Imponible"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(1109, 754)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 25)
        Me.btnBuscar.TabIndex = 40
        Me.btnBuscar.Text = "Buscar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(1109, 826)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(102, 25)
        Me.btnEliminar.TabIndex = 64
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(981, 826)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 25)
        Me.btnCancelar.TabIndex = 62
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(855, 826)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(102, 25)
        Me.btnAceptar.TabIndex = 60
        Me.btnAceptar.Text = "Guardar"
        '
        'txtAlbaran
        '
        Me.txtAlbaran.Location = New System.Drawing.Point(912, 83)
        Me.txtAlbaran.Name = "txtAlbaran"
        Me.txtAlbaran.Size = New System.Drawing.Size(321, 25)
        Me.txtAlbaran.TabIndex = 20
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(158, 83)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(68, 25)
        Me.txtIVA.TabIndex = 12
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(23, 83)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(112, 25)
        Me.txtFactura.TabIndex = 10
        '
        'dtpFechaFac
        '
        Me.dtpFechaFac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFac.Location = New System.Drawing.Point(252, 86)
        Me.dtpFechaFac.Name = "dtpFechaFac"
        Me.dtpFechaFac.Size = New System.Drawing.Size(175, 20)
        Me.dtpFechaFac.TabIndex = 14
        '
        'lblAlbaran
        '
        Me.lblAlbaran.AutoSize = True
        Me.lblAlbaran.Location = New System.Drawing.Point(912, 59)
        Me.lblAlbaran.Name = "lblAlbaran"
        Me.lblAlbaran.Size = New System.Drawing.Size(120, 19)
        Me.lblAlbaran.TabIndex = 78
        Me.lblAlbaran.Text = "Referencia Albarán"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(450, 59)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(71, 19)
        Me.lblProveedor.TabIndex = 77
        Me.lblProveedor.Text = "Proveedor"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(252, 59)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(43, 19)
        Me.lblFecha.TabIndex = 76
        Me.lblFecha.Text = "Fecha"
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Location = New System.Drawing.Point(162, 59)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(28, 19)
        Me.lblIVA.TabIndex = 75
        Me.lblIVA.Text = "IVA"
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Location = New System.Drawing.Point(23, 59)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(71, 19)
        Me.lblFactura.TabIndex = 74
        Me.lblFactura.Text = "Nº Factura"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtReferencia)
        Me.GroupBox1.Controls.Add(Me.txtFamilia)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.lblReferencia)
        Me.GroupBox1.Controls.Add(Me.btnNuevoArticulo)
        Me.GroupBox1.Controls.Add(Me.dgArticulos)
        Me.GroupBox1.Controls.Add(Me.btnAñadir)
        Me.GroupBox1.Controls.Add(Me.txtDescuento)
        Me.GroupBox1.Controls.Add(Me.lblFamilia)
        Me.GroupBox1.Controls.Add(Me.txtPVP)
        Me.GroupBox1.Controls.Add(Me.lblCantidad)
        Me.GroupBox1.Controls.Add(Me.lblPVP)
        Me.GroupBox1.Controls.Add(Me.lblDescuento)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1210, 378)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Añadir artículo"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(256, 60)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(219, 26)
        Me.txtReferencia.TabIndex = 23
        '
        'txtFamilia
        '
        Me.txtFamilia.Location = New System.Drawing.Point(25, 61)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(212, 26)
        Me.txtFamilia.TabIndex = 22
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(549, 60)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 26)
        Me.txtCantidad.TabIndex = 26
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(256, 38)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(70, 19)
        Me.lblReferencia.TabIndex = 57
        Me.lblReferencia.Text = "Referencia"
        '
        'btnNuevoArticulo
        '
        Me.btnNuevoArticulo.Location = New System.Drawing.Point(481, 60)
        Me.btnNuevoArticulo.Name = "btnNuevoArticulo"
        Me.btnNuevoArticulo.Size = New System.Drawing.Size(35, 26)
        Me.btnNuevoArticulo.TabIndex = 24
        Me.btnNuevoArticulo.Text = "+"
        '
        'dgArticulos
        '
        Me.dgArticulos.AllowUserToAddRows = False
        Me.dgArticulos.AllowUserToDeleteRows = False
        Me.dgArticulos.AutoGenerateColumns = False
        Me.dgArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgArticulos.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FamiliaDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.pvp, Me.StockDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn})
        Me.dgArticulos.DataSource = Me.ConsProductoBindingSource
        Me.dgArticulos.Location = New System.Drawing.Point(25, 118)
        Me.dgArticulos.MultiSelect = False
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.ReadOnly = True
        Me.dgArticulos.RowHeadersVisible = False
        Me.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgArticulos.Size = New System.Drawing.Size(1163, 240)
        Me.dgArticulos.TabIndex = 34
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
        'pvp
        '
        Me.pvp.DataPropertyName = "pvp"
        Me.pvp.HeaderText = "pvp"
        Me.pvp.Name = "pvp"
        Me.pvp.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
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
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(1051, 61)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(137, 25)
        Me.btnAñadir.TabIndex = 32
        Me.btnAñadir.Text = "Añadir"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(852, 61)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(157, 25)
        Me.txtDescuento.TabIndex = 30
        '
        'lblFamilia
        '
        Me.lblFamilia.AutoSize = True
        Me.lblFamilia.Location = New System.Drawing.Point(25, 38)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(50, 19)
        Me.lblFamilia.TabIndex = 52
        Me.lblFamilia.Text = "Familia"
        '
        'txtPVP
        '
        Me.txtPVP.Location = New System.Drawing.Point(678, 61)
        Me.txtPVP.Name = "txtPVP"
        Me.txtPVP.Size = New System.Drawing.Size(121, 25)
        Me.txtPVP.TabIndex = 28
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(549, 38)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(62, 19)
        Me.lblCantidad.TabIndex = 53
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblPVP
        '
        Me.lblPVP.AutoSize = True
        Me.lblPVP.Location = New System.Drawing.Point(678, 38)
        Me.lblPVP.Name = "lblPVP"
        Me.lblPVP.Size = New System.Drawing.Size(33, 19)
        Me.lblPVP.TabIndex = 54
        Me.lblPVP.Text = "PVP"
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(852, 38)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(69, 19)
        Me.lblDescuento.TabIndex = 55
        Me.lblDescuento.Text = "Descuento"
        '
        'gbLineas
        '
        Me.gbLineas.Controls.Add(Me.dgLinea)
        Me.gbLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLineas.Location = New System.Drawing.Point(23, 515)
        Me.gbLineas.Name = "gbLineas"
        Me.gbLineas.Size = New System.Drawing.Size(1060, 264)
        Me.gbLineas.TabIndex = 42
        Me.gbLineas.TabStop = False
        Me.gbLineas.Text = "Líneas"
        '
        'dgLinea
        '
        Me.dgLinea.AllowUserToAddRows = False
        Me.dgLinea.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgLinea.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgLinea.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.dgLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLinea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.cantidad, Me.descripcion, Me.precio, Me.Descuento, Me.total})
        Me.dgLinea.Location = New System.Drawing.Point(25, 30)
        Me.dgLinea.MultiSelect = False
        Me.dgLinea.Name = "dgLinea"
        Me.dgLinea.RowHeadersVisible = False
        Me.dgLinea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLinea.Size = New System.Drawing.Size(1019, 215)
        Me.dgLinea.TabIndex = 44
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Visible = False
        Me.id.Width = 50
        '
        'cantidad
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.cantidad.FillWeight = 22.84264!
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Width = 150
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descripcion.FillWeight = 387.0073!
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        '
        'precio
        '
        Me.precio.FillWeight = 25.83185!
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.Width = 120
        '
        'Descuento
        '
        Me.Descuento.FillWeight = 7.159113!
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Width = 120
        '
        'total
        '
        Me.total.FillWeight = 7.159113!
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.Width = 120
        '
        'ConsProductoTableAdapter
        '
        Me.ConsProductoTableAdapter.ClearBeforeFill = True
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedor.DataSource = Me.ProveedorBindingSource
        Me.cmbProveedor.DisplayMember = "nombre"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(450, 86)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(398, 21)
        Me.cmbProveedor.TabIndex = 16
        Me.cmbProveedor.ValueMember = "Id"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.TallerDataSet
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'btnEliminarLinea
        '
        Me.btnEliminarLinea.Location = New System.Drawing.Point(1109, 527)
        Me.btnEliminarLinea.Name = "btnEliminarLinea"
        Me.btnEliminarLinea.Size = New System.Drawing.Size(102, 25)
        Me.btnEliminarLinea.TabIndex = 36
        Me.btnEliminarLinea.Text = "Eliminar Linea"
        '
        'ConfiguracionTableAdapter
        '
        Me.ConfiguracionTableAdapter.ClearBeforeFill = True
        '
        'FacturaRTableAdapter
        '
        Me.FacturaRTableAdapter.ClearBeforeFill = True
        '
        'cbContado
        '
        Me.cbContado.AutoSize = True
        Me.cbContado.Location = New System.Drawing.Point(624, 830)
        Me.cbContado.Name = "cbContado"
        Me.cbContado.Size = New System.Drawing.Size(116, 17)
        Me.cbContado.TabIndex = 58
        Me.cbContado.Text = "Pagada al contado"
        Me.cbContado.UseVisualStyleBackColor = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'LineaFacturaRTableAdapter
        '
        Me.LineaFacturaRTableAdapter.ClearBeforeFill = True
        '
        'btnAñadirProveedor
        '
        Me.btnAñadirProveedor.Location = New System.Drawing.Point(855, 86)
        Me.btnAñadirProveedor.Name = "btnAñadirProveedor"
        Me.btnAñadirProveedor.Size = New System.Drawing.Size(28, 21)
        Me.btnAñadirProveedor.TabIndex = 18
        Me.btnAñadirProveedor.Text = "+"
        '
        'frmFacturacionRecibidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1388, 882)
        Me.Controls.Add(Me.btnAñadirProveedor)
        Me.Controls.Add(Me.cbContado)
        Me.Controls.Add(Me.btnEliminarLinea)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtTotalFactura)
        Me.Controls.Add(Me.lblProveedor)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.lblAlbaran)
        Me.Controls.Add(Me.txtAlbaran)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbLineas)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.txtIVATotal)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txtBaseImponible)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dtpFechaFac)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFacturacionRecibidas"
        Me.Text = "Facturas Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLineas.ResumeLayout(False)
        CType(Me.dgLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTotalFactura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtIVATotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBaseImponible As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtAlbaran As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIVA As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFactura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpFechaFac As DateTimePicker
    Friend WithEvents lblAlbaran As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProveedor As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblFecha As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblIVA As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblFactura As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgArticulos As DataGridView
    Friend WithEvents btnAñadir As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDescuento As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblFamilia As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPVP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCantidad As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPVP As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDescuento As MetroFramework.Controls.MetroLabel
    Friend WithEvents gbLineas As GroupBox
    Friend WithEvents dgLinea As DataGridView
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents ConsProductoBindingSource As BindingSource
    Friend WithEvents ConsProductoTableAdapter As tallerDataSetTableAdapters.ConsProductoTableAdapter
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As tallerDataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents btnNuevoArticulo As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminarLinea As MetroFramework.Controls.MetroButton
    Friend WithEvents ConfiguracionTableAdapter As tallerDataSetTableAdapters.ConfiguracionTableAdapter
    Friend WithEvents FacturaRTableAdapter As tallerDataSetTableAdapters.FacturaRTableAdapter
    Friend WithEvents cbContado As CheckBox
    Friend WithEvents ProductoTableAdapter As tallerDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents LineaFacturaRTableAdapter As tallerDataSetTableAdapters.LineaFacturaRTableAdapter
    Friend WithEvents btnAñadirProveedor As MetroFramework.Controls.MetroButton
    Friend WithEvents FamiliaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents pvp As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblReferencia As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtFamilia As TextBox
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
