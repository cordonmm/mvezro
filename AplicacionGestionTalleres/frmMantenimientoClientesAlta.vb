Imports System.Net.Mail

Public Class frmMantenimientoClientesAlta
    Dim dtCliente As tallerDataSet.ClienteDataTable
    Private Sub frmMantenimientoClientesAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.TallerDataSet.Cliente)
        txtPoblacion.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtPoblacion.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtProvincia.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtProvincia.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Dim provincia As New AutoCompleteStringCollection
        Dim poblacion As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To Me.TallerDataSet.Cliente.Rows.Count - 1
            provincia.Add(Me.TallerDataSet.Cliente.Rows(i)("provincia").ToString())
            poblacion.Add(Me.TallerDataSet.Cliente.Rows(i)("población").ToString())
        Next
        txtProvincia.AutoCompleteCustomSource = provincia
        txtPoblacion.AutoCompleteCustomSource = poblacion
        If (Me.Tag IsNot Nothing AndAlso IsNumeric(Me.Tag)) Then
            dtCliente = ClienteTableAdapter.GetDataBy(Me.Tag)
            txtCodigo.Text = dtCliente(0).Id
            txtNombre.Text = dtCliente(0).nombre
            txtDNI.Text = dtCliente(0).cif
            txtDomicilio.Text = dtCliente(0).domicilio
            txtPoblacion.Text = dtCliente(0).población
            txtProvincia.Text = dtCliente(0).provincia
            txtCP.Text = dtCliente(0).cp
            txtEmail.Text = dtCliente(0).email
            txtTlfFijo.Text = dtCliente(0).telefonoFijo
            txtTlfMovil.Text = dtCliente(0).telefonoMovil
            txtFax.Text = dtCliente(0).fax
            txtObservaciones.Text = dtCliente(0).observaciones
            Me.Text = "Guardar Cliente"
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim val As String = validar()
        If (val = "") Then
            Try
                If (dtCliente IsNot Nothing) Then
                    dtCliente(0).nombre = txtNombre.Text
                    dtCliente(0).cif = txtDNI.Text
                    dtCliente(0).domicilio = txtDomicilio.Text
                    dtCliente(0).población = txtPoblacion.Text
                    dtCliente(0).provincia = txtProvincia.Text
                    dtCliente(0).email = txtEmail.Text
                    dtCliente(0).cp = txtCP.Text
                    dtCliente(0).telefonoFijo = txtTlfFijo.Text
                    dtCliente(0).telefonoMovil = txtTlfMovil.Text
                    dtCliente(0).fax = txtFax.Text
                    dtCliente(0).observaciones = txtObservaciones.Text
                    Me.ClienteTableAdapter.Update(dtCliente)
                    If (MessageBox.Show("Cliente guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK) Then
                        Me.Close()
                    End If


                Else
                    If (txtTlfFijo.Text = "") Then
                        txtTlfFijo.Text = 0
                    End If
                    If txtFax.Text = "" Then
                        txtFax.Text = 0

                    End If
                    Me.TallerDataSet.Cliente.AddClienteRow(txtNombre.Text, txtDNI.Text, txtDomicilio.Text, txtPoblacion.Text, txtProvincia.Text, txtCP.Text, txtTlfFijo.text, txtTlfMovil.Text, txtFax.Text, txtObservaciones.Text, txtEmail.Text)
                    Me.ClienteTableAdapter.Update(Me.TallerDataSet.Cliente)
                    MessageBox.Show("Cliente guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        txtDNI.Text = ""
        txtDomicilio.Text = ""
        txtPoblacion.Text = ""
        txtProvincia.Text = ""
        txtEmail.Text = ""
        txtCP.Text = ""
        txtTlfFijo.Text = ""
        txtTlfMovil.Text = ""
        txtFax.Text = ""
        txtObservaciones.Text = ""
    End Sub

    Private Function validar() As String

        Dim res As String = ""

        If (txtDNI.Text = "") Then
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