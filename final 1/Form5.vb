Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class clientForm
    Inherits Form

    Private connectionString As String = "server=localhost;database=supermarket;uid=root;password=123456;"
    Private cart As New List(Of Product)
    Private _username As String

    Public Class Product
        Public Property Name As String
        Public Property Price As Decimal
    End Class

    Public Sub New(username As String)
        ' Initialize components
        InitializeComponent()
        ' Store the username
        _username = username
    End Sub

    Private Sub clientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Try
            Dim dt As New DataTable()
            Using connection As New MySqlConnection(connectionString)
                Dim commandText As String = "SELECT p_name, p_price FROM products;"
                Using command As New MySqlCommand(commandText, connection)
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateCartTextBox()
        cartTB.Text = String.Join(Environment.NewLine, cart.Select(Function(p) $"Name: {p.Name}, Price: {p.Price:C}"))
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If cart.Count = 0 Then
            MessageBox.Show("Your cart is empty. Please add items before checkout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim totalPrice As Decimal = cart.Sum(Function(p) p.Price)
        SaveOrder(totalPrice)
    End Sub

    Private Sub bckButton_Click(sender As Object, e As EventArgs) Handles bckButton.Click
        Dim loginForm As New loginForm()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub addBttn_Click(sender As Object, e As EventArgs) Handles addBttn.Click
        If dgv.SelectedRows.Count > 0 Then
            Dim selectedRow = dgv.SelectedRows(0)
            Dim product As New Product()
            product.Name = selectedRow.Cells("p_name").Value.ToString()
            product.Price = Convert.ToDecimal(selectedRow.Cells("p_price").Value)
            cart.Add(product)
            MessageBox.Show($"Added {product.Name} to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateCartTextBox()
        Else
            MessageBox.Show("Please select a product to add to the cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SaveOrder(totalPrice As Decimal)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Combine all product names for insertion
                Dim itemList As String = String.Join(", ", cart.Select(Function(p) p.Name))

                ' Insert the total, user, and concatenated item names into the orders table
                Dim query As String = "INSERT INTO orders (total, user, items) VALUES (@TotalPrice, @Username, @Items);"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@TotalPrice", totalPrice)
                    command.Parameters.AddWithValue("@Username", _username)
                    command.Parameters.AddWithValue("@Items", itemList)
                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

            cart.Clear()
            UpdateCartTextBox()
        Catch ex As Exception
            MessageBox.Show($"Error saving order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class