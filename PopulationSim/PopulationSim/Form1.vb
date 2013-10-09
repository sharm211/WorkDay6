Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim population As Integer
        Dim year As Double
        population = 7000
        year = 2012

        Do While (population > 6)
            year = year - 50
            population = CInt(population / 2)

        Loop

        MessageBox.Show("this year is " & year, "Error")


    End Sub
End Class
