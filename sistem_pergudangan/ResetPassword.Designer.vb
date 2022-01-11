<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPassword
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
        Me.TxtHurufPasswordBaru = New System.Windows.Forms.TextBox()
        Me.BtnNewPasswordClear = New System.Windows.Forms.Button()
        Me.BtnBuatNewPassword = New System.Windows.Forms.Button()
        Me.TxtNewPasswordLagi = New System.Windows.Forms.TextBox()
        Me.TxtNewPassword = New System.Windows.Forms.TextBox()
        Me.LblRegPassword = New System.Windows.Forms.Label()
        Me.LblNewPassword = New System.Windows.Forms.Label()
        Me.LblUbahPassword = New System.Windows.Forms.Label()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'TxtHurufPasswordBaru
        '
        Me.TxtHurufPasswordBaru.Location = New System.Drawing.Point(254, 82)
        Me.TxtHurufPasswordBaru.Name = "TxtHurufPasswordBaru"
        Me.TxtHurufPasswordBaru.Size = New System.Drawing.Size(27, 20)
        Me.TxtHurufPasswordBaru.TabIndex = 36
        '
        'BtnNewPasswordClear
        '
        Me.BtnNewPasswordClear.Location = New System.Drawing.Point(15, 197)
        Me.BtnNewPasswordClear.Name = "BtnNewPasswordClear"
        Me.BtnNewPasswordClear.Size = New System.Drawing.Size(90, 23)
        Me.BtnNewPasswordClear.TabIndex = 35
        Me.BtnNewPasswordClear.Text = "Clear"
        Me.BtnNewPasswordClear.UseVisualStyleBackColor = True
        '
        'BtnBuatNewPassword
        '
        Me.BtnBuatNewPassword.Location = New System.Drawing.Point(111, 197)
        Me.BtnBuatNewPassword.Name = "BtnBuatNewPassword"
        Me.BtnBuatNewPassword.Size = New System.Drawing.Size(170, 23)
        Me.BtnBuatNewPassword.TabIndex = 34
        Me.BtnBuatNewPassword.Text = "Update"
        Me.BtnBuatNewPassword.UseVisualStyleBackColor = True
        '
        'TxtNewPasswordLagi
        '
        Me.TxtNewPasswordLagi.Location = New System.Drawing.Point(15, 150)
        Me.TxtNewPasswordLagi.Name = "TxtNewPasswordLagi"
        Me.TxtNewPasswordLagi.Size = New System.Drawing.Size(233, 20)
        Me.TxtNewPasswordLagi.TabIndex = 33
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.Location = New System.Drawing.Point(15, 82)
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.Size = New System.Drawing.Size(233, 20)
        Me.TxtNewPassword.TabIndex = 32
        '
        'LblRegPassword
        '
        Me.LblRegPassword.AutoSize = True
        Me.LblRegPassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegPassword.Location = New System.Drawing.Point(12, 122)
        Me.LblRegPassword.Name = "LblRegPassword"
        Me.LblRegPassword.Size = New System.Drawing.Size(149, 13)
        Me.LblRegPassword.TabIndex = 31
        Me.LblRegPassword.Text = "Masukkan Password Lagi"
        '
        'LblNewPassword
        '
        Me.LblNewPassword.AutoSize = True
        Me.LblNewPassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewPassword.Location = New System.Drawing.Point(12, 56)
        Me.LblNewPassword.Name = "LblNewPassword"
        Me.LblNewPassword.Size = New System.Drawing.Size(92, 13)
        Me.LblNewPassword.TabIndex = 30
        Me.LblNewPassword.Text = "Password Baru"
        '
        'LblUbahPassword
        '
        Me.LblUbahPassword.AutoSize = True
        Me.LblUbahPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbahPassword.Location = New System.Drawing.Point(12, 20)
        Me.LblUbahPassword.Name = "LblUbahPassword"
        Me.LblUbahPassword.Size = New System.Drawing.Size(119, 16)
        Me.LblUbahPassword.TabIndex = 29
        Me.LblUbahPassword.Text = "Ubah Password"
        '
        'PnlLogo
        '
        Me.PnlLogo.BackgroundImage = Global.sistem_pergudangan.My.Resources.Resources.Adidas
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlLogo.Location = New System.Drawing.Point(212, 12)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(82, 39)
        Me.PnlLogo.TabIndex = 38
        '
        'ResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 242)
        Me.Controls.Add(Me.PnlLogo)
        Me.Controls.Add(Me.TxtHurufPasswordBaru)
        Me.Controls.Add(Me.BtnNewPasswordClear)
        Me.Controls.Add(Me.BtnBuatNewPassword)
        Me.Controls.Add(Me.TxtNewPasswordLagi)
        Me.Controls.Add(Me.TxtNewPassword)
        Me.Controls.Add(Me.LblRegPassword)
        Me.Controls.Add(Me.LblNewPassword)
        Me.Controls.Add(Me.LblUbahPassword)
        Me.Name = "ResetPassword"
        Me.Text = "ResetPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtHurufPasswordBaru As TextBox
    Friend WithEvents BtnNewPasswordClear As Button
    Friend WithEvents BtnBuatNewPassword As Button
    Friend WithEvents TxtNewPasswordLagi As TextBox
    Friend WithEvents TxtNewPassword As TextBox
    Friend WithEvents LblRegPassword As Label
    Friend WithEvents LblNewPassword As Label
    Friend WithEvents LblUbahPassword As Label
    Friend WithEvents PnlLogo As Panel
End Class
