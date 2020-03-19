<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.PictureBoxBan = New System.Windows.Forms.PictureBox()
        Me.Labelincorrect = New System.Windows.Forms.Label()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        CType(Me.PictureBoxBan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.ForeColor = System.Drawing.Color.White
        Me.TextBoxName.Location = New System.Drawing.Point(288, 614)
        Me.TextBoxName.MaximumSize = New System.Drawing.Size(398, 35)
        Me.TextBoxName.MinimumSize = New System.Drawing.Size(398, 35)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(398, 35)
        Me.TextBoxName.TabIndex = 0
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnter.Location = New System.Drawing.Point(288, 655)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(398, 35)
        Me.ButtonEnter.TabIndex = 1
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.ForeColor = System.Drawing.Color.Magenta
        Me.LabelName.Location = New System.Drawing.Point(299, 620)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(68, 25)
        Me.LabelName.TabIndex = 18
        Me.LabelName.Text = "Name"
        '
        'PictureBoxBan
        '
        Me.PictureBoxBan.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxBan.BackgroundImage = CType(resources.GetObject("PictureBoxBan.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxBan.Location = New System.Drawing.Point(296, 588)
        Me.PictureBoxBan.Name = "PictureBoxBan"
        Me.PictureBoxBan.Size = New System.Drawing.Size(16, 16)
        Me.PictureBoxBan.TabIndex = 20
        Me.PictureBoxBan.TabStop = False
        Me.PictureBoxBan.Visible = False
        '
        'Labelincorrect
        '
        Me.Labelincorrect.AutoSize = True
        Me.Labelincorrect.BackColor = System.Drawing.Color.Transparent
        Me.Labelincorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelincorrect.ForeColor = System.Drawing.Color.White
        Me.Labelincorrect.Location = New System.Drawing.Point(292, 581)
        Me.Labelincorrect.Name = "Labelincorrect"
        Me.Labelincorrect.Size = New System.Drawing.Size(0, 25)
        Me.Labelincorrect.TabIndex = 21
        '
        'ButtonSettings
        '
        Me.ButtonSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ButtonSettings.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSettings.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonSettings.Location = New System.Drawing.Point(854, 712)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(118, 70)
        Me.ButtonSettings.TabIndex = 22
        Me.ButtonSettings.Text = "Settings"
        Me.ButtonSettings.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(984, 794)
        Me.Controls.Add(Me.ButtonSettings)
        Me.Controls.Add(Me.Labelincorrect)
        Me.Controls.Add(Me.PictureBoxBan)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.TextBoxName)
        Me.MaximumSize = New System.Drawing.Size(1000, 833)
        Me.MinimumSize = New System.Drawing.Size(1000, 833)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBoxBan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents LabelName As Label
    Friend WithEvents PictureBoxBan As PictureBox
    Friend WithEvents Labelincorrect As Label
    Friend WithEvents ButtonSettings As Button
End Class
