Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUserId.Text = "" And txtPassword.Text = "" Then
            MsgBox("Sila masukkan User Name dan Password ")
        Else
            Dim Conn As New System.Data.OleDb.OleDbConnection
            Conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\db_ProgramPengajian.mdb"

            Dim sql As String = "SELECT * FROM Pengguna WHERE Nama ='" & txtUserId.Text & "' AND Password = '" & txtPassword.Text & "'"

            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

            'open database connection
            sqlCom.Connection = Conn
            Conn.Open()

            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

            If sqlRead.Read() Then
                frmMain.Show()
                Me.Hide()
            Else
                'if user enters wrong username and password combination display error message
                ' lbl_LoginWarning.Visible = True
                'clear all fields
                MsgBox("Salah password")
                txtPassword.Text = ""
                txtUserId.Text = ""
                'Focus in username field
                txtUserId.Focus()
            End If
            ' Catch ex As Exception
            'MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try

        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        txtUserId.Text = ""
        txtPassword.Text = ""

    End Sub
End Class