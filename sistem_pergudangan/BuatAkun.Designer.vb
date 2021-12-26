<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuatAkun
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
        Me.LblBuatAkun = New System.Windows.Forms.Label()
        Me.BtnRegClear = New System.Windows.Forms.Button()
        Me.BtnRegBuat = New System.Windows.Forms.Button()
        Me.TxtRegPassword = New System.Windows.Forms.TextBox()
        Me.TxtRegUsername = New System.Windows.Forms.TextBox()
        Me.LblRegPassword = New System.Windows.Forms.Label()
        Me.LblRegUsername = New System.Windows.Forms.Label()
        Me.TxtHurufUsername = New System.Windows.Forms.TextBox()
        Me.TxtHurufPassword = New System.Windows.Forms.TextBox()
        Me.TxtPasswordLagi = New System.Windows.Forms.TextBox()
        Me.LblPasswordLagi = New System.Windows.Forms.Label()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'LblBuatAkun
        '
        Me.LblBuatAkun.AutoSize = True
        Me.LblBuatAkun.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuatAkun.Location = New System.Drawing.Point(12, 21)
        Me.LblBuatAkun.Name = "LblBuatAkun"
        Me.LblBuatAkun.Size = New System.Drawing.Size(82, 16)
        Me.LblBuatAkun.TabIndex = 13
        Me.LblBuatAkun.Text = "Buat Akun"
        '
        'BtnRegClear
        '
        Me.BtnRegClear.Location = New System.Drawing.Point(38, 249)
        Me.BtnRegClear.Name = "BtnRegClear"
        Me.BtnRegClear.Size = New System.Drawing.Size(90, 23)
        Me.BtnRegClear.TabIndex = 21
        Me.BtnRegClear.Text = "Clear"
        Me.BtnRegClear.UseVisualStyleBackColor = True
        '
        'BtnRegBuat
        '
        Me.BtnRegBuat.Location = New System.Drawing.Point(134, 249)
        Me.BtnRegBuat.Name = "BtnRegBuat"
        Me.BtnRegBuat.Size = New System.Drawing.Size(180, 23)
        Me.BtnRegBuat.TabIndex = 20
        Me.BtnRegBuat.Text = "Create"
        Me.BtnRegBuat.UseVisualStyleBackColor = True
        '
        'TxtRegPassword
        '
        Me.TxtRegPassword.Location = New System.Drawing.Point(38, 147)
        Me.TxtRegPassword.Name = "TxtRegPassword"
        Me.TxtRegPassword.Size = New System.Drawing.Size(233, 20)
        Me.TxtRegPassword.TabIndex = 19
        '
        'TxtRegUsername
        '
        Me.TxtRegUsername.Location = New System.Drawing.Point(38, 79)
        Me.TxtRegUsername.Name = "TxtRegUsername"
        Me.TxtRegUsername.Size = New System.Drawing.Size(233, 20)
        Me.TxtRegUsername.TabIndex = 18
        '
        'LblRegPassword
        '
        Me.LblRegPassword.AutoSize = True
        Me.LblRegPassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegPassword.Location = New System.Drawing.Point(35, 119)
        Me.LblRegPassword.Name = "LblRegPassword"
        Me.LblRegPassword.Size = New System.Drawing.Size(61, 13)
        Me.LblRegPassword.TabIndex = 17
        Me.LblRegPassword.Text = "Password"
        '
        'LblRegUsername
        '
        Me.LblRegUsername.AutoSize = True
        Me.LblRegUsername.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegUsername.Location = New System.Drawing.Point(35, 53)
        Me.LblRegUsername.Name = "LblRegUsername"
        Me.LblRegUsername.Size = New System.Drawing.Size(65, 13)
        Me.LblRegUsername.TabIndex = 16
        Me.LblRegUsername.Text = "Username"
        '
        'TxtHurufUsername
        '
        Me.TxtHurufUsername.Location = New System.Drawing.Point(277, 79)
        Me.TxtHurufUsername.Name = "TxtHurufUsername"
        Me.TxtHurufUsername.Size = New System.Drawing.Size(26, 20)
        Me.TxtHurufUsername.TabIndex = 27
        '
        'TxtHurufPassword
        '
        Me.TxtHurufPassword.Location = New System.Drawing.Point(277, 147)
        Me.TxtHurufPassword.Name = "TxtHurufPassword"
        Me.TxtHurufPassword.Size = New System.Drawing.Size(26, 20)
        Me.TxtHurufPassword.TabIndex = 28
        '
        'TxtPasswordLagi
        '
        Me.TxtPasswordLagi.Location = New System.Drawing.Point(38, 210)
        Me.TxtPasswordLagi.Name = "TxtPasswordLagi"
        Me.TxtPasswordLagi.Size = New System.Drawing.Size(276, 20)
        Me.TxtPasswordLagi.TabIndex = 30
        '
        'LblPasswordLagi
        '
        Me.LblPasswordLagi.AutoSize = True
        Me.LblPasswordLagi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPasswordLagi.Location = New System.Drawing.Point(35, 182)
        Me.LblPasswordLagi.Name = "LblPasswordLagi"
        Me.LblPasswordLagi.Size = New System.Drawing.Size(149, 13)
        Me.LblPasswordLagi.TabIndex = 29
        Me.LblPasswordLagi.Text = "Masukkan Password Lagi"
        '
        'PnlLogo
        '
        Me.PnlLogo.BackgroundImage = Global.sistem_pergudangan.My.Resources.Resources.Adidas
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlLogo.Location = New System.Drawing.Point(252, 12)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(82, 39)
        Me.PnlLogo.TabIndex = 39
        '
        'BuatAkun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 297)
        Me.Controls.Add(Me.PnlLogo)
        Me.Controls.Add(Me.TxtPasswordLagi)
        Me.Controls.Add(Me.LblPasswordLagi)
        Me.Controls.Add(Me.TxtHurufPassword)
        Me.Controls.Add(Me.TxtHurufUsername)
        Me.Controls.Add(Me.BtnRegClear)
        Me.Controls.Add(Me.BtnRegBuat)
        Me.Controls.Add(Me.TxtRegPassword)
        Me.Controls.Add(Me.TxtRegUsername)
        Me.Controls.Add(Me.LblRegPassword)
        Me.Controls.Add(Me.LblRegUsername)
        Me.Controls.Add(Me.LblBuatAkun)
        Me.Name = "BuatAkun"
        Me.Text = "BuatAkun"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBuatAkun As Label
    Friend WithEvents BtnRegClear As Button
    Friend WithEvents BtnRegBuat As Button
    Friend WithEvents TxtRegPassword As TextBox
    Friend WithEvents TxtRegUsername As TextBox
    Friend WithEvents LblRegPassword As Label
    Friend WithEvents LblRegUsername As Label
    Friend WithEvents TxtHurufUsername As TextBox
    Friend WithEvents TxtHurufPassword As TextBox
    Friend WithEvents TxtPasswordLagi As TextBox
    Friend WithEvents LblPasswordLagi As Label
    Friend WithEvents PnlLogo As Panel
End Class
