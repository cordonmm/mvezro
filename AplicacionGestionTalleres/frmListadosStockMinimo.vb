Public Class frmListadosStockMinimo
    Private Sub frmListadosStockMinimo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Familia' Puede moverla o quitarla según sea necesario.
        Me.FamiliaTableAdapter.Fill(Me.TallerDataSet.Familia)

    End Sub
End Class