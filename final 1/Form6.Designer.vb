<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addUsers
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
        dgv = New DataGridView()
        bckButton = New Button()
        Label2 = New Label()
        Label1 = New Label()
        dltBttn = New Button()
        addButtn = New Button()
        passText = New TextBox()
        userText = New TextBox()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(12, 106)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.RowHeadersWidth = 51
        dgv.Size = New Size(776, 297)
        dgv.TabIndex = 16
        ' 
        ' bckButton
        ' 
        bckButton.Location = New Point(694, 409)
        bckButton.Name = "bckButton"
        bckButton.Size = New Size(94, 29)
        bckButton.TabIndex = 15
        bckButton.Text = "Back"
        bckButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 14
        Label2.Text = "Password :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 13
        Label1.Text = "Username :"
        ' 
        ' dltBttn
        ' 
        dltBttn.Location = New Point(433, 71)
        dltBttn.Name = "dltBttn"
        dltBttn.Size = New Size(94, 29)
        dltBttn.TabIndex = 12
        dltBttn.Text = "Delete"
        dltBttn.UseVisualStyleBackColor = True
        ' 
        ' addButtn
        ' 
        addButtn.Location = New Point(433, 26)
        addButtn.Name = "addButtn"
        addButtn.Size = New Size(94, 29)
        addButtn.TabIndex = 11
        addButtn.Text = "Add"
        addButtn.UseVisualStyleBackColor = True
        ' 
        ' passText
        ' 
        passText.Location = New Point(175, 68)
        passText.Name = "passText"
        passText.Size = New Size(176, 27)
        passText.TabIndex = 10
        ' 
        ' userText
        ' 
        userText.Location = New Point(175, 26)
        userText.Name = "userText"
        userText.Size = New Size(176, 27)
        userText.TabIndex = 9
        ' 
        ' addUsers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgv)
        Controls.Add(bckButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dltBttn)
        Controls.Add(addButtn)
        Controls.Add(passText)
        Controls.Add(userText)
        Name = "addUsers"
        Text = "Users"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents bckButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dltBttn As Button
    Friend WithEvents addButtn As Button
    Friend WithEvents passText As TextBox
    Friend WithEvents userText As TextBox
End Class
