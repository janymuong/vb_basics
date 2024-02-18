<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectDemonstrationsForm
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
        ObjectDemoHeaderLabel = New Label()
        DisplayTestTextBox = New TextBox()
        DisplayTestLabel = New Label()
        FontLabel = New Label()
        GaramondRadioButton = New RadioButton()
        MagnetoRadioButton = New RadioButton()
        TahomaRadioButton = New RadioButton()
        GreenRadioButton = New RadioButton()
        RedRadioButton = New RadioButton()
        BlueRadioButton = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        ItalicCheckBox = New CheckBox()
        BoldCheckBox = New CheckBox()
        BoldItalicCheckBox = New CheckBox()
        SuspendLayout()
        ' 
        ' ObjectDemoHeaderLabel
        ' 
        ObjectDemoHeaderLabel.AutoSize = True
        ObjectDemoHeaderLabel.BorderStyle = BorderStyle.FixedSingle
        ObjectDemoHeaderLabel.Location = New Point(241, 21)
        ObjectDemoHeaderLabel.Name = "ObjectDemoHeaderLabel"
        ObjectDemoHeaderLabel.Size = New Size(198, 27)
        ObjectDemoHeaderLabel.TabIndex = 0
        ObjectDemoHeaderLabel.Text = "Object Demonstrations"
        ' 
        ' DisplayTestTextBox
        ' 
        DisplayTestTextBox.Location = New Point(73, 146)
        DisplayTestTextBox.Name = "DisplayTestTextBox"
        DisplayTestTextBox.Size = New Size(184, 31)
        DisplayTestTextBox.TabIndex = 1
        DisplayTestTextBox.Text = "Sample Test"
        ' 
        ' DisplayTestLabel
        ' 
        DisplayTestLabel.AutoSize = True
        DisplayTestLabel.BorderStyle = BorderStyle.Fixed3D
        DisplayTestLabel.Location = New Point(107, 116)
        DisplayTestLabel.Name = "DisplayTestLabel"
        DisplayTestLabel.Size = New Size(112, 27)
        DisplayTestLabel.TabIndex = 2
        DisplayTestLabel.Text = "Display Test "
        ' 
        ' FontLabel
        ' 
        FontLabel.AutoSize = True
        FontLabel.BorderStyle = BorderStyle.Fixed3D
        FontLabel.Location = New Point(384, 116)
        FontLabel.Name = "FontLabel"
        FontLabel.Size = New Size(50, 27)
        FontLabel.TabIndex = 3
        FontLabel.Text = "Font"
        ' 
        ' GaramondRadioButton
        ' 
        GaramondRadioButton.AutoSize = True
        GaramondRadioButton.Location = New Point(384, 148)
        GaramondRadioButton.Name = "GaramondRadioButton"
        GaramondRadioButton.Size = New Size(121, 29)
        GaramondRadioButton.TabIndex = 5
        GaramondRadioButton.TabStop = True
        GaramondRadioButton.Text = "Garamond"
        GaramondRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MagnetoRadioButton
        ' 
        MagnetoRadioButton.AutoSize = True
        MagnetoRadioButton.Location = New Point(511, 148)
        MagnetoRadioButton.Name = "MagnetoRadioButton"
        MagnetoRadioButton.Size = New Size(109, 29)
        MagnetoRadioButton.TabIndex = 6
        MagnetoRadioButton.TabStop = True
        MagnetoRadioButton.Text = "Magneto"
        MagnetoRadioButton.UseVisualStyleBackColor = True
        ' 
        ' TahomaRadioButton
        ' 
        TahomaRadioButton.AutoSize = True
        TahomaRadioButton.Location = New Point(626, 148)
        TahomaRadioButton.Name = "TahomaRadioButton"
        TahomaRadioButton.Size = New Size(99, 29)
        TahomaRadioButton.TabIndex = 7
        TahomaRadioButton.TabStop = True
        TahomaRadioButton.Text = "Tahoma"
        TahomaRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GreenRadioButton
        ' 
        GreenRadioButton.AutoSize = True
        GreenRadioButton.Location = New Point(626, 251)
        GreenRadioButton.Name = "GreenRadioButton"
        GreenRadioButton.Size = New Size(83, 29)
        GreenRadioButton.TabIndex = 8
        GreenRadioButton.TabStop = True
        GreenRadioButton.Text = "Green"
        GreenRadioButton.UseVisualStyleBackColor = True
        ' 
        ' RedRadioButton
        ' 
        RedRadioButton.AutoSize = True
        RedRadioButton.Location = New Point(626, 321)
        RedRadioButton.Name = "RedRadioButton"
        RedRadioButton.Size = New Size(67, 29)
        RedRadioButton.TabIndex = 9
        RedRadioButton.TabStop = True
        RedRadioButton.Text = "Red"
        RedRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlueRadioButton
        ' 
        BlueRadioButton.AutoSize = True
        BlueRadioButton.Location = New Point(626, 286)
        BlueRadioButton.Name = "BlueRadioButton"
        BlueRadioButton.Size = New Size(70, 29)
        BlueRadioButton.TabIndex = 10
        BlueRadioButton.TabStop = True
        BlueRadioButton.Text = "Blue"
        BlueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Location = New Point(611, 221)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 27)
        Label1.TabIndex = 11
        Label1.Text = "Font Color"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(451, 221)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 27)
        Label2.TabIndex = 12
        Label2.Text = "Font Style"
        ' 
        ' ItalicCheckBox
        ' 
        ItalicCheckBox.AutoSize = True
        ItalicCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ItalicCheckBox.Location = New Point(451, 252)
        ItalicCheckBox.Name = "ItalicCheckBox"
        ItalicCheckBox.Size = New Size(77, 29)
        ItalicCheckBox.TabIndex = 13
        ItalicCheckBox.Text = "Italic"
        ItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' BoldCheckBox
        ' 
        BoldCheckBox.AutoSize = True
        BoldCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BoldCheckBox.Location = New Point(451, 287)
        BoldCheckBox.Name = "BoldCheckBox"
        BoldCheckBox.Size = New Size(77, 29)
        BoldCheckBox.TabIndex = 14
        BoldCheckBox.Text = "Bold"
        BoldCheckBox.UseVisualStyleBackColor = True
        ' 
        ' BoldItalicCheckBox
        ' 
        BoldItalicCheckBox.AutoSize = True
        BoldItalicCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BoldItalicCheckBox.Location = New Point(451, 321)
        BoldItalicCheckBox.Name = "BoldItalicCheckBox"
        BoldItalicCheckBox.Size = New Size(126, 29)
        BoldItalicCheckBox.TabIndex = 15
        BoldItalicCheckBox.Text = "Bold Italic"
        BoldItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' ObjectDemonstrationsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 508)
        Controls.Add(BoldItalicCheckBox)
        Controls.Add(BoldCheckBox)
        Controls.Add(ItalicCheckBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BlueRadioButton)
        Controls.Add(RedRadioButton)
        Controls.Add(GreenRadioButton)
        Controls.Add(TahomaRadioButton)
        Controls.Add(MagnetoRadioButton)
        Controls.Add(GaramondRadioButton)
        Controls.Add(FontLabel)
        Controls.Add(DisplayTestLabel)
        Controls.Add(DisplayTestTextBox)
        Controls.Add(ObjectDemoHeaderLabel)
        Name = "ObjectDemonstrationsForm"
        Text = "ObjectDemonstrationsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ObjectDemoHeaderLabel As Label
    Friend WithEvents DisplayTestTextBox As TextBox
    Friend WithEvents DisplayTestLabel As Label
    Friend WithEvents FontLabel As Label
    Friend WithEvents GaramondRadioButton As RadioButton
    Friend WithEvents MagnetoRadioButton As RadioButton
    Friend WithEvents TahomaRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ItalicCheckBox As CheckBox
    Friend WithEvents CheckBox As CheckBox
    Friend WithEvents BoldItalicCheckBox As CheckBox
    Friend WithEvents BoldCheckBox As CheckBox
End Class
