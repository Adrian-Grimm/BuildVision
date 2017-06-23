﻿using BuildVision.UI.Settings;
using BuildVision.UI.ViewModels;
using System.Windows;

namespace BuildVision.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var controlViewModel = new ControlViewModel();
            ControlView.DataContext = controlViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var settingsWindow = new SettingsWindow(new BuildMessagesSettingsControl());
            settingsWindow.ShowDialog();
        }
    }
}