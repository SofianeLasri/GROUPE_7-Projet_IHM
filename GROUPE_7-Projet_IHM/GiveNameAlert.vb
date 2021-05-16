Public Class GiveNameAlert
    'C'est vraiment un projet passionnant avec un langage absolument génial
    Private Sub GiveNameAlert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On utilise des polices d'écritures personnalisées, du coup on utilise une fonction créée dans un module
        btnCancel.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.HelvNeue75_W1G.ttf", 12, FontStyle.Bold)
        btnCreateDetail.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.HelvNeue75_W1G.ttf", 12, FontStyle.Bold)
        lblAlertGiveName.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.Roboto-Regular.ttf", 16, FontStyle.Regular)
        My.Computer.Audio.Play(My.Resources.notice, AudioPlayMode.Background)
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

    Private Sub btnAlertExistingFileKeep_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Dispose()

    End Sub

    Private Sub btnAlertExistingFileReplace_Click(sender As Object, e As EventArgs) Handles btnCreateDetail.Click
        If (String.IsNullOrEmpty(DetailComboBox.SelectedItem)) Then
            My.Computer.Audio.Play(My.Resources.notif, AudioPlayMode.Background)
            MsgBox("Veuillez donner un nom")
        Else
            Screen2.addNote(DetailComboBox.SelectedIndex)
            Me.Dispose()
        End If

    End Sub
End Class