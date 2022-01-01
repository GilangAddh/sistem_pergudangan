<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus_Barang
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
        Me.LblNamaBarang = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        Me.PictureBoxFotoBarang = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBoxFotoBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNamaBarang
        '
        Me.LblNamaBarang.AutoSize = True
        Me.LblNamaBarang.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNamaBarang.Location = New System.Drawing.Point(64, 172)
        Me.LblNamaBarang.Name = "LblNamaBarang"
        Me.LblNamaBarang.Size = New System.Drawing.Size(50, 16)
        Me.LblNamaBarang.TabIndex = 51
        Me.LblNamaBarang.Text = "Nama"
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(12, 222)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(198, 23)
        Me.BtnHapus.TabIndex = 52
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBack})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(221, 25)
        Me.ToolStrip1.TabIndex = 53
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
        'PictureBoxFotoBarang
        '
        Me.PictureBoxFotoBarang.Location = New System.Drawing.Point(67, 50)
        Me.PictureBoxFotoBarang.Name = "PictureBoxFotoBarang"
        Me.PictureBoxFotoBarang.Size = New System.Drawing.Size(84, 101)
        Me.PictureBoxFotoBarang.TabIndex = 54
        Me.PictureBoxFotoBarang.TabStop = False
        '
        'Hapus_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 269)
        Me.Controls.Add(Me.PictureBoxFotoBarang)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblNamaBarang)
        Me.Name = "Hapus_Barang"
        Me.Text = "Hapus_Barang"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBoxFotoBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNamaBarang As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonBack As ToolStripButton
    Friend WithEvents PictureBoxFotoBarang As PictureBox
End Class
