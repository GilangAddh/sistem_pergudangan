<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetAkun
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
        Me.ToolStripReset = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonResetBack = New System.Windows.Forms.ToolStripButton()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.TxtResetKodeAkses = New System.Windows.Forms.TextBox()
        Me.LblResetKodeAkses = New System.Windows.Forms.Label()
        Me.TxtResetNamaPegawai = New System.Windows.Forms.TextBox()
        Me.LblResetNamaPegawai = New System.Windows.Forms.Label()
        Me.LblResetAkun = New System.Windows.Forms.Label()
        Me.TxtResetUsername = New System.Windows.Forms.TextBox()
        Me.LblResetUsername = New System.Windows.Forms.Label()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.TxtResetEmail = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnImport = New System.Windows.Forms.Button()
        Me.ToolStripReset.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripReset
        '
        Me.ToolStripReset.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonResetBack})
        Me.ToolStripReset.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripReset.Name = "ToolStripReset"
        Me.ToolStripReset.Size = New System.Drawing.Size(350, 25)
        Me.ToolStripReset.TabIndex = 14
        Me.ToolStripReset.Text = "ToolStripDaftar"
        '
        'ToolStripButtonResetBack
        '
        Me.ToolStripButtonResetBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonResetBack.Image = Global.sistem_pergudangan.My.Resources.Resources.back_exit
        Me.ToolStripButtonResetBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonResetBack.Name = "ToolStripButtonResetBack"
        Me.ToolStripButtonResetBack.Size = New System.Drawing.Size(23, 22)
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(31, 319)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(282, 23)
        Me.BtnReset.TabIndex = 39
        Me.BtnReset.Text = "Pulihkan"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'TxtResetKodeAkses
        '
        Me.TxtResetKodeAkses.Location = New System.Drawing.Point(31, 281)
        Me.TxtResetKodeAkses.Name = "TxtResetKodeAkses"
        Me.TxtResetKodeAkses.Size = New System.Drawing.Size(212, 20)
        Me.TxtResetKodeAkses.TabIndex = 38
        '
        'LblResetKodeAkses
        '
        Me.LblResetKodeAkses.AutoSize = True
        Me.LblResetKodeAkses.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResetKodeAkses.Location = New System.Drawing.Point(28, 254)
        Me.LblResetKodeAkses.Name = "LblResetKodeAkses"
        Me.LblResetKodeAkses.Size = New System.Drawing.Size(74, 13)
        Me.LblResetKodeAkses.TabIndex = 37
        Me.LblResetKodeAkses.Text = "Kode Akses"
        '
        'TxtResetNamaPegawai
        '
        Me.TxtResetNamaPegawai.Location = New System.Drawing.Point(31, 216)
        Me.TxtResetNamaPegawai.Name = "TxtResetNamaPegawai"
        Me.TxtResetNamaPegawai.Size = New System.Drawing.Size(282, 20)
        Me.TxtResetNamaPegawai.TabIndex = 34
        '
        'LblResetNamaPegawai
        '
        Me.LblResetNamaPegawai.AutoSize = True
        Me.LblResetNamaPegawai.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResetNamaPegawai.Location = New System.Drawing.Point(28, 188)
        Me.LblResetNamaPegawai.Name = "LblResetNamaPegawai"
        Me.LblResetNamaPegawai.Size = New System.Drawing.Size(91, 13)
        Me.LblResetNamaPegawai.TabIndex = 32
        Me.LblResetNamaPegawai.Text = "Nama Pegawai"
        '
        'LblResetAkun
        '
        Me.LblResetAkun.AutoSize = True
        Me.LblResetAkun.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResetAkun.Location = New System.Drawing.Point(12, 25)
        Me.LblResetAkun.Name = "LblResetAkun"
        Me.LblResetAkun.Size = New System.Drawing.Size(109, 16)
        Me.LblResetAkun.TabIndex = 28
        Me.LblResetAkun.Text = "Pulihkan Akun"
        '
        'TxtResetUsername
        '
        Me.TxtResetUsername.Location = New System.Drawing.Point(31, 90)
        Me.TxtResetUsername.Name = "TxtResetUsername"
        Me.TxtResetUsername.Size = New System.Drawing.Size(282, 20)
        Me.TxtResetUsername.TabIndex = 41
        '
        'LblResetUsername
        '
        Me.LblResetUsername.AutoSize = True
        Me.LblResetUsername.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResetUsername.Location = New System.Drawing.Point(28, 64)
        Me.LblResetUsername.Name = "LblResetUsername"
        Me.LblResetUsername.Size = New System.Drawing.Size(65, 13)
        Me.LblResetUsername.TabIndex = 40
        Me.LblResetUsername.Text = "Username"
        '
        'PnlLogo
        '
        Me.PnlLogo.BackgroundImage = Global.sistem_pergudangan.My.Resources.Resources.Adidas
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlLogo.Location = New System.Drawing.Point(268, 25)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(82, 39)
        Me.PnlLogo.TabIndex = 42
        '
        'TxtResetEmail
        '
        Me.TxtResetEmail.Location = New System.Drawing.Point(31, 153)
        Me.TxtResetEmail.Name = "TxtResetEmail"
        Me.TxtResetEmail.Size = New System.Drawing.Size(282, 20)
        Me.TxtResetEmail.TabIndex = 44
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(28, 125)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(89, 13)
        Me.LblEmail.TabIndex = 43
        Me.LblEmail.Text = "Email Pegawai"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnImport
        '
        Me.BtnImport.Location = New System.Drawing.Point(249, 279)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(64, 23)
        Me.BtnImport.TabIndex = 45
        Me.BtnImport.Text = "Import"
        Me.BtnImport.UseVisualStyleBackColor = True
        '
        'ResetAkun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 373)
        Me.Controls.Add(Me.BtnImport)
        Me.Controls.Add(Me.TxtResetEmail)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.PnlLogo)
        Me.Controls.Add(Me.TxtResetUsername)
        Me.Controls.Add(Me.LblResetUsername)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.TxtResetKodeAkses)
        Me.Controls.Add(Me.LblResetKodeAkses)
        Me.Controls.Add(Me.TxtResetNamaPegawai)
        Me.Controls.Add(Me.LblResetNamaPegawai)
        Me.Controls.Add(Me.LblResetAkun)
        Me.Controls.Add(Me.ToolStripReset)
        Me.Name = "ResetAkun"
        Me.Text = "ResetAkun"
        Me.ToolStripReset.ResumeLayout(False)
        Me.ToolStripReset.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripReset As ToolStrip
    Friend WithEvents ToolStripButtonResetBack As ToolStripButton
    Friend WithEvents BtnReset As Button
    Friend WithEvents TxtResetKodeAkses As TextBox
    Friend WithEvents LblResetKodeAkses As Label
    Friend WithEvents TxtResetNamaPegawai As TextBox
    Friend WithEvents LblResetNamaPegawai As Label
    Friend WithEvents LblResetAkun As Label
    Friend WithEvents TxtResetUsername As TextBox
    Friend WithEvents LblResetUsername As Label
    Friend WithEvents PnlLogo As Panel
    Friend WithEvents TxtResetEmail As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnImport As Button
End Class
