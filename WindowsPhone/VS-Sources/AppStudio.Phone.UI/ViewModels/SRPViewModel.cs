using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class SRPViewModel : ViewModelBase<HtmlSchema>
    {
        override protected string CacheKey
        {
            get { return "SRPDataSource"; }
        }

        override protected IDataSource<HtmlSchema> CreateDataSource()
        {
            return new SRPDataSource(); // HtmlDataSource
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
