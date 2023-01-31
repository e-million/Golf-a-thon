<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnGolfers = New System.Windows.Forms.Button()
        Me.btnEvents = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageGolfersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageEventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ManageGolfersEventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGolfers
        '
        Me.btnGolfers.Location = New System.Drawing.Point(63, 26)
        Me.btnGolfers.Name = "btnGolfers"
        Me.btnGolfers.Size = New System.Drawing.Size(159, 58)
        Me.btnGolfers.TabIndex = 0
        Me.btnGolfers.Text = "Manage &Golfers"
        Me.btnGolfers.UseVisualStyleBackColor = True
        '
        'btnEvents
        '
        Me.btnEvents.Location = New System.Drawing.Point(228, 26)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(159, 58)
        Me.btnEvents.TabIndex = 1
        Me.btnEvents.Text = "Manage &Events"
        Me.btnEvents.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProjectToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(451, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageGolfersToolStripMenuItem, Me.ManageEventsToolStripMenuItem, Me.ManageGolfersEventsToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'ManageGolfersToolStripMenuItem
        '
        Me.ManageGolfersToolStripMenuItem.Name = "ManageGolfersToolStripMenuItem"
        Me.ManageGolfersToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.ManageGolfersToolStripMenuItem.Text = "Manage Golfers"
        '
        'ManageEventsToolStripMenuItem
        '
        Me.ManageEventsToolStripMenuItem.Name = "ManageEventsToolStripMenuItem"
        Me.ManageEventsToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.ManageEventsToolStripMenuItem.Text = "Manage Events"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 58)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Manage Golfers / Events"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ManageGolfersEventsToolStripMenuItem
        '
        Me.ManageGolfersEventsToolStripMenuItem.Name = "ManageGolfersEventsToolStripMenuItem"
        Me.ManageGolfersEventsToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.ManageGolfersEventsToolStripMenuItem.Text = "Manage Golfers / Events"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 174)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEvents)
        Me.Controls.Add(Me.btnGolfers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Golf-A-Thon"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGolfers As Button
    Friend WithEvents btnEvents As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageGolfersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageEventsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents ManageGolfersEventsToolStripMenuItem As ToolStripMenuItem
End Class
