using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class GoFlexArmDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{440b2fd2-f639-4223-90fa-f40c60feaa29}",
                Content = "The GoFlex-Arm allows you to maneuver your gopro to the best position<br><br><a r" +
    "el=\"nofollow\" target=\"_blank\" href=\"http://go-mount.com\">Go to go-mount.com</a>"
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
