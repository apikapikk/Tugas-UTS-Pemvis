<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormData))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_kosongkan = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.txt_id_barang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_stok_barang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_harga_produksi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tahun_produksi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tipe_barang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_merk_barang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.id_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merk_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_produksi_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-5, 801)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1643, 50)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SF UI  Text Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(20, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(845, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Designed And Development By Kelompok 4 || Muhammad Alfan Muwaffiqul Ihsan || Nare" &
    "ndra Adi Nugraha"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(-5, 90)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1612, 718)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btn_kosongkan)
        Me.GroupBox2.Controls.Add(Me.btn_hapus)
        Me.GroupBox2.Controls.Add(Me.btn_ubah)
        Me.GroupBox2.Controls.Add(Me.btn_tambah)
        Me.GroupBox2.Controls.Add(Me.txt_id_barang)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_stok_barang)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_harga_produksi)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_tahun_produksi)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_tipe_barang)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_merk_barang)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("SF UI  Text", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 687)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Barang"
        '
        'btn_kosongkan
        '
        Me.btn_kosongkan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_kosongkan.BackColor = System.Drawing.Color.Navy
        Me.btn_kosongkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_kosongkan.ForeColor = System.Drawing.Color.White
        Me.btn_kosongkan.Location = New System.Drawing.Point(16, 587)
        Me.btn_kosongkan.Name = "btn_kosongkan"
        Me.btn_kosongkan.Size = New System.Drawing.Size(213, 39)
        Me.btn_kosongkan.TabIndex = 19
        Me.btn_kosongkan.Text = "KOSONGKAN"
        Me.btn_kosongkan.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_hapus.ForeColor = System.Drawing.Color.White
        Me.btn_hapus.Location = New System.Drawing.Point(16, 530)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(213, 39)
        Me.btn_hapus.TabIndex = 18
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_ubah
        '
        Me.btn_ubah.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ubah.BackColor = System.Drawing.Color.Navy
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ubah.ForeColor = System.Drawing.Color.White
        Me.btn_ubah.Location = New System.Drawing.Point(16, 472)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(213, 39)
        Me.btn_ubah.TabIndex = 17
        Me.btn_ubah.Text = "UBAH"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'btn_tambah
        '
        Me.btn_tambah.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_tambah.BackColor = System.Drawing.Color.Navy
        Me.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_tambah.ForeColor = System.Drawing.Color.White
        Me.btn_tambah.Location = New System.Drawing.Point(16, 414)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(213, 39)
        Me.btn_tambah.TabIndex = 16
        Me.btn_tambah.Text = "TAMBAH"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'txt_id_barang
        '
        Me.txt_id_barang.Location = New System.Drawing.Point(16, 48)
        Me.txt_id_barang.Name = "txt_id_barang"
        Me.txt_id_barang.Size = New System.Drawing.Size(213, 28)
        Me.txt_id_barang.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ID BARANG"
        '
        'txt_stok_barang
        '
        Me.txt_stok_barang.Location = New System.Drawing.Point(16, 323)
        Me.txt_stok_barang.Name = "txt_stok_barang"
        Me.txt_stok_barang.Size = New System.Drawing.Size(213, 28)
        Me.txt_stok_barang.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "STOK BARANG"
        '
        'txt_harga_produksi
        '
        Me.txt_harga_produksi.Location = New System.Drawing.Point(16, 268)
        Me.txt_harga_produksi.Name = "txt_harga_produksi"
        Me.txt_harga_produksi.Size = New System.Drawing.Size(213, 28)
        Me.txt_harga_produksi.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "HARGA SATUAN"
        '
        'txt_tahun_produksi
        '
        Me.txt_tahun_produksi.Location = New System.Drawing.Point(16, 213)
        Me.txt_tahun_produksi.Name = "txt_tahun_produksi"
        Me.txt_tahun_produksi.Size = New System.Drawing.Size(213, 28)
        Me.txt_tahun_produksi.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TAHUN PRODUKSI"
        '
        'txt_tipe_barang
        '
        Me.txt_tipe_barang.Location = New System.Drawing.Point(16, 158)
        Me.txt_tipe_barang.Name = "txt_tipe_barang"
        Me.txt_tipe_barang.Size = New System.Drawing.Size(213, 28)
        Me.txt_tipe_barang.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TIPE BARANG "
        '
        'txt_merk_barang
        '
        Me.txt_merk_barang.Location = New System.Drawing.Point(16, 103)
        Me.txt_merk_barang.Name = "txt_merk_barang"
        Me.txt_merk_barang.Size = New System.Drawing.Size(213, 28)
        Me.txt_merk_barang.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "NAMA BARANG "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGV1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("SF UI  Text", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(262, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1271, 693)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Barang"
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_barang, Me.merk_barang, Me.tipe_barang, Me.tahun_produksi_barang, Me.harga_barang, Me.stok_barang})
        Me.DGV1.Location = New System.Drawing.Point(6, 122)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersWidth = 51
        Me.DGV1.RowTemplate.Height = 24
        Me.DGV1.Size = New System.Drawing.Size(1250, 565)
        Me.DGV1.TabIndex = 1
        '
        'id_barang
        '
        Me.id_barang.HeaderText = "ID BARANG"
        Me.id_barang.MinimumWidth = 6
        Me.id_barang.Name = "id_barang"
        Me.id_barang.ReadOnly = True
        Me.id_barang.Width = 125
        '
        'merk_barang
        '
        Me.merk_barang.HeaderText = "MERK BARANG"
        Me.merk_barang.MinimumWidth = 6
        Me.merk_barang.Name = "merk_barang"
        Me.merk_barang.ReadOnly = True
        Me.merk_barang.Width = 120
        '
        'tipe_barang
        '
        Me.tipe_barang.HeaderText = "TIPE BARANG"
        Me.tipe_barang.MinimumWidth = 6
        Me.tipe_barang.Name = "tipe_barang"
        Me.tipe_barang.ReadOnly = True
        Me.tipe_barang.Width = 200
        '
        'tahun_produksi_barang
        '
        Me.tahun_produksi_barang.HeaderText = "TAHUN PRODUKSI"
        Me.tahun_produksi_barang.MinimumWidth = 6
        Me.tahun_produksi_barang.Name = "tahun_produksi_barang"
        Me.tahun_produksi_barang.ReadOnly = True
        Me.tahun_produksi_barang.Width = 125
        '
        'harga_barang
        '
        Me.harga_barang.HeaderText = "HARGA BARANG"
        Me.harga_barang.MinimumWidth = 6
        Me.harga_barang.Name = "harga_barang"
        Me.harga_barang.ReadOnly = True
        Me.harga_barang.Width = 200
        '
        'stok_barang
        '
        Me.stok_barang.HeaderText = "STOK BARANG"
        Me.stok_barang.MinimumWidth = 6
        Me.stok_barang.Name = "stok_barang"
        Me.stok_barang.ReadOnly = True
        Me.stok_barang.Width = 125
        '
        'Button3
        '
        Me.Button3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Navy
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1085, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 39)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "CARI"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("SF UI  Text", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(685, 40)
        Me.TextBox1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("SF UI  Text", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(18, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(927, 57)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "DATA BARANG RIZEKI JAYA KOMPUTER"
        '
        'Button6
        '
        Me.Button6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(1475, 29)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(53, 50)
        Me.Button6.TabIndex = 16
        Me.Button6.UseVisualStyleBackColor = False
        '
        'FormData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1610, 850)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormData"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_kosongkan As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents txt_id_barang As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_stok_barang As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_harga_produksi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_tahun_produksi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_tipe_barang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_merk_barang As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents id_barang As DataGridViewTextBoxColumn
    Friend WithEvents merk_barang As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang As DataGridViewTextBoxColumn
    Friend WithEvents tahun_produksi_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga_barang As DataGridViewTextBoxColumn
    Friend WithEvents stok_barang As DataGridViewTextBoxColumn
End Class
