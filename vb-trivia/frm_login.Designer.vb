<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.grpLogin = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btLogin = New System.Windows.Forms.Button
        Me.lbUsername = New System.Windows.Forms.Label
        Me.lbPassword = New System.Windows.Forms.Label
        Me.txUsername = New System.Windows.Forms.TextBox
        Me.txPassword = New System.Windows.Forms.TextBox
        Me.grpLogin.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLogin
        '
        Me.grpLogin.AutoSize = True
        Me.grpLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpLogin.Controls.Add(Me.TableLayoutPanel1)
        Me.grpLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpLogin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpLogin.Location = New System.Drawing.Point(0, 0)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(292, 164)
        Me.grpLogin.TabIndex = 0
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Ingresar al Sistema"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.37313!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.62687!))
        Me.TableLayoutPanel1.Controls.Add(Me.btLogin, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbUsername, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbPassword, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txUsername, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txPassword, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(268, 114)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btLogin
        '
        Me.btLogin.Location = New System.Drawing.Point(137, 79)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(128, 32)
        Me.btLogin.TabIndex = 2
        Me.btLogin.Text = "Login"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbUsername.Location = New System.Drawing.Point(88, 10)
        Me.lbUsername.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Size = New System.Drawing.Size(43, 28)
        Me.lbUsername.TabIndex = 1
        Me.lbUsername.Text = "Usuario"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbPassword.Location = New System.Drawing.Point(78, 48)
        Me.lbPassword.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(53, 28)
        Me.lbPassword.TabIndex = 2
        Me.lbPassword.Text = "Password"
        '
        'txUsername
        '
        Me.txUsername.Dock = System.Windows.Forms.DockStyle.Left
        Me.txUsername.Location = New System.Drawing.Point(137, 10)
        Me.txUsername.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txUsername.Name = "txUsername"
        Me.txUsername.Size = New System.Drawing.Size(128, 20)
        Me.txUsername.TabIndex = 0
        '
        'txPassword
        '
        Me.txPassword.Dock = System.Windows.Forms.DockStyle.Left
        Me.txPassword.Location = New System.Drawing.Point(137, 48)
        Me.txPassword.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txPassword.Name = "txPassword"
        Me.txPassword.Size = New System.Drawing.Size(128, 20)
        Me.txPassword.TabIndex = 1
        Me.txPassword.UseSystemPasswordChar = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 164)
        Me.Controls.Add(Me.grpLogin)
        Me.Name = "frm_login"
        Me.Text = "Comenzar a Jugar"
        Me.grpLogin.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpLogin As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btLogin As System.Windows.Forms.Button
    Friend WithEvents lbUsername As System.Windows.Forms.Label
    Friend WithEvents lbPassword As System.Windows.Forms.Label
    Friend WithEvents txUsername As System.Windows.Forms.TextBox
    Friend WithEvents txPassword As System.Windows.Forms.TextBox

End Class
