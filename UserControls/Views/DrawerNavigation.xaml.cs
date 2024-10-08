﻿using Prism.Regions;
using Syncfusion.UI.Xaml.NavigationDrawer;
using Syncfusion.Windows.Shared;
using System.Windows;
using System.Windows.Controls;
using WPFStructure.UserControls.ViewModels;
using WPFStructure.ViewModels;

namespace WPFStructure.UserControls.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DrawerNavigation : UserControl
    {
        public DrawerNavigation()
        {
            InitializeComponent();
            Loaded += OnInitialized;
        }

        private void OnInitialized(object sender, RoutedEventArgs e)
        {
            if (DataContext is DrawerNavigationViewModel viewModel)
            {
                viewModel.DrawerContentControl = _drawerContent;
                viewModel.OnInitialized();
            }
        }
    }
}
