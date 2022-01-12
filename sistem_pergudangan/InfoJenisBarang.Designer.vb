<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoJenisBarang
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
        Me.LblCatatan = New System.Windows.Forms.Label()
        Me.LblSatuan = New System.Windows.Forms.Label()
        Me.LblJenisBarang = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblOutputJenisBarang = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.LblOutputSatuan = New System.Windows.Forms.Label()
        Me.RtxOutputCatatan = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'LblCatatan
        '
        Me.LblCatatan.AutoSize = True
        Me.LblCatatan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblCatatan.Location = New System.Drawing.Point(55, 134)
        Me.LblCatatan.Name = "LblCatatan"
        Me.LblCatatan.Size = New System.Drawing.Size(57, 19)
        Me.LblCatatan.TabIndex = 17
        Me.LblCatatan.Text = "Catatan"
        '
        'LblSatuan
        '
        Me.LblSatuan.AutoSize = True
        Me.LblSatuan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblSatuan.Location = New System.Drawing.Point(55, 105)
        Me.LblSatuan.Name = "LblSatuan"
        Me.LblSatuan.Size = New System.Drawing.Size(51, 19)
        Me.LblSatuan.TabIndex = 16
        Me.LblSatuan.Text = "Satuan"
        '
        'LblJenisBarang
        '
        Me.LblJenisBarang.AutoSize = True
        Me.LblJenisBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblJenisBarang.Location = New System.Drawing.Point(55, 76)
        Me.LblJenisBarang.Name = "LblJenisBarang"
        Me.LblJenisBarang.Size = New System.Drawing.Size(85, 19)
        Me.LblJenisBarang.TabIndex = 15
        Me.LblJenisBarang.Text = "Jenis Barang"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(43, 22)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(251, 24)
        Me.LblTitle.TabIndex = 14
        Me.LblTitle.Text = "Info Jenis Barang Gudang"
        '
        'LblOutputJenisBarang
        '
        Me.LblOutputJenisBarang.AutoSize = True
        Me.LblOutputJenisBarang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOutputJenisBarang.Location = New System.Drawing.Point(152, 76)
        Me.LblOutputJenisBarang.Name = "LblOutputJenisBarang"
        Me.LblOutputJenisBarang.Size = New System.Drawing.Size(0, 17)
        Me.LblOutputJenisBarang.TabIndex = 18
        '
        'BtnTutup
        '
        Me.BtnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutup.Location = New System.Drawing.Point(262, 314)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(80, 25)
        Me.BtnTutup.TabIndex = 21
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'LblOutputSatuan
        '
        Me.LblOutputSatuan.AutoSize = True
        Me.LblOutputSatuan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOutputSatuan.Location = New System.Drawing.Point(152, 105)
        Me.LblOutputSatuan.Name = "LblOutputSatuan"
        Me.LblOutputSatuan.Size = New System.Drawing.Size(0, 17)
        Me.LblOutputSatuan.TabIndex = 23
        '
        'RtxOutputCatatan
        '
        Me.RtxOutputCatatan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtxOutputCatatan.Location = New System.Drawing.Point(155, 134)
        Me.RtxOutputCatatan.Name = "RtxOutputCatatan"
        Me.RtxOutputCatatan.Size = New System.Drawing.Size(118, 102)
        Me.RtxOutputCatatan.TabIndex = 24
        Me.RtxOutputCatatan.Text = ""
        '
        'InfoJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 351)
        Me.Controls.Add(Me.RtxOutputCatatan)
        Me.Controls.Add(Me.LblOutputSatuan)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.LblOutputJenisBarang)
        Me.Controls.Add(Me.LblCatatan)
        Me.Controls.Add(Me.LblSatuan)
        Me.Controls.Add(Me.LblJenisBarang)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "InfoJenisBarang"
        Me.Text = "InfoJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCatatan As Label
    Friend WithEvents LblSatuan As Label
    Friend WithEvents LblJenisBarang As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblOutputJenisBarang As Label
    Friend WithEvents BtnTutup As Button
    Friend WithEvents LblOutputSatuan As Label
    Friend WithEvents RtxOutputCatatan As RichTextBox
End Class
