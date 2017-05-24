using KitchenApp.Models;
using KitchenApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace KitchenApp.Views
{
    public sealed partial class OrdersPageDetailPage : Page
    {
        public OrdersPageDetailViewModel ViewModel { get; } = new OrdersPageDetailViewModel();
        public OrdersPageDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel.Item = e.Parameter as SampleModel;
        }
    }
}
