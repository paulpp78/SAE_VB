Imports System.Windows.Forms

Public Class FormCommencementPartie
    Public Property JoueurQuiPropose As Object
    Public Property JoueurQuiJoue As Object
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        ' Vérifie si tous les caractères ont été saisis
        If TxtCaractere1.TextLength = 1 AndAlso TxtCaractere2.TextLength = 1 AndAlso TxtCaractere3.TextLength = 1 AndAlso TxtCaractere4.TextLength = 1 AndAlso TxtCaractere5.TextLength = 1 Then
            ' Vérifie si les caractères saisis sont valides
            Dim caracteresAutorises As String = "!@#$%"
            Dim combinaison As String = TxtCaractere1.Text & TxtCaractere2.Text & TxtCaractere3.Text & TxtCaractere4.Text & TxtCaractere5.Text

            ' Vérifie si chaque caractère de la combinaison est autorisé
            Dim caracteresInvalides As String = ""
            For Each caractere As Char In combinaison
                If Not caracteresAutorises.Contains(caractere) Then
                    caracteresInvalides &= caractere & " "
                End If
            Next

            If caracteresInvalides = "" Then
                ' La combinaison est valide, tu peux effectuer l'action souhaitée
                ' Passe à la prochaine étape du jeu en passant les joueurs et la combinaison
                Dim joueurQuiPropose As Joueur = TryCast(joueurQuiPropose, Joueur)
                Dim joueurQuiJoue As Joueur = TryCast(joueurQuiJoue, Joueur)

                ' Vérifie si les objets Joueur sont valides
                If joueurQuiPropose IsNot Nothing AndAlso joueurQuiJoue IsNot Nothing Then
                    ' Mise à jour des statistiques des joueurs
                    MettreAJourStatistiquesJoueur(joueurQuiPropose.Nom, 0, 0, True)
                    MettreAJourStatistiquesJoueur(joueurQuiJoue.Nom, 0, 0, False)

                    ' Passe à la prochaine étape du jeu en passant les joueurs et la combinaison
                    Dim FormJoueurQuiDevine As New FormJoueurQuiDevine(joueurQuiPropose, joueurQuiJoue, combinaison)
                    FormJoueurQuiDevine.Show()
                    Me.Close() ' Ferme le formulaire actuel
                Else
                    ' Affiche un message d'erreur si les objets Joueur sont invalides
                    MessageBox.Show("Les joueurs sont invalides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ' Affiche un message d'erreur avec les caractères invalides
                MessageBox.Show("Les caractères suivants ne sont pas autorisés : " & caracteresInvalides, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Affiche un message d'erreur si tous les caractères n'ont pas été saisis
            MessageBox.Show("Veuillez saisir un seul caractère dans chaque TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FormCommencementPartie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblCaractereJouable.Text = "Caractères autorisés : ! @ # $ %"
    End Sub
End Class