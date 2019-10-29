'Program: Payroll
'Programmer Name: Christy Mims
'Date: 2/15/17
'Description:  This program allows the user to enter in information about their employees and then calculate the gross pay, federal and state tax witheld, 
'and the net pay.  The information is displayed through the use of labels, textboxes, list boxes and buttons.  This program also allows the user to 
'calculate the data through the use of coding instead of memorizing and entering in information by hand.
Public Class frmPayroll
    Dim Count As Integer = 0
    Const Federal_Tax_Rate As Decimal = 0.12
    Const State_Tax_Rate As Decimal = 0.04
    Const Medicare_Tax_Rate As Decimal = 0.01

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'This button allows the user to exit the program.
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This button calculates the numerical information entered in and then displays the calculated information in the text boxes on the right.
        Dim gross_pay, federal_tax, state_tax, medicare_tax, net_pay As Decimal
        Dim hours_worked, pay_rate As Decimal
        hours_worked = CDec(txtHoursWorked.Text)
        pay_rate = CDec(txtPayRate.Text)
        gross_pay = hours_worked * pay_rate
        federal_tax = Federal_Tax_Rate * gross_pay
        state_tax = State_Tax_Rate * gross_pay
        medicare_tax = Medicare_Tax_Rate * gross_pay
        net_pay = gross_pay - federal_tax - state_tax - medicare_tax

        txtGrossPay.Text = gross_pay.ToString("C")
        txtFederalTax.Text = federal_tax.ToString("C")
        txtStateTax.Text = state_tax.ToString("C")
        txtMedicareTax.Text = medicare_tax.ToString("C")
        txtNetPay.Text = net_pay.ToString("C")

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'This button allows the user to save the previous inforamtion entered in and allows the user to add another name to the listbox.
        Dim gross_pay, federal_tax, state_tax, medicare_tax, net_pay As Decimal
        Count = Count + 1
        Dim FormatList As String = "{0,-25}{1, 25}"
        lstResults.Items.Add("Employee" & " " & Count.ToString)
        lstResults.Items.Add("------------------------------------------")
        lstResults.Items.Add(String.Format(FormatList, "Name:", cbName.Text))
        lstResults.Items.Add(String.Format(FormatList, "Social Security Number:", mskSocialSecurity.Text))
        lstResults.Items.Add(String.Format(FormatList, "Department:", cbDepartment.Text))
        lstResults.Items.Add(String.Format(FormatList, "Hours Worked:", txtHoursWorked.Text))
        lstResults.Items.Add(String.Format(FormatList, "Pay Rate:", txtPayRate.Text))
        lstResults.Items.Add(String.Format(FormatList, "Gross Pay:", txtGrossPay.Text))
        lstResults.Items.Add(String.Format(FormatList, "Federal Tax Witheld:", txtFederalTax.Text))
        lstResults.Items.Add(String.Format(FormatList, "State Tax Witheld:", txtStateTax.Text))
        lstResults.Items.Add(String.Format(FormatList, "Medicare Tax Witheld:", txtMedicareTax.Text))
        lstResults.Items.Add(String.Format(FormatList, "Net Pay:", txtNetPay.Text))
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'This button allows the user to clear the data they entered in and then allows the user to enter in new information.
        cbName.Text = ""
        mskSocialSecurity.Text = ""
        cbDepartment.Text = ""
        txtHoursWorked.Text = ""
        txtPayRate.Text = ""
        txtGrossPay.Text = ""
        txtFederalTax.Text = ""
        txtStateTax.Text = ""
        txtMedicareTax.Text = ""
        txtNetPay.Text = ""
    End Sub
End Class
