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
    public sealed partial class credit : Page
    {
        public credit()
        {
            this.InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            creditamount.Text += b.Content.ToString();
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                creditamount.Text = "Error!";
            }
        }

        private void result()
        {
            String cal;
            int iOp = 0;
            if (creditamount.Text.Contains("+"))
            {
                iOp = creditamount.Text.IndexOf("+");
            }
            else if (creditamount.Text.Contains("-"))
            {
                iOp = creditamount.Text.IndexOf("-");
            }
            else if (creditamount.Text.Contains("*"))
            {
                iOp = creditamount.Text.IndexOf("*");
            }
            else if (creditamount.Text.Contains("/"))
            {
                iOp = creditamount.Text.IndexOf("/");
            }
            else
            {

            }

            cal = creditamount.Text.Substring(iOp, 1);
            double cal1 = Convert.ToDouble(creditamount.Text.Substring(0, iOp));
            double cal2 = Convert.ToDouble(creditamount.Text.Substring(iOp + 1, creditamount.Text.Length - iOp - 1));

            if (cal == "+")
            {
                creditamount.Text = Convert.ToString(cal1 + cal2);
            }
            else if (cal == "-")
            {
                creditamount.Text = Convert.ToString(cal1 - cal2);
            }
            else if (cal == "*")
            {
                creditamount.Text = Convert.ToString(cal1 * cal2);
            }
            else
            {
                creditamount.Text = Convert.ToString(cal1 / cal2);
            }
        }

      
        private void Clr_Click_1(object sender, RoutedEventArgs e)
        {
            creditamount.Text = "";
        }

        private void R_Click_1(object sender, RoutedEventArgs e)
        {
            if (creditamount.Text.Length > 0)
            {
                creditamount.Text = creditamount.Text.Substring(0, creditamount.Text.Length - 1);
            }
        }

        private void back(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(wallet), null);
        }

        private void creditcategory_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(creditcategory), null);
        }


        protected override void OnNavigatedTo(NavigationEventArgs d)
        {
            if (d.Parameter != null)
            {
                note.Text = d.Parameter.ToString();
                base.OnNavigatedTo(d);
            }
            else
            {
                String s = "The Value is Null";
            }
        }

       

        private async void creditbutton_Click(object sender, RoutedEventArgs e)
        {
            // To store the money to be Credited amount
            int cred = int.Parse(creditamount.Text);

            StorageFolder walletFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            var walle = await walletFolder.GetFileAsync("wallet.txt");
            var walletamounts = await FileIO.ReadTextAsync(walle);
            int temp = int.Parse(walletamounts);
            int Store = temp + cred;
            String stores = Convert.ToString(Store);


            StorageFile newFile = await walletFolder.CreateFileAsync("wallet.txt", CreationCollisionOption.OpenIfExists);
            await FileIO.WriteTextAsync(newFile, stores);
            MessageDialog msgbox = new MessageDialog("Credit $" + cred + "\n" + "Your Balance is $" + stores, "My Wallet");
            msgbox.Commands.Clear();
            var res = await msgbox.ShowAsync();

        }
    }

}
