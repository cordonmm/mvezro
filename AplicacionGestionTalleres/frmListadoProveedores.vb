﻿Public Class frmListadoProveedores
    Private Sub frmListadoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'tallerDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.tallerDataSet.Proveedor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class