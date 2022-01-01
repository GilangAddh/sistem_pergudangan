<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Stock
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        Me.LblNamaBarang = New System.Windows.Forms.Label()
        Me.LblCaptStock = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.TxtSetStock = New System.Windows.Forms.TextBox()
        Me.BtnMinStock = New System.Windows.Forms.Button()
        Me.BtnPlusStock = New System.Windows.Forms.Button()
        Me.BtnUpdateStock = New System.Windows.Forms.Button()
        Me.ColorDialogStock = New System.Windows.Forms.ColorDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBack})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(348, 25)
        Me.ToolStrip1.TabIndex = 49
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonBack
        '
        Me.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBack.Image = Global.sistem_pergudangan.My.Resources.Resources.back_exit
        Me.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBack.Name = "ToolStripButtonBack"
        Me.ToolStripButtonBack.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonBack.Text = "ToolStripButton1"
        '
        'LblNamaBarang
        '
        Me.LblNamaBarang.AutoSize = True
        Me.LblNamaBarang.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNamaBarang.Location = New System.Drawing.Point(124, 53)
        Me.LblNamaBarang.Name = "LblNamaBarang"
        Me.LblNamaBarang.Size = New System.Drawing.Size(63, 20)
        Me.LblNamaBarang.TabIndex = 50
        Me.LblNamaBarang.Text = "Nama"
        '
        'LblCaptStock
        '
        Me.LblCaptStock.AutoSize = True
        Me.LblCaptStock.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaptStock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblCaptStock.Location = New System.Drawing.Point(25, 107)
        Me.LblCaptStock.Name = "LblCaptStock"
        Me.LblCaptStock.Size = New System.Drawing.Size(49, 14)
        Me.LblCaptStock.TabIndex = 51
        Me.LblCaptStock.Text = "Stock:"
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblStock.Location = New System.Drawing.Point(157, 103)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(19, 18)
        Me.LblStock.TabIndex = 52
        Me.LblStock.Text = "0"
        '
        'TxtSetStock
        '
        Me.TxtSetStock.Location = New System.Drawing.Point(81, 147)
        Me.TxtSetStock.Name = "TxtSetStock"
        Me.TxtSetStock.Size = New System.Drawing.Size(180, 20)
        Me.TxtSetStock.TabIndex = 53
        Me.TxtSetStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnMinStock
        '
        Me.BtnMinStock.Location = New System.Drawing.Point(29, 147)
        Me.BtnMinStock.Name = "BtnMinStock"
        Me.BtnMinStock.Size = New System.Drawing.Size(46, 21)
        Me.BtnMinStock.TabIndex = 54
        Me.BtnMinStock.Text = "-"
        Me.BtnMinStock.UseVisualStyleBackColor = True
        '
        'BtnPlusStock
        '
        Me.BtnPlusStock.Location = New System.Drawing.Point(267, 146)
        Me.BtnPlusStock.Name = "BtnPlusStock"
        Me.BtnPlusStock.Size = New System.Drawing.Size(49, 21)
        Me.BtnPlusStock.TabIndex = 55
        Me.BtnPlusStock.Text = "+"
        Me.BtnPlusStock.UseVisualStyleBackColor = True
        '
        'BtnUpdateStock
        '
        Me.BtnUpdateStock.Location = New System.Drawing.Point(29, 191)
        Me.BtnUpdateStock.Name = "BtnUpdateStock"
        Me.BtnUpdateStock.Size = New System.Drawing.Size(287, 23)
        Me.BtnUpdateStock.TabIndex = 56
        Me.BtnUpdateStock.Text = "Simpan Stock"
        Me.BtnUpdateStock.UseVisualStyleBackColor = True
        '
        'Edit_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 240)
        Me.Controls.Add(Me.BtnUpdateStock)
        Me.Controls.Add(Me.BtnPlusStock)
        Me.Controls.Add(Me.BtnMinStock)
        Me.Controls.Add(Me.TxtSetStock)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.LblCaptStock)
        Me.Controls.Add(Me.LblNamaBarang)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Edit_Stock"
        Me.Text = "Edit_Stock"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonBack As ToolStripButton
    Friend WithEvents LblNamaBarang As Label
    Friend WithEvents LblCaptStock As Label
    Friend WithEvents LblStock As Label
    Friend WithEvents TxtSetStock As TextBox
    Friend WithEvents BtnMinStock As Button
    Friend WithEvents BtnPlusStock As Button
    Friend WithEvents BtnUpdateStock As Button
    Friend WithEvents ColorDialogStock As ColorDialog
End Class
