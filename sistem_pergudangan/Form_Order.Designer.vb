<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Order
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
        Me.DGV_Barang_Order = New System.Windows.Forms.DataGridView()
        Me.LblNamaBarang = New System.Windows.Forms.Label()
        Me.TxtBox_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtB_JumlahOrder = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_TanggalOrder = New System.Windows.Forms.DateTimePicker()
        Me.Button_Cari = New System.Windows.Forms.Button()
        Me.Button_Simpan = New System.Windows.Forms.Button()
        Me.Button_Tambah = New System.Windows.Forms.Button()
        Me.TextBox_TanggalOrder = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Tampilkan = New System.Windows.Forms.Button()
        Me.LabelIDBarang = New System.Windows.Forms.Label()
        CType(Me.DGV_Barang_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Barang_Order
        '
        Me.DGV_Barang_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Barang_Order.Location = New System.Drawing.Point(12, 12)
        Me.DGV_Barang_Order.Name = "DGV_Barang_Order"
        Me.DGV_Barang_Order.Size = New System.Drawing.Size(483, 178)
        Me.DGV_Barang_Order.TabIndex = 0
        '
        'LblNamaBarang
        '
        Me.LblNamaBarang.AutoSize = True
        Me.LblNamaBarang.Location = New System.Drawing.Point(632, 28)
        Me.LblNamaBarang.Name = "LblNamaBarang"
        Me.LblNamaBarang.Size = New System.Drawing.Size(72, 13)
        Me.LblNamaBarang.TabIndex = 1
        Me.LblNamaBarang.Text = "Nama Barang"
        '
        'TxtBox_NamaBarang
        '
        Me.TxtBox_NamaBarang.Location = New System.Drawing.Point(749, 28)
        Me.TxtBox_NamaBarang.Name = "TxtBox_NamaBarang"
        Me.TxtBox_NamaBarang.Size = New System.Drawing.Size(118, 20)
        Me.TxtBox_NamaBarang.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(635, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jumlah Order"
        '
        'TxtB_JumlahOrder
        '
        Me.TxtB_JumlahOrder.Location = New System.Drawing.Point(749, 117)
        Me.TxtB_JumlahOrder.Name = "TxtB_JumlahOrder"
        Me.TxtB_JumlahOrder.Size = New System.Drawing.Size(118, 20)
        Me.TxtB_JumlahOrder.TabIndex = 5
        '
        'DateTimePicker_TanggalOrder
        '
        Me.DateTimePicker_TanggalOrder.Location = New System.Drawing.Point(749, 165)
        Me.DateTimePicker_TanggalOrder.Name = "DateTimePicker_TanggalOrder"
        Me.DateTimePicker_TanggalOrder.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker_TanggalOrder.TabIndex = 6
        '
        'Button_Cari
        '
        Me.Button_Cari.Location = New System.Drawing.Point(882, 26)
        Me.Button_Cari.Name = "Button_Cari"
        Me.Button_Cari.Size = New System.Drawing.Size(58, 22)
        Me.Button_Cari.TabIndex = 7
        Me.Button_Cari.Text = "Cari"
        Me.Button_Cari.UseVisualStyleBackColor = True
        '
        'Button_Simpan
        '
        Me.Button_Simpan.Location = New System.Drawing.Point(635, 334)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(132, 22)
        Me.Button_Simpan.TabIndex = 8
        Me.Button_Simpan.Text = "Simpan ke Database"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'Button_Tambah
        '
        Me.Button_Tambah.Location = New System.Drawing.Point(839, 334)
        Me.Button_Tambah.Name = "Button_Tambah"
        Me.Button_Tambah.Size = New System.Drawing.Size(101, 22)
        Me.Button_Tambah.TabIndex = 9
        Me.Button_Tambah.Text = "Tambah Order"
        Me.Button_Tambah.UseVisualStyleBackColor = True
        '
        'TextBox_TanggalOrder
        '
        Me.TextBox_TanggalOrder.Location = New System.Drawing.Point(749, 223)
        Me.TextBox_TanggalOrder.Name = "TextBox_TanggalOrder"
        Me.TextBox_TanggalOrder.Size = New System.Drawing.Size(118, 20)
        Me.TextBox_TanggalOrder.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(632, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tanggal Order"
        '
        'Btn_Tampilkan
        '
        Me.Btn_Tampilkan.Location = New System.Drawing.Point(635, 207)
        Me.Btn_Tampilkan.Name = "Btn_Tampilkan"
        Me.Btn_Tampilkan.Size = New System.Drawing.Size(90, 36)
        Me.Btn_Tampilkan.TabIndex = 12
        Me.Btn_Tampilkan.Text = "Tampilkan Tanngal Order"
        Me.Btn_Tampilkan.UseVisualStyleBackColor = True
        '
        'LabelIDBarang
        '
        Me.LabelIDBarang.AutoSize = True
        Me.LabelIDBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDBarang.Location = New System.Drawing.Point(746, 69)
        Me.LabelIDBarang.Name = "LabelIDBarang"
        Me.LabelIDBarang.Size = New System.Drawing.Size(77, 16)
        Me.LabelIDBarang.TabIndex = 14
        Me.LabelIDBarang.Text = "ID Barang"
        '
        'Form_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 394)
        Me.Controls.Add(Me.LabelIDBarang)
        Me.Controls.Add(Me.Button_Cari)
        Me.Controls.Add(Me.Btn_Tampilkan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_TanggalOrder)
        Me.Controls.Add(Me.Button_Tambah)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.DateTimePicker_TanggalOrder)
        Me.Controls.Add(Me.TxtB_JumlahOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBox_NamaBarang)
        Me.Controls.Add(Me.LblNamaBarang)
        Me.Controls.Add(Me.DGV_Barang_Order)
        Me.Name = "Form_Order"
        Me.Text = "Form_Order"
        CType(Me.DGV_Barang_Order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Barang_Order As DataGridView
    Friend WithEvents LblNamaBarang As Label
    Friend WithEvents TxtBox_NamaBarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtB_JumlahOrder As TextBox
    Friend WithEvents DateTimePicker_TanggalOrder As DateTimePicker
    Friend WithEvents Button_Cari As Button
    Friend WithEvents Button_Simpan As Button
    Friend WithEvents Button_Tambah As Button
    Friend WithEvents TextBox_TanggalOrder As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Tampilkan As Button
    Friend WithEvents LabelIDBarang As Label
End Class
