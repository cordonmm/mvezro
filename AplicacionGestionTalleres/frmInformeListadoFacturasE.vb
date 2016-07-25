Imports System.Drawing.Printing

Public Class frmInformeListadoFacturasE
    Private Sub frmInformeListadoFacturasE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TypeOf (Me.Tag) Is ArrayList Then
            If (Me.Tag(2) = 0) Then
                Me.ConsFacturaETableAdapter.FillByFacturaEFecha(Me.tallerDataSet.ConsFacturaE, Convert.ToDateTime(Me.Tag(0)), Convert.ToDateTime(Me.Tag(1)))

            Else
                Me.ConsFacturaETableAdapter.FillByFacturaEfechasCliente(Me.tallerDataSet.ConsFacturaE, Convert.ToDateTime(Me.Tag(0)), Convert.ToDateTime(Me.Tag(1)), Me.Tag(2))
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