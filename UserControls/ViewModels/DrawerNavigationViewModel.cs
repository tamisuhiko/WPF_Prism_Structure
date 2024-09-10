using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Regions;
using System.Windows.Input;
using System;
using System.Windows.Navigation;
using Prism.Commands;

namespace WPFStructure.UserControls.ViewModels
{
    public class DrawerNavigationViewModel : BindableBase
    {
        //Declaration
        private readonly IRegionManager _regionManager;
        private readonly IEventAggregator _eventAggregator;
        //1. Event Aggregator
        //2. Properties
        //3. Commands
        public DelegateCommand<object[]> SelectedCommand { get; private set; }
        public DelegateCommand<string> NavigateCommand;
      
        public DrawerNavigationViewModel(
            IEventAggregator eventAggregator,
            IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;

            NavigateCommand = new DelegateCommand<string>(OnNavigate);


        }

        private void OnNavigate(string viewname)
        {
            if (!string.IsNullOrEmpty(viewname)) {
                _regionManager.RequestNavigate("MainView" , viewname, new NavigationParameters());
            }
        }
    }
}
