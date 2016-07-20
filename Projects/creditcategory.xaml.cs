using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class creditcategory : Page
    {
        public creditcategory()
        {
            this.InitializeComponent();
        }

        private async void cash_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Do you want to add the Money as Cash ?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                creditcategorys.Text = "Cash";
                this.Frame.Navigate(typeof(credit), creditcategorys.Text);
            }

            else if ((int)res.Id == 1)
            {
                creditcategorys.Text = "";
            }

            else
            {
            }
        }

        private async void check_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Do you want to add the Money as Check ?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                creditcategorys.Text = "Check";
                this.Frame.Navigate(typeof(credit), creditcategorys.Text);
            }

            else if ((int)res.Id == 1)
            {
                creditcategorys.Text = "";
            }

            else
            {
            }
        }

        private async void creditcard_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Do you want to add the Money into Credit Card?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                creditcategorys.Text = "Credit Card / Debit Card";
                this.Frame.Navigate(typeof(credit), creditcategorys.Text);
            }

            else if ((int)res.Id == 1)
            {
                creditcategorys.Text = "";
            }

            else
            {
            }
        }

       
    }
}