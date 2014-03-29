using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GoProVODViewModel : ViewModelBase<YouTubeSchema>
    {
        static private GoProVODViewModel _current = null;

        static public GoProVODViewModel Current
        {
            get { return _current ?? (_current = new GoProVODViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "GoProVODDataSource"; }
        }

        protected override IDataSource<YouTubeSchema> CreateDataSource()
        {
            return new GoProVODDataSource(); // YouTubeDataSource
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
                    base.PinToStart("VideoView", "{Title}", "{Summary}", "{ImageUrl}");
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
