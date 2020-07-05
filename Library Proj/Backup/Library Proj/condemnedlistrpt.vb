Imports System.Data
Imports System.Data.OleDb
Public Class condemnedlistrpt
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub condemnedlistrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Vighna.K.V.R\Library proj\LibraryProj.mdb"
        con.Open()
        cmd.CommandText = "delete from temp"
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        cmd.CommandText = "insert into temp select * from books where status='condemned'"
        cmd.ExecuteNonQuery()
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class