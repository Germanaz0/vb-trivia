Imports System.Windows.Forms

Public Class mdi_form

    Private m_ChildFormNumber As Integer
    Private totalQuestions As Integer

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub



    Private Sub mdi_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "Bienvenidos al sistema de Trivias v1.0"

        Me.totalQuestions = init_module.countAllQuestions()

        If (Me.totalQuestions = 0) Then
            ComenzarAJugarToolStripMenuItem.Enabled = False
        End If

        refreshStatusBar()
    End Sub


    Public Sub refreshStatusBar()
        Me.ToolStripStatusLabel.Text = "* " & loggedUser.Username.ToUpper() & " *"
        Me.toolStripResult.Text = "Resultado: " & loggedUser.getTotalPoints() & " Puntos"

        If (loggedUser.getTotalPoints() = 0) Then
            MisPuntajesToolStripMenuItem.Enabled = False
        Else
            MisPuntajesToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        init_module.logoutFromSystem()
    End Sub

    Private Sub ComenzarAJugarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComenzarAJugarToolStripMenuItem.Click
        abrirVentana(frm_trivia, Me, "")
    End Sub


    Private Sub MisPuntajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MisPuntajesToolStripMenuItem.Click
        abrirVentana(frm_userpoints, Me, "")
    End Sub

    Private Sub CambiarDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarDatosToolStripMenuItem.Click
        abrirVentana(frm_user, Me, "")
    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        abrirVentana(frm_acerca, Me, "")
    End Sub
End Class
