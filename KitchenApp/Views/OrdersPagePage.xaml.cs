using KitchenApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace KitchenApp.Views
{
    public sealed partial class OrdersPagePage : Page
    {
        public OrdersPageViewModel ViewModel { get; } = new OrdersPageViewModel();
        public OrdersPagePage()
        {
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await ViewModel.LoadDataAsync(WindowStates.CurrentState);
        }
    }
}
