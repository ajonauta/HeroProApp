using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class DJIPhantomViewModel : ViewModelBase<HtmlSchema>
    {
        static private DJIPhantomViewModel _current = null;

        static public DJIPhantomViewModel Current
        {
            get { return _current ?? (_current = new DJIPhantomViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "DJIPhantomDataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new DJIPhantomDataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("DJI Phantom", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "DJI Phantom", "{Content}", "");
                });
            }
        }
}
}
