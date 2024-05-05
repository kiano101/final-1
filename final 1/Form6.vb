Imports System.Text
Imports MySql.Data.MySqlClient

Public Class addUsers
    Private Sub addUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private connectionString = "server=localhost;database=supermarket;uid=root;password=123456;"
        Private Sub LoadData()
            Try
                Dim dt As New DataTable()
                Using connection As New MySqlConnection(connectionString)
                Dim commandText As String = "SELECT * FROM users;"
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
        Private Sub DeleteFromDatabase(id As Integer)
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                Dim commandText As String = "DELETE FROM users WHERE idusers = @id"
                Using command As New MySqlCommand(commandText, connection)
                        command.Parameters.AddWithValue("@id", id)
                        command.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub


    Private Function AddProduct(usern As String, pass As String) As Boolean
        Dim query As String = "INSERT INTO users (username, password) VALUES (@usern, @pass)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@usern", usern)
                command.Parameters.AddWithValue("@pass", pass)

                Try
                    connection.Open()
                    Return command.ExecuteNonQuery() > 0
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub addButtn_Click(sender As Object, e As EventArgs) Handles addButtn.Click
        Dim usern As String = userText.Text
        Dim pass As String = passText.Text

        If AddProduct(usern, pass) Then
            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            userText.Clear()
            passText.Clear()
        Else
            MessageBox.Show("Failed to add user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
            LoadData()
        End Sub
        Private Sub bckButton_Click(sender As Object, e As EventArgs) Handles bckButton.Click
            Dim adminForm As New adminForm()
            adminForm.Show()
            Me.Close()
        End Sub

    Private Sub dltBttn_Click(sender As Object, e As EventArgs) Handles dltBttn.Click
        If dgv.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgv.SelectedRows(0)
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("idusers").Value)
            dgv.Rows.Remove(selectedRow)
            DeleteFromDatabase(id)
        Else
            MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class