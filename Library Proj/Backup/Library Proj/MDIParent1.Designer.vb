<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.EntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.newbk = New System.Windows.Forms.ToolStripMenuItem
        Me.newsub = New System.Windows.Forms.ToolStripMenuItem
        Me.ProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.bookissue = New System.Windows.Forms.ToolStripMenuItem
        Me.ret = New System.Windows.Forms.ToolStripMenuItem
        Me.lostbkprss = New System.Windows.Forms.ToolStripMenuItem
        Me.cndmdprs = New System.Windows.Forms.ToolStripMenuItem
        Me.search = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.stocks = New System.Windows.Forms.ToolStripMenuItem
        Me.cndmdlst = New System.Windows.Forms.ToolStripMenuItem
        Me.lostbksrpt = New System.Windows.Forms.ToolStripMenuItem
        Me.category = New System.Windows.Forms.ToolStripMenuItem
        Me.subhis = New System.Windows.Forms.ToolStripMenuItem
        Me.xit = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntryToolStripMenuItem, Me.ProcessToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.xit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EntryToolStripMenuItem
        '
        Me.EntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newbk, Me.newsub})
        Me.EntryToolStripMenuItem.Name = "EntryToolStripMenuItem"
        Me.EntryToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.EntryToolStripMenuItem.Text = "Entry"
        '
        'newbk
        '
        Me.newbk.Name = "newbk"
        Me.newbk.Size = New System.Drawing.Size(166, 22)
        Me.newbk.Text = "New Book"
        '
        'newsub
        '
        Me.newsub.Name = "newsub"
        Me.newsub.Size = New System.Drawing.Size(166, 22)
        Me.newsub.Text = "New Scrubscriber"
        '
        'ProcessToolStripMenuItem
        '
        Me.ProcessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bookissue, Me.ret, Me.lostbkprss, Me.cndmdprs, Me.search})
        Me.ProcessToolStripMenuItem.Name = "ProcessToolStripMenuItem"
        Me.ProcessToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ProcessToolStripMenuItem.Text = "Process"
        '
        'bookissue
        '
        Me.bookissue.Name = "bookissue"
        Me.bookissue.Size = New System.Drawing.Size(140, 22)
        Me.bookissue.Text = "Book-Issue"
        '
        'ret
        '
        Me.ret.Name = "ret"
        Me.ret.Size = New System.Drawing.Size(140, 22)
        Me.ret.Text = "Return"
        '
        'lostbkprss
        '
        Me.lostbkprss.Name = "lostbkprss"
        Me.lostbkprss.Size = New System.Drawing.Size(140, 22)
        Me.lostbkprss.Text = "Lost Book"
        '
        'cndmdprs
        '
        Me.cndmdprs.Name = "cndmdprs"
        Me.cndmdprs.Size = New System.Drawing.Size(140, 22)
        Me.cndmdprs.Text = "Condemned"
        '
        'search
        '
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(140, 22)
        Me.search.Text = "Search"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stocks, Me.cndmdlst, Me.lostbksrpt, Me.category, Me.subhis})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'stocks
        '
        Me.stocks.Name = "stocks"
        Me.stocks.Size = New System.Drawing.Size(186, 22)
        Me.stocks.Text = "Stocks"
        '
        'cndmdlst
        '
        Me.cndmdlst.Name = "cndmdlst"
        Me.cndmdlst.Size = New System.Drawing.Size(186, 22)
        Me.cndmdlst.Text = "condemned list"
        '
        'lostbksrpt
        '
        Me.lostbksrpt.Name = "lostbksrpt"
        Me.lostbksrpt.Size = New System.Drawing.Size(186, 22)
        Me.lostbksrpt.Text = "Lost Books"
        '
        'category
        '
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(186, 22)
        Me.category.Text = "Category wise Listing"
        '
        'subhis
        '
        Me.subhis.Name = "subhis"
        Me.subhis.Size = New System.Drawing.Size(186, 22)
        Me.subhis.Text = "Subscriber's History"
        '
        'xit
        '
        Me.xit.Name = "xit"
        Me.xit.Size = New System.Drawing.Size(37, 20)
        Me.xit.Text = "Exit"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(632, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.Text = "Library"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents newbk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newsub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bookissue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ret As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lostbkprss As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cndmdprs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents search As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stocks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cndmdlst As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lostbksrpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents category As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subhis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

End Class
