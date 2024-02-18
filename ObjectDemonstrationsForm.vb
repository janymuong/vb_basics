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


End Class