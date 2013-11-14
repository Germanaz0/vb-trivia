Public Class frm_trivia

    Private Trivias(init_module.maxQuestions) As classTrivia
    Private currentTriviaIndex As Integer = 0
    Private maxCounts As Integer = 0

    Dim theQuestion As classTrivia


    Private Sub frm_trivia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        Trivias = init_module.getTrvias()
        maxCounts = countNonEmptyTrivias()

        loadTrivia()
        txQuestion.ReadOnly = True

        init_module.currentTriviaResult = 0
        ''Me.Label1.Text = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat."
        ''Me.RichTextBox1.Text = 
    End Sub

    Private Function countNonEmptyTrivias() As Integer
        Dim count As Integer = 0
        For index As Integer = 0 To Trivias.Count - 1
            If (Not (Trivias(index) Is Nothing)) Then
                count += 1
            End If
        Next index

        Return count
    End Function

    Private Sub loadTrivia()
        If (currentTriviaIndex >= maxCounts) Then
            endTriviasForm()
            Exit Sub
        End If

        theQuestion = Trivias(currentTriviaIndex)
        txQuestion.Text = theQuestion.Question
        lbQuestion.Text = String.Format("Pregunta ({0} puntos)", theQuestion.Points)

        txQuestion.Focus()

        If (currentTriviaIndex = maxCounts - 1) Then
            btAnswer.Text = "Finalizar"
        End If

        txAnswer.Text = ""
        txAnswer.Focus()

        Me.Text = String.Format("Pregunta {0} de {1}", (currentTriviaIndex + 1), maxCounts)
    End Sub

    Private Sub btAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAnswer.Click
        Trivias(currentTriviaIndex).userAnswer = txAnswer.Text

        currentTriviaIndex += 1
        loadTrivia()
    End Sub


    Private Sub endTriviasForm()

        Dim Result As Integer = 0
        For index As Integer = 0 To maxCounts - 1
            ''init_module.(index).getResultPoints()
            Result += Trivias(index).evaluateAnswer()
        Next index

        init_module.currentTriviaResult = Result
        init_module.loggedUser.saveResult(Result)

        Dim msg As String
        msg = "Usted ha obtenido: {0} puntos"
        MsgBox(String.Format(msg, Result), MsgBoxStyle.Information, "Felicitaciones !")

        Me.Close()

    End Sub
End Class