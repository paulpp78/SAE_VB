Imports System.Drawing
Imports System.Windows.Forms

Public Class FormJoueurQuiDevine
    Private combinaison As String ' Variable pour stocker la combinaison à deviner
    Private remainingTime As TimeSpan ' Variable pour stocker le temps restant
    Private colors As Color()
    Private tempsRestant As Integer

    Private Sub FormJoueurQuiDevine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponents()
        ResetGame()
    End Sub

    Private Sub InitializeComponents()
        LblRemainingAttempts.Text = "15"
        remainingTime = TimeSpan.FromMinutes(1).Add(TimeSpan.FromSeconds(30))
        LblRemainingTime.Text = remainingTime.ToString("m\:ss")
        lstHistorique.Items.Clear()
        lstHistorique.DrawMode = DrawMode.OwnerDrawVariable
        TxtChoix1.Focus()
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1))
        tempsRestant = remainingTime.Minutes
        If remainingTime.TotalSeconds <= 0 Then
            Timer1.Stop()
            MessageBox.Show("Désolé, le temps est écoulé.", "Défaite", MessageBoxButtons.OK, MessageBoxIcon.Information)
            EndGame(False)
        Else
            LblRemainingTime.Text = remainingTime.ToString("m\:ss")
        End If
    End Sub

    Private Function GetReponse(proposition As String) As String
        Dim reponse As String = ""

        For i As Integer = 0 To combinaison.Length - 1
            Dim caracterePropose As Char = proposition(i)
            Dim caractereCombinaison As Char = combinaison(i)

            If caracterePropose = caractereCombinaison Then
                reponse &= "P"
            ElseIf combinaison.Contains(caracterePropose) Then
                reponse &= "M"
            Else
                reponse &= "A"
            End If
        Next

        Return reponse
    End Function

    Private Sub UpdateRemainingAttempts()
        Dim remainingAttempts As Integer = Integer.Parse(LblRemainingAttempts.Text)
        remainingAttempts -= 1

        If remainingAttempts = 0 Then
            MessageBox.Show("Désolé, vous avez épuisé toutes vos tentatives.", "Défaite", MessageBoxButtons.OK, MessageBoxIcon.Information)
            EndGame(False)
        Else
            LblRemainingAttempts.Text = remainingAttempts.ToString()
        End If
    End Sub

    Private Sub lstHistorique_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstHistorique.DrawItem
        If e.Index >= 0 AndAlso e.Index < lstHistorique.Items.Count Then
            e.DrawBackground()

            Dim isSelected As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected

            Dim proposition As String = lstHistorique.Items(e.Index).ToString()

            Dim xPosition As Integer = e.Bounds.Left
            For i As Integer = 0 To proposition.Length - 1
                Dim caractere As Char = proposition(i)
                Dim couleur As Color = GetColorFromResponse(GetReponse(proposition).Chars(i))
                Dim caractereSize As SizeF = e.Graphics.MeasureString(caractere.ToString(), e.Font)
                Dim caractereBounds As New RectangleF(xPosition, e.Bounds.Top, caractereSize.Width, e.Bounds.Height)

                Using brush As New SolidBrush(couleur)
                    e.Graphics.DrawString(caractere.ToString(), e.Font, brush, caractereBounds)
                End Using

                xPosition += CInt(caractereSize.Width)
            Next

            If isSelected Then
                e.DrawFocusRectangle()
            End If
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If AllCharactersEntered() Then
            Dim proposition As String = TxtChoix1.Text & TxtChoix2.Text & TxtChoix3.Text & TxtChoix4.Text & TxtChoix5.Text
            If proposition = combinaison Then
                MessageBox.Show("Félicitations ! Vous avez deviné la combinaison.", "Victoire", MessageBoxButtons.OK, MessageBoxIcon.Information)
                EndGame(True)
            Else
                lstHistorique.Items.Add(proposition)
                Dim reponse As String = GetReponse(proposition)
                UpdateRemainingAttempts()
                HighlightTextBox(TxtChoix1, GetColorFromResponse(reponse.Chars(0)), 1500)
                HighlightTextBox(TxtChoix2, GetColorFromResponse(reponse.Chars(1)), 1500)
                HighlightTextBox(TxtChoix3, GetColorFromResponse(reponse.Chars(2)), 1500)
                HighlightTextBox(TxtChoix4, GetColorFromResponse(reponse.Chars(3)), 1500)
                HighlightTextBox(TxtChoix5, GetColorFromResponse(reponse.Chars(4)), 1500)
                ResetGame()

                If Integer.Parse(LblRemainingAttempts.Text) = 0 Then
                    MessageBox.Show("Désolé, vous avez épuisé toutes vos tentatives. La combinaison était : " & combinaison, "Défaite", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    EndGame(False)
                End If
            End If
        Else
            MessageBox.Show("Veuillez saisir tous les caractères de la proposition.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function AllCharactersEntered() As Boolean
        Return TxtChoix1.Text <> "" AndAlso TxtChoix2.Text <> "" AndAlso TxtChoix3.Text <> "" AndAlso TxtChoix4.Text <> "" AndAlso TxtChoix5.Text <> ""
    End Function

    Private Function GetColorFromResponse(responseChar As Char) As Color
        Select Case responseChar
            Case "P"c
                Return Color.FromArgb(0, 192, 0) ' LblPresentEtBienPlace
            Case "M"c
                Return Color.Blue ' LblPresent
            Case Else
                Return Color.Red ' LblAbsent
        End Select
    End Function

    Private Sub HighlightTextBox(textBox As TextBox, backColor As Color, durationMilliseconds As Integer)
        textBox.BackColor = backColor
        Task.Delay(durationMilliseconds).ContinueWith(Sub()
                                                          textBox.BackColor = SystemColors.Window
                                                      End Sub)
    End Sub

    Private Sub EndGame(Joueur1APerdu As Boolean)
        ' Afficher le formulaire de partie terminée avec les nouveaux rôles des joueurs
        'Dim formPartieTerminee As New FormPartieTerminee()
        'formPartieTerminee.RemplirLabels(joueurQuiPropose.nom, joueurQuiJoue.nom)
        'formPartieTerminee.Show()

        If Joueur1APerdu Then
            ModuleJoueur.AjouterStats(getDeuxiemeJoueur, tempsRestant)
        Else
            ModuleJoueur.AjouterStats(getPremierJoueur, tempsRestant)
        End If

        SauvegarderHistorique()
        Me.Close() ' Fermer le formulaire actuel
    End Sub

    Private Sub ResetGame()
        TxtChoix1.Clear()
        TxtChoix2.Clear()
        TxtChoix4.Clear()
        TxtChoix3.Clear()
        TxtChoix5.Clear()
        TxtChoix1.Focus()
    End Sub
End Class
