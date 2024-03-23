Public Class Form1
    Dim firstValue As Double
    Dim SecondValue As Double
    Dim currentoperation As String

    Private Sub btnNumber_click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

        TextBox1.Text &= DirectCast(sender, Button).Text
    End Sub

    Private Sub btnOperator_click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMultiply.Click, btnMinus.Click, btnDivide.Click

        firstValue = Double.Parse(TextBox1.Text)
        currentoperation = DirectCast(sender, Button).Text
        TextBox1.Text = ""
    End Sub

    Private Sub btnEquals_click(sender As Object, e As EventArgs) Handles btnEquals.Click
        SecondValue = Double.Parse(TextBox1.Text)
        Select Case currentoperation
            Case "+"
                TextBox1.Text = (firstValue + SecondValue).ToString()
            Case "-"
                TextBox1.Text = (firstValue - SecondValue).ToString()
            Case "*"
                TextBox1.Text = (firstValue * SecondValue).ToString
            Case "/"
                If SecondValue = 0 Then
                    TextBox1.Text = "ERROR"
                Else
                    TextBox1.Text = (firstValue / SecondValue).ToString
                End If
        End Select
    End Sub

    Private Sub btnClear_click(sender As Object, e As EventArgs) Handles btnClear.Click

        TextBox1.Text = ""
        firstValue = 0
        SecondValue = 0
        currentoperation = ""

    End Sub



End Class
