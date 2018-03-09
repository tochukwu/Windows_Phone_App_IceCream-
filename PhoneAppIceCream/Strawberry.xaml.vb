Partial Public Class Strawberry
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnMoreIC_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMoreIC.Click
        NavigationService.Navigate(New Uri("/Menu.xaml", UriKind.Relative))
        If StrawberryScoops > 0 Then
            StrawberyOrder = StrawberryScoops * 1.25
        End If
    End Sub

    Private Sub btnBasket_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnBasket.Click
        NavigationService.Navigate(New Uri("/Basket.xaml", UriKind.Relative))
        If StrawberryScoops > 0 Then
            StrawberyOrder = StrawberryScoops * 1.25
        End If
    End Sub

    Private Sub btnPlus_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnPlus.Click
        If StrawberryScoops <= 4 Then
            StrawberryScoops = StrawberryScoops + 1
            txtBoxScoops.Text = StrawberryScoops
        Else
            MessageBox.Show("Cant Have More Than 5 Scoops")
        End If
    End Sub

    Private Sub btnMinus_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMinus.Click
        If StrawberryScoops > 0 Then
            StrawberryScoops = StrawberryScoops - 1
            txtBoxScoops.Text = StrawberryScoops
        Else
            MessageBox.Show("Cant Get Ice Cream From The Customer")
        End If
    End Sub
End Class
