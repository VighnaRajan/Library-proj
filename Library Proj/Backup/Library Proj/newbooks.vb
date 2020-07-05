Imports System.Data
Imports System.Data.OleDb
Public Class newbooks
    Dim con As New OleDbConnection
    Dim cmd, d1cmd, d2cmd As New OleDbCommand
    Dim da, d1da, d2da As New OleDbDataAdapter
    Dim ds, d1ds, d2ds As New DataSet

    Private Sub newbooks_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIParent1.ToolStripStatusLabel1.Text = "You Are In MAIN MENU"
    End Sub
    Private Sub newbooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIParent1.ToolStripStatusLabel1.Text = "You are Currently in NEW BOOK ENTRY Module"
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;data Source=D:\Vighna.K.V.R\Library proj\LibraryProj.mdb"
        con.Open()
        cmd.CommandText = "select * from books "
        cmd.Connection = con
        da.SelectCommand = cmd
        da.Fill(ds)
        a.DataSource = ds
        a.DataMember = ds.Tables(0).TableName
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim q As String
        If Button1.Text = "Add Book" Then
            Button1.Text = "Add"
            Button2.Enabled = False
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
        Else
            d2cmd.Connection = con
            d2cmd.CommandText = "select count(*) from books where bno=" & TextBox1.Text
            d2da.SelectCommand = d2cmd
            d2ds.Clear()
            d2da.Fill(d2ds)
            If d2ds.Tables(0).Rows(0).Item(0) = 0 Then
                Button1.Text = "Add Book"
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                TextBox5.Enabled = False
                TextBox6.Enabled = False
                TextBox7.Enabled = False
                q = "insert into books values(" & TextBox1.Text & ",'" & TextBox2.Text & "','" & TextBox3.Text & "'," & TextBox4.Text & ",'" & TextBox5.Text & "','" & TextBox6.Text & "'," & TextBox7.Text & ",'free',0)"
                cmd.Connection = con
                cmd.CommandText = q
                cmd.ExecuteNonQuery()
                cmd.CommandText = ("Select * from books")
                da.SelectCommand = cmd
                ds.Clear()
                da.Fill(ds)
                a.DataSource = ds
                a.DataMember = ds.Tables(0).TableName
            Else
                MsgBox("You have entered an existing book number", MsgBoxStyle.Information)
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x As MsgBoxResult
        x = MsgBox("Are you sure to exit!", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            End
        Else
            MsgBox("Operation Aborted!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim t As String
        If Button2.Text = "Edit" Then
            Button2.Text = "Update"
            Button1.Enabled = False
            TextBox2.Focus()
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
        Else
            Button2.Text = "Edit"
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            Button1.Enabled = True
            t = "update books set bname='" & TextBox2.Text & "', author='" & TextBox3.Text & "', price=" & TextBox4.Text & ", publication='" & TextBox5.Text & "', category='" & TextBox6.Text & "', edition='" & TextBox7.Text & "' where bno=" & TextBox1.Text
            cmd.Connection = con
            cmd.CommandText = t
            cmd.ExecuteNonQuery()
            MsgBox("Updated")
            cmd.CommandText = ("Select * from books")
            da.SelectCommand = cmd
            ds.Clear()
            da.Fill(ds)
            a.DataSource = ds
            a.DataMember = ds.Tables(0).TableName
            Button1.Enabled = True
        End If
    End Sub

    Private Sub a_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles a.CellContentClick

    End Sub

    Private Sub a_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles a.RowEnter
        Dim r As Integer
        r = e.RowIndex
        TextBox1.Text = ds.Tables(0).Rows(r).Item("bno")
        TextBox2.Text = ds.Tables(0).Rows(r).Item("bname")
        TextBox3.Text = ds.Tables(0).Rows(r).Item("author")
        TextBox4.Text = ds.Tables(0).Rows(r).Item("price")
        TextBox5.Text = ds.Tables(0).Rows(r).Item("publication")
        TextBox6.Text = ds.Tables(0).Rows(r).Item("category")
        TextBox7.Text = ds.Tables(0).Rows(r).Item("edition")
    End Sub
End Class
