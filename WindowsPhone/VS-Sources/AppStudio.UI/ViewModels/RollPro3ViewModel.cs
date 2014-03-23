using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class RollPro3ViewModel : ViewModelBase<HtmlSchema>
    {
        override protected string CacheKey
        {
            get { return "RollPro3DataSource"; }
        }

        override protected IDataSource<HtmlSchema> CreateDataSource()
        {
            return new RollPro3DataSource(); // HtmlDataSource
        }

        override public bool IsStaticData
        {
            get { return true; }
        }

        override public ViewTypes ViewType
        {
            get { return ViewTypes.Detail; }
        }
    }
}
