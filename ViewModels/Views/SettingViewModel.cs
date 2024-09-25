using Prism.Mvvm;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;
using WPFStructure.Commons;

namespace WPFStructure.ViewModels
{
    public class SettingViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private string _title = "Syncfusion Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public SettingViewModel(IRegionManager regionManager)
        {
            Initialize();
        }

        private void Initialize()
        {
        }
    }
}
