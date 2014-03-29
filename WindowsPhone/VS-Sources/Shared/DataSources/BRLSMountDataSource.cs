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
                Id = "{8a726929-6379-4afc-81e2-20fe88c1cc73}",
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
