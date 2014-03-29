using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

using AppStudio.Data;
using AppStudio.Common;

namespace AppStudio
{
    public partial class GoProDIYView1
    {
        private NavigationHelper _navigationHelper;

        private GoProDIYViewModel _goProDIYViewModel = null;

        public GoProDIYView1()
        {
            InitializeComponent();
            _navigationHelper = new NavigationHelper(this);
            DataContext = GoProDIYViewModel;
        }

        public GoProDIYViewModel GoProDIYViewModel
        {
            get { return _goProDIYViewModel ?? (_goProDIYViewModel = GoProDIYViewModel.Current); }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this._navigationHelper; }
        }

        override protected async void OnNavigatedTo(NavigationEventArgs e)
        {
            await GoProDIYViewModel.LoadItems(true);
            DataContext = GoProDIYViewModel;
            base.OnNavigatedTo(e);
        }
    }
}
