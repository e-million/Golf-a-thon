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
        Me.btnAddSponsor = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDropGolferSponsor = New System.Windows.Forms.Button()
        Me.btnAddGolferSponsor = New System.Windows.Forms.Button()
        Me.lstNoSponsors = New System.Windows.Forms.ListBox()
        Me.lstHasSponsor = New System.Windows.Forms.ListBox()
        Me.cboSponsors = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAddSponsor
        '
        Me.btnAddSponsor.Location = New System.Drawing.Point(16, 245)
        Me.btnAddSponsor.Name = "btnAddSponsor"
        Me.btnAddSponsor.Size = New System.Drawing.Size(136, 48)
        Me.btnAddSponsor.TabIndex = 29
        Me.btnAddSponsor.Text = "Add Sponsor"
        Me.btnAddSponsor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Available Sponsors"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Sponsors in Events: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Sponsors:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(206, 245)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 48)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDropGolferSponsor
        '
        Me.btnDropGolferSponsor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnDropGolferSponsor.Location = New System.Drawing.Point(155, 175)
        Me.btnDropGolferSponsor.Name = "btnDropGolferSponsor"
        Me.btnDropGolferSponsor.Size = New System.Drawing.Size(46, 38)
        Me.btnDropGolferSponsor.TabIndex = 24
        Me.btnDropGolferSponsor.Text = "→"
        Me.btnDropGolferSponsor.UseVisualStyleBackColor = True
        '
        'btnAddGolferSponsor
        '
        Me.btnAddGolferSponsor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGolferSponsor.Location = New System.Drawing.Point(155, 113)
        Me.btnAddGolferSponsor.Name = "btnAddGolferSponsor"
        Me.btnAddGolferSponsor.Size = New System.Drawing.Size(46, 35)
        Me.btnAddGolferSponsor.TabIndex = 23
        Me.btnAddGolferSponsor.Text = "←"
        Me.btnAddGolferSponsor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddGolferSponsor.UseVisualStyleBackColor = True
        '
        'lstNoSponsors
        '
        Me.lstNoSponsors.FormattingEnabled = True
        Me.lstNoSponsors.ItemHeight = 16
        Me.lstNoSponsors.Location = New System.Drawing.Point(230, 113)
        Me.lstNoSponsors.Name = "lstNoSponsors"
        Me.lstNoSponsors.Size = New System.Drawing.Size(106, 100)
        Me.lstNoSponsors.TabIndex = 22
        '
        'lstHasSponsor
        '
        Me.lstHasSponsor.FormattingEnabled = True
        Me.lstHasSponsor.ItemHeight = 16
        Me.lstHasSponsor.Location = New System.Drawing.Point(16, 113)
        Me.lstHasSponsor.Name = "lstHasSponsor"
        Me.lstHasSponsor.Size = New System.Drawing.Size(106, 100)
        Me.lstHasSponsor.TabIndex = 21
        '
        'cboSponsors
        '
        Me.cboSponsors.FormattingEnabled = True
        Me.cboSponsors.Location = New System.Drawing.Point(128, 38)
        Me.cboSponsors.Name = "cboSponsors"
        Me.cboSponsors.Size = New System.Drawing.Size(106, 24)
        Me.cboSponsors.TabIndex = 20
        '
        'frmManageSponsors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 308)
        Me.Controls.Add(Me.btnAddSponsor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDropGolferSponsor)
        Me.Controls.Add(Me.btnAddGolferSponsor)
        Me.Controls.Add(Me.lstNoSponsors)
        Me.Controls.Add(Me.lstHasSponsor)
        Me.Controls.Add(Me.cboSponsors)
        Me.Name = "frmManageSponsors"
        Me.Text = "Manage Sponsors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddSponsor As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDropGolferSponsor As Button
    Friend WithEvents btnAddGolferSponsor As Button
    Friend WithEvents lstNoSponsors As ListBox
    Friend WithEvents lstHasSponsor As ListBox
    Friend WithEvents cboSponsors As ComboBox
End Class
