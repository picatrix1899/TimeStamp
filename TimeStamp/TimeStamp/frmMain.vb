Public Class frmMain

	Private entries As New Collection

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim ico As New Icon(Me.GetType.Assembly.GetManifestResourceStream("TimeStamp.a.ico"))
		Me.Icon = ico
		notify.Icon = ico
		notify.Text = "TimeStamp"
		notify.Visible = True
		notify.ContextMenuStrip = mnuContext
	End Sub

	Private Sub Add(ByVal desc As String)

		Dim timeHours As String = System.DateTime.Now().ToString("HH")
		Dim timeMinutes As String = System.DateTime.Now().ToString("mm")
		Dim timeSeconds As String = System.DateTime.Now().ToString("ss")
		Dim entry As New TimeEntry

		entry.StartTime = timeHours * 60 * 60 + timeMinutes * 60 + timeSeconds
		entry.Description = desc

		lbxTimes.Items.Add(entry)
		entries.Add(entry)

	End Sub

	Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
		Me.Hide()
	End Sub

	Private Sub mnuShow_Click(sender As Object, e As EventArgs) Handles mnuShow.Click
		Me.Show()
		tbxDesc.Focus()
	End Sub

	Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

		If Not lbxTimes.SelectedIndex = -1 Then
			Dim selection = lbxTimes.SelectedIndex

			lbxTimes.Items.RemoveAt(lbxTimes.SelectedIndex)
			If lbxTimes.Items.Count > selection Then
				lbxTimes.SelectedIndex = selection
			End If

		End If

	End Sub

	Private Sub tbxDesc_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxDesc.KeyDown

		If e.KeyCode = Keys.Enter Then
			Add(tbxDesc.Text)

			tbxDesc.Text = ""
		End If

	End Sub

	Private Sub mnuDesc_KeyDown(sender As Object, e As KeyEventArgs) Handles mnuDesc.KeyDown
		If e.KeyCode = Keys.Enter Then
			Add(mnuDesc.Text)

			mnuDesc.Text = ""

			mnuContext.Hide()
		End If
	End Sub

	Private Sub notify_MouseClick(sender As Object, e As MouseEventArgs) Handles notify.MouseClick
		If e.Button = MouseButtons.Left Then
			Add("")
		ElseIf e.Button = MouseButtons.Right Then
			mnuContext.Show()
			mnuDesc.Focus()
		End If
	End Sub

	Private Sub lbxTimes_MouseClick(sender As Object, e As MouseEventArgs) Handles lbxTimes.MouseClick
		If e.Button = MouseButtons.Right Then
			If lbxTimes.SelectedIndex > -1 Then



			End If
		End If
	End Sub

	Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

		Dim text As String = ""

		For Each p As TimeEntry In lbxTimes.Items
			text = text & p.ToString() & vbCrLf
		Next

		Clipboard.SetText(text)

	End Sub
End Class
