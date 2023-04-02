Public Class Form1

    Public Sub Main()

    End Sub

    Private Sub Button_Calculate_Click(sender As Object, e As EventArgs) Handles Button_Calculate.Click

        Dim list_string As String = TextBox_Input.Text

        'Deleting elements in the string containing a 'coma' and concatenating the remaining 
        'character groups and storing them to an array
        Dim list_array As String() = list_string.Split(New Char() {","c})

        Dim sum_total As Integer = list_array.Length
        Dim sum As Double

        'Iterating through the array, and summing each element.
        For Each number As String In list_array
            sum += Convert.ToDouble(number)
        Next

        'Calculating Average
        Dim average As Double = sum / sum_total

        TextBox_Output.Text = Convert.ToString(average)

    End Sub

End Class
