Imports System.Data
Imports System.Data.OleDb
Public Class issue
    Dim con As New OleDbConnection
    Dim cmd, d1cmd, d2cmd, d3cmd, d4cmd, d5cmd As New OleDbCommand
    Dim da, d1da, d2da, d3da As New OleDbDataAdapter
    Dim ds, d1ds, d2ds, d3ds As New DataSet
    Dim cr As Integer
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim p As Integer
        p = ComboBox1.SelectedIndex
        TextBox1.Text = ds.Tables(0).Rows(p).Item("mno")
        TextBox2.Text = ds.Tables(0).Rows(p).Item("address")
        TextBox3.Text = ds.Tables(0).Rows(p).Item("maxcount")
        d1cmd.CommandText = "select count(*) from books where status='issue' and mno=" & TextBox1.Text
        d1da.SelectCommand = d1cmd
        d1da.Fill(d1ds)
        If d1ds.Tables(0).Rows(0).Item(0) < ds.Tables(0).Rows(p).Item("maxcount") Then
            MsgBox("Your books will be issued")
        Else
            MsgBox("Maximum Books Issued")
        End If
    End Sub
    Private Sub issue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Vighna.K.V.R\Library proj\LibraryProj.mdb"
        con.Open()
        cmd.CommandText = "select * from Subscriber"
        cmd.Connection = con
        da.SelectCommand = cmd
        da.Fill(ds)
        ComboBox1.Items.Clear()
        'ComboBox1.DataSource = ds
        'ComboBox1.DisplayMember = ds.Tables(0).TableName
        'MsgBox(ComboBox1.DisplayMember)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables(0).Rows(i).Item("mname"))

        Next
        d2cmd.Connection = con
        d1cmd.Connection = con
        d3cmd.Connection = con
        d4cmd.Connection = con
        d2cmd.CommandText = "select distinct(category) from books "
        d2cmd.Connection = con
        d2da.SelectCommand = d2cmd
        d2da.Fill(d2ds)
        ComboBox2.Items.Clear()
        'ComboBox1.DataSource = ds
        'ComboBox1.DisplayMember = ds.Tables(0).TableName
        'MsgBox(ComboBox1.DisplayMember)
        For i = 0 To d2ds.Tables(0).Rows.Count - 1
            ComboBox2.Items.Add(d2ds.Tables(0).Rows(i).Item(0))
        Next
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        d3cmd.CommandText = "select * from books where category='" & ComboBox2.Text & "'"
        d3da.SelectCommand = d3cmd
        d3ds.Clear()
        d3da.Fill(d3ds)
        c.DataSource = d3ds
        c.DataMember = d3ds.Tables(0).TableName
        c.Refresh()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If d3ds.Tables(0).Rows(cr).Item("status") = "free" Then
            Dim z As MsgBoxResult
            z = MsgBox("Do you want to take" & d3ds.Tables(0).Rows(cr).Item("bname") & " book?", MsgBoxStyle.YesNo)
            If z = MsgBoxResult.Yes Then
                d4cmd.CommandText = "update books set status='issue', mno=" & TextBox1.Text & " where bno=" & d3ds.Tables(0).Rows(cr).Item("bno")
                d4cmd.ExecuteNonQuery()
                d5cmd.Connection = con
                d5cmd.CommandText = "insert into trans values (" & d3ds.Tables(0).Rows(cr).Item("bno") & "," & TextBox1.Text & ",#" & dtp.Value.Date & "#,0.00,'issue')"
                MsgBox(d5cmd.CommandText)
                Clipboard.SetText(d5cmd.CommandText)
                d5cmd.ExecuteNonQuery()
                MsgBox("Book Issued")
            End If
        Else
            MsgBox("BOOK NOT AVAILABLE NOW. SORRY!")
        End If
    End Sub
    Private Sub c_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles c.RowEnter
        cr = e.RowIndex
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