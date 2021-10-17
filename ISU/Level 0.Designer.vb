<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Level_0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level_0))
        Me.tmrMossLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMossRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFall = New System.Windows.Forms.Timer(Me.components)
        Me.tmrKnife = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBounds = New System.Windows.Forms.Timer(Me.components)
        Me.lblText = New System.Windows.Forms.Label()
        Me.tmrText = New System.Windows.Forms.Timer(Me.components)
        Me.tmrZombie1 = New System.Windows.Forms.Timer(Me.components)
        Me.picZombie2 = New System.Windows.Forms.PictureBox()
        Me.picZombie1 = New System.Windows.Forms.PictureBox()
        Me.picMoss = New System.Windows.Forms.PictureBox()
        Me.picKnife = New System.Windows.Forms.PictureBox()
        Me.picHeart3 = New System.Windows.Forms.PictureBox()
        Me.picHeart2 = New System.Windows.Forms.PictureBox()
        Me.picHeart1 = New System.Windows.Forms.PictureBox()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        CType(Me.picZombie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picZombie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKnife, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrMossLeft
        '
        '
        'tmrMossRight
        '
        '
        'tmrFall
        '
        Me.tmrFall.Interval = 3
        '
        'tmrKnife
        '
        Me.tmrKnife.Interval = 10
        '
        'tmrBounds
        '
        Me.tmrBounds.Interval = 1
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.White
        Me.lblText.Font = New System.Drawing.Font("Microsoft Himalaya", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(12, 579)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(830, 74)
        Me.lblText.TabIndex = 7
        '
        'tmrText
        '
        Me.tmrText.Interval = 10
        '
        'tmrZombie1
        '
        '
        'picZombie2
        '
        Me.picZombie2.Image = Global.ISU.My.Resources.Resources.Zombie1
        Me.picZombie2.Location = New System.Drawing.Point(743, 136)
        Me.picZombie2.Name = "picZombie2"
        Me.picZombie2.Size = New System.Drawing.Size(60, 75)
        Me.picZombie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picZombie2.TabIndex = 9
        Me.picZombie2.TabStop = False
        '
        'picZombie1
        '
        Me.picZombie1.Image = Global.ISU.My.Resources.Resources.Zombie1_Reversed
        Me.picZombie1.Location = New System.Drawing.Point(280, 136)
        Me.picZombie1.Name = "picZombie1"
        Me.picZombie1.Size = New System.Drawing.Size(60, 75)
        Me.picZombie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picZombie1.TabIndex = 8
        Me.picZombie1.TabStop = False
        '
        'picMoss
        '
        Me.picMoss.Image = Global.ISU.My.Resources.Resources.Moss1_New
        Me.picMoss.Location = New System.Drawing.Point(503, -32)
        Me.picMoss.Name = "picMoss"
        Me.picMoss.Size = New System.Drawing.Size(84, 56)
        Me.picMoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMoss.TabIndex = 6
        Me.picMoss.TabStop = False
        '
        'picKnife
        '
        Me.picKnife.Image = Global.ISU.My.Resources.Resources.Knife_Right
        Me.picKnife.Location = New System.Drawing.Point(164, 116)
        Me.picKnife.Name = "picKnife"
        Me.picKnife.Size = New System.Drawing.Size(76, 67)
        Me.picKnife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKnife.TabIndex = 5
        Me.picKnife.TabStop = False
        '
        'picHeart3
        '
        Me.picHeart3.Image = Global.ISU.My.Resources.Resources.Heart_New
        Me.picHeart3.Location = New System.Drawing.Point(147, 37)
        Me.picHeart3.Name = "picHeart3"
        Me.picHeart3.Size = New System.Drawing.Size(58, 50)
        Me.picHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeart3.TabIndex = 3
        Me.picHeart3.TabStop = False
        '
        'picHeart2
        '
        Me.picHeart2.Image = CType(resources.GetObject("picHeart2.Image"), System.Drawing.Image)
        Me.picHeart2.Location = New System.Drawing.Point(83, 37)
        Me.picHeart2.Name = "picHeart2"
        Me.picHeart2.Size = New System.Drawing.Size(58, 50)
        Me.picHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeart2.TabIndex = 2
        Me.picHeart2.TabStop = False
        '
        'picHeart1
        '
        Me.picHeart1.Image = CType(resources.GetObject("picHeart1.Image"), System.Drawing.Image)
        Me.picHeart1.Location = New System.Drawing.Point(19, 37)
        Me.picHeart1.Name = "picHeart1"
        Me.picHeart1.Size = New System.Drawing.Size(58, 50)
        Me.picHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeart1.TabIndex = 1
        Me.picHeart1.TabStop = False
        '
        'picBackground
        '
        Me.picBackground.Image = Global.ISU.My.Resources.Resources.Background_New_1
        Me.picBackground.Location = New System.Drawing.Point(97, -10)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(914, 692)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'Level_0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(854, 674)
        Me.Controls.Add(Me.picZombie2)
        Me.Controls.Add(Me.picZombie1)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.picMoss)
        Me.Controls.Add(Me.picKnife)
        Me.Controls.Add(Me.picHeart3)
        Me.Controls.Add(Me.picHeart2)
        Me.Controls.Add(Me.picHeart1)
        Me.Controls.Add(Me.picBackground)
        Me.Name = "Level_0"
        Me.Text = "Level_1"
        CType(Me.picZombie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picZombie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKnife, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picHeart1 As PictureBox
    Friend WithEvents picHeart2 As PictureBox
    Friend WithEvents picHeart3 As PictureBox
    Friend WithEvents tmrMossLeft As Timer
    Friend WithEvents tmrMossRight As Timer
    Friend WithEvents tmrFall As Timer
    Friend WithEvents picBackground As PictureBox
    Friend WithEvents picKnife As PictureBox
    Friend WithEvents tmrKnife As Timer
    Friend WithEvents tmrBounds As Timer
    Friend WithEvents picMoss As PictureBox
    Friend WithEvents lblText As Label
    Friend WithEvents tmrText As Timer
    Friend WithEvents picZombie1 As PictureBox
    Friend WithEvents tmrZombie1 As Timer
    Friend WithEvents picZombie2 As PictureBox
End Class
