<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadosReorganizacion
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadosReorganizacion))
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroTextBox3
        '
        Me.MetroTextBox3.Location = New System.Drawing.Point(23, 84)
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.Size = New System.Drawing.Size(437, 25)
        Me.MetroTextBox3.TabIndex = 84
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 62)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(212, 19)
        Me.MetroLabel4.TabIndex = 83
        Me.MetroLabel4.Text = "Introduce fecha de Reorganización"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(358, 126)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton2.TabIndex = 88
        Me.MetroButton2.Text = "Cancelar"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(250, 126)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton1.TabIndex = 87
        Me.MetroButton1.Text = "Aceptar"
        '
        'frmListadosReorganizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(488, 184)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroTextBox3)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListadosReorganizacion"
        Me.Text = "Reorganización de Informes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
