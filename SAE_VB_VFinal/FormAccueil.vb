Imports System.Windows.Forms

Public Class FormAccueil
    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charger les joueurs depuis l'historique
        ChargerHistorique()

        ' Mettre à jour la liste des joueurs dans les ComboBox
        ChargerNomsJoueurs(CmbJoueur1, CmbJoueur2)
    End Sub

    Private Sub BtnStartGame_Click(sender As Object, e As EventArgs) Handles BtnStartGame.Click
        ' Vérifier si les deux joueurs ont saisi un nom valide
        If CmbJoueur1.Text <> "" AndAlso CmbJoueur2.Text <> "" AndAlso CmbJoueur1.Text <> CmbJoueur2.Text Then
            ' Enregistrer les joueurs dans l'historique
            EnregistrerJoueur(CmbJoueur1, CmbJoueur2)
            CmbJoueur1.Text = ""
            CmbJoueur2.Text = ""
            InverserNomsJoueurs(CmbJoueur1, CmbJoueur2)
            FormCommencementPartie.Show()
            Me.Hide() ' Cache le formulaire FormAccueil au lieu de le fermer

        Else
            ' Affiche un message d'erreur si les noms des joueurs sont identiques ou non saisis
            MessageBox.Show("Veuillez saisir des noms de joueurs différents.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        ' Affiche une boîte de dialogue de confirmation avant de quitter l'application
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            ' Sauvegarde l'historique des joueurs dans le fichier avant de quitter
            SauvegarderHistorique()

            ' Ferme l'application
            Application.Exit()
        End If
    End Sub

    Private Sub BtnSeeScore_Click(sender As Object, e As EventArgs) Handles BtnSeeScore.Click
        ' Affiche le formulaire du tableau des scores
        Dim formTableauScores As New FormTableauScores()
        formTableauScores.ShowDialog()
    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        Dim formOption As New FormOption()
        formOption.ShowDialog()
    End Sub

    Private Sub BtnStatJoueur_Click(sender As Object, e As EventArgs) Handles BtnStatJoueur.Click
        Dim formStatJoueur As New FormStatJoueur
        formStatJoueur.ShowDialog()
    End Sub
End Class
