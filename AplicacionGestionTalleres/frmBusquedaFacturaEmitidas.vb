Public Class frmBusquedaFacturaEmitidas
    Private Sub frmMantenimientoClientesListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.ConsFacturaE' Puede moverla o quitarla según sea necesario.
        Me.ConsFacturaETableAdapter.Fill(Me.TallerDataSet.ConsFacturaE)


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (IsNumeric(txtBuscar.Text)) Then
            ConsFacturaEBindingSource.Filter = "numeroFactura = " & txtBuscar.Text & " or fecha like '%" & txtBuscar.Text & "%' or nombre like '%" & txtBuscar.Text & "%' or cif like '%" & txtBuscar.Text & "%' or email like '%" & txtBuscar.Text & "%'"
        Else
            ConsFacturaEBindingSource.Filter = "fecha like '%" & txtBuscar.Text & "%' or nombre like '%" & txtBuscar.Text & "%' or cif like '%" & txtBuscar.Text & "%' or email like '%" & txtBuscar.Text & "%'"
        End If
    End Sub

    Private Sub dgClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFacturaEmitidas.CellDoubleClick
        If TypeOf Me.Tag Is frmFacturacionEmitidas Then
            Me.Tag = TryCast(dgFacturaEmitidas.SelectedRows(0).DataBoundItem.Row, tallerDataSet.ConsFacturaERow).Id
            Me.Close()
        Else
            Dim frmFacturacionEmitidas As frmFacturacionEmitidas
            frmFacturacionEmitidas = New frmFacturacionEmitidas
            frmFacturacionEmitidas.Tag = TryCast(dgFacturaEmitidas.SelectedRows(0).DataBoundItem.Row, tallerDataSet.ConsFacturaERow).Id
            frmFacturacionEmitidas.ShowDialog()
            Me.ConsFacturaETableAdapter.Fill(Me.TallerDataSet.ConsFacturaE)

        End If



    End Sub

End Class