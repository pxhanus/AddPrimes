'Patricia Hanus
'151105
'Add Primes
'___________________________________________________________________________
Public Class Form1

    Private Sub btnAddPrimes_Click(sender As Object, e As EventArgs) Handles btnAddPrimes.Click
        Dim num1 As Integer = Val(Me.txtNum1.Text)
        Dim num2 As Integer = Val(Me.txtNum2.Text)
        Dim isPrime As Boolean = False

        Call IsSumPrime(num1, num2, isPrime)

        If Not isPrime Then
            Me.lblAns.Text = "The sum is not prime"
        Else
            Me.lblAns.Text = "The sum is prime"
        End If
    End Sub
    '****************************************************************
    'IsSumPrime - returns true if num1 + num2 is prime and false otherwise
    '
    'pre:  num1 and num2 should primes
    'post: true or false is returned in prime
    '****************************************************************
    Sub IsSumPrime(ByVal num1Dif As Integer, ByVal num2Diff As Integer, ByRef prime As Boolean)
        Dim sum As Integer = num1Dif + num2Diff
        Dim div As Integer = 2
        Do While sum Mod div <> 0
            div += 1
        Loop

        If sum = div Then
            prime = True
        Else
            prime = False
        End If
    End Sub

End Class
