using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class SRPViewModel : ViewModelBase<HtmlSchema>
    {
        static private SRPViewModel _current = null;

        static public SRPViewModel Current
        {
            get { return _current ?? (_current = new SRPViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "SRPDataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new SRPDataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("SRP", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "SRP", "{Content}", "");
                });
            }
        }
}
}
