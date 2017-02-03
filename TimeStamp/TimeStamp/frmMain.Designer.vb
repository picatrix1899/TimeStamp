<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
	Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.notify = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.mnuContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.mnuDesc = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuShow = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnHide = New System.Windows.Forms.Button()
		Me.lbxTimes = New System.Windows.Forms.ListBox()
		Me.btnRemove = New System.Windows.Forms.Button()
		Me.tbxDesc = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnExport = New System.Windows.Forms.Button()
		Me.mnuContext.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'notify
		'
		Me.notify.Text = "NotifyIcon1"
		Me.notify.Visible = True
		'
		'mnuContext
		'
		Me.mnuContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDesc, Me.ToolStripSeparator1, Me.mnuShow})
		Me.mnuContext.Name = "test"
		Me.mnuContext.Size = New System.Drawing.Size(261, 57)
		'
		'mnuDesc
		'
		Me.mnuDesc.Name = "mnuDesc"
		Me.mnuDesc.Size = New System.Drawing.Size(200, 23)
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(257, 6)
		'
		'mnuShow
		'
		Me.mnuShow.Name = "mnuShow"
		Me.mnuShow.Size = New System.Drawing.Size(260, 22)
		Me.mnuShow.Text = "Show"
		'
		'btnHide
		'
		Me.btnHide.Location = New System.Drawing.Point(543, 327)
		Me.btnHide.Name = "btnHide"
		Me.btnHide.Size = New System.Drawing.Size(87, 27)
		Me.btnHide.TabIndex = 2
		Me.btnHide.Text = "Hide"
		Me.btnHide.UseVisualStyleBackColor = True
		'
		'lbxTimes
		'
		Me.lbxTimes.FormattingEnabled = True
		Me.lbxTimes.Location = New System.Drawing.Point(12, 38)
		Me.lbxTimes.Name = "lbxTimes"
		Me.lbxTimes.Size = New System.Drawing.Size(358, 316)
		Me.lbxTimes.TabIndex = 3
		'
		'btnRemove
		'
		Me.btnRemove.Location = New System.Drawing.Point(376, 327)
		Me.btnRemove.Name = "btnRemove"
		Me.btnRemove.Size = New System.Drawing.Size(87, 27)
		Me.btnRemove.TabIndex = 5
		Me.btnRemove.Text = "Remove"
		Me.btnRemove.UseVisualStyleBackColor = True
		'
		'tbxDesc
		'
		Me.tbxDesc.Location = New System.Drawing.Point(12, 12)
		Me.tbxDesc.MaxLength = 0
		Me.tbxDesc.Name = "tbxDesc"
		Me.tbxDesc.Size = New System.Drawing.Size(251, 20)
		Me.tbxDesc.TabIndex = 6
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(376, 38)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(254, 283)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Stats"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(0, 13)
		Me.Label1.TabIndex = 0
		'
		'btnExport
		'
		Me.btnExport.Location = New System.Drawing.Point(555, 12)
		Me.btnExport.Name = "btnExport"
		Me.btnExport.Size = New System.Drawing.Size(75, 23)
		Me.btnExport.TabIndex = 8
		Me.btnExport.Text = "Export"
		Me.btnExport.UseVisualStyleBackColor = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(642, 366)
		Me.Controls.Add(Me.btnExport)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.tbxDesc)
		Me.Controls.Add(Me.btnRemove)
		Me.Controls.Add(Me.lbxTimes)
		Me.Controls.Add(Me.btnHide)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmMain"
		Me.ShowInTaskbar = False
		Me.Text = "TimeStamp @picatrix1899"
		Me.mnuContext.ResumeLayout(False)
		Me.mnuContext.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents notify As NotifyIcon
	Friend WithEvents mnuContext As ContextMenuStrip
	Friend WithEvents mnuShow As ToolStripMenuItem
	Friend WithEvents btnHide As Button
	Friend WithEvents lbxTimes As ListBox
	Friend WithEvents mnuDesc As ToolStripTextBox
	Friend WithEvents btnRemove As Button
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents tbxDesc As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnExport As Button
End Class
