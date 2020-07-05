Imports System.Data
Imports System.Data.OleDb
Public Class categorywiselistingrpt
    Dim con As New OleDbConnection
    Dim cmd, d1cmd, tcmd As New OleDbCommand
    Dim da, d1da, tda As New OleDbDataAdapter
    Dim ds, d1ds, tds As New DataSet
    Dim i As Integer
    Private Sub categorywiselistingrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Vighna.K.V.R\Library proj\LibraryProj.mdb"
        con.Open()
        cmd.Connection = con
        tcmd.Connection = con
        cmd.CommandText = "select distinct(category) from books"
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables(0).Rows(i).Item(0))
        Next
        d1cmd.Connection = con
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        d1cmd.CommandText = "delete from temp"
        d1cmd.ExecuteNonQuery()
        d1cmd.CommandText = "insert into temp select * from books where category='" & ComboBox1.Text & "'"
        d1cmd.ExecuteNonQuery()
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class