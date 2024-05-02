Imports MySql.Data.MySqlClient
Imports System.Text

Public Class orders
    Dim connectionString = "server=localhost;database=supermarket;uid=root;password=123456;"
    Private Sub LoadData()
        Try
            Dim dt As New DataTable()
            Using connection As New MySqlConnection(connectionString)
                Dim commandText As String = "SELECT idorders, user, items, date FROM orders;"
                Dim command As New MySqlCommand(commandText, connection)

                connection.Open()

                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
            End Using

            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub bckButton_Click(sender As Object, e As EventArgs) Handles bckButton.Click
        Dim adminFrom As New adminForm()
        adminForm.Show()
        Me.Close()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class