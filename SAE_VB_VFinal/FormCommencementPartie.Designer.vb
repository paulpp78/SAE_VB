<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCommencementPartie
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
        Me.LblCaractereJouable = New System.Windows.Forms.Label()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.TxtCaractere1 = New System.Windows.Forms.TextBox()
        Me.TxtCaractere2 = New System.Windows.Forms.TextBox()
        Me.TxtCaractere3 = New System.Windows.Forms.TextBox()
        Me.TxtCaractere4 = New System.Windows.Forms.TextBox()
        Me.TxtCaractere5 = New System.Windows.Forms.TextBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnRandom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblCaractereJouable
        '
        Me.LblCaractereJouable.AutoSize = True
        Me.LblCaractereJouable.BackColor = System.Drawing.Color.White
        Me.LblCaractereJouable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaractereJouable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblCaractereJouable.Location = New System.Drawing.Point(77, 297)
        Me.LblCaractereJouable.Name = "LblCaractereJouable"
        Me.LblCaractereJouable.Size = New System.Drawing.Size(63, 20)
        Me.LblCaractereJouable.TabIndex = 0
        Me.LblCaractereJouable.Text = "Label1"
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Red
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNext.Location = New System.Drawing.Point(514, 297)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(91, 35)
        Me.BtnNext.TabIndex = 1
        Me.BtnNext.Text = "Start"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'TxtCaractere1
        '
        Me.TxtCaractere1.BackColor = System.Drawing.Color.Blue
        Me.TxtCaractere1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaractere1.ForeColor = System.Drawing.Color.Transparent
        Me.TxtCaractere1.Location = New System.Drawing.Point(187, 163)
        Me.TxtCaractere1.MaxLength = 1
        Me.TxtCaractere1.Name = "TxtCaractere1"
        Me.TxtCaractere1.Size = New System.Drawing.Size(100, 26)
        Me.TxtCaractere1.TabIndex = 2
        '
        'TxtCaractere2
        '
        Me.TxtCaractere2.BackColor = System.Drawing.Color.Lime
        Me.TxtCaractere2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaractere2.ForeColor = System.Drawing.Color.Black
        Me.TxtCaractere2.Location = New System.Drawing.Point(293, 163)
        Me.TxtCaractere2.MaxLength = 1
        Me.TxtCaractere2.Name = "TxtCaractere2"
        Me.TxtCaractere2.Size = New System.Drawing.Size(100, 26)
        Me.TxtCaractere2.TabIndex = 3
        '
        'TxtCaractere3
        '
        Me.TxtCaractere3.BackColor = System.Drawing.Color.Blue
        Me.TxtCaractere3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaractere3.ForeColor = System.Drawing.Color.Transparent
        Me.TxtCaractere3.Location = New System.Drawing.Point(399, 163)
        Me.TxtCaractere3.MaxLength = 1
        Me.TxtCaractere3.Name = "TxtCaractere3"
        Me.TxtCaractere3.Size = New System.Drawing.Size(100, 26)
        Me.TxtCaractere3.TabIndex = 4
        '
        'TxtCaractere4
        '
        Me.TxtCaractere4.BackColor = System.Drawing.Color.Lime
        Me.TxtCaractere4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaractere4.ForeColor = System.Drawing.Color.Black
        Me.TxtCaractere4.Location = New System.Drawing.Point(505, 163)
        Me.TxtCaractere4.MaxLength = 1
        Me.TxtCaractere4.Name = "TxtCaractere4"
        Me.TxtCaractere4.Size = New System.Drawing.Size(100, 26)
        Me.TxtCaractere4.TabIndex = 5
        '
        'TxtCaractere5
        '
        Me.TxtCaractere5.BackColor = System.Drawing.Color.Blue
        Me.TxtCaractere5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaractere5.ForeColor = System.Drawing.Color.Transparent
        Me.TxtCaractere5.Location = New System.Drawing.Point(611, 163)
        Me.TxtCaractere5.MaxLength = 1
        Me.TxtCaractere5.Name = "TxtCaractere5"
        Me.TxtCaractere5.Size = New System.Drawing.Size(100, 26)
        Me.TxtCaractere5.TabIndex = 6
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Gray
        Me.BtnQuit.Location = New System.Drawing.Point(420, 32)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(79, 31)
        Me.BtnQuit.TabIndex = 7
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'BtnRandom
        '
        Me.BtnRandom.BackColor = System.Drawing.Color.Gold
        Me.BtnRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRandom.Location = New System.Drawing.Point(12, 163)
        Me.BtnRandom.Name = "BtnRandom"
        Me.BtnRandom.Size = New System.Drawing.Size(92, 33)
        Me.BtnRandom.TabIndex = 8
        Me.BtnRandom.Text = "Random"
        Me.BtnRandom.UseVisualStyleBackColor = False
        '
        'FormCommencementPartie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(745, 450)
        Me.Controls.Add(Me.BtnRandom)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.TxtCaractere5)
        Me.Controls.Add(Me.TxtCaractere4)
        Me.Controls.Add(Me.TxtCaractere3)
        Me.Controls.Add(Me.TxtCaractere2)
        Me.Controls.Add(Me.TxtCaractere1)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.LblCaractereJouable)
        Me.Name = "FormCommencementPartie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Character"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCaractereJouable As Windows.Forms.Label
    Friend WithEvents BtnNext As Windows.Forms.Button
    Friend WithEvents TxtCaractere1 As Windows.Forms.TextBox
    Friend WithEvents TxtCaractere2 As Windows.Forms.TextBox
    Friend WithEvents TxtCaractere3 As Windows.Forms.TextBox
    Friend WithEvents TxtCaractere4 As Windows.Forms.TextBox
    Friend WithEvents TxtCaractere5 As Windows.Forms.TextBox
    Friend WithEvents BtnQuit As Windows.Forms.Button
    Friend WithEvents BtnRandom As Windows.Forms.Button
End Class
