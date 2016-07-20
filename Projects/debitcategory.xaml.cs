using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class debitcategory : Page
    {
        

        public debitcategory()
        {
            this.InitializeComponent();
        }

        private async void movies_Click(object sender, RoutedEventArgs d)
        {

            MessageDialog msgbox = new MessageDialog("Do you want to debit the money in Movies ?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                categorybox.Text = "Movies";
                this.Frame.Navigate(typeof(debit), categorybox.Text);
            }

            else if ((int)res.Id == 1)
            {
                categorybox.Text = "";

            }

            else
            {
            }

        }

        private async void health_Click(object sender, RoutedEventArgs s)
        {
            MessageDialog msgbox = new MessageDialog("Do you want to debit the money in Health ?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                categorybox.Text = "Health";
                this.Frame.Navigate(typeof(debit), categorybox.Text);
            }

            else if ((int)res.Id == 1)
            {
                categorybox.Text = "";

            }

            else
            {
            }
        }

        private async void house_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Do you want to debit the money in House ?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                categorybox.Text = "House";
                this.Frame.Navigate(typeof(debit), categorybox.Text);
            }

            else if ((int)res.Id == 1)
            {
                categorybox.Text = "";

            }

            else
            {
            }
        }

        private  async void food_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Do you want to debit the money in Food ?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                categorybox.Text = "Food";
                this.Frame.Navigate(typeof(debit), categorybox.Text);
            }

            else if ((int)res.Id == 1)
            {
                categorybox.Text = "";

            }

            else
            {
            }
        }

        private async void transport_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Do you want to debit the money in Transport ?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                categorybox.Text = "Transport";
                this.Frame.Navigate(typeof(debit), categorybox.Text);
            }

            else if ((int)res.Id == 1)
            {
                categorybox.Text = "";

            }

            else
            {
            }
        }

        private async void sports_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Do you want to debit the money in Sports?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                categorybox.Text = "Sports";
                this.Frame.Navigate(typeof(debit), categorybox.Text);
            }

            else if ((int)res.Id == 1)
            {
                categorybox.Text = "";

            }

            else
            {
            }
        }

        private async void bills_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Do you want to debit the money in Bills ?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                categorybox.Text = "Bills";
                this.Frame.Navigate(typeof(debit), categorybox.Text);
            }

            else if ((int)res.Id == 1)
            {
                categorybox.Text = "";

            }

            else
            {
            }
        }

        private async void shopping_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Do you want to debit the money in Shopping ?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                categorybox.Text = "Shopping";
                this.Frame.Navigate(typeof(debit), categorybox.Text);
            }

            else if ((int)res.Id == 1)
            {
                categorybox.Text = "";
             }

            else
            {
            }
        }

        private async void party_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Do you want to debit the money in Party ?", "My Wallet");
            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                categorybox.Text = "Party";
                this.Frame.Navigate(typeof(debit), categorybox.Text);
            }

            else if ((int)res.Id == 1)
            {
                categorybox.Text = "";

            }

            else
            {
            }
        }
    }
}
