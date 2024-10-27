<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKasir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKasir))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_name_user = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_total_harga = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lb_id_transaksi = New System.Windows.Forms.Label()
        Me.DGV2Kasir = New System.Windows.Forms.DataGridView()
        Me.id_barang_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merk_barang_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_produksi_barang_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_satuan_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_total_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kuantitas_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waktu_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.garansi_barang_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_pegawai_kasir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_telepon = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_pembeli = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.txt_kembalian = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_nominal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lb_tahun_produksi = New System.Windows.Forms.Label()
        Me.lb_id_produk = New System.Windows.Forms.Label()
        Me.lb_total_harga = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lb_merk = New System.Windows.Forms.Label()
        Me.lb_tipe_produk = New System.Windows.Forms.Label()
        Me.lb_harga_satuan = New System.Windows.Forms.Label()
        Me.dt_garansi = New System.Windows.Forms.DateTimePicker()
        Me.nd_quantity = New System.Windows.Forms.NumericUpDown()
        Me.btn_tambahkan = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.id_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merk_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_produksi_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lb_2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV2Kasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nd_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lb_name_user)
        Me.Panel1.Location = New System.Drawing.Point(-3, 812)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1612, 40)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("SF UI  Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(1271, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Login Sebagai :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SF UI  Text Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(845, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Designed And Development By Kelompok 4 || Muhammad Alfan Muwaffiqul Ihsan || Nare" &
    "ndra Adi Nugraha"
        '
        'lb_name_user
        '
        Me.lb_name_user.AutoSize = True
        Me.lb_name_user.BackColor = System.Drawing.Color.Transparent
        Me.lb_name_user.Font = New System.Drawing.Font("SF UI  Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_name_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_name_user.Location = New System.Drawing.Point(1394, 11)
        Me.lb_name_user.Name = "lb_name_user"
        Me.lb_name_user.Size = New System.Drawing.Size(87, 18)
        Me.lb_name_user.TabIndex = 8
        Me.lb_name_user.Text = "User Name"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(-3, 95)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1612, 718)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txt_total_harga)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Font = New System.Drawing.Font("SF UI  Text", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(1130, 18)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(426, 161)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total "
        '
        'txt_total_harga
        '
        Me.txt_total_harga.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total_harga.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_total_harga.Font = New System.Drawing.Font("SF UI  Text", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_harga.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_total_harga.Location = New System.Drawing.Point(10, 48)
        Me.txt_total_harga.Name = "txt_total_harga"
        Me.txt_total_harga.ReadOnly = True
        Me.txt_total_harga.Size = New System.Drawing.Size(409, 79)
        Me.txt_total_harga.TabIndex = 16
        Me.txt_total_harga.Text = "0"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(193, 20)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "TOTAL KESELURUHAN"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.lb_id_transaksi)
        Me.GroupBox4.Controls.Add(Me.DGV2Kasir)
        Me.GroupBox4.Font = New System.Drawing.Font("SF UI  Text", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(557, 233)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(567, 478)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tabel Transaksi"
        '
        'lb_id_transaksi
        '
        Me.lb_id_transaksi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_id_transaksi.AutoSize = True
        Me.lb_id_transaksi.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lb_id_transaksi.Location = New System.Drawing.Point(21, 38)
        Me.lb_id_transaksi.Name = "lb_id_transaksi"
        Me.lb_id_transaksi.Size = New System.Drawing.Size(20, 20)
        Me.lb_id_transaksi.TabIndex = 17
        Me.lb_id_transaksi.Text = "0"
        '
        'DGV2Kasir
        '
        Me.DGV2Kasir.AllowUserToAddRows = False
        Me.DGV2Kasir.AllowUserToDeleteRows = False
        Me.DGV2Kasir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV2Kasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2Kasir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_barang_transaksi, Me.id_transaksi, Me.merk_barang_transaksi, Me.tipe_barang_transaksi, Me.tahun_produksi_barang_transaksi, Me.harga_satuan_transaksi, Me.harga_total_transaksi, Me.kuantitas_transaksi, Me.waktu_transaksi, Me.garansi_barang_transaksi, Me.nama_pegawai_kasir})
        Me.DGV2Kasir.Location = New System.Drawing.Point(6, 69)
        Me.DGV2Kasir.Name = "DGV2Kasir"
        Me.DGV2Kasir.ReadOnly = True
        Me.DGV2Kasir.RowHeadersWidth = 51
        Me.DGV2Kasir.RowTemplate.Height = 24
        Me.DGV2Kasir.Size = New System.Drawing.Size(555, 403)
        Me.DGV2Kasir.TabIndex = 0
        '
        'id_barang_transaksi
        '
        Me.id_barang_transaksi.HeaderText = "ID BARANG"
        Me.id_barang_transaksi.MinimumWidth = 6
        Me.id_barang_transaksi.Name = "id_barang_transaksi"
        Me.id_barang_transaksi.ReadOnly = True
        Me.id_barang_transaksi.Width = 125
        '
        'id_transaksi
        '
        Me.id_transaksi.HeaderText = "ID TRANSAKSI"
        Me.id_transaksi.MinimumWidth = 6
        Me.id_transaksi.Name = "id_transaksi"
        Me.id_transaksi.ReadOnly = True
        Me.id_transaksi.Width = 125
        '
        'merk_barang_transaksi
        '
        Me.merk_barang_transaksi.HeaderText = "MERK BARANG"
        Me.merk_barang_transaksi.MinimumWidth = 6
        Me.merk_barang_transaksi.Name = "merk_barang_transaksi"
        Me.merk_barang_transaksi.ReadOnly = True
        Me.merk_barang_transaksi.Width = 125
        '
        'tipe_barang_transaksi
        '
        Me.tipe_barang_transaksi.HeaderText = "TIPE BARANG"
        Me.tipe_barang_transaksi.MinimumWidth = 6
        Me.tipe_barang_transaksi.Name = "tipe_barang_transaksi"
        Me.tipe_barang_transaksi.ReadOnly = True
        Me.tipe_barang_transaksi.Width = 125
        '
        'tahun_produksi_barang_transaksi
        '
        Me.tahun_produksi_barang_transaksi.HeaderText = "TAHUN PRODUKSI"
        Me.tahun_produksi_barang_transaksi.MinimumWidth = 6
        Me.tahun_produksi_barang_transaksi.Name = "tahun_produksi_barang_transaksi"
        Me.tahun_produksi_barang_transaksi.ReadOnly = True
        Me.tahun_produksi_barang_transaksi.Width = 125
        '
        'harga_satuan_transaksi
        '
        Me.harga_satuan_transaksi.HeaderText = "HARGA SATUAN"
        Me.harga_satuan_transaksi.MinimumWidth = 6
        Me.harga_satuan_transaksi.Name = "harga_satuan_transaksi"
        Me.harga_satuan_transaksi.ReadOnly = True
        Me.harga_satuan_transaksi.Width = 125
        '
        'harga_total_transaksi
        '
        Me.harga_total_transaksi.HeaderText = "HARGA TOTAL"
        Me.harga_total_transaksi.MinimumWidth = 6
        Me.harga_total_transaksi.Name = "harga_total_transaksi"
        Me.harga_total_transaksi.ReadOnly = True
        Me.harga_total_transaksi.Width = 125
        '
        'kuantitas_transaksi
        '
        Me.kuantitas_transaksi.HeaderText = "QTY"
        Me.kuantitas_transaksi.MinimumWidth = 6
        Me.kuantitas_transaksi.Name = "kuantitas_transaksi"
        Me.kuantitas_transaksi.ReadOnly = True
        Me.kuantitas_transaksi.Width = 125
        '
        'waktu_transaksi
        '
        Me.waktu_transaksi.HeaderText = "WAKTU TRANSAKSI"
        Me.waktu_transaksi.MinimumWidth = 6
        Me.waktu_transaksi.Name = "waktu_transaksi"
        Me.waktu_transaksi.ReadOnly = True
        Me.waktu_transaksi.Width = 125
        '
        'garansi_barang_transaksi
        '
        Me.garansi_barang_transaksi.HeaderText = "GARANSI BARANG"
        Me.garansi_barang_transaksi.MinimumWidth = 6
        Me.garansi_barang_transaksi.Name = "garansi_barang_transaksi"
        Me.garansi_barang_transaksi.ReadOnly = True
        Me.garansi_barang_transaksi.Width = 125
        '
        'nama_pegawai_kasir
        '
        Me.nama_pegawai_kasir.HeaderText = "NAMA PEGAWAI"
        Me.nama_pegawai_kasir.MinimumWidth = 6
        Me.nama_pegawai_kasir.Name = "nama_pegawai_kasir"
        Me.nama_pegawai_kasir.ReadOnly = True
        Me.nama_pegawai_kasir.Width = 125
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txt_alamat)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_telepon)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_pembeli)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.btn_reset)
        Me.GroupBox3.Controls.Add(Me.btn_cetak)
        Me.GroupBox3.Controls.Add(Me.txt_kembalian)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txt_nominal)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("SF UI  Text", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1130, 185)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(426, 526)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pembayaran"
        '
        'txt_alamat
        '
        Me.txt_alamat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_alamat.Font = New System.Drawing.Font("SF UI  Text", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alamat.Location = New System.Drawing.Point(10, 341)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(405, 40)
        Me.txt_alamat.TabIndex = 27
        Me.txt_alamat.Text = "0"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 20)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "ALAMAT PEMBELI"
        '
        'txt_telepon
        '
        Me.txt_telepon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_telepon.Font = New System.Drawing.Font("SF UI  Text", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telepon.Location = New System.Drawing.Point(11, 275)
        Me.txt_telepon.Name = "txt_telepon"
        Me.txt_telepon.Size = New System.Drawing.Size(405, 40)
        Me.txt_telepon.TabIndex = 25
        Me.txt_telepon.Text = "0"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 252)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(164, 20)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "TELEPON PEMBELI"
        '
        'txt_pembeli
        '
        Me.txt_pembeli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_pembeli.Font = New System.Drawing.Font("SF UI  Text", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pembeli.Location = New System.Drawing.Point(11, 210)
        Me.txt_pembeli.Name = "txt_pembeli"
        Me.txt_pembeli.Size = New System.Drawing.Size(405, 40)
        Me.txt_pembeli.TabIndex = 23
        Me.txt_pembeli.Text = "0"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 20)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "NAMA PEMBELI"
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.BackColor = System.Drawing.Color.Navy
        Me.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_reset.ForeColor = System.Drawing.Color.White
        Me.btn_reset.Location = New System.Drawing.Point(230, 427)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(189, 93)
        Me.btn_reset.TabIndex = 22
        Me.btn_reset.Text = "RESET"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_cetak
        '
        Me.btn_cetak.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cetak.BackColor = System.Drawing.Color.Navy
        Me.btn_cetak.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cetak.ForeColor = System.Drawing.Color.White
        Me.btn_cetak.Location = New System.Drawing.Point(10, 427)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(199, 93)
        Me.btn_cetak.TabIndex = 21
        Me.btn_cetak.Text = "CETAK"
        Me.btn_cetak.UseVisualStyleBackColor = False
        '
        'txt_kembalian
        '
        Me.txt_kembalian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_kembalian.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txt_kembalian.Font = New System.Drawing.Font("SF UI  Text", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kembalian.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_kembalian.Location = New System.Drawing.Point(10, 130)
        Me.txt_kembalian.Name = "txt_kembalian"
        Me.txt_kembalian.ReadOnly = True
        Me.txt_kembalian.Size = New System.Drawing.Size(409, 47)
        Me.txt_kembalian.TabIndex = 20
        Me.txt_kembalian.Text = "0"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(161, 20)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "UANG KEMBALIAN"
        '
        'txt_nominal
        '
        Me.txt_nominal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nominal.Font = New System.Drawing.Font("SF UI  Text", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nominal.Location = New System.Drawing.Point(10, 56)
        Me.txt_nominal.Name = "txt_nominal"
        Me.txt_nominal.Size = New System.Drawing.Size(405, 40)
        Me.txt_nominal.TabIndex = 16
        Me.txt_nominal.Text = "0"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(315, 20)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "MASUKKAN SEJUMLAH UANG TUNAI"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lb_tahun_produksi)
        Me.GroupBox2.Controls.Add(Me.lb_id_produk)
        Me.GroupBox2.Controls.Add(Me.lb_total_harga)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lb_merk)
        Me.GroupBox2.Controls.Add(Me.lb_tipe_produk)
        Me.GroupBox2.Controls.Add(Me.lb_harga_satuan)
        Me.GroupBox2.Controls.Add(Me.dt_garansi)
        Me.GroupBox2.Controls.Add(Me.nd_quantity)
        Me.GroupBox2.Controls.Add(Me.btn_tambahkan)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("SF UI  Text", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(571, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 209)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Barang"
        '
        'lb_tahun_produksi
        '
        Me.lb_tahun_produksi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_tahun_produksi.AutoSize = True
        Me.lb_tahun_produksi.Location = New System.Drawing.Point(96, 67)
        Me.lb_tahun_produksi.Name = "lb_tahun_produksi"
        Me.lb_tahun_produksi.Size = New System.Drawing.Size(103, 20)
        Me.lb_tahun_produksi.TabIndex = 16
        Me.lb_tahun_produksi.Text = "no selected"
        '
        'lb_id_produk
        '
        Me.lb_id_produk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_id_produk.AutoSize = True
        Me.lb_id_produk.Location = New System.Drawing.Point(288, 173)
        Me.lb_id_produk.Name = "lb_id_produk"
        Me.lb_id_produk.Size = New System.Drawing.Size(103, 20)
        Me.lb_id_produk.TabIndex = 15
        Me.lb_id_produk.Text = "no selected"
        '
        'lb_total_harga
        '
        Me.lb_total_harga.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_total_harga.AutoSize = True
        Me.lb_total_harga.Location = New System.Drawing.Point(154, 173)
        Me.lb_total_harga.Name = "lb_total_harga"
        Me.lb_total_harga.Size = New System.Drawing.Size(20, 20)
        Me.lb_total_harga.TabIndex = 14
        Me.lb_total_harga.Text = "0"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("SF UI  Text Med", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "TOTAL HARGA :"
        '
        'lb_merk
        '
        Me.lb_merk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_merk.AutoSize = True
        Me.lb_merk.Location = New System.Drawing.Point(7, 67)
        Me.lb_merk.Name = "lb_merk"
        Me.lb_merk.Size = New System.Drawing.Size(103, 20)
        Me.lb_merk.TabIndex = 12
        Me.lb_merk.Text = "no selected"
        '
        'lb_tipe_produk
        '
        Me.lb_tipe_produk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_tipe_produk.AutoSize = True
        Me.lb_tipe_produk.Location = New System.Drawing.Point(221, 67)
        Me.lb_tipe_produk.Name = "lb_tipe_produk"
        Me.lb_tipe_produk.Size = New System.Drawing.Size(103, 20)
        Me.lb_tipe_produk.TabIndex = 11
        Me.lb_tipe_produk.Text = "no selected"
        '
        'lb_harga_satuan
        '
        Me.lb_harga_satuan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_harga_satuan.AutoSize = True
        Me.lb_harga_satuan.Location = New System.Drawing.Point(383, 67)
        Me.lb_harga_satuan.Name = "lb_harga_satuan"
        Me.lb_harga_satuan.Size = New System.Drawing.Size(20, 20)
        Me.lb_harga_satuan.TabIndex = 10
        Me.lb_harga_satuan.Text = "0"
        '
        'dt_garansi
        '
        Me.dt_garansi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_garansi.Location = New System.Drawing.Point(278, 118)
        Me.dt_garansi.Name = "dt_garansi"
        Me.dt_garansi.Size = New System.Drawing.Size(258, 28)
        Me.dt_garansi.TabIndex = 8
        '
        'nd_quantity
        '
        Me.nd_quantity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nd_quantity.Location = New System.Drawing.Point(11, 122)
        Me.nd_quantity.Name = "nd_quantity"
        Me.nd_quantity.Size = New System.Drawing.Size(161, 28)
        Me.nd_quantity.TabIndex = 7
        '
        'btn_tambahkan
        '
        Me.btn_tambahkan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_tambahkan.BackColor = System.Drawing.Color.Navy
        Me.btn_tambahkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_tambahkan.ForeColor = System.Drawing.Color.White
        Me.btn_tambahkan.Location = New System.Drawing.Point(402, 164)
        Me.btn_tambahkan.Name = "btn_tambahkan"
        Me.btn_tambahkan.Size = New System.Drawing.Size(145, 39)
        Me.btn_tambahkan.TabIndex = 6
        Me.btn_tambahkan.Text = "Tambahkan"
        Me.btn_tambahkan.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("SF UI  Text Med", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "JUMLAH BARANG :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("SF UI  Text Med", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(367, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "GARANSI BARANG :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("SF UI  Text Med", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(383, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "HARGA BARANG :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("SF UI  Text Med", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(221, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "TIPE BARANG :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SF UI  Text Med", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "NAMA BARANG :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGV1)
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Font = New System.Drawing.Font("SF UI  Text", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 693)
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
        Me.DGV1.Size = New System.Drawing.Size(529, 565)
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
        Me.merk_barang.Width = 125
        '
        'tipe_barang
        '
        Me.tipe_barang.HeaderText = "TIPE BARANG"
        Me.tipe_barang.MinimumWidth = 6
        Me.tipe_barang.Name = "tipe_barang"
        Me.tipe_barang.ReadOnly = True
        Me.tipe_barang.Width = 125
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
        Me.harga_barang.Width = 125
        '
        'stok_barang
        '
        Me.stok_barang.HeaderText = "STOK BARANG"
        Me.stok_barang.MinimumWidth = 6
        Me.stok_barang.Name = "stok_barang"
        Me.stok_barang.ReadOnly = True
        Me.stok_barang.Width = 125
        '
        'txt_search
        '
        Me.txt_search.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.Font = New System.Drawing.Font("SF UI  Text", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(6, 67)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(529, 40)
        Me.txt_search.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(1489, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 50)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lb_2
        '
        Me.lb_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_2.AutoSize = True
        Me.lb_2.BackColor = System.Drawing.Color.Transparent
        Me.lb_2.Font = New System.Drawing.Font("SF UI  Text", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_2.Location = New System.Drawing.Point(62, 22)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(744, 57)
        Me.lb_2.TabIndex = 7
        Me.lb_2.Text = "KASIR REJEKI JAYA KOMPUTER"
        '
        'FormKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1610, 850)
        Me.Controls.Add(Me.lb_2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKasir"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGV2Kasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nd_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lb_2 As Label
    Friend WithEvents DGV2Kasir As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dt_garansi As DateTimePicker
    Friend WithEvents nd_quantity As NumericUpDown
    Friend WithEvents btn_tambahkan As Button
    Friend WithEvents lb_total_harga As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lb_merk As Label
    Friend WithEvents lb_tipe_produk As Label
    Friend WithEvents lb_harga_satuan As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents txt_total_harga As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_cetak As Button
    Friend WithEvents txt_kembalian As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_nominal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents id_barang As DataGridViewTextBoxColumn
    Friend WithEvents merk_barang As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang As DataGridViewTextBoxColumn
    Friend WithEvents tahun_produksi_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga_barang As DataGridViewTextBoxColumn
    Friend WithEvents stok_barang As DataGridViewTextBoxColumn
    Friend WithEvents lb_id_produk As Label
    Friend WithEvents lb_tahun_produksi As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lb_name_user As Label
    Friend WithEvents lb_id_transaksi As Label
    Friend WithEvents id_barang_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents id_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents merk_barang_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents tahun_produksi_barang_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents harga_satuan_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents harga_total_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents kuantitas_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents waktu_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents garansi_barang_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents nama_pegawai_kasir As DataGridViewTextBoxColumn
    Friend WithEvents txt_telepon As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_pembeli As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label12 As Label
End Class
