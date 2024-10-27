Imports System.Data.Odbc
Public Class FormData

    Private Function generateId() As String
        Dim newId As String = ""
        Try
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()
            Dim queryIdGet As String = "SELECT `id_barang` FROM `databarang` ORDER BY `id_barang` DESC LIMIT 1"
            Using cmd As New OdbcCommand(queryIdGet, dbConnect)
                Dim reader As OdbcDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim lastId As String = reader("id_barang").ToString
                    Dim lastNumebr As Integer = Integer.Parse(lastId.Substring(3))
                    newId = "BRG" & (lastNumebr + 1).ToString("D4")
                Else
                    newId = "BRG0001"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return newId
    End Function
    Private Sub clearForm()
        txt_id_barang.Text = generateId()
        txt_harga_produksi.Clear()
        txt_merk_barang.Clear()
        txt_tipe_barang.Clear()
        txt_tahun_produksi.Clear()
        txt_stok_barang.Clear()
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
    Private Sub deleteFromDatabase(id_barang As String)
        Try
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()
            Dim deleteQuery As String = "DELETE FROM `databarang` WHERE `id_barang` = '" & id_barang & "'"
            Dim cmd As New OdbcCommand(deleteQuery, dbConnect)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus ")
            clearForm()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub deleteData()
        If DGV1.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("apakah anda ingin mengahpus data ini ?", "konfirmasi", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                For Each row As DataGridViewRow In DGV1.SelectedRows
                    If Not row.IsNewRow Then
                        Dim idBarang As String = row.Cells("id_barang").Value.ToString
                        deleteFromDatabase(idBarang)
                        DGV1.Rows.Remove(row)
                    End If
                Next
            End If
        Else
            MessageBox.Show("silahkan pilih baris yang ingin dihapus")
        End If
    End Sub
    Private Sub saveData() 'simpan data dari tekx box ke sql 

        Dim idBarang As String = txt_id_barang.Text
        Dim merkBarang As String = txt_merk_barang.Text
        Dim tipeBarang As String = txt_tipe_barang.Text
        Dim tahunProduksi As Integer = Convert.ToInt32(txt_tahun_produksi.Text)
        Dim hargaBarang As Double = Convert.ToDouble(txt_harga_produksi.Text)
        Dim stokBarang As Integer = Convert.ToInt32(txt_stok_barang.Text)

        Try
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()
            Dim queryData As String = "INSERT INTO `databarang`(
            `id_barang`, 
            `merk_barang`, 
            `tipe_barang`, 
            `tahun_produksi_barang`, 
            `harga_barang`,
            `stok_barang`
            ) VALUES (
                '" & idBarang & "',
                '" & merkBarang & "',
                '" & tipeBarang & "',
                " & tahunProduksi & ",
                " & hargaBarang & ",
                " & stokBarang & "
            )"

            'saya langsung inject ke value sql nya pak,
            'kalo pake parameter lalu panggil pake command malah ga kebaca

            Using cmd As New OdbcCommand(queryData, dbConnect)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("data berhasil ditambahkan")
                    clearForm()
                    loadData()

                Else
                    MessageBox.Show("data gagal ditambahkan")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub getData() 'get data to texktbox from selected row'
        If DGV1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DGV1.SelectedRows(0)
            txt_id_barang.Text = row.Cells("id_barang").Value.ToString
            txt_merk_barang.Text = row.Cells("merk_barang").Value.ToString
            txt_tipe_barang.Text = row.Cells("tipe_barang").Value.ToString
            txt_tahun_produksi.Text = row.Cells("tahun_produksi_barang").Value.ToString
            txt_harga_produksi.Text = row.Cells("harga_barang").Value.ToString
            txt_stok_barang.Text = row.Cells("stok_barang").Value.ToString
        End If
    End Sub
    Private Function validateInput() As Boolean
        Return Not String.IsNullOrEmpty(txt_id_barang.Text) AndAlso
               Not String.IsNullOrEmpty(txt_merk_barang.Text) AndAlso
               Not String.IsNullOrEmpty(txt_tipe_barang.Text) AndAlso
               Not String.IsNullOrEmpty(txt_tahun_produksi.Text) AndAlso
               Not String.IsNullOrEmpty(txt_harga_produksi.Text) AndAlso
               Not String.IsNullOrEmpty(txt_stok_barang.Text)
    End Function
    Private Sub updateData()
        If validateInput() Then
            Dim id_barang As String = txt_id_barang.Text
            Dim merk_barang As String = txt_merk_barang.Text
            Dim tipe_barang As String = txt_tipe_barang.Text
            Dim tahun_barang As String = Convert.ToInt32(txt_tahun_produksi.Text)
            Dim harga_barang As String = Convert.ToDouble(txt_harga_produksi.Text)
            Dim stok_barang As String = Convert.ToInt32(txt_stok_barang.Text)

            updateDataInDatabase(
                id_barang,
                merk_barang,
                tipe_barang,
                tahun_barang,
                harga_barang,
                stok_barang
            )
            loadData()
        Else
            MessageBox.Show("data tidak valid, pastikan field terisi semua")
        End If
    End Sub
    Private Sub updateDataInDatabase(
                    idBarang As String,
                    merkBarang As String,
                    tipeBarang As String,
                    tahunProduksi As Integer,
                    hargaBarang As Double,
                    stokBarang As Integer
     )
        Try
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()

            Dim queryData As String = "UPDATE `databarang` SET
            `id_barang` = '" & idBarang & "', 
            `merk_barang` = '" & merkBarang & "', 
            `tipe_barang` = '" & tipeBarang & "', 
            `tahun_produksi_barang` = " & tahunProduksi & ", 
            `harga_barang` = " & hargaBarang & ",
            `stok_barang` = " & stokBarang & ""

            Using cmd As New OdbcCommand(queryData, dbConnect)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("data berhasil diubah")
                    clearForm()
                    loadData()
                Else
                    MessageBox.Show("data gagal ditambahkan")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub tutupForm(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub tambahData(sender As Object, e As EventArgs) Handles btn_tambah.Click
        txt_id_barang.Text = generateId()
        txt_id_barang.ReadOnly = True
        saveData()
    End Sub

    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_id_barang.Text = generateId()
        txt_id_barang.ReadOnly = True
        loadData()
    End Sub

    Private Sub kosongkanData(sender As Object, e As EventArgs) Handles btn_kosongkan.Click
        clearForm()
    End Sub

    Private Sub hapusData(sender As Object, e As EventArgs) Handles btn_hapus.Click
        deleteData()
        txt_id_barang.Text = generateId()
        txt_id_barang.ReadOnly = True
    End Sub

    Private Sub ambilDataKeDatagridView(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
        getData()
    End Sub

    Private Sub ubahData(sender As Object, e As EventArgs) Handles btn_ubah.Click
        updateData()
    End Sub

End Class