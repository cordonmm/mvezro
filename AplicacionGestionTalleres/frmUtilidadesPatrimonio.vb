Public Class frmUtilidadesPatrimonio
    Dim dtPatrimonio As tallerDataSet.PatrimonioDataTable
    Private Sub frmUtilidadesPatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.TallerDataSet.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.PatrimonioTableAdapter.Fill(Me.TallerDataSet.Patrimonio)
        Me.ConfiguracionTableAdapter.Fill(Me.TallerDataSet.Configuracion)

        If (Me.Tag IsNot Nothing AndAlso IsNumeric(Me.Tag)) Then
            dtPatrimonio = PatrimonioTableAdapter.GetDataBy2(Me.Tag)
            txtFactura.Text = dtPatrimonio(0).numeroFactura
            txtConcepto.Text = dtPatrimonio(0).concepto
            txtIVA.Text = dtPatrimonio(0).iva
            txtImporte.Text = dtPatrimonio(0).importe
            cmbIdentificador.SelectedItem = dtPatrimonio(0).identificador
            cmbProveedor.SelectedValue = dtPatrimonio(0).idProveedor
            dtpFechaFac.Value = dtPatrimonio(0).fecha


            Me.Text = "Guardar Patrimonio"
        Else
            txtFactura.Text = Me.PatrimonioTableAdapter.numeroFac() + 1
        End If


        If (txtFactura.Text = "") Then
            txtFactura.Text = 1

        End If

        Dim drConfiguracion As tallerDataSet.ConfiguracionRow = Me.TallerDataSet.Configuracion.Rows(0)
        txtIVA.Text = drConfiguracion.iva

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim val As String = validar()
        If (val = "") Then
            Try
                If (dtPatrimonio IsNot Nothing) Then

                    dtPatrimonio(0).concepto = txtConcepto.Text
                    dtPatrimonio(0).iva = txtIVA.Text
                    dtPatrimonio(0).importe = txtImporte.Text
                    dtPatrimonio(0).identificador = cmbIdentificador.SelectedItem
                    dtPatrimonio(0).idProveedor = cmbProveedor.SelectedValue
                    dtPatrimonio(0).fecha = dtpFechaFac.Value.ToShortDateString
                    dtPatrimonio(0).total = (Convert.ToDouble(txtImporte.Text) * (1 + (Convert.ToDouble(txtIVA.Text) / 100)))

                    Me.PatrimonioTableAdapter.Update(dtPatrimonio)
                    If (MessageBox.Show("Patrimonio guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK) Then
                        Me.Close()
                    End If


                Else

                    Me.TallerDataSet.Patrimonio.AddPatrimonioRow(cmbProveedor.SelectedValue, txtFactura.Text, cmbIdentificador.SelectedItem, txtConcepto.Text, txtImporte.Text, (Convert.ToDouble(txtImporte.Text) * (1 + (Convert.ToDouble(txtIVA.Text) / 100))), txtIVA.Text, dtpFechaFac.Value.ToShortDateString)
                    Me.PatrimonioTableAdapter.Update(Me.TallerDataSet.Patrimonio)
                    MessageBox.Show("Patrimonio guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    If (TypeOf Me.Tag Is frmFacturacionEmitidas) Or (TypeOf Me.Tag Is frmFacturacionRecibidas) Then
                        Me.Close()
                    End If
                End If


            Catch ex As Exception
                MessageBox.Show("Ocurrio algun error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else
            MessageBox.Show(val, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub limpiar()
        txtConcepto.Text = ""

    End Sub

    Private Function validar() As String

        Dim res As String = ""

        If (Not IsNumeric(txtImporte.Text)) Then
            res &= "EL importe debe ser numérico" & vbCrLf
        End If
        If (Not IsNumeric(txtIVA.Text)) Then
            res &= "EL I.V.A costo debe ser numérico" & vbCrLf
        End If



        Return res
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If (MessageBox.Show("¿Está seguro que desea cerrar Patrimonio?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub
End Class