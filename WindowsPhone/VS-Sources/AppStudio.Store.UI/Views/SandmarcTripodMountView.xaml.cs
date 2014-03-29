using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

using AppStudio.Data;
using AppStudio.Common;

namespace AppStudio
{
    public sealed partial class SandmarcTripodMountView
    {
        private NavigationHelper _navigationHelper;

        private bool _isLoadingData = false;

        public SandmarcTripodMountView()
        {
            InitializeComponent();
            _navigationHelper = new NavigationHelper(this);
            DataContext = this;
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this._navigationHelper; }
        }

 
        public SandmarcTripodMountViewModel SandmarcTripodMountViewModel
        {
            get { return SandmarcTripodMountViewModel.Current; }
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
                SandmarcTripodMountViewModel.LoadItems(isNetworkAvailable),
            };
            await Task.WhenAll(loadTasks);
        }

        private void EnableSelectionNavigation()
        {
            SandmarcTripodMountViewModel.EnableSelectionNavigation();
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
