Imports System.Text.RegularExpressions
Public Class FrmMaintenance

    Private ReadOnly dtDepartment As DataTable = DisplayDepartment()
    Private ReadOnly dtPosition As DataTable = DisplayPosition()
    Private ReadOnly dtIncentive As DataTable = DisplayIncentives()
    Private ReadOnly dtAllowance As DataTable = DisplayAllowance()

    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        DgDepartment.DataSource = dtDepartment
        DgPosition.DataSource = dtPosition
        DgIncentives.DataSource = dtIncentive
        DgAllowance.DataSource = dtAllowance
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
            DgDepartment.DataSource = dtDepartment
        End If
    End Sub

    Private Sub BtnDeleteDepartment_Click(sender As Object, e As EventArgs) Handles BtnDeleteDepartment.Click
        Dim departmentID As Integer 'insert get id function here
        DeleteDepartment(departmentID)
        DgDepartment.DataSource = dtDepartment
    End Sub

    Private Sub BtnSavePosition_Click(sender As Object, e As EventArgs) Handles BtnSavePosition.Click
        If String.IsNullOrEmpty(txtDepartment.Text) OrElse String.IsNullOrEmpty(cbDepartment.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not Regex.IsMatch(txtDepartment.Text, letterOnly) Then
            MessageBox.Show("This contains letter only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim departmentID As Integer 'insert get id function here
            NewPosition(txtPosition.Text, departmentID)
            DgPosition.DataSource = dtPosition
        End If
    End Sub

    Private Sub BtnDeletePosition_Click(sender As Object, e As EventArgs) Handles BtnDeletePosition.Click
        Dim positionID As Integer 'insert get id function here
        DeletePosition(positionID)
        DgPosition.DataSource = dtPosition
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
            DgIncentives.DataSource = dtIncentive
        End If
    End Sub

    Private Sub BtnDeleteIncentives_Click(sender As Object, e As EventArgs) Handles BtnDeleteIncentives.Click
        Dim incentiveID As Integer 'insert get id function here
        DeleteIncentives(incentiveID)
        DgIncentives.DataSource = dtIncentive
    End Sub

    Private Sub BtnDeleteAllowance_Click(sender As Object, e As EventArgs) Handles BtnDeleteAllowance.Click
        Dim allowanceID As Integer 'insert get id function here
        DeleteAllowance(allowanceID)
        DgAllowance.DataSource = dtAllowance
    End Sub

    Private Sub BtnSaveAllowance_Click(sender As Object, e As EventArgs) Handles BtnSaveAllowance.Click
        If String.IsNullOrEmpty(txtAllowance.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not Regex.IsMatch(txtAllowance.Text, numberOnly) Then
            MessageBox.Show("This contains digit only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            NewAllowance(txtAllowance.Text)
            DgAllowance.DataSource = dtAllowance
        End If
    End Sub
End Class