<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPartieTerminee
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
        Me.LblResultat = New System.Windows.Forms.Label()
        Me.LblJoueurQuiPropose = New System.Windows.Forms.Label()
        Me.LblJoueurQuiJoue = New System.Windows.Forms.Label()
        Me.BtnNouvellePartie = New System.Windows.Forms.Button()
        Me.BtnQuitterlejeu = New System.Windows.Forms.Button()
        Me.BtnContinuerSansRejouer = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblResultat
        '
        Me.LblResultat.AutoSize = True
        Me.LblResultat.Location = New System.Drawing.Point(191, 143)
        Me.LblResultat.Name = "LblResultat"
        Me.LblResultat.Size = New System.Drawing.Size(46, 13)
        Me.LblResultat.TabIndex = 0
        Me.LblResultat.Text = "Resultat"
        '
        'LblJoueurQuiPropose
        '
        Me.LblJoueurQuiPropose.AutoSize = True
        Me.LblJoueurQuiPropose.Location = New System.Drawing.Point(306, 143)
        Me.LblJoueurQuiPropose.Name = "LblJoueurQuiPropose"
        Me.LblJoueurQuiPropose.Size = New System.Drawing.Size(39, 13)
        Me.LblJoueurQuiPropose.TabIndex = 1
        Me.LblJoueurQuiPropose.Text = "Label2"
        '
        'LblJoueurQuiJoue
        '
        Me.LblJoueurQuiJoue.AutoSize = True
        Me.LblJoueurQuiJoue.Location = New System.Drawing.Point(569, 143)
        Me.LblJoueurQuiJoue.Name = "LblJoueurQuiJoue"
        Me.LblJoueurQuiJoue.Size = New System.Drawing.Size(39, 13)
        Me.LblJoueurQuiJoue.TabIndex = 2
        Me.LblJoueurQuiJoue.Text = "Label3"
        '
        'BtnNouvellePartie
        '
        Me.BtnNouvellePartie.Location = New System.Drawing.Point(85, 249)
        Me.BtnNouvellePartie.Name = "BtnNouvellePartie"
        Me.BtnNouvellePartie.Size = New System.Drawing.Size(166, 23)
        Me.BtnNouvellePartie.TabIndex = 3
        Me.BtnNouvellePartie.Text = "Nouvelle Partie ?"
        Me.BtnNouvellePartie.UseVisualStyleBackColor = True
        '
        'BtnQuitterlejeu
        '
        Me.BtnQuitterlejeu.Location = New System.Drawing.Point(687, 49)
        Me.BtnQuitterlejeu.Name = "BtnQuitterlejeu"
        Me.BtnQuitterlejeu.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuitterlejeu.TabIndex = 4
        Me.BtnQuitterlejeu.Text = "Quitter ?"
        Me.BtnQuitterlejeu.UseVisualStyleBackColor = True
        '
        'BtnContinuerSansRejouer
        '
        Me.BtnContinuerSansRejouer.Location = New System.Drawing.Point(559, 249)
        Me.BtnContinuerSansRejouer.Name = "BtnContinuerSansRejouer"
        Me.BtnContinuerSansRejouer.Size = New System.Drawing.Size(129, 23)
        Me.BtnContinuerSansRejouer.TabIndex = 5
        Me.BtnContinuerSansRejouer.Text = "Continuer sans rejouer"
        Me.BtnContinuerSansRejouer.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Gray
        Me.BtnQuit.Location = New System.Drawing.Point(599, 12)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(79, 31)
        Me.BtnQuit.TabIndex = 6
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'FormPartieTerminee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnContinuerSansRejouer)
        Me.Controls.Add(Me.BtnQuitterlejeu)
        Me.Controls.Add(Me.BtnNouvellePartie)
        Me.Controls.Add(Me.LblJoueurQuiJoue)
        Me.Controls.Add(Me.LblJoueurQuiPropose)
        Me.Controls.Add(Me.LblResultat)
        Me.Name = "FormPartieTerminee"
        Me.Text = "FormPartieTerminee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblResultat As Windows.Forms.Label
    Friend WithEvents LblJoueurQuiPropose As Windows.Forms.Label
    Friend WithEvents LblJoueurQuiJoue As Windows.Forms.Label
    Friend WithEvents BtnNouvellePartie As Windows.Forms.Button
    Friend WithEvents BtnQuitterlejeu As Windows.Forms.Button
    Friend WithEvents BtnContinuerSansRejouer As Windows.Forms.Button
    Friend WithEvents BtnQuit As Windows.Forms.Button
End Class
