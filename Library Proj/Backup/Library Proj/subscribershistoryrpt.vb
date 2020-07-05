Imports System.Data
Imports System.Data.OleDb
Public Class subscribershistoryrpt
    Dim con As New OleDbConnection
    Dim cmd, d1cmd, tcmd As New OleDbCommand
    Dim da, d1da, tda As New OleDbDataAdapter
    Dim ds, d1ds, tds As New DataSet
    Dim i As Integer
    Private Sub subscribershistoryrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Vighna.K.V.R\Library proj\LibraryProj.mdb"
        con.Open()
        cmd.Connection = con
        tcmd.Connection = con
        cmd.CommandText = "select * from subscriber"
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables(0).Rows(i).Item("mno"))
        Next
        d1cmd.Connection = con
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        d1cmd.CommandText = "delete from temp1"
        d1cmd.ExecuteNonQuery()
        tcmd.CommandText = "select * from trans where mno=" & ComboBox1.Text
        tda.SelectCommand = tcmd
        tds.Clear()
        tda.Fill(tds)
        For i = 0 To tds.Tables(0).Rows.Count - 1
            d1cmd.CommandText = "insert into temp1 values(" & tds.Tables(0).Rows(i).Item("bno") & "," & ComboBox1.Text & ",#" & tds.Tables(0).Rows(i).Item("tdate") & "#," & tds.Tables(0).Rows(i).Item("tamount") & ",'" & tds.Tables(0).Rows(i).Item("trans") & "','" & ds.Tables(0).Rows(ComboBox1.SelectedIndex).Item("mname") & "')"
            d1cmd.ExecuteNonQuery()
        Next

        CrystalReportViewer1.RefreshReport()
    End Sub
End Class