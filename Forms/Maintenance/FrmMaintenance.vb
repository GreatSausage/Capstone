Imports System.Text.RegularExpressions
Public Class FrmMaintenance

    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtDepartment As DataTable = DisplayDepartment()
        Dim dtPosition As DataTable = DisplayPosition()
        Dim dtIncentive As DataTable = DisplayIncentives()
        Dim dtAllowance As DataTable = DisplayAllowance()
        Dim dtLeave As DataTable = DisplayLeave()
        dgDepartment.DataSource = dtDepartment
        DgPosition.DataSource = dtPosition
        DgIncentives.DataSource = dtIncentive
        DgAllowance.DataSource = dtAllowance
        dgManageAllowance.DataSource = dtAllowance
        dgLeave.DataSource = dtLeave
        dgManageLeave.DataSource = dtLeave
        cbDepartment.DataSource = dtDepartment
        cbDepartment.ValueMember = "departmentID"
        cbDepartment.DisplayMember = "departmentName"
        cbDepartment.SelectedIndex = 0
        cbDepartmentTwo.DataSource = dtDepartment
        cbDepartmentTwo.DisplayMember = "departmentName"
        cbDepartmentTwo.ValueMember = "departmentID"
        cbDepartmentTwo.SelectedIndex = 0
        cbPosition.DataSource = dtPosition
        cbPosition.ValueMember = "positionID"
        cbPosition.DisplayMember = "positionName"
        cbPosition.SelectedIndex = 0

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
        End If
    End Sub

    Private Sub BtnSaveTax_Click(sender As Object, e As EventArgs) Handles BtnSaveTax.Click

    End Sub
End Class