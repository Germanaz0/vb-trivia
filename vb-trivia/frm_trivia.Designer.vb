<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_trivia
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
        Me.txQuestion = New System.Windows.Forms.RichTextBox
        Me.lbQuestion = New System.Windows.Forms.Label
        Me.txAnswer = New System.Windows.Forms.RichTextBox
        Me.lbAnswer = New System.Windows.Forms.Label
        Me.btAnswer = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txQuestion
        '
        Me.txQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txQuestion.Location = New System.Drawing.Point(13, 42)
        Me.txQuestion.Name = "txQuestion"
        Me.txQuestion.Size = New System.Drawing.Size(628, 67)
        Me.txQuestion.TabIndex = 20
        Me.txQuestion.Text = ""
        '
        'lbQuestion
        '
        Me.lbQuestion.AutoSize = True
        Me.lbQuestion.Location = New System.Drawing.Point(13, 23)
        Me.lbQuestion.Name = "lbQuestion"
        Me.lbQuestion.Size = New System.Drawing.Size(50, 13)
        Me.lbQuestion.TabIndex = 1
        Me.lbQuestion.Text = "Pregunta"
        '
        'txAnswer
        '
        Me.txAnswer.Location = New System.Drawing.Point(16, 133)
        Me.txAnswer.Name = "txAnswer"
        Me.txAnswer.Size = New System.Drawing.Size(625, 189)
        Me.txAnswer.TabIndex = 0
        Me.txAnswer.Text = ""
        '
        'lbAnswer
        '
        Me.lbAnswer.AutoSize = True
        Me.lbAnswer.Location = New System.Drawing.Point(13, 117)
        Me.lbAnswer.Name = "lbAnswer"
        Me.lbAnswer.Size = New System.Drawing.Size(58, 13)
        Me.lbAnswer.TabIndex = 3
        Me.lbAnswer.Text = "Respuesta"
        '
        'btAnswer
        '
        Me.btAnswer.Location = New System.Drawing.Point(565, 333)
        Me.btAnswer.Name = "btAnswer"
        Me.btAnswer.Size = New System.Drawing.Size(75, 23)
        Me.btAnswer.TabIndex = 1
        Me.btAnswer.Text = "Responder"
        Me.btAnswer.UseVisualStyleBackColor = True
        '
        'frm_trivia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 368)
        Me.Controls.Add(Me.btAnswer)
        Me.Controls.Add(Me.lbAnswer)
        Me.Controls.Add(Me.txAnswer)
        Me.Controls.Add(Me.lbQuestion)
        Me.Controls.Add(Me.txQuestion)
        Me.Name = "frm_trivia"
        Me.Text = "frm_trivia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txQuestion As System.Windows.Forms.RichTextBox
    Friend WithEvents lbQuestion As System.Windows.Forms.Label
    Friend WithEvents txAnswer As System.Windows.Forms.RichTextBox
    Friend WithEvents lbAnswer As System.Windows.Forms.Label
    Friend WithEvents btAnswer As System.Windows.Forms.Button
End Class
