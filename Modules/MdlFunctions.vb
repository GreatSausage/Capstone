Module MdlFunctions

    Public letterOnly As String = "^[A-Za-z]+$"
    Public numberOnly As String = "^[0-9]+$"

    Public Sub DisplayFormPanel(frm As Form, displayPanel As Panel)
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(frm)
        frm.Show()
    End Sub

End Module
