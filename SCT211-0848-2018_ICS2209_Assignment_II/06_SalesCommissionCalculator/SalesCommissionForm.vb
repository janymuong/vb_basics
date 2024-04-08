' SCT211-O848/2018
' Jany Muong
' 06_SalesCommissionCalculator project: Calculate weekly sales and commission for salespersons using arrays

Imports System.Windows.Forms

Public Class SalesCommissionForm
    Private Sub SalesButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim Sales(2, 3) As String
        Dim Total As Integer, GrandTotal As Integer
        Dim DisplaySales As String
        Dim I As Integer, J As Integer
        'Input sales values 
        For I = Sales.GetLowerBound(0) To Sales.GetUpperBound(0)
            Sales(I, 0) = InputBox("Enter the salesman's name")
            For J = Sales.GetLowerBound(1) + 1 To Sales.GetUpperBound(1)
                Sales(I, J) = InputBox("Enter the sales for item:" & J)
            Next J
        Next I
        'Compute and display sales details 
        For I = Sales.GetLowerBound(0) To Sales.GetUpperBound(0)
            SalesListBox.Items.Add(Sales(I, 0))
            Total = 0
            DisplaySales = String.Empty
            For J = Sales.GetLowerBound(1) + 1 To Sales.GetUpperBound(1)
                DisplaySales &= Sales(I, J) & ControlChars.Tab
                Total = Total + Convert.ToInt32(Sales(I, J))
            Next J
            SalesListBox.Items.Add(DisplaySales)
            SalesListBox.Items.Add("Total Sales = " & Total.ToString)
            GrandTotal = GrandTotal + Total
        Next I
        SalesListBox.Items.Add("The Grand Total is:" & GrandTotal.ToString)
    End Sub

End Class
