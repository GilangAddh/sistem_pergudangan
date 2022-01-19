<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Barang_Masuk
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxIDOrder = New System.Windows.Forms.TextBox()
        Me.TxtboxJumlahMasuk = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.Button_Tampilkan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxJumlahOrder = New System.Windows.Forms.TextBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.LabelIDBarang = New System.Windows.Forms.Label()
        Me.Button_Japus = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_Hapus_Barang_Masuk = New System.Windows.Forms.Button()
        CType(Me.DGV_Barang_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Barang_Order
        '
        Me.DGV_Barang_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Barang_Order.Location = New System.Drawing.Point(12, 81)
        Me.DGV_Barang_Order.Name = "DGV_Barang_Order"
        Me.DGV_Barang_Order.Size = New System.Drawing.Size(810, 202)
        Me.DGV_Barang_Order.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(856, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(856, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jumlah Masuk"
        '
        'TxtBoxIDOrder
        '
        Me.TxtBoxIDOrder.Location = New System.Drawing.Point(967, 113)
        Me.TxtBoxIDOrder.Name = "TxtBoxIDOrder"
        Me.TxtBoxIDOrder.Size = New System.Drawing.Size(109, 20)
        Me.TxtBoxIDOrder.TabIndex = 3
        '
        'TxtboxJumlahMasuk
        '
        Me.TxtboxJumlahMasuk.Location = New System.Drawing.Point(967, 211)
        Me.TxtboxJumlahMasuk.Name = "TxtboxJumlahMasuk"
        Me.TxtboxJumlahMasuk.Size = New System.Drawing.Size(109, 20)
        Me.TxtboxJumlahMasuk.TabIndex = 4
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(914, 652)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(138, 33)
        Me.BtnSimpan.TabIndex = 5
        Me.BtnSimpan.Text = "Simpan dan Tambah"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(641, 652)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(111, 33)
        Me.ButtonUpdate.TabIndex = 6
        Me.ButtonUpdate.Text = "Update Stock"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'Button_Tampilkan
        '
        Me.Button_Tampilkan.Location = New System.Drawing.Point(967, 258)
        Me.Button_Tampilkan.Name = "Button_Tampilkan"
        Me.Button_Tampilkan.Size = New System.Drawing.Size(91, 25)
        Me.Button_Tampilkan.TabIndex = 7
        Me.Button_Tampilkan.Text = "Tampilkan Data"
        Me.Button_Tampilkan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(856, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Jumlah Order"
        '
        'TextBoxJumlahOrder
        '
        Me.TextBoxJumlahOrder.Location = New System.Drawing.Point(967, 155)
        Me.TextBoxJumlahOrder.Name = "TextBoxJumlahOrder"
        Me.TextBoxJumlahOrder.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxJumlahOrder.TabIndex = 9
        '
        'LabelStatus
        '
        Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(855, 305)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(143, 20)
        Me.LabelStatus.TabIndex = 10
        Me.LabelStatus.Text = "STATUS"
        '
        'LabelIDBarang
        '
        Me.LabelIDBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDBarang.Location = New System.Drawing.Point(1067, 305)
        Me.LabelIDBarang.Name = "LabelIDBarang"
        Me.LabelIDBarang.Size = New System.Drawing.Size(114, 20)
        Me.LabelIDBarang.TabIndex = 11
        Me.LabelIDBarang.Text = "ID BARANG"
        '
        'Button_Japus
        '
        Me.Button_Japus.Location = New System.Drawing.Point(110, 652)
        Me.Button_Japus.Name = "Button_Japus"
        Me.Button_Japus.Size = New System.Drawing.Size(103, 33)
        Me.Button_Japus.TabIndex = 12
        Me.Button_Japus.Text = "Hapus Order"
        Me.Button_Japus.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 375)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(810, 202)
        Me.DataGridView1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "DataGrid Order Barang"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "DataGrid Barang Masuk"
        '
        'Btn_Hapus_Barang_Masuk
        '
        Me.Btn_Hapus_Barang_Masuk.Location = New System.Drawing.Point(346, 652)
        Me.Btn_Hapus_Barang_Masuk.Name = "Btn_Hapus_Barang_Masuk"
        Me.Btn_Hapus_Barang_Masuk.Size = New System.Drawing.Size(123, 33)
        Me.Btn_Hapus_Barang_Masuk.TabIndex = 17
        Me.Btn_Hapus_Barang_Masuk.Text = "Hapus Barang Masuk"
        Me.Btn_Hapus_Barang_Masuk.UseVisualStyleBackColor = True
        '
        'Barang_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 697)
        Me.Controls.Add(Me.Btn_Hapus_Barang_Masuk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_Japus)
        Me.Controls.Add(Me.LabelIDBarang)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.TextBoxJumlahOrder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_Tampilkan)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtboxJumlahMasuk)
        Me.Controls.Add(Me.TxtBoxIDOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_Barang_Order)
        Me.Name = "Barang_Masuk"
        Me.Text = "Barang_Masuk"
        CType(Me.DGV_Barang_Order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Barang_Order As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxIDOrder As TextBox
    Friend WithEvents TxtboxJumlahMasuk As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents Button_Tampilkan As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxJumlahOrder As TextBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelIDBarang As Label
    Friend WithEvents Button_Japus As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_Hapus_Barang_Masuk As Button
End Class
