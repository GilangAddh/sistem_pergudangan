<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Barang
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
        Me.DGV_Data_Barang = New System.Windows.Forms.DataGridView()
        Me.Button_Pilih = New System.Windows.Forms.Button()
        Me.Button_Tutup = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Cari_Data = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_CariNama = New System.Windows.Forms.TextBox()
        CType(Me.DGV_Data_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Data_Barang
        '
        Me.DGV_Data_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Data_Barang.Location = New System.Drawing.Point(12, 150)
        Me.DGV_Data_Barang.Name = "DGV_Data_Barang"
        Me.DGV_Data_Barang.Size = New System.Drawing.Size(426, 173)
        Me.DGV_Data_Barang.TabIndex = 0
        '
        'Button_Pilih
        '
        Me.Button_Pilih.Location = New System.Drawing.Point(590, 150)
        Me.Button_Pilih.Name = "Button_Pilih"
        Me.Button_Pilih.Size = New System.Drawing.Size(75, 23)
        Me.Button_Pilih.TabIndex = 1
        Me.Button_Pilih.Text = "Pilih"
        Me.Button_Pilih.UseVisualStyleBackColor = True
        '
        'Button_Tutup
        '
        Me.Button_Tutup.Location = New System.Drawing.Point(590, 212)
        Me.Button_Tutup.Name = "Button_Tutup"
        Me.Button_Tutup.Size = New System.Drawing.Size(75, 23)
        Me.Button_Tutup.TabIndex = 2
        Me.Button_Tutup.Text = "Tutup"
        Me.Button_Tutup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Cari_Data)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_CariNama)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 125)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kolom Pencarian"
        '
        'Button_Cari_Data
        '
        Me.Button_Cari_Data.Location = New System.Drawing.Point(314, 53)
        Me.Button_Cari_Data.Name = "Button_Cari_Data"
        Me.Button_Cari_Data.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cari_Data.TabIndex = 15
        Me.Button_Cari_Data.Text = "Cari"
        Me.Button_Cari_Data.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Pencarian Nama Barang"
        '
        'Txt_CariNama
        '
        Me.Txt_CariNama.Location = New System.Drawing.Point(111, 53)
        Me.Txt_CariNama.Name = "Txt_CariNama"
        Me.Txt_CariNama.Size = New System.Drawing.Size(118, 20)
        Me.Txt_CariNama.TabIndex = 14
        '
        'Data_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Tutup)
        Me.Controls.Add(Me.Button_Pilih)
        Me.Controls.Add(Me.DGV_Data_Barang)
        Me.Name = "Data_Barang"
        Me.Text = "Data_Barang"
        CType(Me.DGV_Data_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Data_Barang As DataGridView
    Friend WithEvents Button_Pilih As Button
    Friend WithEvents Button_Tutup As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Cari_Data As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_CariNama As TextBox
End Class
