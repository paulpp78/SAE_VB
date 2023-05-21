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
        'FormStatJoueur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnRechercherJoueur)
        Me.Controls.Add(Me.CbnRechercheJoueur)
        Me.Controls.Add(Me.BtnTriTemps)
        Me.Controls.Add(Me.BtnTriScore)
        Me.Controls.Add(Me.BtnTriNom)
        Me.Controls.Add(Me.LstJoueurs)
        Me.Name = "FormStatJoueur"
        Me.Text = "FormStatJoueur"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstJoueurs As Windows.Forms.ListBox
    Friend WithEvents BtnTriNom As Windows.Forms.Button
    Friend WithEvents BtnTriScore As Windows.Forms.Button
    Friend WithEvents BtnTriTemps As Windows.Forms.Button
    Friend WithEvents CbnRechercheJoueur As Windows.Forms.ComboBox
    Friend WithEvents BtnRechercherJoueur As Windows.Forms.Button
End Class
