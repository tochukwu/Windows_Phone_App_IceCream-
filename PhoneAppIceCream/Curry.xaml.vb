Partial Public Class Curry
    Inherits PhoneApplicationPage
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnMoreIC_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMoreIC.Click
        NavigationService.Navigate(New Uri("/Menu.xaml", UriKind.Relative))
        If CurryScoops > 0 Then
            CurryOrder = CurryScoops * 2.25
        End If
    End Sub

    Private Sub btnBasket_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnBasket.Click
        NavigationService.Navigate(New Uri("/Basket.xaml", UriKind.Relative))
        If CurryScoops > 0 Then
            CurryOrder = CurryScoops * 2.25
        End If
    End Sub

    Private Sub btnPlus_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnPlus.Click
        If CurryScoops <= 4 Then
            CurryScoops = CurryScoops + 1
            txtBoxScoops.Text = CurryScoops
        Else
            MessageBox.Show("Cant Have More Than 5 Scoops")
        End If
    End Sub

    Private Sub btnMinus_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMinus.Click
        If CurryScoops > 0 Then
            CurryScoops = CurryScoops - 1
            txtBoxScoops.Text = CurryScoops
        Else
            MessageBox.Show("Cant Get Ice Cream From The Customer")
        End If
    End Sub
End Class
