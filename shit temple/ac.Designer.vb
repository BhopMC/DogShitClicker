<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ac
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.keybinds = New System.Windows.Forms.Timer(Me.components)
        Me.HexTheme1 = New dogshit.HexTheme()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HexClose1 = New dogshit.HexClose()
        Me.HexMini1 = New dogshit.HexMini()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HexButton1 = New dogshit.HexButton()
        Me.HexTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'keybinds
        '
        '
        'HexTheme1
        '
        Me.HexTheme1.Controls.Add(Me.Label3)
        Me.HexTheme1.Controls.Add(Me.Label2)
        Me.HexTheme1.Controls.Add(Me.HexClose1)
        Me.HexTheme1.Controls.Add(Me.HexMini1)
        Me.HexTheme1.Controls.Add(Me.Label1)
        Me.HexTheme1.Controls.Add(Me.HexButton1)
        Me.HexTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HexTheme1.Location = New System.Drawing.Point(0, 0)
        Me.HexTheme1.Name = "HexTheme1"
        Me.HexTheme1.Size = New System.Drawing.Size(229, 220)
        Me.HexTheme1.TabIndex = 0
        Me.HexTheme1.Text = "dog shit clicker"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(93, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hide: F5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(69, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enable / Disable: F4"
        '
        'HexClose1
        '
        Me.HexClose1.Location = New System.Drawing.Point(214, 10)
        Me.HexClose1.Name = "HexClose1"
        Me.HexClose1.Size = New System.Drawing.Size(12, 12)
        Me.HexClose1.TabIndex = 5
        Me.HexClose1.Text = "HexClose1"
        '
        'HexMini1
        '
        Me.HexMini1.Location = New System.Drawing.Point(196, 6)
        Me.HexMini1.Name = "HexMini1"
        Me.HexMini1.Size = New System.Drawing.Size(12, 12)
        Me.HexMini1.TabIndex = 4
        Me.HexMini1.Text = "HexMini1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "@BhopMC"
        '
        'HexButton1
        '
        Me.HexButton1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexButton1.ForeColor = System.Drawing.Color.White
        Me.HexButton1.Location = New System.Drawing.Point(22, 80)
        Me.HexButton1.Name = "HexButton1"
        Me.HexButton1.Size = New System.Drawing.Size(186, 30)
        Me.HexButton1.TabIndex = 0
        Me.HexButton1.Text = "Start"
        '
        'ac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 220)
        Me.Controls.Add(Me.HexTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ac"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.HexTheme1.ResumeLayout(False)
        Me.HexTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HexTheme1 As HexTheme
    Friend WithEvents HexButton1 As HexButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents HexClose1 As HexClose
    Friend WithEvents HexMini1 As HexMini
    Friend WithEvents keybinds As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
