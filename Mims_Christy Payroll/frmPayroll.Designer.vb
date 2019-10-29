<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
        Me.gbEmployeeInformation = New System.Windows.Forms.GroupBox()
        Me.cbDepartment = New System.Windows.Forms.ComboBox()
        Me.mskSocialSecurity = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbName = New System.Windows.Forms.ComboBox()
        Me.gbPayrollInformation = New System.Windows.Forms.GroupBox()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbPayrollResults = New System.Windows.Forms.GroupBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.txtMedicareTax = New System.Windows.Forms.TextBox()
        Me.txtStateTax = New System.Windows.Forms.TextBox()
        Me.txtFederalTax = New System.Windows.Forms.TextBox()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.gbEmployeeInformation.SuspendLayout()
        Me.gbPayrollInformation.SuspendLayout()
        Me.gbPayrollResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbEmployeeInformation
        '
        Me.gbEmployeeInformation.BackColor = System.Drawing.Color.PowderBlue
        Me.gbEmployeeInformation.Controls.Add(Me.cbDepartment)
        Me.gbEmployeeInformation.Controls.Add(Me.mskSocialSecurity)
        Me.gbEmployeeInformation.Controls.Add(Me.Label3)
        Me.gbEmployeeInformation.Controls.Add(Me.Label2)
        Me.gbEmployeeInformation.Controls.Add(Me.Label1)
        Me.gbEmployeeInformation.Controls.Add(Me.cbName)
        Me.gbEmployeeInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEmployeeInformation.Location = New System.Drawing.Point(34, 22)
        Me.gbEmployeeInformation.Name = "gbEmployeeInformation"
        Me.gbEmployeeInformation.Size = New System.Drawing.Size(435, 184)
        Me.gbEmployeeInformation.TabIndex = 0
        Me.gbEmployeeInformation.TabStop = False
        Me.gbEmployeeInformation.Text = "Employee Information"
        '
        'cbDepartment
        '
        Me.cbDepartment.AutoCompleteCustomSource.AddRange(New String() {"Research and Development", "Management", "", "Human Resources"})
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.Location = New System.Drawing.Point(182, 115)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(121, 24)
        Me.cbDepartment.TabIndex = 3
        '
        'mskSocialSecurity
        '
        Me.mskSocialSecurity.Location = New System.Drawing.Point(182, 70)
        Me.mskSocialSecurity.Mask = "000-00-0000"
        Me.mskSocialSecurity.Name = "mskSocialSecurity"
        Me.mskSocialSecurity.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mskSocialSecurity.Size = New System.Drawing.Size(163, 22)
        Me.mskSocialSecurity.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Department:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Social Security #:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'cbName
        '
        Me.cbName.FormattingEnabled = True
        Me.cbName.Items.AddRange(New Object() {"Colton James", "Tim Morrow", "Shearyl Johnson", "Liz Collins", "William Bryant", "John Eppes", "Lilly Castle", "Kate Beckette", "Fiona Glenanne", "Michael Weston", "Madelyn Brennan", "Katrina Holland"})
        Me.cbName.Location = New System.Drawing.Point(182, 24)
        Me.cbName.Name = "cbName"
        Me.cbName.Size = New System.Drawing.Size(218, 24)
        Me.cbName.TabIndex = 1
        '
        'gbPayrollInformation
        '
        Me.gbPayrollInformation.BackColor = System.Drawing.Color.PowderBlue
        Me.gbPayrollInformation.Controls.Add(Me.txtPayRate)
        Me.gbPayrollInformation.Controls.Add(Me.txtHoursWorked)
        Me.gbPayrollInformation.Controls.Add(Me.Label5)
        Me.gbPayrollInformation.Controls.Add(Me.Label4)
        Me.gbPayrollInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPayrollInformation.Location = New System.Drawing.Point(34, 226)
        Me.gbPayrollInformation.Name = "gbPayrollInformation"
        Me.gbPayrollInformation.Size = New System.Drawing.Size(345, 150)
        Me.gbPayrollInformation.TabIndex = 1
        Me.gbPayrollInformation.TabStop = False
        Me.gbPayrollInformation.Text = "Payroll Information"
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(130, 82)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(134, 22)
        Me.txtPayRate.TabIndex = 2
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(130, 36)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(134, 22)
        Me.txtHoursWorked.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Pay Rate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Hours Worked:"
        '
        'gbPayrollResults
        '
        Me.gbPayrollResults.BackColor = System.Drawing.Color.PowderBlue
        Me.gbPayrollResults.Controls.Add(Me.txtNetPay)
        Me.gbPayrollResults.Controls.Add(Me.txtMedicareTax)
        Me.gbPayrollResults.Controls.Add(Me.txtStateTax)
        Me.gbPayrollResults.Controls.Add(Me.txtFederalTax)
        Me.gbPayrollResults.Controls.Add(Me.txtGrossPay)
        Me.gbPayrollResults.Controls.Add(Me.Label10)
        Me.gbPayrollResults.Controls.Add(Me.Label9)
        Me.gbPayrollResults.Controls.Add(Me.Label8)
        Me.gbPayrollResults.Controls.Add(Me.Label7)
        Me.gbPayrollResults.Controls.Add(Me.Label6)
        Me.gbPayrollResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPayrollResults.Location = New System.Drawing.Point(511, 22)
        Me.gbPayrollResults.Name = "gbPayrollResults"
        Me.gbPayrollResults.Size = New System.Drawing.Size(394, 268)
        Me.gbPayrollResults.TabIndex = 0
        Me.gbPayrollResults.TabStop = False
        Me.gbPayrollResults.Text = "Payroll Results"
        '
        'txtNetPay
        '
        Me.txtNetPay.BackColor = System.Drawing.Color.White
        Me.txtNetPay.Enabled = False
        Me.txtNetPay.Location = New System.Drawing.Point(193, 197)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.Size = New System.Drawing.Size(178, 22)
        Me.txtNetPay.TabIndex = 4
        Me.txtNetPay.TabStop = False
        '
        'txtMedicareTax
        '
        Me.txtMedicareTax.BackColor = System.Drawing.Color.White
        Me.txtMedicareTax.Enabled = False
        Me.txtMedicareTax.Location = New System.Drawing.Point(193, 152)
        Me.txtMedicareTax.Name = "txtMedicareTax"
        Me.txtMedicareTax.Size = New System.Drawing.Size(178, 22)
        Me.txtMedicareTax.TabIndex = 3
        Me.txtMedicareTax.TabStop = False
        '
        'txtStateTax
        '
        Me.txtStateTax.BackColor = System.Drawing.Color.White
        Me.txtStateTax.Enabled = False
        Me.txtStateTax.Location = New System.Drawing.Point(193, 111)
        Me.txtStateTax.Name = "txtStateTax"
        Me.txtStateTax.Size = New System.Drawing.Size(178, 22)
        Me.txtStateTax.TabIndex = 2
        Me.txtStateTax.TabStop = False
        '
        'txtFederalTax
        '
        Me.txtFederalTax.BackColor = System.Drawing.Color.White
        Me.txtFederalTax.Enabled = False
        Me.txtFederalTax.Location = New System.Drawing.Point(193, 68)
        Me.txtFederalTax.Name = "txtFederalTax"
        Me.txtFederalTax.Size = New System.Drawing.Size(178, 22)
        Me.txtFederalTax.TabIndex = 1
        Me.txtFederalTax.TabStop = False
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BackColor = System.Drawing.Color.White
        Me.txtGrossPay.Enabled = False
        Me.txtGrossPay.Location = New System.Drawing.Point(193, 25)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(178, 22)
        Me.txtGrossPay.TabIndex = 0
        Me.txtGrossPay.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Net Pay:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Medicare Tax Witheld:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "State Tax Witheld:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Federal Tax Witheld:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Gross Pay:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(499, 333)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(93, 43)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(605, 333)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(93, 43)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(711, 333)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 43)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(817, 333)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 43)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 14
        Me.lstResults.Location = New System.Drawing.Point(34, 408)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(871, 214)
        Me.lstResults.TabIndex = 5
        Me.lstResults.TabStop = False
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(941, 676)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gbPayrollInformation)
        Me.Controls.Add(Me.gbPayrollResults)
        Me.Controls.Add(Me.gbEmployeeInformation)
        Me.Name = "frmPayroll"
        Me.gbEmployeeInformation.ResumeLayout(False)
        Me.gbEmployeeInformation.PerformLayout()
        Me.gbPayrollInformation.ResumeLayout(False)
        Me.gbPayrollInformation.PerformLayout()
        Me.gbPayrollResults.ResumeLayout(False)
        Me.gbPayrollResults.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbEmployeeInformation As GroupBox
    Friend WithEvents cbDepartment As ComboBox
    Friend WithEvents mskSocialSecurity As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbName As ComboBox
    Friend WithEvents gbPayrollInformation As GroupBox
    Friend WithEvents txtPayRate As TextBox
    Friend WithEvents txtHoursWorked As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gbPayrollResults As GroupBox
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents txtMedicareTax As TextBox
    Friend WithEvents txtStateTax As TextBox
    Friend WithEvents txtFederalTax As TextBox
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstResults As ListBox
End Class
