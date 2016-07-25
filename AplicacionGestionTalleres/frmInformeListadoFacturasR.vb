Imports System.Drawing.Printing

Public Class frmInformeListadoFacturasR
    Private Sub frmInformeListadoFacturasR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TypeOf (Me.Tag) Is ArrayList Then
            If (Me.Tag(2) = 0) Then
                Me.ConsFacturaRTableAdapter.FillByFacturasRfecha(Me.tallerDataSet.ConsFacturaR, Convert.ToDateTime(Me.Tag(0)), Convert.ToDateTime(Me.Tag(1)))
            Else
                Me.ConsFacturaRTableAdapter.FillByFacturasRfechasProveedor(Me.tallerDataSet.ConsFacturaR, Convert.ToDateTime(Me.Tag(0)), Convert.ToDateTime(Me.Tag(1)), Me.Tag(2))
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