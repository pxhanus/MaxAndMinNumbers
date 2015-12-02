'Patricia Hanus
'151202
'Max And Min Numbers
'_____________________________________________________________________________
Public Class Form1
    Dim numbers(9) As Integer
    Private Sub btnNumbers_Click(sender As Object, e As EventArgs) Handles btnNumbers.Click
        Me.lstNums.Items.Clear()
        Me.lblMaxMin.Text = Nothing

        For index As Integer = 0 To 9
            numbers(index) = RndInt(1, 99)
        Next

        Call DisplayArray(Me.lstNums, numbers)

    End Sub
    '********************************************************************************************
    'RndInt
    'Returns a random integer between max and min
    '
    'post:  A number is returned
    '********************************************************************************************
    Function RndInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Randomize()
        Return Int((max - min + 1) * Rnd() + min)
    End Function
    '********************************************************************************************
    'DisplayArray
    'Displays the contents of the passed array in the passed list box values index
    '
    'post:  Array results displayed in list box 
    '********************************************************************************************
    Sub DisplayArray(ByRef lstbox As ListBox, ByRef array() As Integer)
        For index As Integer = 0 To array.Length - 1
            lstbox.Items.Add(array(index))
        Next
    End Sub
End Class
