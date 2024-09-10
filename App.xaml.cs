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
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowViewModel>();


            containerRegistry.RegisterSingleton<ISharedService, SharedService>();


            ViewModelLocationProvider.Register<DrawerNavigation, DrawerNavigationViewModel>();
        }
    }
}
