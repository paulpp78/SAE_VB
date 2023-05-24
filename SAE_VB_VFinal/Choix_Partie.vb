Imports System.Windows.Forms

Public Class Choix_Partie

    Private Sub Choix_Partie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Code à exécuter lors du chargement du formulaire
        LblEasy.Text = "10 tentative"
        LblFree.Text = "A toi de choisir"
        LblHard.Text = "4 tentatives"
        LblModerate.Text = "7 tentatives"

        ' Par exemple, vous pouvez initialiser des valeurs ou effectuer des opérations spécifiques au chargement du formulaire
        MessageBox.Show("Bienvenue dans le choix de partie !")
    End Sub

    Private Sub BtnEasy_Click(sender As Object, e As EventArgs) Handles BtnEasy.Click
        ModuleOptionsDeJeu.SetOptionsImportants(True, 10, TimeSpan.FromMinutes(2))
        FormAccueil.Show()
        Me.Hide()
    End Sub

    Private Sub BtnModerate_Click(sender As Object, e As EventArgs) Handles BtnModerate.Click
        ModuleOptionsDeJeu.SetOptionsImportants(True, 7, TimeSpan.FromSeconds(45))
        FormAccueil.Show()
        Me.Hide()
    End Sub

    Private Sub BtnHard_Click(sender As Object, e As EventArgs) Handles BtnHard.Click
        ModuleOptionsDeJeu.SetOptionsImportants(True, 4, TimeSpan.FromSeconds(15))
        FormAccueil.Show()
        Me.Hide()

    End Sub


    Private Sub BtnFree_Click(sender As Object, e As EventArgs) Handles BtnFree.Click
        FormOption.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        StartAppli.Show()
        Me.Hide()
    End Sub

    Private Sub ScrollbarChoixPartie_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrollbarChoixPartie.Scroll
        ' Récupérer la position de défilement de la scrollbar
        Dim scrollPosition As Integer = ScrollbarChoixPartie.Value

        ' Définir la position de défilement vertical du formulaire
        Me.VerticalScroll.Value = scrollPosition
    End Sub

End Class