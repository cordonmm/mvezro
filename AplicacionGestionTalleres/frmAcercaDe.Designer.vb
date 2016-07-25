<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcercaDe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcercaDe))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplicacionGestionTalleres.My.Resources.Resources.logoo
        Me.PictureBox1.Location = New System.Drawing.Point(23, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(480, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 76)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(480, 19)
        Me.MetroLabel1.TabIndex = 82
        Me.MetroLabel1.Text = "Esta Aplicación ha sido desarrollada por 10Code, S.C. para Talleres M. Vezro, S.L" &
    "."
        '
        'MetroLink1
        '
        Me.MetroLink1.ForeColor = System.Drawing.Color.LightCoral
        Me.MetroLink1.Location = New System.Drawing.Point(23, 295)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(480, 23)
        Me.MetroLink1.TabIndex = 83
        Me.MetroLink1.Text = "www.10code.es"
        '
        'frmAcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(528, 349)
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.LightCoral
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAcercaDe"
        Me.Text = "Acerca de..."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
End Class
