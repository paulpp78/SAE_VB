Imports System.Windows.Forms

Public Class FormPartieTerminee


    Private Sub FormPartieTerminee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblResultat.Text = "Le joueur : " & GetJoueurQuiGagne() & " a gagné la partie."
    End Sub



    ' Gestionnaire d'événement pour le clic sur le bouton "Nouvelle Partie"
    Private Sub BtnNouvellePartie_Click(sender As Object, e As EventArgs) Handles BtnNouvellePartie.Click
        ' Code à exécuter lorsque le bouton "Nouvelle Partie" est cliqué
        ' Rediriger vers le formulaire d'accueil pour démarrer une nouvelle partie
        FormAccueil.Show()
        InverserNomsJoueurs()
        Me.Hide() ' Fermer le formulaire actuel
    End Sub

    ' Gestionnaire d'événement pour le clic sur le bouton "Continuer sans rejouer"
    Private Sub BtnContinuerSansRejouer_Click(sender As Object, e As EventArgs) Handles BtnContinuerSansRejouer.Click
        FormChoix_Partie.Show()
        Me.Hide() ' Fermer le formulaire actuel
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        ' Affiche une boîte de dialogue de confirmation avant de quitter l'application
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
