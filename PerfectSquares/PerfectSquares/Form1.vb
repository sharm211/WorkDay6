﻿Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        lstResult.Items.Clear()
        Dim n As Integer
        n = 1
        Do While (n <= 10)
            lstResult.Items.Add("The perfect Square: " & n ^ 2)
            n = n + 1

        Loop


        lstResult.Items.Add(n)

    End Sub
End Class
