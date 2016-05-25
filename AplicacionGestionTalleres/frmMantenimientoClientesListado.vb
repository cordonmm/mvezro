Public Class frmMantenimientoClientesListado
    Private Sub frmMantenimientoClientesListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.TallerDataSet.Cliente)

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ClienteBindingSource.Filter = "nombre like '%" & txtBuscar.Text & "%' or cif like '%" & txtBuscar.Text & "%' or provincia like '%" & txtBuscar.Text & "%' or población like '%" & txtBuscar.Text & "%'"

    End Sub

    Private Sub dgClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCliente.CellDoubleClick
        Dim frmMantenimientoClientesAlta As frmMantenimientoClientesAlta
        frmMantenimientoClientesAlta = New frmMantenimientoClientesAlta
        frmMantenimientoClientesAlta.Tag = TryCast(dgCliente.SelectedRows(0).DataBoundItem.Row, tallerDataSet.ClienteRow).Id
        frmMantenimientoClientesAlta.ShowDialog()
        Me.ClienteTableAdapter.Fill(Me.TallerDataSet.Cliente)

    End Sub


End Class