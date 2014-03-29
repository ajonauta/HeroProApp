using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GoProTipsViewModel : ViewModelBase<YouTubeSchema>
    {
        static private GoProTipsViewModel _current = null;

        static public GoProTipsViewModel Current
        {
            get { return _current ?? (_current = new GoProTipsViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "GoProTipsDataSource"; }
        }

        protected override IDataSource<YouTubeSchema> CreateDataSource()
        {
            return new GoProTipsDataSource(); // YouTubeDataSource
        }

        protected override void NavigateToSelectedItem()
        {
            DisableSelectionNavigation();
            // Not implemented in current version
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("{Title}", "{Summary}", "{VideoUrl}", "{ImageUrl}");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("GPTipView", "{Title}", "{Summary}", "{ImageUrl}");
                });
            }
        }

        public ICommand GoToSourceCommand
        {
            get
            {
                return new RelayCommand<string>((str) =>
                {
                    base.GoToSource("{ExternalUrl}");
                });
            }
        }
}
}
