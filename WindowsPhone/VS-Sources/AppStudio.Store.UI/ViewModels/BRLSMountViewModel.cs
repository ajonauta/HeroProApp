using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class BRLSMountViewModel : ViewModelBase<HtmlSchema>
    {
        static private BRLSMountViewModel _current = null;

        static public BRLSMountViewModel Current
        {
            get { return _current ?? (_current = new BRLSMountViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "BRLSMountDataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new BRLSMountDataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("BRLS Mount", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "BRLS Mount", "{Content}", "");
                });
            }
        }
}
}
