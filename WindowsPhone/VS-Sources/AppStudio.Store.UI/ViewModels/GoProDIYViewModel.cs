using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GoProDIYViewModel : ViewModelBase<YouTubeSchema>
    {
        static private GoProDIYViewModel _current = null;

        static public GoProDIYViewModel Current
        {
            get { return _current ?? (_current = new GoProDIYViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "GoProDIYDataSource"; }
        }

        protected override IDataSource<YouTubeSchema> CreateDataSource()
        {
            return new GoProDIYDataSource(); // YouTubeDataSource
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
                    base.PinToStart("GoProDIYView1", "{Title}", "{Summary}", "{ImageUrl}");
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
