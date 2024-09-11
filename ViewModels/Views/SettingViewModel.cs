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
        public SettingViewModel(IRegionManager regionManager)
        {
            Initialize();
        }

        private void Initialize()
        {
        }
    }
}
