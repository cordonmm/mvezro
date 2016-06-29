Public Class frmListadosEmitidas
    Private Sub frmListadosEmitidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.TallerDataSet.Cliente)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim frmInformeListadoFacturasE As frmInformeListadoFacturasE
        frmInformeListadoFacturasE = New frmInformeListadoFacturasE
        Dim array As ArrayList
        array = New ArrayList
        array.Add(Me.fechaInicio.Value.ToShortDateString)
        array.Add(Me.fechaFin.Value.ToShortDateString)

        If todos.Checked Then
            array.Add(0)
            frmInformeListadoFacturasE.Tag = array
            frmInformeListadoFacturasE.Show()
        End If

        If idCliente.Checked Then
            array.Add(cmbCliente.SelectedValue)
            frmInformeListadoFacturasE.Tag = array
            frmInformeListadoFacturasE.Show()
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Close()
    End Sub
End Class