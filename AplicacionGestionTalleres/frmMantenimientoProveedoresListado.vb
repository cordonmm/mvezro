Public Class frmMantenimientoProveedoresListado
    Private Sub frmMantenimientoProveedoresListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.TallerDataSet.Proveedor)

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        ProveedorBindingSource.Filter = "nombre like '%" & txtBuscar.Text & "%' or cif like '%" & txtBuscar.Text & "%' or provincia like '%" & txtBuscar.Text & "%' or población like '%" & txtBuscar.Text & "%'"


    End Sub

    Private Sub dgProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProveedores.CellDoubleClick
        Dim frmMantenimientoProveedoresAlta As frmMantenimientoProveedoresAlta
        frmMantenimientoProveedoresAlta = New frmMantenimientoProveedoresAlta
        frmMantenimientoProveedoresAlta.Tag = TryCast(dgProveedores.SelectedRows(0).DataBoundItem.Row, tallerDataSet.ProveedorRow).Id
        frmMantenimientoProveedoresAlta.ShowDialog()
        Me.ProveedorTableAdapter.Fill(Me.TallerDataSet.Proveedor)
    End Sub
End Class