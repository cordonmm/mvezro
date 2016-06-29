Public Class frmInformeListadoFacturasE
    Private Sub frmInformeListadoFacturasE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TypeOf (Me.Tag) Is ArrayList Then
            If (Me.Tag(2) = 0) Then
                Me.informeFacturaETableAdapter.FillByFacturasEfecha(Me.tallerDataSet.informeFacturaE, Me.Tag(0), Me.Tag(1))

            Else
                Me.InformeFacturaETableAdapter.FillByFacturasEfechasCliente(Me.tallerDataSet.informeFacturaE, Me.Tag(0), Me.Tag(1), Me.Tag(2))
            End If

        End If
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class