using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class AppDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{7c87ea95-75d1-4703-8a05-e46453301fca}",
                Content = @"Make sure you are connected to the GoPro Wifi and you have 3G/4G
<br><br>HeroProApp works on the browser.
<br><br><a rel=""nofollow"" target=""_blank"" href=""http://m.heropro.chernowii.com""><span class=""wysiwyg-font-size-larger"">Go to HeroProApp in Browser</span></a>"
            }
        };

        public async Task<IEnumerable<HtmlSchema>> LoadData()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }

        public async Task<IEnumerable<HtmlSchema>> Refresh()
        {
            return await LoadData();
        }
    }
}
