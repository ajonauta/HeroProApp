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
                Id = "{2cbb4556-49b2-43bd-bf90-7e8b215ff89b}",
                Content = @"HeroProApp has been developed by Konrad Iturbe
<p><a rel=""nofollow"" target=""_blank"" href=""http://chernowii.com"">Visit website</a></p>
<p><a rel=""nofollow"" target=""_blank"" href=""mailto:mail@chernowii.com>Contact Konrad</a></p>
<p><a href=""http://github.com/konradit/heroproapp"" target=""_blank"">View GitHub repo of HeroProApp</p>"
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
