Imports System.Drawing
Imports System.Windows.Forms

Module ModuleOptionsDeJeu
    Private limiteTempsActif As Boolean = False
    Private caracteresUtilisables As String = "!@#$%"
    Private limitePropositions As Integer = 15
    Public cheminSauvegardePartie As String = "./MasterMind.txt"
    Private couleurAbsent As Color = Color.Red
    Private couleurPresent As Color = Color.Blue
    Private couleurBienPlace As Color = Color.FromArgb(0, 192, 0)
    Private DureeLimiteTemps As TimeSpan

    ' Méthodes pour obtenir et modifier les options

    Public Sub SetAllOptions(ByVal limiteTemps As Boolean, ByVal caracteres As String, ByVal limiteProp As Integer, ByVal cheminSauvegarde As String, ByVal couleurAbs As Color, ByVal couleurPres As Color, ByVal couleurBienPl As Color)
        limiteTempsActif = limiteTemps
        caracteresUtilisables = caracteres
        limitePropositions = limiteProp
        cheminSauvegardePartie = cheminSauvegarde
        couleurAbsent = couleurAbs
        couleurPresent = couleurPres
        couleurBienPlace = couleurBienPl
    End Sub


    Public Function GetDureeLimiteTemps() As TimeSpan
        Return DureeLimiteTemps
    End Function

    Public Sub SetDureeLimiteTemps(duree As TimeSpan)
        DureeLimiteTemps = duree
    End Sub


    Public Sub SetOptionsImportants(ByVal limiteTemps As Boolean, ByVal limiteProp As Integer, ByVal DureeLim As TimeSpan)
        limiteTempsActif = limiteTemps
        limitePropositions = limiteProp
        DureeLimiteTemps = DureeLim
    End Sub
    Public Function GetLimiteTempsActif() As Boolean
        Return limiteTempsActif
    End Function

    Public Sub SetLimiteTempsActif(ByVal value As Boolean)
        limiteTempsActif = value
    End Sub

    Public Function GetCaracteresUtilisables() As String
        Return caracteresUtilisables
    End Function

    Public Sub SetCaracteresUtilisables(ByVal value As String)
        caracteresUtilisables = value
    End Sub

    Public Function GetLimitePropositions() As Integer
        Return limitePropositions
    End Function

    Public Sub SetLimitePropositions(ByVal value As Integer)
        limitePropositions = value
    End Sub

    Public Function GetCheminSauvegardePartie() As String
        Return cheminSauvegardePartie
    End Function

    Public Sub SetCheminSauvegardePartie(ByVal value As String)
        cheminSauvegardePartie = value
    End Sub

    Public Function GetCouleurAbsent() As Color
        Return couleurAbsent
    End Function

    Public Sub SetCouleurAbsent(ByVal value As Color)
        couleurAbsent = value
    End Sub

    Public Function GetCouleurPresent() As Color
        Return couleurPresent
    End Function

    Public Sub SetCouleurPresent(ByVal value As Color)
        couleurPresent = value
    End Sub

    Public Function GetCouleurBienPlace() As Color
        Return couleurBienPlace
    End Function

    Public Sub SetCouleurBienPlace(ByVal value As Color)
        couleurBienPlace = value
    End Sub

    Public Sub SetCouleurAction(ByVal colorButton As Button)
        Dim colorDialog As New ColorDialog()

        ' Affichez la boîte de dialogue de sélection de couleur
        If colorDialog.ShowDialog() = DialogResult.OK Then
            ' Obtenez la couleur sélectionnée
            Dim selectedColor As Color = colorDialog.Color

            ' Modifiez la couleur en fonction du bouton sur lequel vous avez cliqué
            Select Case colorButton.Name
                Case "BtnCouleurAbsent"
                    couleurAbsent = selectedColor
                    colorButton.BackColor = selectedColor
                Case "BtnCouleurPresent"
                    couleurPresent = selectedColor
                    colorButton.BackColor = selectedColor
                Case "BtnCouleurBienPlace"
                    couleurBienPlace = selectedColor
                    colorButton.BackColor = selectedColor
            End Select
        End If
    End Sub
End Module
