Imports MySql.Data.MySqlClient

Public Class adminForm
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim products As New products()
        products.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim orders As New orders()
        orders.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim loginForm As New loginForm()
        loginForm.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim addUsers As New addUsers()
        addUsers.Show()
        Me.Hide()
    End Sub
End Class