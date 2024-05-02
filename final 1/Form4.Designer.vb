<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orders
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
        dgv = New DataGridView()
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
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(12, 12)
        dgv.Name = "dgv"
        dgv.RowHeadersWidth = 51
        dgv.Size = New Size(776, 391)
        dgv.TabIndex = 1
        ' 
        ' orders
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgv)
        Controls.Add(bckButton)
        Name = "orders"
        Text = "orders"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents bckButton As Button
    Friend WithEvents dgv As DataGridView
End Class
