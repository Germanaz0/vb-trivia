<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lbUsername = New System.Windows.Forms.Label
        Me.lbPassword = New System.Windows.Forms.Label
        Me.lbConfirmPassword = New System.Windows.Forms.Label
        Me.txUser = New System.Windows.Forms.TextBox
        Me.txPass = New System.Windows.Forms.TextBox
        Me.txConfirm = New System.Windows.Forms.TextBox
        Me.btSave = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbUsername, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbPassword, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbConfirmPassword, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txUser, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txPass, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txConfirm, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btSave, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 29)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(268, 141)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbUsername.Location = New System.Drawing.Point(34, 0)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lbUsername.Size = New System.Drawing.Size(43, 31)
        Me.lbUsername.TabIndex = 0
        Me.lbUsername.Text = "Usuario"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbPassword.Location = New System.Drawing.Point(43, 31)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lbPassword.Size = New System.Drawing.Size(34, 31)
        Me.lbPassword.TabIndex = 1
        Me.lbPassword.Text = "Clave"
        '
        'lbConfirmPassword
        '
        Me.lbConfirmPassword.AutoSize = True
        Me.lbConfirmPassword.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbConfirmPassword.Location = New System.Drawing.Point(6, 62)
        Me.lbConfirmPassword.Name = "lbConfirmPassword"
        Me.lbConfirmPassword.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lbConfirmPassword.Size = New System.Drawing.Size(71, 31)
        Me.lbConfirmPassword.TabIndex = 2
        Me.lbConfirmPassword.Text = "Repetir Clave"
        '
        'txUser
        '
        Me.txUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.txUser.Location = New System.Drawing.Point(83, 3)
        Me.txUser.Name = "txUser"
        Me.txUser.Size = New System.Drawing.Size(182, 20)
        Me.txUser.TabIndex = 20
        '
        'txPass
        '
        Me.txPass.Dock = System.Windows.Forms.DockStyle.Right
        Me.txPass.Location = New System.Drawing.Point(83, 34)
        Me.txPass.Name = "txPass"
        Me.txPass.Size = New System.Drawing.Size(182, 20)
        Me.txPass.TabIndex = 0
        Me.txPass.UseSystemPasswordChar = True
        '
        'txConfirm
        '
        Me.txConfirm.Dock = System.Windows.Forms.DockStyle.Right
        Me.txConfirm.Location = New System.Drawing.Point(83, 65)
        Me.txConfirm.Name = "txConfirm"
        Me.txConfirm.Size = New System.Drawing.Size(182, 20)
        Me.txConfirm.TabIndex = 1
        Me.txConfirm.UseSystemPasswordChar = True
        '
        'btSave
        '
        Me.btSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btSave.Location = New System.Drawing.Point(137, 96)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(128, 42)
        Me.btSave.TabIndex = 2
        Me.btSave.Text = "Guardar"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 192)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frm_user"
        Me.Text = "frm_user"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbUsername As System.Windows.Forms.Label
    Friend WithEvents lbPassword As System.Windows.Forms.Label
    Friend WithEvents lbConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txUser As System.Windows.Forms.TextBox
    Friend WithEvents txPass As System.Windows.Forms.TextBox
    Friend WithEvents txConfirm As System.Windows.Forms.TextBox
    Friend WithEvents btSave As System.Windows.Forms.Button
End Class
