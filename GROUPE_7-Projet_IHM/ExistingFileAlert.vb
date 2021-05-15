Public Class ExistingFileAlert
    Private Sub ExistingFileAlert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On utilise des polices d'écritures personnalisées, du coup on utilise une fonction créée dans un module
        btnAlertExistingFileKeep.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.HelvNeue75_W1G.ttf", 12, FontStyle.Bold)
        btnAlertExistingFileReplace.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.HelvNeue75_W1G.ttf", 12, FontStyle.Bold)
        lblAlertExistingFileTitle.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.Roboto-Regular.ttf", 16, FontStyle.Regular)
        lblAlertExistingFileDescription.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.Roboto-Regular.ttf", 12, FontStyle.Regular)
    End Sub

    'Permet de bouger la fênetre vu qu'elle ne dispose pas de bordure
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
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
    Public Function setFileName(Name As String, File As String)
        FileName = Name
        SourceFile = File
    End Function

    Private Sub btnAlertExistingFileKeep_Click(sender As Object, e As EventArgs) Handles btnAlertExistingFileKeep.Click
        'On remplace simplement
        Screen2.picSecondScreen1.Image = Image.FromFile("Resource\" + FileName)

        Screen2.Show()
        formMainScreen.Hide()
        Me.Dispose()

    End Sub

    Private Sub btnAlertExistingFileReplace_Click(sender As Object, e As EventArgs) Handles btnAlertExistingFileReplace.Click
        'On supprime le fichier qui existe déjà
        IO.File.Delete("Resource\" + FileName)
        'Et on execute le code permettant de copier le fichier et de l'utiliser sur l'écran suivant
        System.IO.File.Copy(SourceFile, "Resource\" + FileName)
        Screen2.picSecondScreen1.Image = Image.FromFile("Resource\" + FileName)

        formMainScreen.Hide()
        Screen2.Show()
        Me.Dispose()

    End Sub
End Class