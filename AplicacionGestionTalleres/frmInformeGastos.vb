Public Class frmInformeGastos
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'tallerDataSet.consPatrimonio' Puede moverla o quitarla según sea necesario.

        Me.consPatrimonioTableAdapter.Fill(Me.tallerDataSet.consPatrimonio)
        consPatrimonioBindingSource.Filter = Me.Tag


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class