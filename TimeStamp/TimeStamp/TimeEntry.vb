Public Class TimeEntry

	Public Property TimeText() As String
	Public Property StartTime() As Date
	Public Property EndTime() As Long
	Public Property Description() As String = ""
	Public Property Duration() As Long


	Public ReadOnly Property Text() As String
		Get
			If Description = "" Then
				Return TimeText
			Else
				Return TimeText & " - " & Description
			End If

		End Get
	End Property

	Public ReadOnly Property StartTimeText() As String
		Get

			Return StartTime.ToString("HH") & ":" & StartTime.ToString("mm")

		End Get
	End Property

	Public Overrides Function ToString() As String
		If Description = "" Then
			Return StartTimeText
		Else
			Return StartTimeText & " - " & Description
		End If
	End Function

End Class
