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
    public partial class VideoView
    {
        private NavigationHelper _navigationHelper;

        private GoProVODViewModel _goProVODViewModel = null;

        public VideoView()
        {
            InitializeComponent();
            _navigationHelper = new NavigationHelper(this);
            DataContext = GoProVODViewModel;
        }

        public GoProVODViewModel GoProVODViewModel
        {
            get { return _goProVODViewModel ?? (_goProVODViewModel = GoProVODViewModel.Current); }
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
            await GoProVODViewModel.LoadItems(true);
            DataContext = GoProVODViewModel;
            base.OnNavigatedTo(e);
        }
    }
}
