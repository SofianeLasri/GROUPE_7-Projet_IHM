Public Class Screen2
    Private Sub Screen2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On a pas fait dispose ou close car ça stop le programme
        formMainScreen.Hide()
        LeftSidebarTitleLabel.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.Roboto-Regular.ttf", 16, FontStyle.Regular)
        LeftSidebarDetailsLabel.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.Roboto-Regular.ttf", 16, FontStyle.Regular)
    End Sub

    'Permet d'éviter que l'utilisateur ferme sans faire exprès, mais également à fermer la form1 qui reste active vu qu'elle n'est que cachée
    Private Sub Screen2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Play(My.Resources.notif, AudioPlayMode.Background)
        If MessageBox.Show("Êtes-vous sûr de vouloir quitter?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            formMainScreen.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    'Permet de bouger la croix rouge française
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    'Liste des points que l'on exportera
    Public Annotations(11, 3) As String
    Public AnnotationsAliases = New String() {
    "Oeil 1",
    "Oeil 2",
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
    "Y1",
    "Y2",
    "BVD",
    "BVD",
    "BN",
    "BNG",
    "BND",
    "BM",
    "LH",
    "BL",
    "LG",
    "LD"
    }
    'Aliases nous permettra de savoir à quel rang appartient tel ou tel point
    'Il est vraiment horrible le système de liste de VB...

    Private Sub addNoteButton_Click(sender As Object, e As EventArgs) Handles addNoteButton.Click
        GiveNameAlert.Show()
    End Sub

    Public Function addNote(id As Integer)
        If (String.IsNullOrEmpty(Annotations(id, 0))) Then
            Dim pb As New PictureBox
            AddHandler pb.MouseDown, AddressOf pb_MouseDown
            AddHandler pb.MouseMove, AddressOf pb_MouseMove
            AddHandler pb.MouseUp, AddressOf pb_MouseUp
            pb.Width = 30 'or whatever
            pb.Height = 30
            pb.Top = 270 'or whatever
            pb.Left = 600
            pb.Image = My.Resources.close
            pb.BackColor = Color.Transparent

            pb.Cursor = Cursors.Hand
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Name = Name

            Me.Controls.Add(pb)
            pb.BringToFront()

            'On a joute le détail du point dans la liste
            DetailsListBox.Items.Add(AnnotationsAliases(id))
            pb.Tag = id
            Annotations(id, 0) = AnnotationsShortAliases(id)
            Annotations(id, 1) = picSecondScreen1.Location.X - 600 'x
            Annotations(id, 2) = picSecondScreen1.Location.Y - 270 'y
        Else
            My.Computer.Audio.Play(My.Resources.notif, AudioPlayMode.Background)
            MsgBox("Ce détail a déjà été ajouté")
        End If

    End Function

    Private Sub pb_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        DetailsListBox.SetSelected(sender.Tag, True)
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - sender.Left
        mousey = Windows.Forms.Cursor.Position.Y - sender.Top
    End Sub
    Private Sub pb_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If drag Then
            sender.Top = Windows.Forms.Cursor.Position.Y - mousey
            sender.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub pb_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        drag = False
        Annotations(sender.Tag, 1) = sender.Left - picSecondScreen1.Location.X 'x
        Annotations(sender.Tag, 2) = sender.Top - picSecondScreen1.Location.Y 'y
    End Sub

    Private Sub saveNotesBtn_Click(sender As Object, e As EventArgs) Handles saveNotesBtn.Click
        Dim Line1 As String
        Line1 = "imagefile,"
        Dim Line2 As String
        Line2 = picSecondScreen1.Tag + ","
        For i As Integer = 0 To 11
            Line1 = Line1 + Annotations(i, 0) + ".x," + Annotations(i, 0) + ".y,"
            Line2 = Line2 + Annotations(i, 1) + "," + Annotations(i, 2) + ","
        Next

        Dim exportPath As String
        Dim dialog As New FolderBrowserDialog()
        Dim file As System.IO.StreamWriter
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Selectionnez un dossier de destination pour l'exportation des annotations"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            exportPath = dialog.SelectedPath
        End If

        If My.Computer.FileSystem.FileExists("Resource\" + picSecondScreen1.Tag + ".csv") Then
            'On supprime le fichier qui existe déjà
            IO.File.Delete("Resource\" + picSecondScreen1.Tag + ".csv")
        End If

        file = My.Computer.FileSystem.OpenTextFileWriter("Resource\" + picSecondScreen1.Tag + ".csv", True)
        file.WriteLine(Line1)
        file.WriteLine(Line2)
        file.Close()

        If My.Computer.FileSystem.FileExists(exportPath + "\" + picSecondScreen1.Tag + ".csv") Then
            ExistingFileAlert.setMode(1)
            ExistingFileAlert.setFileName(picSecondScreen1.Tag + ".csv", exportPath + "\" + picSecondScreen1.Tag + ".csv")
            ExistingFileAlert.Show()
        Else
            file = My.Computer.FileSystem.OpenTextFileWriter(exportPath + "\" + picSecondScreen1.Tag + ".csv", True)
            file.WriteLine(Line1)
            file.WriteLine(Line2)
            file.Close()
        End If


    End Sub

    Private Sub loadNotesBtn_Click(sender As Object, e As EventArgs) Handles loadNotesBtn.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        With OpenFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "Fichiers csv|*.csv"
            .FilterIndex = 2

            '
            If .ShowDialog = DialogResult.OK Then
                Dim FName() As String = OpenFileDialog1.FileName.Split("\")

                If My.Computer.FileSystem.FileExists("Resource\" + FName(FName.Length - 1)) Then
                    IO.File.Delete("Resource\" + FName(FName.Length - 1))
                End If

                System.IO.File.Copy(OpenFileDialog1.FileName, "Resource\" + FName(FName.Length - 1))
                Using ImportedNotes As New Microsoft.VisualBasic.FileIO.TextFieldParser("Resource\" + FName(FName.Length - 1))
                    ImportedNotes.TextFieldType = FileIO.FieldType.Delimited
                    ImportedNotes.SetDelimiters(",")

                    Dim currentRow As String()
                    Dim index As Integer
                    Dim index2 As Integer
                    index = 0
                    Dim indexCount As Integer
                    'On déclare un tableau temporaire
                    Dim NewAnnotations(12, 3) As String

                    'On lit chaque item
                    While Not ImportedNotes.EndOfData
                        Try
                            currentRow = ImportedNotes.ReadFields()
                            Dim currentField As String
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
                                    For Each AnnotationsShortAlias In AnnotationsShortAliases
                                        'Donc pour chaque alias, on va check si le nom de la colonne correspond partiellement à ce dernier (car on .x et .y)
                                        If (currentField.Contains(AnnotationsShortAlias.ToString)) Then
                                            'MsgBox(currentField + " contient " + AnnotationsShortAlias)
                                            Annotations(index2, 0) = AnnotationsShortAlias
                                            'MsgBox(Annotations(index2, 0))

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
                                        Annotations(NewAnnotations(index - indexCount, 2), 1) = currentField
                                    ElseIf NewAnnotations(index - indexCount, 0).Contains(".y") Then
                                        Annotations(NewAnnotations(index - indexCount, 2), 2) = currentField
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

                'On créé les points
                For index3 As Integer = 0 To 11
                    'MsgBox("Anotation " + index3.ToString)

                    Dim pb As New PictureBox
                    AddHandler pb.MouseDown, AddressOf pb_MouseDown
                    AddHandler pb.MouseMove, AddressOf pb_MouseMove
                    AddHandler pb.MouseUp, AddressOf pb_MouseUp
                    pb.Width = 30 'or whatever
                    pb.Height = 30
                    pb.Top = picSecondScreen1.Location.Y + (Annotations(index3, 2))
                    pb.Left = picSecondScreen1.Location.X + (Annotations(index3, 1))
                    pb.Image = My.Resources.close
                    pb.BackColor = Color.Transparent

                    pb.Cursor = Cursors.Hand
                    pb.SizeMode = PictureBoxSizeMode.StretchImage
                    pb.Name = Name

                    Me.Controls.Add(pb)
                    pb.BringToFront()

                    'On a joute le détail du point dans la liste
                    DetailsListBox.Items.Add(AnnotationsAliases(index3))
                    pb.Tag = index3
                Next


            End If
        End With
    End Sub

    Private Sub finishBtn_Click(sender As Object, e As EventArgs) Handles finishBtn.Click
        MsgBox(picSecondScreen1.Tag)
    End Sub
End Class