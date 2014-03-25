using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class TheBobberDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{4f2e4fa9-9098-42cf-a4de-d43e64426797}",
                Content = "This yellow tube does much more than you think, shoot yourself surfing&nbsp;those" +
    " crystal water blue&nbsp;waves or shoot the snow hitting your face.<br><br><br><" +
    "a href=\"http://gopole.com/products/the-bobber\">Go to the bobber page</a>"
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
