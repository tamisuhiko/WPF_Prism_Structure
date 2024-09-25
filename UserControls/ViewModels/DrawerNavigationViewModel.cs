using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Regions;
using System.Windows.Input;
using System;
using System.Windows.Navigation;
using Prism.Commands;
using System.Windows;
using Prism.Ioc;
using WPFStructure.Commons;
using WPFStructure.Views;
using System.Windows.Controls;

namespace WPFStructure.UserControls.ViewModels
{
    public class DrawerNavigationViewModel : BindableBase
    {
        //Declaration
        private readonly IRegionManager _regionManager;
        private readonly IEventAggregator _eventAggregator;
        //1. Event Aggregator
        //2. Properties
        public ContentControl DrawerContentControl { get; set; }
        //3. Commands
        public DelegateCommand<string> NavigateCommand { get; private set; }

        public DrawerNavigationViewModel(
            IEventAggregator eventAggregator,
            IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;

            NavigateCommand = new DelegateCommand<string>(NavigateTo);

        }

        public void OnInitialized()
        {
            NavigateTo(WPFStructure.Commons.RegionViews.HomeView);
        }

        private void NavigateTo(string viewName)
        {
            string viewPath = "WPFStructure.Views." + viewName;
            Type viewType = Type.GetType(viewPath);

            if (viewType != null && DrawerContentControl.Content.GetType().Name.ToLower() != viewName.ToLower())
            {
                var viewInstance = Activator.CreateInstance(viewType) as UserControl;
                if (viewInstance != null)
                {
                    DrawerContentControl.Content = viewInstance;
                }
            }

        }
    }
}
