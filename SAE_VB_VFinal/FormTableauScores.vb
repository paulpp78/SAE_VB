Imports System.Drawing
Imports System.Windows.Forms

Public Class FormTableauScores
    Inherits Form

    Public Sub New()
        ' Initialisation du formulaire
        InitializeComponent()

        ' Configuration du DataGridView
        DgvTabScore.Name = "DgvTabScore"
        DgvTabScore.Dock = DockStyle.Fill

        ' Ajouter les colonnes au DataGridView
        DgvTabScore.Columns.Add("Nom", "Nom")
        DgvTabScore.Columns.Add("Score", "Score")
        DgvTabScore.Columns.Add("MeilleurTemps", "Meilleur Temps")
        DgvTabScore.Columns.Add("PartiesJoueesEnTantQuePremierJoueur", "Parties en tant que Premier Joueur")
        DgvTabScore.Columns.Add("PartiesJoueesEnTantQueDeuxiemeJoueur", "Parties en tant que Deuxième Joueur")
        DgvTabScore.Columns.Add("TempsTotal", "Temps Total")

        ' Ajouter le DataGridView au formulaire
        Controls.Add(DgvTabScore)
    End Sub

    Private Sub FormTableauScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Lier les données du tableau des scores au DataGridView
        DgvTabScore.DataSource = ModuleJoueur.joueursHistorique
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        ' Affiche une boîte de dialogue de confirmation avant de quitter l'application
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Me.Close()
            StartAppli.Show()
        End If
    End Sub
End Class
