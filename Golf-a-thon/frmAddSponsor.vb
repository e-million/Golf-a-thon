Public Class frmAddSponsor
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' CLose the form 
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm() ' Clears form
    End Sub

    Private Sub btnAddSponsor_Click(sender As Object, e As EventArgs) Handles btnAddSponsor.Click
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


                ' call sub to add Sponsor to the database 
                AddSponsor(strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddSponsor(ByVal FirstName As String, ByVal LastName As String, ByVal StreetAddress As String, ByVal City As String, ByVal State As String, ByVal Zip As String, ByVal PhoneNumber As String, ByVal Email As String)
        ' Create command object and integer for number of returned rows
        Dim cmdAddSponsor As New OleDb.OleDbCommand
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
            cmdAddSponsor.CommandText = "EXECUTE uspAddSponsor '" & intPKID & "','" & FirstName & "','" & LastName & "','" & StreetAddress & "','" & City & "','" & State & "','" & Zip & "','" & PhoneNumber & "','" & Email & "'"
            cmdAddSponsor.CommandType = CommandType.StoredProcedure

            ' Call to procedure which will insert the record
            cmdAddSponsor = New OleDb.OleDbCommand(cmdAddSponsor.CommandText, m_conAdministrator)


            ' returns the # of rows affected
            intRowsAffected = cmdAddSponsor.ExecuteNonQuery()


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
        For Each cntrl As Control In SponsorInfo.Controls
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

End Class