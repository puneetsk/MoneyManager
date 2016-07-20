using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Notifications;
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
    public sealed partial class settings : Page
    {
        public settings()
        {
            this.InitializeComponent();
        }




        private async void okbutton_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)remainbox.SelectedValue;
            String remainder = (string)item.Content;

            ComboBoxItem item1 = (ComboBoxItem)currencycombo.SelectedValue;
            String currency = (string)item1.Content;

          
                ComboBoxItem item2 = (ComboBoxItem)remainbox.SelectedValue;
                String notification = (string)item2.Content;
                string msg = String.Format("<text id='2'> {0} </text>", notification);
                string toastXmlString = "<toast>"
                                       + "<visual version='1'>"
                                       + "<binding template='ToastText04'>"
                                       + msg
                                       + "<text id='2'>Please Pay</text>"
                                       + msg
                                       + "</binding>"
                                       + "</visual>"
                                       + "</toast>";

                Windows.Data.Xml.Dom.XmlDocument toastDOM = new Windows.Data.Xml.Dom.XmlDocument();
                toastDOM.LoadXml(toastXmlString);
                ToastNotification toast = new ToastNotification(toastDOM);
                ToastNotificationManager.CreateToastNotifier().Show(toast);
          

                //for storing the Currency TextBox
                StorageFolder CurrencyFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                StorageFile newFile = await CurrencyFolder.CreateFileAsync("Currency.txt", CreationCollisionOption.OpenIfExists);
                await FileIO.WriteTextAsync(newFile, currency);

                //for storing the Remainder 
                StorageFolder remainderFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                StorageFile newFile1 = await remainderFolder.CreateFileAsync("remainder.txt", CreationCollisionOption.OpenIfExists);
                await FileIO.WriteTextAsync(newFile1, remainder);
               // this.Frame.Navigate(typeof(wallet), null);

                //for storing the Wallet Amount 
                StorageFolder walletFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                StorageFile newFile2 = await walletFolder.CreateFileAsync("wallet.txt", CreationCollisionOption.OpenIfExists);
                await FileIO.WriteTextAsync(newFile2, budgetbox.Text);
                 this.Frame.Navigate(typeof(wallet), budgetbox.Text);
            
        }
        //else
        //{
        //    //this.Frame.Navigate(typeof(wallet), null);
        //}


        ////this.Frame.Navigate(typeof(wallet), null);
        //  DateTimeOffset sourceTime = dtpick.Date;
        //  budgetbox.Text = Convert.ToString(sourceTime);
    }
    }

