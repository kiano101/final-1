<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        username_t = New TextBox()
        password_t = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        log_bttn = New Button()
        extButton = New Button()
        SuspendLayout()
        ' 
        ' username_t
        ' 
        username_t.Location = New Point(164, 66)
        username_t.Name = "username_t"
        username_t.Size = New Size(219, 27)
        username_t.TabIndex = 0
        ' 
        ' password_t
        ' 
        password_t.Location = New Point(164, 126)
        password_t.Name = "password_t"
        password_t.Size = New Size(219, 27)
        password_t.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 2
        Label1.Text = "username :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 3
        Label2.Text = "password :"
        ' 
        ' log_bttn
        ' 
        log_bttn.Location = New Point(164, 200)
        log_bttn.Name = "log_bttn"
        log_bttn.Size = New Size(94, 34)
        log_bttn.TabIndex = 4
        log_bttn.Text = "login"
        log_bttn.UseVisualStyleBackColor = True
        ' 
        ' extButton
        ' 
        extButton.Location = New Point(374, 368)
        extButton.Name = "extButton"
        extButton.Size = New Size(94, 29)
        extButton.TabIndex = 5
        extButton.Text = "Exit"
        extButton.UseVisualStyleBackColor = True
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 409)
        Controls.Add(extButton)
        Controls.Add(log_bttn)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(password_t)
        Controls.Add(username_t)
        Name = "loginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents username_t As TextBox
    Friend WithEvents password_t As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents log_bttn As Button
    Friend WithEvents extButton As Button

End Class
