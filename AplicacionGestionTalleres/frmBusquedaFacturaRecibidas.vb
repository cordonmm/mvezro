Public Class frmBusquedaFacturaRecibidas
    Private Sub frmMantenimientoClientesListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.ConsFacturaR' Puede moverla o quitarla según sea necesario.
        Me.ConsFacturaRTableAdapter.Fill(Me.TallerDataSet.ConsFacturaR)


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (IsNumeric(txtBuscar.Text)) Then
            ConsFacturaRBindingSource.Filter = "numeroFactura = " & txtBuscar.Text & " or fecha like '%" & txtBuscar.Text & "%' or nombre like '%" & txtBuscar.Text & "%' or cif like '%" & txtBuscar.Text & "%' or email like '%" & txtBuscar.Text & "%'"
        Else
            ConsFacturaRBindingSource.Filter = "fecha like '%" & txtBuscar.Text & "%' or nombre like '%" & txtBuscar.Text & "%' or cif like '%" & txtBuscar.Text & "%' or email like '%" & txtBuscar.Text & "%'"
        End If
    End Sub

    Private Sub dgClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFacturaRecibidas.CellDoubleClick
        If TypeOf Me.Tag Is frmFacturacionEmitidas Then
            Me.Tag = TryCast(dgFacturaRecibidas.SelectedRows(0).DataBoundItem.Row, tallerDataSet.ConsFacturaRRow).id
            Me.Close()
        Else
            Dim frmFacturacionRecibidas As frmFacturacionRecibidas
            frmFacturacionRecibidas = New frmFacturacionRecibidas
            frmFacturacionRecibidas.Tag = TryCast(dgFacturaRecibidas.SelectedRows(0).DataBoundItem.Row, tallerDataSet.ConsFacturaRRow).id
            frmFacturacionRecibidas.ShowDialog()
            Me.ConsFacturaRTableAdapter.Fill(Me.TallerDataSet.ConsFacturaR)

        End If



    End Sub

End Class