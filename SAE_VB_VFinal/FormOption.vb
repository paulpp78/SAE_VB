Imports System.Drawing
Imports System.Windows.Forms

Public Class FormOption
    Private Sub ChkLimiteTemps_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLimiteTemps.CheckedChanged
        ModuleOptionsDeJeu.GérerLimiteTemps(ChkLimiteTemps.Checked)
    End Sub

    Private Sub TxtCaracteres_TextChanged(sender As Object, e As EventArgs) Handles TxtCaracteres.TextChanged
        ModuleOptionsDeJeu.GérerModificationCaracteres(TxtCaracteres.Text)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        ModuleOptionsDeJeu.GérerModificationLimitePropositions(CInt(NumericUpDown1.Value))
    End Sub



    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles BtnCouleurAbsent.Click, BtnCouleurPresent.Click, BtnCouleurBienPlace.Click
        Dim colorButton As Button = CType(sender, Button)
        ModuleOptionsDeJeu.GérerCouleurAction(colorButton)
    End Sub


    Private Sub TxtCheminSauvegarde_TextChanged(sender As Object, e As EventArgs) Handles TxtCheminSauvegarde.TextChanged
        ModuleOptionsDeJeu.CheminFichier1 = TxtCheminSauvegarde.Text
    End Sub



    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ModuleOptionsDeJeu.EnregistrerOptions()
        MessageBox.Show("Les options ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
