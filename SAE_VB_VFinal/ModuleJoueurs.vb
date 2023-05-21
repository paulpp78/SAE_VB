Imports System.IO

Module ModuleJoueurs
    Public Class Joueur
        Public Nom As String
        Public Score As Integer
        Public MeilleurTemps As Integer
        Public PartiesJoueesEnTantQueNomJoueurQuiPropose As Integer
        Public PartiesJoueesEnTantQueNomJoueurQuiJoue As Integer
        Public TempsTotal As Integer
        Public EstPremierJoueur As Boolean ' Nouvel élément pour indiquer si le joueur est le premier joueur ou le joueur qui devine
    End Class

    Public Joueurs As New List(Of Joueur)()

    Public Sub AjouterJoueur(nom As String)
        Dim nouveauJoueur As Joueur
        nouveauJoueur.Nom = nom
        nouveauJoueur.Score = 0
        nouveauJoueur.MeilleurTemps = 0
        nouveauJoueur.PartiesJoueesEnTantQueNomJoueurQuiPropose = 0
        nouveauJoueur.PartiesJoueesEnTantQueNomJoueurQuiJoue = 0
        nouveauJoueur.TempsTotal = 0
        nouveauJoueur.EstPremierJoueur = False

        Joueurs.Add(nouveauJoueur)
    End Sub

    Public Sub AjouterJoueurSiNecessaire(nom As String)
        ChargerJoueursDepuisFichier("nom_du_fichier.txt")

        Dim joueurExistant = Joueurs.FirstOrDefault(Function(j) j.Nom = nom)

        If joueurExistant.Equals(Nothing) Then
            AjouterJoueur(nom)
        End If
    End Sub


    Public Sub MettreAJourStatistiquesJoueur(nom As String, score As Integer, temps As Integer, estPremierJoueur As Boolean)
        Dim joueur = Joueurs.FirstOrDefault(Function(j) j.Nom = nom)

        If Not joueur.Equals(Nothing) Then
            joueur.Score += score
            joueur.TempsTotal += temps

            If score > joueur.Score Then
                joueur.Score = score
            End If

            If temps < joueur.MeilleurTemps OrElse joueur.MeilleurTemps = 0 Then
                joueur.MeilleurTemps = temps
            End If

            If estPremierJoueur Then
                joueur.PartiesJoueesEnTantQueNomJoueurQuiPropose += 1
                joueur.EstPremierJoueur = True ' Le joueur est le premier joueur
            Else
                joueur.PartiesJoueesEnTantQueNomJoueurQuiJoue += 1
                joueur.EstPremierJoueur = False ' Le joueur n'est pas le premier joueur
            End If
        End If
    End Sub

    Public Sub TrierJoueursParNom()
        Joueurs.Sort(Function(j1, j2) j1.Nom.CompareTo(j2.Nom))
    End Sub

    Public Sub TrierJoueursParScore()
        Joueurs.Sort(Function(j1, j2) j2.Score.CompareTo(j1.Score))
    End Sub

    Public Sub TrierJoueursParMeilleurTemps()
        Joueurs.Sort(Function(j1, j2) j1.MeilleurTemps.CompareTo(j2.MeilleurTemps))
    End Sub

    Public Function RechercherJoueurParNom(nom As String) As Joueur
        Return Joueurs.FirstOrDefault(Function(j) j.Nom = nom)
    End Function

    Public Sub SauvegarderJoueursDansFichier(nomFichier As String)
        Using writer As New StreamWriter(nomFichier)
            For Each joueur In Joueurs
                writer.WriteLine(joueur.Nom)
                writer.WriteLine(joueur.Score)
                writer.WriteLine(joueur.MeilleurTemps)
                writer.WriteLine(joueur.PartiesJoueesEnTantQueNomJoueurQuiPropose)
                writer.WriteLine(joueur.PartiesJoueesEnTantQueNomJoueurQuiJoue)
                writer.WriteLine(joueur.TempsTotal)
                writer.WriteLine(joueur.EstPremierJoueur)
            Next
        End Using
    End Sub
    Public Sub ChargerJoueursDepuisFichier(nomFichier As String)
        Joueurs.Clear()

        If File.Exists(nomFichier) Then
            Using reader As New StreamReader(nomFichier)
                While Not reader.EndOfStream
                    Dim joueur As Joueur
                    joueur.Nom = reader.ReadLine()
                    joueur.Score = Integer.Parse(reader.ReadLine())
                    joueur.MeilleurTemps = Integer.Parse(reader.ReadLine())
                    joueur.PartiesJoueesEnTantQueNomJoueurQuiPropose = Integer.Parse(reader.ReadLine())
                    joueur.PartiesJoueesEnTantQueNomJoueurQuiJoue = Integer.Parse(reader.ReadLine())
                    joueur.TempsTotal = Integer.Parse(reader.ReadLine())
                    joueur.EstPremierJoueur = Boolean.Parse(reader.ReadLine())

                    Joueurs.Add(joueur)
                End While
            End Using
        End If
    End Sub
End Module