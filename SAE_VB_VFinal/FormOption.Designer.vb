<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOption
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
        Me.LblCouleursResultat = New System.Windows.Forms.Label()
        Me.LblCaracteres = New System.Windows.Forms.Label()
        Me.LblLimiteTemps = New System.Windows.Forms.Label()
        Me.LblLimitePropositions = New System.Windows.Forms.Label()
        Me.LblCheminSauvegarde = New System.Windows.Forms.Label()
        Me.TxtCaracteres = New System.Windows.Forms.TextBox()
        Me.ChkLimiteTemps = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TxtCheminSauvegarde = New System.Windows.Forms.TextBox()
        Me.BtnCouleurAbsent = New System.Windows.Forms.Button()
        Me.BtnCouleurPresent = New System.Windows.Forms.Button()
        Me.BtnCouleurBienPlace = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCouleursResultat
        '
        Me.LblCouleursResultat.AutoSize = True
        Me.LblCouleursResultat.Location = New System.Drawing.Point(135, 249)
        Me.LblCouleursResultat.Name = "LblCouleursResultat"
        Me.LblCouleursResultat.Size = New System.Drawing.Size(100, 13)
        Me.LblCouleursResultat.TabIndex = 0
        Me.LblCouleursResultat.Text = "Couleurs du résultat"
        '
        'LblCaracteres
        '
        Me.LblCaracteres.AutoSize = True
        Me.LblCaracteres.Location = New System.Drawing.Point(36, 93)
        Me.LblCaracteres.Name = "LblCaracteres"
        Me.LblCaracteres.Size = New System.Drawing.Size(125, 26)
        Me.LblCaracteres.TabIndex = 1
        Me.LblCaracteres.Text = "Choix " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "des caractères utilisables"
        '
        'LblLimiteTemps
        '
        Me.LblLimiteTemps.AutoSize = True
        Me.LblLimiteTemps.Location = New System.Drawing.Point(309, 93)
        Me.LblLimiteTemps.Name = "LblLimiteTemps"
        Me.LblLimiteTemps.Size = New System.Drawing.Size(80, 13)
        Me.LblLimiteTemps.TabIndex = 2
        Me.LblLimiteTemps.Text = "Limite de temps"
        '
        'LblLimitePropositions
        '
        Me.LblLimitePropositions.AutoSize = True
        Me.LblLimitePropositions.Location = New System.Drawing.Point(453, 93)
        Me.LblLimitePropositions.Name = "LblLimitePropositions"
        Me.LblLimitePropositions.Size = New System.Drawing.Size(108, 13)
        Me.LblLimitePropositions.TabIndex = 3
        Me.LblLimitePropositions.Text = "Limite de propositions"
        '
        'LblCheminSauvegarde
        '
        Me.LblCheminSauvegarde.AutoSize = True
        Me.LblCheminSauvegarde.Location = New System.Drawing.Point(612, 93)
        Me.LblCheminSauvegarde.Name = "LblCheminSauvegarde"
        Me.LblCheminSauvegarde.Size = New System.Drawing.Size(116, 13)
        Me.LblCheminSauvegarde.TabIndex = 4
        Me.LblCheminSauvegarde.Text = "Chemin de sauvegarde"
        '
        'TxtCaracteres
        '
        Me.TxtCaracteres.Location = New System.Drawing.Point(39, 123)
        Me.TxtCaracteres.Name = "TxtCaracteres"
        Me.TxtCaracteres.Size = New System.Drawing.Size(103, 20)
        Me.TxtCaracteres.TabIndex = 5
        '
        'ChkLimiteTemps
        '
        Me.ChkLimiteTemps.AutoSize = True
        Me.ChkLimiteTemps.Location = New System.Drawing.Point(312, 109)
        Me.ChkLimiteTemps.Name = "ChkLimiteTemps"
        Me.ChkLimiteTemps.Size = New System.Drawing.Size(58, 17)
        Me.ChkLimiteTemps.TabIndex = 6
        Me.ChkLimiteTemps.Text = "activer"
        Me.ChkLimiteTemps.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(456, 109)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 7
        '
        'TxtCheminSauvegarde
        '
        Me.TxtCheminSauvegarde.Location = New System.Drawing.Point(615, 109)
        Me.TxtCheminSauvegarde.Name = "TxtCheminSauvegarde"
        Me.TxtCheminSauvegarde.Size = New System.Drawing.Size(113, 20)
        Me.TxtCheminSauvegarde.TabIndex = 8
        '
        'BtnCouleurAbsent
        '
        Me.BtnCouleurAbsent.Location = New System.Drawing.Point(66, 274)
        Me.BtnCouleurAbsent.Name = "BtnCouleurAbsent"
        Me.BtnCouleurAbsent.Size = New System.Drawing.Size(75, 24)
        Me.BtnCouleurAbsent.TabIndex = 9
        Me.BtnCouleurAbsent.Text = "Absent"
        Me.BtnCouleurAbsent.UseVisualStyleBackColor = True
        '
        'BtnCouleurPresent
        '
        Me.BtnCouleurPresent.Location = New System.Drawing.Point(147, 274)
        Me.BtnCouleurPresent.Name = "BtnCouleurPresent"
        Me.BtnCouleurPresent.Size = New System.Drawing.Size(75, 24)
        Me.BtnCouleurPresent.TabIndex = 10
        Me.BtnCouleurPresent.Text = "Present"
        Me.BtnCouleurPresent.UseVisualStyleBackColor = True
        '
        'BtnCouleurBienPlace
        '
        Me.BtnCouleurBienPlace.Location = New System.Drawing.Point(228, 274)
        Me.BtnCouleurBienPlace.Name = "BtnCouleurBienPlace"
        Me.BtnCouleurBienPlace.Size = New System.Drawing.Size(75, 24)
        Me.BtnCouleurBienPlace.TabIndex = 11
        Me.BtnCouleurBienPlace.Text = "Bien Place"
        Me.BtnCouleurBienPlace.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(595, 302)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FormOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCouleurBienPlace)
        Me.Controls.Add(Me.BtnCouleurPresent)
        Me.Controls.Add(Me.BtnCouleurAbsent)
        Me.Controls.Add(Me.TxtCheminSauvegarde)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ChkLimiteTemps)
        Me.Controls.Add(Me.TxtCaracteres)
        Me.Controls.Add(Me.LblCheminSauvegarde)
        Me.Controls.Add(Me.LblLimitePropositions)
        Me.Controls.Add(Me.LblLimiteTemps)
        Me.Controls.Add(Me.LblCaracteres)
        Me.Controls.Add(Me.LblCouleursResultat)
        Me.Name = "FormOption"
        Me.Text = "FormOption"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCouleursResultat As Windows.Forms.Label
    Friend WithEvents LblCaracteres As Windows.Forms.Label
    Friend WithEvents LblLimiteTemps As Windows.Forms.Label
    Friend WithEvents LblLimitePropositions As Windows.Forms.Label
    Friend WithEvents LblCheminSauvegarde As Windows.Forms.Label
    Friend WithEvents TxtCaracteres As Windows.Forms.TextBox
    Friend WithEvents ChkLimiteTemps As Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown1 As Windows.Forms.NumericUpDown
    Friend WithEvents TxtCheminSauvegarde As Windows.Forms.TextBox
    Friend WithEvents BtnCouleurAbsent As Windows.Forms.Button
    Friend WithEvents BtnCouleurPresent As Windows.Forms.Button
    Friend WithEvents BtnCouleurBienPlace As Windows.Forms.Button
    Friend WithEvents BtnSave As Windows.Forms.Button
End Class
