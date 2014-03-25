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
                Id = "{c7dc811b-cbf3-4bba-afd8-73ae0dd9e5f5}",
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
