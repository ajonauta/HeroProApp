using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GoProPhotosViewModel : ViewModelBase<FlickrSchema>
    {
        static private GoProPhotosViewModel _current = null;

        static public GoProPhotosViewModel Current
        {
            get { return _current ?? (_current = new GoProPhotosViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "GoProPhotosDataSource"; }
        }

        protected override IDataSource<FlickrSchema> CreateDataSource()
        {
            return new GoProPhotosDataSource(); // FlickrDataSource
        }

        protected override void NavigateToSelectedItem()
        {
            DisableSelectionNavigation();
            NavigationServices.NavigateToPage("GoProPhotosViewDetail");
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("{Title}", "{Summary}", "{ImageUrl}", "{ImageUrl}");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("GoProPhotosViewDetail", "{Title}", "{Summary}", "{ImageUrl}");
                });
            }
        }
}
}
