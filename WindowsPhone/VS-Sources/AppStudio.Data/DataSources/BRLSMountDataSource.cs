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
                Id = "{55bfce2a-67c7-4ba6-b4d2-0d0f602dbbb2}",
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
