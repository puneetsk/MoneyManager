using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
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
    public sealed partial class signup : Page
    {
        public signup()
        {
            this.InitializeComponent();
        }

        public object MessageBox { get; private set; }

        private void sloginButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private async void ssignup_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(susername.Text.Trim(), @"^[A-Za-z_][a-zA-Z0-9_\s]*$"))
            {
                MessageDialog msgbox = new MessageDialog("Enter Valid Inputs", "My Wallet");
                msgbox.Commands.Clear();
                var res = await msgbox.ShowAsync();
            }
            else
            {

                StorageFolder usernameFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                StorageFile newFile = await usernameFolder.CreateFileAsync("Login.txt", CreationCollisionOption.OpenIfExists);
                await FileIO.WriteTextAsync(newFile, susername.Text);


                StorageFolder passwordFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                StorageFile newFile1 = await passwordFolder.CreateFileAsync("Password.txt", CreationCollisionOption.OpenIfExists);
                await FileIO.WriteTextAsync(newFile1, spassword.Text);
                this.Frame.Navigate(typeof(MainPage), null);

            }


        }
    }
}
