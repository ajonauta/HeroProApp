using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class RollPro3DataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{0a2cf6f6-fa62-4214-a1ce-3d86ca609e94}",
                Content = "The RollPro3 is a bag to store all your gopro mounts and gopro camera(s).&nbsp;<b" +
    "r><br><a href=\"http://riseful.com\">Go to Riseful.com</a>"
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
