Partial Public Class Banana
    Inherits PhoneApplicationPage
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnMoreIC_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMoreIC.Click
        NavigationService.Navigate(New Uri("/Menu.xaml", UriKind.Relative))
        If BananaScoops > 0 Then
            BananaOrder = BananaScoops * 1.5
        End If
    End Sub

    Private Sub btnBasket_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnBasket.Click
        NavigationService.Navigate(New Uri("/Basket.xaml", UriKind.Relative))
        If BananaScoops > 0 Then
            BananaOrder = BananaScoops * 1.5
        End If
    End Sub

    Private Sub btnPlus_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnPlus.Click
        If BananaScoops <= 4 Then
            BananaScoops = BananaScoops + 1
            txtBoxScoops.Text = BananaScoops
        Else
            MessageBox.Show("Cant Have More Than 5 Scoops")
        End If
    End Sub

    Private Sub btnMinus_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMinus.Click
        If BananaScoops > 0 Then
            BananaScoops = BananaScoops - 1
            txtBoxScoops.Text = BananaScoops
        Else
            MessageBox.Show("Cant Get Ice Cream From The Customer")
        End If
    End Sub

    Private Sub txtBoxScoops_TextChanged(sender As System.Object, e As System.Windows.Controls.TextChangedEventArgs) Handles txtBoxScoops.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.Windows.Controls.TextChangedEventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
