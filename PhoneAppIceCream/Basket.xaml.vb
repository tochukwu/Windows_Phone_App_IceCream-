
Partial Public Class Basket
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()

        SummaryListBox.Items.Clear()

        If VanillaScoops > 0 Then
            SummaryListBox.Items.Add(VanillaScoops & " X Vanilla Scoops " & " @ " & " £ " & VanillaOrder.ToString("N2"))
        End If

        If ChocolateScoops > 0 Then
            SummaryListBox.Items.Add(ChocolateScoops & " X Chocolate Scoops " & " @ " & " £ " & ChocolateOrder.ToString("N2"))
        End If

        If BananaScoops > 0 Then
            SummaryListBox.Items.Add(BananaScoops & " X Banana Scoops " & " @ " & " £ " & BananaOrder.ToString("N2"))
        End If

        If StrawberryScoops > 0 Then
            SummaryListBox.Items.Add(StrawberryScoops & " X Strawberry Scoops " & " @ " & " £ " & StrawberyOrder.ToString("N2"))
        End If

        If MintOrder > 0 Then
            SummaryListBox.Items.Add(MintScoops & " X Mint Scoops " & " @ " & " £ " & MintOrder.ToString("N2"))
        End If

        If LagerOrder > 0 Then
            SummaryListBox.Items.Add(LagerScoops & " X Lager Scoops " & " @ " & " £ " & LagerOrder.ToString("N2"))
        End If

        If LemonOrder > 0 Then
            SummaryListBox.Items.Add(LemonScoops & " X Lemon Scoops " & " @ " & " £ " & LemonOrder.ToString("N2"))
        End If

        If EggOrder > 0 Then
            SummaryListBox.Items.Add(EggScoops & " X Egg Scoops " & " @ " & " £ " & EggOrder.ToString("N2"))
        End If

        If CurryOrder Then
            SummaryListBox.Items.Add(CurryScoops & " X Curry Scoops " & " @ " & " £ " & CurryOrder.ToString("N2"))
        End If



        SubTotal = VanillaOrder + BananaOrder + StrawberyOrder + MintOrder + LagerOrder + EggOrder + CurryOrder + ChocolateOrder + LemonOrder
        TxtBoxSubTotal.Text = SubTotal.ToString("N2")


    End Sub

    Private Sub RadioBYes_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles RadioBYes.Checked
        If RadioBYes.IsChecked Then
            NewTotal = SubTotal * 0.9
            TxtBoxTotal.Text = NewTotal.ToString("N2")
            NumberOfMembers += 1
        End If
    End Sub

    Private Sub RadiBNo_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles RadioBNo.Checked
        If RadioBNo.IsChecked Then
            TxtBoxTotal.Text = SubTotal.ToString("N2")
        End If
    End Sub

    Private Sub btnMoreIC_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMoreIC.Click
        NavigationService.Navigate(New Uri("/Menu.xaml", UriKind.Relative))
    End Sub

    Private Sub btnCheckOut_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnCheckOut.Click

        TxtBoxTotal.Text = ""
        TxtBoxSubTotal.Text = ""

        NavigationService.Navigate(New Uri("/Home.xaml", UriKind.Relative))

        RunningVnScoops = RunningVnScoops + VanillaScoops
        RunningBnScoops = RunningBnScoops + BananaScoops
        RunningChScoops = RunningChScoops + ChocolateScoops
        RunningEgScoops = RunningEgScoops + EggScoops
        RunningLcScoops = RunningLcScoops + LemonScoops
        RunningLgScoops = RunningLgScoops + LagerScoops
        RunningMtScoops = RunningMtScoops + MintScoops
        RunningSrScoops = RunningSrScoops + StrawberryScoops
        RunningCrScoops = RunningCrScoops + CurryScoops


        RunningVnPrice = RunningVnPrice + VanillaOrder
        RunningBnPrice = RunningBnPrice + BananaOrder
        RunningChPrice = RunningChPrice + ChocolateOrder
        RunningEgPrice = RunningEgPrice + EggOrder
        RunningLcPrice = RunningLcPrice + LemonOrder
        RunningLgPrice = RunningLgPrice + LagerOrder
        RunningMtPrice = RunningMtPrice + MintOrder
        RunningSrPrice = RunningSrPrice + StrawberyOrder
        RunningCrPrice = RunningCrPrice + CurryScoops

        NumberOfCustomers += 1

        SummaryListBox.Items.Clear()
        ResetScoops()
        ResetPrice()

    End Sub

    Public Sub ResetScoops()
        VanillaScoops = 0
        BananaScoops = 0
        StrawberryScoops = 0
        MintScoops = 0
        LemonScoops = 0
        LagerScoops = 0
        EggScoops = 0
        CurryScoops = 0
        ChocolateScoops = 0
    End Sub

    Public Sub ResetPrice()
        VanillaOrder = 0
        BananaOrder = 0
        ChocolateOrder = 0
        EggOrder = 0
        LemonOrder = 0
        LagerOrder = 0
        MintOrder = 0
        StrawberyOrder = 0
        CurryOrder = 0

    End Sub

    Private Sub SummaryListBox_SelectionChanged(sender As System.Object, e As System.Windows.Controls.SelectionChangedEventArgs) Handles SummaryListBox.SelectionChanged

    End Sub

    Private Sub TxtBoxSubTotal_TextChanged(sender As System.Object, e As System.Windows.Controls.TextChangedEventArgs) Handles TxtBoxSubTotal.TextChanged

    End Sub
End Class
