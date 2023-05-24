<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatJoueur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LstJoueurs = New System.Windows.Forms.ListBox()
        Me.BtnTriNom = New System.Windows.Forms.Button()
        Me.BtnTriScore = New System.Windows.Forms.Button()
        Me.BtnTriTemps = New System.Windows.Forms.Button()
        Me.CbnRechercheJoueur = New System.Windows.Forms.ComboBox()
        Me.BtnRechercherJoueur = New System.Windows.Forms.Button()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.TxtScore = New System.Windows.Forms.TextBox()
        Me.TxtMeilleurTemps = New System.Windows.Forms.TextBox()
        Me.TxtPartiesPremierJoueur = New System.Windows.Forms.TextBox()
        Me.TxtPartiesSecondJoueur = New System.Windows.Forms.TextBox()
        Me.TxtTempsTotal = New System.Windows.Forms.TextBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstJoueurs
        '
        Me.LstJoueurs.FormattingEnabled = True
        Me.LstJoueurs.Location = New System.Drawing.Point(130, 52)
        Me.LstJoueurs.Name = "LstJoueurs"
        Me.LstJoueurs.Size = New System.Drawing.Size(237, 95)
        Me.LstJoueurs.TabIndex = 0
        '
        'BtnTriNom
        '
        Me.BtnTriNom.Location = New System.Drawing.Point(130, 153)
        Me.BtnTriNom.Name = "BtnTriNom"
        Me.BtnTriNom.Size = New System.Drawing.Size(75, 23)
        Me.BtnTriNom.TabIndex = 1
        Me.BtnTriNom.Text = "TriNom"
        Me.BtnTriNom.UseVisualStyleBackColor = True
        '
        'BtnTriScore
        '
        Me.BtnTriScore.Location = New System.Drawing.Point(211, 153)
        Me.BtnTriScore.Name = "BtnTriScore"
        Me.BtnTriScore.Size = New System.Drawing.Size(75, 23)
        Me.BtnTriScore.TabIndex = 2
        Me.BtnTriScore.Text = "TriScore"
        Me.BtnTriScore.UseVisualStyleBackColor = True
        '
        'BtnTriTemps
        '
        Me.BtnTriTemps.Location = New System.Drawing.Point(292, 153)
        Me.BtnTriTemps.Name = "BtnTriTemps"
        Me.BtnTriTemps.Size = New System.Drawing.Size(75, 23)
        Me.BtnTriTemps.TabIndex = 3
        Me.BtnTriTemps.Text = "TriTemps"
        Me.BtnTriTemps.UseVisualStyleBackColor = True
        '
        'CbnRechercheJoueur
        '
        Me.CbnRechercheJoueur.FormattingEnabled = True
        Me.CbnRechercheJoueur.Location = New System.Drawing.Point(130, 182)
        Me.CbnRechercheJoueur.Name = "CbnRechercheJoueur"
        Me.CbnRechercheJoueur.Size = New System.Drawing.Size(237, 21)
        Me.CbnRechercheJoueur.TabIndex = 4
        '
        'BtnRechercherJoueur
        '
        Me.BtnRechercherJoueur.Location = New System.Drawing.Point(211, 209)
        Me.BtnRechercherJoueur.Name = "BtnRechercherJoueur"
        Me.BtnRechercherJoueur.Size = New System.Drawing.Size(75, 23)
        Me.BtnRechercherJoueur.TabIndex = 5
        Me.BtnRechercherJoueur.Text = "Rechercher"
        Me.BtnRechercherJoueur.UseVisualStyleBackColor = True
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(549, 96)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(100, 20)
        Me.TxtNom.TabIndex = 6
        '
        'TxtScore
        '
        Me.TxtScore.Location = New System.Drawing.Point(556, 143)
        Me.TxtScore.Name = "TxtScore"
        Me.TxtScore.Size = New System.Drawing.Size(100, 20)
        Me.TxtScore.TabIndex = 7
        '
        'TxtMeilleurTemps
        '
        Me.TxtMeilleurTemps.Location = New System.Drawing.Point(567, 199)
        Me.TxtMeilleurTemps.Name = "TxtMeilleurTemps"
        Me.TxtMeilleurTemps.Size = New System.Drawing.Size(100, 20)
        Me.TxtMeilleurTemps.TabIndex = 8
        '
        'TxtPartiesPremierJoueur
        '
        Me.TxtPartiesPremierJoueur.Location = New System.Drawing.Point(570, 239)
        Me.TxtPartiesPremierJoueur.Name = "TxtPartiesPremierJoueur"
        Me.TxtPartiesPremierJoueur.Size = New System.Drawing.Size(100, 20)
        Me.TxtPartiesPremierJoueur.TabIndex = 9
        '
        'TxtPartiesSecondJoueur
        '
        Me.TxtPartiesSecondJoueur.Location = New System.Drawing.Point(573, 278)
        Me.TxtPartiesSecondJoueur.Name = "TxtPartiesSecondJoueur"
        Me.TxtPartiesSecondJoueur.Size = New System.Drawing.Size(100, 20)
        Me.TxtPartiesSecondJoueur.TabIndex = 10
        '
        'TxtTempsTotal
        '
        Me.TxtTempsTotal.Location = New System.Drawing.Point(580, 325)
        Me.TxtTempsTotal.Name = "TxtTempsTotal"
        Me.TxtTempsTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTempsTotal.TabIndex = 11
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Gray
        Me.BtnQuit.Location = New System.Drawing.Point(577, 12)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(79, 31)
        Me.BtnQuit.TabIndex = 12
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'FormStatJoueur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.TxtTempsTotal)
        Me.Controls.Add(Me.TxtPartiesSecondJoueur)
        Me.Controls.Add(Me.TxtPartiesPremierJoueur)
        Me.Controls.Add(Me.TxtMeilleurTemps)
        Me.Controls.Add(Me.TxtScore)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.BtnRechercherJoueur)
        Me.Controls.Add(Me.CbnRechercheJoueur)
        Me.Controls.Add(Me.BtnTriTemps)
        Me.Controls.Add(Me.BtnTriScore)
        Me.Controls.Add(Me.BtnTriNom)
        Me.Controls.Add(Me.LstJoueurs)
        Me.Name = "FormStatJoueur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstJoueurs As Windows.Forms.ListBox
    Friend WithEvents BtnTriNom As Windows.Forms.Button
    Friend WithEvents BtnTriScore As Windows.Forms.Button
    Friend WithEvents BtnTriTemps As Windows.Forms.Button
    Friend WithEvents CbnRechercheJoueur As Windows.Forms.ComboBox
    Friend WithEvents BtnRechercherJoueur As Windows.Forms.Button
    Friend WithEvents TxtNom As Windows.Forms.TextBox
    Friend WithEvents TxtScore As Windows.Forms.TextBox
    Friend WithEvents TxtMeilleurTemps As Windows.Forms.TextBox
    Friend WithEvents TxtPartiesPremierJoueur As Windows.Forms.TextBox
    Friend WithEvents TxtPartiesSecondJoueur As Windows.Forms.TextBox
    Friend WithEvents TxtTempsTotal As Windows.Forms.TextBox
    Friend WithEvents BtnQuit As Windows.Forms.Button
End Class
