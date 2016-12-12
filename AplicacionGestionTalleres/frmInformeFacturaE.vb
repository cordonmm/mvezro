Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms

Public Class frmInformeFacturaE
    Private Sub frmInformeFacturaE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'tallerDataSet.informeFacturaE' Puede moverla o quitarla según sea necesario.
        If bandera Then
            Me.informeFacturaETableAdapter.Connection.ConnectionString = cadenaB
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionGestionTalleres.rpInformePresupuestoE.rdlc"

        Else
            Me.informeFacturaETableAdapter.Connection.ConnectionString = cadenaA
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionGestionTalleres.rpInformeFacturaE.rdlc"
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



        Dim imprimir As Impresion = New Impresion()

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter("ReportParameter", ""))
        Using cls As New Impresion
            cls.Print(Me.ReportViewer1.LocalReport)
        End Using


        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter("ReportParameter", "COPIA"))

        Using imprimir2 As New Impresion
            imprimir2.Print(Me.ReportViewer1.LocalReport)
        End Using


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class