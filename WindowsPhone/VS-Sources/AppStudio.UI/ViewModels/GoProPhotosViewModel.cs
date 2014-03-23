using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GoProPhotosViewModel : ViewModelBase<FlickrSchema>
    {
        override protected string CacheKey
        {
            get { return "GoProPhotosDataSource"; }
        }

        override protected IDataSource<FlickrSchema> CreateDataSource()
        {
            return new GoProPhotosDataSource(); // FlickrDataSource
        }

        override public bool IsRefreshVisible
        {
            get { return ViewType == ViewTypes.List; }
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("GoProPhotosViewDetail");
        }
    }
}
