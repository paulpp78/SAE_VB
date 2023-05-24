Imports System.Windows.Forms

Public Class FormStartAppli

    Private Sub StartAppli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerHistorique()
    End Sub

    Private Sub BtnNewGame_Click(sender As Object, e As EventArgs) Handles BtnNewGame.Click
        FormAccueil.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Dim message As String = "Mastermind est une application du jeu de société où les joueurs doivent trouver le code en utilisant des indications."

        MessageBox.Show(message, "À propos du Mastermind", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnSeeScore_Click(sender As Object, e As EventArgs) Handles BtnSeeScore.Click
        ' Affiche le formulaire du tableau des scores
        'Dim formTableauScores As New FormTableauScores()
        'FormTableauScores.ShowDialog()
        FormTableauScores.Show()
        Me.Hide()
    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click

        'Dim formOption As New FormOption()
        'FormOption.ShowDialog()
        FormChoix_Partie.Show()
        Me.Hide()
    End Sub

    Private Sub BtnStatJoueur_Click(sender As Object, e As EventArgs) Handles BtnStatJoueur.Click
        'Dim formStatJoueur As New FormStatJoueur
        'formStatJoueur.ShowDialog()
        FormStatJoueur.Show()
        Me.Hide()


    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        ' Affiche une boîte de dialogue de confirmation avant de quitter l'application
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            ' Ferme l'application
            Application.Exit()
        End If
    End Sub


End Class