<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_userpoints
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dtUserPoints = New System.Windows.Forms.DataGridView
        Me.Puntos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lbTotal = New System.Windows.Forms.Label
        Me.btClose = New System.Windows.Forms.Button
        CType(Me.dtUserPoints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtUserPoints
        '
        Me.dtUserPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtUserPoints.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Puntos, Me.Fecha})
        Me.dtUserPoints.Location = New System.Drawing.Point(12, 35)
        Me.dtUserPoints.Name = "dtUserPoints"
        Me.dtUserPoints.Size = New System.Drawing.Size(378, 267)
        Me.dtUserPoints.TabIndex = 0
        '
        'Puntos
        '
        Me.Puntos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Puntos.DefaultCellStyle = DataGridViewCellStyle3
        Me.Puntos.HeaderText = "Puntos"
        Me.Puntos.Name = "Puntos"
        Me.Puntos.ReadOnly = True
        Me.Puntos.Width = 63
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Format = "G"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle4
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 60
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(12, 9)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(88, 13)
        Me.lbTotal.TabIndex = 1
        Me.lbTotal.Text = "Total de Puntos: "
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(314, 309)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 23)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "Cerrar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'frm_userpoints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 345)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.dtUserPoints)
        Me.Name = "frm_userpoints"
        Me.Text = "frm_userpoints"
        CType(Me.dtUserPoints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtUserPoints As System.Windows.Forms.DataGridView
    Friend WithEvents Puntos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents btClose As System.Windows.Forms.Button
End Class
