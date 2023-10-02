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
        btnSayHi = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' btnSayHi
        ' 
        btnSayHi.ForeColor = SystemColors.WindowText
        btnSayHi.Location = New Point(329, 306)
        btnSayHi.Name = "btnSayHi"
        btnSayHi.Size = New Size(109, 45)
        btnSayHi.TabIndex = 0
        btnSayHi.Text = "Say Hi"
        btnSayHi.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("SimSun", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TextBox1.Location = New Point(211, 88)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(410, 44)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Welcome! Siyakwamukela!"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("SimSun", 18F, FontStyle.Italic, GraphicsUnit.Point)
        TextBox2.Location = New Point(253, 201)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(308, 35)
        TextBox2.TabIndex = 2
        TextBox2.Text = "We Would Like To Know You"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnSayHi)
        Cursor = Cursors.IBeam
        ForeColor = SystemColors.ControlDark
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSayHi As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
