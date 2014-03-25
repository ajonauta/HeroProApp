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
                Id = "{b5cb57d4-b4dd-44db-a327-aa260ca32402}",
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
