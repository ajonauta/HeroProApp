using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class EasyGimbalViewModel : ViewModelBase<HtmlSchema>
    {
        static private EasyGimbalViewModel _current = null;

        static public EasyGimbalViewModel Current
        {
            get { return _current ?? (_current = new EasyGimbalViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "EasyGimbalDataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new EasyGimbalDataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("Easy Gimbal", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "Easy Gimbal", "{Content}", "");
                });
            }
        }
}
}
