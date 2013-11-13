Public Class classUser
    Public ID As Integer = 0
    Public Username As String = ""
    Public Password As String = ""
    Public Rol As String = "user"

    Public Sub New()

    End Sub

    Public Function getUserByAuthentication(ByVal Username As String, ByVal Password As String) As classUser

        Dim Query As String

        Dim Res As System.Data.DataTable

        If (Username.Length = 0 Or Password.Length = 0) Then
            Throw New Exception("El usuario o la clave no deben estar vacios")
        End If

        Query = "SELECT id, username, password, rol FROM usuarios WHERE username='{0}' AND password='{1}' LIMIT 1;"
        Query = String.Format(Query, Username, Password)

        Res = db.LEER(Query)

        If (Res.Columns.Count = 0) Then
            Throw New Exception("El Usuario o la Contraseña no coinciden")
        End If

        Me.ID = Res.Rows(0).Item("id")
        MsgBox(Me.ID)

        Return Nothing

    End Function

End Class
