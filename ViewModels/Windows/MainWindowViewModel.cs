using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;
using WPFStructure.Commons;
using WPFStructure.Views;

namespace WPFStructure.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand ABC { get; private set; }

        private readonly IRegionManager _regionManager;
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager=regionManager;
        }

        public void OnInitialized()
        {

        }
    }
}
