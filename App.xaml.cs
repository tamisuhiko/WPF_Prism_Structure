using Helpers.Commons;
using Prism.Ioc;
using Prism.Mvvm;
using System.Windows;
using WPFStructure.Services;
using WPFStructure.UserControls.ViewModels;
using WPFStructure.UserControls.Views;
using WPFStructure.ViewModels;
using WPFStructure.Views;

namespace WPFStructure
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(SyncFuctionKeyGenerator.GenerateBase64LicenseKey());
            //Key for Syncfuction
        }
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            //Register for view
            containerRegistry.RegisterForNavigation<ContainerView, ContainerViewModel>();
            containerRegistry.RegisterForNavigation<HomeView,HomeViewModel>();
            containerRegistry.RegisterForNavigation<SettingView, SettingViewModel>();


            //Commons
            containerRegistry.RegisterSingleton<ISharedService, SharedService>();


            ViewModelLocationProvider.Register<DrawerNavigation, DrawerNavigationViewModel>();
        }
    }
}
