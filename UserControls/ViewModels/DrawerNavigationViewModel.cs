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

            NavigateCommand = new DelegateCommand<string>(OnNavigate);

        }

        public void OnInitialized()
        {
            _regionManager.RequestNavigate("DrawerNavigation", RegionNames.Views.HomeView);
        }

        private void OnNavigate(string viewName)
        {
            string viewPath = "WPFStructure.Views." + viewName; // Tên đầy đủ của View
            Type viewType = Type.GetType(viewPath);

            if (viewType != null)
            {
                var viewInstance = Activator.CreateInstance(viewType) as UserControl;
                if (viewInstance != null)
                {
                    // Giả sử bạn có một Grid hoặc ContentControl để chứa View này
                    DrawerContentControl.Content = viewInstance;
                }
            }
            else
            {
                MessageBox.Show("View not found.");
            }

        }
    }
}
