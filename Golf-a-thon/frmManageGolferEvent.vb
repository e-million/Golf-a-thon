Public Class frmManageGolferEvent
    '  "SELECT TG.intGolferID As GOLFER_ID, TG.strLastName As LASTNAME FROM TGolfers As TG, TGolferEventYears As TGE  WHERE TGE.intEventYearID = " & cboEvents.SelectedIndex
    Private Sub frmManageGolferEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' form load will load the combo box. If you setup the combo box with a
        ' selected index change (see below) it will load the players from the
        ' team selected into to team players list box. Form load will also pull 
        ' players from the view in the DB that has players not on a team and load
        ' them into the Available players list box.

        Try

            ' *************************************************************************************
            ' LOAD Years COMBO BOX
            ' *************************************************************************************

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader


            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Show changes all at once at end (MUCH faster). 
            cboEvents.BeginUpdate()

            ' Build the select statement for combo box for teams
            strSelect = "SELECT intEventYearID, intEventYear FROM TEventYears"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)


            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboEvents.ValueMember = "intEventYearID"
            cboEvents.DisplayMember = "intEventYear"
            cboEvents.DataSource = dt

            ' Select the first item in the list by default
            If cboEvents.Items.Count > 0 Then cboEvents.SelectedIndex = 0

            ' Show any changes
            cboEvents.EndUpdate()

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

            ' Load golfers in events
            LoadGolferEvents()
            'LoadAvailableGolfers()





        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub
    Private Sub cboEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEvents.SelectedIndexChanged
        ' create this SUB by double clicking on the combo box. This will load
        ' players on team based on index (DB PK) into the list box for team 
        ' players when combo box index changes.
        Try
            LoadGolferEvents()
            LoadAvailableGolfers()
        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub btnAddGolfer_Click(sender As Object, e As EventArgs) Handles btnAddGolfer.Click
        ' Create command object and integer for number of returned rows
        Dim cmdAddGolferYear As New OleDb.OleDbCommand
        Dim intPKID As Integer                      ' Primary Key value, required by stored procedure
        Dim intRowsAffected As Integer              ' how many rows were affected when sql executed

        Dim GolferID As Integer = lstAvailableGolfers.SelectedIndex + 1
        Dim EventYearID As Integer = cboEvents.SelectedIndex + 1

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
            cmdAddGolferYear.CommandText = "EXECUTE uspAddGolferYear '" & intPKID & "','" & GolferID & "','" & EventYearID & "'"
            cmdAddGolferYear.CommandType = CommandType.StoredProcedure

            ' Call to procedure which will insert the record
            cmdAddGolferYear = New OleDb.OleDbCommand(cmdAddGolferYear.CommandText, m_conAdministrator)


            ' returns the # of rows affected
            intRowsAffected = cmdAddGolferYear.ExecuteNonQuery()


            CloseDatabaseConnection()       ' close connection if insert didn't work

            If intRowsAffected > 0 Then
                MessageBox.Show("Insert Successful, Golfer " & GolferID & " has been added to Event Year " & EventYearID)
            Else

            End If

            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDropGolfer_Click(sender As Object, e As EventArgs) Handles btnDropGolfer.Click
        Dim strDelete1 As String = ""
        Dim strSelect As String = String.Empty
        Dim strName As String = ""
        Dim intRowsAffected As Integer
        Dim cmdDelete As OleDb.OleDbCommand ' this will be used for our Delete statement
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
        Dim result As DialogResult

        Try



            ' open the database
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' always ask before deleting!!!!
            result = MessageBox.Show("Are you sure you want to Delete Player: Last Name-" & lstInEvent.Text & " from " & cboEvents.Text & " ?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            ' this will figure out which button was selected. Cancel and No does nothing, Yes will allow deletion
            Select Case result
                Case DialogResult.Cancel
                    MessageBox.Show("Action Canceled")
                Case DialogResult.No
                    MessageBox.Show("Action Canceled")
                Case DialogResult.Yes

                    ' delete child tables first
                    strDelete1 = "Delete FROM TGolferEventYearSponsors  Where intEventYearID = " & cboEvents.SelectedIndex + 1 & " Delete FROM TGolferEventYears Where intEventYearID = " & cboEvents.SelectedIndex + 1

                    ' Delete the record(s) 
                    cmdDelete = New OleDb.OleDbCommand(strDelete1, m_conAdministrator)
                    intRowsAffected = cmdDelete.ExecuteNonQuery()


            End Select


            ' close the database connection
            CloseDatabaseConnection()

            ' refresh the form so changes can be seen
            frmManageGolferEvent_Load(sender, e)

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub AddGolferEvent(ByVal GolferID As Integer, ByVal EventYearID As Integer)
        ' Create command object and integer for number of returned rows
        Dim cmdAddGolferYear As New OleDb.OleDbCommand
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
            cmdAddGolferYear.CommandText = "EXECUTE uspAddGolferYear '" & intPKID & "','" & GolferID & "','" & EventYearID & "'"
            cmdAddGolferYear.CommandType = CommandType.StoredProcedure

            ' Call to procedure which will insert the record
            cmdAddGolferYear = New OleDb.OleDbCommand(cmdAddGolferYear.CommandText, m_conAdministrator)


            ' returns the # of rows affected
            intRowsAffected = cmdAddGolferYear.ExecuteNonQuery()


            CloseDatabaseConnection()       ' close connection if insert didn't work

            If intRowsAffected > 0 Then
                MessageBox.Show("Insert Successful, Golfer " & GolferID & " has been added to Event Year " & EventYearID)
            Else

            End If

            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub








    Private Sub LoadGolferEvents()


        Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader


            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Show changes all at once at end (MUCH faster). 
            lstInEvent.BeginUpdate()

            ' Build the select statement for listbox with players on team selected
            strSelect = "SELECT TG.intGolferID AS GolferID, TG.strLastName AS LastName
                         FROM TGolfers AS TG, TGolferEventYears AS TGE 
                         WHERE TGE.intEventYearID = " + (cboEvents.SelectedIndex + 1).ToString() + " AND TG.intGolferID = TGE.intGolferID"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)


            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            lstInEvent.ValueMember = "GolferID"
            lstInEvent.DisplayMember = "LastName"
            lstInEvent.DataSource = dt

            ' Select the first item in the list by default
            If lstInEvent.Items.Count > 0 Then lstInEvent.SelectedIndex = 0

            ' Show any changes
            lstInEvent.EndUpdate()

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()




    End Sub

    Private Sub LoadAvailableGolfers()
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader


        ' open the DB
        If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Show changes all at once at end (MUCH faster). 
            lstAvailableGolfers.BeginUpdate()

        ' Build the select statement
        strSelect = "SELECT DISTINCT TG.intGolferID AS GolferID, TG.strLastName AS LastName FROM TGolfers AS TG WHERE TG.intGolferID NOT IN (SELECT intGolferID FROM TGolferEventYears
                     WHERE intEventYearID = " + (cboEvents.SelectedIndex + 1).ToString() + ")" 'AND TG.intGolferID = TGE.intGolferID)"

        MessageBox.Show(strSelect)

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)


            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            lstAvailableGolfers.ValueMember = "GolferID"
        lstAvailableGolfers.DisplayMember = "LastName"
        lstAvailableGolfers.DataSource = dt



            ' Select the first item in the list by default
            If lstAvailableGolfers.Items.Count > 0 Then lstAvailableGolfers.SelectedIndex = 0

            ' Show any changes
            lstAvailableGolfers.EndUpdate()

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()


    End Sub

    Private Sub btnManageSponsors_Click(sender As Object, e As EventArgs) Handles btnManageSponsors.Click
        ' frmManageSponsors.ShowDialog() ' Opens manageSponsors form
    End Sub
End Class