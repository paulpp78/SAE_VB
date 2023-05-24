Imports System.Windows.Forms

Public Class FormStatJoueur
    Private Sub FormStatJoueur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charger les joueurs depuis le fichier ou la liste en mémoire
        ModuleJoueur.ChargerHistorique()

        ' Initialiser la ListBox avec les noms des joueurs
        MettreAJourListeJoueurs()

        ' Initialiser la ComboBox avec les noms des joueurs
        MettreAJourComboBoxRecherche()
    End Sub

    Private Sub MettreAJourListeJoueurs()
        ' Effacer la liste actuelle
        LstJoueurs.Items.Clear()

        ' Ajouter les noms des joueurs à la ListBox
        For Each joueur As ModuleJoueur.Joueur In ModuleJoueur.joueursHistorique
            LstJoueurs.Items.Add(joueur.nom)
        Next
    End Sub

    Private Sub MettreAJourComboBoxRecherche()
        ' Effacer la liste actuelle
        CbnRechercheJoueur.Items.Clear()

        ' Trier les joueurs par nom
        TrierJoueursParNom()

        ' Ajouter les noms des joueurs à la ComboBox
        For Each joueur As ModuleJoueur.Joueur In ModuleJoueur.joueursHistorique
            CbnRechercheJoueur.Items.Add(joueur.nom)
        Next
    End Sub

    Private Sub TrierJoueursParNom()
        ModuleJoueur.joueursHistorique.Sort(Function(joueur1, joueur2) joueur1.nom.CompareTo(joueur2.nom))
    End Sub



    Private Sub TrierJoueursParScore()
        ModuleJoueur.TrierJoueursParScore()
    End Sub

    Private Sub TrierJoueursParMeilleurTemps()
        ModuleJoueur.TrierJoueursParMeilleurTemps()
    End Sub

    Private Sub BtnTriNom_Click(sender As Object, e As EventArgs) Handles BtnTriNom.Click
        ' Trier les joueurs par nom
        TrierJoueursParNom()

        ' Mettre à jour la ListBox
        MettreAJourListeJoueurs()
    End Sub

    Private Sub BtnTriScore_Click(sender As Object, e As EventArgs) Handles BtnTriScore.Click
        ' Trier les joueurs par score
        TrierJoueursParScore()

        ' Mettre à jour la ListBox
        MettreAJourListeJoueurs()
    End Sub

    Private Sub BtnTriTemps_Click(sender As Object, e As EventArgs) Handles BtnTriTemps.Click
        ' Trier les joueurs par meilleur temps
        TrierJoueursParMeilleurTemps()

        ' Mettre à jour la ListBox
        MettreAJourListeJoueurs()
    End Sub

    Private Sub BtnRechercherJoueur_Click(sender As Object, e As EventArgs) Handles BtnRechercherJoueur.Click
        Dim nomJoueur As String = CbnRechercheJoueur.Text
        Dim joueur As ModuleJoueur.Joueur = RechercherJoueurParNom(nomJoueur)

        If IsNothing(joueur) Then
            MessageBox.Show("Joueur non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AfficherStatistiquesJoueur(joueur)
        End If
    End Sub

    Private Function RechercherJoueurParNom(nom As String) As ModuleJoueur.Joueur
        Return ModuleJoueur.RechercherJoueurParNom(nom)
    End Function

    Private Sub AfficherStatistiquesJoueur(joueur As ModuleJoueur.Joueur)
        ' Afficher les statistiques du joueur dans les contrôles appropriés
        TxtNom.Text = joueur.nom
        TxtScore.Text = joueur.score.ToString()
        TxtMeilleurTemps.Text = joueur.meilleurTemps.ToString()
        TxtPartiesPremierJoueur.Text = joueur.nbrPartiesPremierJoueur.ToString()
        TxtPartiesSecondJoueur.Text = joueur.nbrPartiesSecondJoueur.ToString()
        TxtTempsTotal.Text = joueur.cumulTemps.ToString()
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
