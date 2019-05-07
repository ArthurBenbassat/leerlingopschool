Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim naam, school, klas As String
        Dim lijn As String

        FileOpen(1, "C:\Users\Arthur\Downloads\schoolgegevens.txt", OpenMode.Append)

        lijn = txtSchool.Text.PadRight(30) & txtKlas.Text.PadRight(4) & txtNaam.Text

        PrintLine(1, lijn)
        FileClose(1)

    End Sub
End Class
