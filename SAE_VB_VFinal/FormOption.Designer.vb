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
        Me.NumUpDownNbProposition = New System.Windows.Forms.NumericUpDown()
        Me.BtnCouleurAbsent = New System.Windows.Forms.Button()
        Me.BtnCouleurPresent = New System.Windows.Forms.Button()
        Me.BtnCouleurBienPlace = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.RdBtnTmp = New System.Windows.Forms.RadioButton()
        Me.TrckBarTemps = New System.Windows.Forms.TrackBar()
        Me.TextBoxValeurScrollBar = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnSelectFile = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.TxtSelectedFile = New System.Windows.Forms.TextBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        CType(Me.NumUpDownNbProposition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrckBarTemps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCouleursResultat
        '
        Me.LblCouleursResultat.AutoSize = True
        Me.LblCouleursResultat.BackColor = System.Drawing.Color.Red
        Me.LblCouleursResultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCouleursResultat.ForeColor = System.Drawing.Color.Transparent
        Me.LblCouleursResultat.Location = New System.Drawing.Point(48, 285)
        Me.LblCouleursResultat.Name = "LblCouleursResultat"
        Me.LblCouleursResultat.Size = New System.Drawing.Size(171, 20)
        Me.LblCouleursResultat.TabIndex = 0
        Me.LblCouleursResultat.Text = "Couleurs du résultat"
        '
        'LblCaracteres
        '
        Me.LblCaracteres.AutoSize = True
        Me.LblCaracteres.BackColor = System.Drawing.Color.Blue
        Me.LblCaracteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaracteres.ForeColor = System.Drawing.Color.Transparent
        Me.LblCaracteres.Location = New System.Drawing.Point(35, 80)
        Me.LblCaracteres.Name = "LblCaracteres"
        Me.LblCaracteres.Size = New System.Drawing.Size(213, 40)
        Me.LblCaracteres.TabIndex = 1
        Me.LblCaracteres.Text = "Choix " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "des caractères utilisables"
        '
        'LblLimiteTemps
        '
        Me.LblLimiteTemps.AutoSize = True
        Me.LblLimiteTemps.BackColor = System.Drawing.Color.Gold
        Me.LblLimiteTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLimiteTemps.ForeColor = System.Drawing.Color.Transparent
        Me.LblLimiteTemps.Location = New System.Drawing.Point(364, 147)
        Me.LblLimiteTemps.Name = "LblLimiteTemps"
        Me.LblLimiteTemps.Size = New System.Drawing.Size(136, 20)
        Me.LblLimiteTemps.TabIndex = 2
        Me.LblLimiteTemps.Text = "Limite de temps"
        '
        'LblLimitePropositions
        '
        Me.LblLimitePropositions.AutoSize = True
        Me.LblLimitePropositions.BackColor = System.Drawing.Color.Red
        Me.LblLimitePropositions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLimitePropositions.ForeColor = System.Drawing.Color.Transparent
        Me.LblLimitePropositions.Location = New System.Drawing.Point(594, 123)
        Me.LblLimitePropositions.Name = "LblLimitePropositions"
        Me.LblLimitePropositions.Size = New System.Drawing.Size(185, 20)
        Me.LblLimitePropositions.TabIndex = 3
        Me.LblLimitePropositions.Text = "Limite de propositions"
        '
        'LblCheminSauvegarde
        '
        Me.LblCheminSauvegarde.AutoSize = True
        Me.LblCheminSauvegarde.BackColor = System.Drawing.Color.Blue
        Me.LblCheminSauvegarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCheminSauvegarde.ForeColor = System.Drawing.Color.Transparent
        Me.LblCheminSauvegarde.Location = New System.Drawing.Point(594, 285)
        Me.LblCheminSauvegarde.Name = "LblCheminSauvegarde"
        Me.LblCheminSauvegarde.Size = New System.Drawing.Size(192, 20)
        Me.LblCheminSauvegarde.TabIndex = 4
        Me.LblCheminSauvegarde.Text = "Chemin de sauvegarde"
        '
        'TxtCaracteres
        '
        Me.TxtCaracteres.BackColor = System.Drawing.Color.Blue
        Me.TxtCaracteres.ForeColor = System.Drawing.Color.Transparent
        Me.TxtCaracteres.Location = New System.Drawing.Point(39, 125)
        Me.TxtCaracteres.Name = "TxtCaracteres"
        Me.TxtCaracteres.Size = New System.Drawing.Size(206, 20)
        Me.TxtCaracteres.TabIndex = 5
        '
        'NumUpDownNbProposition
        '
        Me.NumUpDownNbProposition.BackColor = System.Drawing.Color.Red
        Me.NumUpDownNbProposition.ForeColor = System.Drawing.Color.Transparent
        Me.NumUpDownNbProposition.Location = New System.Drawing.Point(597, 147)
        Me.NumUpDownNbProposition.Name = "NumUpDownNbProposition"
        Me.NumUpDownNbProposition.Size = New System.Drawing.Size(182, 20)
        Me.NumUpDownNbProposition.TabIndex = 7
        '
        'BtnCouleurAbsent
        '
        Me.BtnCouleurAbsent.BackColor = System.Drawing.Color.Red
        Me.BtnCouleurAbsent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCouleurAbsent.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCouleurAbsent.Location = New System.Drawing.Point(4, 309)
        Me.BtnCouleurAbsent.Name = "BtnCouleurAbsent"
        Me.BtnCouleurAbsent.Size = New System.Drawing.Size(75, 27)
        Me.BtnCouleurAbsent.TabIndex = 9
        Me.BtnCouleurAbsent.Text = "Absent"
        Me.BtnCouleurAbsent.UseVisualStyleBackColor = False
        '
        'BtnCouleurPresent
        '
        Me.BtnCouleurPresent.BackColor = System.Drawing.Color.Red
        Me.BtnCouleurPresent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCouleurPresent.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCouleurPresent.Location = New System.Drawing.Point(85, 309)
        Me.BtnCouleurPresent.Name = "BtnCouleurPresent"
        Me.BtnCouleurPresent.Size = New System.Drawing.Size(79, 25)
        Me.BtnCouleurPresent.TabIndex = 10
        Me.BtnCouleurPresent.Text = "Present"
        Me.BtnCouleurPresent.UseVisualStyleBackColor = False
        '
        'BtnCouleurBienPlace
        '
        Me.BtnCouleurBienPlace.BackColor = System.Drawing.Color.Red
        Me.BtnCouleurBienPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCouleurBienPlace.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCouleurBienPlace.Location = New System.Drawing.Point(170, 310)
        Me.BtnCouleurBienPlace.Name = "BtnCouleurBienPlace"
        Me.BtnCouleurBienPlace.Size = New System.Drawing.Size(78, 26)
        Me.BtnCouleurBienPlace.TabIndex = 11
        Me.BtnCouleurBienPlace.Text = "Bien Place"
        Me.BtnCouleurBienPlace.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.DimGray
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSave.Location = New System.Drawing.Point(368, 339)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(118, 35)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'RdBtnTmp
        '
        Me.RdBtnTmp.AutoSize = True
        Me.RdBtnTmp.BackColor = System.Drawing.Color.Gold
        Me.RdBtnTmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdBtnTmp.ForeColor = System.Drawing.Color.Transparent
        Me.RdBtnTmp.Location = New System.Drawing.Point(368, 178)
        Me.RdBtnTmp.Name = "RdBtnTmp"
        Me.RdBtnTmp.Size = New System.Drawing.Size(76, 24)
        Me.RdBtnTmp.TabIndex = 13
        Me.RdBtnTmp.TabStop = True
        Me.RdBtnTmp.Text = "Active"
        Me.RdBtnTmp.UseVisualStyleBackColor = False
        '
        'TrckBarTemps
        '
        Me.TrckBarTemps.BackColor = System.Drawing.Color.Gold
        Me.TrckBarTemps.Location = New System.Drawing.Point(329, 208)
        Me.TrckBarTemps.Name = "TrckBarTemps"
        Me.TrckBarTemps.Size = New System.Drawing.Size(209, 45)
        Me.TrckBarTemps.TabIndex = 14
        '
        'TextBoxValeurScrollBar
        '
        Me.TextBoxValeurScrollBar.BackColor = System.Drawing.Color.Gold
        Me.TextBoxValeurScrollBar.Location = New System.Drawing.Point(329, 242)
        Me.TextBoxValeurScrollBar.Name = "TextBoxValeurScrollBar"
        Me.TextBoxValeurScrollBar.Size = New System.Drawing.Size(209, 20)
        Me.TextBoxValeurScrollBar.TabIndex = 16
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnSelectFile
        '
        Me.BtnSelectFile.BackColor = System.Drawing.Color.Blue
        Me.BtnSelectFile.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSelectFile.Location = New System.Drawing.Point(597, 313)
        Me.BtnSelectFile.Name = "BtnSelectFile"
        Me.BtnSelectFile.Size = New System.Drawing.Size(189, 23)
        Me.BtnSelectFile.TabIndex = 17
        Me.BtnSelectFile.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Gray
        Me.BtnQuit.Location = New System.Drawing.Point(14, 12)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(79, 31)
        Me.BtnQuit.TabIndex = 18
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'TxtSelectedFile
        '
        Me.TxtSelectedFile.BackColor = System.Drawing.SystemColors.Control
        Me.TxtSelectedFile.ForeColor = System.Drawing.Color.Black
        Me.TxtSelectedFile.Location = New System.Drawing.Point(597, 342)
        Me.TxtSelectedFile.Name = "TxtSelectedFile"
        Me.TxtSelectedFile.Size = New System.Drawing.Size(189, 20)
        Me.TxtSelectedFile.TabIndex = 19
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(13, 393)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(824, 17)
        Me.HScrollBar1.TabIndex = 20
        '
        'FormOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(864, 450)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.TxtSelectedFile)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnSelectFile)
        Me.Controls.Add(Me.TextBoxValeurScrollBar)
        Me.Controls.Add(Me.TrckBarTemps)
        Me.Controls.Add(Me.RdBtnTmp)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCouleurBienPlace)
        Me.Controls.Add(Me.BtnCouleurPresent)
        Me.Controls.Add(Me.BtnCouleurAbsent)
        Me.Controls.Add(Me.NumUpDownNbProposition)
        Me.Controls.Add(Me.TxtCaracteres)
        Me.Controls.Add(Me.LblCheminSauvegarde)
        Me.Controls.Add(Me.LblLimitePropositions)
        Me.Controls.Add(Me.LblLimiteTemps)
        Me.Controls.Add(Me.LblCaracteres)
        Me.Controls.Add(Me.LblCouleursResultat)
        Me.Name = "FormOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Option"
        CType(Me.NumUpDownNbProposition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrckBarTemps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCouleursResultat As Windows.Forms.Label
    Friend WithEvents LblCaracteres As Windows.Forms.Label
    Friend WithEvents LblLimiteTemps As Windows.Forms.Label
    Friend WithEvents LblLimitePropositions As Windows.Forms.Label
    Friend WithEvents LblCheminSauvegarde As Windows.Forms.Label
    Friend WithEvents TxtCaracteres As Windows.Forms.TextBox
    Friend WithEvents NumUpDownNbProposition As Windows.Forms.NumericUpDown
    Friend WithEvents BtnCouleurAbsent As Windows.Forms.Button
    Friend WithEvents BtnCouleurPresent As Windows.Forms.Button
    Friend WithEvents BtnCouleurBienPlace As Windows.Forms.Button
    Friend WithEvents BtnSave As Windows.Forms.Button
    Friend WithEvents RdBtnTmp As Windows.Forms.RadioButton
    Friend WithEvents TrckBarTemps As Windows.Forms.TrackBar
    Friend WithEvents TextBoxValeurScrollBar As Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents BtnSelectFile As Windows.Forms.Button
    Friend WithEvents BtnQuit As Windows.Forms.Button
    Friend WithEvents TxtSelectedFile As Windows.Forms.TextBox
    Friend WithEvents HScrollBar1 As Windows.Forms.HScrollBar
End Class
