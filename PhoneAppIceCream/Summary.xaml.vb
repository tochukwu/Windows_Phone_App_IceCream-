Partial Public Class Summary
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()

        TxtBQVanilla.Text = RunningVnScoops
        TxtBQChocolate.Text = RunningChScoops
        TxtBQCurry.Text = RunningCrScoops
        TxtBQEgg.Text = RunningEgScoops
        TxtBQLager.Text = RunningLgScoops
        TxtBQLemon.Text = RunningLcScoops
        TxtBQMint.Text = RunningMtScoops
        TxtBQStrawberry.Text = RunningSrScoops
        TxtBQBanana.Text = RunningBnScoops

        RunningTotalScoops = RunningVnScoops + RunningChScoops + RunningCrScoops + RunningEgScoops + RunningLgScoops + RunningLcScoops + RunningMtScoops + RunningSrScoops + RunningBnScoops
        TxtBQTotal.Text = RunningTotalScoops

        TxtBPBanana.Text = RunningBnPrice.ToString("N2")
        TxtBPChocolate.Text = RunningChPrice.ToString("N2")
        TxtBPCurry.Text = RunningCrPrice.ToString("N2")
        TxtBPEgg.Text = RunningEgPrice.ToString("N2")
        TxtBPLager.Text = RunningLgPrice.ToString("N2")
        TxtBPLemon.Text = RunningLcPrice.ToString("N2")
        TxtBPMint.Text = RunningMtPrice.ToString("N2")
        TxtBPStrawberry.Text = RunningSrPrice.ToString("N2")
        TxtBPVanilla.Text = RunningVnPrice.ToString("N2")

        RunningPriceTotal = RunningBnPrice + RunningChPrice + RunningCrPrice + RunningEgPrice + RunningLgPrice + RunningLcPrice + RunningMtPrice + RunningSrPrice + RunningVnPrice
        TxtBPTotal.Text = RunningPriceTotal.ToString("N2")


        TxtBTotalCustomer.Text = NumberOfCustomers
        TxtBMemberTotal.Text = NumberOfMembers

        AveragePricePerCustomer = RunningPriceTotal / NumberOfCustomers

        TxtBAveragePrice.Text = AveragePricePerCustomer.ToString("N2")
    End Sub

    Private Sub btnReport_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnReport.Click
        NavigationService.Navigate(New Uri("/Report.xaml", UriKind.Relative))
    End Sub

    Private Sub btnHome_Click_1(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnHome.Click
        NavigationService.Navigate(New Uri("/Home.xaml", UriKind.Relative))
    End Sub

    Private Sub TxtBQVanilla_TextChanged(sender As System.Object, e As System.Windows.Controls.TextChangedEventArgs) Handles TxtBQVanilla.TextChanged

    End Sub
End Class
