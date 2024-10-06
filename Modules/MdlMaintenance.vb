Imports MySql.Data.MySqlClient
Module MdlMaintenance

    Dim connection As New MySqlConnection("server=localhost;port=3306;user id=root;password=052903;database=dbmcpms")

#Region "Department"
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

#End Region

#Region "Leave"
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

#End Region

#Region "Position"
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

#End Region

#Region "Incentives"
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

#End Region

#Region "Allowance"
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

#End Region

#Region "Contributions"

    Public Function DisplayTax() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblTax", connection)
        Dim datatable As New DataTable
        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(datatable)
        connection.Close()
        Return datatable
    End Function

    Public Function TaxGetMaxSalary() As Decimal
        connection.Open()
        Dim command As New MySqlCommand("SELECT MAX(maxSalary) FROM tblTax", connection)
        Dim max As Decimal = Convert.ToDecimal(command.ExecuteScalar())
        max += 0.01
        If command.ExecuteReader.HasRows Then
            connection.Close()
            Return max
        Else
            connection.Close()
            Return 0
        End If
    End Function

    Public Sub NewTax(minimumSalary As Decimal, maximumSalary As Decimal, fixedAmount As Decimal, percentage As Integer)
        connection.Open()
        Dim command As New MySqlCommand("INSERT INTO tblTax (minSalary, maxSalary, fixedAmount, percentage) 
                                         VALUES (@minSalary, @maxSalary, @fixedAmount, @percentage)", connection)
        With command.Parameters
            .AddWithValue("@minSalary", minimumSalary)
            .AddWithValue("@maxSalary", maximumSalary)
            .AddWithValue("@fixedAmount", fixedAmount)
            .AddWithValue("@percentage", percentage)
        End With
        command.ExecuteNonQuery()
        MessageBox.Show("Tax added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

    Public Function DisplaySSS() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblSSS", connection)
        Dim datatable As New DataTable
        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(datatable)
        connection.Close()
        Return datatable
    End Function

    Public Function SSSGetMaxSalary() As Decimal
        connection.Open()
        Dim command As New MySqlCommand("SELECT MAX(maxSalary) FROM tblsss", connection)
        Dim max As Decimal = Convert.ToDecimal(command.ExecuteScalar())
        max += 0.01
        If command.ExecuteReader.HasRows Then
            connection.Close()
            Return max
        Else
            connection.Close()
            Return 0
        End If
    End Function

    Public Sub NewSSS(minSalary As Decimal, maxSalary As Decimal, EE As Decimal, wisp As Decimal, total As Decimal)
        Dim command As New MySqlCommand("INSERT INTO tblSSS (minSalary, maxSalary, EE, wisp, total) 
                                         VALUES (@minSalary, @maxSalary, @EE, @wisp, @total)", connection)
        With command.Parameters
            .AddWithValue("@minSalary", minSalary)
            .AddWithValue("@maxSalary", maxSalary)
            .AddWithValue("@EE", EE)
            .AddWithValue("@wisp", wisp)
            .AddWithValue("@total", total)
        End With
        command.ExecuteNonQuery()
        MessageBox.Show("SSS added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub

#End Region

End Module
