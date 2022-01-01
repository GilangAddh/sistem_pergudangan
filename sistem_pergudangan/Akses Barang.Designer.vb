<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Akses_Barang
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
        Me.BtnShowInfo = New System.Windows.Forms.Button()
        Me.BtnEditBarang = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        Me.LblPilih = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnShowInfo
        '
        Me.BtnShowInfo.Location = New System.Drawing.Point(28, 69)
        Me.BtnShowInfo.Name = "BtnShowInfo"
        Me.BtnShowInfo.Size = New System.Drawing.Size(212, 23)
        Me.BtnShowInfo.TabIndex = 0
        Me.BtnShowInfo.Text = "Show Info Barang"
        Me.BtnShowInfo.UseVisualStyleBackColor = True
        '
        'BtnEditBarang
        '
        Me.BtnEditBarang.Location = New System.Drawing.Point(28, 110)
        Me.BtnEditBarang.Name = "BtnEditBarang"
        Me.BtnEditBarang.Size = New System.Drawing.Size(212, 23)
        Me.BtnEditBarang.TabIndex = 1
        Me.BtnEditBarang.Text = "Edit Barang"
        Me.BtnEditBarang.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(28, 151)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(212, 23)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus Barang"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBack})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(269, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonBack
        '
        Me.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBack.Image = Global.sistem_pergudangan.My.Resources.Resources.back_exit
        Me.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBack.Name = "ToolStripButtonBack"
        Me.ToolStripButtonBack.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonBack.Text = "ToolStripButton1"
        '
        'LblPilih
        '
        Me.LblPilih.AutoSize = True
        Me.LblPilih.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPilih.Location = New System.Drawing.Point(12, 36)
        Me.LblPilih.Name = "LblPilih"
        Me.LblPilih.Size = New System.Drawing.Size(132, 13)
        Me.LblPilih.TabIndex = 46
        Me.LblPilih.Text = "Pilih Akses Barang:"
        '
        'Akses_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 192)
        Me.Controls.Add(Me.LblPilih)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEditBarang)
        Me.Controls.Add(Me.BtnShowInfo)
        Me.Name = "Akses_Barang"
        Me.Text = "Akses_Barang"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnShowInfo As Button
    Friend WithEvents BtnEditBarang As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonBack As ToolStripButton
    Friend WithEvents LblPilih As Label
End Class
