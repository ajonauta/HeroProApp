using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class RollPro3ViewModel : ViewModelBase<HtmlSchema>
    {
        static private RollPro3ViewModel _current = null;

        static public RollPro3ViewModel Current
        {
            get { return _current ?? (_current = new RollPro3ViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "RollPro3DataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new RollPro3DataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("RollPro 3 ", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "RollPro 3 ", "{Content}", "");
                });
            }
        }
}
}
