using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class OriginalHandleViewModel : ViewModelBase<HtmlSchema>
    {
        static private OriginalHandleViewModel _current = null;

        static public OriginalHandleViewModel Current
        {
            get { return _current ?? (_current = new OriginalHandleViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "OriginalHandleDataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new OriginalHandleDataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("Original Handle", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "Original Handle", "{Content}", "");
                });
            }
        }
}
}
