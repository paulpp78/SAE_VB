<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChoix_Partie
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
        Me.BtnEasy = New System.Windows.Forms.Button()
        Me.BtnModerate = New System.Windows.Forms.Button()
        Me.BtnHard = New System.Windows.Forms.Button()
        Me.BtnFree = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.ScrollbarChoixPartie = New System.Windows.Forms.VScrollBar()
        Me.LblEasy = New System.Windows.Forms.Label()
        Me.LblModerate = New System.Windows.Forms.Label()
        Me.LblHard = New System.Windows.Forms.Label()
        Me.LblFree = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEasy
        '
        Me.BtnEasy.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEasy.ForeColor = System.Drawing.Color.Black
        Me.BtnEasy.Location = New System.Drawing.Point(82, 12)
        Me.BtnEasy.Name = "BtnEasy"
        Me.BtnEasy.Size = New System.Drawing.Size(144, 66)
        Me.BtnEasy.TabIndex = 0
        Me.BtnEasy.Text = "Easy"
        Me.BtnEasy.UseVisualStyleBackColor = False
        '
        'BtnModerate
        '
        Me.BtnModerate.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnModerate.ForeColor = System.Drawing.Color.Black
        Me.BtnModerate.Location = New System.Drawing.Point(82, 93)
        Me.BtnModerate.Name = "BtnModerate"
        Me.BtnModerate.Size = New System.Drawing.Size(144, 66)
        Me.BtnModerate.TabIndex = 1
        Me.BtnModerate.Text = "Moderate"
        Me.BtnModerate.UseVisualStyleBackColor = False
        '
        'BtnHard
        '
        Me.BtnHard.BackColor = System.Drawing.Color.Brown
        Me.BtnHard.ForeColor = System.Drawing.Color.Black
        Me.BtnHard.Location = New System.Drawing.Point(82, 174)
        Me.BtnHard.Name = "BtnHard"
        Me.BtnHard.Size = New System.Drawing.Size(144, 66)
        Me.BtnHard.TabIndex = 2
        Me.BtnHard.Text = "Hard"
        Me.BtnHard.UseVisualStyleBackColor = False
        '
        'BtnFree
        '
        Me.BtnFree.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFree.ForeColor = System.Drawing.Color.Black
        Me.BtnFree.Location = New System.Drawing.Point(82, 255)
        Me.BtnFree.Name = "BtnFree"
        Me.BtnFree.Size = New System.Drawing.Size(144, 66)
        Me.BtnFree.TabIndex = 3
        Me.BtnFree.Text = "Free"
        Me.BtnFree.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnBack.Location = New System.Drawing.Point(82, 336)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(144, 66)
        Me.BtnBack.TabIndex = 4
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'ScrollbarChoixPartie
        '
        Me.ScrollbarChoixPartie.Location = New System.Drawing.Point(360, 12)
        Me.ScrollbarChoixPartie.Name = "ScrollbarChoixPartie"
        Me.ScrollbarChoixPartie.Size = New System.Drawing.Size(10, 390)
        Me.ScrollbarChoixPartie.TabIndex = 5
        '
        'LblEasy
        '
        Me.LblEasy.AutoSize = True
        Me.LblEasy.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblEasy.Location = New System.Drawing.Point(232, 39)
        Me.LblEasy.Name = "LblEasy"
        Me.LblEasy.Size = New System.Drawing.Size(39, 13)
        Me.LblEasy.TabIndex = 6
        Me.LblEasy.Text = "Label1"
        '
        'LblModerate
        '
        Me.LblModerate.AutoSize = True
        Me.LblModerate.BackColor = System.Drawing.Color.RosyBrown
        Me.LblModerate.Location = New System.Drawing.Point(232, 120)
        Me.LblModerate.Name = "LblModerate"
        Me.LblModerate.Size = New System.Drawing.Size(39, 13)
        Me.LblModerate.TabIndex = 7
        Me.LblModerate.Text = "Label2"
        '
        'LblHard
        '
        Me.LblHard.AutoSize = True
        Me.LblHard.BackColor = System.Drawing.Color.Brown
        Me.LblHard.Location = New System.Drawing.Point(232, 201)
        Me.LblHard.Name = "LblHard"
        Me.LblHard.Size = New System.Drawing.Size(39, 13)
        Me.LblHard.TabIndex = 8
        Me.LblHard.Text = "Label3"
        '
        'LblFree
        '
        Me.LblFree.AutoSize = True
        Me.LblFree.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblFree.Location = New System.Drawing.Point(233, 286)
        Me.LblFree.Name = "LblFree"
        Me.LblFree.Size = New System.Drawing.Size(39, 13)
        Me.LblFree.TabIndex = 10
        Me.LblFree.Text = "Label4"
        '
        'FormChoix_Partie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(385, 358)
        Me.Controls.Add(Me.LblFree)
        Me.Controls.Add(Me.LblHard)
        Me.Controls.Add(Me.LblModerate)
        Me.Controls.Add(Me.LblEasy)
        Me.Controls.Add(Me.ScrollbarChoixPartie)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnFree)
        Me.Controls.Add(Me.BtnHard)
        Me.Controls.Add(Me.BtnModerate)
        Me.Controls.Add(Me.BtnEasy)
        Me.Name = "FormChoix_Partie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choice mode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEasy As Windows.Forms.Button
    Friend WithEvents BtnModerate As Windows.Forms.Button
    Friend WithEvents BtnHard As Windows.Forms.Button
    Friend WithEvents BtnFree As Windows.Forms.Button
    Friend WithEvents BtnBack As Windows.Forms.Button
    Friend WithEvents ScrollbarChoixPartie As Windows.Forms.VScrollBar
    Friend WithEvents LblEasy As Windows.Forms.Label
    Friend WithEvents LblModerate As Windows.Forms.Label
    Friend WithEvents LblHard As Windows.Forms.Label
    Friend WithEvents LblFree As Windows.Forms.Label
End Class
