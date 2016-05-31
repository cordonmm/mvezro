﻿

Public Class frmFacturacionEmitidas
    Dim dtFactura As tallerDataSet.FacturaEDataTable


    Private Sub frmFacturacionEmitidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.TallerDataSet.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.ConsProducto' Puede moverla o quitarla según sea necesario.
        Me.ConsProductoTableAdapter.Fill(Me.TallerDataSet.ConsProducto)
        Me.ConfiguracionTableAdapter1.Fill(Me.TallerDataSet.Configuracion)
        If (Me.Tag IsNot Nothing AndAlso IsNumeric(Me.Tag)) Then
            dtFactura = FacturaETableAdapter.GetDataBy2(Me.Tag)
            txtFactura.Text = dtFactura(0).numeroFactura
            txtVehiculo.Text = dtFactura(0).modeloVehiculo
            txtIVA.Text = dtFactura(0).iva
            txtBaseImponible.Text = dtFactura(0).baseImponible
            txtTotalFactura.Text = dtFactura(0).total
            dtpFechaFac.Value = dtFactura(0).fecha
            txtMatricula.Text = dtFactura(0).matricula
            txtKM.Text = dtFactura(0).km
            cmbCliente.SelectedValue = dtFactura(0).idCliente

            For Each row As tallerDataSet.LineaFacturaERow In LineaFacturaETableAdapter.GetDataByFac(dtFactura(0).Id).Rows
                dgLinea.Rows.Add(row.idProducto, row.Cantidad, ProductoTableAdapter.GetDataBy(row.idProducto)(0).Descripción, row.Precio, row.Total)
            Next

            Me.Text = "Guardar Factura"
        Else
            txtFactura.Text = Me.FacturaETableAdapter.numeroFac() + 1
        End If


        If (txtFactura.Text = "") Then
            txtFactura.Text = 1

        End If

        Dim drConfiguracion As tallerDataSet.ConfiguracionRow = Me.TallerDataSet.Configuracion.Rows(0)
        txtIVA.Text = drConfiguracion.iva
    End Sub

    Private Sub MetroTextBox13_TextChanged(sender As Object, e As EventArgs) Handles txtArticulo.TextChanged
        ConsProductoBindingSource.Filter = "descripción like '%" & txtArticulo.Text & "%' or referencia like '%" & txtArticulo.Text & "%' or familia like '%" & txtArticulo.Text & "%'"

    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Dim validar As String = ValidarLinea()
        If validar = "" Then
            Dim consProdRow As tallerDataSet.ConsProductoRow = TryCast(dgArticulos.SelectedRows(0).DataBoundItem.Row, tallerDataSet.ConsProductoRow)
            Dim precio = consProdRow.Precio
            If (txtPVP.Text <> "") Then
                precio = txtPVP.Text
            End If
            If (txtDescuento.Text <> "") Then
                precio = precio * (1 - (Convert.ToDouble(txtDescuento.Text) / 100))
            End If
            dgLinea.Rows.Add(consProdRow.Id, txtCantidad.Text, consProdRow.Descripción, precio, precio * txtCantidad.Text)
            actualizarTotales()

        Else
            MessageBox.Show(validar, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Function ValidarLinea() As String
        Dim res As String = ""
        If dgArticulos.SelectedRows(0).DataBoundItem.Row Is Nothing Then
            res &= "Elige un articulo" & vbCrLf
        End If
        If (txtCantidad.Text = "" Or Not IsNumeric(txtCantidad.Text)) Then
            res &= "Introduce una cantidad valida" & vbCrLf
        End If
        If txtPVP.Text <> "" Then
            If Not IsNumeric(txtPVP.Text) Then
                res &= "Introduce un PVP valido" & vbCrLf
            End If

        End If
        If txtDescuento.Text <> "" Then
            If Not IsNumeric(txtDescuento.Text) Then
                res &= "Introduce un descuento valido" & vbCrLf
            End If

        End If

        Return res


    End Function

    Private Sub btnEliminarLinea_Click(sender As Object, e As EventArgs) Handles btnEliminarLinea.Click
        If dgLinea.SelectedRows.Count <> 0 Then
            If (MessageBox.Show("¿Está seguro que desea eliminar la linea?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK) Then
                dgLinea.Rows.Remove(dgLinea.SelectedRows(0))
                actualizarTotales()
            End If

        End If
    End Sub

    Private Sub actualizarTotales()
        Dim baseImponible As Double = 0.0
        For Each row As DataGridViewRow In dgLinea.Rows
            baseImponible += row.Cells(4).Value
        Next
        If (Not IsNumeric(txtBaseImponible.Text)) Then
            txtBaseImponible.Text = "0.0"
        End If
        If (Not IsNumeric(txtIVA.Text)) Then
            txtIVA.Text = "0.0"
        End If


        txtBaseImponible.Text = baseImponible.ToString("###,###,##0.#0")

        txtIVATotal.Text = (baseImponible * (Convert.ToDouble(txtIVA.Text) / 100)).ToString("###,###,##0.#0")
        txtTotalFactura.Text = (baseImponible + (baseImponible * (Convert.ToDouble(txtIVA.Text) / 100))).ToString("###,###,##0.#0")
    End Sub

    Private Sub txtIVA_Click(sender As Object, e As EventArgs) Handles txtIVA.TextChanged
        actualizarTotales()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If (MessageBox.Show("¿Está seguro que desea cerrar la factura?, perderá los cambios que no haya guardado", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim val As String = validar()
        If (val = "") Then
            Try
                actualizarTotales()
                If (dtFactura IsNot Nothing) Then
                    dtFactura(0).fecha = dtpFechaFac.Value
                    dtFactura(0).idCliente = cmbCliente.SelectedValue
                    dtFactura(0).baseImponible = txtBaseImponible.Text
                    dtFactura(0).total = txtTotalFactura.Text
                    dtFactura(0).km = txtKM.Text
                    dtFactura(0).modeloVehiculo = txtVehiculo.Text
                    dtFactura(0).matricula = txtMatricula.Text

                    LineaFacturaETableAdapter.BorrarLineas(dtFactura(0).Id)
                    For Each row As DataGridViewRow In dgLinea.Rows
                        Me.TallerDataSet.LineaFacturaE.AddLineaFacturaERow(row.Cells(0).Value, row.Cells(1).Value, Convert.ToDouble(row.Cells(3).Value), Convert.ToDouble(row.Cells(4).Value), dtFactura(0).Id)

                    Next
                    Me.LineaFacturaETableAdapter.Update(Me.TallerDataSet.LineaFacturaE)
                    Me.FacturaETableAdapter.Update(dtFactura)
                    If (MessageBox.Show("Factura guardada correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK) Then
                        Me.Close()
                    End If


                Else

                    Me.TallerDataSet.FacturaE.AddFacturaERow(cmbCliente.SelectedValue, txtFactura.Text, Convert.ToDouble(txtBaseImponible.Text), Convert.ToDouble(txtTotalFactura.Text), cbContado.Checked, dtpFechaFac.Value, txtVehiculo.Text, txtMatricula.Text, txtKM.Text, txtIVA.Text)

                    Me.FacturaETableAdapter.Update(Me.TallerDataSet.FacturaE)
                    dtFactura = FacturaETableAdapter.GetDataBy2(txtFactura.Text)

                    For Each row As DataGridViewRow In dgLinea.Rows
                        Me.TallerDataSet.LineaFacturaE.AddLineaFacturaERow(row.Cells(0).Value, row.Cells(1).Value, Convert.ToDouble(row.Cells(3).Value), Convert.ToDouble(row.Cells(4).Value), dtFactura(0).Id)

                    Next
                    Me.LineaFacturaETableAdapter.Update(Me.TallerDataSet.LineaFacturaE)
                    dtFactura = Nothing

                    MessageBox.Show("Factura guardada correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                End If


            Catch ex As Exception
                MessageBox.Show("Ocurrio algun error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else
            MessageBox.Show(val, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub limpiar()

    End Sub

    Private Function validar() As String
        Dim res As String = ""
        Return res
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim frmBusquedaFacturaEmitidas As frmBusquedaFacturaEmitidas
        frmBusquedaFacturaEmitidas = New frmBusquedaFacturaEmitidas
        frmBusquedaFacturaEmitidas.Tag = Me
        frmBusquedaFacturaEmitidas.ShowDialog()
        If (frmBusquedaFacturaEmitidas.Tag IsNot Nothing AndAlso IsNumeric(frmBusquedaFacturaEmitidas.Tag)) Then
            dtFactura = FacturaETableAdapter.GetDataBy2(frmBusquedaFacturaEmitidas.Tag)
            txtFactura.Text = dtFactura(0).numeroFactura
            txtVehiculo.Text = dtFactura(0).modeloVehiculo
            txtIVA.Text = dtFactura(0).iva
            txtBaseImponible.Text = dtFactura(0).baseImponible
            txtTotalFactura.Text = dtFactura(0).total
            dtpFechaFac.Value = dtFactura(0).fecha
            txtMatricula.Text = dtFactura(0).matricula
            txtKM.Text = dtFactura(0).km
            cmbCliente.SelectedValue = dtFactura(0).idCliente
            For Each row As tallerDataSet.LineaFacturaERow In LineaFacturaETableAdapter.GetDataByFac(dtFactura(0).Id).Rows
                dgLinea.Rows.Add(row.idProducto, row.Cantidad, ProductoTableAdapter.GetDataBy(row.idProducto)(0).Descripción, row.Precio, row.Total)
            Next
            Me.Tag = frmBusquedaFacturaEmitidas.Tag
            Me.Text = "Guardar Factura"

        End If

    End Sub
End Class