Imports System.Text.RegularExpressions
Public Class FrmMaintenance

    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtDepartment As DataTable = DisplayDepartment()
        Dim dtPosition As DataTable = DisplayPosition()
        Dim dtIncentive As DataTable = DisplayIncentives()
        Dim dtAllowance As DataTable = DisplayAllowance()
        Dim dtLeave As DataTable = DisplayLeave()
        Dim dtTax As DataTable = DisplayTax()
        Dim dtSSS As DataTable = DisplaySSS()
        Dim dtPagibig As DataTable = DisplayPagIbig()
        Dim dtPhilHealth As DataTable = DisplayPhilhealth()
        dgDepartment.DataSource = dtDepartment
        DgPosition.DataSource = dtPosition
        DgIncentives.DataSource = dtIncentive
        DgAllowance.DataSource = dtAllowance
        dgLeave.DataSource = dtLeave
        dgTaxContri.DataSource = dtTax
        dgSSSContri.DataSource = dtSSS
        dgPagibigContri.DataSource = dtPagibig
<<<<<<< HEAD
        dgPhilhealthContri.DataSource = dtPhilHealth

=======
        Load_department(cbDepartmentTwo)
>>>>>>> 6da93115b9c7c6d0482f6efb8e536b367de5aae2
        Dim maxSalary As Decimal = TaxGetMaxSalary()
        txtTaxMinSalary.Text = maxSalary
        Dim maxSalarySSS As Decimal = SSSGetMaxSalary()
        txtSSSMinSalary.Text = maxSalarySSS
    End Sub

    Private Sub BtnSaveDepartment_Click(sender As Object, e As EventArgs) Handles BtnSaveDepartment.Click
        If String.IsNullOrEmpty(txtDepartment.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not Regex.IsMatch(txtDepartment.Text, letterOnly) Then
            MessageBox.Show("This contains letter only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            NewDepartment(txtDepartment.Text)
            txtDepartment.Clear()
            Dim dtDepartment As DataTable = DisplayDepartment()
            dgDepartment.DataSource = dtDepartment
            cbDepartment.DataSource = dtDepartment
            cbDepartment.ValueMember = "departmentID"
            cbDepartment.DisplayMember = "departmentName"
            cbDepartmentTwo.DataSource = dtDepartment
            cbDepartmentTwo.ValueMember = "departmentID"
            cbDepartmentTwo.DisplayMember = "departmentName"
        End If
    End Sub

    Private Sub BtnSavePosition_Click(sender As Object, e As EventArgs) Handles BtnSavePosition.Click
        If String.IsNullOrEmpty(txtPosition.Text) OrElse cbDepartment.SelectedValue = -1 Then
            MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not Regex.IsMatch(txtPosition.Text, letterOnly) Then
            MessageBox.Show("This contains letter only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim departmentID As Integer = Convert.ToInt32(cbDepartment.SelectedValue)
            NewPosition(txtPosition.Text, departmentID)
            Dim dtPosition As DataTable = DisplayPosition()
            DgPosition.DataSource = dtPosition
            txtPosition.Clear()
            cbDepartment.SelectedIndex = 0
        End If
    End Sub

    Private Sub BtnSaveIncentives_Click(sender As Object, e As EventArgs) Handles BtnSaveIncentives.Click
        If String.IsNullOrEmpty(txtIncentive.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not Regex.IsMatch(txtIncentive.Text, letterOnly) Then
            MessageBox.Show("This contains letter only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            NewIncentives(txtIncentive.Text)
            Dim dtIncentives As DataTable = DisplayIncentives()
            DgIncentives.DataSource = dtIncentives
            txtIncentive.Clear()
        End If
    End Sub

    Private Sub BtnSaveAllowance_Click(sender As Object, e As EventArgs) Handles BtnSaveAllowance.Click
        If String.IsNullOrEmpty(txtAllowance.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not Regex.IsMatch(txtAllowance.Text, letterOnly) Then
            MessageBox.Show("This contains digit only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            NewAllowance(txtAllowance.Text)
            Dim dtAllowance As DataTable = DisplayAllowance()
            DgAllowance.DataSource = dtAllowance
            txtAllowance.Clear()
        End If
    End Sub

    Private Sub BtnSaveLeave_Click(sender As Object, e As EventArgs) Handles BtnSaveLeave.Click
        If String.IsNullOrEmpty(txtLeave.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not Regex.IsMatch(txtLeave.Text, letteronly) Then
            MessageBox.Show("This contains letter only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            NewLeave(txtLeave.Text)
            Dim dtLeave As DataTable = DisplayLeave()
            dgLeave.DataSource = dtLeave
            txtLeave.Clear()
        End If
    End Sub

    Private Sub BtnSaveTax_Click(sender As Object, e As EventArgs) Handles BtnSaveTax.Click
        If String.IsNullOrEmpty(txtTaxMinSalary.Text) OrElse
           String.IsNullOrEmpty(txtTaxMinSalary.Text) OrElse
           String.IsNullOrEmpty(txtTaxFixed.Text) OrElse
           String.IsNullOrEmpty(txtTaxPercentage.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not Regex.IsMatch(txtTaxMinSalary.Text, numberOnly) OrElse
               Not Regex.IsMatch(txtTaxMaxSalary.Text, numberOnly) OrElse
               Not Regex.IsMatch(txtTaxFixed.Text, numberOnly) OrElse
               Not Regex.IsMatch(txtTaxPercentage.text, numberOnly) Then
            MessageBox.Show("This contains number only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim minSalary As Decimal = Convert.ToDecimal(txtTaxMinSalary.Text)
            Dim maxSalary As Decimal = Convert.ToDecimal(txtTaxMaxSalary.Text)
            Dim fixedAmount As Decimal = Convert.ToDecimal(txtTaxFixed.Text)
            Dim percentage As Decimal = Convert.ToDecimal(txtTaxPercentage.Text)
            NewTax(minSalary, maxSalary, fixedAmount, percentage)
            Dim dtTax As DataTable = DisplayTax()
            dgTaxContri.DataSource = dtTax
            Dim maxSalaryOne As Decimal = TaxGetMaxSalary()
            txtTaxMinSalary.Text = maxSalaryOne
            txtTaxMaxSalary.Clear()
            txtTaxFixed.Clear()
            txtTaxPercentage.Clear()
        End If
    End Sub

    Private Sub BtnSaveSSS_Click(sender As Object, e As EventArgs) Handles BtnSaveSSS.Click
        If String.IsNullOrEmpty(txtSSSMinSalary.Text) OrElse
                    String.IsNullOrEmpty(txtSSSMaximumSalary.Text) OrElse
                    String.IsNullOrEmpty(txtSSSEE.Text) OrElse
                    String.IsNullOrEmpty(txtSSSWisp.Text) OrElse
                    String.IsNullOrEmpty(txtSSSTotal.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        ElseIf Not Regex.IsMatch(txtSSSMinSalary.text, numberOnly) OrElse
                   Not Regex.IsMatch(txtSSSMaximumSalary.text, numberOnly) OrElse
                   Not Regex.IsMatch(txtSSSEE.text, numberOnly) OrElse
                   Not Regex.IsMatch(txtSSSWisp.text, numberOnly) OrElse
                   Not Regex.IsMatch(txtSSSTotal.text, numberOnly) Then
            MessageBox.Show("This contains number only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            NewSSS(Convert.ToDecimal(txtSSSMinSalary.Text), Convert.ToDecimal(txtSSSMaximumSalary.Text), Convert.ToDecimal(txtSSSEE.Text), Convert.ToDecimal(txtSSSWisp.Text))
            Dim dtSSS As DataTable = DisplaySSS()
            dgSSSContri.DataSource = dtSSS
            Dim sssMaxSalary As Decimal = SSSGetMaxSalary()
            txtSSSMinSalary.Text = sssMaxSalary
            txtSSSMaximumSalary.Clear()
            txtSSSEE.Clear()
            txtSSSWisp.Clear()
            txtSSSTotal.Clear()
        End If
    End Sub

    Private Sub BtnSavePagibig_Click(sender As Object, e As EventArgs) Handles BtnSavePagibig.Click
        If String.IsNullOrEmpty(txtPagIbigRate.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not Regex.IsMatch(txtPagIbigRate.Text, numberOnly) Then
            MessageBox.Show("This contains number only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            NewPagibig(txtPagIbigRate.Text)
            Dim dtPagibig As DataTable = DisplayPagIbig()
            dgPagibigContri.DataSource = dtPagibig
            txtPagIbigRate.Clear()
        End If
    End Sub
    Private Sub CbDepartmentTwo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartmentTwo.SelectedIndexChanged
        Load_position(cbDepartmentTwo, cbPosition)
        Load_leave(cbPosition, dgManageLeave)
    End Sub

    Private Sub CbPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPosition.SelectedIndexChanged

        If cbPosition.SelectedIndex >= 0 Then
            Load_leave(cbPosition, dgManageLeave)
        End If
    End Sub

    Private Sub BtnSaveManage_Click(sender As Object, e As EventArgs) Handles BtnSaveManage.Click
        Update_Leave(dgManageLeave, cbPosition)
    End Sub

    Private Sub txtSSSMaximumSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSSSMaximumSalary.TextChanged
        If String.IsNullOrEmpty(txtSSSMaximumSalary.Text) Then
            txtSSSWisp.Enabled = False
            Exit Sub
        Else
            Dim max As Integer = Convert.ToInt32(txtSSSMaximumSalary.Text)
            If max < 20000 Then
                txtSSSWisp.Enabled = False
            Else
                txtSSSWisp.Enabled = True
            End If
        End If
    End Sub

    Private Sub BtnSavePhilHealth_Click(sender As Object, e As EventArgs) Handles BtnSavePhilHealth.Click
        If String.IsNullOrEmpty(txtPhilhealthRate.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not Regex.IsMatch(txtPhilhealthRate.Text, numberOnly) Then
            MessageBox.Show("This contains number only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            NewPhilhealth(Convert.ToInt32(txtPhilhealthRate.Text))
            Dim dtPhilHealth As DataTable = DisplayPhilhealth()
            dgPhilhealthContri.DataSource = dtPhilHealth
        End If
    End Sub
End Class