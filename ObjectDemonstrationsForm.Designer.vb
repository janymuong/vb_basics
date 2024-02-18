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
        DisplayTestTextBox.Location = New Point(23, 155)
        DisplayTestTextBox.Name = "DisplayTestTextBox"
        DisplayTestTextBox.Size = New Size(184, 31)
        DisplayTestTextBox.TabIndex = 1
        DisplayTestTextBox.Text = "Sample Test"
        ' 
        ' DisplayTestLabel
        ' 
        DisplayTestLabel.AutoSize = True
        DisplayTestLabel.BorderStyle = BorderStyle.Fixed3D
        DisplayTestLabel.Location = New Point(57, 125)
        DisplayTestLabel.Name = "DisplayTestLabel"
        DisplayTestLabel.Size = New Size(112, 27)
        DisplayTestLabel.TabIndex = 2
        DisplayTestLabel.Text = "Display Test "
        ' 
        ' FontLabel
        ' 
        FontLabel.AutoSize = True
        FontLabel.BorderStyle = BorderStyle.Fixed3D
        FontLabel.Location = New Point(280, 125)
        FontLabel.Name = "FontLabel"
        FontLabel.Size = New Size(50, 27)
        FontLabel.TabIndex = 3
        FontLabel.Text = "Font"
        ' 
        ' GaramondRadioButton
        ' 
        GaramondRadioButton.AutoSize = True
        GaramondRadioButton.Location = New Point(280, 157)
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
        MagnetoRadioButton.Location = New Point(407, 157)
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
        TahomaRadioButton.Location = New Point(522, 157)
        TahomaRadioButton.Name = "TahomaRadioButton"
        TahomaRadioButton.Size = New Size(99, 29)
        TahomaRadioButton.TabIndex = 7
        TahomaRadioButton.TabStop = True
        TahomaRadioButton.Text = "Tahoma"
        TahomaRadioButton.UseVisualStyleBackColor = True
        ' 
        ' ObjectDemonstrationsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
End Class
