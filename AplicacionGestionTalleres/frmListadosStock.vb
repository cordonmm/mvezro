Public Class frmListadosStock
    Private Sub frmListadosStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Familia' Puede moverla o quitarla según sea necesario.
        Me.FamiliaTableAdapter.Fill(Me.TallerDataSet.Familia)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim frmInformeStock As frmInformeStock
        frmInformeStock = New frmInformeStock

        If todos.Checked Then
            frmInformeStock.Tag = 0
            frmInformeStock.Show()
        End If

        If familia.Checked Then
            frmInformeStock.Tag = cmbFamilia.SelectedValue
            frmInformeStock.Show()
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Close()
    End Sub
End Class