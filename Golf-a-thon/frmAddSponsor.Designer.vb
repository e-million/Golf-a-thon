<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSponsor
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddSponsor = New System.Windows.Forms.Button()
        Me.SponsorInfo = New System.Windows.Forms.GroupBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.SponsorInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(268, 275)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 52)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(166, 275)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 52)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddSponsor
        '
        Me.btnAddSponsor.Location = New System.Drawing.Point(64, 275)
        Me.btnAddSponsor.Name = "btnAddSponsor"
        Me.btnAddSponsor.Size = New System.Drawing.Size(96, 52)
        Me.btnAddSponsor.TabIndex = 23
        Me.btnAddSponsor.Text = "&Add Sponsor"
        Me.btnAddSponsor.UseVisualStyleBackColor = True
        '
        'SponsorInfo
        '
        Me.SponsorInfo.Controls.Add(Me.txtFirstName)
        Me.SponsorInfo.Controls.Add(Me.Label5)
        Me.SponsorInfo.Controls.Add(Me.Label1)
        Me.SponsorInfo.Controls.Add(Me.txtEmail)
        Me.SponsorInfo.Controls.Add(Me.txtLastName)
        Me.SponsorInfo.Controls.Add(Me.Label6)
        Me.SponsorInfo.Controls.Add(Me.Label2)
        Me.SponsorInfo.Controls.Add(Me.txtPhoneNumber)
        Me.SponsorInfo.Controls.Add(Me.txtStreetAddress)
        Me.SponsorInfo.Controls.Add(Me.Label7)
        Me.SponsorInfo.Controls.Add(Me.Label4)
        Me.SponsorInfo.Controls.Add(Me.txtZip)
        Me.SponsorInfo.Controls.Add(Me.txtCity)
        Me.SponsorInfo.Controls.Add(Me.Label8)
        Me.SponsorInfo.Controls.Add(Me.Label3)
        Me.SponsorInfo.Controls.Add(Me.txtState)
        Me.SponsorInfo.Location = New System.Drawing.Point(12, 12)
        Me.SponsorInfo.Name = "SponsorInfo"
        Me.SponsorInfo.Size = New System.Drawing.Size(404, 257)
        Me.SponsorInfo.TabIndex = 22
        Me.SponsorInfo.TabStop = False
        Me.SponsorInfo.Text = "Sponsor Info"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(122, 21)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(180, 22)
        Me.txtFirstName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Email: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name: "
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(122, 217)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 22)
        Me.txtEmail.TabIndex = 14
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(122, 49)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(180, 22)
        Me.txtLastName.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Phone Number: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name: "
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(122, 189)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(180, 22)
        Me.txtPhoneNumber.TabIndex = 12
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(122, 77)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(180, 22)
        Me.txtStreetAddress.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Zip Code: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Street Address: "
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(122, 161)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(78, 22)
        Me.txtZip.TabIndex = 10
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(122, 105)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(180, 22)
        Me.txtCity.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "State: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "City: "
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(122, 133)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(78, 22)
        Me.txtState.TabIndex = 8
        '
        'frmAddSponsor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 340)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddSponsor)
        Me.Controls.Add(Me.SponsorInfo)
        Me.Name = "frmAddSponsor"
        Me.Text = "Add Sponsor"
        Me.SponsorInfo.ResumeLayout(False)
        Me.SponsorInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAddSponsor As Button
    Friend WithEvents SponsorInfo As GroupBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtState As TextBox
End Class
