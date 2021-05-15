Public Class Screen2
    Private Sub Screen2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On a pas fait dispose ou close car ça stop le programme
        formMainScreen.Hide()
        LeftSidebarTitleLabel.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.Roboto-Regular.ttf", 16, FontStyle.Regular)
        LeftSidebarDetailsLabel.Font = useFont.LoadFont(Me.GetType.Assembly, "GROUPE_7_Projet_IHM.Roboto-Regular.ttf", 16, FontStyle.Regular)
    End Sub

    'Permet d'éviter que l'utilisateur ferme sans faire exprès, mais également à fermer la form1 qui reste active vu qu'elle n'est que cachée
    Private Sub Screen2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Êtes-vous sûr de vouloir quitter?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Screen1.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    'Permet de bouger la croix rouge française
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub addNoteButton_Click(sender As Object, e As EventArgs) Handles addNoteButton.Click
        GiveNameAlert.Show()
    End Sub

    Public Function addNote(Name As String)
        Dim pb As New PictureBox
        AddHandler pb.MouseDown, AddressOf pb_MouseDown
        AddHandler pb.MouseMove, AddressOf pb_MouseMove
        AddHandler pb.MouseUp, AddressOf pb_MouseUp
        pb.Width = 30 'or whatever
        pb.Height = 30
        pb.Top = 270 'or whatever
        pb.Left = 600
        pb.Image = My.Resources.close

        pb.Cursor = Cursors.Hand
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        pb.Name = Name

        Me.Controls.Add(pb)
        pb.BringToFront()


        'On a joute le détail du point dans la liste
        DetailsListBox.Items.Add(Name)
    End Function

    Private Sub pb_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
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
    End Sub

End Class