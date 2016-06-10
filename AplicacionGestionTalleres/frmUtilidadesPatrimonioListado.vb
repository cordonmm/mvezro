Public Class frmUtilidadesPatrimonioListado
    Private Sub frmUtilidadesPatrimonioListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.consPatrimonio' Puede moverla o quitarla según sea necesario.
        Me.ConsPatrimonioTableAdapter.Fill(Me.TallerDataSet.consPatrimonio)
        dtpFechaFin.Value = dtpFechaFin.Value.AddMonths(1)

    End Sub
End Class