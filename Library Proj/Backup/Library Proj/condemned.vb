Imports System.Data
Imports System.Data.OleDb
Public Class condemned
    Dim con As New OleDbConnection
    Dim cmd, a1cmd, a2cmd, a3cmd, a4cmd As New OleDbCommand
    Dim da, a1da, a2da, a4da As New OleDbDataAdapter
    Dim ds, a1ds, a2ds, a4ds As New DataSet
    Dim c As Integer
    Private Sub condemned_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Vighna.K.V.R\Library proj\LibraryProj.mdb"
        con.Open()
        cmd.CommandText = "select * from books"
        cmd.Connection = con
        da.SelectCommand = cmd
        da.Fill(ds)
        ComboBox1.Items.Clear()
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables(0).Rows(i).Item("bno"))
        Next
        showcondemnedbooks()
    End Sub
    Private Sub showbooks()
        a1cmd.CommandText = "select * from books where bno=" & ds.Tables(0).Rows(c).Item("bno")
        a1cmd.Connection = con
        a2cmd.Connection = con
        a3cmd.connection = con
        a1da.SelectCommand = a1cmd
        a1ds.Clear()
        a1da.Fill(a1ds)
        a.DataSource = a1ds
        a.DataMember = a1ds.Tables(0).TableName
        If a1ds.Tables(0).Rows.Count > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
    Private Sub showcondemnedbooks()
        a4cmd.CommandText = "select * from books where status='condemned'"
        a4cmd.Connection = con
        a4da.SelectCommand = a4cmd
        a4ds.Clear()
        a4da.Fill(a4ds)
        b.DataSource = a4ds
        b.DataMember = a4ds.Tables(0).TableName
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        c = ComboBox1.SelectedIndex
        showbooks()
    End Sub
    Private Sub a_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles a.RowEnter
        Dim p As Integer
        p = e.RowIndex
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As String
        Dim x As MsgBoxResult
        x = MsgBox("Is the book " & ds.Tables(0).Rows(c).Item("bname") & " condemned?", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            f = "update books set status='Condemned', mno= 0 where bno=" & ds.Tables(0).Rows(c).Item("bno")
            a2cmd.CommandText = f
            a2cmd.ExecuteNonQuery()
            f = "insert into trans values (" & ComboBox1.Text & ",0,#" & dtp.Value.Date & "#,0.00,'Condemned')"
            a3cmd.commandtext = f
            a3cmd.executenonquery()
            MsgBox("Book Added to condemned list", MsgBoxStyle.Information)
            showcondemnedbooks()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim b As MsgBoxResult
        b = MsgBox("Are you sure to exit!", MsgBoxStyle.YesNo)
        If b = MsgBoxResult.Yes Then
            End
        Else
            MsgBox("Operation Aborted!")
        End If
    End Sub
End Class