<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTableauScores
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DgvTabScore = New System.Windows.Forms.DataGridView()
        Me.BtnQuit = New System.Windows.Forms.Button()
        CType(Me.DgvTabScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(705, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DgvTabScore
        '
        Me.DgvTabScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTabScore.Location = New System.Drawing.Point(139, 65)
        Me.DgvTabScore.Name = "DgvTabScore"
        Me.DgvTabScore.Size = New System.Drawing.Size(240, 150)
        Me.DgvTabScore.TabIndex = 2
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Gray
        Me.BtnQuit.Location = New System.Drawing.Point(620, 12)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(79, 31)
        Me.BtnQuit.TabIndex = 4
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'FormTableauScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.DgvTabScore)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormTableauScores"
        Me.Text = "FormTableauScores"
        CType(Me.DgvTabScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents DgvTabScore As Windows.Forms.DataGridView
    Friend WithEvents BtnQuit As Windows.Forms.Button
End Class
