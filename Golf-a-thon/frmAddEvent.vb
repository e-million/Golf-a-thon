Public Class frmAddEvent

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        ' variables for new event year data and select and insert statements
        Dim strEventYear As String = ""



        Try

            ' validate data is entered
            If Validation() = True Then
                ' put values into strings
                strEventYear = txtEventYear.Text

                AddEventYear(strEventYear)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub AddEventYear(ByVal EventYear As String)
        ' Create command object and integer for number of returned rows
        Dim cmdAddEventYear As New OleDb.OleDbCommand
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
            cmdAddEventYear.CommandText = "EXECUTE uspAddEventYear '" & intPKID & "','" & EventYear & "'"
            cmdAddEventYear.CommandType = CommandType.StoredProcedure

            ' Call to procedure which will insert the record
            cmdAddEventYear = New OleDb.OleDbCommand(cmdAddEventYear.CommandText, m_conAdministrator)


            ' returns the # of rows affected
            intRowsAffected = cmdAddEventYear.ExecuteNonQuery()


            CloseDatabaseConnection()       ' close connection if insert didn't work

            If intRowsAffected > 0 Then
                MessageBox.Show("Insert Successful, Event " & EventYear & " has been added.")
            Else

            End If

            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function Validation() As Boolean

        If txtEventYear.Text = String.Empty Then
            txtEventYear.BackColor = Color.Yellow
            txtEventYear.Focus()
            Return False
        Else
            Return True
        End If

    End Function

End Class