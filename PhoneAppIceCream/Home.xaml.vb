Partial Public Class Home
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BtnMenu_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMenu.Click
        NavigationService.Navigate(New Uri("/Menu.xaml", UriKind.Relative))
    End Sub

    Private Sub btnSummary_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnSummary.Click
        NavigationService.Navigate(New Uri("/Summary.xaml", UriKind.Relative))
    End Sub

End Class
