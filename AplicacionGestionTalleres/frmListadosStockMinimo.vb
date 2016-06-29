Public Class frmListadosStockMinimo
    Private Sub frmListadosStockMinimo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Familia' Puede moverla o quitarla según sea necesario.
        Me.FamiliaTableAdapter.Fill(Me.TallerDataSet.Familia)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim frmInformeStockMin As frmInformeStockMin
        frmInformeStockMin = New frmInformeStockMin

        If rbTodos.Checked Then
            frmInformeStockMin.Tag = 0
            frmInformeStockMin.Show()
        End If

        If rbIdFamilia.Checked Then
            frmInformeStockMin.Tag = cmbFamilia.SelectedValue
            frmInformeStockMin.Show()
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Close()
    End Sub
End Class