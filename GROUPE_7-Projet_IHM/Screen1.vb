Public Class formMainScreen
    Inherits System.Windows.Forms.Form
    Private Sub formMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On utilise des polices d'écritures personnalisées, du coup on utilise une fonction créée dans un module
        lblSendImage.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.HelvNeue75_W1G.ttf", 14, FontStyle.Bold)
        btnMainScreen.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.HelvNeue75_W1G.ttf", 14, FontStyle.Bold)
    End Sub

    Private Sub btnMainScreen_Click(sender As Object, e As EventArgs) Handles btnMainScreen.Click
        'Nous créons un dossier Resource où nous irons copier et récupérer les données
        If (Not System.IO.Directory.Exists("Resource")) Then
            System.IO.Directory.CreateDirectory("Resource")
        End If

        'Ici nous ouvrons l'explorateur Oindose pour sélectionner une image
        Dim OpenFileDialog1 As New OpenFileDialog
        With OpenFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "Tous les fichiers|*|Fichiers images|*.bmp;*.gif;*.jpg;*.png"
            .FilterIndex = 2

            '
            If .ShowDialog = DialogResult.OK Then
                Dim FName() As String = OpenFileDialog1.FileName.Split("\")

                'Si l'image existe déjà dans le dossier ressource, nous allons demander à l'utilisateur s'il souhaite la remplacer ou non
                'On ne sait jamais, des fois qu'il ai fait des modifications
                If My.Computer.FileSystem.FileExists("Resource\" + FName(FName.Length - 1)) Then
                    'Le mode 0 correspond à l'importation et au remplacement de l'image du second écran.
                    'VOIR Form en question
                    ExistingFileAlert.setMode(0)
                    ExistingFileAlert.setFileName(FName(FName.Length - 1), OpenFileDialog1.FileName)
                    ExistingFileAlert.Show()
                Else
                    'Nous copions l'image dans le dossier ressource vu qu'elle n'y était pas
                    System.IO.File.Copy(OpenFileDialog1.FileName, "Resource\" + FName(FName.Length - 1))
                    Screen2.picSecondScreen1.Image = Image.FromFile(.FileName)
                    Screen2.Show()
                End If


            End If
        End With
    End Sub
End Class
