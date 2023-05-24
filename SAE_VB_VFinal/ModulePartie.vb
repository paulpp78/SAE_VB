Imports System.Windows.Forms

Module ModulePartie

    Private combinaison As String

    Public Function GetCombinaison() As String
        Return combinaison
    End Function
    Public Sub SetCombinaison(combi As String)
        combinaison = combi
    End Sub

    Sub Main()
        Dim formAccueil As New FormStartAppli()
        Application.Run(formAccueil)
    End Sub
End Module
