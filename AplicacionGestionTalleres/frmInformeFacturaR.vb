Public Class frmInformeFacturaR
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'tallerDataSet.informeFacturaR' Puede moverla o quitarla según sea necesario.
        If bandera Then
            Me.informeFacturaRTableAdapter.Connection.ConnectionString = cadenaB
        Else
            Me.informeFacturaRTableAdapter.Connection.ConnectionString = cadenaA
        End If
        If IsNumeric(Me.Tag) Then
            Me.informeFacturaRTableAdapter.Fill(Me.tallerDataSet.informeFacturaR, Me.Tag)
        End If
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class