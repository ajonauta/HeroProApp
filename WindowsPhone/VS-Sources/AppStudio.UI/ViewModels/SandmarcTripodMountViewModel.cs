using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class SandmarcTripodMountViewModel : ViewModelBase<HtmlSchema>
    {
        override protected string CacheKey
        {
            get { return "SandmarcTripodMountDataSource"; }
        }

        override protected IDataSource<HtmlSchema> CreateDataSource()
        {
            return new SandmarcTripodMountDataSource(); // HtmlDataSource
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
