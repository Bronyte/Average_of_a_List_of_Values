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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Input = New System.Windows.Forms.TextBox()
        Me.Button_Calculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Output = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter the numbers. Entries should be seperated by comas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(39, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "e.g.: 10,3,101,40, ..."
        '
        'TextBox_Input
        '
        Me.TextBox_Input.Location = New System.Drawing.Point(12, 51)
        Me.TextBox_Input.Name = "TextBox_Input"
        Me.TextBox_Input.Size = New System.Drawing.Size(344, 23)
        Me.TextBox_Input.TabIndex = 2
        '
        'Button_Calculate
        '
        Me.Button_Calculate.Location = New System.Drawing.Point(12, 92)
        Me.Button_Calculate.Name = "Button_Calculate"
        Me.Button_Calculate.Size = New System.Drawing.Size(131, 23)
        Me.Button_Calculate.TabIndex = 3
        Me.Button_Calculate.Text = "Calculate"
        Me.Button_Calculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Average:"
        '
        'TextBox_Output
        '
        Me.TextBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Output.Location = New System.Drawing.Point(219, 99)
        Me.TextBox_Output.Name = "TextBox_Output"
        Me.TextBox_Output.ReadOnly = True
        Me.TextBox_Output.Size = New System.Drawing.Size(137, 16)
        Me.TextBox_Output.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 127)
        Me.Controls.Add(Me.TextBox_Output)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_Calculate)
        Me.Controls.Add(Me.TextBox_Input)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Average Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Input As TextBox
    Friend WithEvents Button_Calculate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Output As TextBox
End Class
