using System;
using System.Windows.Input;

using KitchenApp.Helpers;
using KitchenApp.Models;
using KitchenApp.Services;

using Windows.UI.Xaml;

namespace KitchenApp.ViewModels
{
    public class OrdersPageDetailViewModel : Observable
    {
        const string NarrowStateName = "NarrowState";
        const string WideStateName = "WideState";

        public ICommand StateChangedCommand { get; private set; }

        private SampleModel _item;
        public SampleModel Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public OrdersPageDetailViewModel()
        {
            StateChangedCommand = new RelayCommand<VisualStateChangedEventArgs>(OnStateChanged);
        }
        
        private void OnStateChanged(VisualStateChangedEventArgs args)
        {
            if (args.OldState.Name == NarrowStateName && args.NewState.Name == WideStateName)
            {
                NavigationService.GoBack();
            }
        }
    }
}
