Public Class Form1
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' fill list box with rates and select 3.0 rate.

        For dblRates As Double = 2 To 7 Step 0.5
            lstRates.Items.Add(dblRates.ToString("N1"))
        Next dblRates
        lstRates.SelectedItem = "3.0"
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'display the monthly mortage payment.

        Dim intPrincipal As Integer
        Dim dblRate As Double
        Dim dblPay As Double

        Integer.TryParse(txtPrincipal.Text, intPrincipal)
        Double.TryParse(lstRates.SelectedItem.ToString, dblRate)
        dblRate = dblRate / 100

        lblPays.Text = String.Empty
        For intTerm As Integer = 15 To 30 Step 5
            dblPay = -Financial.Pmt(dblRate / 12, intTerm * 12, intPrincipal)
            lblPays.Text = lblPays.Text & intTerm.ToString & " years: " & dblPay.ToString("C2") & ControlChars.NewLine
        Next
    End Sub


End Class
