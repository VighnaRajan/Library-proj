Imports System.Data
Imports System.Data.OleDb
Public Class lostbook
    Dim con As New OleDbConnection
    Dim cmd, a1cmd, a2cmd, a3cmd, a4cmd As New OleDbCommand
    Dim da, a1da, a2da, a4da As New OleDbDataAdapter
    Dim ds, a1ds, a2ds, a4ds As New DataSet
    Dim i As Integer
    Dim c As Integer
    Private Sub lostbook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
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
        ComboBox1.Items.Clear()
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables(0).Rows(i).Item("bname"))
        Next 
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim x As Integer
        i = ComboBox1.SelectedIndex
        TextBox1.Text = ds.Tables(0).Rows(i).Item("price")
        x = Val(TextBox1.Text)
        TextBox2.Text = x * 3
        TextBox3.Text = ds.Tables(0).Rows(i).Item("status")
        TextBox6.Text = ds.Tables(0).Rows(i).Item("mno")
        If UCase(TextBox3.Text) = "ISSUE" Then
            a4cmd.CommandText = "select * from Subscriber where mno=" & ds.Tables(0).Rows(i).Item("mno")
            a4da.SelectCommand = a4cmd
            a4ds.Clear()
            a4da.Fill(a4ds)

            TextBox4.Text = a4ds.Tables(0).Rows(0).Item("mname")
            TextBox5.Text = a4ds.Tables(0).Rows(0).Item("address")
        Else
            TextBox4.Text = "-"
            TextBox5.Text = "-"
        End If
        If UCase(TextBox3.Text) = "CONDEMNED" Or UCase(TextBox3.Text) = "LOST" Or UCase(TextBox3.Text) = "FREE" Then
            Button1.Enabled = False
        Else
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As String
        Dim x As MsgBoxResult
        x = MsgBox("Is the book " & ComboBox1.Text & " lost?", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            f = "update books set status='lost', mno= 0 where bno=" & ds.Tables(0).Rows(i).Item("bno")
            a2cmd.CommandText = f
            a2cmd.ExecuteNonQuery()
            f = "insert into trans values (" & ds.Tables(0).Rows(i).Item("bno") & "," & ds.Tables(0).Rows(i).Item("mno") & ",#" & dtp.Value.Date & "#," & TextBox2.Text & ",'lost')"
            a3cmd.commandtext = f
            a3cmd.executenonquery()
            MsgBox("Book Added to lost list", MsgBoxStyle.Information)
            ds.Clear()
            da.Fill(ds)
        End If
    End Sub
End Class