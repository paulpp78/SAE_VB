<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartAppli
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
        Me.BtnOption = New System.Windows.Forms.Button()
        Me.BtnSeeScore = New System.Windows.Forms.Button()
        Me.BtnStatJoueur = New System.Windows.Forms.Button()
        Me.BtnNewGame = New System.Windows.Forms.Button()
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnOption
        '
        Me.BtnOption.BackColor = System.Drawing.Color.Red
        Me.BtnOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOption.ForeColor = System.Drawing.Color.Transparent
        Me.BtnOption.Location = New System.Drawing.Point(113, 281)
        Me.BtnOption.Name = "BtnOption"
        Me.BtnOption.Size = New System.Drawing.Size(204, 44)
        Me.BtnOption.TabIndex = 7
        Me.BtnOption.Text = "Option"
        Me.BtnOption.UseVisualStyleBackColor = False
        '
        'BtnSeeScore
        '
        Me.BtnSeeScore.BackColor = System.Drawing.Color.Transparent
        Me.BtnSeeScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeeScore.ForeColor = System.Drawing.Color.Blue
        Me.BtnSeeScore.Location = New System.Drawing.Point(12, 12)
        Me.BtnSeeScore.Name = "BtnSeeScore"
        Me.BtnSeeScore.Size = New System.Drawing.Size(95, 33)
        Me.BtnSeeScore.TabIndex = 8
        Me.BtnSeeScore.Text = "Score"
        Me.BtnSeeScore.UseVisualStyleBackColor = False
        '
        'BtnStatJoueur
        '
        Me.BtnStatJoueur.BackColor = System.Drawing.Color.Red
        Me.BtnStatJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatJoueur.ForeColor = System.Drawing.Color.Transparent
        Me.BtnStatJoueur.Location = New System.Drawing.Point(113, 231)
        Me.BtnStatJoueur.Name = "BtnStatJoueur"
        Me.BtnStatJoueur.Size = New System.Drawing.Size(204, 44)
        Me.BtnStatJoueur.TabIndex = 9
        Me.BtnStatJoueur.Text = "Statistiques"
        Me.BtnStatJoueur.UseVisualStyleBackColor = False
        '
        'BtnNewGame
        '
        Me.BtnNewGame.BackColor = System.Drawing.Color.Blue
        Me.BtnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewGame.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNewGame.Location = New System.Drawing.Point(113, 181)
        Me.BtnNewGame.Name = "BtnNewGame"
        Me.BtnNewGame.Size = New System.Drawing.Size(204, 44)
        Me.BtnNewGame.TabIndex = 10
        Me.BtnNewGame.Text = "New Game"
        Me.BtnNewGame.UseVisualStyleBackColor = False
        '
        'BtnAbout
        '
        Me.BtnAbout.BackColor = System.Drawing.Color.Red
        Me.BtnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbout.ForeColor = System.Drawing.Color.Transparent
        Me.BtnAbout.Location = New System.Drawing.Point(113, 331)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(204, 44)
        Me.BtnAbout.TabIndex = 11
        Me.BtnAbout.Text = "About"
        Me.BtnAbout.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Transparent
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuit.ForeColor = System.Drawing.Color.Red
        Me.BtnQuit.Location = New System.Drawing.Point(354, 12)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(35, 33)
        Me.BtnQuit.TabIndex = 12
        Me.BtnQuit.Text = "exit"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'StartAppli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(401, 450)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnAbout)
        Me.Controls.Add(Me.BtnNewGame)
        Me.Controls.Add(Me.BtnStatJoueur)
        Me.Controls.Add(Me.BtnSeeScore)
        Me.Controls.Add(Me.BtnOption)
        Me.Name = "StartAppli"
        Me.Text = "StartAppli"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnOption As Windows.Forms.Button
    Friend WithEvents BtnSeeScore As Windows.Forms.Button
    Friend WithEvents BtnStatJoueur As Windows.Forms.Button
    Friend WithEvents BtnNewGame As Windows.Forms.Button
    Friend WithEvents BtnAbout As Windows.Forms.Button
    Friend WithEvents BtnQuit As Windows.Forms.Button
End Class
