Public Class frm_login

    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click
        doLogin()
    End Sub

    Private Sub txPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txPassword.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            doLogin()
        End If

    End Sub

    Private Sub doLogin()
        Dim User As New classUser
        Try
            User.getUserByAuthentication(txUsername.Text, txPassword.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error de Ingreso")
            Exit Sub
        End Try

        If (User.isLoggedIn()) Then
            init_module.startMainProgram(User)
        End If

        txUsername.Text = ""
        txPassword.Text = ""
        txUsername.Focus()
    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txUsername.Focus()
        txUsername.MaxLength = "20"
        txPassword.MaxLength = "20"
    End Sub
End Class
