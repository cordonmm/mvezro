Public Class frmListadoStockCompleto
    Private Sub frmListadoStockCompleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'tallerDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.tallerDataSet.Producto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class