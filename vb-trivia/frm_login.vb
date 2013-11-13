Public Class frm_login

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click
        Dim Usuario As classUser

        Try
            Usuario.getUserByAuthentication(txUsername, txPassword)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
