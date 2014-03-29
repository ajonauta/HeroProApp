using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class TheBobberViewModel : ViewModelBase<HtmlSchema>
    {
        static private TheBobberViewModel _current = null;

        static public TheBobberViewModel Current
        {
            get { return _current ?? (_current = new TheBobberViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "TheBobberDataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new TheBobberDataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("The Bobber", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "The Bobber", "{Content}", "");
                });
            }
        }
}
}
