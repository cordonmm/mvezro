Imports System.Net.Mail

Public Class frmMantenimientoProveedoresAlta

    Dim dtProveedor As tallerDataSet.ProveedorDataTable



    Private Sub frmMantenimientoProveedoresAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.TallerDataSet.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Cliente' Puede moverla o quitarla según sea necesario.

        txtPoblacion.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtPoblacion.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtProvincia.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtProvincia.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Dim provincia As New AutoCompleteStringCollection
        Dim poblacion As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To Me.TallerDataSet.Proveedor.Rows.Count - 1
            provincia.Add(Me.TallerDataSet.Proveedor.Rows(i)("provincia").ToString())
            poblacion.Add(Me.TallerDataSet.Proveedor.Rows(i)("población").ToString())
        Next
        txtProvincia.AutoCompleteCustomSource = provincia
        txtPoblacion.AutoCompleteCustomSource = poblacion
        If (Me.Tag IsNot Nothing AndAlso IsNumeric(Me.Tag)) Then
            dtProveedor = ProveedorTableAdapter.GetDataBy(Me.Tag)
            txtCodigo.Text = dtProveedor(0).Id
            txtNombre.Text = dtProveedor(0).nombre
            txtCIF.Text = dtProveedor(0).cif
            txtDomicilio.Text = dtProveedor(0).domicilio
            txtPoblacion.Text = dtProveedor(0).población
            txtProvincia.Text = dtProveedor(0).provincia
            txtCP.Text = dtProveedor(0).cp
            txtEmail.Text = dtProveedor(0).email
            txtTlfFijo.Text = dtProveedor(0).telefonoFijo
            txtTlfMovil.Text = dtProveedor(0).telefonoMovil
            txtFax.Text = dtProveedor(0).fax
            txtObservaciones.Text = dtProveedor(0).observaciones
            txtPersonaContacto.Text = dtProveedor(0).contacto
            txtTlfPersonaContacto.Text = dtProveedor(0).telefonoContacto
            Me.Text = "Guardar Proveedor"
        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim val As String = validar()
        If (val = "") Then
            Try
                If (dtProveedor IsNot Nothing) Then
                    dtProveedor(0).nombre = txtNombre.Text
                    dtProveedor(0).cif = txtCIF.Text
                    dtProveedor(0).domicilio = txtDomicilio.Text
                    dtProveedor(0).población = txtPoblacion.Text
                    dtProveedor(0).provincia = txtProvincia.Text
                    dtProveedor(0).email = txtEmail.Text
                    dtProveedor(0).cp = txtCP.Text
                    dtProveedor(0).telefonoFijo = txtTlfFijo.Text
                    dtProveedor(0).telefonoMovil = txtTlfMovil.Text
                    dtProveedor(0).fax = txtFax.Text
                    dtProveedor(0).observaciones = txtObservaciones.Text
                    dtProveedor(0).contacto = txtPersonaContacto.Text
                    dtProveedor(0).telefonoContacto = txtTlfPersonaContacto.Text
                    Me.ProveedorTableAdapter.Update(dtProveedor)
                    If (MessageBox.Show("Proveedor guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK) Then
                        Me.Close()
                    End If


                Else
                    If (txtTlfFijo.Text = "") Then
                        txtTlfFijo.Text = 0
                    End If
                    If txtFax.Text = "" Then
                        txtFax.Text = 0

                    End If

                    If txtTlfPersonaContacto.Text = "" Then
                        txtTlfPersonaContacto.Text = 0

                    End If
                    Me.TallerDataSet.Proveedor.AddProveedorRow(txtNombre.Text, txtCIF.Text, txtDomicilio.Text, txtPoblacion.Text, txtProvincia.Text, txtCP.Text, txtTlfFijo.Text, txtTlfMovil.Text, txtFax.Text, txtObservaciones.Text, txtEmail.Text, txtPersonaContacto.Text, txtTlfPersonaContacto.Text)
                    Me.ProveedorTableAdapter.Update(Me.TallerDataSet.Proveedor)
                    MessageBox.Show("Proveedor guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        txtNombre.Text = ""
        txtCIF.Text = ""
        txtDomicilio.Text = ""
        txtPoblacion.Text = ""
        txtProvincia.Text = ""
        txtCP.Text = ""
        txtEmail.Text = ""
        txtTlfFijo.Text = ""
        txtTlfMovil.Text = ""
        txtFax.Text = ""
        txtObservaciones.Text = ""
        txtPersonaContacto.Text = ""
        txtTlfPersonaContacto.Text = ""


    End Sub

    Private Function validar() As String

        Dim res As String = ""

        If (txtCIF.Text = "") Then
            res &= "El DNI/CIF del cliente es obligatorio" & vbCrLf
        End If
        If (txtNombre.Text = "") Then
            res &= "El nombre del cliente es obligatorio" & vbCrLf
        End If
        If (txtTlfMovil.Text = "") Then
            res &= "El teléfono del cliente es obligatorio" & vbCrLf
        End If
        Dim address As MailAddress
        Try
            address = New MailAddress(txtEmail.Text)
        Catch ex As Exception
            res &= "Debe introducir un correo válido" & vbCrLf
        End Try



        Return res
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If (MessageBox.Show("¿Está seguro que desea cerrar el formulario?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub
End Class