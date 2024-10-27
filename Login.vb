Imports System.Data.Odbc
Public Class Login

    Private Sub loginData()
        Dim usernamedata As String = txt_username.Text
        Dim passwordData As String = txt_password.Text
        Try
            Dim dbConnect As OdbcConnection = ConnectionOdbc.getInstance().getConnection()
            Dim queryLog As String = "SELECT nama FROM `users` WHERE username='" & usernamedata & "' AND password='" & passwordData & "'"
            Using cmd As New OdbcCommand(queryLog, dbConnect)

                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    SessionModule.NamaPengguna = result.ToString()
                    'MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormMenu.ShowDialog()
                    lb_info_exception1.Visible = False
                    lb_info_exception2.Visible = False

                Else
                    lb_info_exception1.Visible = True
                    lb_info_exception2.Visible = True
                    'MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan koneksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginData()
        'FormMenu.ShowDialog()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_info_exception1.Visible = False
        lb_info_exception2.Visible = False

    End Sub
End Class
