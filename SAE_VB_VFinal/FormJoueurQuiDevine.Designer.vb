﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJoueurQuiDevine
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
        Me.components = New System.ComponentModel.Container()
        Me.LblCaractereJouable = New System.Windows.Forms.Label()
        Me.LblRemainingAttempts = New System.Windows.Forms.Label()
        Me.LblRemainingTime = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.TxtChoix1 = New System.Windows.Forms.TextBox()
        Me.TxtChoix2 = New System.Windows.Forms.TextBox()
        Me.TxtChoix3 = New System.Windows.Forms.TextBox()
        Me.TxtChoix4 = New System.Windows.Forms.TextBox()
        Me.TxtChoix5 = New System.Windows.Forms.TextBox()
        Me.lstHistorique = New System.Windows.Forms.ListBox()
        Me.LblAbsent = New System.Windows.Forms.Label()
        Me.LblPresent = New System.Windows.Forms.Label()
        Me.LblPresentEtBienPlace = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblCaractereJouable
        '
        Me.LblCaractereJouable.AutoSize = True
        Me.LblCaractereJouable.BackColor = System.Drawing.Color.Black
        Me.LblCaractereJouable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaractereJouable.ForeColor = System.Drawing.Color.Transparent
        Me.LblCaractereJouable.Location = New System.Drawing.Point(281, 360)
        Me.LblCaractereJouable.Name = "LblCaractereJouable"
        Me.LblCaractereJouable.Size = New System.Drawing.Size(125, 20)
        Me.LblCaractereJouable.TabIndex = 0
        Me.LblCaractereJouable.Text = "Label Autorisé"
        '
        'LblRemainingAttempts
        '
        Me.LblRemainingAttempts.AutoSize = True
        Me.LblRemainingAttempts.BackColor = System.Drawing.Color.Black
        Me.LblRemainingAttempts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemainingAttempts.ForeColor = System.Drawing.Color.Transparent
        Me.LblRemainingAttempts.Location = New System.Drawing.Point(281, 273)
        Me.LblRemainingAttempts.Name = "LblRemainingAttempts"
        Me.LblRemainingAttempts.Size = New System.Drawing.Size(191, 20)
        Me.LblRemainingAttempts.TabIndex = 1
        Me.LblRemainingAttempts.Text = "LblRemainingAttempts"
        '
        'LblRemainingTime
        '
        Me.LblRemainingTime.AutoSize = True
        Me.LblRemainingTime.BackColor = System.Drawing.Color.Black
        Me.LblRemainingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemainingTime.ForeColor = System.Drawing.Color.Transparent
        Me.LblRemainingTime.Location = New System.Drawing.Point(281, 318)
        Me.LblRemainingTime.Name = "LblRemainingTime"
        Me.LblRemainingTime.Size = New System.Drawing.Size(156, 20)
        Me.LblRemainingTime.TabIndex = 2
        Me.LblRemainingTime.Text = "LblRemainingTime"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.Gold
        Me.BtnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(663, 83)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(70, 23)
        Me.BtnSubmit.TabIndex = 3
        Me.BtnSubmit.Text = "BtnSubmit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'TxtChoix1
        '
        Me.TxtChoix1.BackColor = System.Drawing.Color.White
        Me.TxtChoix1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChoix1.ForeColor = System.Drawing.Color.Black
        Me.TxtChoix1.Location = New System.Drawing.Point(41, 86)
        Me.TxtChoix1.MaxLength = 1
        Me.TxtChoix1.Name = "TxtChoix1"
        Me.TxtChoix1.Size = New System.Drawing.Size(100, 24)
        Me.TxtChoix1.TabIndex = 4
        Me.TxtChoix1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtChoix2
        '
        Me.TxtChoix2.BackColor = System.Drawing.Color.White
        Me.TxtChoix2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChoix2.ForeColor = System.Drawing.Color.Black
        Me.TxtChoix2.Location = New System.Drawing.Point(161, 86)
        Me.TxtChoix2.MaxLength = 1
        Me.TxtChoix2.Name = "TxtChoix2"
        Me.TxtChoix2.Size = New System.Drawing.Size(100, 24)
        Me.TxtChoix2.TabIndex = 5
        Me.TxtChoix2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtChoix3
        '
        Me.TxtChoix3.BackColor = System.Drawing.Color.White
        Me.TxtChoix3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChoix3.ForeColor = System.Drawing.Color.Black
        Me.TxtChoix3.Location = New System.Drawing.Point(285, 83)
        Me.TxtChoix3.MaxLength = 1
        Me.TxtChoix3.Name = "TxtChoix3"
        Me.TxtChoix3.Size = New System.Drawing.Size(100, 24)
        Me.TxtChoix3.TabIndex = 6
        Me.TxtChoix3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtChoix4
        '
        Me.TxtChoix4.BackColor = System.Drawing.Color.White
        Me.TxtChoix4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChoix4.ForeColor = System.Drawing.Color.Black
        Me.TxtChoix4.Location = New System.Drawing.Point(415, 86)
        Me.TxtChoix4.MaxLength = 1
        Me.TxtChoix4.Name = "TxtChoix4"
        Me.TxtChoix4.Size = New System.Drawing.Size(100, 24)
        Me.TxtChoix4.TabIndex = 7
        Me.TxtChoix4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtChoix5
        '
        Me.TxtChoix5.BackColor = System.Drawing.Color.White
        Me.TxtChoix5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChoix5.ForeColor = System.Drawing.Color.Black
        Me.TxtChoix5.Location = New System.Drawing.Point(533, 86)
        Me.TxtChoix5.MaxLength = 1
        Me.TxtChoix5.Name = "TxtChoix5"
        Me.TxtChoix5.Size = New System.Drawing.Size(100, 24)
        Me.TxtChoix5.TabIndex = 8
        Me.TxtChoix5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstHistorique
        '
        Me.lstHistorique.BackColor = System.Drawing.Color.Black
        Me.lstHistorique.ForeColor = System.Drawing.Color.Transparent
        Me.lstHistorique.FormattingEnabled = True
        Me.lstHistorique.Location = New System.Drawing.Point(41, 143)
        Me.lstHistorique.Name = "lstHistorique"
        Me.lstHistorique.Size = New System.Drawing.Size(100, 264)
        Me.lstHistorique.TabIndex = 9
        '
        'LblAbsent
        '
        Me.LblAbsent.AutoSize = True
        Me.LblAbsent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAbsent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblAbsent.Location = New System.Drawing.Point(649, 182)
        Me.LblAbsent.Name = "LblAbsent"
        Me.LblAbsent.Size = New System.Drawing.Size(59, 18)
        Me.LblAbsent.TabIndex = 10
        Me.LblAbsent.Text = "Absent"
        '
        'LblPresent
        '
        Me.LblPresent.AutoSize = True
        Me.LblPresent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPresent.ForeColor = System.Drawing.Color.Blue
        Me.LblPresent.Location = New System.Drawing.Point(649, 209)
        Me.LblPresent.Name = "LblPresent"
        Me.LblPresent.Size = New System.Drawing.Size(66, 18)
        Me.LblPresent.TabIndex = 11
        Me.LblPresent.Text = "Present"
        '
        'LblPresentEtBienPlace
        '
        Me.LblPresentEtBienPlace.AutoSize = True
        Me.LblPresentEtBienPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPresentEtBienPlace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblPresentEtBienPlace.Location = New System.Drawing.Point(622, 231)
        Me.LblPresentEtBienPlace.Name = "LblPresentEtBienPlace"
        Me.LblPresentEtBienPlace.Size = New System.Drawing.Size(166, 18)
        Me.LblPresentEtBienPlace.TabIndex = 12
        Me.LblPresentEtBienPlace.Text = "Present et bien place"
        '
        'Timer1
        '
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Gray
        Me.BtnQuit.Location = New System.Drawing.Point(709, 12)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(79, 31)
        Me.BtnQuit.TabIndex = 13
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'FormJoueurQuiDevine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(796, 450)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.LblPresentEtBienPlace)
        Me.Controls.Add(Me.LblPresent)
        Me.Controls.Add(Me.LblAbsent)
        Me.Controls.Add(Me.lstHistorique)
        Me.Controls.Add(Me.TxtChoix5)
        Me.Controls.Add(Me.TxtChoix4)
        Me.Controls.Add(Me.TxtChoix3)
        Me.Controls.Add(Me.TxtChoix2)
        Me.Controls.Add(Me.TxtChoix1)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LblRemainingTime)
        Me.Controls.Add(Me.LblRemainingAttempts)
        Me.Controls.Add(Me.LblCaractereJouable)
        Me.Name = "FormJoueurQuiDevine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCaractereJouable As Windows.Forms.Label
    Friend WithEvents LblRemainingAttempts As Windows.Forms.Label
    Friend WithEvents LblRemainingTime As Windows.Forms.Label
    Friend WithEvents BtnSubmit As Windows.Forms.Button
    Friend WithEvents TxtChoix1 As Windows.Forms.TextBox
    Friend WithEvents TxtChoix2 As Windows.Forms.TextBox
    Friend WithEvents TxtChoix3 As Windows.Forms.TextBox
    Friend WithEvents TxtChoix4 As Windows.Forms.TextBox
    Friend WithEvents TxtChoix5 As Windows.Forms.TextBox
    Friend WithEvents lstHistorique As Windows.Forms.ListBox
    Friend WithEvents LblAbsent As Windows.Forms.Label
    Friend WithEvents LblPresent As Windows.Forms.Label
    Friend WithEvents LblPresentEtBienPlace As Windows.Forms.Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents BtnQuit As Windows.Forms.Button
End Class
