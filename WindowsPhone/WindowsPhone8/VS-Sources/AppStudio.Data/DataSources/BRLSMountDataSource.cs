using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class BRLSMountDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{f41fa911-8c3f-44b8-af29-d438e903d41c}",
                Content = "The BRLS mount is a suction cup that allows users to mount it on cars and surfboa" +
    "rds<br><br><br><a rel=\"nofollow\" target=\"_blank\" href=\"http://brlshawaii.com\">br" +
    "lshawaii.com</a>"
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
