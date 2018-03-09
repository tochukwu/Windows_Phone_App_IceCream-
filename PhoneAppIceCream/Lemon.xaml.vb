﻿Partial Public Class Lemon
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnMoreIC_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMoreIC.Click
        NavigationService.Navigate(New Uri("/Menu.xaml", UriKind.Relative))
        If LemonScoops > 0 Then
            LemonOrder = LemonScoops * 1.5
        End If
    End Sub

    Private Sub btnBasket_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnBasket.Click
        NavigationService.Navigate(New Uri("/Basket.xaml", UriKind.Relative))
        If LemonScoops > 0 Then
            LemonOrder = LemonScoops * 1.5
        End If
    End Sub

    Private Sub btnPlus_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnPlus.Click
        If LemonScoops <= 4 Then
            LemonScoops = LemonScoops + 1
            txtBoxScoops.Text = LemonScoops
        Else
            MessageBox.Show("Cant Have More Than 5 Scoops")
        End If
    End Sub

    Private Sub btnMinus_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMinus.Click
        If LemonScoops > 0 Then
            LemonScoops = LemonScoops - 1
            txtBoxScoops.Text = LemonScoops
        Else
            MessageBox.Show("Cant Get Ice Cream From The Customer")
        End If
    End Sub
End Class
