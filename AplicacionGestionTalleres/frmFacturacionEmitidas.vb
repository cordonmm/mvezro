Public Class frmFacturacionEmitidas
    Private Sub frmFacturacionEmitidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.TallerDataSet.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.ConsProducto' Puede moverla o quitarla según sea necesario.
        Me.ConsProductoTableAdapter.Fill(Me.TallerDataSet.ConsProducto)

    End Sub

    Private Sub MetroTextBox13_TextChanged(sender As Object, e As EventArgs) Handles txtArticulo.TextChanged
        ConsProductoBindingSource.Filter = "descripción like '%" & txtArticulo.Text & "%' or referencia like '%" & txtArticulo.Text & "%' or familia like '%" & txtArticulo.Text & "%'"

    End Sub
End Class