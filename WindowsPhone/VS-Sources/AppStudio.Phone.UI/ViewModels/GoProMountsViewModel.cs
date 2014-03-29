using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GoProMountsViewModel : ViewModelBase<MenuSchema>
    {
        override protected string CacheKey
        {
            get { return "GoProMountsDataSource"; }
        }

        override protected IDataSource<MenuSchema> CreateDataSource()
        {
            return new GoProMountsDataSource(); // MenuDataSource
        }

        override public bool IsStaticData
        {
            get { return true; }
        }

        override public bool IsShareItemVisible
        {
            get { return ViewType == ViewTypes.Detail; }
        }
        
        override public void ShareItem()
        {
            base.ShareItem("", "", "", "");
        }

        override protected void NavigateToSelectedItem()
        {
            var currentItem = GetCurrentItem();
            if (currentItem != null)
            {
                if (currentItem.GetValue("Type").EqualNoCase("Section"))
                {
                    NavigationServices.NavigateToPage(currentItem.GetValue("Target"));
                }
                else
                {
                    NavigationServices.NavigateTo(new Uri(currentItem.GetValue("Target"), UriKind.Absolute));
                }
            }
        }
    }
}
