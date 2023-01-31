Public Class frmAddGolfer
    Private Sub frmAddGolfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Load_Gender()
            Load_ShirtSize()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Sub ClearForm()
        ' Clears the form 
        txtFirstName.Clear()
        txtLastName.Clear()
        txtStreetAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtPhoneNumber.Clear()
        txtEmail.Clear()

        ' Puts focus back on first name
        txtFirstName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddGolfer_Click(sender As Object, e As EventArgs) Handles btnAddGolfer.Click
        ' variables for new player data and select and insert statements
        Dim strSelect As String
        Dim strInsert As String
        Dim strFirstName As String = ""
        Dim strLastName As String = ""
        Dim strStreetAddress As String = ""
        Dim strCity As String = ""
        Dim strState As String = ""
        Dim strZip As String = ""
        Dim strPhoneNumber As String = ""
        Dim strEmail As String = ""
        Dim intGenderID = cboGender.SelectedIndex + 1
        Dim intShirtSizeID = cboShirtSize.SelectedIndex + 1

        Try

            ' validate data is entered
            If Validation() = True Then

                ' put values into strings
                strFirstName = txtFirstName.Text
                strLastName = txtLastName.Text
                strStreetAddress = txtStreetAddress.Text
                strCity = txtCity.Text
                strState = txtState.Text
                strZip = txtZip.Text
                strPhoneNumber = txtPhoneNumber.Text
                strEmail = txtEmail.Text


                ' call sub to add golfer to the database 
                AddGolfer(strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail, intShirtSizeID, intGenderID)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Load_ShirtSize()
        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

            ' open the DB this is in module
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If



            ' Build the select statement
            strSelect = "SELECT intShirtSizeID, strShirtSizeDesc FROM TShirtSizes"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            ' Add the item to the combo box. We need the shirtSize ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the golfer data.
            ' We are binding the column name to the combo box display and value members. 
            cboShirtSize.ValueMember = "intShirtSizeID"
            cboShirtSize.DisplayMember = "strShirtSizeDesc"
            cboShirtSize.DataSource = dt

            ' Select the first item in the list by default
            ' If cboShirtSize.Items.Count > 0 Then cboShirtSize.SelectedIndex = 0

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()


        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Load_Gender()
        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

            ' open the DB this is in module
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If



            ' Build the select statement
            strSelect = "SELECT intGenderID, strGenderDesc FROM TGenders"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            ' Add the item to the combo box. We need the gender ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the golfer data.
            ' We are binding the column name to the combo box display and value members. 
            cboGender.ValueMember = "intGenderID"
            cboGender.DisplayMember = "strGenderDesc"
            cboGender.DataSource = dt

            ' Select the first item in the list by default
            ' If cboGender.Items.Count > 0 Then cboGender.SelectedIndex = 0

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()


        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub AddGolfer(ByVal FirstName As String, ByVal LastName As String, ByVal StreetAddress As String, ByVal City As String, ByVal State As String, ByVal Zip As String, ByVal PhoneNumber As String, ByVal Email As String, ByVal ShirtSizeID As Integer, ByVal GenderID As Integer)
        ' Create command object and integer for number of returned rows
        Dim cmdAddGolfer As New OleDb.OleDbCommand
        Dim intPKID As Integer                      ' Primary Key value, required by stored procedure
        Dim intRowsAffected As Integer              ' how many rows were affected when sql executed

        Try


            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Call procedure
            cmdAddGolfer.CommandText = "EXECUTE uspAddGolfer '" & intPKID & "','" & FirstName & "','" & LastName & "','" & StreetAddress & "','" & City & "','" & State & "','" & Zip & "','" & PhoneNumber & "','" & Email & "','" & ShirtSizeID & "','" & GenderID & "'"
            cmdAddGolfer.CommandType = CommandType.StoredProcedure

            ' Call to procedure which will insert the record
            cmdAddGolfer = New OleDb.OleDbCommand(cmdAddGolfer.CommandText, m_conAdministrator)


            ' returns the # of rows affected
            intRowsAffected = cmdAddGolfer.ExecuteNonQuery()


            CloseDatabaseConnection()       ' close connection if insert didn't work

            If intRowsAffected > 0 Then
                MessageBox.Show("Insert Successful, Player " & LastName & " has been added.")
            Else

            End If

            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function Validation() As Boolean
        ' loop through the textboxes and check to make sure there is data in them
        For Each cntrl As Control In GolferInfo.Controls
            If TypeOf cntrl Is TextBox Then
                cntrl.BackColor = Color.White
                If cntrl.Text = String.Empty Then
                    cntrl.BackColor = Color.Yellow
                    cntrl.Focus()
                    '  MessageBox.Show("Something is blank! ")
                    Return False
                End If
            End If
        Next

        'every this is good so return true
        Return True

    End Function

    Private Sub GolferInfo_Enter(sender As Object, e As EventArgs) Handles GolferInfo.Enter

    End Sub
End Class