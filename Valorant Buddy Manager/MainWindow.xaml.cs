using System.Threading.Tasks;
using System.Windows;
using ValAPINet;

namespace ValorantCardandTitleChanger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Auth auth = Websocket.GetAuthLocal(false);
            if (auth != null)
            {
                IgnTextBlock.Text = $"Logged In As: {Username.GetUsername(auth)}";
            }
        }

        private async void LoginClick(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Login");
            var authTask = Task.Run(() => Websocket.GetAuthLocal(false));
            var auth = await authTask;
            if (auth != null)
            {
                var usernameTask = Task.Run(() => Username.GetUsername(auth));
                var username = await usernameTask;
                IgnTextBlock.Text = $"Logged In As: {username.GameName + "#" + username.TagLine}";
            }
            else
            {
                IgnTextBlock.Text = "Valorant Not Detected";
            }
        }

        private async void SaveClick(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Saved");

        }

        private async void ResetClick(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Reset");

        }
    }
}
