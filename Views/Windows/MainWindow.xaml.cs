using Prism.Events;
using Prism.Regions;
using Syncfusion.Windows.Shared;
using System.Windows;
using WPFStructure.ViewModels;

namespace WPFStructure.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += OnInitialized;

        }

        private void OnInitialized(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainWindowViewModel viewModel)
            {
                viewModel.OnInitialized();
            }
        }

    }
}
