Imports System.Drawing
Imports System.Windows.Forms

Public Class FormOption
    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles BtnCouleurAbsent.Click, BtnCouleurPresent.Click, BtnCouleurBienPlace.Click
        Dim colorButton As Button = CType(sender, Button)
        ModuleOptionsDeJeu.SetCouleurAction(colorButton)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Vérifier que toutes les options sont remplies
        If RdBtnTmp.Checked = False AndAlso TrckBarTemps.Value = 0 Then
            MessageBox.Show("Veuillez spécifier une durée limite de temps.", "Options incomplètes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(TxtCaracteres.Text) Then
            MessageBox.Show("Veuillez spécifier les caractères utilisables.", "Options incomplètes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If NumUpDownNbProposition.Value = 0 Then
            MessageBox.Show("Veuillez spécifier une limite de propositions.", "Options incomplètes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(TxtSelectedFile.Text) Then
            MessageBox.Show("Veuillez sélectionner un fichier de sauvegarde.", "Options incomplètes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Enregistrer les options dans le module ModuleOptionsDeJeu
        ModuleOptionsDeJeu.SetAllOptions(RdBtnTmp.Checked, TxtCaracteres.Text, NumUpDownNbProposition.Value, TxtSelectedFile.Text, BtnCouleurAbsent.BackColor, BtnCouleurPresent.BackColor, BtnCouleurBienPlace.BackColor, TimeSpan.FromSeconds(TrckBarTemps.Value))

        MessageBox.Show("Les options ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FormAccueil.Show()
        Me.Hide()
    End Sub


    Private Sub RdBtnTmp_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnTmp.CheckedChanged
        If RdBtnTmp.Checked Then
            ' Si le RadioButton est coché, masquer la TrackBar et la désactiver
            TrckBarTemps.Hide()
            TrckBarTemps.Enabled = False
        Else
            ' Si le RadioButton n'est pas coché, afficher la TrackBar et l'activer
            TrckBarTemps.Show()
            TrckBarTemps.Enabled = True
        End If
    End Sub

    Private Sub TrckBarTemps_Scroll(sender As Object, e As EventArgs) Handles TrckBarTemps.Scroll
        ' Gérer l'événement Scroll de la TrackBar pour obtenir la valeur choisie
        Dim minutes As Integer = TrckBarTemps.Value \ 60
        Dim secondes As Integer = TrckBarTemps.Value Mod 60
        ' Faire quelque chose avec les valeurs de minutes et de secondes choisies
        TextBoxValeurScrollBar.Text = minutes.ToString() & " minutes " & secondes.ToString() & " secondes"
    End Sub

    Private Sub FormOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurer les propriétés de la TrackBar pour augmenter la sensibilité
        TrckBarTemps.Minimum = 0
        TrckBarTemps.Maximum = 120 ' 2 minutes
        TrckBarTemps.LargeChange = 15
    End Sub

    Private Sub BtnSelectFile_Click(sender As Object, e As EventArgs) Handles BtnSelectFile.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Configurez les options de l'OpenFileDialog si nécessaire
        openFileDialog.Title = "Sélectionnez un fichier"
        openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"

        ' Affichez la boîte de dialogue de sélection de fichier
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Récupérez le chemin complet du fichier sélectionné
            Dim selectedFilePath As String = openFileDialog.FileName

            ' Affectez le chemin du fichier sélectionné au contrôle TextBox
            TxtSelectedFile.Text = selectedFilePath
        End If
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        ' Affiche une boîte de dialogue de confirmation avant de quitter l'application
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Me.Close()
            FormStartAppli.Show()
        End If
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        ' Get the current value of the scroll bar
        Dim scrollValue As Integer = HScrollBar1.Value
        Me.HorizontalScroll.Value = scrollValue
    End Sub

End Class
