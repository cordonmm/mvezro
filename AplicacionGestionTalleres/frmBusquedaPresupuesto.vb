Public Class frmBusquedaPresupuesto
    Private Sub frmMantenimientoClientesListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet1.consPresupuesto' Puede moverla o quitarla según sea necesario.
        Me.ConsPresupuestoTableAdapter.Fill(Me.TallerDataSet1.consPresupuesto)

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (IsNumeric(txtBuscar.Text)) Then
            ConsPresupuestoBindingSource.Filter = "numeroFactura = " & txtBuscar.Text & " or fecha like '%" & txtBuscar.Text & "%' or nombre like '%" & txtBuscar.Text & "%' or cif like '%" & txtBuscar.Text & "%' or email like '%" & txtBuscar.Text & "%'"
        Else
            ConsPresupuestoBindingSource.Filter = "fecha like '%" & txtBuscar.Text & "%' or nombre like '%" & txtBuscar.Text & "%' or cif like '%" & txtBuscar.Text & "%' or email like '%" & txtBuscar.Text & "%'"
        End If
    End Sub

    Private Sub dgClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPresupuestos.CellDoubleClick
        If TypeOf Me.Tag Is frmPresupuesto Then
            Me.Tag = TryCast(dgPresupuestos.SelectedRows(0).DataBoundItem.Row, tallerDataSet.consPresupuestoRow).Id
            Me.Close()
        Else
            Dim frmPresupuesto As frmPresupuesto
            frmPresupuesto = New frmPresupuesto
            frmPresupuesto.Tag = TryCast(dgPresupuestos.SelectedRows(0).DataBoundItem.Row, tallerDataSet.consPresupuestoRow).Id
            frmPresupuesto.ShowDialog()
            Me.ConsPresupuestoTableAdapter.Fill(Me.TallerDataSet.consPresupuesto)

        End If



    End Sub

End Class