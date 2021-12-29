<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblCaptUsername = New System.Windows.Forms.Label()
        Me.LblCaptPassword = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.LblLupaAkun = New System.Windows.Forms.Label()
        Me.LblReset = New System.Windows.Forms.Label()
        Me.LblAtau = New System.Windows.Forms.Label()
        Me.LblDaftar = New System.Windows.Forms.Label()
        Me.LblBelumPunyaAkun = New System.Windows.Forms.Label()
        Me.PnlPassword = New System.Windows.Forms.Panel()
        Me.PnlUsername = New System.Windows.Forms.Panel()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.ColorDialogLink = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'LblCaptUsername
        '
        Me.LblCaptUsername.AutoSize = True
        Me.LblCaptUsername.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaptUsername.Location = New System.Drawing.Point(65, 152)
        Me.LblCaptUsername.Name = "LblCaptUsername"
        Me.LblCaptUsername.Size = New System.Drawing.Size(65, 13)
        Me.LblCaptUsername.TabIndex = 1
        Me.LblCaptUsername.Text = "Username"
        '
        'LblCaptPassword
        '
        Me.LblCaptPassword.AutoSize = True
        Me.LblCaptPassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaptPassword.Location = New System.Drawing.Point(65, 218)
        Me.LblCaptPassword.Name = "LblCaptPassword"
        Me.LblCaptPassword.Size = New System.Drawing.Size(61, 13)
        Me.LblCaptPassword.TabIndex = 2
        Me.LblCaptPassword.Text = "Password"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(68, 178)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(223, 20)
        Me.TxtUsername.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(68, 246)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(223, 20)
        Me.TxtPassword.TabIndex = 4
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(155, 286)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(136, 23)
        Me.BtnLogin.TabIndex = 7
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(68, 286)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(81, 23)
        Me.BtnClear.TabIndex = 8
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'LblLupaAkun
        '
        Me.LblLupaAkun.AutoSize = True
        Me.LblLupaAkun.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLupaAkun.Location = New System.Drawing.Point(89, 321)
        Me.LblLupaAkun.Name = "LblLupaAkun"
        Me.LblLupaAkun.Size = New System.Drawing.Size(86, 12)
        Me.LblLupaAkun.TabIndex = 9
        Me.LblLupaAkun.Text = "Lupa Password?"
        '
        'LblReset
        '
        Me.LblReset.AutoSize = True
        Me.LblReset.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReset.ForeColor = System.Drawing.Color.Blue
        Me.LblReset.Location = New System.Drawing.Point(171, 321)
        Me.LblReset.Name = "LblReset"
        Me.LblReset.Size = New System.Drawing.Size(97, 12)
        Me.LblReset.TabIndex = 10
        Me.LblReset.Text = "Dapatkan Bantuan"
        '
        'LblAtau
        '
        Me.LblAtau.AutoSize = True
        Me.LblAtau.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAtau.Location = New System.Drawing.Point(165, 349)
        Me.LblAtau.Name = "LblAtau"
        Me.LblAtau.Size = New System.Drawing.Size(29, 12)
        Me.LblAtau.TabIndex = 11
        Me.LblAtau.Text = "Atau"
        '
        'LblDaftar
        '
        Me.LblDaftar.AutoSize = True
        Me.LblDaftar.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDaftar.ForeColor = System.Drawing.Color.Blue
        Me.LblDaftar.Location = New System.Drawing.Point(211, 379)
        Me.LblDaftar.Name = "LblDaftar"
        Me.LblDaftar.Size = New System.Drawing.Size(36, 12)
        Me.LblDaftar.TabIndex = 14
        Me.LblDaftar.Text = "Daftar"
        '
        'LblBelumPunyaAkun
        '
        Me.LblBelumPunyaAkun.AutoSize = True
        Me.LblBelumPunyaAkun.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBelumPunyaAkun.Location = New System.Drawing.Point(110, 379)
        Me.LblBelumPunyaAkun.Name = "LblBelumPunyaAkun"
        Me.LblBelumPunyaAkun.Size = New System.Drawing.Size(105, 12)
        Me.LblBelumPunyaAkun.TabIndex = 13
        Me.LblBelumPunyaAkun.Text = "Belum Punya Akun?"
        '
        'PnlPassword
        '
        Me.PnlPassword.BackgroundImage = Global.sistem_pergudangan.My.Resources.Resources.lock
        Me.PnlPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlPassword.Location = New System.Drawing.Point(22, 236)
        Me.PnlPassword.Name = "PnlPassword"
        Me.PnlPassword.Size = New System.Drawing.Size(33, 30)
        Me.PnlPassword.TabIndex = 6
        '
        'PnlUsername
        '
        Me.PnlUsername.BackgroundImage = Global.sistem_pergudangan.My.Resources.Resources.account1
        Me.PnlUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlUsername.Location = New System.Drawing.Point(22, 168)
        Me.PnlUsername.Name = "PnlUsername"
        Me.PnlUsername.Size = New System.Drawing.Size(29, 30)
        Me.PnlUsername.TabIndex = 5
        '
        'PnlLogo
        '
        Me.PnlLogo.BackgroundImage = Global.sistem_pergudangan.My.Resources.Resources.Adidas
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlLogo.Location = New System.Drawing.Point(68, 22)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(209, 100)
        Me.PnlLogo.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 413)
        Me.Controls.Add(Me.LblDaftar)
        Me.Controls.Add(Me.LblBelumPunyaAkun)
        Me.Controls.Add(Me.LblAtau)
        Me.Controls.Add(Me.LblReset)
        Me.Controls.Add(Me.LblLupaAkun)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.PnlPassword)
        Me.Controls.Add(Me.PnlUsername)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LblCaptPassword)
        Me.Controls.Add(Me.LblCaptUsername)
        Me.Controls.Add(Me.PnlLogo)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlLogo As Panel
    Friend WithEvents LblCaptUsername As Label
    Friend WithEvents LblCaptPassword As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents PnlUsername As Panel
    Friend WithEvents PnlPassword As Panel
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents LblLupaAkun As Label
    Friend WithEvents LblReset As Label
    Friend WithEvents LblAtau As Label
    Friend WithEvents LblDaftar As Label
    Friend WithEvents LblBelumPunyaAkun As Label
    Friend WithEvents ColorDialogLink As ColorDialog
End Class
