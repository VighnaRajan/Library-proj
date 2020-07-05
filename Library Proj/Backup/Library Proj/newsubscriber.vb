Imports System.Data
Imports System.Data.OleDb
Public Class newsubscriber
    Dim con As New OleDbConnection
    Dim cmd, d1cmd, d2cmd As New OleDbCommand
    Dim da, d1da, d2da As New OleDbDataAdapter
    Dim ds, d1ds, d2ds As New DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim q As String
        If Button1.Text = "Add Subscriber" Then
            Button1.Text = "ADD"
            Button2.Enabled = False
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        Else
            Button1.Text = "Add Subscriber"
            Button2.Enabled = True
            d2cmd.CommandText = "select max(mno) from subscriber"
            d2da.SelectCommand = d2cmd
            d2ds.Clear()
            d2da.Fill(d2ds)
            TextBox1.Text = d2ds.Tables(0).Rows(0).Item(0) + 1
            cmd.Connection = con
            q = "insert into Subscriber values(" & TextBox1.Text & ",'" & TextBox2.Text & "','" & TextBox3.Text & "'," & TextBox4.Text & "," & TextBox5.Text & ")"
            cmd.CommandText = q
            cmd.ExecuteNonQuery()
            cmd.CommandText = ("Select * from Subscriber")
            da.SelectCommand = cmd
            ds.Clear()
            da.Fill(ds)
            b.DataSource = ds
            b.DataMember = ds.Tables(0).TableName
        End If
    End Sub

    Private Sub newsubscriber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;data Source=D:\Vighna.K.V.R\Library proj\LibraryProj.mdb"
        con.Open()
        cmd.CommandText = "select * from Subscriber "
        cmd.Connection = con
        da.SelectCommand = cmd
        da.Fill(ds)
        b.DataSource = ds
        b.DataMember = ds.Tables(0).TableName
        d2cmd.Connection = con

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim t As String
        If Button2.Text = "Edit" Then
            Button2.Text = "Update"
            Button1.Enabled = False
            TextBox2.Focus()
        Else
            Button2.Text = "Edit"
            t = "update Subscriber set mname='" & TextBox2.Text & "', address='" & TextBox3.Text & "', deposit=" & TextBox4.Text & ", maxcount=" & TextBox5.Text & " where mno=" & TextBox1.Text
            cmd.Connection = con
            cmd.CommandText = t
            cmd.ExecuteNonQuery()
            MsgBox("Updated")
            cmd.CommandText = ("Select * from Subscriber")
            da.SelectCommand = cmd
            ds.Clear()
            da.Fill(ds)
            b.DataSource = ds
            b.DataMember = ds.Tables(0).TableName
            Button1.Enabled = True
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

    Private Sub b_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles b.RowEnter
        Dim r As Integer
        r = e.RowIndex
        TextBox1.Text = ds.Tables(0).Rows(r).Item("mno")
        TextBox2.Text = ds.Tables(0).Rows(r).Item("mname")
        TextBox3.Text = ds.Tables(0).Rows(r).Item("address")
        TextBox4.Text = ds.Tables(0).Rows(r).Item("deposit")
        TextBox5.Text = ds.Tables(0).Rows(r).Item("maxcount")
    End Sub
End Class