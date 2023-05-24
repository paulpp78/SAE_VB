Imports System.Drawing
Imports System.Windows.Forms

Public Class FormCommencementPartie

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        ' Vérifie si tous les caractères ont été saisis
        If TxtCaractere1.TextLength = 1 AndAlso TxtCaractere2.TextLength = 1 AndAlso TxtCaractere3.TextLength = 1 AndAlso TxtCaractere4.TextLength = 1 AndAlso TxtCaractere5.TextLength = 1 Then
            ' Vérifie si les caractères saisis sont valides
            Dim caracteresAutorises As String = ModuleOptionsDeJeu.GetCaracteresUtilisables()
            SetCombinaison(TxtCaractere1.Text & TxtCaractere2.Text & TxtCaractere3.Text & TxtCaractere4.Text & TxtCaractere5.Text)

            ' Vérifie si chaque caractère de la combinaison est autorisé
            Dim caracteresInvalides As String = ""
            For Each caractere As Char In GetCombinaison()
                If Not caracteresAutorises.Contains(caractere) Then
                    caracteresInvalides &= caractere & " "
                End If
            Next

            If caracteresInvalides = "" Then
                ' La combinaison est valide, tu peux effectuer l'action souhaitée
                ' Passe à la prochaine étape du jeu
                FormJoueurQuiDevine.Show()
                Me.Close() ' Ferme le formulaire actuel
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
        LblCaractereJouable.Text = "Caractères autorisés : " & ModuleOptionsDeJeu.GetCaracteresUtilisables()
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        ' Affiche une boîte de dialogue de confirmation avant de quitter l'application
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Me.Close()
            FormStartAppli.Show()
        End If
    End Sub

    Private Sub BtnRandom_Click(sender As Object, e As EventArgs) Handles BtnRandom.Click
        Dim caracteresAutorises As String = ModuleOptionsDeJeu.GetCaracteresUtilisables()
        Dim random As New Random()

        TxtCaractere1.Text = caracteresAutorises(random.Next(0, caracteresAutorises.Length))
        TxtCaractere2.Text = caracteresAutorises(random.Next(0, caracteresAutorises.Length))
        TxtCaractere3.Text = caracteresAutorises(random.Next(0, caracteresAutorises.Length))
        TxtCaractere4.Text = caracteresAutorises(random.Next(0, caracteresAutorises.Length))
        TxtCaractere5.Text = caracteresAutorises(random.Next(0, caracteresAutorises.Length))
    End Sub
End Class
