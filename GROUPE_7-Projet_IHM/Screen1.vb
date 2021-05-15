Public Class formMainScreen
    Inherits System.Windows.Forms.Form
    Public secondScreen As Screen2
    Private Sub formMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On utilise des polices d'écritures personnalisées, du coup on utilise une fonction créée dans un module
        lblSendImage.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.HelvNeue75_W1G.ttf", 14, FontStyle.Bold)
        btnMainScreen.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.HelvNeue75_W1G.ttf", 14, FontStyle.Bold)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picMainScreen1.Click

    End Sub

    Private Sub btnMainScreen_Click(sender As Object, e As EventArgs) Handles btnMainScreen.Click
        If (Not System.IO.Directory.Exists("Resource")) Then
            System.IO.Directory.CreateDirectory("Resource")
        End If


        Dim OpenFileDialog1 As New OpenFileDialog
        With OpenFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|.|Bitmap Files ()|*.bmp;*.gif;*.jpg;*.png"
            .FilterIndex = 2

            '
            If .ShowDialog = DialogResult.OK Then
                Dim FName() As String = OpenFileDialog1.FileName.Split("\")

                If My.Computer.FileSystem.FileExists("Resource\" + FName(FName.Length - 1)) Then
                    ExistingFileAlert.setFileName(FName(FName.Length - 1), OpenFileDialog1.FileName)
                    ExistingFileAlert.Show()
                Else
                    System.IO.File.Copy(OpenFileDialog1.FileName, "Resource\" + FName(FName.Length - 1))
                    Screen2.picSecondScreen1.Image = Image.FromFile(.FileName)
                    Screen2.Show()
                End If


            End If
        End With
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblSendImage.Click

    End Sub
End Class
