Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Collections
Imports System.Text

Partial Public Class Report
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()

        TxtBTotalCustomer.Text = NumberOfCustomers
        TxtBMemberTotal.Text = NumberOfMembers

        AveragePricePerCustomer = RunningPriceTotal / NumberOfCustomers

        TxtBAveragePrice.Text = AveragePricePerCustomer.ToString("N2")

        TxtBQTotal.Text = RunningTotalScoops

        TxtBPTotal.Text = RunningPriceTotal.ToString("N2")
    End Sub

    Private Sub btnReport_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnReport.Click
        'Check the user has entered a filename
        If (TxtBReportName.Text = String.Empty) Then
            MessageBox.Show("You must enter a filename to continue", "Warning", MessageBoxButton.OK)
        Else
            Try
                Using store As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
                    Dim sb As StringBuilder = New StringBuilder

                    'Determine if the filename has already been used.
                    If store.FileExists(TxtBReportName.Text + "-Takings.txt") Then
                        TxtBReportName.Text = ("Filename already exists," + vbCrLf + "please try again.")
                    Else
                        'Create a text file for takings
                        Dim takingsFile As IsolatedStorageFileStream = _
                            store.CreateFile(TxtBReportName.Text + "-Takings.txt")
                        takingsFile.Close()
                        'Create a text file for stock totals
                        Dim stockFile As IsolatedStorageFileStream = _
                           store.CreateFile(TxtBReportName.Text + "-Stock.txt")
                        stockFile.Close()
                        'Write takings to text file
                        If store.FileExists(TxtBReportName.Text + "-Takings.txt") Then
                            Try
                                Using sw As StreamWriter = _
                                    New StreamWriter(store.OpenFile((TxtBReportName.Text + "-Takings.txt"), FileMode.Open, FileAccess.Write))
                                    sw.WriteLine("End of Day Summary:")
                                    sw.WriteLine("Filename : " + TxtBReportName.Text)
                                    sw.WriteLine("Takings")
                                    sw.WriteLine(" ")
                                    sw.WriteLine("Total Takings: £" + RunningPriceTotal.ToString("N2"))
                                    sw.WriteLine("Average Sale: £" + AveragePricePerCustomer.ToString("N2"))
                                    sw.WriteLine("Total Customers: " + NumberOfCustomers.ToString)
                                    sw.WriteLine("Total Memebers: " + NumberOfMembers.ToString)
                                End Using
                            Catch ex As IsolatedStorageException
                                sb.AppendLine(ex.Message)
                                TxtLabel.Text = sb.ToString
                            End Try
                        Else
                            sb.AppendLine(((TxtBReportName.Text + "-Takings.txt") + "does not exist"))
                            TxtLabel.Text = sb.ToString
                        End If
                        'Write stock to text file
                        If store.FileExists(TxtBReportName.Text + "-Stock.txt") Then
                            Try
                                Using sw As StreamWriter = _
                                    New StreamWriter(store.OpenFile((TxtBReportName.Text + "-Stock.txt"), FileMode.Open, FileAccess.Write))
                                    sw.WriteLine("End of Day Summary:")
                                    sw.WriteLine("Filename : " + TxtBReportName.Text)
                                    sw.WriteLine("Stock Sold")
                                    sw.WriteLine(" ")
                                    sw.WriteLine("Vanilla:" + RunningVnScoops.ToString)
                                    sw.WriteLine("Strawberry: " + RunningSrScoops.ToString)
                                    sw.WriteLine("Chocolate: " + RunningChScoops.ToString)
                                    sw.WriteLine("Banana: " + RunningBnScoops.ToString)
                                    sw.WriteLine("Mint: " + RunningMtScoops.ToString)
                                    sw.WriteLine("Lemon Cheesecake: " + RunningLcScoops.ToString)
                                    sw.WriteLine("Egg: " + RunningEgPrice.ToString)
                                    sw.WriteLine("Curry: " + RunningCrScoops.ToString)
                                    sw.WriteLine("Lager: " + RunningLgScoops.ToString)
                                End Using
                            Catch ex As IsolatedStorageException
                                sb.AppendLine(ex.Message)
                                TxtLabel.Text = sb.ToString
                            End Try
                        Else
                            sb.AppendLine(((TxtBReportName.Text + "-Stock.txt") + "does not exist"))
                            TxtLabel.Text = sb.ToString
                        End If
                        'Reset variables for a new session
                        RunningVnPrice = 0
                        RunningChPrice = 0
                        RunningSrPrice = 0
                        RunningMtPrice = 0
                        RunningBnPrice = 0
                        RunningCrPrice = 0
                        RunningEgPrice = 0
                        RunningLgPrice = 0
                        RunningLcPrice = 0
                        RunningSrPrice = 0

                        RunningVnScoops = 0
                        RunningChScoops = 0
                        RunningSrScoops = 0
                        RunningMtScoops = 0
                        RunningBnScoops = 0
                        RunningCrScoops = 0
                        RunningEgScoops = 0
                        RunningLgScoops = 0
                        RunningLcScoops = 0
                        RunningSrScoops = 0

                        NumberOfCustomers = 0
                        RunningPriceTotal = 0
                        NumberOfMembers = 0
                        AveragePricePerCustomer = 0

                        MessageBox.Show("File saved, data has been reset to start a new session", "Message", MessageBoxButton.OK)
                        NavigationService.Navigate(New Uri("/Summary.xaml", UriKind.RelativeOrAbsolute))
                    End If
                End Using
            Catch Ex As IsolatedStorageException
            End Try
        End If
    End Sub
End Class
