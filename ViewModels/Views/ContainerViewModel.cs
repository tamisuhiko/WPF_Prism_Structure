using Prism.Mvvm;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;
using WPFStructure.Commons;

namespace WPFStructure.ViewModels
{
    public class ContainerViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        public ContainerViewModel(IRegionManager regionManager)
        {
            Initialize();
        }

        private void Initialize()
        {
        }
    }
}
