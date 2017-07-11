<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imgFront = New System.Windows.Forms.PictureBox()
        Me.imgSide = New System.Windows.Forms.PictureBox()
        Me.imgFrontSource = New System.Windows.Forms.PictureBox()
        Me.imgSideSource = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.gIndicator = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupAngle = New System.Windows.Forms.GroupBox()
        Me.txtMinX = New System.Windows.Forms.TextBox()
        Me.txtMinY = New System.Windows.Forms.TextBox()
        Me.txtMaxY = New System.Windows.Forms.TextBox()
        Me.txtMaxX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pRight = New System.Windows.Forms.Panel()
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMaxLoss = New System.Windows.Forms.TextBox()
        Me.txtMinLoss = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pLoss = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        CType(Me.imgFront, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFrontSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSideSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.gIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupAngle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(502, 250)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.Size = New System.Drawing.Size(181, 20)
        Me.txtLog.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(118, 10)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Port"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(49, 12)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(63, 20)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Text = "5002"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(499, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Data received"
        '
        'imgFront
        '
        Me.imgFront.Image = CType(resources.GetObject("imgFront.Image"), System.Drawing.Image)
        Me.imgFront.Location = New System.Drawing.Point(9, 124)
        Me.imgFront.Name = "imgFront"
        Me.imgFront.Size = New System.Drawing.Size(192, 100)
        Me.imgFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgFront.TabIndex = 1
        Me.imgFront.TabStop = False
        '
        'imgSide
        '
        Me.imgSide.Image = CType(resources.GetObject("imgSide.Image"), System.Drawing.Image)
        Me.imgSide.Location = New System.Drawing.Point(9, 18)
        Me.imgSide.Name = "imgSide"
        Me.imgSide.Size = New System.Drawing.Size(192, 100)
        Me.imgSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSide.TabIndex = 0
        Me.imgSide.TabStop = False
        '
        'imgFrontSource
        '
        Me.imgFrontSource.Image = CType(resources.GetObject("imgFrontSource.Image"), System.Drawing.Image)
        Me.imgFrontSource.Location = New System.Drawing.Point(205, 292)
        Me.imgFrontSource.Name = "imgFrontSource"
        Me.imgFrontSource.Size = New System.Drawing.Size(192, 100)
        Me.imgFrontSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgFrontSource.TabIndex = 3
        Me.imgFrontSource.TabStop = False
        Me.imgFrontSource.Visible = False
        '
        'imgSideSource
        '
        Me.imgSideSource.Image = CType(resources.GetObject("imgSideSource.Image"), System.Drawing.Image)
        Me.imgSideSource.Location = New System.Drawing.Point(0, 292)
        Me.imgSideSource.Name = "imgSideSource"
        Me.imgSideSource.Size = New System.Drawing.Size(192, 100)
        Me.imgSideSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSideSource.TabIndex = 2
        Me.imgSideSource.TabStop = False
        Me.imgSideSource.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.gIndicator)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Enabled = False
        Me.GroupBox5.Location = New System.Drawing.Point(502, 49)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(181, 182)
        Me.GroupBox5.TabIndex = 45
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "g Force"
        '
        'gIndicator
        '
        Me.gIndicator.BackColor = System.Drawing.Color.Transparent
        Me.gIndicator.BackgroundImage = CType(resources.GetObject("gIndicator.BackgroundImage"), System.Drawing.Image)
        Me.gIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gIndicator.Location = New System.Drawing.Point(84, 84)
        Me.gIndicator.Name = "gIndicator"
        Me.gIndicator.Size = New System.Drawing.Size(16, 16)
        Me.gIndicator.TabIndex = 1
        Me.gIndicator.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 155)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'groupAngle
        '
        Me.groupAngle.Controls.Add(Me.imgFront)
        Me.groupAngle.Controls.Add(Me.imgSide)
        Me.groupAngle.Controls.Add(Me.imgFrontSource)
        Me.groupAngle.Controls.Add(Me.imgSideSource)
        Me.groupAngle.Enabled = False
        Me.groupAngle.Location = New System.Drawing.Point(12, 45)
        Me.groupAngle.Name = "groupAngle"
        Me.groupAngle.Size = New System.Drawing.Size(214, 235)
        Me.groupAngle.TabIndex = 46
        Me.groupAngle.TabStop = False
        Me.groupAngle.Text = "Sim"
        '
        'txtMinX
        '
        Me.txtMinX.Location = New System.Drawing.Point(55, 202)
        Me.txtMinX.Name = "txtMinX"
        Me.txtMinX.ReadOnly = True
        Me.txtMinX.Size = New System.Drawing.Size(76, 20)
        Me.txtMinX.TabIndex = 47
        '
        'txtMinY
        '
        Me.txtMinY.Location = New System.Drawing.Point(137, 202)
        Me.txtMinY.Name = "txtMinY"
        Me.txtMinY.ReadOnly = True
        Me.txtMinY.Size = New System.Drawing.Size(76, 20)
        Me.txtMinY.TabIndex = 48
        '
        'txtMaxY
        '
        Me.txtMaxY.Location = New System.Drawing.Point(137, 176)
        Me.txtMaxY.Name = "txtMaxY"
        Me.txtMaxY.ReadOnly = True
        Me.txtMaxY.Size = New System.Drawing.Size(76, 20)
        Me.txtMaxY.TabIndex = 50
        '
        'txtMaxX
        '
        Me.txtMaxX.Location = New System.Drawing.Point(55, 176)
        Me.txtMaxX.Name = "txtMaxX"
        Me.txtMaxX.ReadOnly = True
        Me.txtMaxX.Size = New System.Drawing.Size(76, 20)
        Me.txtMaxX.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Max"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Min"
        '
        'pRight
        '
        Me.pRight.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pRight.Location = New System.Drawing.Point(168, 15)
        Me.pRight.Name = "pRight"
        Me.pRight.Size = New System.Drawing.Size(18, 151)
        Me.pRight.TabIndex = 53
        '
        'pLeft
        '
        Me.pLeft.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pLeft.Location = New System.Drawing.Point(84, 15)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(18, 151)
        Me.pLeft.TabIndex = 52
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaxLoss)
        Me.GroupBox1.Controls.Add(Me.txtMinLoss)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.pLoss)
        Me.GroupBox1.Controls.Add(Me.pRight)
        Me.GroupBox1.Controls.Add(Me.pLeft)
        Me.GroupBox1.Controls.Add(Me.txtMinX)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMinY)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMaxX)
        Me.GroupBox1.Controls.Add(Me.txtMaxY)
        Me.GroupBox1.Location = New System.Drawing.Point(232, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 297)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Axis"
        '
        'txtMaxLoss
        '
        Me.txtMaxLoss.Location = New System.Drawing.Point(175, 271)
        Me.txtMaxLoss.Name = "txtMaxLoss"
        Me.txtMaxLoss.ReadOnly = True
        Me.txtMaxLoss.Size = New System.Drawing.Size(76, 20)
        Me.txtMaxLoss.TabIndex = 57
        '
        'txtMinLoss
        '
        Me.txtMinLoss.Location = New System.Drawing.Point(15, 271)
        Me.txtMinLoss.Name = "txtMinLoss"
        Me.txtMinLoss.ReadOnly = True
        Me.txtMinLoss.Size = New System.Drawing.Size(76, 20)
        Me.txtMinLoss.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Traction loss"
        '
        'pLoss
        '
        Me.pLoss.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pLoss.Location = New System.Drawing.Point(15, 245)
        Me.pLoss.Name = "pLoss"
        Me.pLoss.Size = New System.Drawing.Size(236, 19)
        Me.pLoss.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(499, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Parsed"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(502, 316)
        Me.txtA.Name = "txtA"
        Me.txtA.ReadOnly = True
        Me.txtA.Size = New System.Drawing.Size(58, 20)
        Me.txtA.TabIndex = 51
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(563, 316)
        Me.txtB.Name = "txtB"
        Me.txtB.ReadOnly = True
        Me.txtB.Size = New System.Drawing.Size(58, 20)
        Me.txtB.TabIndex = 52
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(624, 316)
        Me.txtC.Name = "txtC"
        Me.txtC.ReadOnly = True
        Me.txtC.Size = New System.Drawing.Size(58, 20)
        Me.txtC.TabIndex = 53
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 346)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupAngle)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2DOF Virtual Sim"
        CType(Me.imgFront, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFrontSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSideSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.gIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupAngle.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents imgFront As System.Windows.Forms.PictureBox
    Friend WithEvents imgSide As System.Windows.Forms.PictureBox
    Friend WithEvents imgFrontSource As System.Windows.Forms.PictureBox
    Friend WithEvents imgSideSource As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents gIndicator As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents groupAngle As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaxY As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxX As System.Windows.Forms.TextBox
    Friend WithEvents txtMinY As System.Windows.Forms.TextBox
    Friend WithEvents txtMinX As System.Windows.Forms.TextBox
    Friend WithEvents pRight As System.Windows.Forms.Panel
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pLoss As System.Windows.Forms.Panel
    Friend WithEvents txtMaxLoss As System.Windows.Forms.TextBox
    Friend WithEvents txtMinLoss As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox

End Class
