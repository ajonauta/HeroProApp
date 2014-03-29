using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GPAthleteTipsViewModel : ViewModelBase<YouTubeSchema>
    {
        static private GPAthleteTipsViewModel _current = null;

        static public GPAthleteTipsViewModel Current
        {
            get { return _current ?? (_current = new GPAthleteTipsViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "GPAthleteTipsDataSource"; }
        }

        protected override IDataSource<YouTubeSchema> CreateDataSource()
        {
            return new GPAthleteTipsDataSource(); // YouTubeDataSource
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
                    base.PinToStart("GPAthleteTipView", "{Title}", "{Summary}", "{ImageUrl}");
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
