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
        Me.BtnAksesJenisBarang = New System.Windows.Forms.Button()
        Me.BtnAksesBarang = New System.Windows.Forms.Button()
        Me.BtnAksesOrder = New System.Windows.Forms.Button()
        Me.BtnMasukBarang = New System.Windows.Forms.Button()
        Me.ToolStripTransisi = New System.Windows.Forms.ToolStrip()
        Me.LblPilih = New System.Windows.Forms.Label()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.ToolStripTransisi.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAksesJenisBarang
        '
        Me.BtnAksesJenisBarang.Location = New System.Drawing.Point(27, 162)
        Me.BtnAksesJenisBarang.Name = "BtnAksesJenisBarang"
        Me.BtnAksesJenisBarang.Size = New System.Drawing.Size(171, 23)
        Me.BtnAksesJenisBarang.TabIndex = 40
        Me.BtnAksesJenisBarang.Text = "Akses Jenis Barang"
        Me.BtnAksesJenisBarang.UseVisualStyleBackColor = True
        '
        'BtnAksesBarang
        '
        Me.BtnAksesBarang.Location = New System.Drawing.Point(27, 212)
        Me.BtnAksesBarang.Name = "BtnAksesBarang"
        Me.BtnAksesBarang.Size = New System.Drawing.Size(171, 23)
        Me.BtnAksesBarang.TabIndex = 41
        Me.BtnAksesBarang.Text = "Akses Data Barang"
        Me.BtnAksesBarang.UseVisualStyleBackColor = True
        '
        'BtnAksesOrder
        '
        Me.BtnAksesOrder.Location = New System.Drawing.Point(27, 261)
        Me.BtnAksesOrder.Name = "BtnAksesOrder"
        Me.BtnAksesOrder.Size = New System.Drawing.Size(171, 23)
        Me.BtnAksesOrder.TabIndex = 42
        Me.BtnAksesOrder.Text = "Akses Order Barang"
        Me.BtnAksesOrder.UseVisualStyleBackColor = True
        '
        'BtnMasukBarang
        '
        Me.BtnMasukBarang.Location = New System.Drawing.Point(27, 310)
        Me.BtnMasukBarang.Name = "BtnMasukBarang"
        Me.BtnMasukBarang.Size = New System.Drawing.Size(171, 23)
        Me.BtnMasukBarang.TabIndex = 43
        Me.BtnMasukBarang.Text = "Akses Masuk Barang"
        Me.BtnMasukBarang.UseVisualStyleBackColor = True
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
        'LblPilih
        '
        Me.LblPilih.AutoSize = True
        Me.LblPilih.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPilih.Location = New System.Drawing.Point(12, 128)
        Me.LblPilih.Name = "LblPilih"
        Me.LblPilih.Size = New System.Drawing.Size(135, 13)
        Me.LblPilih.TabIndex = 45
        Me.LblPilih.Text = "Pilih Akses Gudang:"
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
        'PnlLogo
        '
        Me.PnlLogo.BackgroundImage = Global.sistem_pergudangan.My.Resources.Resources.Adidas
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlLogo.Location = New System.Drawing.Point(59, 28)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(112, 74)
        Me.PnlLogo.TabIndex = 39
        '
        'Transisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 356)
        Me.Controls.Add(Me.LblPilih)
        Me.Controls.Add(Me.ToolStripTransisi)
        Me.Controls.Add(Me.BtnMasukBarang)
        Me.Controls.Add(Me.BtnAksesOrder)
        Me.Controls.Add(Me.BtnAksesBarang)
        Me.Controls.Add(Me.BtnAksesJenisBarang)
        Me.Controls.Add(Me.PnlLogo)
        Me.Name = "Transisi"
        Me.Text = "Transisi"
        Me.ToolStripTransisi.ResumeLayout(False)
        Me.ToolStripTransisi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlLogo As Panel
    Friend WithEvents BtnAksesJenisBarang As Button
    Friend WithEvents BtnAksesBarang As Button
    Friend WithEvents BtnAksesOrder As Button
    Friend WithEvents BtnMasukBarang As Button
    Friend WithEvents ToolStripTransisi As ToolStrip
    Friend WithEvents ToolStripButtonBack As ToolStripButton
    Friend WithEvents LblPilih As Label
End Class
