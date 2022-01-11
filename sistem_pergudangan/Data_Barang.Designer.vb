<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Barang
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
        Me.DGV_Data_Barang = New System.Windows.Forms.DataGridView()
        Me.Button_Pilih = New System.Windows.Forms.Button()
        Me.Button_Tutup = New System.Windows.Forms.Button()
        CType(Me.DGV_Data_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Data_Barang
        '
        Me.DGV_Data_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Data_Barang.Location = New System.Drawing.Point(12, 12)
        Me.DGV_Data_Barang.Name = "DGV_Data_Barang"
        Me.DGV_Data_Barang.Size = New System.Drawing.Size(349, 165)
        Me.DGV_Data_Barang.TabIndex = 0
        '
        'Button_Pilih
        '
        Me.Button_Pilih.Location = New System.Drawing.Point(481, 43)
        Me.Button_Pilih.Name = "Button_Pilih"
        Me.Button_Pilih.Size = New System.Drawing.Size(75, 23)
        Me.Button_Pilih.TabIndex = 1
        Me.Button_Pilih.Text = "Pilih"
        Me.Button_Pilih.UseVisualStyleBackColor = True
        '
        'Button_Tutup
        '
        Me.Button_Tutup.Location = New System.Drawing.Point(481, 114)
        Me.Button_Tutup.Name = "Button_Tutup"
        Me.Button_Tutup.Size = New System.Drawing.Size(75, 23)
        Me.Button_Tutup.TabIndex = 2
        Me.Button_Tutup.Text = "Tutup"
        Me.Button_Tutup.UseVisualStyleBackColor = True
        '
        'Data_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Tutup)
        Me.Controls.Add(Me.Button_Pilih)
        Me.Controls.Add(Me.DGV_Data_Barang)
        Me.Name = "Data_Barang"
        Me.Text = "Data_Barang"
        CType(Me.DGV_Data_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Data_Barang As DataGridView
    Friend WithEvents Button_Pilih As Button
    Friend WithEvents Button_Tutup As Button
End Class
