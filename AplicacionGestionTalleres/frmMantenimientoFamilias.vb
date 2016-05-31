Public Class frmMantenimientoFamilias
    Private Sub frmMantenimientoFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Familia' Puede moverla o quitarla según sea necesario.
        Me.FamiliaTableAdapter.Fill(Me.TallerDataSet.Familia)


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim message As String
        message = validar()
        If (validar = "") Then
            Me.TallerDataSet.Familia.AddFamiliaRow(txtDescription.Text)
            Me.FamiliaTableAdapter.Update(Me.TallerDataSet.Familia)

        Else
            MessageBox.Show(message)
        End If
    End Sub

    Private Function validar() As String
        Dim res As String
        res = ""
        If txtDescription.Text = "" Then
            res = res & "Debe introducir una descripción" & vbCrLf
        End If
        Return res
    End Function

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgFamilias.SelectedRows.Count > 0 Then
            'you may want to add a confirmation message, and if the user confirms delete
            If MessageBox.Show("¿Está seguro que desea borrar la familia seleccionada?", "Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                TryCast(dgFamilias.SelectedRows(0).DataBoundItem.Row, tallerDataSet.FamiliaRow).Delete()
                Me.FamiliaTableAdapter.Update(Me.TallerDataSet.Familia)
                Me.FamiliaTableAdapter.Fill(Me.TallerDataSet.Familia)
            End If
        Else
                MessageBox.Show("Seleciona una familia para borrar")
        End If
    End Sub

    Private Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (IsNumeric(txtBuscar.Text)) Then
            FamiliaBindingSource.Filter = "id = " & txtBuscar.Text & " or descripcion like '%" & txtBuscar.Text & "%'"
        Else
            FamiliaBindingSource.Filter = "descripcion like '%" & txtBuscar.Text & "%'"

        End If



    End Sub

    Private Sub dgFamilias_CellContentClick(sender As Object, e As EventArgs) Handles dgFamilias.SelectionChanged

        If dgFamilias.SelectedRows.Count > 0 Then
            txtCode.Text = TryCast(dgFamilias.SelectedRows(0).DataBoundItem.Row, tallerDataSet.FamiliaRow).Id
            txtDescription.Text = TryCast(dgFamilias.SelectedRows(0).DataBoundItem.Row, tallerDataSet.FamiliaRow).descripcion

        End If
        'you may want to add a confirmation message, and if the user confirms delete


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgFamilias.SelectedRows.Count > 0 Then
            Dim id = TryCast(dgFamilias.SelectedRows(0).DataBoundItem.Row, tallerDataSet.FamiliaRow).Id
            Dim dtFamilia = Me.FamiliaTableAdapter.GetDataBy1(id)
            dtFamilia(0).descripcion = txtDescription.Text
            Me.FamiliaTableAdapter.Update(dtFamilia)
            Me.FamiliaTableAdapter.Fill(Me.TallerDataSet.Familia)
        End If
    End Sub

    Private Sub txtBuscar_Click_1(sender As Object, e As EventArgs) Handles txtBuscar.Click

    End Sub
End Class