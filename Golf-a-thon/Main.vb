Public Class frmMain
    Private Sub btnGolfers_Click(sender As Object, e As EventArgs) Handles btnGolfers.Click
        frmGolfers.ShowDialog()
    End Sub

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        frmEvents.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ManageGolfersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageGolfersToolStripMenuItem.Click
        frmGolfers.ShowDialog()
    End Sub

    Private Sub ManageEventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageEventsToolStripMenuItem.Click
        frmEvents.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmManageGolferEvent.ShowDialog()
    End Sub

    Private Sub ManageGolfersEventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageGolfersEventsToolStripMenuItem.Click
        frmManageGolferEvent.ShowDialog()
    End Sub
End Class
