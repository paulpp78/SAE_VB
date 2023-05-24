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
        Me.LblNom = New System.Windows.Forms.Label()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.LblMeilleurTemps = New System.Windows.Forms.Label()
        Me.LblPartiesPremierJoueur = New System.Windows.Forms.Label()
        Me.LblPartiesSecondJoueur = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstJoueurs
        '
        Me.LstJoueurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstJoueurs.FormattingEnabled = True
        Me.LstJoueurs.ItemHeight = 16
        Me.LstJoueurs.Location = New System.Drawing.Point(12, 54)
        Me.LstJoueurs.Name = "LstJoueurs"
        Me.LstJoueurs.Size = New System.Drawing.Size(343, 308)
        Me.LstJoueurs.TabIndex = 0
        '
        'BtnTriNom
        '
        Me.BtnTriNom.BackColor = System.Drawing.Color.Transparent
        Me.BtnTriNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTriNom.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnTriNom.Location = New System.Drawing.Point(12, 377)
        Me.BtnTriNom.Name = "BtnTriNom"
        Me.BtnTriNom.Size = New System.Drawing.Size(112, 27)
        Me.BtnTriNom.TabIndex = 1
        Me.BtnTriNom.Text = "TriNom"
        Me.BtnTriNom.UseVisualStyleBackColor = False
        '
        'BtnTriScore
        '
        Me.BtnTriScore.BackColor = System.Drawing.Color.Transparent
        Me.BtnTriScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTriScore.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnTriScore.Location = New System.Drawing.Point(125, 377)
        Me.BtnTriScore.Name = "BtnTriScore"
        Me.BtnTriScore.Size = New System.Drawing.Size(112, 27)
        Me.BtnTriScore.TabIndex = 2
        Me.BtnTriScore.Text = "TriScore"
        Me.BtnTriScore.UseVisualStyleBackColor = False
        '
        'BtnTriTemps
        '
        Me.BtnTriTemps.BackColor = System.Drawing.Color.Transparent
        Me.BtnTriTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTriTemps.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnTriTemps.Location = New System.Drawing.Point(243, 377)
        Me.BtnTriTemps.Name = "BtnTriTemps"
        Me.BtnTriTemps.Size = New System.Drawing.Size(112, 27)
        Me.BtnTriTemps.TabIndex = 3
        Me.BtnTriTemps.Text = "TriTemps"
        Me.BtnTriTemps.UseVisualStyleBackColor = False
        '
        'CbnRechercheJoueur
        '
        Me.CbnRechercheJoueur.FormattingEnabled = True
        Me.CbnRechercheJoueur.Location = New System.Drawing.Point(466, 126)
        Me.CbnRechercheJoueur.Name = "CbnRechercheJoueur"
        Me.CbnRechercheJoueur.Size = New System.Drawing.Size(237, 21)
        Me.CbnRechercheJoueur.TabIndex = 4
        '
        'BtnRechercherJoueur
        '
        Me.BtnRechercherJoueur.BackColor = System.Drawing.Color.Transparent
        Me.BtnRechercherJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRechercherJoueur.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnRechercherJoueur.Location = New System.Drawing.Point(709, 118)
        Me.BtnRechercherJoueur.Name = "BtnRechercherJoueur"
        Me.BtnRechercherJoueur.Size = New System.Drawing.Size(101, 32)
        Me.BtnRechercherJoueur.TabIndex = 5
        Me.BtnRechercherJoueur.Text = "Rechercher"
        Me.BtnRechercherJoueur.UseVisualStyleBackColor = False
        '
        'TxtNom
        '
        Me.TxtNom.BackColor = System.Drawing.Color.Red
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.ForeColor = System.Drawing.Color.Blue
        Me.TxtNom.Location = New System.Drawing.Point(486, 183)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(100, 24)
        Me.TxtNom.TabIndex = 6
        '
        'TxtScore
        '
        Me.TxtScore.BackColor = System.Drawing.Color.Blue
        Me.TxtScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScore.ForeColor = System.Drawing.Color.Red
        Me.TxtScore.Location = New System.Drawing.Point(486, 213)
        Me.TxtScore.Name = "TxtScore"
        Me.TxtScore.Size = New System.Drawing.Size(100, 24)
        Me.TxtScore.TabIndex = 7
        '
        'TxtMeilleurTemps
        '
        Me.TxtMeilleurTemps.BackColor = System.Drawing.Color.Red
        Me.TxtMeilleurTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMeilleurTemps.ForeColor = System.Drawing.Color.Blue
        Me.TxtMeilleurTemps.Location = New System.Drawing.Point(486, 246)
        Me.TxtMeilleurTemps.Name = "TxtMeilleurTemps"
        Me.TxtMeilleurTemps.Size = New System.Drawing.Size(100, 24)
        Me.TxtMeilleurTemps.TabIndex = 8
        '
        'TxtPartiesPremierJoueur
        '
        Me.TxtPartiesPremierJoueur.BackColor = System.Drawing.Color.Blue
        Me.TxtPartiesPremierJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPartiesPremierJoueur.ForeColor = System.Drawing.Color.Red
        Me.TxtPartiesPremierJoueur.Location = New System.Drawing.Point(486, 278)
        Me.TxtPartiesPremierJoueur.Name = "TxtPartiesPremierJoueur"
        Me.TxtPartiesPremierJoueur.Size = New System.Drawing.Size(100, 24)
        Me.TxtPartiesPremierJoueur.TabIndex = 9
        '
        'TxtPartiesSecondJoueur
        '
        Me.TxtPartiesSecondJoueur.BackColor = System.Drawing.Color.Red
        Me.TxtPartiesSecondJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPartiesSecondJoueur.ForeColor = System.Drawing.Color.Blue
        Me.TxtPartiesSecondJoueur.Location = New System.Drawing.Point(486, 308)
        Me.TxtPartiesSecondJoueur.Name = "TxtPartiesSecondJoueur"
        Me.TxtPartiesSecondJoueur.Size = New System.Drawing.Size(100, 24)
        Me.TxtPartiesSecondJoueur.TabIndex = 10
        '
        'TxtTempsTotal
        '
        Me.TxtTempsTotal.BackColor = System.Drawing.Color.Blue
        Me.TxtTempsTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTempsTotal.ForeColor = System.Drawing.Color.Red
        Me.TxtTempsTotal.Location = New System.Drawing.Point(486, 338)
        Me.TxtTempsTotal.Name = "TxtTempsTotal"
        Me.TxtTempsTotal.Size = New System.Drawing.Size(100, 24)
        Me.TxtTempsTotal.TabIndex = 11
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Gray
        Me.BtnQuit.Location = New System.Drawing.Point(721, 12)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(79, 31)
        Me.BtnQuit.TabIndex = 12
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.BackColor = System.Drawing.Color.Transparent
        Me.LblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNom.ForeColor = System.Drawing.Color.Gold
        Me.LblNom.Location = New System.Drawing.Point(592, 189)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(44, 18)
        Me.LblNom.TabIndex = 13
        Me.LblNom.Text = "Nom"
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.BackColor = System.Drawing.Color.Transparent
        Me.LblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScore.ForeColor = System.Drawing.Color.Gold
        Me.LblScore.Location = New System.Drawing.Point(592, 219)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(53, 18)
        Me.LblScore.TabIndex = 14
        Me.LblScore.Text = "Score"
        '
        'LblMeilleurTemps
        '
        Me.LblMeilleurTemps.AutoSize = True
        Me.LblMeilleurTemps.BackColor = System.Drawing.Color.Transparent
        Me.LblMeilleurTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMeilleurTemps.ForeColor = System.Drawing.Color.Gold
        Me.LblMeilleurTemps.Location = New System.Drawing.Point(592, 252)
        Me.LblMeilleurTemps.Name = "LblMeilleurTemps"
        Me.LblMeilleurTemps.Size = New System.Drawing.Size(118, 18)
        Me.LblMeilleurTemps.TabIndex = 15
        Me.LblMeilleurTemps.Text = "MeilleurTemps"
        '
        'LblPartiesPremierJoueur
        '
        Me.LblPartiesPremierJoueur.AutoSize = True
        Me.LblPartiesPremierJoueur.BackColor = System.Drawing.Color.Transparent
        Me.LblPartiesPremierJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPartiesPremierJoueur.ForeColor = System.Drawing.Color.Gold
        Me.LblPartiesPremierJoueur.Location = New System.Drawing.Point(592, 284)
        Me.LblPartiesPremierJoueur.Name = "LblPartiesPremierJoueur"
        Me.LblPartiesPremierJoueur.Size = New System.Drawing.Size(172, 18)
        Me.LblPartiesPremierJoueur.TabIndex = 16
        Me.LblPartiesPremierJoueur.Text = "PartiesPremierJoueur"
        '
        'LblPartiesSecondJoueur
        '
        Me.LblPartiesSecondJoueur.AutoSize = True
        Me.LblPartiesSecondJoueur.BackColor = System.Drawing.Color.Transparent
        Me.LblPartiesSecondJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPartiesSecondJoueur.ForeColor = System.Drawing.Color.Gold
        Me.LblPartiesSecondJoueur.Location = New System.Drawing.Point(592, 314)
        Me.LblPartiesSecondJoueur.Name = "LblPartiesSecondJoueur"
        Me.LblPartiesSecondJoueur.Size = New System.Drawing.Size(170, 18)
        Me.LblPartiesSecondJoueur.TabIndex = 17
        Me.LblPartiesSecondJoueur.Text = "PartiesSecondJoueur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(592, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "TempsTotal"
        '
        'FormStatJoueur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(812, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblPartiesSecondJoueur)
        Me.Controls.Add(Me.LblPartiesPremierJoueur)
        Me.Controls.Add(Me.LblMeilleurTemps)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.LblNom)
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
    Friend WithEvents LblNom As Windows.Forms.Label
    Friend WithEvents LblScore As Windows.Forms.Label
    Friend WithEvents LblMeilleurTemps As Windows.Forms.Label
    Friend WithEvents LblPartiesPremierJoueur As Windows.Forms.Label
    Friend WithEvents LblPartiesSecondJoueur As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
End Class
