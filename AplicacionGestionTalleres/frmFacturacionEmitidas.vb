

Public Class frmFacturacionEmitidas
    Dim dtFactura As tallerDataSet.FacturaEDataTable


    Private Sub frmFacturacionEmitidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.TallerDataSet.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.ConsProducto' Puede moverla o quitarla según sea necesario.
        Me.ConsProductoTableAdapter.Fill(Me.TallerDataSet.ConsProducto)
        Me.ConfiguracionTableAdapter1.Fill(Me.TallerDataSet.Configuracion)
        If (bandera) Then
            Me.FacturaETableAdapter.Connection.ConnectionString = cadenaB
            Me.LineaFacturaETableAdapter.Connection.ConnectionString = cadenaB
        Else
            Me.FacturaETableAdapter.Connection.ConnectionString = cadenaA
            Me.LineaFacturaETableAdapter.Connection.ConnectionString = cadenaA
        End If
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
            If dtFactura(0).contado Then
                cbContado.Checked = True
            Else
                cbContado.Checked = False
            End If

            cmbCliente.SelectedValue = dtFactura(0).idCliente
            dgLinea.Rows.Clear()
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
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.Shift And e.KeyCode = Keys.B Then
            bandera = Not bandera
            If (bandera) Then
                frmFacturacionEmitidas_Load(Me, Nothing)
                principal.Icon = My.Resources.ico_car_thug


            Else
                frmFacturacionEmitidas_Load(Me, Nothing)
                principal.Icon = My.Resources.ico_car
            End If

        End If
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
            dgLinea.Rows.Add(consProdRow.Id, Convert.ToDouble(txtCantidad.Text), consProdRow.Descripción, precio, precio * txtCantidad.Text)
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
                    If (txtKM.Text = "") Then
                        txtKM.Text = "0.0"
                    End If
                    dtFactura(0).fecha = dtpFechaFac.Value.ToShortDateString
                    dtFactura(0).idCliente = cmbCliente.SelectedValue
                    dtFactura(0).baseImponible = txtBaseImponible.Text
                    dtFactura(0).total = txtTotalFactura.Text
                    dtFactura(0).km = txtKM.Text
                    dtFactura(0).modeloVehiculo = txtVehiculo.Text
                    dtFactura(0).matricula = txtMatricula.Text
                    If cbContado.Checked Then
                        dtFactura(0).contado = True
                    Else
                        dtFactura(0).contado = False
                    End If

                    LineaFacturaETableAdapter.BorrarLineas(dtFactura(0).Id)
                    For Each row As DataGridViewRow In dgLinea.Rows
                        Me.TallerDataSet.LineaFacturaE.AddLineaFacturaERow(row.Cells(0).Value, row.Cells(1).Value, Convert.ToDouble(row.Cells(3).Value), Convert.ToDouble(row.Cells(4).Value), dtFactura(0).Id)

                    Next
                    Me.LineaFacturaETableAdapter.Update(Me.TallerDataSet.LineaFacturaE)
                    Me.FacturaETableAdapter.Update(dtFactura)
                    MessageBox.Show("Factura guardada correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()


                Else
                    If (txtKM.Text = "") Then
                        txtKM.Text = "0.0"
                    End If
                    Me.TallerDataSet.FacturaE.AddFacturaERow(cmbCliente.SelectedValue, txtFactura.Text, Convert.ToDouble(txtBaseImponible.Text), Convert.ToDouble(txtTotalFactura.Text), cbContado.Checked, dtpFechaFac.Value.ToShortDateString, txtVehiculo.Text, txtMatricula.Text, txtKM.Text, txtIVA.Text)

                    Me.FacturaETableAdapter.Update(Me.TallerDataSet.FacturaE)
                    Me.FacturaETableAdapter.Fill(Me.TallerDataSet.FacturaE)
                    Dim idFactura As Integer = FacturaETableAdapter.GetId(txtFactura.Text)

                    For Each row As DataGridViewRow In dgLinea.Rows
                        Me.TallerDataSet.LineaFacturaE.AddLineaFacturaERow(row.Cells(0).Value, row.Cells(1).Value, Convert.ToDouble(row.Cells(3).Value), Convert.ToDouble(row.Cells(4).Value), idFactura)
                    Next
                    Me.LineaFacturaETableAdapter.Update(Me.TallerDataSet.LineaFacturaE)
                    If (MessageBox.Show("Factura guardada correctamente ,¿Desea imprimirla?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK) Then
                        Dim frmInformeFacturaE As frmInformeFacturaE
                        frmInformeFacturaE = New frmInformeFacturaE
                        frmInformeFacturaE.Tag = idFactura
                        frmInformeFacturaE.ShowDialog()
                    End If

                    limpiar()
                End If

                actualizarTotales()
            Catch ex As Exception
                MessageBox.Show("Ocurrio algun error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else
            MessageBox.Show(val, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub limpiar()
        txtVehiculo.Text = ""
        txtMatricula.Text = ""
        txtKM.Text = ""
        dgLinea.Rows.Clear()
        Me.FacturaETableAdapter.Fill(Me.TallerDataSet.FacturaE)
        txtFactura.Text = Me.FacturaETableAdapter.numeroFac() + 1

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
            dgLinea.Rows.Clear()
            For Each row As tallerDataSet.LineaFacturaERow In LineaFacturaETableAdapter.GetDataByFac(dtFactura(0).Id).Rows
                dgLinea.Rows.Add(row.idProducto, row.Cantidad, ProductoTableAdapter.GetDataBy(row.idProducto)(0).Descripción, row.Precio, row.Total)
            Next
            Me.Tag = frmBusquedaFacturaEmitidas.Tag
            Me.Text = "Guardar Factura"
            actualizarTotales()

        End If

    End Sub

    Private Sub btnNuevoArticulo_Click(sender As Object, e As EventArgs) Handles btnNuevoArticulo.Click
        Dim frmMantenimientoArticulosAlta As frmMantenimientoArticulosAlta
        frmMantenimientoArticulosAlta = New frmMantenimientoArticulosAlta
        frmMantenimientoArticulosAlta.Tag = Me
        frmMantenimientoArticulosAlta.ShowDialog()
        ConsProductoTableAdapter.Fill(Me.TallerDataSet.ConsProducto)
    End Sub

    Private Sub btnAñadirCliente_Click(sender As Object, e As EventArgs) Handles btnAñadirCliente.Click
        Dim frmMantenimientoClientesAlta As frmMantenimientoClientesAlta
        frmMantenimientoClientesAlta = New frmMantenimientoClientesAlta
        frmMantenimientoClientesAlta.Tag = Me
        frmMantenimientoClientesAlta.ShowDialog()
        ClienteTableAdapter.Fill(Me.TallerDataSet.Cliente)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dtFactura IsNot Nothing Then
            Dim frmInformeFacturaE As frmInformeFacturaE
            frmInformeFacturaE = New frmInformeFacturaE
            frmInformeFacturaE.Tag = dtFactura(0).Id
            frmInformeFacturaE.ShowDialog()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        LineaFacturaETableAdapter.BorrarLineas(dtFactura(0).Id)
        FacturaETableAdapter.Delete(dtFactura(0))
    End Sub
End Class