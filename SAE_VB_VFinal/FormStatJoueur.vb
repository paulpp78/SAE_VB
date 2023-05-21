Imports System.Windows.Forms

Public Class FormStatJoueur
    Private Sub FormStatJoueur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charger les joueurs depuis le fichier ou la liste en mémoire
        ChargerJoueursDepuisFichier("chemin_vers_le_fichier")

        ' Initialiser la ListBox avec les noms des joueurs
        MettreAJourListeJoueurs()

        ' Initialiser la ComboBox avec les noms des joueurs
        MettreAJourComboBoxRecherche()
    End Sub

    Private Sub MettreAJourListeJoueurs()
        ' Effacer la liste actuelle
        LstJoueurs.Items.Clear()

        ' Trier les joueurs par nom
        TrierJoueursParNom()

        ' Ajouter les noms des joueurs à la ListBox
        For Each joueur As Joueur In Joueurs
            LstJoueurs.Items.Add(joueur.Nom)
        Next
    End Sub

    Private Sub MettreAJourComboBoxRecherche()
        ' Effacer la liste actuelle
        CbnRechercheJoueur.Items.Clear()

        ' Trier les joueurs par nom
        TrierJoueursParNom()

        ' Ajouter les noms des joueurs à la ComboBox
        For Each joueur As Joueur In Joueurs
            CbnRechercheJoueur.Items.Add(joueur.Nom)
        Next
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
        Dim joueur As Joueur = RechercherJoueurParNom(nomJoueur)

        If IsNothing(joueur) Then
            MessageBox.Show("Joueur non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Afficher les statistiques du joueur dans une MessageBox
            Dim message As String = $"Statistiques du joueur {joueur.Nom}:" & Environment.NewLine &
                $"Score : {joueur.Score}" & Environment.NewLine &
                $"Meilleur temps : {joueur.MeilleurTemps}" & Environment.NewLine &
                $"Parties jouées en tant que premier : {joueur.PartiesJoueesEnTantQueNomJoueurQuiPropose}" & Environment.NewLine &
                $"Parties jouées en tant que second : {joueur.PartiesJoueesEnTantQueNomJoueurQuiJoue}" & Environment.NewLine &
                $"Temps total : {joueur.TempsTotal}"
            MessageBox.Show(message, "Statistiques du joueur")
        End If

    End Sub

End Class