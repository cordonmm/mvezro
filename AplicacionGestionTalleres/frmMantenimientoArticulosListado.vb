Public Class frmMantenimientoArticulosListado
    Private Sub frmMantenimientoArticulosListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.ConsProducto' Puede moverla o quitarla según sea necesario.
        Me.ConsProductoTableAdapter.Fill(Me.TallerDataSet.ConsProducto)


    End Sub


    Private Sub MetroTextBox13_TextChanged(sender As Object, e As EventArgs) Handles txtFamilia.TextChanged, txtReferencia.TextChanged

        ConsProductoBindingSource.Filter = "referencia like '%" & txtReferencia.Text & "%' and familia like '%" & txtFamilia.Text & "%'"

    End Sub

    Private Sub dgArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgArticulos.CellDoubleClick
        Dim frmMantenimientoArticulosAlta As frmMantenimientoArticulosAlta
        frmMantenimientoArticulosAlta = New frmMantenimientoArticulosAlta
        frmMantenimientoArticulosAlta.Tag = TryCast(dgArticulos.SelectedRows(0).DataBoundItem.Row, tallerDataSet.ConsProductoRow).Id
        frmMantenimientoArticulosAlta.ShowDialog()
        Me.ConsProductoTableAdapter.Fill(Me.TallerDataSet.ConsProducto)

    End Sub

    Private Sub txtArticulo_Click_1(sender As Object, e As EventArgs) Handles txtFamilia.Click

    End Sub
End Class