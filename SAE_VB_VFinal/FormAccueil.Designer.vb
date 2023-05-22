<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccueil
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

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CmbJoueur1 = New System.Windows.Forms.ComboBox()
        Me.CmbJoueur2 = New System.Windows.Forms.ComboBox()
        Me.BtnStartGame = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSeeScore = New System.Windows.Forms.Button()
        Me.BtnStatJoueur = New System.Windows.Forms.Button()
        Me.BtnOption = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbJoueur1
        '
        Me.CmbJoueur1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbJoueur1.FormattingEnabled = True
        Me.CmbJoueur1.Items.AddRange(New Object() {"Joueur 1", "Player 1", "Jugador 1"})
        Me.CmbJoueur1.Location = New System.Drawing.Point(128, 103)
        Me.CmbJoueur1.Name = "CmbJoueur1"
        Me.CmbJoueur1.Size = New System.Drawing.Size(156, 21)
        Me.CmbJoueur1.TabIndex = 0
        '
        'CmbJoueur2
        '
        Me.CmbJoueur2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbJoueur2.FormattingEnabled = True
        Me.CmbJoueur2.Items.AddRange(New Object() {"Joueur 2", "Player 2", "Jugador 2"})
        Me.CmbJoueur2.Location = New System.Drawing.Point(498, 103)
        Me.CmbJoueur2.Name = "CmbJoueur2"
        Me.CmbJoueur2.Size = New System.Drawing.Size(193, 21)
        Me.CmbJoueur2.TabIndex = 1
        '
        'BtnStartGame
        '
        Me.BtnStartGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStartGame.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnStartGame.ForeColor = System.Drawing.Color.White
        Me.BtnStartGame.Location = New System.Drawing.Point(128, 248)
        Me.BtnStartGame.Name = "BtnStartGame"
        Me.BtnStartGame.Size = New System.Drawing.Size(563, 36)
        Me.BtnStartGame.TabIndex = 2
        Me.BtnStartGame.Text = "Démarrer la partie"
        Me.BtnStartGame.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuit.ForeColor = System.Drawing.Color.White
        Me.BtnQuit.Location = New System.Drawing.Point(763, 12)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(105, 44)
        Me.BtnQuit.TabIndex = 3
        Me.BtnQuit.Text = "Quitter"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'BtnSeeScore
        '
        Me.BtnSeeScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnSeeScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeeScore.ForeColor = System.Drawing.Color.White
        Me.BtnSeeScore.Location = New System.Drawing.Point(12, 354)
        Me.BtnSeeScore.Name = "BtnSeeScore"
        Me.BtnSeeScore.Size = New System.Drawing.Size(95, 33)
        Me.BtnSeeScore.TabIndex = 4
        Me.BtnSeeScore.Text = "Voir le score"
        Me.BtnSeeScore.UseVisualStyleBackColor = False
        '
        'BtnStatJoueur
        '
        Me.BtnStatJoueur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatJoueur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BtnStatJoueur.Location = New System.Drawing.Point(113, 354)
        Me.BtnStatJoueur.Name = "BtnStatJoueur"
        Me.BtnStatJoueur.Size = New System.Drawing.Size(87, 33)
        Me.BtnStatJoueur.TabIndex = 5
        Me.BtnStatJoueur.Text = "Statistiques"
        Me.BtnStatJoueur.UseVisualStyleBackColor = True
        '
        'BtnOption
        '
        Me.BtnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnOption.Location = New System.Drawing.Point(12, 12)
        Me.BtnOption.Name = "BtnOption"
        Me.BtnOption.Size = New System.Drawing.Size(75, 23)
        Me.BtnOption.TabIndex = 6
        Me.BtnOption.Text = "Options"
        Me.BtnOption.UseVisualStyleBackColor = True
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 399)
        Me.Controls.Add(Me.BtnOption)
        Me.Controls.Add(Me.BtnStatJoueur)
        Me.Controls.Add(Me.BtnSeeScore)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnStartGame)
        Me.Controls.Add(Me.CmbJoueur2)
        Me.Controls.Add(Me.CmbJoueur1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormAccueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil - Mastermind Revisité"
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents CmbJoueur1 As Windows.Forms.ComboBox
    Friend WithEvents CmbJoueur2 As Windows.Forms.ComboBox
    Friend WithEvents BtnStartGame As Windows.Forms.Button
    Friend WithEvents BtnQuit As Windows.Forms.Button
    Friend WithEvents BtnSeeScore As Windows.Forms.Button
    Friend WithEvents BtnStatJoueur As Windows.Forms.Button
    Friend WithEvents BtnOption As Windows.Forms.Button
End Class
