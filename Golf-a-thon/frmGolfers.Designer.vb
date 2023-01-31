<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGolfers
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.GolferInfo = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboShirtSize = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.cboGolfers = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddGolfer = New System.Windows.Forms.Button()
        Me.btnDeleteGolfer = New System.Windows.Forms.Button()
        Me.GolferInfo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(122, 21)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(180, 22)
        Me.txtFirstName.TabIndex = 0
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name: "
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(122, 49)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(180, 22)
        Me.txtLastName.TabIndex = 2
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
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(122, 105)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(180, 22)
        Me.txtCity.TabIndex = 6
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
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(122, 77)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(180, 22)
        Me.txtStreetAddress.TabIndex = 4
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
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(122, 217)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 22)
        Me.txtEmail.TabIndex = 14
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
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(122, 189)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(180, 22)
        Me.txtPhoneNumber.TabIndex = 12
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
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(122, 161)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(78, 22)
        Me.txtZip.TabIndex = 10
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
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(122, 133)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(78, 22)
        Me.txtState.TabIndex = 8
        '
        'GolferInfo
        '
        Me.GolferInfo.Controls.Add(Me.Label10)
        Me.GolferInfo.Controls.Add(Me.cboShirtSize)
        Me.GolferInfo.Controls.Add(Me.Label9)
        Me.GolferInfo.Controls.Add(Me.cboGender)
        Me.GolferInfo.Controls.Add(Me.txtFirstName)
        Me.GolferInfo.Controls.Add(Me.Label5)
        Me.GolferInfo.Controls.Add(Me.Label1)
        Me.GolferInfo.Controls.Add(Me.txtEmail)
        Me.GolferInfo.Controls.Add(Me.txtLastName)
        Me.GolferInfo.Controls.Add(Me.Label6)
        Me.GolferInfo.Controls.Add(Me.Label2)
        Me.GolferInfo.Controls.Add(Me.txtPhoneNumber)
        Me.GolferInfo.Controls.Add(Me.txtStreetAddress)
        Me.GolferInfo.Controls.Add(Me.Label7)
        Me.GolferInfo.Controls.Add(Me.Label4)
        Me.GolferInfo.Controls.Add(Me.txtZip)
        Me.GolferInfo.Controls.Add(Me.txtCity)
        Me.GolferInfo.Controls.Add(Me.Label8)
        Me.GolferInfo.Controls.Add(Me.Label3)
        Me.GolferInfo.Controls.Add(Me.txtState)
        Me.GolferInfo.Location = New System.Drawing.Point(12, 80)
        Me.GolferInfo.Name = "GolferInfo"
        Me.GolferInfo.Size = New System.Drawing.Size(404, 328)
        Me.GolferInfo.TabIndex = 16
        Me.GolferInfo.TabStop = False
        Me.GolferInfo.Text = "Golfer Info"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Shirt Size: "
        '
        'cboShirtSize
        '
        Me.cboShirtSize.FormattingEnabled = True
        Me.cboShirtSize.Location = New System.Drawing.Point(122, 279)
        Me.cboShirtSize.Name = "cboShirtSize"
        Me.cboShirtSize.Size = New System.Drawing.Size(180, 24)
        Me.cboShirtSize.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Gender: "
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(122, 249)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(180, 24)
        Me.cboGender.TabIndex = 18
        '
        'cboGolfers
        '
        Me.cboGolfers.FormattingEnabled = True
        Me.cboGolfers.Location = New System.Drawing.Point(21, 50)
        Me.cboGolfers.Name = "cboGolfers"
        Me.cboGolfers.Size = New System.Drawing.Size(395, 24)
        Me.cboGolfers.TabIndex = 17
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 414)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 52)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "&Update Info"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(320, 414)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 52)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProjectToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(434, 28)
        Me.MenuStrip1.TabIndex = 21
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
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateInfoToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'UpdateInfoToolStripMenuItem
        '
        Me.UpdateInfoToolStripMenuItem.Name = "UpdateInfoToolStripMenuItem"
        Me.UpdateInfoToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.UpdateInfoToolStripMenuItem.Text = "Update Info"
        '
        'btnAddGolfer
        '
        Me.btnAddGolfer.Location = New System.Drawing.Point(116, 414)
        Me.btnAddGolfer.Name = "btnAddGolfer"
        Me.btnAddGolfer.Size = New System.Drawing.Size(96, 52)
        Me.btnAddGolfer.TabIndex = 22
        Me.btnAddGolfer.Text = "&Add Golfer"
        Me.btnAddGolfer.UseVisualStyleBackColor = True
        '
        'btnDeleteGolfer
        '
        Me.btnDeleteGolfer.Location = New System.Drawing.Point(218, 414)
        Me.btnDeleteGolfer.Name = "btnDeleteGolfer"
        Me.btnDeleteGolfer.Size = New System.Drawing.Size(96, 52)
        Me.btnDeleteGolfer.TabIndex = 23
        Me.btnDeleteGolfer.Text = "&Delete Golfer"
        Me.btnDeleteGolfer.UseVisualStyleBackColor = True
        '
        'frmGolfers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 478)
        Me.Controls.Add(Me.btnDeleteGolfer)
        Me.Controls.Add(Me.btnAddGolfer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cboGolfers)
        Me.Controls.Add(Me.GolferInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGolfers"
        Me.Text = "Manage Golfers"
        Me.GolferInfo.ResumeLayout(False)
        Me.GolferInfo.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents GolferInfo As GroupBox
    Friend WithEvents cboGolfers As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAddGolfer As Button
    Friend WithEvents btnDeleteGolfer As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cboShirtSize As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboGender As ComboBox
End Class
