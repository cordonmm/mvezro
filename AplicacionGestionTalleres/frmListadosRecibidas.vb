Public Class frmListadosRecibidas
    Private Sub frmListadosRecibidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.TallerDataSet.Proveedor)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim frmInformeListadoFacturasR As frmInformeListadoFacturasR
        frmInformeListadoFacturasR = New frmInformeListadoFacturasR
        Dim array As ArrayList
        array = New ArrayList
        array.Add(Me.fechaInicio.Value.ToShortDateString)
        array.Add(Me.fechaFin.Value.ToShortDateString)

        If todos.Checked Then
            array.Add(0)

            frmInformeListadoFacturasR.Tag = array
            frmInformeListadoFacturasR.Show()
        End If

        If idProveedor.Checked Then
            array.Add(cmbProveedor.SelectedValue)
            frmInformeListadoFacturasR.Tag = array
            frmInformeListadoFacturasR.Show()
        End If
    End Sub
End Class