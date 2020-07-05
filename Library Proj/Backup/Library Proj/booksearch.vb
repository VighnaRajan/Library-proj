Imports System.Data
Imports System.Data.OleDb
Public Class booksearch
    Dim con As New OleDbConnection
    Dim cmd, a1cmd, a2cmd, a3cmd, a4cmd As New OleDbCommand
    Dim da, a1da, a2da, a3da, a4da As New OleDbDataAdapter
    Dim ds, a1ds, a2ds, a3ds, a4ds As New DataSet
    Dim i As Integer
    Private Sub booksearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Vighna.K.V.R\Library proj\LibraryProj.mdb"
        con.Open()
        cmd.CommandText = "select * from books"
        cmd.Connection = con
        a1cmd.Connection = con
        a2cmd.Connection = con
        a3cmd.Connection = con
        a4cmd.Connection = con
        
        da.SelectCommand = cmd
        da.Fill(ds)
        
        
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ComboBox1.Enabled = False
            a.ReadOnly = True
        Else
            ComboBox1.Enabled = True
            a.ReadOnly = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = False
            a.ReadOnly = True
        Else
            ComboBox1.Enabled = True
            a.ReadOnly = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            TextBox5.ReadOnly = True
            TextBox6.ReadOnly = True
            TextBox7.ReadOnly = True
            TextBox8.ReadOnly = True
            Button1.Enabled = False
            a2cmd.CommandText = "select distinct(category) from books"
            a2da.SelectCommand = a2cmd
            a2da.Fill(a2ds)
            ComboBox1.Items.Clear()
            For i = 0 To a2ds.Tables(0).Rows.Count - 1
                ComboBox1.Items.Add(a2ds.Tables(0).Rows(i).Item("category"))
            Next
            If a2ds.Tables(0).Rows.Count > 0 Then
                ComboBox1.SelectedIndex = 0
            End If
        Else
            TextBox1.ReadOnly = False
            TextBox2.ReadOnly = False
            TextBox3.ReadOnly = False
            TextBox4.ReadOnly = False
            TextBox5.ReadOnly = False
            TextBox6.ReadOnly = False
            TextBox7.ReadOnly = False
            TextBox8.ReadOnly = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            TextBox5.ReadOnly = True
            TextBox6.ReadOnly = True
            TextBox7.ReadOnly = True
            TextBox8.ReadOnly = True
            a1cmd.CommandText = "select distinct(author) from books"
            a1da.SelectCommand = a1cmd
            a1da.Fill(a1ds)
            ComboBox1.Items.Clear()
            For i = 0 To a1ds.Tables(0).Rows.Count - 1
                ComboBox1.Items.Add(a1ds.Tables(0).Rows(i).Item("author"))
            Next
            If a1ds.Tables(0).Rows.Count > 0 Then
                ComboBox1.SelectedIndex = 0
            End If
            Button1.Enabled = False
        Else
            TextBox1.ReadOnly = False
            TextBox2.ReadOnly = False
            TextBox3.ReadOnly = False
            TextBox4.ReadOnly = False
            TextBox5.ReadOnly = False
            TextBox6.ReadOnly = False
            TextBox7.ReadOnly = False
            TextBox8.ReadOnly = False
            Button1.Enabled = True
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If RadioButton3.Checked = True Then
            a3cmd.CommandText = "select * from books where category='" & ComboBox1.Text & "'"
            a3da.SelectCommand = a3cmd
            a3ds.Clear()
            a3da.Fill(a3ds)
            a.DataSource = a3ds
            a.DataMember = a3ds.Tables(0).TableName
            a.Refresh()
        ElseIf RadioButton4.Checked = True Then
            a3cmd.CommandText = "select * from books where author='" & ComboBox1.Text & "'"
            a3da.SelectCommand = a3cmd
            a3ds.Clear()
            a3da.Fill(a3ds)
            a.DataSource = a3ds
            a.DataMember = a3ds.Tables(0).TableName
            a.Refresh()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            a4cmd.CommandText = "select * from books where bname='" & TextBox1.Text & "'"
        ElseIf RadioButton2.Checked = True Then
            a4cmd.CommandText = "select * from books where bno=" & TextBox1.Text
        End If
        TextBox1.Clear()
        a4da.SelectCommand = a4cmd
        a4ds.Clear()
        a4da.Fill(a4ds)
        If a4ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Invalid Key", MsgBoxStyle.Critical)
            GoTo fin
        End If

        TextBox2.Text = a4ds.Tables(0).Rows(0).Item("bname")
        TextBox3.Text = a4ds.Tables(0).Rows(0).Item("bno")
        TextBox4.Text = a4ds.Tables(0).Rows(0).Item("author")
        TextBox5.Text = a4ds.Tables(0).Rows(0).Item("price")
        TextBox6.Text = a4ds.Tables(0).Rows(0).Item("publication")
        TextBox7.Text = a4ds.Tables(0).Rows(0).Item("category")
        TextBox8.Text = a4ds.Tables(0).Rows(0).Item("status")
fin:
    End Sub
End Class