<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtFirstNum = New TextBox()
        Label1 = New Label()
        txtSecNum = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' txtFirstNum
        ' 
        txtFirstNum.Location = New Point(28, 41)
        txtFirstNum.Name = "txtFirstNum"
        txtFirstNum.Size = New Size(190, 23)
        txtFirstNum.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 1
        Label1.Text = "FIRST NUMBER:"
        ' 
        ' txtSecNum
        ' 
        txtSecNum.Location = New Point(28, 100)
        txtSecNum.Name = "txtSecNum"
        txtSecNum.Size = New Size(192, 23)
        txtSecNum.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 15)
        Label2.TabIndex = 3
        Label2.Text = "SECOND NUMBER:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(28, 144)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 26)
        Button1.TabIndex = 4
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(54, 187)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(41, 15)
        lblResult.TabIndex = 5
        lblResult.Text = "Label3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(412, 450)
        Controls.Add(lblResult)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(txtSecNum)
        Controls.Add(Label1)
        Controls.Add(txtFirstNum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSecNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResult As Label
End Class
