<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoFamilias
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgFamilias = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton8 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 150)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Código"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(24, 195)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Descripción"
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Location = New System.Drawing.Point(142, 145)
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.Size = New System.Drawing.Size(205, 23)
        Me.MetroTextBox1.TabIndex = 2
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.Location = New System.Drawing.Point(142, 191)
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.Size = New System.Drawing.Size(541, 23)
        Me.MetroTextBox2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Helvetica-Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(718, 131)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Familia"
        '
        'dgFamilias
        '
        Me.dgFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFamilias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.descripcion})
        Me.dgFamilias.Location = New System.Drawing.Point(17, 249)
        Me.dgFamilias.Name = "dgFamilias"
        Me.dgFamilias.Size = New System.Drawing.Size(718, 270)
        Me.dgFamilias.TabIndex = 5
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(24, 64)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(34, 23)
        Me.MetroButton1.TabIndex = 6
        Me.MetroButton1.Text = "+"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(64, 64)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(34, 23)
        Me.MetroButton2.TabIndex = 7
        Me.MetroButton2.Text = "-"
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(104, 64)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(81, 23)
        Me.MetroButton3.TabIndex = 8
        Me.MetroButton3.Text = "Guardar"
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(191, 64)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(81, 23)
        Me.MetroButton4.TabIndex = 9
        Me.MetroButton4.Text = "Cancelar"
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(278, 64)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(34, 23)
        Me.MetroButton5.TabIndex = 10
        Me.MetroButton5.Text = "<<"
        '
        'MetroButton6
        '
        Me.MetroButton6.Location = New System.Drawing.Point(318, 64)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(34, 23)
        Me.MetroButton6.TabIndex = 11
        Me.MetroButton6.Text = "<"
        '
        'MetroButton7
        '
        Me.MetroButton7.Location = New System.Drawing.Point(358, 64)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(34, 23)
        Me.MetroButton7.TabIndex = 12
        Me.MetroButton7.Text = ">"
        '
        'MetroButton8
        '
        Me.MetroButton8.Location = New System.Drawing.Point(398, 64)
        Me.MetroButton8.Name = "MetroButton8"
        Me.MetroButton8.Size = New System.Drawing.Size(34, 23)
        Me.MetroButton8.TabIndex = 13
        Me.MetroButton8.Text = ">>"
        '
        'frmMantenimientoFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(759, 553)
        Me.Controls.Add(Me.MetroButton8)
        Me.Controls.Add(Me.MetroButton7)
        Me.Controls.Add(Me.MetroButton6)
        Me.Controls.Add(Me.MetroButton5)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.dgFamilias)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMantenimientoFamilias"
        Me.Text = "Gestión de Familias"
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgFamilias As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton7 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton8 As MetroFramework.Controls.MetroButton
End Class
