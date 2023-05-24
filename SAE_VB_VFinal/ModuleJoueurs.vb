Imports System.IO

Module ModuleJoueur
    Private Const NBR_MAX_JOUEUR As Integer = 2
    Private joueursActuels(NBR_MAX_JOUEUR - 1) As Joueur
    Private joueursHistorique As List(Of Joueur) = New List(Of Joueur)()
    Private estPremiereFois As Boolean = True
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

    Public Sub EnregistrerJoueur(ByRef cmbJoueur1 As Object, ByRef cmbJoueur2 As Object)
        ResetJoueursActuels()
        joueursActuels(0).nom = cmbJoueur1.Text
        joueursActuels(0).estPremierJoueur = True

        joueursActuels(1).nom = cmbJoueur2.Text
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

        ChargerNomsJoueurs(cmbJoueur1, cmbJoueur2)
    End Sub

    Public Sub InverserNomsJoueurs(ByRef cmbJoueur1 As Object, ByRef cmbJoueur2 As Object)
        cmbJoueur1.Text = joueursActuels(1).nom
        cmbJoueur2.Text = joueursActuels(0).nom
    End Sub

    Public Function GetAncienNomTemp() As String
        Return joueursActuels(0).ancienNom
    End Function

    Public Sub SetAncienNomTemp(ancien As String)
        joueursActuels(0).ancienNom = ancien
    End Sub

    Public Sub FinDePartieSwitchJoueur(ByRef cmbJoueur1 As Object, ByRef cmbJoueur2 As Object)
        Dim tempNom As String = joueursActuels(0).nom
        joueursActuels(0).nom = joueursActuels(1).nom
        joueursActuels(1).nom = tempNom
        cmbJoueur1.Text = joueursActuels(0).nom
        cmbJoueur2.Text = joueursActuels(1).nom
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


                If temps < joueurActuel.meilleurTemps Or joueurActuel.meilleurTemps = 0 Then
                    joueurActuel.meilleurTemps = temps
                End If

                joueurActuel.cumulTemps += temps
                Exit For
            End If
        Next
    End Sub

    Public Function EstContenuDansHistorique(nom As String) As Boolean
        For Each joueur In joueursHistorique
            If joueur.nom = nom Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub ChargerNomsJoueurs(ByRef cmbJoueur1 As Object, ByRef cmbJoueur2 As Object)
        cmbJoueur1.Items.Clear()
        cmbJoueur2.Items.Clear()

        For Each joueur In joueursHistorique
            cmbJoueur1.Items.Add(joueur.nom)
            cmbJoueur2.Items.Add(joueur.nom)
        Next
    End Sub



    Public Sub SauvegarderHistorique()
        Dim fichier As StreamWriter = File.CreateText(cheminFichier)
        For Each joueur In joueursHistorique
            fichier.WriteLine(joueur.nom & ";" & joueur.score & ";" & joueur.meilleurTemps & ";" & joueur.nbrPartiesPremierJoueur & ";" & joueur.nbrPartiesSecondJoueur & ";" & joueur.cumulTemps)
        Next
        fichier.Close()
    End Sub

    Public Sub ChargerHistorique()
        If File.Exists(cheminFichier) Then
            Dim fichier As StreamReader = File.OpenText(cheminFichier)
            While Not fichier.EndOfStream
                Dim ligne As String = fichier.ReadLine()
                Dim donnees() As String = ligne.Split(";")
                Dim joueur As Joueur
                joueur.nom = donnees(0)
                joueur.score = Integer.Parse(donnees(1))
                joueur.meilleurTemps = Integer.Parse(donnees(2))
                joueur.nbrPartiesPremierJoueur = Integer.Parse(donnees(3))
                joueur.nbrPartiesSecondJoueur = Integer.Parse(donnees(4))
                joueur.cumulTemps = Integer.Parse(donnees(5))
                joueur.estPremierJoueur = False
                joueur.ancienNom = ""
                joueursHistorique.Add(joueur)
            End While
            fichier.Close()
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

End Module