﻿Public Class classUser
    Public ID As Integer = 0
    Public Username As String = ""
    Public Password As String = ""
    Public Rol As String = "user"

    Protected currentPoints As Integer = 0

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

        If (Res.Rows.Count = 0) Then
            Throw New Exception("El Usuario o la Contraseña no coinciden")
        End If

        Me.ID = Res.Rows(0).Item("id")
        Me.Username = Res.Rows(0).Item("username")
        Me.Rol = Res.Rows(0).Item("rol")
        Me.Password = Res.Rows(0).Item("password")

        Return Me

    End Function

    Public Function isLoggedIn()
        If (Me.ID > 0) Then
            Return True
        End If

        Return False
    End Function


    Public Function saveResult(ByVal Result As Integer)

        Dim Query As String

        Query = "INSERT INTO resultados (id, usuario_id, resultado, created_at) VALUES (NULL, '{0}', '{1}', CURRENT_TIMESTAMP);"
        Query = String.Format(Query, init_module.loggedUser.ID, Result)


        Return db.QUERY(Query)
    End Function

    Public Function getTotalPoints() As Integer
        Dim Query As String
        Dim Res As System.Data.DataTable
        Dim toReturn As Object
        Query = "SELECT SUM(resultado) as SUMA FROM resultados WHERE usuario_id={0}"

        Res = init_module.db.LEER(String.Format(Query, Me.ID))

        If (Res.Rows.Count > 0) Then
            toReturn = Res.Rows(0).Item("SUMA")
            If (IsNumeric(toReturn)) Then
                Return toReturn
            End If
        End If
        Return 0
    End Function

    Public Function getPoints() As System.Data.DataTable
        Dim Query As String
        Dim Res As System.Data.DataTable

        Query = "SELECT id, usuario_id, resultado, created_at FROM resultados WHERE usuario_id={0}"

        Res = init_module.db.LEER(String.Format(Query, Me.ID))

        Return Res
    End Function

    Public Function savePassword(ByVal Password As String)
        ''UPDATE `vb-trivia`.`usuarios` SET `password` = 'admin2' WHERE `usuarios`.`id` =1;

        Dim Query As String
        Query = "UPDATE usuarios SET password = '{0}' WHERE id = {1}"

        Return db.QUERY(String.Format(Query, Password, Me.ID))
    End Function

End Class
