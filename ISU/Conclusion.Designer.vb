<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conclusion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picMoss = New System.Windows.Forms.PictureBox()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.lblEndless = New System.Windows.Forms.Label()
        Me.tmrEvents = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMoss = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picMoss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("SimSun", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(12, 98)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(209, 83)
        Me.lblScore.TabIndex = 20
        Me.lblScore.Text = "5000"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picMoss
        '
        Me.picMoss.Image = Global.ISU.My.Resources.Resources.Moss_with_Knife
        Me.picMoss.Location = New System.Drawing.Point(358, 286)
        Me.picMoss.Name = "picMoss"
        Me.picMoss.Size = New System.Drawing.Size(103, 94)
        Me.picMoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMoss.TabIndex = 21
        Me.picMoss.TabStop = False
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblWin.Font = New System.Drawing.Font("Sylfaen", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.Location = New System.Drawing.Point(300, 66)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(220, 62)
        Me.lblWin.TabIndex = 22
        Me.lblWin.Text = "You win!"
        Me.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEndless
        '
        Me.lblEndless.AutoSize = True
        Me.lblEndless.Font = New System.Drawing.Font("Sitka Banner", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndless.Location = New System.Drawing.Point(353, 143)
        Me.lblEndless.Name = "lblEndless"
        Me.lblEndless.Size = New System.Drawing.Size(108, 16)
        Me.lblEndless.TabIndex = 23
        Me.lblEndless.Text = "(Go play endless now)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblEndless.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrEvents
        '
        Me.tmrEvents.Interval = 149
        '
        'tmrMoss
        '
        Me.tmrMoss.Interval = 153
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(347, 410)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 68)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Conclusion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 546)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblEndless)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.picMoss)
        Me.Controls.Add(Me.lblScore)
        Me.Name = "Conclusion"
        Me.Text = "Conclusion"
        CType(Me.picMoss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScore As Label
    Friend WithEvents picMoss As PictureBox
    Friend WithEvents lblWin As Label
    Friend WithEvents lblEndless As Label
    Friend WithEvents tmrEvents As Timer
    Friend WithEvents tmrMoss As Timer
    Friend WithEvents btnExit As Button
End Class
