using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

using AppStudio.Data;

namespace AppStudio
{
    public sealed partial class MainPage
    {
        private bool _isLoadingData = false;

        public MainPage()
        {
            InitializeComponent();
            DataContext = this;
        }

 
        public AppViewModel AppViewModel
        {
            get { return AppViewModel.Current; }
        }
 
        public GoProVODViewModel GoProVODViewModel
        {
            get { return GoProVODViewModel.Current; }
        }
 
        public GPTipsTricksViewModel GPTipsTricksViewModel
        {
            get { return GPTipsTricksViewModel.Current; }
        }
 
        public GoProPhotosViewModel GoProPhotosViewModel
        {
            get { return GoProPhotosViewModel.Current; }
        }
 
        public GoProMountsViewModel GoProMountsViewModel
        {
            get { return GoProMountsViewModel.Current; }
        }
 
        public AboutViewModel AboutViewModel
        {
            get { return AboutViewModel.Current; }
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            AppLogs.WriteInfo("OnNavigatedTo", e.NavigationMode.ToString());

            _isLoadingData = true;
            ShowProgressBarOnTimeElapsed();
            await EnsureDataLoaded();
            _isLoadingData = false;
            progressBar.Visibility = Visibility.Collapsed;

            EnableSelectionNavigation();

            //ReadLogs();
        }

        private async Task EnsureDataLoaded()
        {
            bool isNetworkAvailable = NetworkInterface.GetIsNetworkAvailable();

            var loadTasks = new Task[] {
                AppViewModel.LoadItems(isNetworkAvailable),
                GoProVODViewModel.LoadItems(isNetworkAvailable),
                GPTipsTricksViewModel.LoadItems(isNetworkAvailable),
                GoProPhotosViewModel.LoadItems(isNetworkAvailable),
                GoProMountsViewModel.LoadItems(isNetworkAvailable),
                AboutViewModel.LoadItems(isNetworkAvailable),
            };
            await Task.WhenAll(loadTasks);
        }

        private void EnableSelectionNavigation()
        {
            AppViewModel.EnableSelectionNavigation();
            GoProVODViewModel.EnableSelectionNavigation();
            GPTipsTricksViewModel.EnableSelectionNavigation();
            GoProPhotosViewModel.EnableSelectionNavigation();
            GoProMountsViewModel.EnableSelectionNavigation();
            AboutViewModel.EnableSelectionNavigation();
        }

        private void ShowProgressBarOnTimeElapsed()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += OnTimeElapsed;
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Start();
        }

        private void OnTimeElapsed(object sender, object e)
        {
            DispatcherTimer timer = sender as DispatcherTimer;
            timer.Stop();
            timer.Tick -= OnTimeElapsed;
            if (_isLoadingData)
            {
                progressBar.Visibility = Visibility.Visible;
            }
        }
    }
}
