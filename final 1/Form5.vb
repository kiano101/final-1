Imports MySql.Data.MySqlClient

Public Class clientForm

    Dim connectionString As String = "server=localhost;database=supermarket;uid=root;password=123456;"
    Dim cart As New List(Of product)

    Public Class product
        Public Property Name As String
        Public Property Price As Decimal
    End Class

    Private Sub clientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Try
            Dim dt As New DataTable()
            Using connection As New MySqlConnection(connectionString)
                Dim commandText As String = "SELECT p_name, p_price FROM products;"
                Dim command As New MySqlCommand(commandText, connection)

                connection.Open()

                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
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
            Exit Sub
        End If

        Try
            Dim totalPrice As Decimal = cart.Sum(Function(p) p.Price)
            SaveOrder(totalPrice)
        Catch ex As Exception
            MessageBox.Show($"Error processing checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bckButton_Click(sender As Object, e As EventArgs) Handles bckButton.Click
        Dim loginForm As New loginForm()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub addBttn_Click(sender As Object, e As EventArgs) Handles addBttn.Click
        If dgv.SelectedRows.Count > 0 Then
            Dim selectedRow = dgv.SelectedRows(0)
            Dim product As New product()
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

                Dim query As String = "INSERT INTO orders (total) VALUES (@TotalPrice); SELECT LAST_INSERT_ID();"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@TotalPrice", totalPrice)
                Dim orderId As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' Insert order details (products) into OrderDetails table
                For Each product In cart
                    query = "INSERT INTO OrderDetails (order_id, product_name, product_price) VALUES (@OrderId, @ProductName, @ProductPrice)"
                    command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@OrderId", orderId)
                    command.Parameters.AddWithValue("@ProductName", product.Name)
                    command.Parameters.AddWithValue("@ProductPrice", product.Price)
                    command.ExecuteNonQuery()
                Next

                MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

            ' Clear the cart after checkout
            cart.Clear()
            UpdateCartTextBox()
        Catch ex As Exception
            MessageBox.Show($"Error saving order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class