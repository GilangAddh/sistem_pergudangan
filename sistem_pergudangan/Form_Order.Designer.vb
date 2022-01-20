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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuJenis = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripFormBarang = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        CType(Me.DGV_Barang_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStripFormBarang.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Barang_Order
        '
        Me.DGV_Barang_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Barang_Order.Location = New System.Drawing.Point(12, 66)
        Me.DGV_Barang_Order.Name = "DGV_Barang_Order"
        Me.DGV_Barang_Order.Size = New System.Drawing.Size(483, 178)
        Me.DGV_Barang_Order.TabIndex = 0
        '
        'LblNamaBarang
        '
        Me.LblNamaBarang.AutoSize = True
        Me.LblNamaBarang.Location = New System.Drawing.Point(632, 82)
        Me.LblNamaBarang.Name = "LblNamaBarang"
        Me.LblNamaBarang.Size = New System.Drawing.Size(72, 13)
        Me.LblNamaBarang.TabIndex = 1
        Me.LblNamaBarang.Text = "Nama Barang"
        '
        'TxtBox_NamaBarang
        '
        Me.TxtBox_NamaBarang.Location = New System.Drawing.Point(749, 82)
        Me.TxtBox_NamaBarang.Name = "TxtBox_NamaBarang"
        Me.TxtBox_NamaBarang.Size = New System.Drawing.Size(118, 20)
        Me.TxtBox_NamaBarang.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(635, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jumlah Order"
        '
        'TxtB_JumlahOrder
        '
        Me.TxtB_JumlahOrder.Location = New System.Drawing.Point(749, 171)
        Me.TxtB_JumlahOrder.Name = "TxtB_JumlahOrder"
        Me.TxtB_JumlahOrder.Size = New System.Drawing.Size(118, 20)
        Me.TxtB_JumlahOrder.TabIndex = 5
        '
        'DateTimePicker_TanggalOrder
        '
        Me.DateTimePicker_TanggalOrder.Location = New System.Drawing.Point(749, 219)
        Me.DateTimePicker_TanggalOrder.Name = "DateTimePicker_TanggalOrder"
        Me.DateTimePicker_TanggalOrder.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker_TanggalOrder.TabIndex = 6
        '
        'Button_Cari
        '
        Me.Button_Cari.Location = New System.Drawing.Point(882, 80)
        Me.Button_Cari.Name = "Button_Cari"
        Me.Button_Cari.Size = New System.Drawing.Size(58, 22)
        Me.Button_Cari.TabIndex = 7
        Me.Button_Cari.Text = "Cari"
        Me.Button_Cari.UseVisualStyleBackColor = True
        '
        'Button_Simpan
        '
        Me.Button_Simpan.Location = New System.Drawing.Point(635, 388)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(132, 22)
        Me.Button_Simpan.TabIndex = 8
        Me.Button_Simpan.Text = "Simpan ke Database"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'Button_Tambah
        '
        Me.Button_Tambah.Location = New System.Drawing.Point(839, 388)
        Me.Button_Tambah.Name = "Button_Tambah"
        Me.Button_Tambah.Size = New System.Drawing.Size(101, 22)
        Me.Button_Tambah.TabIndex = 9
        Me.Button_Tambah.Text = "Tambah Order"
        Me.Button_Tambah.UseVisualStyleBackColor = True
        '
        'TextBox_TanggalOrder
        '
        Me.TextBox_TanggalOrder.Location = New System.Drawing.Point(749, 277)
        Me.TextBox_TanggalOrder.Name = "TextBox_TanggalOrder"
        Me.TextBox_TanggalOrder.Size = New System.Drawing.Size(118, 20)
        Me.TextBox_TanggalOrder.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(632, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tanggal Order"
        '
        'Btn_Tampilkan
        '
        Me.Btn_Tampilkan.Location = New System.Drawing.Point(635, 261)
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
        Me.LabelIDBarang.Location = New System.Drawing.Point(746, 123)
        Me.LabelIDBarang.Name = "LabelIDBarang"
        Me.LabelIDBarang.Size = New System.Drawing.Size(77, 16)
        Me.LabelIDBarang.TabIndex = 14
        Me.LabelIDBarang.Text = "ID Barang"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(966, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenu
        '
        Me.ToolStripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuJenis, Me.ToolStripMenuItem3})
        Me.ToolStripMenu.Name = "ToolStripMenu"
        Me.ToolStripMenu.Size = New System.Drawing.Size(53, 20)
        Me.ToolStripMenu.Text = "Menu "
        '
        'ToolStripMenuJenis
        '
        Me.ToolStripMenuJenis.Name = "ToolStripMenuJenis"
        Me.ToolStripMenuJenis.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuJenis.Text = "Jenis Barang"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem3.Text = "Data Barang"
        '
        'ToolStripFormBarang
        '
        Me.ToolStripFormBarang.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBack})
        Me.ToolStripFormBarang.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripFormBarang.Name = "ToolStripFormBarang"
        Me.ToolStripFormBarang.Size = New System.Drawing.Size(966, 25)
        Me.ToolStripFormBarang.TabIndex = 16
        Me.ToolStripFormBarang.Text = "ToolStrip1"
        '
        'ToolStripButtonBack
        '
        Me.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBack.Image = Global.sistem_pergudangan.My.Resources.Resources.back_exit
        Me.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBack.Name = "ToolStripButtonBack"
        Me.ToolStripButtonBack.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonBack.Text = "ToolStripButtonBack"
        '
        'Form_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 432)
        Me.Controls.Add(Me.ToolStripFormBarang)
        Me.Controls.Add(Me.MenuStrip1)
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
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStripFormBarang.ResumeLayout(False)
        Me.ToolStripFormBarang.PerformLayout()
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenu As ToolStripMenuItem
    Friend WithEvents ToolStripMenuJenis As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripFormBarang As ToolStrip
    Friend WithEvents ToolStripButtonBack As ToolStripButton
End Class
