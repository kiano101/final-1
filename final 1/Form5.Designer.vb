<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        bckButton = New Button()
        addBttn = New Button()
        btnCheckout = New Button()
        dgv = New DataGridView()
        cartTB = New TextBox()
        totalTB = New TextBox()
        Label1 = New Label()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bckButton
        ' 
        bckButton.Location = New Point(694, 409)
        bckButton.Name = "bckButton"
        bckButton.Size = New Size(94, 29)
        bckButton.TabIndex = 0
        bckButton.Text = "Back"
        bckButton.UseVisualStyleBackColor = True
        ' 
        ' addBttn
        ' 
        addBttn.Location = New Point(12, 409)
        addBttn.Name = "addBttn"
        addBttn.Size = New Size(94, 29)
        addBttn.TabIndex = 1
        addBttn.Text = "Add"
        addBttn.UseVisualStyleBackColor = True
        ' 
        ' btnCheckout
        ' 
        btnCheckout.Location = New Point(112, 409)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(94, 29)
        btnCheckout.TabIndex = 2
        btnCheckout.Text = "Check Out"
        btnCheckout.UseVisualStyleBackColor = True
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(12, 12)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.RowHeadersWidth = 51
        dgv.Size = New Size(511, 391)
        dgv.TabIndex = 3
        ' 
        ' cartTB
        ' 
        cartTB.Location = New Point(540, 12)
        cartTB.Multiline = True
        cartTB.Name = "cartTB"
        cartTB.Size = New Size(248, 349)
        cartTB.TabIndex = 4
        ' 
        ' totalTB
        ' 
        totalTB.Location = New Point(595, 368)
        totalTB.Name = "totalTB"
        totalTB.Size = New Size(193, 27)
        totalTB.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(540, 371)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 6
        Label1.Text = "Total :"
        ' 
        ' clientForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(totalTB)
        Controls.Add(cartTB)
        Controls.Add(dgv)
        Controls.Add(btnCheckout)
        Controls.Add(addBttn)
        Controls.Add(bckButton)
        Name = "clientForm"
        Text = "Client"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bckButton As Button
    Friend WithEvents addBttn As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents cartTB As TextBox
    Friend WithEvents totalTB As TextBox
    Friend WithEvents Label1 As Label
End Class
