﻿Public Class frmInformeGastos
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'tallerDataSet.informeFacturaR' Puede moverla o quitarla según sea necesario.

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class