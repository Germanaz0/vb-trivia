Module init_module

    Public db As New Mysql
    Public loggedUser As classUser
    Private questionsCounts As Integer
    Public ventana_actual As Form
    Public maxQuestions As Integer = 5
    Public currentTriviaResult As Integer = 0

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

    Public Function getTrvias() As classTrivia()

        Dim Trivias(maxQuestions) As classTrivia
        Dim Res As System.Data.DataTable
        Dim Query As String

        Query = "SELECT id, pregunta, respuesta, puntaje FROM preguntas ORDER BY RAND() LIMIT {0};"

        Query = String.Format(Query, maxQuestions)

        Res = db.LEER(Query)

        If (Res.Rows.Count = 0) Then
            Return Nothing
        End If

        For x As Integer = 0 To Res.Rows.Count - 1
            Trivias(x) = New classTrivia()
            Trivias(x).ID = Res.Rows(x).Item("id")
            Trivias(x).Question = Res.Rows(x).Item("pregunta")
            Trivias(x).Answer = Res.Rows(x).Item("respuesta")
            Trivias(x).Points = Res.Rows(x).Item("puntaje")
        Next x

        Return Trivias
    End Function

    Public Sub centrarVentanaHija(ByVal form_padre As Form, Optional ByRef ventana_hija As Form = Nothing)
        If ventana_hija Is Nothing Then
            If form_padre.HasChildren Then
                Dim position As Point
                position = New Point((form_padre.ClientSize.Width - ventana_actual.Width) / 2, ((form_padre.ClientSize.Height - ventana_actual.Height) / 2) - 25)
                ventana_actual.Location = position
            End If
        Else
            Dim position As Point
            position = New Point(form_padre.Location.X + (form_padre.ClientSize.Width - ventana_hija.Width) / 2, (form_padre.Location.Y + (form_padre.ClientSize.Height - ventana_hija.Height) / 2) - 25)
            ventana_hija.Location = position
        End If
    End Sub

    Public Sub abrirVentana(ByVal form_hijo As Form, ByVal form_padre As Form, ByVal estado As String)
        ventana_actual = form_hijo
        'Set the Parent Form of the Child window.
        ventana_actual.MdiParent = form_padre
        'NewMDIChild.Width = Me.Width
        'NewMDIChild.Height = Me.Height


        ventana_actual.Show()
        'ventana_actual.WindowState = FormWindowState.Maximized

        centrarVentanaHija(form_padre)
    End Sub

End Module
