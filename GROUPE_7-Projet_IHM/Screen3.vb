Public Class Screen3
    'Cette fois-ci on met les variables tout en haut car la fenêtre va calculer les ratios à son ouverture
    Dim ratios(8) As Single 'L'ordre est celui du sujet -> commence par ratioLèvres et se termine par largeurYeux
    Public Annotations(11, 3) As String 'shortAlias, x, y
    Public AnnotationsAliases = New String() {
    "Oeil gauche",
    "Oeil droit",
    "Bord du visage gauche",
    "Bord du visage droite",
    "Bas du nez",
    "Bord gauche du nez",
    "Bord droit du nez",
    "Bas du menton",
    "Haut des lèvres",
    "Bas des lèvres",
    "Bord gauche des lèvres",
    "Bord droit des lèvres"
    }
    Dim AnnotationsShortAliases = New String() {
    "Y1",'0
    "Y2",'1
    "BVG",'2
    "BVD",'3
    "BN",'4
    "BNG",'5
    "BND",'6
    "BM",'7
    "LH",'8
    "BL",'9
    "LG",'10
    "LD"'11
    }

    Private Sub Screen3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Encore et toujours ces polices d'écritures, il faut quand même admettre que ça rend bien
        LeftSidebarTitleLabel.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.Roboto-Regular.ttf", 16, FontStyle.Regular)
        LeftSidebarSpecsLabel.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.Roboto-Regular.ttf", 16, FontStyle.Regular)
        contentTitleLbl.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.HelvNeue75_W1G.ttf", 16, FontStyle.Bold)

        'Ratiolèvre = hauteurlèvre / largeurlèvre
        ratios(0) = ((Annotations(9, 2)) - (Annotations(8, 2)) / (Annotations(11, 1)) - (Annotations(10, 1)))
        RatiosListBox.Items.Add("Ratio lèvres: " + ratios(0).ToString)

        'Rationez = hauteurnez / largeurnez -> on va prendre un oeuil au pif pour la hauteur du nez (:
        '(on considère que la personne est normalement constituée avec des yeux à la même hauteur
        'nan pas de picasso, même le bossu de notre dame a les yeux alignés x)
        ratios(1) = ((Annotations(4, 2)) - (Annotations(0, 2)) / (Annotations(6, 1)) - (Annotations(5, 1)))
        RatiosListBox.Items.Add("Ratio nez: " + ratios(1).ToString)

        'Ratiovisage = hauteurvisage / largeurvisage
        ratios(2) = ((Annotations(7, 2)) - (Annotations(0, 2)) / (Annotations(3, 1)) - (Annotations(2, 1)))
        RatiosListBox.Items.Add("Ratio visage: " + ratios(2).ToString)

        'Ratioyeux = largeurvisage / largeuryeux
        ratios(3) = ((Annotations(3, 1)) - (Annotations(2, 1)) / (Annotations(1, 1)) - (Annotations(0, 1)))
        RatiosListBox.Items.Add("Ratio yeux: " + ratios(3).ToString)




        'On va chercher tous les fichiers csv enregistrés pour comparer les images

        'On déclare les variables
        Dim NewAnnotations(12, 3) As String
        Dim TempAnnotations(11, 3) As String
        Dim currentField As String
        Dim currentRow As String()
        Dim index As Integer
        Dim index2 As Integer

        Dim indexCount As Integer


        'On cherche
        For Each foundFile As String In My.Computer.FileSystem.GetFiles("Resource\")
            'On réinitialise les variables
            index = 0
            index2 = 0
            ReDim NewAnnotations(12, 3)
            ReDim TempAnnotations(11, 3)

            If (System.IO.Path.GetExtension(foundFile) = ".csv") Then
                'On va reprendre le code d'importation du Screen 2
                'Il sera très légèrement modifié pour que l'on puisse l'executer plusieurs fois
                Using ImportedNotes As New Microsoft.VisualBasic.FileIO.TextFieldParser(foundFile)
                    ImportedNotes.TextFieldType = FileIO.FieldType.Delimited
                    ImportedNotes.SetDelimiters(",")

                    'On lit chaque item
                    While Not ImportedNotes.EndOfData
                        Try
                            currentRow = ImportedNotes.ReadFields()

                            'On est à l'initialisation du code
                            If (index = 0) Then
                                indexCount = currentRow.Length
                                'On redéclare le tableau en fonction de la taille de la ligne
                                ReDim NewAnnotations(indexCount, 3)
                            End If
                            'currentRow est une liste contenant les valeurs
                            'La première ligne contient le nom des variables
                            For Each currentField In currentRow
                                If (index < indexCount) Then
                                    'Donc on va regarder si le nom de la colonne correspond à un index connu
                                    'Comme ça ont va associer les numéros d'index à ceux que l'on a déjà

                                    index2 = 0
                                    'MsgBox("index: " + index.ToString)
                                    'MsgBox(TempAnnotations)
                                    For Each AnnotationsShortAlias In AnnotationsShortAliases
                                        'Donc pour chaque alias, on va check si le nom de la colonne correspond partiellement à ce dernier (car on .x et .y)
                                        If (currentField.Contains(AnnotationsShortAlias.ToString)) Then
                                            'MsgBox(currentField + " contient " + AnnotationsShortAlias)
                                            TempAnnotations(index2, 0) = AnnotationsShortAlias


                                            'NewAnnotations sert d'alias pour les vraies annotations. On stock les index corrigé dans la 3ème ligne
                                            NewAnnotations(index, 2) = index2
                                        End If
                                        index2 = index2 + 1
                                    Next

                                    'On note le nom de la colonne dans la liste NewAnnotations
                                    NewAnnotations(index, 0) = currentField

                                Else
                                    'Ici on n'est plus sur la première ligne
                                    'En théorie il n'y a que deux lignes

                                    'On met la valeur de la colonne dans la ligne n°2
                                    NewAnnotations(index - indexCount, 1) = currentField
                                    'MsgBox("On est dans les donnée, je contient x/y: " + NewAnnotations(index - indexCount, 0) + " . Ma valeur est: " + currentField)

                                    If NewAnnotations(index - indexCount, 0).Contains(".x") Then
                                        TempAnnotations(NewAnnotations(index - indexCount, 2), 1) = currentField
                                    ElseIf NewAnnotations(index - indexCount, 0).Contains(".y") Then
                                        TempAnnotations(NewAnnotations(index - indexCount, 2), 2) = currentField
                                    End If

                                End If
                                index = index + 1
                            Next
                        Catch ex As Microsoft.VisualBasic.
                                        FileIO.MalformedLineException
                            MsgBox("Line " & ex.Message &
                                "is not valid and will be skipped.")
                        End Try
                    End While
                End Using
                'Fin du code d'importation
            End If

            'On ajoute ça au tableau
            If (Not String.IsNullOrEmpty(NewAnnotations(0, 1))) Then
                Dim arr As String() = New String(7) {}
                Dim itm As ListViewItem
                'add items to ListView
                arr(0) = NewAnnotations(0, 1)

                'Ratiolèvre = hauteurlèvre / largeurlèvre
                arr(1) = CSng(((TempAnnotations(9, 2)) - (TempAnnotations(8, 2)) / (TempAnnotations(11, 1)) - (TempAnnotations(10, 1))))

                'Rationez = hauteurnez / largeurnez
                arr(2) = CSng(((TempAnnotations(4, 2)) - (TempAnnotations(0, 2)) / (TempAnnotations(6, 1)) - (TempAnnotations(5, 1))))

                'Ratiovisage = hauteurvisage / largeurvisage
                arr(3) = CSng(((TempAnnotations(7, 2)) - (TempAnnotations(0, 2)) / (TempAnnotations(3, 1)) - (TempAnnotations(2, 1))))

                'Ratioyeux = largeurvisage / largeuryeux
                arr(4) = CSng(((TempAnnotations(3, 1)) - (TempAnnotations(2, 1)) / (TempAnnotations(1, 1)) - (TempAnnotations(0, 1))))


                arr(5) = (ratios(0) - CSng(arr(1))) ^ 2 + (ratios(1) - CSng(arr(2))) ^ 2 + (ratios(2) - CSng(arr(3))) ^ 2 + (ratios(3) - CSng(arr(4))) ^ 2
                itm = New ListViewItem(arr)
                ComparisonListView.Items.Add(itm)
            End If

            'Note à propos du tableau:
            'Je suis un peu déçu car j'aurais aimé mettre une prévisualisation des images en question. :(


        Next

    End Sub

    Private Sub Screen2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Play(My.Resources.notif, AudioPlayMode.Background)
        If MessageBox.Show("Êtes-vous sûr de vouloir quitter?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            formMainScreen.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
End Class