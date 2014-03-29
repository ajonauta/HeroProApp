using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class AppViewModel : ViewModelBase<HtmlSchema>
    {
        static private AppViewModel _current = null;

        static public AppViewModel Current
        {
            get { return _current ?? (_current = new AppViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "AppDataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new AppDataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("App", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "App", "{Content}", "");
                });
            }
        }
}
}
