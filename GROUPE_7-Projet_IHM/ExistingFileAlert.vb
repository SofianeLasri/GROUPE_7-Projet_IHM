Public Class ExistingFileAlert
    Private Sub ExistingFileAlert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On utilise des polices d'écritures personnalisées, du coup on utilise une fonction créée dans un module
        btnAlertExistingFileKeep.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.HelvNeue75_W1G.ttf", 12, FontStyle.Bold)
        btnAlertExistingFileReplace.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.HelvNeue75_W1G.ttf", 12, FontStyle.Bold)
        lblAlertExistingFileTitle.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.Roboto-Regular.ttf", 16, FontStyle.Regular)
        lblAlertExistingFileDescription.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.Roboto-Regular.ttf", 12, FontStyle.Regular)

        'Nous avons décidé d'émettre un son car il se peut que la fenêtre se cache quelque part, et que l'utilisateur ne remarque pas son ouverture
        My.Computer.Audio.Play(My.Resources.notice, AudioPlayMode.Background)
    End Sub

    'Permet de bouger la fênetre vu qu'elle ne dispose pas de bordure
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        'Permet de récupérer la position relative de la souris
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'Permet de bouger la fenêtre en fonction de la souris
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    'Fin du code pour bouger la fenêtre

    'Permet de savoir quel fichier est à remplacer ou non
    Dim FileName As String
    Dim SourceFile As String

    'Mode pour savoir quelle est la tâche à effectuer -> on appel cette forme dans 2 cas différents
    Dim Mode As Integer '1 = remplace image de screen2, 2 = remplace juste le fichier

    'Nous aurions pu nous passer de cette fonction setFilename, plus-tard nous avons vu que nous pouvions directement appeler des variables d'autres forms
    Public Function setFileName(Name As String, File As String)
        FileName = Name
        SourceFile = File
    End Function

    'Idem
    Public Function setMode(useMode As Integer)
        Mode = useMode
    End Function


    Private Sub btnAlertExistingFileKeep_Click(sender As Object, e As EventArgs) Handles btnAlertExistingFileKeep.Click
        If (Mode = 0) Then
            'On remplace simplement le fichier
            Screen2.picSecondScreen1.Image = Image.FromFile("Resource\" + FileName)
            Screen2.picSecondScreen1.Tag = FileName

            Screen2.Show()
            formMainScreen.Hide()
        End If
        'Et bah nan pas de else finalement :D
        Me.Dispose()

    End Sub

    Private Sub btnAlertExistingFileReplace_Click(sender As Object, e As EventArgs) Handles btnAlertExistingFileReplace.Click
        'On supprime le fichier qui existe déjà
        If (Mode = 0) Then
            IO.File.Delete("Resource\" + FileName)
            'Et on execute le code permettant de copier le fichier et de l'utiliser sur l'écran suivant
            System.IO.File.Copy(SourceFile, "Resource\" + FileName)
            Screen2.picSecondScreen1.Image = Image.FromFile("Resource\" + FileName)
            'On met son nom dans son tag, ça nous servira plus-tard
            Screen2.picSecondScreen1.Tag = FileName

            formMainScreen.Hide()
            Screen2.Show()
        ElseIf (Mode = 1) Then
            'On supprime et on remplace
            IO.File.Delete(SourceFile)
            System.IO.File.Copy("Resource\" + FileName, SourceFile)
        End If
        Me.Dispose()
    End Sub
End Class