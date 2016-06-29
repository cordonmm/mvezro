Public Class frmInformeStock
    Private Sub frmInformeStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IsNumeric(Me.Tag) Then
            If (Me.Tag = 0) Then
                Me.ConsProductoTableAdapter.FillByInformeStockTodos(tallerDataSet.ConsProducto)
            Else
                Me.ConsProductoTableAdapter.FillByStockMinFamilia(tallerDataSet.ConsProducto, Me.Tag)
            End If

        End If
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class