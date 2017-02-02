Public Class TimeEntry

	Public Property TimeText() As String
	Public Property StartTime() As Long
	Public Property EndTime() As Long
	Public Property Description() As String
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
			Dim hours As Integer = StartTime / 60 / 60
			Dim minutes As Integer = StartTime / 60 - hours * 60
			Dim seconds As Integer = StartTime - minutes * 60 - hours * 60 * 60

			Dim outHours As String
			Dim outMinutes As String
			Dim outSeconds As String

			If hours < 9 Then
				outHours = "0" & hours
			Else
				outHours = hours
			End If

			If minutes < 9 Then
				outMinutes = "0" & minutes
			Else
				outMinutes = minutes
			End If

			If hours < 9 Then
				outHours = "0" & hours
			Else
				outHours = hours
			End If

			Return outHours & ":" & outMinutes & ":" & outSeconds

		End Get
	End Property

	Public Overrides Function ToString() As String
		If Description = "" Then
			Return TimeText
		Else
			Return TimeText & " - " & Description
		End If
	End Function

End Class
