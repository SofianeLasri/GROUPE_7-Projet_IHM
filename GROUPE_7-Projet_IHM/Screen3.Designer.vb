<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screen3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Screen3))
        Me.leftSideBarPanel = New System.Windows.Forms.Panel()
        Me.RatiosListBox = New System.Windows.Forms.ListBox()
        Me.LeftSidebarSpecsLabel = New System.Windows.Forms.Label()
        Me.LeftSidebarTitleLabel = New System.Windows.Forms.Label()
        Me.refImagePic = New System.Windows.Forms.PictureBox()
        Me.contentTitleLbl = New System.Windows.Forms.Label()
        Me.ComparisonListView = New System.Windows.Forms.ListView()
        Me.pictureName = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.leftSideBarPanel.SuspendLayout()
        CType(Me.refImagePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftSideBarPanel
        '
        Me.leftSideBarPanel.Controls.Add(Me.RatiosListBox)
        Me.leftSideBarPanel.Controls.Add(Me.LeftSidebarSpecsLabel)
        Me.leftSideBarPanel.Controls.Add(Me.LeftSidebarTitleLabel)
        Me.leftSideBarPanel.Controls.Add(Me.refImagePic)
        Me.leftSideBarPanel.Location = New System.Drawing.Point(-1, 0)
        Me.leftSideBarPanel.Name = "leftSideBarPanel"
        Me.leftSideBarPanel.Size = New System.Drawing.Size(301, 594)
        Me.leftSideBarPanel.TabIndex = 0
        '
        'RatiosListBox
        '
        Me.RatiosListBox.FormattingEnabled = True
        Me.RatiosListBox.ItemHeight = 15
        Me.RatiosListBox.Location = New System.Drawing.Point(22, 349)
        Me.RatiosListBox.Name = "RatiosListBox"
        Me.RatiosListBox.Size = New System.Drawing.Size(256, 229)
        Me.RatiosListBox.TabIndex = 2
        '
        'LeftSidebarSpecsLabel
        '
        Me.LeftSidebarSpecsLabel.AutoSize = True
        Me.LeftSidebarSpecsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LeftSidebarSpecsLabel.Location = New System.Drawing.Point(14, 312)
        Me.LeftSidebarSpecsLabel.Name = "LeftSidebarSpecsLabel"
        Me.LeftSidebarSpecsLabel.Size = New System.Drawing.Size(168, 25)
        Me.LeftSidebarSpecsLabel.TabIndex = 1
        Me.LeftSidebarSpecsLabel.Text = "Caractéristiques"
        '
        'LeftSidebarTitleLabel
        '
        Me.LeftSidebarTitleLabel.AutoSize = True
        Me.LeftSidebarTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LeftSidebarTitleLabel.Location = New System.Drawing.Point(14, 22)
        Me.LeftSidebarTitleLabel.Name = "LeftSidebarTitleLabel"
        Me.LeftSidebarTitleLabel.Size = New System.Drawing.Size(127, 25)
        Me.LeftSidebarTitleLabel.TabIndex = 0
        Me.LeftSidebarTitleLabel.Text = "Votre image"
        '
        'refImagePic
        '
        Me.refImagePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.refImagePic.Image = Global.GROUPE_7_Projet_IHM.My.Resources.Resources.Emilie
        Me.refImagePic.Location = New System.Drawing.Point(22, 63)
        Me.refImagePic.Name = "refImagePic"
        Me.refImagePic.Size = New System.Drawing.Size(256, 230)
        Me.refImagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.refImagePic.TabIndex = 0
        Me.refImagePic.TabStop = False
        '
        'contentTitleLbl
        '
        Me.contentTitleLbl.AutoSize = True
        Me.contentTitleLbl.BackColor = System.Drawing.Color.Transparent
        Me.contentTitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.contentTitleLbl.ForeColor = System.Drawing.Color.White
        Me.contentTitleLbl.Location = New System.Drawing.Point(306, 22)
        Me.contentTitleLbl.Name = "contentTitleLbl"
        Me.contentTitleLbl.Size = New System.Drawing.Size(395, 25)
        Me.contentTitleLbl.TabIndex = 3
        Me.contentTitleLbl.Text = "Comparaisons avec visages enregistrés"
        '
        'ComparisonListView
        '
        Me.ComparisonListView.BackColor = System.Drawing.Color.Black
        Me.ComparisonListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.pictureName, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader1})
        Me.ComparisonListView.ForeColor = System.Drawing.Color.White
        Me.ComparisonListView.HideSelection = False
        Me.ComparisonListView.Location = New System.Drawing.Point(306, 63)
        Me.ComparisonListView.Name = "ComparisonListView"
        Me.ComparisonListView.Size = New System.Drawing.Size(803, 458)
        Me.ComparisonListView.TabIndex = 4
        Me.ComparisonListView.UseCompatibleStateImageBehavior = False
        Me.ComparisonListView.View = System.Windows.Forms.View.Details
        '
        'pictureName
        '
        Me.pictureName.Tag = ""
        Me.pictureName.Text = "Nom de L'image"
        Me.pictureName.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ratio lèvres"
        Me.ColumnHeader2.Width = 128
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Ratio Nez"
        Me.ColumnHeader3.Width = 128
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ratio Visage"
        Me.ColumnHeader4.Width = 128
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Ratio Yeux"
        Me.ColumnHeader5.Width = 128
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ressemblance (0 = 100%)"
        Me.ColumnHeader1.Width = 180
        '
        'Screen3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GROUPE_7_Projet_IHM.My.Resources.Resources.sfr_back
        Me.ClientSize = New System.Drawing.Size(1121, 594)
        Me.Controls.Add(Me.ComparisonListView)
        Me.Controls.Add(Me.contentTitleLbl)
        Me.Controls.Add(Me.leftSideBarPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Screen3"
        Me.Text = "Super Face Recognition"
        Me.leftSideBarPanel.ResumeLayout(False)
        Me.leftSideBarPanel.PerformLayout()
        CType(Me.refImagePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents leftSideBarPanel As Panel
    Friend WithEvents refImagePic As PictureBox
    Friend WithEvents LeftSidebarTitleLabel As Label
    Friend WithEvents LeftSidebarSpecsLabel As Label
    Friend WithEvents RatiosListBox As ListBox
    Friend WithEvents contentTitleLbl As Label
    Friend WithEvents ComparisonListView As ListView
    Friend WithEvents pictureName As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
