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
                Id = "{f1f591ca-97be-42f6-bbe0-3d65f510ed4c}",
                Content = "Make sure you are connected to the GoPro Wifi and you have 3G/4G\nHeroProApp works" +
    " on the browser.\n<br><br><a rel=\"nofollow\" target=\"_blank\" style=\"color:red\" hre" +
    "f=\"http://m.heropro.chernowii.com\"><big>Go to HeroProApp in Browser</big></a>"
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
