Imports System.Windows.Forms

Public Class FormAccueil
    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nomsJoueursHistorique As List(Of String) = ModuleJoueur.GetNomsJoueursHistorique()

        Dim validNomsJoueursHistorique = nomsJoueursHistorique.Where(Function(n) n IsNot Nothing).ToList()

        CmbJoueur1.Items.AddRange(validNomsJoueursHistorique.ToArray())
        CmbJoueur2.Items.AddRange(validNomsJoueursHistorique.ToArray())
    End Sub


    Private Sub BtnStartGame_Click(sender As Object, e As EventArgs) Handles BtnStartGame.Click
        ' Vérifier si les deux joueurs ont saisi un nom valide
        If CmbJoueur1.Text <> "" AndAlso CmbJoueur2.Text <> "" AndAlso CmbJoueur1.Text <> CmbJoueur2.Text Then
            ' Enregistrer les joueurs dans l'historique
            
            EnregistrerJoueur()
            CmbJoueur1.Text = ""
            CmbJoueur2.Text = ""
            ' Cache le formulaire FormAccueil au lieu de le fermer
            Me.Hide()
            FormCommencementPartie.Show()
        Else
            ' Affiche un message d'erreur si les noms des joueurs sont identiques ou non saisis
            MessageBox.Show("Veuillez saisir des noms de joueurs différents.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        ' Affiche une boîte de dialogue de confirmation avant de quitter l'application
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Me.Close()
            FormStartAppli.Show()
        End If
    End Sub
End Class
