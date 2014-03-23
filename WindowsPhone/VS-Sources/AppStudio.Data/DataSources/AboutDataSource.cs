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
                Id = "{1f299339-4ede-4a6d-a770-bea787885b36}",
                Content = @"HeroProApp has been developed by Konrad Iturbe
<p><a rel=""nofollow"" target=""_blank"" href=""http://chernowii.com"">Visit website</a></p>
<p><a href=""mail@chernowii.com"">Mail me</a></p>
<p><a rel=""nofollow"" target=""_blank"" href=""http://github.com/konradit/heroproapp"">View GitHub repo of HeroProApp</a></p>"
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
