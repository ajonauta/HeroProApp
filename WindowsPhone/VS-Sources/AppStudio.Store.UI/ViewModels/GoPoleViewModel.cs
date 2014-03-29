using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GoPoleViewModel : ViewModelBase<HtmlSchema>
    {
        static private GoPoleViewModel _current = null;

        static public GoPoleViewModel Current
        {
            get { return _current ?? (_current = new GoPoleViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "GoPoleDataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new GoPoleDataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("GoPole", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "GoPole", "{Content}", "");
                });
            }
        }
}
}
