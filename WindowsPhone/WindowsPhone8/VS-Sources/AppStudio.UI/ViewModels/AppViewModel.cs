using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class AppViewModel : ViewModelBase<HtmlSchema>
    {
        override protected string CacheKey
        {
            get { return "AppDataSource"; }
        }

        override protected IDataSource<HtmlSchema> CreateDataSource()
        {
            return new AppDataSource(); // HtmlDataSource
        }

        override public bool IsStaticData
        {
            get { return true; }
        }

        override public ViewTypes ViewType
        {
            get { return ViewTypes.Detail; }
        }

        override public bool IsPinToStartVisible
        {
            get { return ViewType == ViewTypes.Detail; }
        }

        override public void PinToStart()
        {
            base.PinToStart("MainPage", "App", "{Content}", "");
        }
    }
}
