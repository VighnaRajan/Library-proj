Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolStripStatusLabel1.Text = "You Are In MAIN MENU"
    End Sub

    Private Sub LostBoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lostbkprss.Click
        lostbook.Show()
    End Sub

    Private Sub xit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xit.Click
        End
    End Sub

    Private Sub newbk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newbk.Click
        newbooks.MdiParent = Me
        newbooks.Show()
    End Sub

    Private Sub newsub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newsub.Click
        newsubscriber.Show()
    End Sub

    Private Sub issue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bookissue.Click
        issue.Show()

    End Sub

    Private Sub cndmdprs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cndmdprs.Click
        condemned.Show()
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        booksearch.Show()
    End Sub

    Private Sub ret_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ret.Click
        bookreturn.Show()
    End Sub

    Private Sub stocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stocks.Click
        BookStocksrpt.Show()
    End Sub

    Private Sub category_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles category.Click
        categorywiselistingrpt.Show()
    End Sub

    Private Sub cndmdlst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cndmdlst.Click
        condemnedlistrpt.Show()
    End Sub

    Private Sub lostbksrpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lostbksrpt.Click
        lostbooksrpt.Show()
    End Sub

    Private Sub subhis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subhis.Click
        subscribershistoryrpt.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        newbooks.MdiParent = Me
        newbooks.Show()
    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub
End Class
