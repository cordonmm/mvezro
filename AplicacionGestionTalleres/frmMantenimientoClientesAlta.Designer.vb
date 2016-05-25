<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMantenimientoClientesAlta
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.lblObservaciones = New MetroFramework.Controls.MetroLabel()
        Me.txtObservaciones = New MetroFramework.Controls.MetroTextBox()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.lblEmail = New MetroFramework.Controls.MetroLabel()
        Me.lblFax = New MetroFramework.Controls.MetroLabel()
        Me.lblTlfMovil = New MetroFramework.Controls.MetroLabel()
        Me.lblTlfFijo = New MetroFramework.Controls.MetroLabel()
        Me.txtCP = New MetroFramework.Controls.MetroTextBox()
        Me.lblCP = New MetroFramework.Controls.MetroLabel()
        Me.lblProvincia = New MetroFramework.Controls.MetroLabel()
        Me.lblPoblacion = New MetroFramework.Controls.MetroLabel()
        Me.txtDomicilio = New MetroFramework.Controls.MetroTextBox()
        Me.lblDomicilio = New MetroFramework.Controls.MetroLabel()
        Me.txtDNI = New MetroFramework.Controls.MetroTextBox()
        Me.lblDNI = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.lblNombre = New MetroFramework.Controls.MetroLabel()
        Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.txtTlfFijo = New System.Windows.Forms.MaskedTextBox()
        Me.txtTlfMovil = New System.Windows.Forms.MaskedTextBox()
        Me.txtFax = New System.Windows.Forms.MaskedTextBox()
        Me.TallerDataSet = New AplicacionGestionTalleres.tallerDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New AplicacionGestionTalleres.tallerDataSetTableAdapters.ClienteTableAdapter()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(711, 459)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 25)
        Me.btnCancelar.TabIndex = 93
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(711, 419)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(102, 25)
        Me.btnAceptar.TabIndex = 92
        Me.btnAceptar.Text = "Aceptar"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(23, 393)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(95, 19)
        Me.lblObservaciones.TabIndex = 91
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(23, 419)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(641, 65)
        Me.txtObservaciones.TabIndex = 90
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(552, 341)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(261, 25)
        Me.txtEmail.TabIndex = 85
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(552, 317)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(47, 19)
        Me.lblEmail.TabIndex = 82
        Me.lblEmail.Text = "E-mail"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(307, 317)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(28, 19)
        Me.lblFax.TabIndex = 81
        Me.lblFax.Text = "Fax"
        '
        'lblTlfMovil
        '
        Me.lblTlfMovil.AutoSize = True
        Me.lblTlfMovil.Location = New System.Drawing.Point(165, 317)
        Me.lblTlfMovil.Name = "lblTlfMovil"
        Me.lblTlfMovil.Size = New System.Drawing.Size(104, 19)
        Me.lblTlfMovil.TabIndex = 80
        Me.lblTlfMovil.Text = "Teléfono Móvil *"
        '
        'lblTlfFijo
        '
        Me.lblTlfFijo.AutoSize = True
        Me.lblTlfFijo.Location = New System.Drawing.Point(23, 317)
        Me.lblTlfFijo.Name = "lblTlfFijo"
        Me.lblTlfFijo.Size = New System.Drawing.Size(83, 19)
        Me.lblTlfFijo.TabIndex = 78
        Me.lblTlfFijo.Text = "Teléfono Fijo"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(552, 256)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(149, 25)
        Me.txtCP.TabIndex = 77
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(552, 234)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(91, 19)
        Me.lblCP.TabIndex = 76
        Me.lblCP.Text = "Código Postal"
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(307, 230)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(62, 19)
        Me.lblProvincia.TabIndex = 75
        Me.lblProvincia.Text = "Provincia"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(23, 230)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(66, 19)
        Me.lblPoblacion.TabIndex = 73
        Me.lblPoblacion.Text = "Población"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(23, 178)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(790, 25)
        Me.txtDomicilio.TabIndex = 71
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Location = New System.Drawing.Point(23, 154)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(64, 19)
        Me.lblDomicilio.TabIndex = 70
        Me.lblDomicilio.Text = "Domicilio"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(617, 102)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(196, 25)
        Me.txtDNI.TabIndex = 69
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(617, 78)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(55, 19)
        Me.lblDNI.TabIndex = 68
        Me.lblDNI.Text = "CIF/DNI"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(176, 102)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(409, 25)
        Me.txtNombre.TabIndex = 67
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(176, 78)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 19)
        Me.lblNombre.TabIndex = 66
        Me.lblNombre.Text = "Nombre *"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(23, 102)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 25)
        Me.txtCodigo.TabIndex = 65
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(23, 78)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(63, 19)
        Me.lblCodigo.TabIndex = 64
        Me.lblCodigo.Text = "Código *"
        '
        'txtProvincia
        '
        Me.txtProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtProvincia.Location = New System.Drawing.Point(307, 256)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(164, 20)
        Me.txtProvincia.TabIndex = 73
        '
        'txtPoblacion
        '
        Me.txtPoblacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPoblacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPoblacion.Location = New System.Drawing.Point(23, 256)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(237, 20)
        Me.txtPoblacion.TabIndex = 72
        '
        'txtTlfFijo
        '
        Me.txtTlfFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTlfFijo.Location = New System.Drawing.Point(23, 341)
        Me.txtTlfFijo.Mask = "000-000-000"
        Me.txtTlfFijo.Name = "txtTlfFijo"
        Me.txtTlfFijo.Size = New System.Drawing.Size(95, 23)
        Me.txtTlfFijo.TabIndex = 82
        Me.txtTlfFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTlfFijo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtTlfMovil
        '
        Me.txtTlfMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTlfMovil.Location = New System.Drawing.Point(165, 341)
        Me.txtTlfMovil.Mask = "000-000-000"
        Me.txtTlfMovil.Name = "txtTlfMovil"
        Me.txtTlfMovil.Size = New System.Drawing.Size(95, 23)
        Me.txtTlfMovil.TabIndex = 83
        Me.txtTlfMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTlfMovil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(307, 341)
        Me.txtFax.Mask = "000-000-000"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(95, 23)
        Me.txtFax.TabIndex = 94
        Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFax.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "tallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'frmMantenimientoClientesAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(854, 533)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.txtDNI)
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
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "frmMantenimientoClientesAlta"
        Me.Text = "Nuevo Cliente"
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Friend WithEvents lblObservaciones As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtObservaciones As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEmail As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblFax As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTlfMovil As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTlfFijo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCP As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProvincia As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPoblacion As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDomicilio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDomicilio As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDNI As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDNI As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNombre As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtPoblacion As TextBox
    Friend WithEvents TallerDataSet As tallerDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As tallerDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents txtTlfFijo As MaskedTextBox
    Friend WithEvents txtTlfMovil As MaskedTextBox
    Friend WithEvents txtFax As MaskedTextBox
End Class
