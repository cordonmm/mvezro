﻿Imports System.Drawing.Printing

Public Class frmInformeFacturaE
    Private Sub frmInformeFacturaE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'tallerDataSet.informeFacturaE' Puede moverla o quitarla según sea necesario.
        If bandera Then
            Me.informeFacturaETableAdapter.Connection.ConnectionString = cadenaB
        Else
            Me.informeFacturaETableAdapter.Connection.ConnectionString = cadenaA
        End If
        If IsNumeric(Me.Tag) Then
            Me.informeFacturaETableAdapter.Fill(Me.tallerDataSet.informeFacturaE, Me.Tag)
        End If

        Dim pg As PageSettings = New PageSettings()
        pg.Margins.Left = 5
        pg.Margins.Right = 5
        pg.Margins.Top = 50
        pg.Margins.Bottom = 40
        ReportViewer1.SetPageSettings(pg)



        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class