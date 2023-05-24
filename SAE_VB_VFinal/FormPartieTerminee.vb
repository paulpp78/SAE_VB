Imports System.Windows.Forms

Public Class FormPartieTerminee

    ' Méthode pour initialiser les labels avec les noms des joueurs
    Public Sub RemplirLabels(nomJoueurQuiPropose As String, nomJoueurQuiJoue As String)
        joueurQuiPropose = nomJoueurQuiPropose
        joueurQuiJoue = nomJoueurQuiJoue
        LblJoueurQuiPropose.Text = "Joueur qui propose : " & nomJoueurQuiPropose
        LblJoueurQuiJoue.Text = "Joueur qui joue : " & nomJoueurQuiJoue
    End Sub

    ' Gestionnaire d'événement pour le clic sur le bouton "Nouvelle Partie"
    Private Sub BtnNouvellePartie_Click(sender As Object, e As EventArgs) Handles BtnNouvellePartie.Click
        ' Code à exécuter lorsque le bouton "Nouvelle Partie" est cliqué
        ' Rediriger vers le formulaire d'accueil pour démarrer une nouvelle partie

        Dim formAccueil As New FormAccueil()
        formAccueil.CmbJoueur1.Text = joueurQuiPropose
        formAccueil.CmbJoueur2.Text = joueurQuiJoue
        formAccueil.Show()

        Me.Close() ' Fermer le formulaire actuel
    End Sub

    ' Gestionnaire d'événement pour le clic sur le bouton "Quitter le jeu"
    Private Sub BtnQuitterLeJeu_Click(sender As Object, e As EventArgs) Handles BtnQuitterlejeu.Click
        ' Code à exécuter lorsque le bouton "Quitter le jeu" est cliqué
        ' Fermer l'application
        Application.Exit()
    End Sub

    ' Gestionnaire d'événement pour le clic sur le bouton "Continuer sans rejouer"
    Private Sub BtnContinuerSansRejouer_Click(sender As Object, e As EventArgs) Handles BtnContinuerSansRejouer.Click
        ' Code à exécuter lorsque le bouton "Continuer sans rejouer" est cliqué
        ' Rediriger vers le formulaire d'accueil pour proposer une nouvelle partie
        Dim formAccueil As New FormAccueil()
        formAccueil.CmbJoueur1.Text = joueurQuiJoue
        formAccueil.CmbJoueur2.Text = joueurQuiPropose
        formAccueil.Show()

        Me.Close() ' Fermer le formulaire actuel
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        ' Affiche une boîte de dialogue de confirmation avant de quitter l'application
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Me.Close()
            StartAppli.Show()
        End If
    End Sub
End Class
