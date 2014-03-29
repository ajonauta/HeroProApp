using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class PolarProViewModel : ViewModelBase<HtmlSchema>
    {
        static private PolarProViewModel _current = null;

        static public PolarProViewModel Current
        {
            get { return _current ?? (_current = new PolarProViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "PolarProDataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new PolarProDataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("PolarPro", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "PolarPro", "{Content}", "");
                });
            }
        }
}
}
