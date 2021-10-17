<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.tmrMossRight = New System.Windows.Forms.Timer(Me.components)
        Me.btnQuickPlay = New System.Windows.Forms.Button()
        Me.btnHowToPlay = New System.Windows.Forms.Button()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.tmrMossLeft = New System.Windows.Forms.Timer(Me.components)
        Me.picMoss = New System.Windows.Forms.PictureBox()
        Me.lblBeginText = New System.Windows.Forms.Label()
        Me.lblQuickPlayText = New System.Windows.Forms.Label()
        Me.lblHowToPlayText = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.picMoss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrMossRight
        '
        Me.tmrMossRight.Enabled = True
        Me.tmrMossRight.Interval = 200
        '
        'btnQuickPlay
        '
        Me.btnQuickPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickPlay.Location = New System.Drawing.Point(383, 478)
        Me.btnQuickPlay.Name = "btnQuickPlay"
        Me.btnQuickPlay.Size = New System.Drawing.Size(109, 45)
        Me.btnQuickPlay.TabIndex = 2
        Me.btnQuickPlay.TabStop = False
        Me.btnQuickPlay.Text = "Endless"
        Me.btnQuickPlay.UseVisualStyleBackColor = True
        '
        'btnHowToPlay
        '
        Me.btnHowToPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHowToPlay.Location = New System.Drawing.Point(383, 405)
        Me.btnHowToPlay.Name = "btnHowToPlay"
        Me.btnHowToPlay.Size = New System.Drawing.Size(109, 45)
        Me.btnHowToPlay.TabIndex = 1
        Me.btnHowToPlay.TabStop = False
        Me.btnHowToPlay.Text = "How To Play"
        Me.btnHowToPlay.UseVisualStyleBackColor = True
        '
        'btnBegin
        '
        Me.btnBegin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBegin.Location = New System.Drawing.Point(360, 306)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(161, 77)
        Me.btnBegin.TabIndex = 0
        Me.btnBegin.TabStop = False
        Me.btnBegin.Text = "Begin"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'tmrMossLeft
        '
        Me.tmrMossLeft.Interval = 200
        '
        'picMoss
        '
        Me.picMoss.Image = CType(resources.GetObject("picMoss.Image"), System.Drawing.Image)
        Me.picMoss.Location = New System.Drawing.Point(383, 143)
        Me.picMoss.Name = "picMoss"
        Me.picMoss.Size = New System.Drawing.Size(156, 157)
        Me.picMoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMoss.TabIndex = 3
        Me.picMoss.TabStop = False
        '
        'lblBeginText
        '
        Me.lblBeginText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeginText.Location = New System.Drawing.Point(537, 322)
        Me.lblBeginText.Name = "lblBeginText"
        Me.lblBeginText.Size = New System.Drawing.Size(164, 61)
        Me.lblBeginText.TabIndex = 4
        Me.lblBeginText.Text = "-- Begin the game with storyline and tutorial"
        '
        'lblQuickPlayText
        '
        Me.lblQuickPlayText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuickPlayText.Location = New System.Drawing.Point(516, 488)
        Me.lblQuickPlayText.Name = "lblQuickPlayText"
        Me.lblQuickPlayText.Size = New System.Drawing.Size(164, 61)
        Me.lblQuickPlayText.TabIndex = 5
        Me.lblQuickPlayText.Text = "-- Pure, infinite, gameplay (no story)"
        '
        'lblHowToPlayText
        '
        Me.lblHowToPlayText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowToPlayText.Location = New System.Drawing.Point(516, 405)
        Me.lblHowToPlayText.Name = "lblHowToPlayText"
        Me.lblHowToPlayText.Size = New System.Drawing.Size(164, 61)
        Me.lblHowToPlayText.TabIndex = 6
        Me.lblHowToPlayText.Text = "-- Movement controls and keybindings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTitle
        '
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTitle.Font = New System.Drawing.Font("Palatino Linotype", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(302, 77)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(299, 53)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Dungeon of Moss"
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(908, 562)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblHowToPlayText)
        Me.Controls.Add(Me.lblQuickPlayText)
        Me.Controls.Add(Me.lblBeginText)
        Me.Controls.Add(Me.picMoss)
        Me.Controls.Add(Me.btnQuickPlay)
        Me.Controls.Add(Me.btnHowToPlay)
        Me.Controls.Add(Me.btnBegin)
        Me.Name = "MainScreen"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Moss"
        CType(Me.picMoss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrMossRight As Timer
    Friend WithEvents picMoss As PictureBox
    Friend WithEvents btnQuickPlay As Button
    Friend WithEvents btnHowToPlay As Button
    Friend WithEvents btnBegin As Button
    Friend WithEvents tmrMossLeft As Timer
    Friend WithEvents lblBeginText As Label
    Friend WithEvents lblQuickPlayText As Label
    Friend WithEvents lblHowToPlayText As Label
    Friend WithEvents lblTitle As Label
End Class
