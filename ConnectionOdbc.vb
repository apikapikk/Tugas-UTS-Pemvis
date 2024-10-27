Imports System.Data.Odbc
Public Class ConnectionOdbc
    Private Shared instance As ConnectionOdbc = Nothing
    Private Shared ReadOnly lockObject As New Object()

    Private conn As OdbcConnection

    Private Sub New()
        Try
            conn = New OdbcConnection("DSN=dbBarang;UID=root;PWD=;")
            conn.Open()

        Catch ex As Exception
            Throw New Exception("koneski database gagal dikarenakan" & ex.Message)
        End Try
    End Sub

    Public Shared Function getInstance() As ConnectionOdbc
        SyncLock lockObject
            If instance Is Nothing Then
                instance = New ConnectionOdbc()
            End If
        End SyncLock
        Return instance
    End Function

    Public Function getConnection() As OdbcConnection
        Return conn
    End Function

    Public Sub closeConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Class
