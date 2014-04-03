using System;
using System.Windows;
using System.Windows.Input;

using AppStudio.Services;

namespace AppStudio.Data
{
    public class BRLSMountViewModel : ViewModelBase<HtmlSchema>
    {
        override protected string CacheKey
        {
            get { return "BRLSMountDataSource"; }
        }

        override protected IDataSource<HtmlSchema> CreateDataSource()
        {
            return new BRLSMountDataSource(); // HtmlDataSource
        }

        override public bool IsStaticData
        {
            get { return true; }
        }

        override public ViewTypes ViewType
        {
            get { return ViewTypes.Detail; }
        }

        override public bool IsShareItemVisible
        {
            get { return ViewType == ViewTypes.Detail; }
        }
        
        override public void ShareItem()
        {
            base.ShareItem("BRLS Mount", "{Content}", "", "");
        }
    }
}
