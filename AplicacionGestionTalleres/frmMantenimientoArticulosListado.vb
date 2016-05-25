Public Class frmMantenimientoArticulosListado
    Private Sub frmMantenimientoArticulosListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.ConsProducto' Puede moverla o quitarla según sea necesario.
        Me.ConsProductoTableAdapter.Fill(Me.TallerDataSet.ConsProducto)


    End Sub

    Private Sub txtArticulo_Click(sender As Object, e As EventArgs) Handles txtArticulo.TextChanged

        ConsProductoBindingSource.Filter = "descripción like '%" & txtArticulo.Text & "%' or referencia like '%" & txtArticulo.Text & "%' or familia like '%" & txtArticulo.Text & "%'"


    End Sub

    Private Sub dgArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgArticulos.CellDoubleClick
        Dim frmMantenimientoArticulosAlta As frmMantenimientoArticulosAlta
        frmMantenimientoArticulosAlta = New frmMantenimientoArticulosAlta
        frmMantenimientoArticulosAlta.Tag = TryCast(dgArticulos.SelectedRows(0).DataBoundItem.Row, tallerDataSet.ConsProductoRow).Id
        frmMantenimientoArticulosAlta.ShowDialog()
        Me.ConsProductoTableAdapter.Fill(Me.TallerDataSet.ConsProducto)

    End Sub

End Class