Imports System.Data
Imports System.Data.OleDb
Public Class login
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Vighna.K.V.R\Library proj\LibraryProj.mdb"
        con.Open()
        cmd.Connection = con
        lgint1.Text = "admin"
        lgint2.Text = "abc123"
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        cmd.CommandText = "select * from login where user='" & lgint1.Text & "' and password='" & lgint2.Text & "'"
        ' MsgBox(cmd.CommandText)
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds)
        'MsgBox(ds.Tables(0).Rows.Count)
        If ds.Tables(0).Rows.Count = 1 Then
            MDIParent1.Show()
        ElseIf ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Retype Username/Password")
            lgint1.Clear()
            lgint2.Clear()
            lgint1.Focus()
        End If
    End Sub
End Class
