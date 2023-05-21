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
        DgvTabScore.Columns.Add("PartiesJoueesEnTantQueNomJoueurQuiPropose", "Parties en tant que NomJoueurQuiPropose")
        DgvTabScore.Columns.Add("PartiesJoueesEnTantQueNomJoueurQuiJoue", "Parties en tant que NomJoueurQuiJoue")
        DgvTabScore.Columns.Add("TempsTotal", "Temps Total")

        ' Ajouter le DataGridView au formulaire
        Controls.Add(DgvTabScore)
    End Sub

    Private Sub FormTableauScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Lier les données du tableau des scores au DataGridView
        DgvTabScore.DataSource = Joueurs
    End Sub
End Class
