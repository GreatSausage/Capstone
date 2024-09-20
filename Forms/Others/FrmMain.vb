Public Class FrmMain
    Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - (y - Screen.PrimaryScreen.WorkingArea.Height)
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub BtnMaintenance_Click(sender As Object, e As EventArgs) Handles BtnMaintenance.Click
        DisplayFormPanel(FrmMaintenance, DisplayPanel)
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class