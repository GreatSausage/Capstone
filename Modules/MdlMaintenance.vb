Imports MySql.Data.MySqlClient
Module MdlMaintenance

    Dim connection As New MySqlConnection("server=localhost;port=3306;user id=root;password=052903;database=dbmcpms")
#Region "Department"
    Public Function DisplayDepartment() As DataTable
        connection.Open()
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
        Dim max As Decimal = 0
        RunQuery("Select max(maxSalary) from tbltax")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Dim result = ds.Tables("querytable").Rows(0)(0)
            If Not IsDBNull(result) Then
                max = Convert.ToDecimal(result) + 0.01
            End If
        Else
            max = 0
        End If
        Return max
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

    Public Function DisplayPagIbig() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM tblSSS", connection)
        Dim datatable As New DataTable
        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(datatable)
        connection.Close()
        Return datatable
    End Function
    Public Function SSSGetMaxSalary() As Decimal
        Dim max As Decimal = 0
        RunQuery("Select max(maxSalary) from tblsss")
        If ds.Tables("querytable").Rows.Count > 0 Then
            Dim result = ds.Tables("querytable").Rows(0)(0)
            If Not IsDBNull(result) Then
                max = Convert.ToDecimal(result) + 0.01
            End If
        Else
            max = 0
        End If
        Return max
    End Function

    Public Sub NewPagibig(rate As Integer)
        Dim command As New MySqlCommand("Insert into tblpagibig (rate,date)
                                         VALUES (@rate,current_timestamp)", connection)
        With command.Parameters
            .AddWithValue("@rate", rate)
        End With
        command.ExecuteNonQuery()
        MessageBox.Show("New Pag-Ibig rate updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
    End Sub


    Public Sub NewSSS(minSalary As Decimal, maxSalary As Decimal, EE As Decimal, wisp As Decimal, total As Decimal)
        connection.Open()
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
