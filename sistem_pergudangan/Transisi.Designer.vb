<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transisi
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
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolStripTransisi = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        Me.LblPilih = New System.Windows.Forms.Label()
        Me.ToolStripTransisi.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlLogo
        '
        Me.PnlLogo.BackgroundImage = Global.sistem_pergudangan.My.Resources.Resources.Adidas
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlLogo.Location = New System.Drawing.Point(65, 38)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(106, 60)
        Me.PnlLogo.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 23)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Akses Jenis Barang"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 23)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Akses Data Barang"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(27, 261)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 23)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Akses Order Barang"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(27, 310)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(171, 23)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "Akses Masuk Barang"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ToolStripTransisi
        '
        Me.ToolStripTransisi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBack})
        Me.ToolStripTransisi.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripTransisi.Name = "ToolStripTransisi"
        Me.ToolStripTransisi.Size = New System.Drawing.Size(222, 25)
        Me.ToolStripTransisi.TabIndex = 44
        Me.ToolStripTransisi.Text = "ToolStripButtunBack"
        '
        'ToolStripButtonBack
        '
        Me.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBack.Image = Global.sistem_pergudangan.My.Resources.Resources.back_exit
        Me.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBack.Name = "ToolStripButtonBack"
        Me.ToolStripButtonBack.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonBack.Text = "ToolStripButtonBack"
        '
        'LblPilih
        '
        Me.LblPilih.AutoSize = True
        Me.LblPilih.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPilih.Location = New System.Drawing.Point(24, 123)
        Me.LblPilih.Name = "LblPilih"
        Me.LblPilih.Size = New System.Drawing.Size(135, 13)
        Me.LblPilih.TabIndex = 45
        Me.LblPilih.Text = "Pilih Akses Gudang:"
        '
        'Transisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 356)
        Me.Controls.Add(Me.LblPilih)
        Me.Controls.Add(Me.ToolStripTransisi)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PnlLogo)
        Me.Name = "Transisi"
        Me.Text = "Transisi"
        Me.ToolStripTransisi.ResumeLayout(False)
        Me.ToolStripTransisi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlLogo As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ToolStripTransisi As ToolStrip
    Friend WithEvents ToolStripButtonBack As ToolStripButton
    Friend WithEvents LblPilih As Label
End Class
