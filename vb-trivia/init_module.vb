Module init_module

    Public db As New Mysql
    Public loggedUser As classUser
    Private questionsCounts As Integer

    Public Sub Main()
        frm_login.ShowDialog()
        ''mdi_form.ShowDialog()
    End Sub

    Public Sub startMainProgram(ByVal User As classUser)
        If (User Is Nothing) Then
            MsgBox("Error inesperado de la aplicación", MsgBoxStyle.Critical, "Error critico")
            Exit Sub
        End If

        loggedUser = User

        frm_login.Hide()
        mdi_form.ShowDialog()


    End Sub

    Public Sub logoutFromSystem()
        loggedUser = Nothing

        mdi_form.Hide()
        frm_login.Show()

    End Sub

    Public Function countAllQuestions() As Integer

        Dim Query As String
        Query = "SELECT COUNT(*) as TOTAL FROM preguntas"

        Dim Res As System.Data.DataTable

        Res = db.LEER(Query)

        If (Res.Rows.Count > 0) Then
            Return Res.Rows(0).Item("TOTAL")
        End If

        Return 0
    End Function

End Module
