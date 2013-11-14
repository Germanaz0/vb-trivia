Public Class frm_userpoints

    Private Sub frm_userpoints_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mis Puntajes"

        lbTotal.Text = "Total de Puntos: " & init_module.loggedUser.getTotalPoints()
        refreshGrid()
    End Sub

    Private Sub refreshGrid()
        dtUserPoints.Rows.Clear()
        Dim Results As System.Data.DataTable

        Results = init_module.loggedUser.getPoints()

        If (Results.Rows.Count = 0) Then
            Exit Sub
        End If

        For index As Integer = 0 To Results.Rows.Count - 1
            dtUserPoints.Rows.Add(Results.Rows(index).Item("resultado"), Results.Rows(index).Item("created_at"))

        Next index


    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub
End Class