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
    public partial class GPAthleteTipView
    {
        private NavigationHelper _navigationHelper;

        private GPAthleteTipsViewModel _gPAthleteTipsViewModel = null;

        public GPAthleteTipView()
        {
            InitializeComponent();
            _navigationHelper = new NavigationHelper(this);
            DataContext = GPAthleteTipsViewModel;
        }

        public GPAthleteTipsViewModel GPAthleteTipsViewModel
        {
            get { return _gPAthleteTipsViewModel ?? (_gPAthleteTipsViewModel = GPAthleteTipsViewModel.Current); }
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
            await GPAthleteTipsViewModel.LoadItems(true);
            DataContext = GPAthleteTipsViewModel;
            base.OnNavigatedTo(e);
        }
    }
}
