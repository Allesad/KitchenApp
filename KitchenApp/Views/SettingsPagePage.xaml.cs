using KitchenApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace KitchenApp.Views
{
    public sealed partial class SettingsPagePage : Page
    {
        public SettingsPageViewModel ViewModel { get; } = new SettingsPageViewModel();
        // TODO UWPTemplates: Setup your privacy web in your Resource File, currently set to https://YourPrivacyUrlGoesHere

        public SettingsPagePage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.Initialize();
        }
    }
}
