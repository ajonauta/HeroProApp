using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GoProFacebookViewModel : ViewModelBase<FacebookSchema>
    {
        override protected string CacheKey
        {
            get { return "GoProFacebookDataSource"; }
        }

        override protected IDataSource<FacebookSchema> CreateDataSource()
        {
            return new GoProFacebookDataSource(); // FacebookDataSource
        }

        override public bool IsShareItemVisible
        {
            get { return ViewType == ViewTypes.Detail; }
        }
        
        override public void ShareItem()
        {
            base.ShareItem();
        }

        override public bool IsRefreshVisible
        {
            get { return ViewType == ViewTypes.List; }
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("GoProFacebookDetail");
        }
    }
}
