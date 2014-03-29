using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class SandmarcTripodMountViewModel : ViewModelBase<HtmlSchema>
    {
        static private SandmarcTripodMountViewModel _current = null;

        static public SandmarcTripodMountViewModel Current
        {
            get { return _current ?? (_current = new SandmarcTripodMountViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "SandmarcTripodMountDataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new SandmarcTripodMountDataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("Sandmarc Tripod Mount", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "Sandmarc Tripod Mount", "{Content}", "");
                });
            }
        }
}
}
