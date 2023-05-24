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

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CmbJoueur1 = New System.Windows.Forms.ComboBox()
        Me.CmbJoueur2 = New System.Windows.Forms.ComboBox()
        Me.BtnStartGame = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbJoueur1
        '
        Me.CmbJoueur1.BackColor = System.Drawing.Color.Blue
        Me.CmbJoueur1.ForeColor = System.Drawing.Color.Transparent
        Me.CmbJoueur1.FormattingEnabled = True
        Me.CmbJoueur1.Location = New System.Drawing.Point(12, 166)
        Me.CmbJoueur1.Name = "CmbJoueur1"
        Me.CmbJoueur1.Size = New System.Drawing.Size(156, 21)
        Me.CmbJoueur1.TabIndex = 0
        Me.CmbJoueur1.Text = "Nom du joueur 1"
        '
        'CmbJoueur2
        '
        Me.CmbJoueur2.BackColor = System.Drawing.Color.Red
        Me.CmbJoueur2.ForeColor = System.Drawing.Color.Transparent
        Me.CmbJoueur2.FormattingEnabled = True
        Me.CmbJoueur2.Location = New System.Drawing.Point(174, 166)
        Me.CmbJoueur2.Name = "CmbJoueur2"
        Me.CmbJoueur2.Size = New System.Drawing.Size(156, 21)
        Me.CmbJoueur2.TabIndex = 1
        Me.CmbJoueur2.Text = "Nom du joueur 2"
        '
        'BtnStartGame
        '
        Me.BtnStartGame.BackColor = System.Drawing.Color.Gold
        Me.BtnStartGame.ForeColor = System.Drawing.Color.Black
        Me.BtnStartGame.Location = New System.Drawing.Point(12, 202)
        Me.BtnStartGame.Name = "BtnStartGame"
        Me.BtnStartGame.Size = New System.Drawing.Size(318, 36)
        Me.BtnStartGame.TabIndex = 2
        Me.BtnStartGame.Text = "Start"
        Me.BtnStartGame.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Gray
        Me.BtnQuit.Location = New System.Drawing.Point(251, 12)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(79, 31)
        Me.BtnQuit.TabIndex = 3
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(345, 288)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnStartGame)
        Me.Controls.Add(Me.CmbJoueur2)
        Me.Controls.Add(Me.CmbJoueur1)
        Me.Name = "FormAccueil"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmbJoueur1 As Windows.Forms.ComboBox
    Friend WithEvents CmbJoueur2 As Windows.Forms.ComboBox
    Friend WithEvents BtnStartGame As Windows.Forms.Button
    Friend WithEvents BtnQuit As Windows.Forms.Button
End Class