<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageGolferEvent
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDropGolfer = New System.Windows.Forms.Button()
        Me.btnAddGolfer = New System.Windows.Forms.Button()
        Me.lstAvailableGolfers = New System.Windows.Forms.ListBox()
        Me.lstInEvent = New System.Windows.Forms.ListBox()
        Me.cboEvents = New System.Windows.Forms.ComboBox()
        Me.btnManageSponsors = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Available Golfers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Golfers in Events: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Events:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(209, 245)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 48)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDropGolfer
        '
        Me.btnDropGolfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnDropGolfer.Location = New System.Drawing.Point(158, 175)
        Me.btnDropGolfer.Name = "btnDropGolfer"
        Me.btnDropGolfer.Size = New System.Drawing.Size(46, 38)
        Me.btnDropGolfer.TabIndex = 14
        Me.btnDropGolfer.Text = "→"
        Me.btnDropGolfer.UseVisualStyleBackColor = True
        '
        'btnAddGolfer
        '
        Me.btnAddGolfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGolfer.Location = New System.Drawing.Point(158, 113)
        Me.btnAddGolfer.Name = "btnAddGolfer"
        Me.btnAddGolfer.Size = New System.Drawing.Size(46, 35)
        Me.btnAddGolfer.TabIndex = 13
        Me.btnAddGolfer.Text = "←"
        Me.btnAddGolfer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddGolfer.UseVisualStyleBackColor = True
        '
        'lstAvailableGolfers
        '
        Me.lstAvailableGolfers.FormattingEnabled = True
        Me.lstAvailableGolfers.ItemHeight = 16
        Me.lstAvailableGolfers.Location = New System.Drawing.Point(233, 113)
        Me.lstAvailableGolfers.Name = "lstAvailableGolfers"
        Me.lstAvailableGolfers.Size = New System.Drawing.Size(106, 100)
        Me.lstAvailableGolfers.TabIndex = 12
        '
        'lstInEvent
        '
        Me.lstInEvent.FormattingEnabled = True
        Me.lstInEvent.ItemHeight = 16
        Me.lstInEvent.Location = New System.Drawing.Point(19, 113)
        Me.lstInEvent.Name = "lstInEvent"
        Me.lstInEvent.Size = New System.Drawing.Size(106, 100)
        Me.lstInEvent.TabIndex = 11
        '
        'cboEvents
        '
        Me.cboEvents.FormattingEnabled = True
        Me.cboEvents.Location = New System.Drawing.Point(127, 38)
        Me.cboEvents.Name = "cboEvents"
        Me.cboEvents.Size = New System.Drawing.Size(106, 24)
        Me.cboEvents.TabIndex = 10
        '
        'btnManageSponsors
        '
        Me.btnManageSponsors.Location = New System.Drawing.Point(19, 245)
        Me.btnManageSponsors.Name = "btnManageSponsors"
        Me.btnManageSponsors.Size = New System.Drawing.Size(136, 48)
        Me.btnManageSponsors.TabIndex = 19
        Me.btnManageSponsors.Text = "Manage Sponsors"
        Me.btnManageSponsors.UseVisualStyleBackColor = True
        '
        'frmManageGolferEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 309)
        Me.Controls.Add(Me.btnManageSponsors)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDropGolfer)
        Me.Controls.Add(Me.btnAddGolfer)
        Me.Controls.Add(Me.lstAvailableGolfers)
        Me.Controls.Add(Me.lstInEvent)
        Me.Controls.Add(Me.cboEvents)
        Me.Name = "frmManageGolferEvent"
        Me.Text = "Manage Golfer Event Years"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDropGolfer As Button
    Friend WithEvents btnAddGolfer As Button
    Friend WithEvents lstAvailableGolfers As ListBox
    Friend WithEvents lstInEvent As ListBox
    Friend WithEvents cboEvents As ComboBox
    Friend WithEvents btnManageSponsors As Button
End Class
