using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using KitchenApp.Helpers;
using KitchenApp.Models;
using KitchenApp.Services;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KitchenApp.ViewModels
{
    public class OrdersPageViewModel : Observable
    {
        const string NarrowStateName = "NarrowState";
        const string WideStateName = "WideState";

        private VisualState _currentState;

        private SampleModel _selected;
        public SampleModel Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ICommand ItemClickCommand { get; private set; }
        public ICommand StateChangedCommand { get; private set; }

        public ObservableCollection<SampleModel> SampleItems { get; private set; } = new ObservableCollection<SampleModel>();

        public OrdersPageViewModel()
        {
            ItemClickCommand = new RelayCommand<ItemClickEventArgs>(OnItemClick);
            StateChangedCommand = new RelayCommand<VisualStateChangedEventArgs>(OnStateChanged);
        }

        public async Task LoadDataAsync(VisualState currentState)
        {
            _currentState = currentState;
            SampleItems.Clear();

            var service = new SampleModelService();
            var data = await service.GetDataAsync();

            foreach (var item in data)
            {
                SampleItems.Add(item);
            }
            Selected = SampleItems.First();
        }

        private void OnStateChanged(VisualStateChangedEventArgs args)
        {
            _currentState = args.NewState;
        }

        private void OnItemClick(ItemClickEventArgs args)
        {
            SampleModel item = args?.ClickedItem as SampleModel;
            if (item != null)
            {
                if (_currentState.Name == NarrowStateName)
                {
                    NavigationService.Navigate<Views.OrdersPageDetailPage>(item);
                }
                else
                {
                    Selected = item;
                }
            }
        }
    }
}
