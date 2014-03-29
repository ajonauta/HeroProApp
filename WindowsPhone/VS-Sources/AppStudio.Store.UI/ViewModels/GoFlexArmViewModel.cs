using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class GoFlexArmViewModel : ViewModelBase<HtmlSchema>
    {
        static private GoFlexArmViewModel _current = null;

        static public GoFlexArmViewModel Current
        {
            get { return _current ?? (_current = new GoFlexArmViewModel()); }
        }

        protected override string CacheKey
        {
            get { return "GoFlexArmDataSource"; }
        }

        protected override IDataSource<HtmlSchema> CreateDataSource()
        {
            return new GoFlexArmDataSource(); // HtmlDataSource
        }

        public ICommand ShareTextCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.ShareItem("GoFlex-Arm", "{Content}", "", "");
                });
            }
        }

        public ICommand PinToStartCommand
        {
            get
            {
                return new RelayCommand<string>((fields) =>
                {
                    base.PinToStart("", "GoFlex-Arm", "{Content}", "");
                });
            }
        }
}
}
