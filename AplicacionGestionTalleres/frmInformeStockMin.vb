Imports System.Drawing.Printing

Public Class frmInformeStockMin
    Private Sub frmInformeStockMin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'tallerDataSet.Producto' Puede moverla o quitarla según sea necesario.

        If IsNumeric(Me.Tag) Then
            If (Me.Tag = 0) Then
                Me.ConsProductoTableAdapter.FillByAllProductosStockMin(tallerDataSet.ConsProducto)
            Else
                Me.ConsProductoTableAdapter.FillByStockMinFamilia(tallerDataSet.ConsProducto, Me.Tag)
            End If

        End If

        Dim pg As PageSettings = New PageSettings()
        pg.Margins.Left = 5
        pg.Margins.Right = 5
        pg.Margins.Top = 50
        pg.Margins.Bottom = 40
        ReportViewer1.SetPageSettings(pg)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class