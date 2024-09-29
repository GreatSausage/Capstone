Imports System.Data.SqlClient
Module MdlMaintenance

    Public Function DisplayDepartment() As DataTable
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("SELECT * FROM tblDepartment", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
        connection.Close()
    End Function

    Public Sub NewDepartment(departmentName As String)
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("INSERT INTO tblDepartment (departmentName, status) VALUES (@departmentName, @status)", connection)
        command.Parameters.AddWithValue("@departmentName", departmentName)
        command.Parameters.AddWithValue("@status", "Active")
        command.ExecuteNonQuery()
        MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Sub DeleteDepartment(departmentID As Integer)
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("DELETE FROM tblDepartment WHERE departmentID = @departmentID", connection)
        command.Parameters.AddWithValue("@departmentID", departmentID)
        command.ExecuteNonQuery()
        MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Function DisplayPosition() As DataTable
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("SELECT * FROM tblPosition", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
        connection.Close()
    End Function

    Public Sub NewPosition(positionName As String, departmentID As Integer)
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("INSERT INTO tblPosition (departmentID, positionName) VALUES (@departmentID, @positionName)", connection)
        command.Parameters.AddWithValue("@departmentID", departmentID)
        command.Parameters.AddWithValue("@positionName", positionName)
        command.ExecuteNonQuery()
        MessageBox.Show("Position added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Sub DeletePosition(positionID As Integer)
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("DELETE FROM tblPosition WHERE positionID = @positionID", connection)
        command.Parameters.AddWithValue("@positionID", positionID)
        command.ExecuteNonQuery()
        MessageBox.Show("Position deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Function DisplayIncentives() As DataTable
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("SELECT * FROM tblIncentives", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
        connection.Close()
    End Function

    Public Sub NewIncentives(incentiveName As String)
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("INSERT INTO tblIncentives (incentiveName) VALUES (@incentiveName)", connection)
        command.Parameters.AddWithValue("@incentiveName", incentiveName)
        command.ExecuteNonQuery()
        MessageBox.Show("Incentive added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Sub DeleteIncentives(incentiveID As Integer)
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("DELETE FROM tblIncentives WHERE incentiveID = @incentiveID", connection)
        command.Parameters.AddWithValue("@incentiveID", incentiveID)
        command.ExecuteNonQuery()
        MessageBox.Show("Incentive deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Function DisplayAllowance() As DataTable
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("SELECT * FROM tblAllowance", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        Return datatable
        connection.Close()
    End Function

    Public Sub NewAllowance(allowanceName As String)
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("INSERT INTO tblAllowance (allowanceName) VALUES (@allowanceName)", connection)
        command.Parameters.AddWithValue("@allowanceName", allowanceName)
        command.ExecuteNonQuery()
        MessageBox.Show("Allowance added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Sub DeleteAllowance(allowanceID As Integer)
        Dim connection As New SqlConnection()
        connection.Open()
        Dim command As New SqlCommand("DELETE FROM tblAllowance WHERE allowanceID = @allowanceID", connection)
        command.Parameters.AddWithValue("@allowanceID", allowanceID)
        command.ExecuteNonQuery()
        MessageBox.Show("Allowance deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub
End Module
