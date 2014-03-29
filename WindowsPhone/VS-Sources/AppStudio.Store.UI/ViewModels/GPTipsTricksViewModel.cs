using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GPTipsTricksViewModel : ViewModelBase<MenuSchema>
    {
        static private GPTipsTricksViewModel _current = null;

        static public GPTipsTricksViewModel Current
        {
            get { return _current ?? (_current = new GPTipsTricksViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "GPTipsTricksDataSource"; }
        }

        protected override IDataSource<MenuSchema> CreateDataSource()
        {
            return new GPTipsTricksDataSource(); // MenuDataSource
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
