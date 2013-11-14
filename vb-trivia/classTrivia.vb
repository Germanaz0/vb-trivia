Public Class classTrivia
    Public ID As Integer = 0
    Public Question As String = ""
    Public Answer As String = ""
    Public Points As Integer = 0

    Public userAnswer As String = ""
    Public Sub New()

    End Sub

    Public Function evaluateAnswer() As Integer

        If (userAnswer.ToLower() = Answer.ToLower) Then
            Return Me.Points
        End If

        Return 0

    End Function

End Class
