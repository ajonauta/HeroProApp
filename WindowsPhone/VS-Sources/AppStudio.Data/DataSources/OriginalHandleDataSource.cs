using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class OriginalHandleDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{18d78e78-ba52-4aae-9a0f-50dcb2d64e7a}",
                Content = "Do you skate? Do you like gopro\'s skate videos, where there are low angle&nbsp;sm" +
    "ooth shots of the skater. They use this mount, the Original Handle.<br><br><a hr" +
    "ef=\"http://originalhandle.com\">OriginalHandle.com\"</a>"
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
