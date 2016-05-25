Public Class Form1
    Private Sub FamiliaArtículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliaArtículosToolStripMenuItem.Click

    End Sub

    Private Sub ArtículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtículosToolStripMenuItem.Click
        Dim frmMantenimientoFamilias As frmMantenimientoFamilias
        frmMantenimientoFamilias = New frmMantenimientoFamilias
        frmMantenimientoFamilias.Show()
    End Sub

    Private Sub PresupuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresupuestosToolStripMenuItem.Click
        Dim frmPresupuestos As frmPresupuestos
        frmPresupuestos = New frmPresupuestos
        frmPresupuestos.Show()
    End Sub

    Private Sub FacturasEmitidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasEmitidasToolStripMenuItem.Click
        Dim frmFacturacionEmitidas As frmFacturacionEmitidas
        frmFacturacionEmitidas = New frmFacturacionEmitidas
        frmFacturacionEmitidas.Show()
    End Sub

    Private Sub FacturasRecibidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasRecibidasToolStripMenuItem.Click
        Dim frmFacturacionRecibidas As frmFacturacionRecibidas
        frmFacturacionRecibidas = New frmFacturacionRecibidas
        frmFacturacionRecibidas.Show()
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        Dim frmUtilidadesConfiguracion As frmUtilidadesConfiguracion
        frmUtilidadesConfiguracion = New frmUtilidadesConfiguracion
        frmUtilidadesConfiguracion.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim frmAcercaDe As frmAcercaDe
        frmAcercaDe = New frmAcercaDe
        frmAcercaDe.Show()
    End Sub

    Private Sub AltaUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaUsuarioToolStripMenuItem.Click
        Dim frmMantenimientoUsuariosAlta As frmMantenimientoUsuariosAlta
        frmMantenimientoUsuariosAlta = New frmMantenimientoUsuariosAlta
        frmMantenimientoUsuariosAlta.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        Dim frmMantenimientoProveedoresListado As frmMantenimientoProveedoresListado
        frmMantenimientoProveedoresListado = New frmMantenimientoProveedoresListado
        frmMantenimientoProveedoresListado.Show()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim frmMantenimientoProveedoresAlta As frmMantenimientoProveedoresAlta
        frmMantenimientoProveedoresAlta = New frmMantenimientoProveedoresAlta
        frmMantenimientoProveedoresAlta.Show()
    End Sub

    Private Sub ListadoArtículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoArtículosToolStripMenuItem.Click
        Dim frmListadosArticulos As frmListadosArticulos
        frmListadosArticulos = New frmListadosArticulos
        frmListadosArticulos.Show()
    End Sub

    Private Sub ListadoFacturaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoFacturaciónToolStripMenuItem.Click
        Dim frmListadosEmitidas As frmListadosEmitidas
        frmListadosEmitidas = New frmListadosEmitidas
        frmListadosEmitidas.Show()
    End Sub

    Private Sub ListadoFacturasRecibidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoFacturasRecibidasToolStripMenuItem.Click
        Dim frmListadosRecibidas As frmListadosRecibidas
        frmListadosRecibidas = New frmListadosRecibidas
        frmListadosRecibidas.Show()
    End Sub

    Private Sub ListadoGastosPatrimonioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoGastosPatrimonioToolStripMenuItem.Click
        Dim frmListadosGastos As frmListadosGastos
        frmListadosGastos = New frmListadosGastos
        frmListadosGastos.Show()
    End Sub

    Private Sub ListadoStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoStockToolStripMenuItem.Click
        Dim frmListadosStock As frmListadosStock
        frmListadosStock = New frmListadosStock
        frmListadosStock.Show()
    End Sub

    Private Sub ListadoArtículosStocMininoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoArtículosStocMininoToolStripMenuItem.Click
        Dim frmListadosStockMinimo As frmListadosStockMinimo
        frmListadosStockMinimo = New frmListadosStockMinimo
        frmListadosStockMinimo.Show()
    End Sub

    Private Sub ReorganizaciónInformesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReorganizaciónInformesToolStripMenuItem.Click
        Dim frmListadosReorganizacion As frmListadosReorganizacion
        frmListadosReorganizacion = New frmListadosReorganizacion
        frmListadosReorganizacion.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem1.Click
        Dim frmMantenimientoClientesListado As frmMantenimientoClientesListado
        frmMantenimientoClientesListado = New frmMantenimientoClientesListado
        frmMantenimientoClientesListado.Show()
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        Dim frmMantenimientoClientesAlta As frmMantenimientoClientesAlta
        frmMantenimientoClientesAlta = New frmMantenimientoClientesAlta
        frmMantenimientoClientesAlta.Show()
    End Sub

    Private Sub AltaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem2.Click
        Dim frmMantenimientoArticulosAlta As frmMantenimientoArticulosAlta
        frmMantenimientoArticulosAlta = New frmMantenimientoArticulosAlta
        frmMantenimientoArticulosAlta.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem2.Click
        Dim frmMantenimientoArticulosListado As frmMantenimientoArticulosListado
        frmMantenimientoArticulosListado = New frmMantenimientoArticulosListado
        frmMantenimientoArticulosListado.Show()
    End Sub

    Private Sub NuevaEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaEntradaToolStripMenuItem.Click
        Dim frmUtilidadesPatrimonio As frmUtilidadesPatrimonio
        frmUtilidadesPatrimonio = New frmUtilidadesPatrimonio
        frmUtilidadesPatrimonio.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
