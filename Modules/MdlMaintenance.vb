Imports MySql.Data.MySqlClient
Module MdlMaintenance

    Dim connection As New MySqlConnection("server=localhost;port=3306;user id=root;password=052903;database=dbmcpms")
    Public Function DisplayDepartment() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblDepartment", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        connection.Close()
        Return datatable
    End Function

    Public Sub NewDepartment(departmentName As String)
        connection.Open()
        Dim command As New MySqlCommand("INSERT INTO tblDepartment (departmentName, status) VALUES (@departmentName, @status)", connection)
        command.Parameters.AddWithValue("@departmentName", departmentName)
        command.Parameters.AddWithValue("@status", "Active")
        command.ExecuteNonQuery()
        MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Function DisplayLeave() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblLeave", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        connection.Close()
        Return datatable
    End Function

    Public Sub NewLeave(leaveType As String)
        connection.Open()
        Dim command As New MySqlCommand("INSERT INTO tblLeave (leaveType, status) VALUES (@leaveType, @status)", connection)
        command.Parameters.AddWithValue("@leaveType", leaveType)
        command.Parameters.AddWithValue("@status", "Active")
        command.ExecuteNonQuery()
        MessageBox.Show("Type of leave added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Function DisplayPosition() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblPosition", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        connection.Close()
        Return datatable
    End Function

    Public Sub NewPosition(positionName As String, departmentID As Integer)
        connection.Open()
        Dim command As New MySqlCommand("INSERT INTO tblPosition (departmentID, positionName, status) VALUES (@departmentID, @positionName, @status)", connection)
        command.Parameters.AddWithValue("@departmentID", departmentID)
        command.Parameters.AddWithValue("@positionName", positionName)
        command.Parameters.AddWithValue("@status", "Active")
        command.ExecuteNonQuery()
        MessageBox.Show("Position added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Function DisplayIncentives() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblIncentives", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        connection.Close()
        Return datatable
    End Function

    Public Sub NewIncentives(incentiveName As String)
        connection.Open()
        Dim command As New MySqlCommand("INSERT INTO tblIncentives (incentiveName, status) VALUES (@incentiveName, @status)", connection)
        command.Parameters.AddWithValue("@incentiveName", incentiveName)
        command.Parameters.AddWithValue("@status", "Active")
        command.ExecuteNonQuery()
        MessageBox.Show("Incentive added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Function DisplayAllowance() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblAllowance", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim datatable As New DataTable
        adapter.Fill(datatable)
        connection.Close()
        Return datatable
    End Function

    Public Sub NewAllowance(allowanceName As String)
        connection.Open()
        Dim command As New MySqlCommand("INSERT INTO tblAllowance (allowanceName, status) VALUES (@allowanceName, @status)", connection)
        command.Parameters.AddWithValue("@allowanceName", allowanceName)
        command.Parameters.AddWithValue("@status", "Active")
        command.ExecuteNonQuery()
        MessageBox.Show("Allowance added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

End Module
