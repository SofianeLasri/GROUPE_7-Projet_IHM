<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExistingFileAlert
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExistingFileAlert))
        Me.lblAlertExistingFileTitle = New System.Windows.Forms.Label()
        Me.lblAlertExistingFileDescription = New System.Windows.Forms.Label()
        Me.btnAlertExistingFileReplace = New System.Windows.Forms.Button()
        Me.btnAlertExistingFileKeep = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAlertExistingFileTitle
        '
        Me.lblAlertExistingFileTitle.AutoSize = True
        Me.lblAlertExistingFileTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAlertExistingFileTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblAlertExistingFileTitle.Location = New System.Drawing.Point(24, 18)
        Me.lblAlertExistingFileTitle.Name = "lblAlertExistingFileTitle"
        Me.lblAlertExistingFileTitle.Size = New System.Drawing.Size(213, 26)
        Me.lblAlertExistingFileTitle.TabIndex = 1
        Me.lblAlertExistingFileTitle.Text = "Image déjà existante"
        '
        'lblAlertExistingFileDescription
        '
        Me.lblAlertExistingFileDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAlertExistingFileDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblAlertExistingFileDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAlertExistingFileDescription.Location = New System.Drawing.Point(24, 52)
        Me.lblAlertExistingFileDescription.Name = "lblAlertExistingFileDescription"
        Me.lblAlertExistingFileDescription.Size = New System.Drawing.Size(416, 52)
        Me.lblAlertExistingFileDescription.TabIndex = 2
        Me.lblAlertExistingFileDescription.Text = "L'image que vous essayer d'importer existe déjà. Souhaitez-vous la remplacer?"
        '
        'btnAlertExistingFileReplace
        '
        Me.btnAlertExistingFileReplace.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnAlertExistingFileReplace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlertExistingFileReplace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnAlertExistingFileReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAlertExistingFileReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlertExistingFileReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAlertExistingFileReplace.Location = New System.Drawing.Point(332, 118)
        Me.btnAlertExistingFileReplace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAlertExistingFileReplace.Name = "btnAlertExistingFileReplace"
        Me.btnAlertExistingFileReplace.Size = New System.Drawing.Size(139, 32)
        Me.btnAlertExistingFileReplace.TabIndex = 6
        Me.btnAlertExistingFileReplace.Text = "Remplacer"
        Me.btnAlertExistingFileReplace.UseVisualStyleBackColor = False
        '
        'btnAlertExistingFileKeep
        '
        Me.btnAlertExistingFileKeep.BackColor = System.Drawing.Color.White
        Me.btnAlertExistingFileKeep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlertExistingFileKeep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnAlertExistingFileKeep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnAlertExistingFileKeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlertExistingFileKeep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAlertExistingFileKeep.Location = New System.Drawing.Point(99, 118)
        Me.btnAlertExistingFileKeep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAlertExistingFileKeep.Name = "btnAlertExistingFileKeep"
        Me.btnAlertExistingFileKeep.Size = New System.Drawing.Size(228, 32)
        Me.btnAlertExistingFileKeep.TabIndex = 7
        Me.btnAlertExistingFileKeep.Text = "Garder l'image existante"
        Me.btnAlertExistingFileKeep.UseVisualStyleBackColor = False
        '
        'GiveANameToDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 160)
        Me.Controls.Add(Me.btnAlertExistingFileKeep)
        Me.Controls.Add(Me.btnAlertExistingFileReplace)
        Me.Controls.Add(Me.lblAlertExistingFileDescription)
        Me.Controls.Add(Me.lblAlertExistingFileTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GiveANameToDetail"
        Me.Text = "GiveANameToDetail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAlertExistingFileTitle As Label
    Friend WithEvents lblAlertExistingFileDescription As Label
    Friend WithEvents btnAlertExistingFileReplace As Button
    Friend WithEvents btnAlertExistingFileKeep As Button
End Class
