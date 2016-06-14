Public Class frmListadosStock
    Private Sub frmListadosStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Familia' Puede moverla o quitarla según sea necesario.
        Me.FamiliaTableAdapter.Fill(Me.TallerDataSet.Familia)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If todos.Checked Then
            Dim frmListadoStockCompleto As frmListadoStockCompleto
            frmListadoStockCompleto = New frmListadoStockCompleto
            frmListadoStockCompleto.Show()
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Close()
    End Sub
End Class