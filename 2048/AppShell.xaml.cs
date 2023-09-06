using _2048.Classes;
using System;
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace _2048
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AppShell : Page
    {
        public AppShell()
        {
            this.InitializeComponent();
            NavigationManager.GoBackHandler += GoBackCall;
            var view = ApplicationView.GetForCurrentView();
            view.TryEnterFullScreenMode();
        }

        private void GoBackCall(object sender, EventArgs e)
        {
            if (mainFrame.CanGoBack)
                mainFrame.GoBack();
            else CoreApplication.Exit();
        }

        private void mainFrame_Loaded(object sender, RoutedEventArgs e)
        {
            Frame frame = sender as Frame;
            frame.Navigate(typeof(MainPage));
        }
    }
}
