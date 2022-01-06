<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JenisBarang
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
        Me.DataGridJenisBarang = New System.Windows.Forms.DataGridView()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnTambahJenis = New System.Windows.Forms.Button()
        Me.BtnEditJenis = New System.Windows.Forms.Button()
        Me.BtnHapusJenis = New System.Windows.Forms.Button()
        Me.BtnShow = New System.Windows.Forms.Button()
        CType(Me.DataGridJenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridJenisBarang
        '
        Me.DataGridJenisBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridJenisBarang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridJenisBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridJenisBarang.Location = New System.Drawing.Point(12, 76)
        Me.DataGridJenisBarang.Name = "DataGridJenisBarang"
        Me.DataGridJenisBarang.RowHeadersWidth = 60
        Me.DataGridJenisBarang.Size = New System.Drawing.Size(567, 263)
        Me.DataGridJenisBarang.TabIndex = 0
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("News706 BT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(131, 23)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(371, 32)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "Kategori Barang Gudang A"
        '
        'BtnTambahJenis
        '
        Me.BtnTambahJenis.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahJenis.Location = New System.Drawing.Point(12, 345)
        Me.BtnTambahJenis.Name = "BtnTambahJenis"
        Me.BtnTambahJenis.Size = New System.Drawing.Size(100, 23)
        Me.BtnTambahJenis.TabIndex = 2
        Me.BtnTambahJenis.Text = "Tambah"
        Me.BtnTambahJenis.UseVisualStyleBackColor = True
        '
        'BtnEditJenis
        '
        Me.BtnEditJenis.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditJenis.Location = New System.Drawing.Point(171, 345)
        Me.BtnEditJenis.Name = "BtnEditJenis"
        Me.BtnEditJenis.Size = New System.Drawing.Size(100, 23)
        Me.BtnEditJenis.TabIndex = 3
        Me.BtnEditJenis.Text = "Edit"
        Me.BtnEditJenis.UseVisualStyleBackColor = True
        '
        'BtnHapusJenis
        '
        Me.BtnHapusJenis.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusJenis.Location = New System.Drawing.Point(325, 345)
        Me.BtnHapusJenis.Name = "BtnHapusJenis"
        Me.BtnHapusJenis.Size = New System.Drawing.Size(100, 23)
        Me.BtnHapusJenis.TabIndex = 4
        Me.BtnHapusJenis.Text = "Hapus"
        Me.BtnHapusJenis.UseVisualStyleBackColor = True
        '
        'BtnShow
        '
        Me.BtnShow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.Location = New System.Drawing.Point(479, 345)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(100, 23)
        Me.BtnShow.TabIndex = 5
        Me.BtnShow.Text = "Show Info"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'JenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 375)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.BtnHapusJenis)
        Me.Controls.Add(Me.BtnEditJenis)
        Me.Controls.Add(Me.BtnTambahJenis)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.DataGridJenisBarang)
        Me.Name = "JenisBarang"
        Me.Text = "JenisBarang"
        CType(Me.DataGridJenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridJenisBarang As DataGridView
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnTambahJenis As Button
    Friend WithEvents BtnEditJenis As Button
    Friend WithEvents BtnHapusJenis As Button
    Friend WithEvents BtnShow As Button
End Class
