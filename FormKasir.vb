Imports System.Data.Odbc
Public Class FormKasir
    Private Sub getData()
        If DGV1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DGV1.SelectedRows(0)
            lb_id_produk.Text = row.Cells("id_barang").Value.ToString
            lb_merk.Text = row.Cells("merk_barang").Value.ToString
            lb_tipe_produk.Text = row.Cells("tipe_barang").Value.ToString
            lb_tahun_produksi.Text = row.Cells("tahun_produksi_barang").Value.ToString
            lb_harga_satuan.Text = row.Cells("harga_barang").Value.ToString
        End If
    End Sub
    Private Sub loadData()
        Try
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()
            Dim viewQuery As String = "SELECT 
            `id_barang`,
            `merk_barang`,
            `tipe_barang`,
            `tahun_produksi_barang`,
            `harga_barang`,
            `stok_barang` 
            FROM `databarang`"

            Dim cmd As New OdbcCommand(viewQuery, dbConnect)
            Dim reader As OdbcDataReader = cmd.ExecuteReader()

            DGV1.Rows.Clear()

            While reader.Read()
                DGV1.Rows.Add(
                    reader("id_barang"),
                    reader("merk_barang"),
                    reader("tipe_barang"),
                    reader("tahun_produksi_barang"),
                    reader("harga_barang"),
                    reader("stok_barang")
                    )
            End While

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub searchData()
        Try
            ' Membuka koneksi database
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()

            ' Buat query pencarian dengan klausa LIKE untuk mencari data yang mirip
            Dim searchQuery As String = "SELECT id_barang, merk_barang, tipe_barang, tahun_produksi_barang, harga_barang, stok_barang " &
                                 "FROM databarang WHERE id_barang LIKE '" & "%" & txt_search.Text & "%" & "' OR merk_barang LIKE '" & "%" & txt_search.Text & "%" & "'"
            Dim cmd As New OdbcCommand(searchQuery, dbConnect)
            Dim reader As OdbcDataReader = cmd.ExecuteReader()
            DGV1.Rows.Clear()
            Dim dataFound As Boolean = False
            While reader.Read()
                dataFound = True
                DGV1.Rows.Add(
             reader("id_barang"),
             reader("merk_barang"),
             reader("tipe_barang"),
             reader("tahun_produksi_barang"),
             reader("harga_barang"),
             reader("stok_barang")
         )
            End While

            reader.Close()
            If Not dataFound Then
                MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub quantityPriceCalculation()
        Dim hargaSatuan As Decimal
        If Decimal.TryParse(lb_harga_satuan.Text, hargaSatuan) Then
            Dim jumlah As Integer = nd_quantity.Value
            Dim totalHarga As Decimal = jumlah * hargaSatuan
            lb_total_harga.Text = totalHarga.ToString
        End If
    End Sub
    Private Function generateIdTransaksi() As String
        Dim newId As String = ""

        Try
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()
            Dim queryIdGet As String = "SELECT `id_transaksi` FROM `histori_transaksi` ORDER BY `id_transaksi` DESC LIMIT 1"
            Using cmd As New OdbcCommand(queryIdGet, dbConnect)
                Dim reader As OdbcDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim lastId As String = reader("id_transaksi").ToString
                    Dim lastNumebr As Integer = Integer.Parse(lastId.Substring(3))
                    newId = "TRS" & (lastNumebr + 1).ToString("D4")
                Else
                    newId = "TRS0001"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return newId
    End Function
    Private Sub generateTotalPrice()
        Dim totalPrice As Double = 0
        For Each row As DataGridViewRow In DGV2Kasir.Rows
            If Not row.IsNewRow Then
                Dim price As Double = Convert.ToDouble(row.Cells("harga_total_transaksi").Value)
                totalPrice += price
            End If
        Next
        txt_total_harga.Text = totalPrice.ToString

    End Sub
    Private Sub addDataToCart()
        Dim timestamp As DateTime = DateTime.Now
        DGV2Kasir.Rows.Add(
            lb_id_produk.Text,
            lb_id_transaksi.Text,
            lb_merk.Text,
            lb_tipe_produk.Text,
            lb_tahun_produksi.Text,
            lb_harga_satuan.Text,
            lb_total_harga.Text,
            nd_quantity.Value.ToString,
            timestamp.ToString,
            dt_garansi.Value.ToString,
            lb_name_user.Text
            )
    End Sub
    Dim currentStocks As Integer
    'Dim currentId As String = lb_id_produk.Text
    Dim newStockInject As String
    Private Sub updateStockInDatabase(newStock As Integer, idBarang As String)
        Try
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()
            Dim queryData As String = "UPDATE `databarang` SET
            `stok_barang` = '" & newStockInject & "' WHERE `id_barang` = '" & idBarang & "'"
            Using cmd As New OdbcCommand(queryData, dbConnect)
            End Using
        Catch ex As Exception
            MessageBox.Show("failed to update stocks")
        End Try
    End Sub
    Private Sub saveData()
        For Each row As DataGridViewRow In DGV2Kasir.Rows
            If Not row.IsNewRow Then
                Try
                    Dim id_barang_transaksi As String = row.Cells("id_barang_transaksi").Value.ToString
                    Dim merk_barang_transaksi As String = row.Cells("merk_barang_transaksi").Value.ToString
                    Dim tipe_barang_transaksi As String = row.Cells("tipe_barang_transaksi").Value.ToString
                    Dim tahun_produksi_barang_transaksi As String = row.Cells("tahun_produksi_barang_transaksi").Value.ToString
                    Dim harga_barang_transaksi As String = row.Cells("harga_satuan_transaksi").Value.ToString
                    Dim harga_total_transaksi As String = row.Cells("harga_total_transaksi").Value.ToString
                    Dim id_transaksi As String = row.Cells("id_transaksi").Value.ToString
                    Dim kuantitas_transaksi As String = row.Cells("kuantitas_transaksi").Value.ToString
                    Dim waktu_transksi As String = row.Cells("waktu_transaksi").Value.ToString
                    Dim garansi_barang_transaksi As String = row.Cells("garansi_barang_transaksi").Value.ToString
                    Dim nama_pegawai As String = row.Cells("nama_pegawai_kasir").Value.ToString
                    Dim nominal_bayar As String = txt_nominal.Text
                    Dim nominal_kembalian As String = txt_kembalian.Text
                    Dim total_belanja As String = txt_total_harga.Text
                    Dim nama_pembeli As String = txt_pembeli.Text
                    Dim telepon_pembeli As String = txt_telepon.Text
                    Dim alamat_pembeli As String = txt_alamat.Text

                    Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()
                    Dim queryadd As String = "INSERT INTO `histori_transaksi`
                            (
                                    `id_barang`,
                                    `merk_barang`,
                                    `tipe_barang`,
                                    `tahun_produksi_barang`,
                                    `harga_barang`,
                                    `harga_total`,
                                    `id_transaksi`,
                                    `kuantitas`,
                                    `waktu_transaksi`,
                                    `garansi_barang`,
                                    `nama_pegawal_kasir`,
                                    `nominal_bayar`,
                                    `nominal_kembalian`,
                                    `nominal_total_keseluruhan`,
                                    `nama_pembeli`,
                                    `no_telepon_pembeli`,
                                    `alamat_pembeli`
                            ) VALUES 
                                    (
                                    '" & id_barang_transaksi & "',
                                    '" & merk_barang_transaksi & "',
                                    '" & tipe_barang_transaksi & "',
                                    '" & tahun_produksi_barang_transaksi & "',
                                    '" & harga_barang_transaksi & "',
                                    '" & harga_total_transaksi & "',
                                    '" & id_transaksi & "',
                                    '" & kuantitas_transaksi & "',
                                    '" & waktu_transksi & "',
                                    '" & garansi_barang_transaksi & "',
                                    '" & nama_pegawai & "',
                                    '" & nominal_bayar & "',
                                    '" & nominal_kembalian & "',
                                    '" & total_belanja & "',
                                    '" & nama_pembeli & "',
                                    '" & telepon_pembeli & "',
                                    '" & alamat_pembeli & "'
                                    )"
                    Using cmd As New OdbcCommand(queryadd, dbConnect)
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End If
        Next
        MessageBox.Show("data berhasil disimpan")
    End Sub
    Private Sub calculationPrice()
        If String.IsNullOrEmpty(txt_nominal.Text) OrElse String.IsNullOrEmpty(txt_total_harga.Text) Then
            Return
        End If
        Dim totalHarga As Double
        Dim nominal As Double

        If Not Double.TryParse(txt_total_harga.Text, totalHarga) Then
            MessageBox.Show("Total Harga TIdak Valid")
        End If

        If Not Double.TryParse(txt_nominal.Text, nominal) Then
            MessageBox.Show("Total Harga TIdak Valid")
        End If

        If nominal >= totalHarga Then
            Dim kembalian As Double = nominal - totalHarga
            txt_kembalian.Text = kembalian.ToString
        Else
            txt_kembalian.Text = "nominal kurang"
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        lb_id_transaksi.Text = generateIdTransaksi()
        nd_quantity.Minimum = 1
        nd_quantity.Value = 1
        lb_name_user.Text = SessionModule.NamaPengguna
    End Sub

    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
        getData()
        quantityPriceCalculation()
    End Sub

    Private Sub nd_quantity_ValueChanged(sender As Object, e As EventArgs) Handles nd_quantity.ValueChanged
        quantityPriceCalculation()
    End Sub

    Private Sub btn_tambahkan_Click(sender As Object, e As EventArgs) Handles btn_tambahkan.Click
        addDataToCart()
        generateTotalPrice()
        loadData()
    End Sub

    Private Sub txt_nominal_TextChanged(sender As Object, e As EventArgs) Handles txt_nominal.TextChanged
        calculationPrice()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        DGV2Kasir.Rows.Clear()
        generateTotalPrice()
        calculationPrice()
        txt_nominal.Text = 0
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        saveData()
        lb_id_transaksi.Text = generateIdTransaksi()
        DGV2Kasir.Rows.Clear()
        generateTotalPrice()
        calculationPrice()
        txt_nominal.Text = 0
        txt_pembeli.Text = "masukkan nama"
        txt_telepon.Text = "masukkan no telepon"
        txt_alamat.Text = "masukkan alamat"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then
            loadData() ' Load all data when the search box is cleared
        Else
            searchData() ' Filter data as per the search term
        End If
    End Sub
End Class