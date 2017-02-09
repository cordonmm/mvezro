Public Class frmMantenimientoArticulosAlta
    Dim dtProducto As tallerDataSet.ProductoDataTable
    Private Sub frmMantenimientoArticulosAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.TallerDataSet.Producto)
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Familia' Puede moverla o quitarla según sea necesario.
        Me.FamiliaTableAdapter.Fill(Me.TallerDataSet.Familia)
        If (Me.Tag IsNot Nothing AndAlso IsNumeric(Me.Tag)) Then
            dtProducto = ProductoTableAdapter.GetDataBy(Me.Tag)
            txtCodigo.Text = dtProducto(0).Codigo
            txtReferencia.Text = dtProducto(0).Referencia
            txtDescripcion.Text = dtProducto(0).Descripción
            txtPrecioCosto.Text = dtProducto(0).Precio
            txtObservaciones.Text = dtProducto(0).Observaciones
            txtStock.Text = dtProducto(0).Stock
            txtPVP.Text = dtProducto(0).pvp
            cmbFamilia.SelectedValue = dtProducto(0).idFamilia
            chkObsoleto.Checked = dtProducto(0).obsoleto
            Me.Text = "Guardar Articulo"
            End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim val As String = validar()
        If (val = "") Then
            Try
                If (dtProducto IsNot Nothing) Then
                    dtProducto(0).Codigo = txtCodigo.Text
                    dtProducto(0).Referencia = txtReferencia.Text
                    dtProducto(0).Descripción = txtDescripcion.Text
                    dtProducto(0).Precio = txtPrecioCosto.Text
                    dtProducto(0).Observaciones = txtObservaciones.Text
                    dtProducto(0).Stock = txtStock.Text
                    dtProducto(0).pvp = txtPVP.Text
                    dtProducto(0).idFamilia = cmbFamilia.SelectedValue
                    dtProducto(0).obsoleto = chkObsoleto.Checked
                    Me.ProductoTableAdapter.Update(dtProducto)
                    If (MessageBox.Show("Articulo guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK) Then
                        Me.Close()
                    End If


                Else
                    Me.TallerDataSet.Producto.AddProductoRow(txtCodigo.Text, txtReferencia.Text, txtDescripcion.Text, Convert.ToDouble(txtPrecioCosto.Text), txtObservaciones.Text, cmbFamilia.SelectedValue, Convert.ToInt32(txtStock.Text), Convert.ToDouble(txtPVP.Text), chkObsoleto.Checked)
                    Me.ProductoTableAdapter.Update(Me.TallerDataSet.Producto)
                    MessageBox.Show("Articulo guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        txtCodigo.Text = ""
        txtReferencia.Text = ""
        txtDescripcion.Text = ""
        txtPrecioCosto.Text = ""
        txtObservaciones.Text = ""
        txtStock.Text = ""
        txtPVP.Text = ""
    End Sub

    Private Function validar() As String

        Dim res As String = ""
        If (Not IsNumeric(txtPrecioCosto.Text)) Then
            res &= "EL precio costo debe ser numérico" & vbCrLf
        End If
        If (Not IsNumeric(txtPVP.Text)) Then
            res &= "EL precio venta debe ser numérico" & vbCrLf
        End If
        If (Not IsNumeric(txtStock.Text)) Then
            res &= "EL stock debe ser numérico"
        End If

        Return res
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbFamilia_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbFamilia.KeyDown
        If e.KeyCode = Keys.Enter Then
            FamiliaBindingSource.Filter = "descripcion like '%" & cmbFamilia.Text & "%'"
        End If

    End Sub

    Private Sub lblPrecioCosto_Click(sender As Object, e As EventArgs) Handles lblPrecioCosto.Click

    End Sub
End Class