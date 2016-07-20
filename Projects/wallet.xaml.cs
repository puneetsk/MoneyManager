using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    public sealed partial class wallet : Page
    {
       
        public wallet()
        {
            this.InitializeComponent();
            
        }
        String walletamount;
        String currentd;
        String cyr;

        //protected override async void OnNavigatedTo(NavigationEventArgs s)
        //{
        //    if (s.Parameter != null)
        //    {
        //        String walletamountd = s.Parameter.ToString();
        //        balancebox.Text = walletamount;
        //        base.OnNavigatedTo(s);

        //    }

        //    else
        //    {
        //        String ds = "The Value is Null";
        //    }
        //}


        private void minus_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(debit), walletamount);

        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(credit), null);
        }

        private void setting_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(settings), null);
        }

        private async void suma_Click(object sender, RoutedEventArgs e)
        {

            StorageFolder walletFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            var walle = await walletFolder.GetFileAsync("wallet.txt");
            var walletamounts = await FileIO.ReadTextAsync(walle);
            walletamount = walletamounts;

            StorageFolder CurrencyFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            var cur = await CurrencyFolder.GetFileAsync("Currency.txt");
            var currents = await FileIO.ReadTextAsync(cur);
            currentd = currents;
            //String cyr = current;
           

            if (currentd == "Dollar")
            {
              cyr = "$";
               balancebox.Text = cyr +" "+ walletamount;
            }
            else if (currentd == "Yen")
            {
                 cyr = "Yen";
                balancebox.Text = cyr + " " + walletamount;
            }

            else
            {
              cyr = "Euro";
                balancebox.Text = cyr + " " + walletamount;
            }
        }
    }
}
