using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GoProMountsViewModel : ViewModelBase<MenuSchema>
    {
        static private GoProMountsViewModel _current = null;

        static public GoProMountsViewModel Current
        {
            get { return _current ?? (_current = new GoProMountsViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "GoProMountsDataSource"; }
        }

        protected override IDataSource<MenuSchema> CreateDataSource()
        {
            return new GoProMountsDataSource(); // MenuDataSource
        }

        protected override void NavigateToSelectedItem()
        {
            DisableSelectionNavigation();
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

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("", "", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "", "", "");
                });
            }
        }
}
}
