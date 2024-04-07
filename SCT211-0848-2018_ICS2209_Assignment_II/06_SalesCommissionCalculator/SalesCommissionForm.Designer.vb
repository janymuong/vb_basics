<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesCommissionForm
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
        SalesListBox = New ListBox()
        SuspendLayout()
        ' 
        ' SalesListBox
        ' 
        SalesListBox.Dock = DockStyle.Fill
        SalesListBox.FormattingEnabled = True
        SalesListBox.ItemHeight = 25
        SalesListBox.Location = New Point(0, 0)
        SalesListBox.Name = "SalesListBox"
        SalesListBox.Size = New Size(800, 450)
        SalesListBox.TabIndex = 0
        ' 
        ' SalesCommissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SalesListBox)
        Name = "SalesCommissionForm"
        Text = "Sales Commission Calculator"
        ResumeLayout(False)
    End Sub

    Friend WithEvents SalesListBox As ListBox

End Class
