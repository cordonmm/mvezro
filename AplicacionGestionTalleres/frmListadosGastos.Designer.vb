<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadosGastos
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
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton3 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(271, 72)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(175, 20)
        Me.DateTimePicker2.TabIndex = 85
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(250, 73)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(15, 19)
        Me.MetroLabel1.TabIndex = 84
        Me.MetroLabel1.Text = "y"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(69, 72)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(175, 20)
        Me.DateTimePicker1.TabIndex = 83
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(24, 73)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel3.TabIndex = 82
        Me.MetroLabel3.Text = "Entre"
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.Checked = True
        Me.MetroRadioButton1.Location = New System.Drawing.Point(140, 126)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(208, 15)
        Me.MetroRadioButton1.TabIndex = 81
        Me.MetroRadioButton1.TabStop = True
        Me.MetroRadioButton1.Text = "Listado de Empresa y Herramientas"
        Me.MetroRadioButton1.UseVisualStyleBackColor = True
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.Location = New System.Drawing.Point(140, 158)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(163, 15)
        Me.MetroRadioButton2.TabIndex = 86
        Me.MetroRadioButton2.Text = "Listado Gastos de Empresa"
        Me.MetroRadioButton2.UseVisualStyleBackColor = True
        '
        'MetroRadioButton3
        '
        Me.MetroRadioButton3.AutoSize = True
        Me.MetroRadioButton3.Location = New System.Drawing.Point(140, 190)
        Me.MetroRadioButton3.Name = "MetroRadioButton3"
        Me.MetroRadioButton3.Size = New System.Drawing.Size(189, 15)
        Me.MetroRadioButton3.TabIndex = 87
        Me.MetroRadioButton3.Text = "Listado Gastos de Herramientas"
        Me.MetroRadioButton3.UseVisualStyleBackColor = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(344, 231)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton2.TabIndex = 89
        Me.MetroButton2.Text = "Cancelar"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(236, 231)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(102, 25)
        Me.MetroButton1.TabIndex = 88
        Me.MetroButton1.Text = "Imprimir"
        '
        'frmListadosGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(476, 295)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroRadioButton3)
        Me.Controls.Add(Me.MetroRadioButton2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroRadioButton1)
        Me.Name = "frmListadosGastos"
        Me.Text = "Gastos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton3 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
