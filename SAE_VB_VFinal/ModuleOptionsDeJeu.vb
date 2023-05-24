Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Module OptionsDeJeu
    Private limiteTempsActif As Boolean = False
    Private caracteresUtilisables As String = "!@#$%"
    Private limitePropositions As Integer = 15
    Private cheminSauvegardePartie As String = "./MasterMind.txt"
    Private couleurAbsent As Color = Color.Red
    Private couleurPresent As Color = Color.Blue
    Private couleurBienPlace As Color = Color.FromArgb(0, 192, 0)

    Public Property LimiteTempsActif1 As Boolean
        Get
            Return limiteTempsActif
        End Get
        Set(value As Boolean)
            limiteTempsActif = value
        End Set
    End Property

    Public Property CaracteresUtilisables1 As String
        Get
            Return caracteresUtilisables
        End Get
        Set(value As String)
            caracteresUtilisables = value
        End Set
    End Property

    Public Property LimitePropositions1 As Integer
        Get
            Return limitePropositions
        End Get
        Set(value As Integer)
            limitePropositions = value
        End Set
    End Property

    Public Property CheminSauvegarde1 As String
        Get
            Return cheminSauvegardePartie
        End Get
        Set(value As String)
            cheminSauvegardePartie = value
        End Set
    End Property

    Public Property CouleurAbsent1 As Color
        Get
            Return couleurAbsent
        End Get
        Set(value As Color)
            couleurAbsent = value
        End Set
    End Property

    Public Property CouleurPresent1 As Color
        Get
            Return couleurPresent
        End Get
        Set(value As Color)
            couleurPresent = value
        End Set
    End Property

    Public Property CouleurBienPlace1 As Color
        Get
            Return couleurBienPlace
        End Get
        Set(value As Color)
            couleurBienPlace = value
        End Set
    End Property

    Public Property CheminFichier1 As String
        Get
            Return cheminFichierOption
        End Get
        Set(value As String)
            cheminFichierOption = value
        End Set
    End Property

    Public Sub GérerLimiteTemps(checked As Boolean)
        If checked Then
            ' La limite de temps est activée, ajoute le code correspondant ici
        Else
            ' La limite de temps est désactivée, ajoute le code correspondant ici
        End If
    End Sub

    Public Sub GérerModificationCaracteres(caracteres As String)
        CaracteresUtilisables1 = caracteres
        ' Ajoute le code correspondant ici pour gérer la modification des caractères utilisables
    End Sub

    Public Sub GérerModificationLimitePropositions(limite As Integer)
        LimitePropositions1 = limite
        ' Ajoute le code correspondant ici pour gérer la modification de la limite de propositions
    End Sub

    Public Sub GérerModificationCheminSauvegarde(chemin As String)
        CheminSauvegarde1 = chemin
        ' Ajoute le code correspondant ici pour gérer la modification du chemin de sauvegarde
    End Sub

    Public Sub GérerCouleurAction(ByRef colorButton As Button)
        Dim colorDialog As New ColorDialog()

        ' Afficher la boîte de dialogue de choix de couleur
        If colorDialog.ShowDialog() = DialogResult.OK Then
            ' Récupérer la couleur sélectionnée
            Dim couleur As Color = colorDialog.Color

            ' Définir la couleur du bouton
            colorButton.BackColor = couleur

            ' Utilisez la couleur sélectionnée (couleur) pour gérer l'action correspondante
            ' Ajoutez le code correspondant ici pour gérer la couleur sélectionnée pour l'action appropriée
            Select Case colorButton.Name
                Case "BtnCouleurAbsent"
                    CouleurAbsent1 = couleur
                Case "BtnCouleurPresent"
                    CouleurPresent1 = couleur
                Case "BtnCouleurBienPlace"
                    CouleurBienPlace1 = couleur
            End Select
        End If
    End Sub

    Public Sub EnregistrerOptions()
        ' Vérifier si le chemin de fichier est vide
        If String.IsNullOrEmpty(CheminFichier1) Then
            ' Afficher un message d'erreur ou prendre une autre action appropriée
            MessageBox.Show("Le chemin de sauvegarde est vide.", "Erreur de sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Obtenir le répertoire du chemin de fichier
        Dim directoryPath As String = Path.GetDirectoryName(CheminFichier1)

        ' Vérifier si le répertoire existe
        If Not Directory.Exists(directoryPath) Then
            ' Créer le répertoire s'il n'existe pas
            Directory.CreateDirectory(directoryPath)
        End If

        ' Écrire les options dans le fichier
        Using writer As New StreamWriter(CheminFichier1)
            writer.WriteLine("LimiteTemps=" & LimiteTempsActif1.ToString())
            writer.WriteLine("CaracteresUtilisables=" & CaracteresUtilisables1)
            writer.WriteLine("LimitePropositions=" & LimitePropositions1.ToString())
            writer.WriteLine("CheminSauvegarde=" & CheminSauvegarde1)
            writer.WriteLine("CouleurAbsent=" & CouleurAbsent1.ToArgb().ToString())
            writer.WriteLine("CouleurPresent=" & CouleurPresent1.ToArgb().ToString())
            writer.WriteLine("CouleurBienPlace=" & CouleurBienPlace1.ToArgb().ToString())
        End Using
    End Sub


End Module
