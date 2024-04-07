' SCT211-O848/2018
' Jany Muong
' 06_SalesCommissionCalculator project: Calculate weekly sales and commission for salespersons using arrays

Imports System.Windows.Forms

Public Class SalesCommissionForm
    Inherits Form

    ' Define constants
    Private Const WeeklyBasePayDecimal As Decimal = 2500D
    Private Const QuotaDecimal As Decimal = 1000D
    Private Const CommissionRateDecimal As Decimal = 0.15D

    ' Array to store sales data for 10 salespersons
    Private SalesData(9, 6) As String ' Each row represents a salesperson, and each column represents a day of the week (7 days)

    ' Constructor
    Public Sub New()
        ' Set up MainForm
        Me.Text = "Sales Commission Calculator"
        Me.Size = New Size(400, 300)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Set up ListBox to display sales data
        Dim SalesListBox As New ListBox()
        SalesListBox.Name = "SalesListBox"
        SalesListBox.Location = New Point(20, 20)
        SalesListBox.Size = New Size(360, 240)

        ' Add ListBox to MainForm
        Me.Controls.Add(SalesListBox)

        ' Input data for each salesperson
        For i As Integer = 0 To 9
            Dim name As String = InputBox("Enter salesperson's name:", "Salesperson " & (i + 1))
            SalesData(i, 0) = name
            For j As Integer = 1 To 6 ' Iterate from 1 to 6 instead of 1 to 7
                Dim sales As String = InputBox("Enter daily sales for " & name & " on Day " & j & ":", "Sales Input")
                SalesData(i, j) = sales
            Next
        Next

        ' Calculate weekly sales and commission for each salesperson
        For i As Integer = 0 To 9
            Dim weeklySalesDecimal As Decimal = 0D
            For j As Integer = 1 To 7
                weeklySalesDecimal += Decimal.Parse(SalesData(i, j))
            Next

            Dim commissionDecimal As Decimal = If(weeklySalesDecimal > QuotaDecimal, weeklySalesDecimal * CommissionRateDecimal, 0D)
            Dim weeklySalaryDecimal As Decimal = WeeklyBasePayDecimal + commissionDecimal

            ' Display salesperson's data in the ListBox
            SalesListBox.Items.Add("Salesperson: " & SalesData(i, 0))
            SalesListBox.Items.Add("Daily Sales:")
            For j As Integer = 1 To 7
                SalesListBox.Items.Add("Day " & j & ": " & SalesData(i, j))
            Next
            SalesListBox.Items.Add("Weekly Sales: " & weeklySalesDecimal.ToString("C"))
            SalesListBox.Items.Add("Commission: " & commissionDecimal.ToString("C"))
            SalesListBox.Items.Add("Weekly Salary: " & weeklySalaryDecimal.ToString("C"))
            SalesListBox.Items.Add("----------------------------------------")
        Next
    End Sub

End Class
