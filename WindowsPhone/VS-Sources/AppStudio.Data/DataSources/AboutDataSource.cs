using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class AboutDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{e410c44e-ed8e-49f3-9a10-18a81d494d89}",
                Content = @"HeroProApp is developed by Konrad Iturbe<br><br><br><a rel=""nofollow"" target=""_blank"" href=""http://chernowii.com"">Go to Konrad's website</a>

<br><br><p>This app is Open Source! <a rel=""nofollow"" target=""_blank"" href=""http://github.com/konradit/heroproapp"">Github repo</a></p>"
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
