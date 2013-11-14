<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdi_form
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolStripSep1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolStripResult = New System.Windows.Forms.ToolStripStatusLabel
        Me.mnMain = New System.Windows.Forms.MenuStrip
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComenzarAJugarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MisPuntajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip.SuspendLayout()
        Me.mnMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.toolStripSep1, Me.toolStripResult})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'toolStripSep1
        '
        Me.toolStripSep1.Name = "toolStripSep1"
        Me.toolStripSep1.Size = New System.Drawing.Size(19, 17)
        Me.toolStripSep1.Text = "---"
        '
        'toolStripResult
        '
        Me.toolStripResult.Name = "toolStripResult"
        Me.toolStripResult.Size = New System.Drawing.Size(55, 17)
        Me.toolStripResult.Text = "Resultado"
        '
        'mnMain
        '
        Me.mnMain.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.mnMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.AcercaDeToolStripMenuItem1})
        Me.mnMain.Location = New System.Drawing.Point(0, 0)
        Me.mnMain.Name = "mnMain"
        Me.mnMain.Size = New System.Drawing.Size(632, 24)
        Me.mnMain.TabIndex = 9
        Me.mnMain.Text = "Menu"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComenzarAJugarToolStripMenuItem, Me.MisPuntajesToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Juego"
        '
        'ComenzarAJugarToolStripMenuItem
        '
        Me.ComenzarAJugarToolStripMenuItem.Name = "ComenzarAJugarToolStripMenuItem"
        Me.ComenzarAJugarToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ComenzarAJugarToolStripMenuItem.Text = "Comenzar a &Jugar"
        '
        'MisPuntajesToolStripMenuItem
        '
        Me.MisPuntajesToolStripMenuItem.Name = "MisPuntajesToolStripMenuItem"
        Me.MisPuntajesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.MisPuntajesToolStripMenuItem.Text = "Mis &Puntajes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarDatosToolStripMenuItem, Me.ToolStripSeparator2, Me.CerrarSesiónToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.UsuarioToolStripMenuItem.Text = "Mi Cuenta"
        '
        'CambiarDatosToolStripMenuItem
        '
        Me.CambiarDatosToolStripMenuItem.Name = "CambiarDatosToolStripMenuItem"
        Me.CambiarDatosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CambiarDatosToolStripMenuItem.Text = "Cambiar Datos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(68, 20)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca De"
        '
        'mdi_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.mnMain)
        Me.IsMdiContainer = True
        Me.Name = "mdi_form"
        Me.Text = "mdi_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.mnMain.ResumeLayout(False)
        Me.mnMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents mnMain As System.Windows.Forms.MenuStrip
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComenzarAJugarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MisPuntajesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSep1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolStripResult As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AcercaDeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
