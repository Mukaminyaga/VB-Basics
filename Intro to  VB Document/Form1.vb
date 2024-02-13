Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Buttonload_Click(sender As Object, e As EventArgs) Handles buttonLoad.Click
        Dim objectDemoForm As New Form()

        ' Configure the Object Demonstrations form
        objectDemoForm.Text = "Object Demonstrations"
        ' Add other controls and configure the form as needed

        ' Show the Object Demonstrations form
        objectDemoForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        Application.Exit()
    End Sub
    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub
    Private Sub btnLoadDemo_MouseEnter(sender As Object, e As EventArgs) Handles buttonLoad.MouseEnter
        ' Set tooltip for Load Object Demo button
        ToolTip1.SetToolTip(buttonLoad, "Click to load object demo")
    End Sub

    ' Event handler for the MouseEnter event of the Exit button
    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles buttonExit.MouseEnter
        ' Set tooltip for Exit button
        ToolTip1.SetToolTip(buttonExit, "Click to exit")
    End Sub
End Class
