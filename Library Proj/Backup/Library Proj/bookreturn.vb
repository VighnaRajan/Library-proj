Imports System.Data
Imports System.Data.OleDb
Public Class bookreturn
    Dim con As New OleDbConnection
    Dim cmd, a1cmd, a2cmd, a3cmd As New OleDbCommand
    Dim da, a1da, a2da, a3da As New OleDbDataAdapter
    Dim ds, a1ds, a2ds, a3ds As New DataSet
    Dim r As Integer
    Dim x As Integer
    Private Sub bookreturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Vighna.K.V.R\Library proj\LibraryProj.mdb"
        con.Open()
        cmd.CommandText = "select * from Subscriber"
        cmd.Connection = con
        da.SelectCommand = cmd
        da.Fill(ds)
        ComboBox1.Items.Clear()
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables(0).Rows(i).Item("mno"))
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        x = ComboBox1.SelectedIndex
        TextBox1.Text = ds.Tables(0).Rows(x).Item("mname")
        TextBox2.Text = ds.Tables(0).Rows(x).Item("deposit")
        TextBox3.Text = ds.Tables(0).Rows(x).Item("maxcount")
        showbooks()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim z As MsgBoxResult
        Dim q As String
        z = MsgBox("Do you want to return the " & a1ds.Tables(0).Rows(r).Item("bname") & " ?", MsgBoxStyle.YesNo)
        If z = MsgBoxResult.Yes Then
            q = "update books set status='free', mno=0 where bno=" & a1ds.Tables(0).Rows(r).Item("bno")
            a2cmd.Connection = con
            a2cmd.CommandText = q
            a2cmd.ExecuteNonQuery()
            q = "insert into trans values (" & a1ds.Tables(0).Rows(r).Item("bno") & "," & ds.Tables(0).Rows(x).Item("mno") & ",#" & DateTimePicker1.Value.Date & "#,0,'return')"
            a3cmd.Connection = con
            a3cmd.CommandText = q
            a3cmd.ExecuteNonQuery()
            MsgBox("Book Returned", MsgBoxStyle.Information)
            showbooks()
        End If
    End Sub

    Private Sub showbooks()
        a1cmd.CommandText = "select * from books where mno=" & ds.Tables(0).Rows(x).Item("mno")
        a1cmd.Connection = con
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
    Private Sub a_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles a.CellContentClick

    End Sub

    Private Sub a_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles a.RowEnter
        r = e.RowIndex
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