Imports System.Windows.Forms

Public Class FormAccueil
    Private Sub BtnStartGame_Click(sender As Object, e As EventArgs) Handles BtnStartGame.Click
        ' Vérifier si les deux joueurs ont saisi un nom valide
        If CmbJoueur1.Text <> "" AndAlso CmbJoueur2.Text <> "" AndAlso CmbJoueur1.Text <> CmbJoueur2.Text Then
            ' Les deux joueurs ont saisi un nom différent, tu peux lancer la partie ici
            Dim nomJoueurQuiPropose As String = CmbJoueur1.Text
            Dim nomJoueurQuiJoue As String = CmbJoueur2.Text

            ' Vérifier si les joueurs existent déjà dans la liste des joueurs, sinon les ajouter
            AjouterJoueurSiNecessaire(nomJoueurQuiPropose)
            AjouterJoueurSiNecessaire(nomJoueurQuiJoue)

            ' Récupérer les joueurs depuis la liste des joueurs
            Dim joueurQuiPropose As Joueur = RechercherJoueurParNom(nomJoueurQuiPropose)
            Dim joueurQuiJoue As Joueur = RechercherJoueurParNom(nomJoueurQuiJoue)

            ' Passer les joueurs à la prochaine fenêtre (FormCommencementPartie)
            Dim formCommencementPartie As New FormCommencementPartie()
            formCommencementPartie.JoueurQuiPropose = joueurQuiPropose
            formCommencementPartie.JoueurQuiJoue = joueurQuiJoue

            formCommencementPartie.Show()
            Me.Hide() ' Cache le formulaire FormAccueil au lieu de le fermer

        Else
            ' Affiche un message d'erreur si les noms des joueurs sont identiques ou non saisis
            MessageBox.Show("Veuillez saisir des noms de joueurs différents.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CmbJoueur1_DropDown(sender As Object, e As EventArgs) Handles CmbJoueur1.DropDown
        ' Met à jour la liste des joueurs connus dans la ComboBox
        MettreAJourListeJoueurs(CmbJoueur1)
    End Sub

    Private Sub CmbJoueur2_DropDown(sender As Object, e As EventArgs) Handles CmbJoueur2.DropDown
        ' Met à jour la liste des joueurs connus dans la ComboBox
        MettreAJourListeJoueurs(CmbJoueur2)
    End Sub

    Private Sub MettreAJourListeJoueurs(comboBox As ComboBox)
        comboBox.Items.Clear()
        For Each joueur In Joueurs
            comboBox.Items.Add(joueur.Nom)
        Next
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        ' Affiche une boîte de dialogue de confirmation avant de quitter l'application
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            ' Sauvegarde les joueurs dans le fichier avant de quitter
            SauvegarderJoueursDansFichier("joueurs.txt")

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