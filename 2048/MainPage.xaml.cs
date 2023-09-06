using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _2048
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

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            switch((sender as AppBarButton).Tag)
            {
                case "Help":
                    Frame.Navigate(typeof(Pages.HelpPage));
                    break;
                case "About":
                    Frame.Navigate(typeof(Pages.AboutPage));
                    break;
            }
        }
    }
}
