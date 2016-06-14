Public Class frmUtilidadesPatrimonioListado
    Private Sub frmUtilidadesPatrimonioListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.consPatrimonio' Puede moverla o quitarla según sea necesario.
        Me.ConsPatrimonioTableAdapter.Fill(Me.TallerDataSet.consPatrimonio)
        dtpFechaInicio.Value = dtpFechaInicio.Value.AddMonths(-1)

    End Sub

    Private Sub MetroTextBox3_Click(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (IsNumeric(txtBuscar.Text)) Then
            ConsPatrimonioBindingSource.Filter = "nombre like '%" & txtBuscar.Text & "%' or concepto like '%" & txtBuscar.Text & "%' or identificador like '%" & txtBuscar.Text & "%' or numeroFactura = " & txtBuscar.Text & ""
        Else
            ConsPatrimonioBindingSource.Filter = "nombre like '%" & txtBuscar.Text & "%' or concepto like '%" & txtBuscar.Text & "%' or identificador like '%" & txtBuscar.Text & "%'"
        End If

    End Sub


    Private Sub dgPatrimonio_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPatrimonio.CellDoubleClick
        Dim frmUtilidadesPatrimonio As frmUtilidadesPatrimonio
        frmUtilidadesPatrimonio = New frmUtilidadesPatrimonio
        frmUtilidadesPatrimonio.Tag = TryCast(dgPatrimonio.SelectedRows(0).DataBoundItem.Row, tallerDataSet.consPatrimonioRow).Id
        frmUtilidadesPatrimonio.ShowDialog()
        Me.ConsPatrimonioTableAdapter.Fill(Me.TallerDataSet.consPatrimonio)
    End Sub

    Private Sub chkFiltrar_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltrar.CheckedChanged
        If chkFiltrar.Checked Then
            txtBuscar.Text = ""
            txtBuscar.ReadOnly = True
            ConsPatrimonioBindingSource.Filter = "fecha >='" & dtpFechaInicio.Value.ToShortDateString & "' and fecha <='" & dtpFechaFin.Value.ToShortDateString & "'"
        Else
            txtBuscar.ReadOnly = False
            ConsPatrimonioBindingSource.Filter = ""

        End If
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged, dtpFechaFin.ValueChanged

        If chkFiltrar.Checked Then
            txtBuscar.Text = ""
            ConsPatrimonioBindingSource.Filter = "fecha >='" & dtpFechaInicio.Value.ToShortDateString & "' and fecha <='" & dtpFechaFin.Value.ToShortDateString & "'"
        End If
    End Sub
End Class