Imports System.IO

Module ModuleJoueur
    Private Const NBR_MAX_JOUEUR As Integer = 2
    Public joueursActuels(NBR_MAX_JOUEUR - 1) As Joueur
    Public joueursHistorique As New List(Of Joueur)()
    Public JoueurQuiGagne As String
    Private cheminFichier As String = "../../HistoriqueJoueurs.txt"

    Structure Joueur
        Public nom As String
        Public score As Integer
        Public meilleurTemps As Integer
        Public nbrPartiesPremierJoueur As Integer
        Public nbrPartiesSecondJoueur As Integer
        Public cumulTemps As Integer
        Public estPremierJoueur As Boolean
        Public ancienNom As String
    End Structure

    Public Function GetJoueurQuiGagne() As String
        Return JoueurQuiGagne
    End Function

    Public Sub SetJoueurQuiGagne(Quigagne As String)
        JoueurQuiGagne = Quigagne
    End Sub

    Public Sub EnregistrerJoueur()
        joueursHistorique.Clear() ' Effacer les joueurs existants dans l'historique
        ResetJoueursActuels()
        joueursActuels(0).nom = FormAccueil.CmbJoueur1.Text
        joueursActuels(0).estPremierJoueur = True

        joueursActuels(1).nom = FormAccueil.CmbJoueur2.Text
        joueursActuels(1).estPremierJoueur = False

        AjouterJoueursDansHistorique()

        For Each joueur In joueursActuels
            joueur.score = 0
            joueur.meilleurTemps = 0
            joueur.cumulTemps = 0
            joueur.ancienNom = ""
            If joueur.estPremierJoueur Then
                joueur.nbrPartiesPremierJoueur += 1
            Else
                joueur.nbrPartiesSecondJoueur += 1
            End If
        Next
        ChargerNomsJoueurs()
    End Sub



    Public Sub ChargerNomsJoueurs()
        If Not File.Exists(cheminFichier) Then
            File.Create(cheminFichier).Close()
        End If

        Dim nbJoueurHistorique As Integer
        If FileLen(cheminFichier) > 0 Then
            Dim num As Integer = FreeFile()
            FileOpen(num, cheminFichier, OpenMode.Input)
            nbJoueurHistorique = LineInput(num)

            For i As Integer = 0 To nbJoueurHistorique - 1
                Dim joueur As Joueur
                joueur.nom = LineInput(num)
                joueur.score = LineInput(num)
                joueur.meilleurTemps = LineInput(num)
                joueur.nbrPartiesPremierJoueur = LineInput(num)
                joueur.nbrPartiesSecondJoueur = LineInput(num)
                joueur.cumulTemps = LineInput(num)

                ' Vérifier si le joueur existe déjà dans l'historique
                ' Vérifier si le joueur existe déjà dans l'historique
                Dim joueurExistant = joueursHistorique.FirstOrDefault(Function(j) j.nom = joueur.nom)
                If joueurExistant.Equals(New Joueur()) Then
                    ' Ajouter le joueur uniquement s'il n'existe pas déjà
                    joueursHistorique.Add(joueur)
                End If

            Next
            FileClose(num)
        End If
    End Sub

    Public Sub MiseAJourJoueurDansHistorique(joueur As Joueur)
        For Each joueurHistorique In joueursHistorique
            If joueurHistorique.nom = joueur.nom Then
                joueurHistorique.score = joueur.score
                joueurHistorique.cumulTemps = joueur.cumulTemps
                joueurHistorique.nbrPartiesPremierJoueur = joueur.nbrPartiesPremierJoueur
                joueurHistorique.nbrPartiesSecondJoueur = joueur.nbrPartiesSecondJoueur
                Exit For
            End If
        Next
    End Sub

    Public Sub ResetJoueursActuels()
        Array.Clear(joueursActuels, 0, joueursActuels.Length)
    End Sub

    Public Sub AjouterJoueursDansHistorique()
        For Each joueur In joueursActuels
            If Not EstContenuDansHistorique(joueur.nom) Then
                joueursHistorique.Add(joueur)
            End If
        Next
    End Sub

    Public Function EstContenuDansHistorique(nom As String) As Boolean
        Return joueursHistorique.Any(Function(joueur) joueur.nom = nom)
    End Function



    Public Sub SauvegarderHistoriqueDansFichier()
        Using writer As New StreamWriter(cheminFichier)
            writer.WriteLine(joueursHistorique.Count)
            For Each joueur In joueursHistorique
                writer.WriteLine(joueur.nom)
                writer.WriteLine(joueur.score)
                writer.WriteLine(joueur.meilleurTemps)
                writer.WriteLine(joueur.nbrPartiesPremierJoueur)
                writer.WriteLine(joueur.nbrPartiesSecondJoueur)
                writer.WriteLine(joueur.cumulTemps)
            Next
        End Using
    End Sub

    Public Sub ChargerHistorique()
        If Not File.Exists(cheminFichier) Then
            Dim fichier As StreamWriter = File.CreateText(cheminFichier)
            fichier.Close()
        End If

        Dim nbJoueurHistorique As Integer = 0
        If FileLen(cheminFichier) > 0 Then
            Using reader As New StreamReader(cheminFichier)
                nbJoueurHistorique = CInt(reader.ReadLine())
                joueursHistorique.Clear()

                For i As Integer = 0 To nbJoueurHistorique - 1
                    Dim joueur As Joueur
                    joueur.nom = reader.ReadLine()
                    joueur.score = CInt(reader.ReadLine())
                    joueur.meilleurTemps = CInt(reader.ReadLine())
                    joueur.nbrPartiesPremierJoueur = CInt(reader.ReadLine())
                    joueur.nbrPartiesSecondJoueur = CInt(reader.ReadLine())
                    joueur.cumulTemps = CInt(reader.ReadLine())

                    joueursHistorique.Add(joueur)
                Next
            End Using
        End If
    End Sub

    Public Sub SupprimerHistorique()
        joueursHistorique.Clear()
        If File.Exists(cheminFichier) Then
            File.Delete(cheminFichier)
        End If
    End Sub

    Public Function getPremierJoueur() As Joueur
        Return joueursActuels(0)
    End Function

    Public Function getDeuxiemeJoueur() As Joueur
        Return joueursActuels(1)
    End Function

    Public Function RechercherJoueurParNom(nom As String) As Joueur
        Return joueursHistorique.FirstOrDefault(Function(joueur) joueur.nom = nom)
    End Function

    Public Sub TrierJoueursParMeilleurTemps()
        joueursHistorique.Sort(Function(joueur1, joueur2) joueur1.meilleurTemps.CompareTo(joueur2.meilleurTemps))
    End Sub

    Public Sub TrierJoueursParScore()
        joueursHistorique.Sort(Function(joueur1, joueur2) joueur2.score.CompareTo(joueur1.score))
    End Sub

    Public Function joueurHistoriqueEstVide() As Boolean
        Return joueursHistorique.Count = 0
    End Function

    Public Function GetNomsJoueursHistorique() As List(Of String)
        Return joueursHistorique.Select(Function(joueur) joueur.nom).ToList()
    End Function

    Public Sub InverserNomsJoueurs()
        FormAccueil.CmbJoueur1.Text = joueursActuels(1).nom
        FormAccueil.CmbJoueur2.Text = joueursActuels(0).nom
    End Sub

End Module
