Public Class ObjectDemonstrationsForm
    Private Sub ObjectDemonstrationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ObjectDemoHeaderLabel_Click(sender As Object, e As EventArgs) Handles ObjectDemoHeaderLabel.Click

    End Sub

    Private Sub DisplayTestLabel_Click(sender As Object, e As EventArgs) Handles DisplayTestLabel.Click

    End Sub
    Private Sub DisplayTestTextBox_TextChanged(sender As Object, e As EventArgs) Handles DisplayTestTextBox.TextChanged
        ' DisplayTestTextBox.Text = DisplayTestTextBox.Text
    End Sub

    Private Sub GaramondRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GaramondRadioButton.CheckedChanged
        If GaramondRadioButton.Checked Then
            DisplayTestTextBox.Font = New Font("Garamond", DisplayTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub MagnetoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetoRadioButton.CheckedChanged
        If MagnetoRadioButton.Checked Then
            DisplayTestTextBox.Font = New Font("Magneto", DisplayTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub TahomaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TahomaRadioButton.CheckedChanged
        If TahomaRadioButton.Checked Then
            DisplayTestTextBox.Font = New Font("Tahoma", DisplayTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        If GreenRadioButton.Checked Then
            DisplayTestTextBox.ForeColor = Color.Green
        End If
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        If BlueRadioButton.Checked Then
            DisplayTestTextBox.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        If RedRadioButton.Checked Then
            DisplayTestTextBox.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicCheckBox.CheckedChanged
        Dim fontStyle As FontStyle = FontStyle.Regular

        If ItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        If BoldCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If BoldItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold Or FontStyle.Italic
        End If

        DisplayTestTextBox.Font = New Font(DisplayTestTextBox.Font, fontStyle)
    End Sub

    Private Sub BoldCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldCheckBox.CheckedChanged
        Dim fontStyle As FontStyle = FontStyle.Regular

        If ItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        If BoldCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If BoldItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold Or FontStyle.Italic
        End If

        DisplayTestTextBox.Font = New Font(DisplayTestTextBox.Font, fontStyle)
    End Sub

    Private Sub BoldItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldItalicCheckBox.CheckedChanged
        Dim fontStyle As FontStyle = FontStyle.Regular

        If ItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        If BoldCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If BoldItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold Or FontStyle.Italic
        End If

        DisplayTestTextBox.Font = New Font(DisplayTestTextBox.Font, fontStyle)
    End Sub



End Class