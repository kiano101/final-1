<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class products
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
        pnameText = New TextBox()
        ppriceText = New TextBox()
        addButtn = New Button()
        dltBttn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        bckButton = New Button()
        dgv = New DataGridView()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnameText
        ' 
        pnameText.Location = New Point(175, 40)
        pnameText.Name = "pnameText"
        pnameText.Size = New Size(176, 27)
        pnameText.TabIndex = 0
        ' 
        ' ppriceText
        ' 
        ppriceText.Location = New Point(175, 82)
        ppriceText.Name = "ppriceText"
        ppriceText.Size = New Size(176, 27)
        ppriceText.TabIndex = 1
        ' 
        ' addButtn
        ' 
        addButtn.Location = New Point(433, 40)
        addButtn.Name = "addButtn"
        addButtn.Size = New Size(94, 29)
        addButtn.TabIndex = 2
        addButtn.Text = "Add"
        addButtn.UseVisualStyleBackColor = True
        ' 
        ' dltBttn
        ' 
        dltBttn.Location = New Point(433, 85)
        dltBttn.Name = "dltBttn"
        dltBttn.Size = New Size(94, 29)
        dltBttn.TabIndex = 3
        dltBttn.Text = "Delete"
        dltBttn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 20)
        Label1.TabIndex = 4
        Label1.Text = "Product name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 5
        Label2.Text = "Price :"
        ' 
        ' bckButton
        ' 
        bckButton.Location = New Point(694, 409)
        bckButton.Name = "bckButton"
        bckButton.Size = New Size(94, 29)
        bckButton.TabIndex = 7
        bckButton.Text = "Back"
        bckButton.UseVisualStyleBackColor = True
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(12, 120)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.RowHeadersWidth = 51
        dgv.Size = New Size(776, 283)
        dgv.TabIndex = 8
        ' 
        ' products
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
        Controls.Add(ppriceText)
        Controls.Add(pnameText)
        Name = "products"
        Text = "products"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnameText As TextBox
    Friend WithEvents ppriceText As TextBox
    Friend WithEvents addButtn As Button
    Friend WithEvents dltBttn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bckButton As Button
    Friend WithEvents dgv As DataGridView
End Class
