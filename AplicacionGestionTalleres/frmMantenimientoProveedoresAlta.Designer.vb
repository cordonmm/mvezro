<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoProveedoresAlta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoProveedoresAlta))
        Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.lblNombre = New MetroFramework.Controls.MetroLabel()
        Me.txtCIF = New MetroFramework.Controls.MetroTextBox()
        Me.lblCIF = New MetroFramework.Controls.MetroLabel()
        Me.txtDomicilio = New MetroFramework.Controls.MetroTextBox()
        Me.lblDomicilio = New MetroFramework.Controls.MetroLabel()
        Me.lblPoblacion = New MetroFramework.Controls.MetroLabel()
        Me.lblProvincia = New MetroFramework.Controls.MetroLabel()
        Me.txtCP = New MetroFramework.Controls.MetroTextBox()
        Me.lblCP = New MetroFramework.Controls.MetroLabel()
        Me.lblTlfFijo = New MetroFramework.Controls.MetroLabel()
        Me.lblTlfMovil = New MetroFramework.Controls.MetroLabel()
        Me.lblFax = New MetroFramework.Controls.MetroLabel()
        Me.lblEmail = New MetroFramework.Controls.MetroLabel()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.lblTlfPersonaContacto = New MetroFramework.Controls.MetroLabel()
        Me.txtPersonaContacto = New MetroFramework.Controls.MetroTextBox()
        Me.lblPersonaContacto = New MetroFramework.Controls.MetroLabel()
        Me.txtObservaciones = New MetroFramework.Controls.MetroTextBox()
        Me.lblObservaciones = New MetroFramework.Controls.MetroLabel()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtTlfFijo = New System.Windows.Forms.MaskedTextBox()
        Me.txtTlfMovil = New System.Windows.Forms.MaskedTextBox()
        Me.txtFax = New System.Windows.Forms.MaskedTextBox()
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ProveedorTableAdapter()
        Me.TableAdapterManager = New AplicacionGestionTalleres.tallerDataSetTableAdapters.TableAdapterManager()
        Me.txtTlfPersonaContacto = New System.Windows.Forms.MaskedTextBox()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(23, 102)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(112, 25)
        Me.txtCodigo.TabIndex = 100
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(23, 78)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 19)
        Me.lblCodigo.TabIndex = 32
        Me.lblCodigo.Text = "Código"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(176, 102)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(409, 25)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(176, 78)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(59, 19)
        Me.lblNombre.TabIndex = 34
        Me.lblNombre.Text = "Nombre"
        '
        'txtCIF
        '
        Me.txtCIF.Location = New System.Drawing.Point(617, 102)
        Me.txtCIF.Name = "txtCIF"
        Me.txtCIF.Size = New System.Drawing.Size(196, 25)
        Me.txtCIF.TabIndex = 3
        '
        'lblCIF
        '
        Me.lblCIF.AutoSize = True
        Me.lblCIF.Location = New System.Drawing.Point(617, 78)
        Me.lblCIF.Name = "lblCIF"
        Me.lblCIF.Size = New System.Drawing.Size(28, 19)
        Me.lblCIF.TabIndex = 36
        Me.lblCIF.Text = "CIF"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(23, 178)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(790, 25)
        Me.txtDomicilio.TabIndex = 5
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Location = New System.Drawing.Point(23, 154)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(64, 19)
        Me.lblDomicilio.TabIndex = 38
        Me.lblDomicilio.Text = "Domicilio"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(23, 230)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(66, 19)
        Me.lblPoblacion.TabIndex = 41
        Me.lblPoblacion.Text = "Población"
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(307, 230)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(62, 19)
        Me.lblProvincia.TabIndex = 43
        Me.lblProvincia.Text = "Provincia"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(617, 256)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(196, 25)
        Me.txtCP.TabIndex = 11
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(617, 232)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(91, 19)
        Me.lblCP.TabIndex = 44
        Me.lblCP.Text = "Codigo Postal"
        '
        'lblTlfFijo
        '
        Me.lblTlfFijo.AutoSize = True
        Me.lblTlfFijo.Location = New System.Drawing.Point(23, 317)
        Me.lblTlfFijo.Name = "lblTlfFijo"
        Me.lblTlfFijo.Size = New System.Drawing.Size(83, 19)
        Me.lblTlfFijo.TabIndex = 46
        Me.lblTlfFijo.Text = "Teléfono Fijo"
        '
        'lblTlfMovil
        '
        Me.lblTlfMovil.AutoSize = True
        Me.lblTlfMovil.Location = New System.Drawing.Point(158, 317)
        Me.lblTlfMovil.Name = "lblTlfMovil"
        Me.lblTlfMovil.Size = New System.Drawing.Size(94, 19)
        Me.lblTlfMovil.TabIndex = 48
        Me.lblTlfMovil.Text = "Teléfono Móvil"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(307, 317)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(28, 19)
        Me.lblFax.TabIndex = 50
        Me.lblFax.Text = "Fax"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(495, 319)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(47, 19)
        Me.lblEmail.TabIndex = 52
        Me.lblEmail.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(495, 343)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(318, 25)
        Me.txtEmail.TabIndex = 20
        '
        'lblTlfPersonaContacto
        '
        Me.lblTlfPersonaContacto.AutoSize = True
        Me.lblTlfPersonaContacto.Location = New System.Drawing.Point(597, 393)
        Me.lblTlfPersonaContacto.Name = "lblTlfPersonaContacto"
        Me.lblTlfPersonaContacto.Size = New System.Drawing.Size(165, 19)
        Me.lblTlfPersonaContacto.TabIndex = 56
        Me.lblTlfPersonaContacto.Text = "Teléfono Persona Contacto"
        '
        'txtPersonaContacto
        '
        Me.txtPersonaContacto.Location = New System.Drawing.Point(23, 417)
        Me.txtPersonaContacto.Name = "txtPersonaContacto"
        Me.txtPersonaContacto.Size = New System.Drawing.Size(544, 25)
        Me.txtPersonaContacto.TabIndex = 21
        '
        'lblPersonaContacto
        '
        Me.lblPersonaContacto.AutoSize = True
        Me.lblPersonaContacto.Location = New System.Drawing.Point(23, 393)
        Me.lblPersonaContacto.Name = "lblPersonaContacto"
        Me.lblPersonaContacto.Size = New System.Drawing.Size(128, 19)
        Me.lblPersonaContacto.TabIndex = 58
        Me.lblPersonaContacto.Text = "Persona de contacto"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(23, 488)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(641, 65)
        Me.txtObservaciones.TabIndex = 23
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(23, 462)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(95, 19)
        Me.lblObservaciones.TabIndex = 61
        Me.lblObservaciones.Text = "Observaciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(711, 528)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 25)
        Me.btnCancelar.TabIndex = 27
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(711, 488)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(102, 25)
        Me.btnAceptar.TabIndex = 25
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.Location = New System.Drawing.Point(23, 256)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(230, 20)
        Me.txtPoblacion.TabIndex = 7
        '
        'txtProvincia
        '
        Me.txtProvincia.Location = New System.Drawing.Point(307, 256)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(230, 20)
        Me.txtProvincia.TabIndex = 9
        '
        'txtTlfFijo
        '
        Me.txtTlfFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTlfFijo.Location = New System.Drawing.Point(23, 343)
        Me.txtTlfFijo.Mask = "000-000-000"
        Me.txtTlfFijo.Name = "txtTlfFijo"
        Me.txtTlfFijo.Size = New System.Drawing.Size(95, 23)
        Me.txtTlfFijo.TabIndex = 13
        Me.txtTlfFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTlfFijo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtTlfMovil
        '
        Me.txtTlfMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTlfMovil.Location = New System.Drawing.Point(158, 343)
        Me.txtTlfMovil.Mask = "000-000-000"
        Me.txtTlfMovil.Name = "txtTlfMovil"
        Me.txtTlfMovil.Size = New System.Drawing.Size(95, 23)
        Me.txtTlfMovil.TabIndex = 15
        Me.txtTlfMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTlfMovil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(307, 343)
        Me.txtFax.Mask = "000-000-000"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(95, 23)
        Me.txtFax.TabIndex = 17
        Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFax.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlbaranTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ConfiguracionTableAdapter = Nothing
        Me.TableAdapterManager.FacturaETableAdapter = Nothing
        Me.TableAdapterManager.FacturaRTableAdapter = Nothing
        Me.TableAdapterManager.FamiliaTableAdapter = Nothing
        Me.TableAdapterManager.LineaAlbaranTableAdapter = Nothing
        Me.TableAdapterManager.LineaFacturaETableAdapter = Nothing
        Me.TableAdapterManager.LineaFacturaRTableAdapter = Nothing
        Me.TableAdapterManager.LineaPresupuestoTableAdapter = Nothing
        Me.TableAdapterManager.PatrimonioTableAdapter = Nothing
        Me.TableAdapterManager.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.UpdateOrder = AplicacionGestionTalleres.tallerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtTlfPersonaContacto
        '
        Me.txtTlfPersonaContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTlfPersonaContacto.Location = New System.Drawing.Point(631, 419)
        Me.txtTlfPersonaContacto.Mask = "000-000-000"
        Me.txtTlfPersonaContacto.Name = "txtTlfPersonaContacto"
        Me.txtTlfPersonaContacto.Size = New System.Drawing.Size(95, 23)
        Me.txtTlfPersonaContacto.TabIndex = 22
        Me.txtTlfPersonaContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTlfPersonaContacto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'frmMantenimientoProveedoresAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(847, 612)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblCIF)
        Me.Controls.Add(Me.txtCIF)
        Me.Controls.Add(Me.lblDomicilio)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.lblPoblacion)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.lblTlfFijo)
        Me.Controls.Add(Me.txtTlfFijo)
        Me.Controls.Add(Me.lblTlfMovil)
        Me.Controls.Add(Me.txtTlfMovil)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblPersonaContacto)
        Me.Controls.Add(Me.txtPersonaContacto)
        Me.Controls.Add(Me.lblTlfPersonaContacto)
        Me.Controls.Add(Me.txtTlfPersonaContacto)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMantenimientoProveedoresAlta"
        Me.Text = "Nuevo Proveedor"
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNombre As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCIF As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCIF As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDomicilio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDomicilio As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPoblacion As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProvincia As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCP As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTlfFijo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTlfMovil As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblFax As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEmail As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblTlfPersonaContacto As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPersonaContacto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPersonaContacto As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtObservaciones As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblObservaciones As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtPoblacion As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtTlfFijo As MaskedTextBox
    Friend WithEvents txtTlfMovil As MaskedTextBox
    Friend WithEvents txtFax As MaskedTextBox
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As tallerDataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents TableAdapterManager As tallerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtTlfPersonaContacto As MaskedTextBox
End Class
