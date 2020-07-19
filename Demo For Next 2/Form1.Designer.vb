<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gbrTopi = New System.Windows.Forms.PictureBox()
        Me.tombolJalankan = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        CType(Me.gbrTopi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbrTopi
        '
        Me.gbrTopi.Image = CType(resources.GetObject("gbrTopi.Image"), System.Drawing.Image)
        Me.gbrTopi.Location = New System.Drawing.Point(4, 3)
        Me.gbrTopi.Name = "gbrTopi"
        Me.gbrTopi.Size = New System.Drawing.Size(100, 85)
        Me.gbrTopi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gbrTopi.TabIndex = 0
        Me.gbrTopi.TabStop = False
        '
        'tombolJalankan
        '
        Me.tombolJalankan.Location = New System.Drawing.Point(99, 127)
        Me.tombolJalankan.Name = "tombolJalankan"
        Me.tombolJalankan.Size = New System.Drawing.Size(112, 40)
        Me.tombolJalankan.TabIndex = 1
        Me.tombolJalankan.Text = "Jalankan!"
        Me.tombolJalankan.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(265, 127)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(112, 40)
        Me.tombolKeluar.TabIndex = 2
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 187)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolJalankan)
        Me.Controls.Add(Me.gbrTopi)
        Me.Name = "Form1"
        Me.Text = "Demo For Next 2"
        CType(Me.gbrTopi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbrTopi As System.Windows.Forms.PictureBox
    Friend WithEvents tombolJalankan As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
