<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiaSeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarCopiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurarCopiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamiliaArtículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaciónUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresupuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasEmitidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasRecibidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoArtículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoFacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoFacturasRecibidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoGastosPatrimonioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoArtículosStocMininoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReorganizaciónInformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónPatrimonioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaEntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AaaaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.FamiliaArtículosToolStripMenuItem, Me.PresupuestosToolStripMenuItem, Me.FacturaciónToolStripMenuItem, Me.InformesToolStripMenuItem, Me.UtilidadesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1201, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiaSeguridadToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CopiaSeguridadToolStripMenuItem
        '
        Me.CopiaSeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RealizarCopiaToolStripMenuItem, Me.RestaurarCopiaToolStripMenuItem})
        Me.CopiaSeguridadToolStripMenuItem.Name = "CopiaSeguridadToolStripMenuItem"
        Me.CopiaSeguridadToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CopiaSeguridadToolStripMenuItem.Text = "Copia Seguridad"
        '
        'RealizarCopiaToolStripMenuItem
        '
        Me.RealizarCopiaToolStripMenuItem.Name = "RealizarCopiaToolStripMenuItem"
        Me.RealizarCopiaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.RealizarCopiaToolStripMenuItem.Text = "Realizar Copia"
        '
        'RestaurarCopiaToolStripMenuItem
        '
        Me.RestaurarCopiaToolStripMenuItem.Name = "RestaurarCopiaToolStripMenuItem"
        Me.RestaurarCopiaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.RestaurarCopiaToolStripMenuItem.Text = "Restaurar Copia"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FamiliaArtículosToolStripMenuItem
        '
        Me.FamiliaArtículosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.ArtículosToolStripMenuItem, Me.ArtículosToolStripMenuItem1, Me.ProveedoresToolStripMenuItem, Me.ProveedoresToolStripMenuItem1})
        Me.FamiliaArtículosToolStripMenuItem.Name = "FamiliaArtículosToolStripMenuItem"
        Me.FamiliaArtículosToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.FamiliaArtículosToolStripMenuItem.Text = "Mantenimiento"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaUsuarioToolStripMenuItem, Me.ModificaciónUsuarioToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'AltaUsuarioToolStripMenuItem
        '
        Me.AltaUsuarioToolStripMenuItem.Name = "AltaUsuarioToolStripMenuItem"
        Me.AltaUsuarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaUsuarioToolStripMenuItem.Text = "Nuevo Usuario"
        '
        'ModificaciónUsuarioToolStripMenuItem
        '
        Me.ModificaciónUsuarioToolStripMenuItem.Name = "ModificaciónUsuarioToolStripMenuItem"
        Me.ModificaciónUsuarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificaciónUsuarioToolStripMenuItem.Text = "Listado"
        '
        'ArtículosToolStripMenuItem
        '
        Me.ArtículosToolStripMenuItem.Name = "ArtículosToolStripMenuItem"
        Me.ArtículosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ArtículosToolStripMenuItem.Text = "Familia Artículos"
        '
        'ArtículosToolStripMenuItem1
        '
        Me.ArtículosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem2, Me.ListadoToolStripMenuItem2})
        Me.ArtículosToolStripMenuItem1.Name = "ArtículosToolStripMenuItem1"
        Me.ArtículosToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.ArtículosToolStripMenuItem1.Text = "Artículos"
        '
        'AltaToolStripMenuItem2
        '
        Me.AltaToolStripMenuItem2.Name = "AltaToolStripMenuItem2"
        Me.AltaToolStripMenuItem2.Size = New System.Drawing.Size(154, 22)
        Me.AltaToolStripMenuItem2.Text = "Nuevo Artículo"
        '
        'ListadoToolStripMenuItem2
        '
        Me.ListadoToolStripMenuItem2.Name = "ListadoToolStripMenuItem2"
        Me.ListadoToolStripMenuItem2.Size = New System.Drawing.Size(154, 22)
        Me.ListadoToolStripMenuItem2.Text = "Listado"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem1, Me.ListadoToolStripMenuItem1})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Clientes"
        '
        'AltaToolStripMenuItem1
        '
        Me.AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        Me.AltaToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.AltaToolStripMenuItem1.Text = "Nuevo Cliente"
        '
        'ListadoToolStripMenuItem1
        '
        Me.ListadoToolStripMenuItem1.Name = "ListadoToolStripMenuItem1"
        Me.ListadoToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.ListadoToolStripMenuItem1.Text = "Listado"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.ListadoToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AltaToolStripMenuItem.Text = "Nuevo Proveedor"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'PresupuestosToolStripMenuItem
        '
        Me.PresupuestosToolStripMenuItem.Name = "PresupuestosToolStripMenuItem"
        Me.PresupuestosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.PresupuestosToolStripMenuItem.Text = "Presupuestos"
        '
        'FacturaciónToolStripMenuItem
        '
        Me.FacturaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturasEmitidasToolStripMenuItem, Me.FacturasRecibidasToolStripMenuItem})
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.FacturaciónToolStripMenuItem.Text = "Facturación"
        '
        'FacturasEmitidasToolStripMenuItem
        '
        Me.FacturasEmitidasToolStripMenuItem.Name = "FacturasEmitidasToolStripMenuItem"
        Me.FacturasEmitidasToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FacturasEmitidasToolStripMenuItem.Text = "Facturas Emitidas"
        '
        'FacturasRecibidasToolStripMenuItem
        '
        Me.FacturasRecibidasToolStripMenuItem.Name = "FacturasRecibidasToolStripMenuItem"
        Me.FacturasRecibidasToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FacturasRecibidasToolStripMenuItem.Text = "Facturas Recibidas"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoClientesToolStripMenuItem, Me.ListadoProveedoresToolStripMenuItem, Me.ListadoArtículosToolStripMenuItem, Me.ListadoFacturaciónToolStripMenuItem, Me.ListadoFacturasRecibidasToolStripMenuItem, Me.ListadoGastosPatrimonioToolStripMenuItem, Me.ListadoStockToolStripMenuItem, Me.ListadoArtículosStocMininoToolStripMenuItem, Me.ReorganizaciónInformesToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'ListadoClientesToolStripMenuItem
        '
        Me.ListadoClientesToolStripMenuItem.Name = "ListadoClientesToolStripMenuItem"
        Me.ListadoClientesToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ListadoClientesToolStripMenuItem.Text = "Listado Clientes"
        '
        'ListadoProveedoresToolStripMenuItem
        '
        Me.ListadoProveedoresToolStripMenuItem.Name = "ListadoProveedoresToolStripMenuItem"
        Me.ListadoProveedoresToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ListadoProveedoresToolStripMenuItem.Text = "Listado Proveedores"
        '
        'ListadoArtículosToolStripMenuItem
        '
        Me.ListadoArtículosToolStripMenuItem.Name = "ListadoArtículosToolStripMenuItem"
        Me.ListadoArtículosToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ListadoArtículosToolStripMenuItem.Text = "Listado Artículos"
        '
        'ListadoFacturaciónToolStripMenuItem
        '
        Me.ListadoFacturaciónToolStripMenuItem.Name = "ListadoFacturaciónToolStripMenuItem"
        Me.ListadoFacturaciónToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ListadoFacturaciónToolStripMenuItem.Text = "Listado Facturas Emitidas"
        '
        'ListadoFacturasRecibidasToolStripMenuItem
        '
        Me.ListadoFacturasRecibidasToolStripMenuItem.Name = "ListadoFacturasRecibidasToolStripMenuItem"
        Me.ListadoFacturasRecibidasToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ListadoFacturasRecibidasToolStripMenuItem.Text = "Listado Facturas Recibidas"
        '
        'ListadoGastosPatrimonioToolStripMenuItem
        '
        Me.ListadoGastosPatrimonioToolStripMenuItem.Name = "ListadoGastosPatrimonioToolStripMenuItem"
        Me.ListadoGastosPatrimonioToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ListadoGastosPatrimonioToolStripMenuItem.Text = "Listado Gastos Patrimonio"
        '
        'ListadoStockToolStripMenuItem
        '
        Me.ListadoStockToolStripMenuItem.Name = "ListadoStockToolStripMenuItem"
        Me.ListadoStockToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ListadoStockToolStripMenuItem.Text = "Listado Stock"
        '
        'ListadoArtículosStocMininoToolStripMenuItem
        '
        Me.ListadoArtículosStocMininoToolStripMenuItem.Name = "ListadoArtículosStocMininoToolStripMenuItem"
        Me.ListadoArtículosStocMininoToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ListadoArtículosStocMininoToolStripMenuItem.Text = "Listado Artículos Stock Minino"
        '
        'ReorganizaciónInformesToolStripMenuItem
        '
        Me.ReorganizaciónInformesToolStripMenuItem.Name = "ReorganizaciónInformesToolStripMenuItem"
        Me.ReorganizaciónInformesToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ReorganizaciónInformesToolStripMenuItem.Text = "Reorganización Informes"
        '
        'UtilidadesToolStripMenuItem
        '
        Me.UtilidadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónPatrimonioToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.UtilidadesToolStripMenuItem.Name = "UtilidadesToolStripMenuItem"
        Me.UtilidadesToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.UtilidadesToolStripMenuItem.Text = "Utilidades"
        '
        'GestiónPatrimonioToolStripMenuItem
        '
        Me.GestiónPatrimonioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaEntradaToolStripMenuItem, Me.ListadoToolStripMenuItem3})
        Me.GestiónPatrimonioToolStripMenuItem.Name = "GestiónPatrimonioToolStripMenuItem"
        Me.GestiónPatrimonioToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GestiónPatrimonioToolStripMenuItem.Text = "Gestión Patrimonio"
        '
        'NuevaEntradaToolStripMenuItem
        '
        Me.NuevaEntradaToolStripMenuItem.Name = "NuevaEntradaToolStripMenuItem"
        Me.NuevaEntradaToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NuevaEntradaToolStripMenuItem.Text = "Nueva entrada"
        '
        'ListadoToolStripMenuItem3
        '
        Me.ListadoToolStripMenuItem3.Name = "ListadoToolStripMenuItem3"
        Me.ListadoToolStripMenuItem3.Size = New System.Drawing.Size(151, 22)
        Me.ListadoToolStripMenuItem3.Text = "Listado"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'AaaaToolStripMenuItem
        '
        Me.AaaaToolStripMenuItem.Name = "AaaaToolStripMenuItem"
        Me.AaaaToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AaaaToolStripMenuItem.Text = "aaaa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(453, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "M. VEZRO, S.L."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(516, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SERVICIO INTEGRAL DEL AUTOMÓVIL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 279)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1238, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1241, 458)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Form1"
        Me.Text = "Gestión de Taller M. Vezro"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiaSeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RealizarCopiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestaurarCopiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FamiliaArtículosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtículosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificaciónUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtículosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PresupuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasEmitidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasRecibidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoArtículosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoFacturaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoFacturasRecibidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoGastosPatrimonioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoArtículosStocMininoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReorganizaciónInformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónPatrimonioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents NuevaEntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem3 As ToolStripMenuItem
    Public WithEvents MenuStrip As MenuStrip
    Friend WithEvents AaaaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
