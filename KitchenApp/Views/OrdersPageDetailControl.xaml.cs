using KitchenApp.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KitchenApp.Views
{
    public sealed partial class OrdersPageDetailControl : UserControl
    {
        public SampleModel MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleModel; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem",typeof(SampleModel),typeof(OrdersPageDetailControl),new PropertyMetadata(null));

        public OrdersPageDetailControl()
        {
            InitializeComponent();
        }
    }
}
