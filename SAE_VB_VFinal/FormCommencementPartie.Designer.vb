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
        Me.SuspendLayout()
        '
        'LblCaractereJouable
        '
        Me.LblCaractereJouable.AutoSize = True
        Me.LblCaractereJouable.Location = New System.Drawing.Point(325, 356)
        Me.LblCaractereJouable.Name = "LblCaractereJouable"
        Me.LblCaractereJouable.Size = New System.Drawing.Size(39, 13)
        Me.LblCaractereJouable.TabIndex = 0
        Me.LblCaractereJouable.Text = "Label1"
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(646, 326)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 1
        Me.BtnNext.Text = "Start"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'TxtCaractere1
        '
        Me.TxtCaractere1.Location = New System.Drawing.Point(36, 109)
        Me.TxtCaractere1.Name = "TxtCaractere1"
        Me.TxtCaractere1.Size = New System.Drawing.Size(100, 20)
        Me.TxtCaractere1.TabIndex = 2
        '
        'TxtCaractere2
        '
        Me.TxtCaractere2.Location = New System.Drawing.Point(210, 109)
        Me.TxtCaractere2.Name = "TxtCaractere2"
        Me.TxtCaractere2.Size = New System.Drawing.Size(100, 20)
        Me.TxtCaractere2.TabIndex = 3
        '
        'TxtCaractere3
        '
        Me.TxtCaractere3.Location = New System.Drawing.Point(373, 109)
        Me.TxtCaractere3.Name = "TxtCaractere3"
        Me.TxtCaractere3.Size = New System.Drawing.Size(100, 20)
        Me.TxtCaractere3.TabIndex = 4
        '
        'TxtCaractere4
        '
        Me.TxtCaractere4.Location = New System.Drawing.Point(516, 109)
        Me.TxtCaractere4.Name = "TxtCaractere4"
        Me.TxtCaractere4.Size = New System.Drawing.Size(100, 20)
        Me.TxtCaractere4.TabIndex = 5
        '
        'TxtCaractere5
        '
        Me.TxtCaractere5.Location = New System.Drawing.Point(656, 109)
        Me.TxtCaractere5.Name = "TxtCaractere5"
        Me.TxtCaractere5.Size = New System.Drawing.Size(100, 20)
        Me.TxtCaractere5.TabIndex = 6
        '
        'FormCommencementPartie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtCaractere5)
        Me.Controls.Add(Me.TxtCaractere4)
        Me.Controls.Add(Me.TxtCaractere3)
        Me.Controls.Add(Me.TxtCaractere2)
        Me.Controls.Add(Me.TxtCaractere1)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.LblCaractereJouable)
        Me.Name = "FormCommencementPartie"
        Me.Text = "Form1"
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
End Class
