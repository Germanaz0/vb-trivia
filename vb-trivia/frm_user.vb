Public Class frm_user

    Private Sub frm_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Cambiar datos personales"

        txUser.Text = init_module.loggedUser.Username

        txUser.ReadOnly = True

        txPass.MaxLength = 20
        txConfirm.MaxLength = 20
        txPass.Focus()
    End Sub

    Private Sub txConfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txConfirm.TextChanged

    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        SaveUserSettings()
    End Sub

    Private Sub SaveUserSettings()
        If (txPass.Text.Length = 0) Then
            MsgBox("La contraseña no debe estar vacia")
            Exit Sub
        End If

        If (txPass.Text <> txConfirm.Text) Then
            MsgBox("La contraseña debe coincidir", MsgBoxStyle.Information, "Error al cargar datos")
            Exit Sub
        End If

        init_module.loggedUser.savePassword(txPass.Text)

        MsgBox("Los datos se actualizaron con éxito", MsgBoxStyle.Exclamation, "Bien !")

        txPass.Text = ""
        txConfirm.Text = ""

    End Sub

End Class