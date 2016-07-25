Imports System.Drawing.Printing

Public Class frmListadoProveedores
    Private Sub frmListadoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'tallerDataSet.informeFacturaE' Puede moverla o quitarla según sea necesario.
        Me.informeFacturaETableAdapter.Fill(Me.tallerDataSet.informeFacturaE, 1)
        'TODO: esta línea de código carga datos en la tabla 'tallerDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.tallerDataSet.Proveedor)

        Dim pg As PageSettings = New PageSettings()
        pg.Margins.Left = 5
        pg.Margins.Right = 5
        pg.Margins.Top = 50
        pg.Margins.Bottom = 40
        ReportViewer1.SetPageSettings(pg)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class