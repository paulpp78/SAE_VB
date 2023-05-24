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
        Me.BtnNouvellePartie = New System.Windows.Forms.Button()
        Me.BtnContinuerSansRejouer = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblResultat
        '
        Me.LblResultat.AutoSize = True
        Me.LblResultat.BackColor = System.Drawing.Color.Transparent
        Me.LblResultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResultat.ForeColor = System.Drawing.Color.Transparent
        Me.LblResultat.Location = New System.Drawing.Point(180, 50)
        Me.LblResultat.Name = "LblResultat"
        Me.LblResultat.Size = New System.Drawing.Size(77, 20)
        Me.LblResultat.TabIndex = 0
        Me.LblResultat.Text = "Resultat"
        '
        'BtnNouvellePartie
        '
        Me.BtnNouvellePartie.BackColor = System.Drawing.Color.Red
        Me.BtnNouvellePartie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNouvellePartie.ForeColor = System.Drawing.Color.Gold
        Me.BtnNouvellePartie.Location = New System.Drawing.Point(12, 126)
        Me.BtnNouvellePartie.Name = "BtnNouvellePartie"
        Me.BtnNouvellePartie.Size = New System.Drawing.Size(166, 61)
        Me.BtnNouvellePartie.TabIndex = 3
        Me.BtnNouvellePartie.Text = "Nouvelle Partie ?"
        Me.BtnNouvellePartie.UseVisualStyleBackColor = False
        '
        'BtnContinuerSansRejouer
        '
        Me.BtnContinuerSansRejouer.BackColor = System.Drawing.Color.Blue
        Me.BtnContinuerSansRejouer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContinuerSansRejouer.ForeColor = System.Drawing.Color.Gold
        Me.BtnContinuerSansRejouer.Location = New System.Drawing.Point(271, 126)
        Me.BtnContinuerSansRejouer.Name = "BtnContinuerSansRejouer"
        Me.BtnContinuerSansRejouer.Size = New System.Drawing.Size(166, 61)
        Me.BtnContinuerSansRejouer.TabIndex = 5
        Me.BtnContinuerSansRejouer.Text = "Continuer sans rejouer"
        Me.BtnContinuerSansRejouer.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Gray
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuit.Location = New System.Drawing.Point(382, 12)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(55, 40)
        Me.BtnQuit.TabIndex = 6
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'FormPartieTerminee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(449, 199)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnContinuerSansRejouer)
        Me.Controls.Add(Me.BtnNouvellePartie)
        Me.Controls.Add(Me.LblResultat)
        Me.Name = "FormPartieTerminee"
        Me.Text = "FormPartieTerminee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblResultat As Windows.Forms.Label
    Friend WithEvents BtnNouvellePartie As Windows.Forms.Button
    Friend WithEvents BtnContinuerSansRejouer As Windows.Forms.Button
    Friend WithEvents BtnQuit As Windows.Forms.Button
End Class
