<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screen2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Screen2))
        Me.picSecondScreen1 = New System.Windows.Forms.PictureBox()
        Me.leftSideBarPanel = New System.Windows.Forms.Panel()
        Me.finishBtn = New System.Windows.Forms.Button()
        Me.saveNotesLbl = New System.Windows.Forms.Label()
        Me.saveNotesBtn = New System.Windows.Forms.Button()
        Me.loadNotesLbl = New System.Windows.Forms.Label()
        Me.loadNotesBtn = New System.Windows.Forms.Button()
        Me.DetailsListBox = New System.Windows.Forms.ListBox()
        Me.LeftSidebarDetailsLabel = New System.Windows.Forms.Label()
        Me.addNoteLabel = New System.Windows.Forms.Label()
        Me.addNoteButton = New System.Windows.Forms.Button()
        Me.LeftSidebarTitleLabel = New System.Windows.Forms.Label()
        CType(Me.picSecondScreen1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.leftSideBarPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'picSecondScreen1
        '
        Me.picSecondScreen1.BackColor = System.Drawing.Color.Transparent
        Me.picSecondScreen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picSecondScreen1.Image = CType(resources.GetObject("picSecondScreen1.Image"), System.Drawing.Image)
        Me.picSecondScreen1.Location = New System.Drawing.Point(494, 67)
        Me.picSecondScreen1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picSecondScreen1.Name = "picSecondScreen1"
        Me.picSecondScreen1.Size = New System.Drawing.Size(457, 407)
        Me.picSecondScreen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSecondScreen1.TabIndex = 5
        Me.picSecondScreen1.TabStop = False
        '
        'leftSideBarPanel
        '
        Me.leftSideBarPanel.Controls.Add(Me.finishBtn)
        Me.leftSideBarPanel.Controls.Add(Me.saveNotesLbl)
        Me.leftSideBarPanel.Controls.Add(Me.saveNotesBtn)
        Me.leftSideBarPanel.Controls.Add(Me.loadNotesLbl)
        Me.leftSideBarPanel.Controls.Add(Me.loadNotesBtn)
        Me.leftSideBarPanel.Controls.Add(Me.DetailsListBox)
        Me.leftSideBarPanel.Controls.Add(Me.LeftSidebarDetailsLabel)
        Me.leftSideBarPanel.Controls.Add(Me.addNoteLabel)
        Me.leftSideBarPanel.Controls.Add(Me.addNoteButton)
        Me.leftSideBarPanel.Controls.Add(Me.LeftSidebarTitleLabel)
        Me.leftSideBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.leftSideBarPanel.Name = "leftSideBarPanel"
        Me.leftSideBarPanel.Size = New System.Drawing.Size(301, 594)
        Me.leftSideBarPanel.TabIndex = 6
        '
        'finishBtn
        '
        Me.finishBtn.Location = New System.Drawing.Point(200, 559)
        Me.finishBtn.Name = "finishBtn"
        Me.finishBtn.Size = New System.Drawing.Size(75, 23)
        Me.finishBtn.TabIndex = 11
        Me.finishBtn.Text = "Terminé"
        Me.finishBtn.UseVisualStyleBackColor = True
        '
        'saveNotesLbl
        '
        Me.saveNotesLbl.AutoSize = True
        Me.saveNotesLbl.Location = New System.Drawing.Point(64, 184)
        Me.saveNotesLbl.Name = "saveNotesLbl"
        Me.saveNotesLbl.Size = New System.Drawing.Size(155, 15)
        Me.saveNotesLbl.TabIndex = 10
        Me.saveNotesLbl.Text = "Sauvegarder les annotations"
        '
        'saveNotesBtn
        '
        Me.saveNotesBtn.BackgroundImage = CType(resources.GetObject("saveNotesBtn.BackgroundImage"), System.Drawing.Image)
        Me.saveNotesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.saveNotesBtn.Location = New System.Drawing.Point(13, 169)
        Me.saveNotesBtn.Name = "saveNotesBtn"
        Me.saveNotesBtn.Size = New System.Drawing.Size(45, 45)
        Me.saveNotesBtn.TabIndex = 9
        Me.saveNotesBtn.UseVisualStyleBackColor = True
        '
        'loadNotesLbl
        '
        Me.loadNotesLbl.AutoSize = True
        Me.loadNotesLbl.Location = New System.Drawing.Point(64, 133)
        Me.loadNotesLbl.Name = "loadNotesLbl"
        Me.loadNotesLbl.Size = New System.Drawing.Size(136, 15)
        Me.loadNotesLbl.TabIndex = 8
        Me.loadNotesLbl.Text = "Charger des annotations"
        '
        'loadNotesBtn
        '
        Me.loadNotesBtn.BackgroundImage = CType(resources.GetObject("loadNotesBtn.BackgroundImage"), System.Drawing.Image)
        Me.loadNotesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.loadNotesBtn.Location = New System.Drawing.Point(13, 118)
        Me.loadNotesBtn.Name = "loadNotesBtn"
        Me.loadNotesBtn.Size = New System.Drawing.Size(45, 45)
        Me.loadNotesBtn.TabIndex = 7
        Me.loadNotesBtn.UseVisualStyleBackColor = True
        '
        'DetailsListBox
        '
        Me.DetailsListBox.BackColor = System.Drawing.SystemColors.Window
        Me.DetailsListBox.FormattingEnabled = True
        Me.DetailsListBox.ItemHeight = 15
        Me.DetailsListBox.Location = New System.Drawing.Point(13, 278)
        Me.DetailsListBox.Name = "DetailsListBox"
        Me.DetailsListBox.Size = New System.Drawing.Size(262, 274)
        Me.DetailsListBox.TabIndex = 4
        '
        'LeftSidebarDetailsLabel
        '
        Me.LeftSidebarDetailsLabel.AutoSize = True
        Me.LeftSidebarDetailsLabel.Font = New System.Drawing.Font("Raleway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LeftSidebarDetailsLabel.Location = New System.Drawing.Point(12, 237)
        Me.LeftSidebarDetailsLabel.Name = "LeftSidebarDetailsLabel"
        Me.LeftSidebarDetailsLabel.Size = New System.Drawing.Size(276, 25)
        Me.LeftSidebarDetailsLabel.TabIndex = 3
        Me.LeftSidebarDetailsLabel.Text = "Détails des caractéristiques"
        '
        'addNoteLabel
        '
        Me.addNoteLabel.AutoSize = True
        Me.addNoteLabel.Location = New System.Drawing.Point(64, 82)
        Me.addNoteLabel.Name = "addNoteLabel"
        Me.addNoteLabel.Size = New System.Drawing.Size(130, 15)
        Me.addNoteLabel.TabIndex = 2
        Me.addNoteLabel.Text = "Ajouter une annotation"
        '
        'addNoteButton
        '
        Me.addNoteButton.BackgroundImage = Global.GROUPE_7_Projet_IHM.My.Resources.Resources.add
        Me.addNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addNoteButton.Location = New System.Drawing.Point(13, 67)
        Me.addNoteButton.Name = "addNoteButton"
        Me.addNoteButton.Size = New System.Drawing.Size(45, 45)
        Me.addNoteButton.TabIndex = 1
        Me.addNoteButton.UseVisualStyleBackColor = True
        '
        'LeftSidebarTitleLabel
        '
        Me.LeftSidebarTitleLabel.AutoSize = True
        Me.LeftSidebarTitleLabel.Font = New System.Drawing.Font("Raleway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LeftSidebarTitleLabel.Location = New System.Drawing.Point(12, 21)
        Me.LeftSidebarTitleLabel.Name = "LeftSidebarTitleLabel"
        Me.LeftSidebarTitleLabel.Size = New System.Drawing.Size(263, 25)
        Me.LeftSidebarTitleLabel.TabIndex = 0
        Me.LeftSidebarTitleLabel.Text = "Caractéristiques du visage"
        '
        'Screen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1121, 594)
        Me.Controls.Add(Me.leftSideBarPanel)
        Me.Controls.Add(Me.picSecondScreen1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Screen2"
        Me.Text = "Super Face Recognition"
        CType(Me.picSecondScreen1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.leftSideBarPanel.ResumeLayout(False)
        Me.leftSideBarPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picSecondScreen1 As PictureBox
    Friend WithEvents leftSideBarPanel As Panel
    Friend WithEvents LeftSidebarTitleLabel As Label
    Friend WithEvents addNoteButton As Button
    Friend WithEvents addNoteLabel As Label
    Friend WithEvents LeftSidebarDetailsLabel As Label
    Friend WithEvents DetailsListBox As ListBox
    Friend WithEvents loadNotesLbl As Label
    Friend WithEvents loadNotesBtn As Button
    Friend WithEvents saveNotesLbl As Label
    Friend WithEvents saveNotesBtn As Button
    Friend WithEvents finishBtn As Button
End Class
