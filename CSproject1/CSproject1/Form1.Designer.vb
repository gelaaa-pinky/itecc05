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
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        MULTIPLY = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.HotPink
        Button1.Location = New Point(48, 314)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 49)
        Button1.TabIndex = 0
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(111, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 1
        Label1.Text = "First Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(215, 59)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(204, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(110, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 3
        Label2.Text = "Second Number"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(215, 101)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(204, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Orchid
        Button2.Location = New Point(176, 314)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 49)
        Button2.TabIndex = 5
        Button2.Text = "SUBTRACT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(305, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(171, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 32)
        Label4.TabIndex = 7
        Label4.Text = "ANSWER:"
        ' 
        ' MULTIPLY
        ' 
        MULTIPLY.Location = New Point(305, 314)
        MULTIPLY.Name = "MULTIPLY"
        MULTIPLY.Size = New Size(99, 49)
        MULTIPLY.TabIndex = 8
        MULTIPLY.Text = "MULTIPLY"
        MULTIPLY.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(425, 315)
        Button3.Name = "Button3"
        Button3.Size = New Size(95, 48)
        Button3.TabIndex = 9
        Button3.Text = "DIVIDE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(MULTIPLY)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MULTIPLY As Button
    Friend WithEvents Button3 As Button

End Class
