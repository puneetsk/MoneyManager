using System;
using System.Collections.Generic;
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


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Projects
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
       
        }



        private async void loginButton_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder usernameFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            //StorageFile newFile = await usernameFolder.CreateFileAsync("Login.txt", CreationCollisionOption.OpenIfExists);
            //await FileIO.WriteTextAsync(newFile, susername.Text);


            StorageFolder passwordFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            //StorageFile newFile1 = await password.CreateFileAsync("Password.txt", CreationCollisionOption.OpenIfExists);
            //await FileIO.WriteTextAsync(newFile1, spassword.Text);


            var file = await usernameFolder.GetFileAsync("Login.txt");
            var usernamed = await Windows.Storage.FileIO.ReadTextAsync(file);



            var file1 = await usernameFolder.GetFileAsync("Password.txt");
            var passwords = await Windows.Storage.FileIO.ReadTextAsync(file1);

            if (usernamed == username.Text && passwords == password.Text)
            {
                this.Frame.Navigate(typeof(wallet), null);
            }

            else
            {
                MessageDialog msgbox = new MessageDialog("Wrong Password", "My Wallet");
                msgbox.Commands.Clear();
                var res = await msgbox.ShowAsync();
            }


        }
        private void signup_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(signup), null);
        }
    }
}
