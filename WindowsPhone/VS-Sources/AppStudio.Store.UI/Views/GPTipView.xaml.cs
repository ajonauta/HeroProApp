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
    public partial class GPTipView
    {
        private NavigationHelper _navigationHelper;

        private GoProTipsViewModel _goProTipsViewModel = null;

        public GPTipView()
        {
            InitializeComponent();
            _navigationHelper = new NavigationHelper(this);
            DataContext = GoProTipsViewModel;
        }

        public GoProTipsViewModel GoProTipsViewModel
        {
            get { return _goProTipsViewModel ?? (_goProTipsViewModel = GoProTipsViewModel.Current); }
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
            await GoProTipsViewModel.LoadItems(true);
            DataContext = GoProTipsViewModel;
            base.OnNavigatedTo(e);
        }
    }
}
