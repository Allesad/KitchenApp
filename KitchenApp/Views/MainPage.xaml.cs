using KitchenApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace KitchenApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
