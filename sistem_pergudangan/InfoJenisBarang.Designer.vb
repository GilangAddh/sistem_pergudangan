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
        Me.LblOutputCatatan = New System.Windows.Forms.Label()
        Me.LblOutputSatuan = New System.Windows.Forms.Label()
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
        Me.LblTitle.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(39, 20)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(274, 22)
        Me.LblTitle.TabIndex = 14
        Me.LblTitle.Text = "Info Jenis Barang Gudang A"
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
        'LblOutputCatatan
        '
        Me.LblOutputCatatan.AutoSize = True
        Me.LblOutputCatatan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOutputCatatan.Location = New System.Drawing.Point(152, 134)
        Me.LblOutputCatatan.Name = "LblOutputCatatan"
        Me.LblOutputCatatan.Size = New System.Drawing.Size(0, 17)
        Me.LblOutputCatatan.TabIndex = 22
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
        'InfoJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 351)
        Me.Controls.Add(Me.LblOutputSatuan)
        Me.Controls.Add(Me.LblOutputCatatan)
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
    Friend WithEvents LblOutputCatatan As Label
    Friend WithEvents LblOutputSatuan As Label
End Class
