using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Projects
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class debit : Page
    {
        public debit()
        {
            this.InitializeComponent();
        }



       protected override void OnNavigatedTo(NavigationEventArgs d)
       {
            if (d.Parameter != null)
            {
                note.PlaceholderText = d.Parameter.ToString();
                base.OnNavigatedTo(d);
            }
            else
            {
                String s = "The Value is Null";
            }
       }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            debitamount.Text += b.Content.ToString();
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                debitamount.Text = "Error!";
            }
        }

        private void result()
        {
            String op;
            int iOp = 0;
            if (debitamount.Text.Contains("+"))
            {
                iOp = debitamount.Text.IndexOf("+");
            }
            else if (debitamount.Text.Contains("-"))
            {
                iOp = debitamount.Text.IndexOf("-");
            }
            else if (debitamount.Text.Contains("*"))
            {
                iOp = debitamount.Text.IndexOf("*");
            }
            else if (debitamount.Text.Contains("/"))
            {
                iOp = debitamount.Text.IndexOf("/");
            }
            else
            {
                
            }

            op = debitamount.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(debitamount.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(debitamount.Text.Substring(iOp + 1, debitamount.Text.Length - iOp - 1));

            if (op == "+")
            {
                debitamount.Text = Convert.ToString(op1 + op2);
            }
            else if (op == "-")
            {
                debitamount.Text = Convert.ToString(op1 - op2);
            }
            else if (op == "*")
            {
                debitamount.Text = Convert.ToString(op1 * op2);
            }
            else
            {
                debitamount.Text = Convert.ToString(op1 / op2);
            }
        }

        private void Clr_Click_1(object sender, RoutedEventArgs e)
        {
            debitamount.Text = "";
        }

        private void R_Click_1(object sender, RoutedEventArgs e)
        {
            if (debitamount.Text.Length > 0)
            {
                debitamount.Text = debitamount.Text.Substring(0, debitamount.Text.Length - 1);
            }
        }

        private void back_click1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(wallet), null);
        }

        private void debitcategory_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(debitcategory), null);
        }

        private async void  debitbutton_Click(object sender, RoutedEventArgs e)
        {

            // To store the money to be debited amount
            int deb = int.Parse(debitamount.Text);

            StorageFolder walletFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            var walle = await walletFolder.GetFileAsync("wallet.txt");
            var walletamounts = await FileIO.ReadTextAsync(walle);
            int temp = int.Parse(walletamounts);
            int Store = temp - deb;
            String stores = Convert.ToString(Store);

            
            StorageFile newFile = await walletFolder.CreateFileAsync("wallet.txt", CreationCollisionOption.OpenIfExists);
            await FileIO.WriteTextAsync(newFile, stores);
            MessageDialog msgbox = new MessageDialog("Debitted $" + deb + "\n" + "Your Balance is $" +stores, "My Wallet");
            msgbox.Commands.Clear();
            var res = await msgbox.ShowAsync();

        }
    }
}
