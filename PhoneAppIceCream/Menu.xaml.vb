Partial Public Class Menu
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnVanilla_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnVanilla.Click
        NavigationService.Navigate(New Uri("/Vanilla.xaml", UriKind.Relative))
    End Sub

    Private Sub btnChocolate_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnChocolate.Click
        NavigationService.Navigate(New Uri("/Chocolate.xaml", UriKind.Relative))
    End Sub

    Private Sub btnStrawberry_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnStrawberry.Click
        NavigationService.Navigate(New Uri("/Strawberry.xaml", UriKind.Relative))
    End Sub

    Private Sub btnLemon_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnLemon.Click
        NavigationService.Navigate(New Uri("/Lemon.xaml", UriKind.Relative))
    End Sub

    Private Sub btnBanana_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnBanana.Click
        NavigationService.Navigate(New Uri("/Banana.xaml", UriKind.Relative))
    End Sub

    Private Sub btnMint_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMint.Click
        NavigationService.Navigate(New Uri("/Mint.xaml", UriKind.Relative))
    End Sub

    Private Sub btnCurry_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnCurry.Click
        NavigationService.Navigate(New Uri("/Curry.xaml", UriKind.Relative))
    End Sub

    Private Sub btnLager_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnLager.Click
        NavigationService.Navigate(New Uri("/Lager.xaml", UriKind.Relative))
    End Sub

    Private Sub btnEgg_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnEgg.Click
        NavigationService.Navigate(New Uri("/Egg.xaml", UriKind.Relative))
    End Sub

    Private Sub btnBasket_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnBasket.Click
        NavigationService.Navigate(New Uri("/Basket.xaml", UriKind.Relative))
    End Sub
End Class
