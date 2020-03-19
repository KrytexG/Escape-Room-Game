<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.ComboBoxResolution = New System.Windows.Forms.ComboBox()
        Me.PictureBoxRes = New System.Windows.Forms.PictureBox()
        Me.PictureBoxBright = New System.Windows.Forms.PictureBox()
        Me.ComboBoxBrightness = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxColourBlind = New System.Windows.Forms.ComboBox()
        Me.PictureBoxColourBlind = New System.Windows.Forms.PictureBox()
        Me.ComboBoxGraphics = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxRes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxColourBlind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxResolution
        '
        Me.ComboBoxResolution.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ComboBoxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxResolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxResolution.ForeColor = System.Drawing.Color.White
        Me.ComboBoxResolution.FormattingEnabled = True
        Me.ComboBoxResolution.Items.AddRange(New Object() {"1680 x 1050 (Native)", "1280 x 720", "640×480", "480 x 360", "426×240", "256×144"})
        Me.ComboBoxResolution.Location = New System.Drawing.Point(359, 114)
        Me.ComboBoxResolution.Name = "ComboBoxResolution"
        Me.ComboBoxResolution.Size = New System.Drawing.Size(219, 28)
        Me.ComboBoxResolution.TabIndex = 0
        '
        'PictureBoxRes
        '
        Me.PictureBoxRes.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxRes.BackgroundImage = CType(resources.GetObject("PictureBoxRes.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxRes.Location = New System.Drawing.Point(159, 1)
        Me.PictureBoxRes.Name = "PictureBoxRes"
        Me.PictureBoxRes.Size = New System.Drawing.Size(192, 145)
        Me.PictureBoxRes.TabIndex = 1
        Me.PictureBoxRes.TabStop = False
        '
        'PictureBoxBright
        '
        Me.PictureBoxBright.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxBright.BackgroundImage = CType(resources.GetObject("PictureBoxBright.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxBright.Location = New System.Drawing.Point(156, 101)
        Me.PictureBoxBright.Name = "PictureBoxBright"
        Me.PictureBoxBright.Size = New System.Drawing.Size(194, 146)
        Me.PictureBoxBright.TabIndex = 2
        Me.PictureBoxBright.TabStop = False
        '
        'ComboBoxBrightness
        '
        Me.ComboBoxBrightness.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ComboBoxBrightness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBrightness.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBrightness.ForeColor = System.Drawing.Color.White
        Me.ComboBoxBrightness.FormattingEnabled = True
        Me.ComboBoxBrightness.Items.AddRange(New Object() {"100%", "90%", "80%", "70%", "60%", "50%"})
        Me.ComboBoxBrightness.Location = New System.Drawing.Point(358, 213)
        Me.ComboBoxBrightness.Name = "ComboBoxBrightness"
        Me.ComboBoxBrightness.Size = New System.Drawing.Size(219, 28)
        Me.ComboBoxBrightness.TabIndex = 3
        '
        'ComboBoxColourBlind
        '
        Me.ComboBoxColourBlind.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ComboBoxColourBlind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxColourBlind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxColourBlind.ForeColor = System.Drawing.Color.White
        Me.ComboBoxColourBlind.FormattingEnabled = True
        Me.ComboBoxColourBlind.Location = New System.Drawing.Point(359, 316)
        Me.ComboBoxColourBlind.Name = "ComboBoxColourBlind"
        Me.ComboBoxColourBlind.Size = New System.Drawing.Size(219, 28)
        Me.ComboBoxColourBlind.TabIndex = 4
        '
        'PictureBoxColourBlind
        '
        Me.PictureBoxColourBlind.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxColourBlind.BackgroundImage = CType(resources.GetObject("PictureBoxColourBlind.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxColourBlind.Location = New System.Drawing.Point(111, 202)
        Me.PictureBoxColourBlind.Name = "PictureBoxColourBlind"
        Me.PictureBoxColourBlind.Size = New System.Drawing.Size(237, 146)
        Me.PictureBoxColourBlind.TabIndex = 5
        Me.PictureBoxColourBlind.TabStop = False
        '
        'ComboBoxGraphics
        '
        Me.ComboBoxGraphics.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ComboBoxGraphics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGraphics.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxGraphics.ForeColor = System.Drawing.Color.White
        Me.ComboBoxGraphics.FormattingEnabled = True
        Me.ComboBoxGraphics.Items.AddRange(New Object() {"Ultra", "High", "Medium", "Low", "Potato"})
        Me.ComboBoxGraphics.Location = New System.Drawing.Point(359, 417)
        Me.ComboBoxGraphics.Name = "ComboBoxGraphics"
        Me.ComboBoxGraphics.Size = New System.Drawing.Size(219, 28)
        Me.ComboBoxGraphics.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(166, 303)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 146)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(984, 794)
        Me.Controls.Add(Me.ComboBoxGraphics)
        Me.Controls.Add(Me.ComboBoxColourBlind)
        Me.Controls.Add(Me.ComboBoxBrightness)
        Me.Controls.Add(Me.ComboBoxResolution)
        Me.Controls.Add(Me.PictureBoxRes)
        Me.Controls.Add(Me.PictureBoxBright)
        Me.Controls.Add(Me.PictureBoxColourBlind)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1000, 833)
        Me.MinimumSize = New System.Drawing.Size(1000, 833)
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.PictureBoxRes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxColourBlind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBoxResolution As ComboBox
    Friend WithEvents PictureBoxRes As PictureBox
    Friend WithEvents PictureBoxBright As PictureBox
    Friend WithEvents ComboBoxBrightness As ComboBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ComboBoxColourBlind As ComboBox
    Friend WithEvents PictureBoxColourBlind As PictureBox
    Friend WithEvents ComboBoxGraphics As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
