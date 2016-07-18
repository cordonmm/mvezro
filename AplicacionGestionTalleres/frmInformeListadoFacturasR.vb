Public Class frmInformeListadoFacturasR
    Private Sub frmInformeListadoFacturasR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TypeOf (Me.Tag) Is ArrayList Then
            If (Me.Tag(2) = 0) Then
                Me.consFacturaRTableAdapter.FillByFacturasRfecha(Me.tallerDataSet.consFacturaR, Convert.ToDateTime(Me.Tag(0)), Convert.ToDateTime(Me.Tag(1)))
            Else
                Me.consFacturaRTableAdapter.FillByFacturasRfechasProveedor(Me.tallerDataSet.consFacturaR, Convert.ToDateTime(Me.Tag(0)), Convert.ToDateTime(Me.Tag(1)), Me.Tag(2))
            End If

        End If
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class