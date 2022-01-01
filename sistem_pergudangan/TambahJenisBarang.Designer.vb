<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJenisBarang
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblJenisBarang = New System.Windows.Forms.Label()
        Me.LblSatuan = New System.Windows.Forms.Label()
        Me.LblCatatan = New System.Windows.Forms.Label()
        Me.TxtInputJenisBarang = New System.Windows.Forms.TextBox()
        Me.TxtInputSatuan = New System.Windows.Forms.TextBox()
        Me.RtxInputCatatan = New System.Windows.Forms.RichTextBox()
        Me.TxtCatatanLimit = New System.Windows.Forms.TextBox()
        Me.BtnTambahCatatan = New System.Windows.Forms.Button()
        Me.BtnTambahJenisBarang = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(20, 20)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(313, 22)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Tambah Jenis Barang Gudang A"
        '
        'LblJenisBarang
        '
        Me.LblJenisBarang.AutoSize = True
        Me.LblJenisBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblJenisBarang.Location = New System.Drawing.Point(55, 76)
        Me.LblJenisBarang.Name = "LblJenisBarang"
        Me.LblJenisBarang.Size = New System.Drawing.Size(85, 19)
        Me.LblJenisBarang.TabIndex = 1
        Me.LblJenisBarang.Text = "Jenis Barang"
        '
        'LblSatuan
        '
        Me.LblSatuan.AutoSize = True
        Me.LblSatuan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblSatuan.Location = New System.Drawing.Point(55, 105)
        Me.LblSatuan.Name = "LblSatuan"
        Me.LblSatuan.Size = New System.Drawing.Size(51, 19)
        Me.LblSatuan.TabIndex = 2
        Me.LblSatuan.Text = "Satuan"
        '
        'LblCatatan
        '
        Me.LblCatatan.AutoSize = True
        Me.LblCatatan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblCatatan.Location = New System.Drawing.Point(55, 134)
        Me.LblCatatan.Name = "LblCatatan"
        Me.LblCatatan.Size = New System.Drawing.Size(57, 19)
        Me.LblCatatan.TabIndex = 3
        Me.LblCatatan.Text = "Catatan"
        '
        'TxtInputJenisBarang
        '
        Me.TxtInputJenisBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtInputJenisBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtInputJenisBarang.Location = New System.Drawing.Point(155, 77)
        Me.TxtInputJenisBarang.Name = "TxtInputJenisBarang"
        Me.TxtInputJenisBarang.Size = New System.Drawing.Size(137, 18)
        Me.TxtInputJenisBarang.TabIndex = 4
        '
        'TxtInputSatuan
        '
        Me.TxtInputSatuan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtInputSatuan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtInputSatuan.Location = New System.Drawing.Point(155, 106)
        Me.TxtInputSatuan.Name = "TxtInputSatuan"
        Me.TxtInputSatuan.Size = New System.Drawing.Size(137, 18)
        Me.TxtInputSatuan.TabIndex = 5
        '
        'RtxInputCatatan
        '
        Me.RtxInputCatatan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RtxInputCatatan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RtxInputCatatan.Location = New System.Drawing.Point(155, 134)
        Me.RtxInputCatatan.Name = "RtxInputCatatan"
        Me.RtxInputCatatan.Size = New System.Drawing.Size(137, 96)
        Me.RtxInputCatatan.TabIndex = 6
        Me.RtxInputCatatan.Text = ""
        '
        'TxtCatatanLimit
        '
        Me.TxtCatatanLimit.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtCatatanLimit.Location = New System.Drawing.Point(298, 205)
        Me.TxtCatatanLimit.Name = "TxtCatatanLimit"
        Me.TxtCatatanLimit.ReadOnly = True
        Me.TxtCatatanLimit.Size = New System.Drawing.Size(25, 25)
        Me.TxtCatatanLimit.TabIndex = 7
        Me.TxtCatatanLimit.Text = "50"
        Me.TxtCatatanLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnTambahCatatan
        '
        Me.BtnTambahCatatan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnTambahCatatan.Location = New System.Drawing.Point(155, 241)
        Me.BtnTambahCatatan.Name = "BtnTambahCatatan"
        Me.BtnTambahCatatan.Size = New System.Drawing.Size(137, 23)
        Me.BtnTambahCatatan.TabIndex = 8
        Me.BtnTambahCatatan.Text = "Buka Catatan File"
        Me.BtnTambahCatatan.UseVisualStyleBackColor = True
        '
        'BtnTambahJenisBarang
        '
        Me.BtnTambahJenisBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahJenisBarang.Location = New System.Drawing.Point(262, 314)
        Me.BtnTambahJenisBarang.Name = "BtnTambahJenisBarang"
        Me.BtnTambahJenisBarang.Size = New System.Drawing.Size(80, 25)
        Me.BtnTambahJenisBarang.TabIndex = 9
        Me.BtnTambahJenisBarang.Text = "Tambah"
        Me.BtnTambahJenisBarang.UseVisualStyleBackColor = True
        '
        'TambahJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 351)
        Me.Controls.Add(Me.BtnTambahJenisBarang)
        Me.Controls.Add(Me.BtnTambahCatatan)
        Me.Controls.Add(Me.TxtCatatanLimit)
        Me.Controls.Add(Me.RtxInputCatatan)
        Me.Controls.Add(Me.TxtInputSatuan)
        Me.Controls.Add(Me.TxtInputJenisBarang)
        Me.Controls.Add(Me.LblCatatan)
        Me.Controls.Add(Me.LblSatuan)
        Me.Controls.Add(Me.LblJenisBarang)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "TambahJenisBarang"
        Me.Text = "`"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblJenisBarang As Label
    Friend WithEvents LblSatuan As Label
    Friend WithEvents LblCatatan As Label
    Friend WithEvents TxtInputJenisBarang As TextBox
    Friend WithEvents TxtInputSatuan As TextBox
    Friend WithEvents RtxInputCatatan As RichTextBox
    Friend WithEvents TxtCatatanLimit As TextBox
    Friend WithEvents BtnTambahCatatan As Button
    Friend WithEvents BtnTambahJenisBarang As Button
End Class
