using Prism.Mvvm;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;
using WPFStructure.Commons;

namespace WPFStructure.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly IRegionManager _regionManager;
        public HomeViewModel(IRegionManager regionManager)
        {
            Initialize();
        }

        private void Initialize()
        {
        }
    }
}
