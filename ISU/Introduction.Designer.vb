<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Introduction
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
        Me.tmrMossRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMossLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAnimations = New System.Windows.Forms.Timer(Me.components)
        Me.tmrText = New System.Windows.Forms.Timer(Me.components)
        Me.lblText = New System.Windows.Forms.Label()
        Me.picKnife = New System.Windows.Forms.PictureBox()
        Me.picMoss = New System.Windows.Forms.PictureBox()
        CType(Me.picKnife, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrAnimations
        '
        Me.tmrAnimations.Interval = 50
        '
        'tmrText
        '
        Me.tmrText.Interval = 50
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.White
        Me.lblText.Font = New System.Drawing.Font("Microsoft Himalaya", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(12, 339)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(696, 74)
        Me.lblText.TabIndex = 1
        '
        'picKnife
        '
        Me.picKnife.Image = Global.ISU.My.Resources.Resources.Knife_Reversed
        Me.picKnife.Location = New System.Drawing.Point(66, 182)
        Me.picKnife.Name = "picKnife"
        Me.picKnife.Size = New System.Drawing.Size(89, 68)
        Me.picKnife.TabIndex = 2
        Me.picKnife.TabStop = False
        '
        'picMoss
        '
        Me.picMoss.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMoss.Image = Global.ISU.My.Resources.Resources.Light
        Me.picMoss.Location = New System.Drawing.Point(297, 182)
        Me.picMoss.Name = "picMoss"
        Me.picMoss.Size = New System.Drawing.Size(86, 106)
        Me.picMoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMoss.TabIndex = 0
        Me.picMoss.TabStop = False
        '
        'Introduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(720, 442)
        Me.Controls.Add(Me.picKnife)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.picMoss)
        Me.Name = "Introduction"
        Me.Text = "Intro_Room"
        CType(Me.picKnife, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picMoss As PictureBox
    Friend WithEvents tmrMossRight As Timer
    Friend WithEvents tmrMossLeft As Timer
    Friend WithEvents tmrAnimations As Timer
    Friend WithEvents tmrText As Timer
    Friend WithEvents lblText As Label
    Friend WithEvents picKnife As PictureBox
End Class
