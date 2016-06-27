<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TabControl))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.pnlTabs = New System.Windows.Forms.Panel()
        Me.TabButton1 = New System.Windows.Forms.PictureBox()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WinMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TabToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DropButton = New MdiTabControl.ControlButton()
        Me.CloseButton = New MdiTabControl.ControlButton()
        Me.pnlTop.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.pnlTabs.SuspendLayout()
        CType(Me.TabButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlTop.Controls.Add(Me.pnlControls)
        Me.pnlTop.Controls.Add(Me.pnlTabs)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(200, 31)
        Me.pnlTop.TabIndex = 6
        '
        'pnlControls
        '
        Me.pnlControls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControls.Controls.Add(Me.DropButton)
        Me.pnlControls.Controls.Add(Me.CloseButton)
        Me.pnlControls.Location = New System.Drawing.Point(175, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(25, 30)
        Me.pnlControls.TabIndex = 1
        '
        'pnlTabs
        '
        Me.pnlTabs.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTabs.BackColor = System.Drawing.Color.Transparent
        Me.pnlTabs.Controls.Add(Me.TabButton1)
        Me.pnlTabs.Location = New System.Drawing.Point(0, 3)
        Me.pnlTabs.Name = "pnlTabs"
        Me.pnlTabs.Size = New System.Drawing.Size(200, 28)
        Me.pnlTabs.TabIndex = 0
        '
        'TabButton1
        '
        Me.TabButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabButton1.Image = CType(resources.GetObject("TabButton1.Image"), System.Drawing.Image)
        Me.TabButton1.Location = New System.Drawing.Point(3, 3)
        Me.TabButton1.Name = "TabButton1"
        Me.TabButton1.Size = New System.Drawing.Size(23, 23)
        Me.TabButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.TabButton1.TabIndex = 1
        Me.TabButton1.TabStop = False
        '
        'pnlBottom
        '
        Me.pnlBottom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBottom.Controls.Add(Me.PictureBox2)
        Me.pnlBottom.Controls.Add(Me.PictureBox1)
        Me.pnlBottom.Location = New System.Drawing.Point(0, 31)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(200, 99)
        Me.pnlBottom.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(83, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'WinMenu
        '
        Me.WinMenu.Name = "WinMenu"
        Me.WinMenu.Size = New System.Drawing.Size(61, 4)
        '
        'DropButton
        '
        Me.DropButton.BackColor = System.Drawing.Color.Transparent
        Me.DropButton.Location = New System.Drawing.Point(4, 8)
        Me.DropButton.Name = "DropButton"
        Me.DropButton.Size = New System.Drawing.Size(17, 15)
        Me.DropButton.Style = MdiTabControl.ControlButton.ButtonStyle.Drop
        Me.DropButton.TabIndex = 0
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.Location = New System.Drawing.Point(4, 8)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(17, 15)
        Me.CloseButton.Style = MdiTabControl.ControlButton.ButtonStyle.Close
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Visible = False
        '
        'TabControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Name = "TabControl"
        Me.Size = New System.Drawing.Size(200, 130)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControls.ResumeLayout(False)
        Me.pnlTabs.ResumeLayout(False)
        CType(Me.TabButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlTabs As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents WinMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DropButton As MdiTabControl.ControlButton
    Friend WithEvents TabToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents CloseButton As MdiTabControl.ControlButton
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents TabButton1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
