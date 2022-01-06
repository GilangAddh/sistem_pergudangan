<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditJenisBarang
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
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.TxtCatatanLimit = New System.Windows.Forms.TextBox()
        Me.RtxCatatan = New System.Windows.Forms.RichTextBox()
        Me.TxtSatuan = New System.Windows.Forms.TextBox()
        Me.TxtJenisBarang = New System.Windows.Forms.TextBox()
        Me.LblCatatan = New System.Windows.Forms.Label()
        Me.LblSatuan = New System.Windows.Forms.Label()
        Me.LblJenisBarang = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnTutup
        '
        Me.BtnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutup.Location = New System.Drawing.Point(262, 314)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(80, 25)
        Me.BtnTutup.TabIndex = 18
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'TxtCatatanLimit
        '
        Me.TxtCatatanLimit.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtCatatanLimit.Location = New System.Drawing.Point(298, 205)
        Me.TxtCatatanLimit.Name = "TxtCatatanLimit"
        Me.TxtCatatanLimit.ReadOnly = True
        Me.TxtCatatanLimit.Size = New System.Drawing.Size(29, 25)
        Me.TxtCatatanLimit.TabIndex = 17
        Me.TxtCatatanLimit.Text = "100"
        Me.TxtCatatanLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RtxCatatan
        '
        Me.RtxCatatan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RtxCatatan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RtxCatatan.Location = New System.Drawing.Point(155, 134)
        Me.RtxCatatan.Name = "RtxCatatan"
        Me.RtxCatatan.Size = New System.Drawing.Size(137, 96)
        Me.RtxCatatan.TabIndex = 16
        Me.RtxCatatan.Text = ""
        '
        'TxtSatuan
        '
        Me.TxtSatuan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSatuan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtSatuan.Location = New System.Drawing.Point(155, 106)
        Me.TxtSatuan.Name = "TxtSatuan"
        Me.TxtSatuan.Size = New System.Drawing.Size(137, 18)
        Me.TxtSatuan.TabIndex = 15
        '
        'TxtJenisBarang
        '
        Me.TxtJenisBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtJenisBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtJenisBarang.Location = New System.Drawing.Point(155, 77)
        Me.TxtJenisBarang.Name = "TxtJenisBarang"
        Me.TxtJenisBarang.Size = New System.Drawing.Size(137, 18)
        Me.TxtJenisBarang.TabIndex = 14
        '
        'LblCatatan
        '
        Me.LblCatatan.AutoSize = True
        Me.LblCatatan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblCatatan.Location = New System.Drawing.Point(55, 134)
        Me.LblCatatan.Name = "LblCatatan"
        Me.LblCatatan.Size = New System.Drawing.Size(57, 19)
        Me.LblCatatan.TabIndex = 13
        Me.LblCatatan.Text = "Catatan"
        '
        'LblSatuan
        '
        Me.LblSatuan.AutoSize = True
        Me.LblSatuan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblSatuan.Location = New System.Drawing.Point(55, 105)
        Me.LblSatuan.Name = "LblSatuan"
        Me.LblSatuan.Size = New System.Drawing.Size(51, 19)
        Me.LblSatuan.TabIndex = 12
        Me.LblSatuan.Text = "Satuan"
        '
        'LblJenisBarang
        '
        Me.LblJenisBarang.AutoSize = True
        Me.LblJenisBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblJenisBarang.Location = New System.Drawing.Point(55, 76)
        Me.LblJenisBarang.Name = "LblJenisBarang"
        Me.LblJenisBarang.Size = New System.Drawing.Size(85, 19)
        Me.LblJenisBarang.TabIndex = 11
        Me.LblJenisBarang.Text = "Jenis Barang"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(39, 20)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(276, 22)
        Me.LblTitle.TabIndex = 10
        Me.LblTitle.Text = "Edit Jenis Barang Gudang A"
        '
        'EditJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 351)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.TxtCatatanLimit)
        Me.Controls.Add(Me.RtxCatatan)
        Me.Controls.Add(Me.TxtSatuan)
        Me.Controls.Add(Me.TxtJenisBarang)
        Me.Controls.Add(Me.LblCatatan)
        Me.Controls.Add(Me.LblSatuan)
        Me.Controls.Add(Me.LblJenisBarang)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "EditJenisBarang"
        Me.Text = "EditJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTutup As Button
    Friend WithEvents TxtCatatanLimit As TextBox
    Friend WithEvents RtxCatatan As RichTextBox
    Friend WithEvents TxtSatuan As TextBox
    Friend WithEvents TxtJenisBarang As TextBox
    Friend WithEvents LblCatatan As Label
    Friend WithEvents LblSatuan As Label
    Friend WithEvents LblJenisBarang As Label
    Friend WithEvents LblTitle As Label
End Class
