Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class loginForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password_t.PasswordChar = "*"c
    End Sub

    Private Sub log_bttn_Click(sender As Object, e As EventArgs) Handles log_bttn.Click
        Dim username As String = username_t.Text
        Dim password As String = password_t.Text

        If username.ToLower() = "admin" AndAlso password.ToLower() = "admin" Then
            Dim adminForm As New adminForm()
            adminForm.Show()
            Me.Hide()
        ElseIf AuthenticateUser(username, password) Then
            Dim clientForm As New clientForm(username)
            clientForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            username_t.Clear()
            password_t.Clear()
        End If
    End Sub
    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim connectionString As String = "server=localhost;database=supermarket;uid=root;password=123456;"
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub extButton_Click(sender As Object, e As EventArgs) Handles extButton.Click
        Application.Exit()
    End Sub
End Class

Module Program
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New loginForm())
    End Sub
End Module