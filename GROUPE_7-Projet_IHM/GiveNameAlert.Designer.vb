<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GiveNameAlert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GiveNameAlert))
        Me.lblAlertGiveName = New System.Windows.Forms.Label()
        Me.btnCreateDetail = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.detailNameTxtBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAlertGiveName
        '
        Me.lblAlertGiveName.AutoSize = True
        Me.lblAlertGiveName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAlertGiveName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblAlertGiveName.Location = New System.Drawing.Point(24, 18)
        Me.lblAlertGiveName.Name = "lblAlertGiveName"
        Me.lblAlertGiveName.Size = New System.Drawing.Size(250, 26)
        Me.lblAlertGiveName.TabIndex = 1
        Me.lblAlertGiveName.Text = "Donner un nom au détail"
        '
        'btnCreateDetail
        '
        Me.btnCreateDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnCreateDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnCreateDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnCreateDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCreateDetail.Location = New System.Drawing.Point(332, 118)
        Me.btnCreateDetail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreateDetail.Name = "btnCreateDetail"
        Me.btnCreateDetail.Size = New System.Drawing.Size(139, 32)
        Me.btnCreateDetail.TabIndex = 6
        Me.btnCreateDetail.Text = "Créer le détail"
        Me.btnCreateDetail.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.Location = New System.Drawing.Point(217, 118)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 32)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'detailNameTxtBox
        '
        Me.detailNameTxtBox.Location = New System.Drawing.Point(24, 61)
        Me.detailNameTxtBox.Name = "detailNameTxtBox"
        Me.detailNameTxtBox.Size = New System.Drawing.Size(446, 23)
        Me.detailNameTxtBox.TabIndex = 8
        '
        'GiveNameAlert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 160)
        Me.Controls.Add(Me.detailNameTxtBox)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreateDetail)
        Me.Controls.Add(Me.lblAlertGiveName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GiveNameAlert"
        Me.Text = "GiveANameToDetail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAlertGiveName As Label
    Friend WithEvents btnCreateDetail As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents detailNameTxtBox As TextBox
End Class
